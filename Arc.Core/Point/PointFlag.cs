namespace Arc.Core;

[Flags]
public enum PointFlags
{
    Corner = 0x01,
    Left = 0x02,
    Bevel = 0x04,
    InnerBevel = 0x08,
}


public static class PointFlagsExtension
{
    public static bool Contains(this PointFlags pointFlags, PointFlags flags) =>
        (pointFlags & flags) == flags;
}