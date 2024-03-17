using Arc.Core;

namespace Arc.ES20;

public class Renderer: IDataRenderer<RenderData>
{
    public RenderData Data { get; } = new RenderData();
    public void Create()
    {
        
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