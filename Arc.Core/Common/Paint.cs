namespace Arc.Core;

public class Paint: ICloneable<Paint>
{
    public Matrix2x3 Transform { get; internal set; } = Matrix2x3.Identity;
    public Extent Extent { get; internal set; }
    public float Radius { get; set; }
    public float Feather { get; set; }
    public Color InnerColor { get; set; }
    public Color OuterColor { get; set; }
    public int? Texture { get; set; }

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

public static class PaintExtension
{
    public static void FillPaintTexture(this State state, int texture, Rectangle view, float angle, float alpha)
    {
        var paint = state.FillPaint;
        var transform = paint.Transform * state.Transform;
        transform.Rotate(angle);
        transform.M31 = view.X + view.Width / 2;
        transform.M32 = view.Y + view.Height / 2;

        paint.Transform = transform;
        paint.Extent = new Extent(view.Width, view.Height);
        paint.Texture = texture;
        paint.InnerColor = new Color(1, 1, 1, alpha);
    } 
}
