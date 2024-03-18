namespace Arc.Core;

public class Paint: ICloneable<Paint>
{
    public Matrix2x3 Transform { get; internal set; } = Matrix2x3.Identity;
    public Vector2 Extent { get; internal set; }
    public float Radius { get; set; }
    public float Feather { get; set; }
    public Color InnerColor { get; set; }
    public Color OuterColor { get; set; }
    public int Texture { get; set; }

    public Paint()
    {
        this.Radius = 0f;
        this.Feather = 1f;
        this.InnerColor = new Color();
        this.OuterColor = new Color();
    }
    public Paint Clone() => 
        new Paint()
        {
            Transform = this.Transform,
            Extent = this.Extent,
            Radius = this.Radius,
            Feather = this.Feather,
            InnerColor = this.InnerColor,
            OuterColor = this.OuterColor,
            Texture = this.Texture,
        };
}