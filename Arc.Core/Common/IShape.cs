namespace Arc.Core;

public interface IShape<T>
{
    public Context Context { get; init; }
    public bool IsCompleted { get; }
    public void Complate();
    public T Stroke();
}