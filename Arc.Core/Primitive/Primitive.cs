namespace Arc.Core;

public class Primitive
{
    public Vertex[] Vertices { get; init; }
    public State State { get; }

    public Primitive(Vertex[] vertices, State state)
    {
        this.Vertices = vertices;
        this.State = state;
    }
}