namespace Arc.ES20;

public enum CallType
{
    Fill,
    ConvexFill,
    Stroke,
    Rectangle
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

public class RenderData
{
    private List<RenderCall> _calls = new List<RenderCall>();
    private List<Vertex2> _vertices = new List<Vertex2>();
    private List<FragUniform> _fragUniforms = new List<FragUniform>();
    public  RenderCall[] Calls { get; private set; } = [];
    public Vertex2[] Vertices { get; private set; } = [];
    public FragUniform[] FragUniforms { get; private set; } = [];

    public int AddCall(RenderCall call)
    {
        var offset = this._calls.Count;
        this._calls.Add(call);
        return offset;
    }

    public int AddVertices(IEnumerable<Vertex2> vertices)
    {
        var offset = this._vertices.Count;
        this._vertices.AddRange(vertices);
        return offset;
    }

    public int AddFragUniform(FragUniform frag)
    {
        var offset = this._fragUniforms.Count;
        this._fragUniforms.Add(frag);
        return offset;
    }

    public void Flush()
    {
        this.Calls = this._calls.ToArray();
        this.Vertices = this._vertices.ToArray();
        this.FragUniforms = this._fragUniforms.ToArray();
    }

    public void Reset()
    {
        this._calls.Clear();
        this._vertices.Clear();
        this._fragUniforms.Clear();
    }
}