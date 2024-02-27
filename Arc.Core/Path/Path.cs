namespace Arc.Core;

public class Path
{
    private Point[]? _points = null;
    public Point[] Points => this._points ?? throw new Exception("Value is not avaliable");
    public int Count => this.Points.Length;
    public int BevelCount { get; set; }
    public bool IsClosed { get; set; }
    public Winding Winding { get; set; }
    public bool IsConvex { get; set; }
    public Rect Bounds { get; private set; }

}