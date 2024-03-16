using Arc.Core;

namespace Arc.ES20;

public enum CallType
{
    Fill,
    ConvexFill,
    Stroke,
    Triangle
}

public class RenderCall
{
    public CallType Type { get; private protected set; }
    public int Offset { get; internal set; }
    public int Length { get; internal set; }
    public int UniformOffset { get; internal set; }
    public int Image { get; internal set; }
    public RenderCall()
    {
        Type = CallType.Stroke;
    }
}

public class RenderFillCall: RenderCall
{
    public int TriangleOffset { get; internal set; }
    public int TriangleLength { get; internal set; }
    public int TriangleUniformOffset { get; internal set; }

    public RenderFillCall(bool isConvex): base()
    {
        Type = isConvex ? CallType.ConvexFill : CallType.Fill;
    }
}

public class RenderCache
{
    public List<RenderCall> Calls { get; } = new List<RenderCall>();
    public List<Vertex2> Vertices { get; } = new List<Vertex2>();
    public List<FragUniform> FragUniforms { get; } = new List<FragUniform>();

    public int AddCall(RenderCall call)
    {
        var offset = this.Calls.Count;
        this.Calls.Add(call);
        return offset;
    }

    public int AddVertices(IEnumerable<Vertex2> vertices)
    {
        var offset = this.Vertices.Count;
        this.Vertices.AddRange(vertices);
        return offset;
    }
    public int AddFragUniform(FragUniform frag)
    {
        var offset = this.FragUniforms.Count;
        this.FragUniforms.Add(frag);
        return offset;
    }
}