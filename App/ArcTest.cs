using Arc.Core;
using Extension;

namespace App;

public static class ArcTest
{
    const float KAPPA90 = 0.5522847493f;
    private static DateTime START_TIME = DateTime.Now;
    public static List<(float p, int l)>? parameters = null;
    public static (Vertex[][] vertexGroup, Point[][] pointGroup) Test()
    {
        var context = new Context();
        var state = context.GetState();
        context.GetState().StrokeWidth = 32;
        context.GetState().LineCap = LineCap.Round;
        context.GetState().LineJoin = LineJoin.Round;
        var path = context.BeginPath();
        path.AddCommand(new Command(CommandType.MoveTo, 100, 200));
        path.AddCommand(new Command(CommandType.LineTo, 200, 200));
        path.AddCommand(new Command(CommandType.BezierTo, 200 + 100 * KAPPA90, 200, 200 + 100 * KAPPA90, 300, 200, 300));
        path.AddCommand(new Command(CommandType.LineTo, 100, 300));
        path.AddCommand(new Command(CommandType.BezierTo, 100 - 100 * KAPPA90, 300, 100 - 100 * KAPPA90, 400, 100, 400));

        path.AddEllipse(800, 480, 100, 100);
        
        var l = 800;
        var t = 240 * 2;

        if(parameters is List<(float p, int l)> ps)
        {
            var count = parameters?.Count ?? 0;
        
            float x = l;
            float y = t;
            path.AddCommand(new Command(CommandType.MoveTo, x, y));
            float ticks = 0;
            for (int i = 0; i < count; i++)
            {
                var period = ps[i].p;
                var len = ps[i].l;
                var tick = (float)((float)(DateTime.Now - START_TIME).TotalMilliseconds / 1000f / period % 1 * (Math.PI * 2)); 
                ticks += tick;
                x += (float)(len * Math.Cos(ticks));
                y += (float)(len * Math.Sin(ticks));

                path.AddCommand(new Command(CommandType.LineTo, x, y));
            }
        }
        else
        {
            parameters = new List<(float p, int l)>();
            parameters.Add((8, 200));
            parameters.Add((6, 200));
            parameters.Add((4, 200));
            parameters.Add((2, 200));
        }

        {
            var period = 2;
            var len = 250;
            var tick = (float)(DateTime.Now - START_TIME).TotalMilliseconds / 1000f / period % 1 * (Math.PI * 2);   
            
            path.AddCommand(new Command(CommandType.MoveTo, l, t));    
            path.AddCommand(new Command(CommandType.LineTo, l + (float)(len * Math.Cos(tick)), t + (float)(len * Math.Sin(tick))));
        }
        

        // var period = 2f;
        // var tick1 = ((float)DateTime.Now.Second + (float)DateTime.Now.Millisecond / 1000f) / period * (Math.PI * 2);
        // var tick2 = ((float)DateTime.Now.Second + (float)DateTime.Now.Millisecond / 1000f) / (period * period) * (Math.PI * 2);
        
        // // tick1 = 0.5f * Math.PI;
        // // tick2 = 1.5f * Math.PI;

        // path.AddCommand(new Command(CommandType.MoveTo, (float)(l + r1 + r1 * Math.Cos(tick1)), (float)(t + r1 * Math.Sin(tick1))));
        // path.AddCommand(new Command(CommandType.LineTo, l + r1, t));
        // path.AddCommand(new Command(CommandType.LineTo, (float)(l + r1 + r2 * Math.Cos(tick2)), (float)(t + r2 * Math.Sin(tick2))));
        // path.AddCommand(new Command(CommandType.LineTo, (float)(l + r1 + r2 * Math.Cos(tick2) + r1 * Math.Cos(tick1)), (float)(t + r2 * Math.Sin(tick2) + r1 * Math.Sin(tick1))));
        // // path.AddCommand(new Command(CommandType.Close));

        // tick1 = -tick1;
        // tick2 = -tick2;
        // l += 400;
        // path.AddCommand(new Command(CommandType.MoveTo, (float)(l + r1 * Math.Cos(tick1)), (float)(t + r1 * Math.Sin(tick1))));
        // path.AddCommand(new Command(CommandType.LineTo, l, t));
        // path.AddCommand(new Command(CommandType.LineTo, (float)(l + r2 * Math.Cos(tick2)), (float)(t + r2 * Math.Sin(tick2))));
        // path.AddCommand(new Command(CommandType.LineTo, (float)(l + r2 * Math.Cos(tick2) + r1 * Math.Cos(tick1)), (float)(t + r2 * Math.Sin(tick2) + r1 * Math.Sin(tick1))));
        // path.AddCommand(new Command(CommandType.LineTo, (float)(l + 2 * r2 * Math.Cos(tick2) + r1 * Math.Cos(tick1)), (float)(t + 2 * r2 * Math.Sin(tick2) + r1 * Math.Sin(tick1))));
        // path.AddCommand(new Command(CommandType.LineTo, (float)(l + 2 * r2 * Math.Cos(tick2) + 2 * r1 * Math.Cos(tick1)), (float)(t + 2 * r2 * Math.Sin(tick2) + 2 * r1 * Math.Sin(tick1))));
        // path.AddCommand(new Command(CommandType.LineTo, (float)(l + 3 * r2 * Math.Cos(tick2) + 2 * r1 * Math.Cos(tick1)), (float)(t + 3 * r2 * Math.Sin(tick2) + 2 * r1 * Math.Sin(tick1))));
        
        var vertexGroup = path.Stroke();

        var pointGroup = path.Segments.Select(x => x.Points).ToArray();
        
        
        return (vertexGroup, pointGroup);
    }
} 