namespace Arc.Core;

public interface IPrimitive
{
    public Vertex[][] VertexMat { get; }
}

public class SegmentPrimitive: IPrimitive
{
    public Vertex[]? Fill { get; internal set; }
    public Vertex[]? Stroke { get; internal set; }

    public Vertex[][] VertexMat
    {
        get
        {
            Vertex[]?[] nullableArray = [this.Fill, this.Stroke];
            return nullableArray.Where(x => x is not null).Cast<Vertex[]>().ToArray();
        }
    }
}

public class PathPrimitive: IPrimitive
{
    public Vertex[][] VertexMat { get; init; }
    public State State { get; init; }
    public PathPrimitive (IEnumerable<SegmentPrimitive> segmentPrimitives, State state)
    {
        this.VertexMat = segmentPrimitives.SelectMany(x => x.VertexMat).ToArray();
        this.State = state;
    }
}