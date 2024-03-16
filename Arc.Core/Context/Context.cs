using Extension;

namespace Arc.Core;

public partial class Context
{
    public IRenderer Renderer { get; init; }
    // public NVGparams parameters;
    public CompositeOperationState CompositeOperationState { get; set; }
    private Stack<State> _states = new Stack<State>();
    public float TessTol { get; private set; }
    public float DistTol { get; private set; }
    public float FringeWidth { get; private set; }
    public float DevicePxRatio { get; private set; }
    public List<Path> Paths { get; } = new List<Path>();
    public Path LastEditPath => this.Paths.LastOrDefault() is Path lastPath ? lastPath : throw new Exception("Unexpected");
    public Context(IRenderer renderer, float ratio = 1)
    {
        this.Renderer = renderer;
        this.CompositeOperationState = new CompositeOperationState(CompositeOperation.SourceOver);
        this.TessTol = 0.25f / ratio;
        this.DistTol = 0.01f / ratio;
        this.FringeWidth = 1.0f / ratio;
        this.DevicePxRatio = ratio;
    }

    public void Reset()
    {
        this._states.Clear();
        this.Paths.Clear();
    }

    public void BeginPath() => this.With(x => x.Paths.Add(new Path(this)));

    public void AddCommand(Command command) => this.LastEditPath.AddCommand(command);

    public void Fill()
    {
        this.LastEditPath.Fill();
        this.Renderer.Fill(this.LastEditPath.Flush());
    }
    public void Stroke()
    {
        this.LastEditPath.Stroke();
        this.Renderer.Stroke(this.LastEditPath.Flush());
    }

    public void SaveState()
    {
        var currState = this._states.Peek();
        this._states.Push(currState.Clone());
    }

    public void RestoreState()
    {
        if(this._states.Count > 1)
            this._states.Pop();
    }

    public State GetState()
    {
        if(this._states.Any() is false)
        {
            var state = new State();
            this._states.Push(state);
        }
        return this._states.Peek();
    }

    public PathPrimitive[] Flush() => this.Paths.Select(x => x.Flush()).ToArray();
}

public static class ContextExtension
{
    public static void AddRectangle(this Context context, float l, float t, float w, float h)
    {
        context.LastEditPath.AddRectangle(l, t, w, h);
    }

    public static void AddEllipse(this Context context, float cx, float cy, float rx, float ry)
    {
        context.LastEditPath.AddEllipse(cx, cy, rx, ry);
    }
    
    public static void ArcTo(this Context context, float cx, float cy, float r, float a0, float a1, Winding winding)
    {
        context.LastEditPath.ArcTo(cx, cy, r, a0, a1, winding);
    }
}