namespace Arc.Core;

public class Point
{
    public float X { get; init; }
    public float Y { get; init; }
    public PointFlags Flags { get; internal set; }
    public Point? Previous { get; internal set; }
    public Point? Next { get; internal set; }

    public float Len { get; private set; }
    public float Dx { get; private set; }
    public float Dy { get; private set; }
    public float Dmx { get; private set; }
    public float Dmy { get; private set; }

    public Point(float x, float y, PointFlags pointFlags)
    {
        this.X = x;
        this.Y = y;
        this.Flags = pointFlags;
    }

    public void Update()
    {
        if(this.Previous is null || this.Next is null)
        {
            throw new Exception("Unexpected");
        }

        if(this.Next is Point nextPoint)
        {
            var len = Math.Sqrt(Math.Pow(this.X - nextPoint.X, 2) + Math.Pow(this.Y - nextPoint.Y, 2));

            var dx = nextPoint.X - this.X;
            var dy = nextPoint.Y - this.Y;
            if(len > 0)
            {
                var iLen = 1.0f / len;
                dx = dx * iLen is var dxx && dxx == 0 ? 0 : (float)dxx;
                dy = dy * iLen is var dyy && dyy == 0 ? 0 : (float)dyy;
            }
            this.Dx = dx;
            this.Dy = dy;

            if(this.Previous is Point previousPoint)
            {
                var dmx = (previousPoint.Dy + this.Dy) / 2f;
                var dmy = (-previousPoint.Dx - this.Dx) / 2f;
                var dmr2 = (float)Math.Pow(dmx, 2) + (float)Math.Pow(dmy, 2);
                if (dmr2 > 0.1e-6f)
                {
                    float scale = 1.0f / dmr2;
                    if (scale > 600.0f)
                    {
                        scale = 600.0f;
                    }
                    dmx = dmx * scale;
                    dmy = dmy * scale;
                }
                this.Dmx = dmx;
                this.Dmy = dmy;
            }
        }
    }
}

public static class PointExtension
{
    internal static float Distance(this Point point, Point other) => (float)Math.Sqrt(Math.Pow(point.X - other.X, 2) + Math.Pow(point.Y - other.Y, 2));
    internal static float Distance(this Point point, float x, float y) => (float)Math.Sqrt(Math.Pow(point.X - x, 2) + Math.Pow(point.Y - y, 2));
}