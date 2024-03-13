using Arc.Core;

namespace Arc.ES20;

public class Renderer: IRenderer
{
    public void Create()
    {
        
    }

    public int CreateTexture(ImageData imageData, TextureType textureType, ImageFlags flags)
    {
        return 0;
    }

    public void Flush(CompositeOperation compositeOperation)
    {
        throw new NotImplementedException();
    }

    public void Render(Primitive primitive)
    {
        throw new NotImplementedException();
    }
}