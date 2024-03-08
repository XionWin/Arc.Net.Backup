using Arc.Core;
using Extension;

namespace App;

public static class ArcTest
{
    const float KAPPA90 = 0.5522847493f;
    private static DateTime START_TIME = DateTime.Now;
    public static List<(float p, int l)>? parameters = null;
    public static Vertex[][] Test()
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
        var count = 6;
        if(parameters is null)
        {
            var random = new Random();
            parameters = new List<(float p, int l)>();
            var ps = new List<float>();
            var ls = new List<int>();
            for (int i = 0; i < count; i++)
            {
                ps.Add(random.Next(1, 4));
                ls.Add(random.Next(64, 256));
            }
            ps.With(x => x.Sort()).Reverse();
            ls.With(x => x.Sort()).Reverse();

            for (int i = 0; i < count; i++)
            {
                parameters.Add((ps[i], ls[i]));
            }
        }
        
        var x = 0f;
        var y = 0f;
        var period = 0f;
        for (int i = 0; i < count; i++)
        {
            period += parameters[i].p;
            var len = parameters[i].l;
            var tick = (float)(DateTime.Now - START_TIME).TotalMilliseconds / 1000f / period * (Math.PI * 2);

            if(i == 0)
            {
                x += l;
                y += t;
                path.AddCommand(new Command(CommandType.MoveTo, x, y));
            }
            else
            {
                x += (float)(len * Math.Cos(tick));
                y += (float)(len * Math.Sin(tick));

                path.AddCommand(new Command(CommandType.LineTo, x, y));
            }
        }

        {
            period = 10;
            var len = 250;
            var tick = (float)(DateTime.Now - START_TIME).TotalMilliseconds / 1000f / period * (Math.PI * 2);   
            
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
        
        var vertices = path.Stroke();
        
        return vertices;
    }
} 