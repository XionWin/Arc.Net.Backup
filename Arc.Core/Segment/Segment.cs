using Extension;

namespace Arc.Core;

public class Segment: IShape<SegmentPrimitive>
{
    public Context Context { get; init;}
    public Path Path { get; init; }

    private List<Point> _editedPoints = new List<Point>();
    private Point[]? _completedPoints = null;
    public Point[] Points => this.IsCompleted && this._completedPoints is Point[] cps ? cps : this._editedPoints.ToArray();
    public Point? LastPoint => this.IsCompleted && this._completedPoints is Point[] cps ? cps.Last() : this._editedPoints.LastOrDefault();
    public int Count => this.IsCompleted && this._completedPoints is Point[] cps ? cps.Length : this._editedPoints.Count;
    
    public int BevelCount { get; set; }
    public bool IsConvex { get; set; }
    public Rect Bounds { get; private set; }
    public bool IsCompleted { get; private set; }
    public bool IsClosed { get; internal set; }

    public Segment(Path path)
    {
        this.Path = path;
        this.Context = path.Context;
    }

    public void AddPoint(Point point)
    {
        if(this.IsCompleted || this.IsClosed)
        {
            throw new Exception("Unexpected");
        }
        this._editedPoints.Add(point);
    }
    public void AddPoints(IEnumerable<Point> points)
    {
        if(this.IsCompleted || this.IsClosed)
        {
            throw new Exception("Unexpected");
        }
        this._editedPoints.AddRange(points);
    }

    public SegmentPrimitive Stroke() =>
        new SegmentPrimitive(
            this.With(x => x.Complate())
            .With(x => x.CalculateJoins())
            .ToVertex(this.Context.CurveDivs(this.Path.State), this.Context.FringeWidth)
        );

    public void Complate()
    {
        if(this.IsCompleted is false)
        {
            this._editedPoints.Optimize(this.Context.DistTol, this.IsClosed);
            this._editedPoints.EnforceWinding(this.IsClosed);
            this._editedPoints.Update(this.IsClosed);

            this._completedPoints = this._editedPoints.ToArray();
            this._editedPoints.Clear();

            this.IsCompleted = true;
        }
        else
        {
            throw new Exception("Unexpected");
        }
    }
}

public static class SegmentExtension
{
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