namespace Arc.Core;

public interface IShape<T>
{
    public Context Context { get; init; }
    public T Stroke();
}