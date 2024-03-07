namespace Arc.Core;

public class Segment: IPrimitive<Vertex[]>
{
    private List<Point> _points = new List<Point>();
    public Point[] Points => this._points.ToArray();
    public int BevelCount { get; set; }
    public bool IsConvex { get; set; }
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

    public Vertex[] Stroke(Context context)
    {
        this.Complate(context);
        this.CalculateJoins(context);
        var vertices = this.ToVertex(context);
        return vertices;
    }

    public void Complate(Context context)
    {
        this.IsCompleted = true;
        this._points.Optimize(context.DistTol);
        this._points.EnforceWinding(this.IsClosed);
        this._points.Update(this.IsClosed);
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
    }

    internal static void CalculateJoins(this Segment segment, Context context)
    {
        var leftCount = 0;
        foreach (var point in segment.Points)
        {
            // Clear flags, but keep the corner.
            point.Flags =  PointFlags.Corner;

            if(point.Previous is Point previousPoint)
            {
                // Keep track of left turns.
                var cross = point.Dx * previousPoint.Dy - previousPoint.Dx * point.Dy;
                if (cross > 0.0f)
                {
                    leftCount++;
                    point.Flags |= PointFlags.Left;
                }

                // Calculate if we should use bevel or miter for inner join.
                if(previousPoint.Len is float previousLen && point.Len is float len && point.Dmr2 is float dmr2)
                {
                    var strokeWidth = context.GetState().StrokeWidth;
                    var miterLimit = context.GetState().MiterLimit;
                    var lineJoin = context.GetState().LineJoin;
                    var iw = 0.0f;
                    if (strokeWidth > 0.0f)
                        iw = 1.0f / strokeWidth;
                    var limit = Math.Max(1.01f, Math.Min(previousLen, len) * iw);
                    if ((dmr2 * limit * limit) < 1.0f)
                        point.Flags |= PointFlags.InnerBevel;

                    // Check to see if the corner needs to be beveled.
                    if (point.Flags.Contains(PointFlags.Corner))
                    {
                        if ((dmr2 * miterLimit * miterLimit) < 1.0f ||
                            lineJoin == LineJoin.Bevel ||
                            lineJoin == LineJoin.Round)
                        {
                            point.Flags |= PointFlags.Bevel;
                        }
                    }
                }
            }

            if (point.Flags.Contains(PointFlags.Bevel | PointFlags.InnerBevel))
                segment.BevelCount++;
        }
        segment.IsConvex = leftCount == segment.Points.Length;
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