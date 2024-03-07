namespace Arc.Core;

public interface IShape<R>
{
    public bool IsCompleted { get; }
    public R Stroke(Context context);
    public void Complate(Context context);
}