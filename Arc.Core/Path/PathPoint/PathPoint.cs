﻿namespace Arc.Core;

public class PathPoint: ICloneable<PathPoint>
{
    public float X { get; init; }
    public float Y { get; init; }
    public PointFlags Flags { get; internal set; }
    public PathPoint? Previous { get; internal set; }
    public PathPoint? Next { get; internal set; }
    public float? Len { get; internal set; }
    public float? Dx { get; internal set; }
    public float? Dy { get; internal set; }
    public float? Dmx { get; internal set; }
    public float? Dmy { get; internal set; }
    public float? Dmr2 { get; internal set; }

    private PathPoint() {}

    public PathPoint(float x, float y, PointFlags pointFlags = PointFlags.None, Matrix2x3? transform = null)
    {
        this.Flags = pointFlags;
        if(transform is Matrix2x3 t)
        {
            this.X = x * t.M11 + y * t.M12 + t.M31;
            this.Y = x * t.M21 + y * t.M22 + t.M32;
        }
        else
        {
            this.X = x;
            this.Y = y;
        }
    }

    public PathPoint Clone() =>
        new PathPoint()
        {
            X = this.X,
            Y = this.Y,
            Flags = this.Flags,
            Previous = this.Previous,
            Next = this.Next,
            Len = this.Len,
            Dx = this.Dx,
            Dy = this.Dy,
            Dmx = this.Dmx,
            Dmy = this.Dmy,
            Dmr2 = this.Dmr2
        };

    public override string ToString()
    {
        return $"X: {X:F2}, Y: {Y:F2}, Dx: {Dx:F2}, Dy: {Dy:F2}, Dmx: {Dmx:F2}, Dmy: {Dmy:F2}, Dmr2: {Dmr2:F2}, Flags: {Flags}";
    }
}

public static class PointExtension
{
    internal static float Distance(this PathPoint point, PathPoint other) => (float)Math.Sqrt(Math.Pow(point.X - other.X, 2) + Math.Pow(point.Y - other.Y, 2));
    internal static float Distance(this PathPoint point, float x, float y) => (float)Math.Sqrt(Math.Pow(point.X - x, 2) + Math.Pow(point.Y - y, 2));

    
}