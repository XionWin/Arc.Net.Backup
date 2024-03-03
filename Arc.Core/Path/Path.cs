namespace Arc.Core;

public class Path
{
    private List<Point> _points = new List<Point>();
    public Point[] Points => this._points.ToArray();
    public int Count => this._points.Count;
    public int BevelCount { get; set; }
    public bool IsClosed { get; set; }
    public Winding Winding { get; set; }
    public bool IsConvex { get; set; }
    public Rect Bounds { get; private set; }

    public void AddPoint(Point point)
    {
        if(this._points.LastOrDefault() is Point previous)
        {
            point.Previous = previous;
            previous.Next = point;
        }
        this._points.Add(point);
    }

}