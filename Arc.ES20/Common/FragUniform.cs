using System.Runtime.InteropServices;
using Arc.Core;

namespace Arc.ES20;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct FragUniform: IFragUniform
{
    private float _type;
    private float _fontType;
    public float Radius { get; set; }
    public float Feather { get; set; }
    public float StrokeMultiple { get; set; }
    public float Strokethreshold { get; set; }
    public Extent Extent { get; set; }
    public Matrix3x4 ScissorMatrix { get; set; }
    public Extent ScissorExtent { get; set; }
    public Scale ScissorScale { get; set; }
    public Matrix3x4 PaintMatrix { get; set; }
    public Color InnerColor { get; set; }
    public Color OuterColor { get; set; }

    public FragUniformType Type
    {
        get => (FragUniformType)this._type;
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
            int size = Marshal.SizeOf(typeof(FragUniform));
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