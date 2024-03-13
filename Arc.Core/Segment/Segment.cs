using Extension;

namespace Arc.Core;

public class Segment: IShape<SegmentPrimitive>
{
    public Context Context { get; init;}
    public Path Path { get; init; }

    private List<Point>? _editedPoints = new List<Point>();
    private Point[]? _points = null;
    public Point[] Points => this._points ?? throw new Exception("Unexpected");
    public Point? LastEditPoint => this._editedPoints?.LastOrDefault();
    public int Count => this._points?.Length ?? 0;
    
    public int BevelCount { get; set; }
    public bool IsConvex { get; set; }
    public Rect Bounds { get; private set; }
    public bool IsClosed { get; internal set; }

    public Segment(Path path)
    {
        this.Path = path;
        this.Context = path.Context;
    }
    
    public void AddPoints(IEnumerable<Point> points)
    {
        if(this._editedPoints is List<Point> editPoints && this.IsClosed is false)
        {
            editPoints.AddRange(points);
        }
        else
        {
            throw new Exception("Unexpected");
        }
    }

    public SegmentPrimitive Stroke() =>
        new SegmentPrimitive(
            this.With(x => x.Complate())
            .ToVertex(this.CurveDivs(this.Path.State), this.Context.FringeWidth)
        );

    private void Complate()
    {
        if(this._points is null && this._editedPoints is List<Point> editPoints)
        {
            editPoints.Optimize(this.Context.DistTol, this.IsClosed);
            editPoints.EnforceWinding(this.IsClosed);
            editPoints.Update(this.IsClosed);

            this._points = editPoints.ToArray();
            this._editedPoints = null;
            this.CalculateJoins();
        }
    }
}

public static class SegmentExtension
{
    internal static int CurveDivs(this Segment segment, State state)
    {
        var aaWidth = segment.GetedgeAntiAliasWidth(state);
        float da = (float)Math.Acos(aaWidth / (aaWidth + segment.Context.TessTol)) * 2.0f;
        return Math.Max(2, (int)Math.Ceiling(Math.PI / da));
    }
    
    private static float GetedgeAntiAliasWidth(this Segment segment, State state) => 
        (state.StrokeWidth + segment.Context.FringeWidth) * 0.5f;
    
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
}