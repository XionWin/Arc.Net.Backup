namespace Arc.Core;

public class Path: IShape
{
    private List<Segment> _segments = new List<Segment>();
    public Segment[] Segments => this._segments.ToArray();
    public int Count => this._segments.Count;
    public int BevelCount { get; set; }
    public bool IsConvex { get; set; }
    public Rect Bounds { get; private set; }
    public bool IsCompleted { get; private set; }

    public void AddCommand(Command command)
    {
        if(command.CommandType == CommandType.MoveTo)
        {
            this._segments.Add(new Segment());
        }
        if(this._segments.LastOrDefault() is Segment segment && segment.IsClosed is false)
        {
            if(command.CommandType == CommandType.Close)
            {
                segment.IsClosed = true;
            }
            else
            {
                segment.AddPoints(command.GetPoints());
            }
        }
        else
        {
            throw new Exception("Can't find the last path");
        }
    }

    public void Stroke(Context context)
    {
        foreach (var segment in Segments)
        {
            segment.Stroke(context);
        }
    }
}

public static class PathExtension
{
    public static Point[] GetPoints(this Command command) =>
        command.CommandType switch
        {
            CommandType.MoveTo => [new Point(command.Values[0], command.Values[1], PointFlags.Corner)],
            CommandType.LineTo => [new Point(command.Values[0], command.Values[1], PointFlags.Corner)],
            _ => throw new NotImplementedException()
        };
}