using System.Runtime.InteropServices;

namespace Arc.Core;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct FragScissor
{
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
    private float[] _matrix;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    private float[] _extent;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    private float[] _scale;

    public float[] Matrix
    {
        get => this._matrix;
        set
        {
            if(value.Length == 12)
            {
                this._matrix = value;
            }
            else
            {
                throw new Exception("Unexpected");
            }
        }
    }

    public float[] Extent
    {
        get => this._extent;
        set
        {
            if(value.Length == 2)
            {
                this._extent = value;
            }
            else
            {
                throw new Exception("Unexpected");
            }
        }
    }

    public float[] Scale
    {
        get => this._scale;
        set
        {
            if(value.Length == 2)
            {
                this._scale = value;
            }
            else
            {
                throw new Exception("Unexpected");
            }
        }
    }
}

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct FragPaint
{
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
    private float[] _matrix;

    public float[] Matrix
    {
        get => this._matrix;
        set
        {
            if(value.Length == 12)
            {
                this._matrix = value;
            }
            else
            {
                throw new Exception("Unexpected");
            }
        }
    }
}

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct FragColor
{
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    private float[] _outer;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    private float[] _inner;

    public float[] Outer
    {
        get => this._outer;
        set
        {
            if(value.Length == 4)
            {
                this._outer = value;
            }
            else
            {
                throw new Exception("Unexpected");
            }
        }
    }
    public float[] Inner
    {
        get => this._inner;
        set
        {
            if(value.Length == 4)
            {
                this._inner = value;
            }
            else
            {
                throw new Exception("Unexpected");
            }
        }
    }
}

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct FragStroke
{
    private float _multiple;
    private float _threshold;

    public float Outer
    {
        get => this._multiple;
        set => this._multiple = value;
    }
    public float Threshold
    {
        get => this._threshold;
        set => this._threshold = value;
    }
}

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct FragUniforms
{
    private int _type;
    private float _radius;
    private float _feather;
    public FragScissor Scissor { get; init; }
    public FragPaint Paint { get; init; }
    public FragColor Color { get; init; }
    public FragStroke Stroke { get; init; }

    public int Type
    {
        get => this._type;
        set => this._type = value;
    }
    public float Radius
    {
        get => this._radius;
        set => this._radius = value;
    }
    public float Feather
    {
        get => this._feather;
        set => this._feather = value;
    }
}