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
    public Primitive(IEnumerable<SegmentPrimitive> sps, State state)
    {
        this.VertexMat = sps.Select(x => x.Vertices).ToArray();
        this.State = state;
    }
}