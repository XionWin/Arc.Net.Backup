#if KMS_MODE
using OpenGL.Graphics.ES20;
#else
using OpenTK.Graphics.ES20;
#endif
using Arc.Core;

namespace Arc.ES20;

public class Renderer : IDataRenderer<RenderData>, IDisposable
{
    public int VAO { get; init; }
    public int VBO { get; init; }
    public Shader Shader { get; init; }
    public RenderData Data { get; } = new RenderData();
    public Dictionary<string, Texture> Textures { get; } = new Dictionary<string, Texture>();
    public Renderer(Shader shader)
    {
        this.VAO = GL.Oes.GenVertexArray();
        this.VBO = GL.GenBuffer();
        this.Shader = shader;
        GL.Oes.BindVertexArray(this.VAO);
    }

    public void BeginFrame()
    {
        this.Data.Reset();
    }

    public void Fill(Core.Path path)
    {
        this.RenderFill(path);
    }
    public void Stroke(Core.Path path)
    {
        this.RenderStroke(path);
    }
    public void Triangles(Vertex[] vertices, State state)
    {
        this.RenderTriangles(vertices, state);
    }

    public Size GetMaxTextureSize()
    {
        var maxTextureSize = GL.GetInteger(GetPName.MaxTextureSize);
        return new Size(maxTextureSize, maxTextureSize);
    }

    public int CreateTexture(ImageData imageData, TextureType textureType, ImageFlags flags, string alias)
    {
        var pixelFormat = textureType switch {
            TextureType.RGBA => PixelFormat.Rgba,
            TextureType.Alpha => PixelFormat.Alpha,
            _ => throw new Exception("Unexpected")
        };
        var textureComponentCount = textureType switch {
            TextureType.RGBA => TextureComponentCount.Rgba,
            TextureType.Alpha => TextureComponentCount.Alpha,
            _ => throw new Exception("Unexpected")
        };
        return this.CreateTexture(imageData, pixelFormat, textureComponentCount, alias);
    }
    
    public void UpdateTexture(int textureId, int x, int y, ImageData imageData, TextureType textureType)
    {
        var pixelFormat = textureType switch {
            TextureType.RGBA => PixelFormat.Rgba,
            TextureType.Alpha => PixelFormat.Alpha,
            _ => throw new Exception("Unexpected")
        };
        this.UpdateTexture(textureId, x, y, imageData, pixelFormat);
    }
    
    public Texture GetTexture(int textureId) =>
        this.Textures.Values.FirstOrDefault(x => x.Id == textureId) ?? throw new Exception("Unexpected");

    public void Render(CompositeOperationState compositeOperationState)
    {
        this.Data.Flush();
        this.RenderFrame();
    }

    public void Dispose()
    {
        // Unbind all the resources by binding the targets to 0/null.
        GL.BindBuffer(BufferTarget.ArrayBuffer, this.VBO);
        GL.Oes.BindVertexArray(this.VAO);

        // Delete all the resources.
        GL.DeleteBuffer(this.VBO);
        GL.Oes.DeleteVertexArray(this.VAO);
    }
}