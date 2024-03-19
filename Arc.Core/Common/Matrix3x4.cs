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

    public Matrix3x4(float m11, float m12, float m13, float m14, float m21, float m22, float m23, float m24, float m31, float m32, float m33, float m34)
    : this(new Vector4(m11, m12, m13, m14), new Vector4(m21, m22, m23, m24), new Vector4(m31, m32, m33, m34))
    {

    }
}