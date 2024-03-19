using System.Runtime.InteropServices;

namespace Arc.Core;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct Extent
{
    public float X { get; set; }
    public float Y { get; set; }

    public Extent(float x, float y)
    {
        this.X = x;
        this.Y = y;
    }
}