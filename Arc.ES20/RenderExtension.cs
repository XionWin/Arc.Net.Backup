#if KMS_MODE
using OpenGL.Graphics.ES20;
#else
using Arc.Core;
using Extension;
using OpenTK.Graphics.ES20;
#endif

namespace Arc.ES20;

public static class RenderExtension
{
    internal static int CreateTexture(this Renderer renderer, ImageData imageData, PixelFormat pixelFormat, TextureComponentCount textureComponentCount, string alias)
    {
        renderer.Textures.Add(
            alias,  new Texture(TextureUnit.Texture0, TextureMinFilter.Linear).With(x => x.LoadRaw(imageData.Value, imageData.Width, imageData.Height, pixelFormat, textureComponentCount))
        );
        return renderer.Textures.Values.Count;
    }

    internal static void UpdateTexture(this Renderer renderer, int textureId, int x, int y, ImageData imageData, PixelFormat pixelFormat)
    {
        var texture = renderer.Textures.Values.ToList()[textureId] ?? throw new Exception("Unexpected");
        GL.ActiveTexture(texture.TextureUnit);
        GL.BindTexture(TextureTarget.Texture2D, texture.Id);
        
        GL.TexSubImage2D(TextureTarget2d.Texture2D, 0, x, y, imageData.Width, imageData.Height, pixelFormat, PixelType.UnsignedByte, imageData.Value);
    }
}