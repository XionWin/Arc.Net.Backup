using Arc.Core;

namespace App;

public static class ArcTest
{
    public static Vertex[] Test()
    {
        var context = new Context();

        var path = context.BeginPath();
        // path.AddCommand(new Command(CommandType.MoveTo, 100, 100));
        // path.AddCommand(new Command(CommandType.LineTo, 200, 200));
        // path.AddCommand(new Command(CommandType.LineTo, 400, 200));
        // path.AddCommand(new Command(CommandType.LineTo, 400, 400));
        
        path.AddCommand(new Command(CommandType.MoveTo, 100, 100));
        path.AddCommand(new Command(CommandType.LineTo, 200, 100));
        path.AddCommand(new Command(CommandType.LineTo, 200, 200));
        path.AddCommand(new Command(CommandType.LineTo, 100, 200));

        path.Complete(context);
        
        return [];
    }
} 