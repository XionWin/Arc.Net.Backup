namespace Arc.Core;

public class Context
{
    // public NVGparams parameters;
    private Stack<State> _states = new Stack<State>();
    private Path? _path;
    private List<Path> _paths = new List<Path>();
    public List<Path> Paths => this._paths;
    public float TessTol { get; private set; }
    public float DistTol { get; private set; }
    public float FringeWidth { get; private set; }
    public float DevicePxRatio { get; private set; }

    public void BeginPath()
    {
        this._path = new Path();
        this._paths.Add(this._path);
    }
}

public static class ContextExtension
{
    public static void AddCommand(this Context context, Command command)
    {
        if(command.CommandType == CommandType.MoveTo)
        {
            context.Paths.Add(new Path());
        }
        if(context.Paths.LastOrDefault() is Path path && path.IsFinalized is false && path.IsClosed is false)
        {
            // switch (command.CommandType)
            // {
            //     case CommandType.MoveTo:
            //     case CommandType.LineTo:
            //         path.AddPoint(new Point(command.Values[0], command.Values[1], PointFlags.Corner));
            //         break;
            //     default:
            //         throw new NotImplementedException();
            // }
            if(command.CommandType == CommandType.Close)
            {
                path.IsClosed = true;
            }
            else if (command.CommandType == CommandType.Winding)
            {
                path.Winding = path.Winding switch {
                    Winding.CCW => Winding.CW,
                    _ => Winding.CCW
                };
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
}