using System.Runtime.InteropServices;

namespace Arc.Core;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct Color
{
	public float R { get; set; }
	public float G { get; set; }
	public float B { get; set; }
	public float A { get; set; }

	public Color()
	{
		this.A = 1f;
	}

	public Color(float r, float g, float b, float a)
	{
		this.R = r;
		this.G = g;
		this.B = b;
		this.A = a;
	}
	
	public Color(byte r, byte g, byte b, byte a)
	{
		this.R = r / 255f;
		this.G = g / 255f;
		this.B = b / 255f;
		this.A = a / 255f;
	}
}