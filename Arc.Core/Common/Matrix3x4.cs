using System.Numerics;
using System.Runtime.InteropServices;

namespace Arc.Core;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct Matrix3x4
{
    public Vector4 Row0;
    public Vector4 Row1;
    public Vector4 Row2;

    public static Matrix3x4 Identity = new Matrix3x4(
        new Vector4(1, 0, 0, 0),
        new Vector4(0, 1, 0, 0),
        new Vector4(0, 0, 1, 0)
    );
    
    public Matrix3x4()
    {
        this = Identity;
    }
    public Matrix3x4(Vector4 row0, Vector4 row1, Vector4 row2)
    {
        this.Row0 = row0;
        this.Row1 = row1;
        this.Row2 = row2;
    }
}