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
        context.GetState().LineJoin = LineJoin.Bevel;
        var path = context.BeginPath();
        // path.AddCommand(new Command(CommandType.MoveTo, 100, 100));
        // path.AddCommand(new Command(CommandType.LineTo, 200, 200));
        // path.AddCommand(new Command(CommandType.LineTo, 400, 200));
        // path.AddCommand(new Command(CommandType.LineTo, 400, 400));
        
        var l = 100;
        var t = 240;
        var r = 100;

        var period = 3f;
        var tick1 = ((float)DateTime.Now.Second + (float)DateTime.Now.Millisecond / 1000f) / period * (Math.PI * 2);
        var tick2 = ((float)DateTime.Now.Second + (float)DateTime.Now.Millisecond / 1000f) / period * period * (Math.PI * 2);
        
        // tick = 0.49f * Math.PI;

        path.AddCommand(new Command(CommandType.MoveTo, (float)(l + r + r * Math.Cos(tick1)), (float)(t + r * Math.Sin(tick1))));
        path.AddCommand(new Command(CommandType.LineTo, l + r, t));
        path.AddCommand(new Command(CommandType.LineTo, (float)(l + r + r * Math.Cos(tick2)), (float)(t + r * Math.Sin(tick2))));
        // path.AddCommand(new Command(CommandType.Close));

        tick1 = -tick1;
        tick2 = -tick2;
        l += 500;
        path.AddCommand(new Command(CommandType.MoveTo, (float)(l + r * Math.Cos(tick1)), (float)(t + r * Math.Sin(tick1))));
        path.AddCommand(new Command(CommandType.LineTo, l, t));
        path.AddCommand(new Command(CommandType.LineTo, (float)(l + r * Math.Cos(tick2)), (float)(t + r * Math.Sin(tick2))));

        var vertices = path.Stroke(context);
        
        return vertices;
    }
} 