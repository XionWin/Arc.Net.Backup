namespace Arc.Core;

public interface IPrimitive<R>
{
    public Context Context { get; init; }
    public bool IsCompleted { get; }
    public void Complate();
    public R Stroke();
}