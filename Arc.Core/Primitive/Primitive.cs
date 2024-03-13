namespace Arc.Core;

public class SegmentPrimitive
{
    public Vertex[] Vertices { get; init; }
    public SegmentPrimitive(Vertex[] vertices)
    {
        this.Vertices = vertices;
    }
}

public class Primitive
{
    public Vertex[][] VertexMat { get; init; }
    public State State { get; init; }
    public Primitive(IEnumerable<SegmentPrimitive> primitives, State state)
    {
        this.VertexMat = primitives.Select(x => x.Vertices).ToArray();
        this.State = state;
    }
}