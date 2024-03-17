namespace Arc.Core;

public interface IPath
{
    public Context Context { get; init; }
    public (Vertex[] vertices, State state) Fill();
    public (Vertex[] vertices, State state) Stroke();

}