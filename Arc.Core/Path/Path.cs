namespace Arc.Core;

public class Path
{
    private List<Command> _commands = new List<Command>();
    private List<Point> _points = new List<Point>();
    public Point[] Points => this._points.ToArray();
    public int Count => this._points.Count;
    public int BevelCount { get; set; }
    public Winding Winding { get; set; }
    public bool IsConvex { get; set; }
    public Rect Bounds { get; private set; }
    public bool IsClosed { get; set; }
    public bool IsFinalized { get; set; }

    public void AddCommand(Command command)
    {
        this._commands.Add(command);
    }

    public void FinalizePath()
    {

    }

    // public void AddPoint(Point point)
    // {
    //     var previous = this._points.LastOrDefault() ?? point;
    //     point.Previous = previous;
    //     previous.Next = point;

    //     var first = this._points.FirstOrDefault() ?? point;
    //     point.Next = first;

    //     this._points.Add(point);
    // }

}