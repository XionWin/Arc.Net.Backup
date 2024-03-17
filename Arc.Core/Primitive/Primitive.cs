namespace Arc.Core;

public class SegmentPrimitive
{   
    private Vertex[]? _fill = null;
    public Vertex[] Fill
    {
        get => this._fill ?? throw new Exception("Unexpected"); 
        internal set => this._fill = value; 
    }
    private Vertex[]? _stroke = null;
    public Vertex[] Stroke
    {
        get => this._stroke ?? throw new Exception("Unexpected"); 
        internal set => this._stroke = value; 
    }
    private Rect? _bounds = new Rect(100, 100, 200, 200);
    public Rect Bounds
    {
        get => this._bounds ?? throw new Exception("Unexpected"); 
        internal set => this._bounds = value;
    }
    public bool IsConvex { get; internal set; }
}

public class PathPrimitive
{
    public State State { get; init; }
    public SegmentPrimitive[] SegmentPrimitives { get; init; }
    public PathPrimitive (IEnumerable<SegmentPrimitive> segmentPrimitives, State state)
    {
        this.SegmentPrimitives = segmentPrimitives.ToArray();
        this.State = state;
    }
}