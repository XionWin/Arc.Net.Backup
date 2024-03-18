namespace Arc.Core;

public static class PaintExtension
{
    public static Paint CreateImagePaint(this IContext context, Rectangle view, float angle, ImageData imageData, float alpha)
    {
        var state = context.GetState();
        var paint = new Paint();
        
        var t = paint.Transform * state.Transform;
        t.Rotate(angle);

        t.M31 = view.X + view.Width / 2;
        t.M32 = view.Y + view.Height / 2;

        paint.Transform = t;

        paint.Extent = new Vector2(view.Width, view.Height);

        paint.Texture = 2;
        paint.InnerColor = new Color(1, 1, 1, alpha);
        return paint;
    } 
}