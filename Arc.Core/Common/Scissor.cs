namespace Arc.Core;

public class Scissor: ICloneable<Scissor>
{
    public Matrix2x3 Xform { get; private set; }
    public Vector2 Extent { get; private init; }
    
    public Scissor Clone() => 
        new Scissor()
        {
            Xform = this.Xform,
            Extent = this.Extent,
        };
}