namespace Arc.Core;

public interface IPrimitive<R>
{
    public bool IsCompleted { get; }
    public R Stroke(Context context);
    public void Complate(Context context);
}