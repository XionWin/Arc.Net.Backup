using Extension;

namespace Arc.Core;

public class Context
{
    // public NVGparams parameters;
    private Stack<State> _states = new Stack<State>();
    private List<Path> _paths = new List<Path>();
    public List<Path> Paths => this._paths;
    public float TessTol { get; private set; }
    public float DistTol { get; private set; }
    public float FringeWidth { get; private set; }
    public float DevicePxRatio { get; private set; }

    public Context(float ratio = 1)
    {
        this.TessTol = 0.25f / ratio;
        this.DistTol = 0.01f / ratio;
        this.FringeWidth = 1.0f / ratio;
        this.DevicePxRatio = ratio;
    }
    
    public Path BeginPath() => new Path().With(x => this._paths.Add(x));

    public void SaveSate()
    {
        var currState = this._states.Peek();
        this._states.Push(currState.Clone());
    }

    public void RestoreSate()
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
    internal static int CurveDivs(this Context context, State state)
    {
        var aaWidth = context.GetedgeAntiAliasWidth(state);
        float da = (float)Math.Acos(aaWidth / (aaWidth + context.TessTol)) * 2.0f;
        return Math.Max(2, (int)Math.Ceiling(Math.PI / da));
    }
    
    private static float GetedgeAntiAliasWidth(this Context context, State state) => 
        (state.StrokeWidth + context.FringeWidth) / 2;
}