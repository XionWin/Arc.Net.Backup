#if KMS_MODE
using OpenGL.Graphics.ES20;
#else
using OpenTK.Graphics.ES20;
#endif
using Arc.Core;
using Extension;

namespace Arc.ES20;

public static class RendererExtension
{
    internal static int CreateTexture(this Renderer renderer, ImageData imageData, PixelFormat pixelFormat, TextureComponentCount textureComponentCount, string alias)
    {
        var texture = new Texture(TextureUnit.Texture0, TextureMinFilter.Linear).With(x => x.LoadRaw(imageData.Value, imageData.Width, imageData.Height, pixelFormat, textureComponentCount));
        renderer.Textures.Add(
            alias,  texture
        );
        return texture.Id;
    }

    internal static void UpdateTexture(this Renderer renderer, int textureId, int x, int y, ImageData imageData, PixelFormat pixelFormat)
    {
        var texture = renderer.Textures.Values.FirstOrDefault(x => x.Id == textureId) ?? throw new Exception("Unexpected");
        GL.ActiveTexture(texture.TextureUnit);
        GL.BindTexture(TextureTarget.Texture2D, texture.Id);
        
        GL.TexSubImage2D(TextureTarget2d.Texture2D, 0, x, y, imageData.Width, imageData.Height, pixelFormat, PixelType.UnsignedByte, imageData.Value);
    }
    
    internal static void RenderStroke(this Renderer renderer, Core.Path path)
    {
        var (pathVertices, state) = path.Stroke();

        var aaFragOffset = renderer.Data.AddFragUniform(state.ToStrokeFragUniform(FragUniformType.FillGradient, path.Context.FringeWidth * 2));
        var fragOffset = renderer.Data.AddFragUniform(state.ToStrokeFragUniform(FragUniformType.FillGradient, path.Context.FringeWidth));
        var vertices = pathVertices.ToVertex2();
        var offset = renderer.Data.AddVertices(vertices);
        var length = vertices.Length;

        var aaCall = new RenderCall()
        {
            Offset = offset,
            Length = length,
            UniformOffset = aaFragOffset,
            Texture = 0
        };
        renderer.Data.AddCall(aaCall);

        var call = new RenderCall()
        {
            Offset = offset,
            Length = length,
            UniformOffset = fragOffset,
            Texture = 0
        };
        renderer.Data.AddCall(call);
    }
    internal static void RenderFill(this Renderer renderer, Core.Path path)
    {
        var (pathVertices, state) = path.Fill();

        var fillFragUniform = state.ToFillFragUniform(FragUniformType.FillGradient);
        var fillFragOffset = renderer.Data.AddFragUniform(fillFragUniform);
        var triangleFragOffset = renderer.Data.AddFragUniform(state.ToFillFragUniform(FragUniformType.Simple));

        var fillVertices = pathVertices.ToVertex2();
        var fillOffset = renderer.Data.AddVertices(fillVertices);
        var fillLength = fillVertices.Length;

        if (path.Bounds is Rect bounds)
        {
            var triangleVertices = bounds.ToVertex2();
            var triangleOffset = renderer.Data.AddVertices(triangleVertices);
            var triangleLength = triangleVertices.Length;
            var fillCall = new RenderFillCall(path.IsConvex)
            {
                Offset = fillOffset,
                Length = fillLength,
                UniformOffset = path.IsConvex ? fillFragOffset : triangleFragOffset,
                TriangleOffset = triangleOffset,
                TriangleLength = triangleLength,
                TriangleUniformOffset = path.IsConvex ? triangleFragOffset : fillFragOffset,
                Texture = state.FillPaint.Texture ?? 0
            };
            renderer.Data.AddCall(fillCall);
        }
        else
        {
            throw new Exception("Unexpected");
        }
    }
    
    internal static void RenderTriangles(this Renderer renderer, Vertex[] vertices, State state)
    {
        var triangleFragUniform = state.ToTrianglesFragUniform(FragUniformType.Image);
        var triangleFragOffset = renderer.Data.AddFragUniform(triangleFragUniform);

        var triangleVertices = vertices.ToVertex2();
        var triangleOffset = renderer.Data.AddVertices(triangleVertices);
        var triangleLength = triangleVertices.Length;

        var triangleCall = new RenderTriangleCall()
        {
            Offset = triangleOffset,
            Length = triangleLength,
            UniformOffset = triangleFragOffset,
            Texture = state.FillPaint.Texture ?? 0
        };
        renderer.Data.AddCall(triangleCall);
    }

    private static FragUniform ToTrianglesFragUniform(this State state, FragUniformType type) =>
        new FragUniform()
        {
            Type = type,
            InnerColor = state.FillPaint.InnerColor,
            StrokeMultiple = float.MaxValue,
        };

    private static FragUniform ToFillFragUniform(this State state, FragUniformType type) =>
        state.FillPaint.Texture is int texture ?
        state.ToFillTextureFragUniform() :
        new FragUniform()
        {
            Type = type,
            InnerColor = state.FillPaint.InnerColor,
            StrokeMultiple = float.MaxValue,
        };

    private static FragUniform ToFillTextureFragUniform(this State state) =>
        new FragUniform()
        {
            Type = FragUniformType.FillTexture,
            InnerColor = state.FillPaint.InnerColor,
            OuterColor = state.FillPaint.OuterColor,
            PaintMatrix = state.FillPaint.Transform.ToMatrix3x4(),
            Extent = state.FillPaint.Extent,
            ScissorExtent = state.Scissor?.Extent ?? new Extent(1, 1),
            ScissorScale = new Scale(1, 1),
            StrokeMultiple = float.MaxValue,
        };

    private static FragUniform ToStrokeFragUniform(this State state, FragUniformType type, float fringeWidth) =>
        new FragUniform()
        {
            Type = type,
            InnerColor = state.StrokePaint.InnerColor,
            StrokeMultiple = (state.StrokeWidth * 0.5f + fringeWidth * 0.5f) / fringeWidth,
        };

    private static Vertex2[] ToVertex2(this Vertex[] vertices)
    {
        return vertices.Select(x => new Vertex2(x.Position.X, x.Position.Y, x.Coordinate.X, x.Coordinate.Y)).ToArray();
    }

    private static Vertex2[] ToVertex2(this Rect bounds) =>
        [
            new Vertex2(bounds.Left, bounds.Top, 0.5f, 1),
            new Vertex2(bounds.Left, bounds.Bottom, 0.5f, 1),
            new Vertex2(bounds.Right, bounds.Top, 0.5f, 1),
            new Vertex2(bounds.Right, bounds.Bottom, 0.5f, 1),
        ];

    private static Matrix3x4 ToMatrix3x4(this Matrix2x3 matrix) =>
        new Matrix3x4(
            matrix.M11, matrix.M12, 0, 0,
            matrix.M21, matrix.M22, 0, 0,
            matrix.M31, matrix.M32, 0, 0
        );
}