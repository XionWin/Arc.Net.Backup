using Arc.Core;
using OpenTK.Graphics.ES20;

namespace Arc.ES20;

public class Renderer: IDataRenderer<RenderData>, IDisposable
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

    public void Clear()
    {
        this.Data.Clear();
    }

    public int CreateTexture(ImageData imageData, TextureType textureType, ImageFlags flags)
    {
        return 0;
    }

    public void Render()
    {

    }

    public void Fill(Core.Path path)
    {
        this.RenderFill(path);
    }
    public void Stroke(Core.Path path)
    {
        this.RenderStroke(path);
    }

    public void Flush(CompositeOperationState compositeOperationState)
    {
        this.Data.Flush();

        GL.Oes.BindVertexArray(this.VAO);
        // bind vbo and set data for vbo
        GL.BindBuffer(BufferTarget.ArrayBuffer, this.VBO);
        var vertices = this.Data.Vertices.GetRaw();
        GL.BufferData(BufferTarget.ArrayBuffer, vertices.Length * sizeof(float), vertices, BufferUsageHint.StaticDraw);
        this.Shader.EnableAttribs(Vertex2.AttribLocations);

        var fragUniforms = this.Data.FragUniforms;
        foreach (var call in this.Data.Calls)
        {
            if(call.Type is CallType.Stroke)
            {
                GL.Enable(EnableCap.Blend);
                GL.BlendFunc(BlendingFactorSrc.One, BlendingFactorDest.OneMinusSrcAlpha);

                this.Shader.Uniform4(
                    "aFrag",
                    fragUniforms[call.UniformOffset].Values
                );
                GL.DrawArrays(PrimitiveType.TriangleStrip, call.Offset, call.Length);
            }
            else if(call.Type is CallType.Fill)
            {
                if(call is RenderFillCall renderFillCall)
                {
                    GL.Enable(EnableCap.Blend);
                    GL.BlendFunc(BlendingFactorSrc.SrcAlpha, BlendingFactorDest.OneMinusSrcAlpha);

                    GL.Enable(EnableCap.StencilTest);
                    GL.StencilMask(0xff);
                    GL.StencilFunc(StencilFunction.Always, 0x00, 0xff);
                    GL.ColorMask(false, false, false, false);
                    
                    this.Shader.Uniform4(
                        "aFrag",
                        fragUniforms[renderFillCall.UniformOffset].Values
                    );

                    GL.StencilOpSeparate(StencilFace.Front, StencilOp.Keep, StencilOp.Keep, StencilOp.IncrWrap);
                    GL.StencilOpSeparate(StencilFace.Back, StencilOp.Keep, StencilOp.Keep, StencilOp.DecrWrap);
                    GL.Disable(EnableCap.CullFace);

                    GL.DrawArrays(PrimitiveType.TriangleFan, renderFillCall.Offset, renderFillCall.Length);

                    GL.Enable(EnableCap.CullFace);
                    GL.ColorMask(true, true, true, true);

                    this.Shader.Uniform4(
                        "aFrag",
                        fragUniforms[renderFillCall.TriangleUniformOffset].Values
                    );

                    GL.StencilFunc(StencilFunction.Notequal, 0x0, 0xff);
                    GL.StencilOp(StencilOp.Zero, StencilOp.Zero, StencilOp.Zero);

                    GL.DrawArrays(PrimitiveType.TriangleStrip, renderFillCall.TriangleOffset, renderFillCall.TriangleLength);
                    
                    GL.Disable(EnableCap.StencilTest);
                    GL.Disable(EnableCap.CullFace);
                }
                else
                {
                    throw new Exception("Unexpected");
                }
            }
            else if(call.Type is CallType.ConvexFill)
            {
                GL.Enable(EnableCap.Blend);
                GL.BlendFunc(BlendingFactorSrc.SrcAlpha, BlendingFactorDest.OneMinusSrcAlpha);
                this.Shader.Uniform4(
                    "aFrag",
                    fragUniforms[call.UniformOffset].Values
                );
                GL.DrawArrays(PrimitiveType.TriangleFan, call.Offset, call.Length);
            }
            else if(call.Type is CallType.Triangle)
            {
                this.Shader.Uniform4(
                    "aFrag",
                    fragUniforms[call.UniformOffset].Values
                );
                GL.DrawArrays(PrimitiveType.TriangleStrip, call.Offset, call.Length);
            }
        }
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

        var fragOffset = renderer.Data.AddFragUniform(state.ToStrokeFragUniform(FragUniformType.FillGradient));
        var vertices = pathVertices.ToVertex2();
        var offset = renderer.Data.AddVertices(vertices);
        var length = vertices.Length;

        var call = new RenderCall()
        {
            Offset = offset,
            Length = length,
            UniformOffset = fragOffset,
            Image = 0
        };
        renderer.Data.AddCall(call);
    }
    internal static void RenderFill(this Renderer renderer, Core.Path path)
    {
        var (pathVertices, state) = path.Fill();

        var fillFragOffset = renderer.Data.AddFragUniform(state.ToFillFragUniform(FragUniformType.FillGradient));
        var triangleFragOffset = renderer.Data.AddFragUniform(state.ToFillFragUniform(FragUniformType.Simple));
        
        var fillVertices = pathVertices.ToVertex2();
        var fillOffset = renderer.Data.AddVertices(fillVertices);
        var fillLength = fillVertices.Length;

        if(path.Bounds is Rect bounds)
        {
            var triangleVertices = bounds.ToVertex2();
            var triangleOffset = renderer.Data.AddVertices(triangleVertices);
            var triangleLength = triangleVertices.Length;
            var fillCall = new RenderFillCall(path.IsConvex)
            {
                Offset = fillOffset,
                Length = fillLength,
                UniformOffset = path.IsConvex ? fillFragOffset: triangleFragOffset,
                TriangleOffset = triangleOffset,
                TriangleLength = triangleLength,
                TriangleUniformOffset = path.IsConvex ? triangleFragOffset : fillFragOffset,
                Image = 0
            };
            renderer.Data.AddCall(fillCall);
        }
        else
        {
            throw new Exception("Unexpected");
        }

    }

    private static FragUniform ToFillFragUniform(this State state, FragUniformType type) =>
        new FragUniform()
        {
            Type = type,
            StrokeMultiple = state.StrokeWidth,
            InnerColor = state.FillPaint.InnerColor
        };
    private static FragUniform ToStrokeFragUniform(this State state, FragUniformType type) =>
        new FragUniform()
        {
            Type = type,
            StrokeMultiple = state.StrokeWidth,
            InnerColor = state.StrokePaint.InnerColor
        };
    private static Vertex2[] ToVertex2(this Vertex[] vertices)
    {
        return vertices.Select(x => new Vertex2(x.Position.X, x.Position.Y, x.Coordinate.X, x.Coordinate.Y)).ToArray();
    }
    private static Vertex2[] ToVertex2(this Rect bounds)
    {
        return [
            new Vertex2(bounds.Left, bounds.Top, 0.5f, 1),
            new Vertex2(bounds.Left, bounds.Bottom, 0.5f, 1),
            new Vertex2(bounds.Right, bounds.Top, 0.5f, 1),
            new Vertex2(bounds.Right, bounds.Bottom, 0.5f, 1),
        ];
    }


}