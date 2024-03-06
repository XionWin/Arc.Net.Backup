namespace Arc.Core;

public class Point
{
    public float X { get; init; }
    public float Y { get; init; }
    public PointFlags Flags { get; internal set; }

    private Point? _previous = null;
    public Point? Previous
    {
        get => this._previous ?? throw new Exception("Unexpected");
        set
        {
            this._previous = value;
            Update();
        }
    }

    private Point? _next = null;
    public Point? Next
    {
        get => this._next ?? throw new Exception("Unexpected");
        set
        {
            this._next = value;
            Update();
        }
    }

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
        if(this._previous is null || this._next is null)
        {
            return;
        }

        if(this.Next is Point nextPoint)
        {
            var len = Math.Sqrt(Math.Pow(this.X - nextPoint.X, 2) + Math.Pow(this.Y - nextPoint.Y, 2));

            var dx = nextPoint.X - this.X;
            var dy = nextPoint.Y - this.Y;
            if(len > 0)
            {
                var iLen = 1.0f / len;
                dx = dx * iLen is var dx2 && dx2 == 0 ? 0 : (float)dx2;
                dy = dy * iLen is var dy2 && dy2 == 0 ? 0 : (float)dy2;
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