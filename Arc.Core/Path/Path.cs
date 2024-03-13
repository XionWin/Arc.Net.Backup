using Extension;

namespace Arc.Core;

public class Path: IShape<Primitive>
{
    public Context Context { get; init; }
    
    public List<Segment> Segments { get; } = new List<Segment>();
    public Segment? LastSegment => this.Segments.LastOrDefault();
    public int Count => this.Segments.Count;
    
    private State? _state = null;
    public State State => this._state ?? throw new Exception("Unexpected");

    public Rect Bounds { get; private set; }

    internal Path(Context context)
    {
        this.Context = context;
    }

    public void AddCommand(Command command)
    {
        if(command.CommandType == CommandType.MoveTo)
        {
            this.Segments.Add(new Segment(this));
        }
        if(this.Segments.LastOrDefault() is Segment segment && segment.IsClosed is false)
        {
            if(command.CommandType == CommandType.Close)
            {
                segment.IsClosed = true;
            }
            else
            {
                segment.AddPoints(this.GetPoints(command));
            }
        }
        else
        {
            throw new Exception("Can't find the last path");
        }
    }

    public Primitive Stroke() =>
        new Primitive(
            this
            .With(x => this._state = this.Context.GetState().Clone())
            .Segments.Select(x => x.Stroke()).ToArray(),
            this.State
        );
}

public static class PathExtension
{
    internal static Point[] GetPoints(this Path path, Command command) =>
        command.CommandType switch
        {
            CommandType.MoveTo => [new Point(command.Values[0], command.Values[1], PointFlags.Corner)],
            CommandType.LineTo => [new Point(command.Values[0], command.Values[1], PointFlags.Corner)],
            CommandType.BezierTo => path.LastSegment?.LastEditPoint is Point lastPoint ? GetBezierPoints(
                lastPoint.X, lastPoint.Y,
                command.Values[0], command.Values[1],
                command.Values[2], command.Values[3],
                command.Values[4], command.Values[5],
                path.Context.TessTol,
                PointFlags.Corner
            ).ToArray()
            :throw new Exception("Unexpected"),
            _ => throw new NotImplementedException()
        };

    
    const float KAPPA90 = 0.5522847493f;
    internal static void AddEllipse(this Path path, float cx, float cy, float rx, float ry)
    {
        path.AddCommand(new Command(CommandType.MoveTo, cx + rx, cy));
        path.AddCommand(new Command(CommandType.BezierTo,
                                    cx + rx, cy + ry * KAPPA90,
                                    cx + rx * KAPPA90, cy + ry,
                                    cx, cy + ry));
        path.AddCommand(new Command(CommandType.BezierTo,
                                    cx - rx * KAPPA90, cy + ry,
                                    cx - rx, cy + ry * KAPPA90,
                                    cx - rx, cy));
        path.AddCommand(new Command(CommandType.BezierTo,
                                    cx - rx, cy - ry * KAPPA90,
                                    cx - rx * KAPPA90, cy - ry,
                                    cx, cy - ry));
        path.AddCommand(new Command(CommandType.BezierTo,
                                    cx + rx * KAPPA90, cy - ry,
                                    cx + rx, cy - ry * KAPPA90,
                                    cx + rx, cy));
        path.AddCommand(new Command(CommandType.Close));
    }

    internal static void ArcTo(this Path path, float cx, float cy, float r, float a0, float a1, Winding winding)
    {
        var firstCommandType = path.LastSegment?.LastEditPoint is Point ? CommandType.LineTo : CommandType.MoveTo;
        
        // Clamp angles
        var da = a1 - a0;
        if (winding is Winding.CW)
        {
            if (Math.Abs(da) >= Math.PI * 2)
            {
                da = (float)Math.PI * 2;
            }
            else
            {
                while (da < 0.0f)
                {
                    da += (float)Math.PI * 2;
                }
            }
        }
        else
        {
            if (Math.Abs(da) >= Math.PI * 2)
            {
                da = -(float)Math.PI * 2;
            }
            else
            {
                while (da > 0.0f)
                {
                    da -= (float)Math.PI * 2;
                }
            }
        }

        // Split arc into max 90 degree segments.
        var ndivs = Math.Max(1, Math.Min((int)(Math.Abs(da) / (Math.PI * 0.5f) + 0.5f), 5));
        var hda = (da / (float)ndivs) / 2.0f;
        var kappa = Math.Abs(4.0f / 3.0f * (1.0f - Math.Cos(hda)) / Math.Sin(hda));

        if (winding is Winding.CCW)
        {
            kappa = -kappa;
        }
        
        var px =0d;
        var py =0d;
        var ptanx =0d;
        var ptany =0d;
        for (int i = 0; i <= ndivs; i++)
        {
            var a = a0 + da * (i / (float)ndivs);
            var dx = Math.Cos(a);
            var dy = Math.Sin(a);
            var x = cx + dx * r;
            var y = cy + dy * r;
            var tanx = -dy * r * kappa;
            var tany = dx * r * kappa;
            var command = i switch
            {
                0 => new Command(firstCommandType, (float)x, (float)y),
                _ => new Command(CommandType.BezierTo,
                    (float)(px + ptanx), (float)(py + ptany),
                    (float)(x - tanx), (float)(y - tany),
                    (float)x, (float)y)
            };

            path.AddCommand(command);
            px = x;
            py = y;
            ptanx = tanx;
            ptany = tany;
        }
    }

    private static IEnumerable<Point> GetBezierPoints(float x1, float y1, float x2, float y2, float x3, float y3, float x4, float y4, float tessTol, PointFlags pointFlags, int level = 0)
    {
        if (level > 10)
            return [];

        var result = new List<Point>();
        var x12 = (x1 + x2) * 0.5f;
        var y12 = (y1 + y2) * 0.5f;
        var x23 = (x2 + x3) * 0.5f;
        var y23 = (y2 + y3) * 0.5f;
        var x34 = (x3 + x4) * 0.5f;
        var y34 = (y3 + y4) * 0.5f;
        var x123 = (x12 + x23) * 0.5f;
        var y123 = (y12 + y23) * 0.5f;

        var dx = x4 - x1;
        var dy = y4 - y1;
        var d2 = Math.Abs((x2 - x4) * dy - (y2 - y4) * dx);
        var d3 = Math.Abs((x3 - x4) * dy - (y3 - y4) * dx);
        
        if ((d2 + d3) * (d2 + d3) < tessTol * (dx * dx + dy * dy))
        {
            result.Add(new Point(x4, y4, pointFlags));
            return result;
        }
        var x234 = (x23 + x34) * 0.5f;
        var y234 = (y23 + y34) * 0.5f;
        var x1234 = (x123 + x234) * 0.5f;
        var y1234 = (y123 + y234) * 0.5f;
        result.AddRange(GetBezierPoints(x1, y1, x12, y12, x123, y123, x1234, y1234, tessTol, PointFlags.None, level + 1));
        result.AddRange(GetBezierPoints(x1234, y1234, x234, y234, x34, y34, x4, y4, tessTol, pointFlags, level + 1));
        return result;
    }
}