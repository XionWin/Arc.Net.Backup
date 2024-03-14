namespace Arc.Core;

public interface IShape<T>
    where T : IPrimitive
{
    public Context Context { get; init; }
    public void Fill();
    public void Stroke();
    public T Flush();

}