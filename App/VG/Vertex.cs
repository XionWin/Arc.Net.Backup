using System.Numerics;
using System.Runtime.InteropServices;

namespace App.VG;

[StructLayout(LayoutKind.Sequential)]
public struct Vertex
{    public Vector2 Position { get; init; }
    public Vector2 Coordinate { get; init; }

    public Vertex(float x, float y, float u, float v)
    {
        this.Position = new Vector2(x, y);
        this.Coordinate = new Vector2(u, v);
    }
}