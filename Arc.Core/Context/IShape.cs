namespace Arc.Core;

public interface IShape
{
    public bool IsCompleted { get; }
    public Vertex[] Stroke(Context context);
    public void Complate(Context context);
}