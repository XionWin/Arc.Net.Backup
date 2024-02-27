namespace App.VG;

public enum PathType
{
    Stroke,
    Fill
}

public class CommandCache
{
    private List<Command> _commands = new List<Command>();
    public List<Command> Commands => this._commands;

    
    public void AddCommand(Command command)
    {
        this.Commands.Add(command);
    }

    public void Clean()
    {
        this._commands.Clear();
    }
    
}

public static class CommandCacheExtension
{
    internal static List<Path> IntoPath(this CommandCache commandCache)
    {
        var paths = new List<Path>();
        foreach (var command in commandCache.Commands)
        {
            if(command.CommandType == CommandType.MoveTo)
            {
                paths.Add(new Path());
            }
            if(paths.LastOrDefault() is Path path && path.IsClosed is false)
            {
                path.AddCommand(command);
            }
            else
            {
                throw new Exception("Can't find the last path");
            }
        }
        return paths;
    }
}