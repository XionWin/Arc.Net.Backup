namespace Arc.Core;

public interface IPath
{
    public IContext Context { get; init; }
    public (Vertex[] vertices, State state) Fill();
    public (Vertex[] vertices, State state) Stroke();

}