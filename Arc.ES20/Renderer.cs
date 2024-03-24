#if KMS_MODE
using OpenGL.Graphics.ES20;
#else
using OpenTK.Graphics.ES20;
#endif
using Arc.Core;
using Extension;

namespace Arc.ES20;

public class Renderer : IDataRenderer<RenderData>, IDisposable
{
    public int VAO { get; init; }
    public int VBO { get; init; }
    public Shader Shader { get; init; }
    public RenderData Data { get; } = new RenderData();
    public Renderer(Shader shader)
    {
        this.VAO = GL.Oes.GenVertexArray();
        this.VBO = GL.GenBuffer();
        this.Shader = shader;
        GL.Oes.BindVertexArray(this.VAO);
    }

    public void Reset()
    {
        this.Data.Reset();
    }

    public int CreateTexture(ImageData imageData, TextureType textureType, ImageFlags flags)
    {
        return 0;
    }

    public void Fill(Core.Path path)
    {
        this.RenderFill(path);
    }
    public void Stroke(Core.Path path)
    {
        this.RenderStroke(path);
    }

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

public static class RendererExtension
{
    internal static void RenderStroke(this Renderer renderer, Core.Path path)
    {
        var (pathVertices, state) = path.Stroke();

        var aaFragOffset = renderer.Data.AddFragUniform(state.Clone().With(x => x.FringeWidth += 2).ToStrokeFragUniform(FragUniformType.FillGradient));
        var fragOffset = renderer.Data.AddFragUniform(state.ToStrokeFragUniform(FragUniformType.FillGradient));
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

    private static FragUniform ToStrokeFragUniform(this State state, FragUniformType type) =>
        new FragUniform()
        {
            Type = type,
            InnerColor = state.StrokePaint.InnerColor,
            StrokeMultiple = (state.StrokeWidth * 0.5f + state.FringeWidth * 0.5f) / state.FringeWidth,
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