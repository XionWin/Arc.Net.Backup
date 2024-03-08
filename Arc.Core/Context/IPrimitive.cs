namespace Arc.Core;

public interface IPrimitive<R>
{
    public Context Context { get; init; }
    public bool IsCompleted { get; }
    public R Stroke();
    public void Complate();
}