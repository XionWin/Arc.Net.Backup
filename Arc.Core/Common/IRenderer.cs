namespace Arc.Core;

public interface IRenderer
{
    public void BeginFrame();
    public Size GetMaxTextureSize();
    public int CreateTexture(ImageData imageData, TextureType textureType, ImageFlags flags, string alias);
    public void UpdateTexture(int textureId, int x, int y, ImageData imageData, TextureType textureType);
    public void Fill(Path path);
    public void Stroke(Path path);
    public void Triangles(Vertex[] vertices, State state);
    public void Render(CompositeOperationState compositeOperationState);
}

public interface IDataRenderer<T>: IRenderer
{
    public T Data { get; }
}