namespace Arc.Core;

public class Point
{
    public float X { get; init; }
    public float Y { get; init; }
    public PointFlags Flags { get; internal set; }
    public Point? Previous { get; internal set; }
    public Point? Next { get; internal set; }
    public float? Len { get; internal set; }
    public float? Dx { get; internal set; }
    public float? Dy { get; internal set; }
    public float? Dmx { get; internal set; }
    public float? Dmy { get; internal set; }
    public float? Dmr2 { get; internal set; }

    public Point(float x, float y, PointFlags pointFlags)
    {
        this.X = x;
        this.Y = y;
        this.Flags = pointFlags;
    }
}

public static class PointExtension
{
    internal static float Distance(this Point point, Point other) => (float)Math.Sqrt(Math.Pow(point.X - other.X, 2) + Math.Pow(point.Y - other.Y, 2));
    internal static float Distance(this Point point, float x, float y) => (float)Math.Sqrt(Math.Pow(point.X - x, 2) + Math.Pow(point.Y - y, 2));
}