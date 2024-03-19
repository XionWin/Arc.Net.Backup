using System.Runtime.InteropServices;

namespace Arc.Core;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct Scale
{
    public float X { get; set; }
    public float Y { get; set; }

    public Scale(float x, float y)
    {
        this.X = x;
        this.Y = y;
    }
}