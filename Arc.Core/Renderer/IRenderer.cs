namespace Arc.Core;

public interface IRenderer
{
    public void Create();

    public int CreateTexture(ImageData imageData, TextureType textureType, ImageFlags flags);

    public void Fill(PathPrimitive primitive);
    public void Stroke(PathPrimitive primitive);

    public void Flush(CompositeOperation compositeOperation);
}