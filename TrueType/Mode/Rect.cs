namespace TrueType.Mode;
public struct Rectangle
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public Point Location
    {
        get => new Point(X, Y);
        set
        {
            X = value.X;
            Y = value.Y;
        }
    }

    public Size Size 
    { 
        get => new Size(Width, Height);
        set
        {
            Width = value.Width;
            Height = value.Height;
        }
    }

    public Rectangle(int x, int y, int width, int height)
    {
        Location = new Point(x, y);
        Size = new Size(width, height);
    }
}

public struct RectF
{
    public float X { get; set; }
    public float Y { get; set; }
    public float Width { get; set; }
    public float Height { get; set; }
    public PointF Location
    {
        get => new PointF(X, Y);
        set
        {
            X = value.X;
            Y = value.Y;
        }
    }

    public SizeF Size
    {
        get => new SizeF(Width, Height);
        set
        {
            Width = value.Width;
            Height = value.Height;
        }
    }

    public RectF(float x, float y, float width, float height)
    {
        Location = new PointF(x, y);
        Size = new SizeF(width, height);
    }
}
