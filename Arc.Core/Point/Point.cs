namespace Arc.Core;

public class Point
{
    public float X { get; init; }
    public float Y { get; init; }
    public PointFlags Flags { get; init; }

    public Point? _next = null;
    public Point Next
    {
        get => this._next ?? throw new Exception("Value is not avaliable");
        set
        {
            this._next = value;
            this.Update();
        }
    }

    private float? _len = 0;
    public float Len => this._len ?? throw new Exception("Value is not avaliable");
    private float? _dx = 0;
    public float Dx => this._dx ?? throw new Exception("Value is not avaliable");
    private float? _dy = 0;
    public float Dy => this._dy ?? throw new Exception("Value is not avaliable");
    private float? _dmx = 0;
    public float Dmx => this._dmx ?? throw new Exception("Value is not avaliable");
    private float? _dmy = 0;
    public float Dmy => this._dmy ?? throw new Exception("Value is not avaliable");

    public Point(float x, float y, PointFlags pointFlags)
    {
        this.X = x;
        this.Y = y;
        this.Flags = pointFlags;
    }

    private void Update()
    {
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
        }
    }
}
