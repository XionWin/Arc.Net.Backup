using System.Runtime.InteropServices;
using Arc.Core;

namespace Arc.ES20;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct FragUniforms: IFragUniform
{
    private float _type;
    private float _fontType;
    public float Radius;
    public float Feather;
    public float StrokeMultiple;
    public float Strokethreshold;
    public Extent Extent;
    public Matrix3x4 ScissorMatrix;
    public Extent ScissorExtent;
    public Scale ScissorScale;
    public Matrix3x4 PaintMatrix;
    public Color InnerColor;
    public Color OuterColor;

    public int Type
    {
        get => (int)this._type;
        set => this._type = (float)value;
    }
    public int FontType
    {
        get => (int)this._fontType;
        set => this._fontType = (float)value;
    }

    public float[] Values
    {
        get 
        {
            int size = Marshal.SizeOf(typeof(FragUniforms));
            int len = size % sizeof(float) == 0 ? size / sizeof(float) : throw new Exception("Unexpected");
            float[] array = new float[len];

            IntPtr ptr = Marshal.AllocHGlobal(size);
            Marshal.StructureToPtr(this, ptr, true);
            Marshal.Copy(ptr, array, 0, len);
            Marshal.FreeHGlobal(ptr);
            return array;
        }
    }
    
}