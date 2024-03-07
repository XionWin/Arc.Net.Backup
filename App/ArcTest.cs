using Arc.Core;

namespace App;

public static class ArcTest
{
    public static Vertex[][] Test()
    {
        var context = new Context();
        var state = context.GetState();
        context.GetState().StrokeWidth = 50;
        context.GetState().LineCap = LineCap.Round;
        var path = context.BeginPath();
        // path.AddCommand(new Command(CommandType.MoveTo, 100, 100));
        // path.AddCommand(new Command(CommandType.LineTo, 200, 200));
        // path.AddCommand(new Command(CommandType.LineTo, 400, 200));
        // path.AddCommand(new Command(CommandType.LineTo, 400, 400));
        
        var l = 100;
        var t = 100;
        var w = 100;
        var h = 100;

        path.AddCommand(new Command(CommandType.MoveTo, l, t));
        path.AddCommand(new Command(CommandType.LineTo, l + w, t));
        path.AddCommand(new Command(CommandType.LineTo, l + w, t + h));
        // path.AddCommand(new Command(CommandType.Close));

        l += 200;
        path.AddCommand(new Command(CommandType.MoveTo, l, t + h));
        path.AddCommand(new Command(CommandType.LineTo, l, t));
        path.AddCommand(new Command(CommandType.LineTo, l + w, t));

        var vertices = path.Stroke(context);
        
        return vertices;
    }
} 