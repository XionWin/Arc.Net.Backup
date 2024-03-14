using Extension;

namespace Arc.Core;

public class Segment: IShape<SegmentPrimitive>
{
    public Context Context { get; init;}
    public Path Path { get; init; }
    public State State => this.Path.State;

    private List<Point>? _editedPoints = new List<Point>();
    public Point? LastEditPoint => this._editedPoints?.LastOrDefault();
    private Point[]? _strokePoints = null;
    private Point[]? _fillPoints;
    public Point[] Points => this._strokePoints ?? throw new Exception("Unexpected");
    public Point[] FillPoints => (this.IsClosed ? _strokePoints : this._fillPoints) ?? throw new Exception("Unexpected");
    
    public int BevelCount { get; set; }
    public bool IsConvex { get; set; }
    public Rect Bounds { get; private set; }
    public bool IsClosed { get; internal set; }


    private SegmentPrimitive _segmentPrimitive = new SegmentPrimitive();

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
                var _ = fillOriginalPoints.CalculateJoins(this.State, true);
                this._fillPoints = fillOriginalPoints.ToArray();
            }
                
            editPoints.Optimize(this.Context.DistTol, this.IsClosed);
            editPoints.EnforceWinding(this.IsClosed);
            editPoints.Update(this.IsClosed);
            var joinResult = editPoints.CalculateJoins(this.State, this.IsClosed);
            this.BevelCount = joinResult.bevelCount;
            this.IsConvex = joinResult.leftCount == editPoints.Count;
            this._strokePoints = editPoints.ToArray();

            // foreach (var point in this._strokePoints)
            // {
            //     Console.WriteLine(point.ToString());
            // }

            // if(this._fillPoints is Point[] fillPoints)
            // {
            //     foreach (var point in fillPoints)
            //     {
            //         Console.WriteLine(point.ToString());
            //     }
            // }

            this._editedPoints = null;
        }
    }

    public void Fill()
    {
        throw new NotImplementedException();
    }

    public void Stroke() =>
        this._segmentPrimitive.Stroke = 
            this.With(x => x.Complate()).ToStrokeVertex(this.CurveDivs(this.Path.State), this.Context.FringeWidth);

    public SegmentPrimitive Flush() => this._segmentPrimitive;
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