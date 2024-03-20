namespace Arc.Core;

public class Scissor: ICloneable<Scissor>
{
    public Matrix2x3 Transform { get; internal set; }
    public Extent Extent { get; internal set; }
    
    public Scissor Clone() => 
        new Scissor()
        {
            Transform = this.Transform,
            Extent = this.Extent,
        };
}