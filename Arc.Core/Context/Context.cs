namespace Arc.Core;

public class Context<T>: IContext
    where T: IRenderer
{
    public T Renderer { get; init; }
    public CompositeOperationState CompositeOperationState { get; set; }
    private Stack<State> _states = new Stack<State>();
    public float TessTol { get; private set; }
    public float DistTol { get; private set; }
    public float FringeWidth { get; private set; }
    public float DevicePxRatio { get; private set; }
    public List<Path> Paths { get; } = new List<Path>();
    public Path LastPath => this.Paths.LastOrDefault() is Path lastPath ? lastPath : throw new Exception("Unexpected");
    public Context(T renderer, float ratio = 1)
    {
        this.Renderer = renderer;
        this.CompositeOperationState = new CompositeOperationState(CompositeOperation.SourceOver);
        this.TessTol = 0.25f / ratio;
        this.DistTol = 0.01f / ratio;
        this.FringeWidth = 1.0f / ratio;
        this.DevicePxRatio = ratio;
    }

    public void BeginFrame()
    {
        this._states.Clear();
        this.Paths.Clear();
        this.Renderer.Clear();
    }

    public void AddCommand(CommandType commandType, params float[] values)
    {
        var command = commandType switch
        {
            CommandType.MoveTo when values.Length == 2 => new Command(commandType, values[0], values[1]),
            CommandType.LineTo when values.Length == 2 => new Command(commandType, values[0], values[1]),
            CommandType.BezierTo when values.Length == 2 => new Command(commandType, values[0], values[1], values[2], values[3], values[4], values[5]),
            CommandType.Close => new Command(commandType),
            _ => throw new Exception("Unexpected")
        };
        this.AddCommand(command);
    }

    public void AddCommand(Command command)
    {
        
        if(command.CommandType == CommandType.MoveTo)
        {
            this.Paths.Add(new Path(this));
        }
        if(this.LastPath is Path path && path.IsClosed is false)
        {
            if(command.CommandType == CommandType.Close)
            {
                path.IsClosed = true;
            }
            else
            {
                path.AddCommand(command);
            }
        }
        else
        {
            throw new Exception("Can't find the last path");
        }
    }

    public void Fill()
    {
        this.Renderer.Fill(this.LastPath);
    }

    public void Stroke()
    {
        this.Renderer.Stroke(this.LastPath);
    }

    public void EndFrame()
    {
        this.Renderer.Flush(this.CompositeOperationState);
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
