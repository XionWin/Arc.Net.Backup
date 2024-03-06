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

    public Path BeginPath() => new Path().With(x => this._paths.Add(x));
}

public static class ContextExtension
{
}