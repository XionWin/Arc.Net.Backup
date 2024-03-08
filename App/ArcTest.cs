using Arc.Core;

namespace App;

public static class ArcTest
{

    public static List<(float p, int l)>? periods = null;
    public static Vertex[][] Test()
    {
        var context = new Context();
        var state = context.GetState();
        context.GetState().StrokeWidth = 24;
        context.GetState().LineCap = LineCap.Round;
        context.GetState().LineJoin = LineJoin.Round;
        var path = context.BeginPath();
        // path.AddCommand(new Command(CommandType.MoveTo, 100, 100));
        // path.AddCommand(new Command(CommandType.LineTo, 200, 200));
        // path.AddCommand(new Command(CommandType.LineTo, 400, 200));
        // path.AddCommand(new Command(CommandType.LineTo, 400, 400));
        
        var l = 400;
        var t = 240 * 2;
        // var r1 = 80;
        // var r2 = 120;

        var count = 10 * 2;
        if(periods is null)
        {
            var random = new Random();
            periods = new List<(float p, int l)>();
            for (int i = 0; i < count; i++)
            {
                periods.Add((random.NextSingle() * 20, random.Next(50, 150)));
            }
        }
        
        var x = 0f;
        var y = 0f;
        for (int i = 0; i < count / 2; i++)
        {
            var period = periods[i].p;
            var len = periods[i].l;
            var tick = ((float)DateTime.Now.Second + (float)DateTime.Now.Millisecond / 1000f) / period * (Math.PI * 2);

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

        
        x = 0f;
        y = 0f;
        for (int i = 0; i < count / 2; i++)
        {
            var period = -periods[i + count / 2].p;
            var len = periods[i + count / 2].l;
            l += 800 * 2 - 400 * 2;
            var tick = ((float)DateTime.Now.Second + (float)DateTime.Now.Millisecond / 1000f) / period * (Math.PI * 2);
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
        
        var vertices = path.Stroke(context);
        
        return vertices;
    }
} 