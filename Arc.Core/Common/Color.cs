namespace Arc.Core;

public struct Color
{
	public float R { get; set; }
	public float G { get; set; }
	public float B { get; set; }
	public float A { get; set; }

	public Color(float r, float g, float b, float a)
	{
		this.R = r;
		this.G = g;
		this.B = b;
		this.A = a;
	}
}