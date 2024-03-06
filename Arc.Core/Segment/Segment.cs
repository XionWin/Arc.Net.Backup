namespace Arc.Core;

public class Segment: IComplete
{
    private List<Point> _points = new List<Point>();
    public Point[] Points => this._points.ToArray();
    public bool IsCompleted { get; private set; }
    public bool IsClosed { get; internal set; }

    public void AddPoint(Point point)
    {
        this._points.Add(point);
    }
    public void AddPoints(IEnumerable<Point> points)
    {
        this._points.AddRange(points);
    }

    public void Complete(Context context)
    {
        this.IsCompleted = true;
        this._points.Optimize(context.DistTol);
        this._points.EnforceWinding(this.IsClosed);
    }
}

public static class SegmentExtension
{
    public static void Optimize(this List<Point> points, float distTol)
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
        foreach (var point in points)
        {
            point.Update();
        }
    }
    private static void Whirling(this List<Point> points, bool isClosed)
    {
        var first = points.First();
        var last = points.Last();

        Point? previous = null;
        foreach (var point in points)
        {
            if((previous ?? last) is var previousPoint)
            {
                point.Previous = previousPoint;
                previousPoint.Next = point;
            }
            point.Next = first;

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