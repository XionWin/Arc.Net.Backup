namespace Arc.Core;

public class ImageData
{
    public int Width { get; init; }
    public int Height { get; init; }
    public byte[] Value { get; init; }

    public ImageData(int width, int height, byte[] value)
    {
        this.Width = width;
        this.Height = height;
        this.Value = value;
    }
}