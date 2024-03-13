using Extension;

namespace Arc.Core;

public class Context
{
    // public NVGparams parameters;
    public CompositeOperationState CompositeOperationState { get; set; }
    private Stack<State> _states = new Stack<State>();
    public float TessTol { get; private set; }
    public float DistTol { get; private set; }
    public float FringeWidth { get; private set; }
    public float DevicePxRatio { get; private set; }

    private Path? _path = null;
    internal Path Path => this._path ?? throw new Exception("Unexpected");
    public List<Primitive> Primitives { get; } = new List<Primitive>();

    public static Context Instance = new Context();
    private Context(float ratio = 1)
    {
        this.CompositeOperationState = new CompositeOperationState(CompositeOperation.SourceOver);
        this.TessTol = 0.25f / ratio;
        this.DistTol = 0.01f / ratio;
        this.FringeWidth = 1.0f / ratio;
        this.DevicePxRatio = ratio;
    }

    public void Reset()
    {
        this._states.Clear();
        this.Primitives.Clear();
    }

    public Context BeginPath() => this.With(x => x._path = new Path(this));

    public void AddCommand(Command command) => this.Path.AddCommand(command);

    public void Stroke()
    {
        this.Primitives.Add(this.Path.Stroke());
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
}

public static class ContextExtension
{

    public static void AddEllipse(this Context context, float cx, float cy, float rx, float ry)
    {
        context.Path.AddEllipse(cx, cy, rx, ry);
    }
    
    public static void ArcTo(this Context context, float cx, float cy, float r, float a0, float a1, Winding winding)
    {
        context.Path.ArcTo(cx, cy, r, a0, a1, winding);
    }
}