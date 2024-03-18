namespace Arc.Core;

public class Scissor: ICloneable<Scissor>
{
    public Matrix2x3 Transform { get; private set; }
    public Vector2 Extent { get; private init; }
    
    public Scissor Clone() => 
        new Scissor()
        {
            Transform = this.Transform,
            Extent = this.Extent,
        };
}