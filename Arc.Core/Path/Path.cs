using Extension;

namespace Arc.Core;

public class Path: IPath
{
    public Context Context { get; init; }
    
    private List<Point>? _editedPoints = new List<Point>();
    public Point? LastEditPoint => this._editedPoints?.LastOrDefault();
     private Point[]? _strokePoints = null;
    private Point[]? _fillPoints;
    public Point[] Points => this._strokePoints ?? throw new Exception("Unexpected");
    public Point[] FillPoints => (this.IsClosed ? _strokePoints : this._fillPoints) ?? throw new Exception("Unexpected");
    public int BevelCount { get; set; }
    public bool IsConvex { get; set; }
    public Rect? Bounds { get; private set; }
    public bool IsClosed { get; internal set; }

    internal Path(Context context)
    {
        this.Context = context;
    }

    public void AddCommand(Command command)
    {
        if(this.IsClosed is false)
        {
            if(command.CommandType == CommandType.Close)
            {
                this.IsClosed = true;
            }
            else
            {
                this.AddPoints(this.GetPoints(command));
            }
        }
        else
        {
            throw new Exception("Unexpected");
        }
    }
    
    public void AddPoints(IEnumerable<Point> points)
    {
        if(this._editedPoints is List<Point> editPoints && this.IsClosed is false)
        {
            editPoints.AddRange(points);
            UpdateRect(points);
        }
        else
        {
            throw new Exception("Unexpected");
        }
    }

    private void UpdateRect(IEnumerable<Point> points)
    {
        var minX = points.Min(x => x.X);
        var minY = points.Min(x => x.Y);
        var maxX = points.Max(x => x.X);
        var maxY = points.Max(x => x.Y);
        var rect = new Rect(
            this.Bounds?.Left is float left ? Math.Min(left, minX) : minX,
            this.Bounds?.Top is float top ? Math.Min(top, minY) : minY,
            this.Bounds?.Right is float right ? Math.Max(right, maxX) : maxX,
            this.Bounds?.Bottom is float bottom ? Math.Max(bottom, maxY) : maxY
        );
        this.Bounds = rect;
    }

    private void Complate()
    {
        if(this._editedPoints is List<Point> editPoints && editPoints.Any())
        {
            if(this.IsClosed is false)
            {
                var fillOriginalPoints = editPoints.Select(x => x.Clone()).ToList();
                fillOriginalPoints.Optimize(this.Context.DistTol, true);
                fillOriginalPoints.EnforceWinding(true);
                fillOriginalPoints.Update(true);
                var _ = fillOriginalPoints.CalculateJoins(this.Context.GetState(), true);
                this._fillPoints = fillOriginalPoints.ToArray();
            }
                
            editPoints.Optimize(this.Context.DistTol, this.IsClosed);
            editPoints.EnforceWinding(this.IsClosed);
            editPoints.Update(this.IsClosed);
            var joinResult = editPoints.CalculateJoins(this.Context.GetState(), this.IsClosed);
            this.BevelCount = joinResult.bevelCount;
            this.IsConvex = joinResult.leftCount == editPoints.Count;
            this._strokePoints = editPoints.ToArray();

            this._editedPoints = null;
        }
    }

    
    public (Vertex[] vertices, State state) Fill() =>
        (
            this.With(x => x.Complate()).ToFillVertex(this.Context.GetState(), this.CurveDivs(this.Context.GetState()), this.Context.FringeWidth),
            this.Context.GetState()
        );

    public (Vertex[] vertices, State state) Stroke() =>
        (
            this.With(x => x.Complate()).ToStrokeVertex(this.Context.GetState(), this.CurveDivs(this.Context.GetState()), this.Context.FringeWidth),
            this.Context.GetState()
        );
    
}

public static class PathExtension
{
    internal static Point[] GetPoints(this Path path, Command command) =>
        command.CommandType switch
        {
            CommandType.MoveTo => [new Point(command.Values[0], command.Values[1], PointFlags.Corner)],
            CommandType.LineTo => [new Point(command.Values[0], command.Values[1], PointFlags.Corner)],
            CommandType.BezierTo => path.LastEditPoint is Point lastPoint ? GetBezierPoints(
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
    
    internal static int CurveDivs(this Path path, State state)
    {
        var aaWidth = path.GetedgeAntiAliasWidth(state);
        float da = (float)Math.Acos(aaWidth / (aaWidth + path.Context.TessTol)) * 2.0f;
        return Math.Max(2, (int)Math.Ceiling(Math.PI / da));
    }
    
    private static float GetedgeAntiAliasWidth(this Path path, State state) => 
        (state.StrokeWidth + path.Context.FringeWidth) * 0.5f;
    
    public static void Optimize(this List<Point> points, float distTol, bool isClosed)
    {
        for (int i = 1; i < points.Count; i++)
        {
            var current = points[i];
            var last = points[i - 1];
            if(last.Distance(current) < distTol)
            {
                last.Flags |= current.Flags;
                points.Remove(current);
            }
        }
        if(isClosed && points.First() is var fp && points.Last() is var lp && lp.Distance(fp) == 0)
        {
            points.Remove(lp);
        }
    }

    internal static void EnforceWinding(this List<Point> points, bool isClosed)
    {
        if(points.Area() is float area)
        {
            if(area < 0)
            {
                points.Reverse();
            }
        }
        points.Whirling(isClosed);
    }
    private static void Whirling(this List<Point> points, bool isClosed)
    {
        if(isClosed)
        {
            points.WhirlingClosed();
        }
        else
        {
            points.WhirlingUnClosed();
        }
    }

    private static void WhirlingClosed(this List<Point> points)
    {
        Point? previous = points.Last();
        foreach (var point in points)
        {
            point.Previous = previous;
            previous.Next = point;
            previous = point;
        }
    }

    private static void WhirlingUnClosed(this List<Point> points)
    {
        Point? previous = null;
        foreach (var point in points)
        {
            if(previous is Point previousPoint)
            {
                point.Previous = previousPoint;
                previousPoint.Next = point;
            }
            previous = point;
        }
    }

    
    private static float? Area(this List<Point> points)
    {
        var area = 0f;
        if(points.Count > 2)
        {
            for (int i = 2; i < points.Count; i++)
            {
                var a = points[0];
                var b = points[i - 1];
                var c = points[i];

                float abx = b.X - a.X;
                float aby = b.Y - a.Y;
                float acx = c.X - a.X;
                float acy = c.Y - a.Y;
                area += (acx * aby - abx * acy) / 2;
            }
            return area;
        }
        else
        {
            return null;
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