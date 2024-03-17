namespace Arc.Core;

public interface IRenderer
{
    public void Create();
    public void Clear();

    public int CreateTexture(ImageData imageData, TextureType textureType, ImageFlags flags);

    public void Fill(Path path);
    public void Stroke(Path path);

    public void Flush(CompositeOperationState compositeOperationState);
}