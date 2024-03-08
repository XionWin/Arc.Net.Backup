namespace Arc.Core;

public class Path: IPrimitive<Vertex[][]>
{
    public Context Context { get; init; }
    private List<Segment> _segments = new List<Segment>();
    public Segment LastSegment => this._segments.Last();
    public int Count => this._segments.Count;
    public int BevelCount { get; set; }
    public bool IsConvex { get; set; }
    public Rect Bounds { get; private set; }
    public bool IsCompleted { get; private set; }

    internal Path(Context context)
    {
        this.Context = context;
    }

    public void AddCommand(Command command)
    {
        if(command.CommandType == CommandType.MoveTo)
        {
            this._segments.Add(new Segment(this));
        }
        if(this._segments.LastOrDefault() is Segment segment && segment.IsClosed is false)
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


    public Vertex[][] Stroke()
    {
        this.Complate();
        var vertexGroup = new List<Vertex[]>();
        foreach (var segment in _segments)
        {
            var results = segment.Stroke();
            vertexGroup.Add(results);
        }
        return vertexGroup.ToArray();
    }

    public void Complate()
    {
        this.IsCompleted = true;
    }
}

public static class PathExtension
{
    public static Point[] GetPoints(this Path path, Command command) =>
        command.CommandType switch
        {
            CommandType.MoveTo => [new Point(command.Values[0], command.Values[1], PointFlags.Corner)],
            CommandType.LineTo => [new Point(command.Values[0], command.Values[1], PointFlags.Corner)],
            CommandType.BezierTo => GetBezierPoints(
                path.LastSegment.LastPoint.X, path.LastSegment.LastPoint.Y,
                command.Values[0], command.Values[1],
                command.Values[2], command.Values[3],
                command.Values[4], command.Values[5],
                path.Context.TessTol,
                PointFlags.Corner
            ).ToArray(),
            _ => throw new NotImplementedException()
        };

    public static IEnumerable<Point> GetBezierPoints(float x1, float y1, float x2, float y2, float x3, float y3, float x4, float y4, float tessTol, PointFlags pointFlags, int level = 0)
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
        result.AddRange(GetBezierPoints(x1, y1, x12, y12, x123, y123, x1234, y1234, level + 1, PointFlags.None));
        result.AddRange(GetBezierPoints(x1234, y1234, x234, y234, x34, y34, x4, y4, level + 1, pointFlags));
        return result;
    }

    
    const float KAPPA90 = 0.5522847493f;
    public static void AddEllipse(this Path path, float cx, float cy, float rx, float ry)
    {
        path.AddCommand(new Command(CommandType.MoveTo, cx - rx, cy));
        path.AddCommand(new Command(CommandType.BezierTo, 
                                    cx - rx, cy + ry * KAPPA90,
                                    cx - rx * KAPPA90, cy + ry,
                                    cx, cy + ry));
        path.AddCommand(new Command(CommandType.BezierTo, 
                                    cx + rx * KAPPA90, cy + ry,
                                    cx + rx, cy + ry * KAPPA90,
                                    cx + rx, cy));
        path.AddCommand(new Command(CommandType.BezierTo, 
                                    cx + rx, cy - ry * KAPPA90,
                                    cx + rx * KAPPA90, cy - ry,
                                    cx, cy - ry));
        path.AddCommand(new Command(CommandType.BezierTo, 
                                    cx - rx * KAPPA90, cy - ry,
                                    cx - rx, cy - ry * KAPPA90,
                                    cx - rx, cy));
        path.AddCommand(new Command(CommandType.Close));
    }
}