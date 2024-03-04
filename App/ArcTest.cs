using Arc.Core;

namespace App;

public static class ArcTest
{
    public static Vertex[] Test()
    {
        var context = new Context();

        context.AddCommand(new Command(CommandType.MoveTo, 100, 100));
        context.AddCommand(new Command(CommandType.LineTo, 200, 200));
        context.AddCommand(new Command(CommandType.LineTo, 400, 200));
        context.AddCommand(new Command(CommandType.LineTo, 400, 400));
        
        return [];
    }
} 