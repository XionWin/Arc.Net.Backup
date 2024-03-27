namespace Arc.Core;

public interface IRenderer
{
    public void BeginFrame();
    public int CreateTexture(ImageData imageData, TextureType textureType, ImageFlags flags);
    public void Fill(Path path);
    public void Stroke(Path path);
    public void Render(CompositeOperationState compositeOperationState);
}

public interface IDataRenderer<T>: IRenderer
{
    public T Data { get; }
}