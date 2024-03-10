using Arc.Core;
using Extension;

namespace App;

public static class ArcTest
{
    public static (Vertex[][] vertexGroup, Point[][] pointGroup) Test()
    {
        var vertexGroup = new List<Vertex[]>();
        var pointGroup = new List<Point[]>();

        var context = new Context();
        context.GetState().StrokeWidth = 32;
        context.GetState().LineCap = LineCap.Round;
        context.GetState().LineJoin = LineJoin.Round;

        var path1 = context.BeginPath();
        path1.DrawRectangle(500, 100);
        path1.DrawCurve(100, 100);
        path1.DrawCircle(800, 480);
        path1.DrawAnimationLines(800, 480);
        path1.DrawArc(1300, 480, 100);

        var left = 300;
        var top = 100;
        var width = 100;
        var heigt = 100;
        path1.AddCommand(new Command(CommandType.MoveTo, left, top));
        path1.AddCommand(new Command(CommandType.BezierTo, left + width, top, left + width, top + heigt, left, top + heigt));
        path1.AddCommand(new Command(CommandType.Close));

        vertexGroup.AddRange(path1.Stroke());
        pointGroup.AddRange(path1.Segments.Select(x => x.Points));
        
        // context.GetState().StrokeWidth = 24;
        // context.GetState().LineCap = LineCap.Butt;
        // context.GetState().LineJoin = LineJoin.Bevel;

        // var path2 = context.BeginPath();
        // path2.DrawRectangle(500 + 200, 100);
        // path2.DrawCurve(100 + 200, 100);
        // path2.DrawCircle(800 + 200, 480);
        // path2.DrawAnimationLines(800 + 200, 480);
        // path2.DrawArc(1300 + 200, 480, 100);

        // vertexGroup.AddRange(path2.Stroke());
        // pointGroup.AddRange(path2.Segments.Select(x => x.Points));

        return (vertexGroup.ToArray(), pointGroup.ToArray());
    }

    private static void DrawRectangle(this Arc.Core.Path path, int l, int t)
    {
        var w = 100;
        var h = 100;
        path.AddCommand(new Command(CommandType.MoveTo, l, t));
        path.AddCommand(new Command(CommandType.LineTo, l + w, t));
        path.AddCommand(new Command(CommandType.LineTo, l + w * 2, t));
        path.AddCommand(new Command(CommandType.LineTo, l + w * 2, t + h));
        path.AddCommand(new Command(CommandType.LineTo, l + w, t + h * 2));
    }

    const float KAPPA90 = 0.5522847493f;
    private static void DrawCurve(this Arc.Core.Path path, int l, int t)
    {
        var w = 100f;
        var h = 100f;
        var r = h / 2f;
        path.AddCommand(new Command(CommandType.MoveTo, l, t));
        path.AddCommand(new Command(CommandType.LineTo, l + w, t));
        path.AddCommand(new Command(CommandType.BezierTo, l + w + r * KAPPA90, t, l + w + r, t + r - r * KAPPA90, l + w + r, t + r));
        path.AddCommand(new Command(CommandType.BezierTo, l + w + r, t + r + r * KAPPA90, l + w + r * KAPPA90, t + h, l + w, t + h));
        path.AddCommand(new Command(CommandType.LineTo, l, t + h));
        // path.AddCommand(new Command(CommandType.BezierTo, l - w * KAPPA90, t + h, l - w * KAPPA90, t + h * 2, l, t + h * 2));
        // path.AddCommand(new Command(CommandType.LineTo, l + w, t + h * 2));
    }

    private static void DrawCircle(this Arc.Core.Path path, int l, int t)
    {
        path.AddEllipse(l, t, 100, 100);
        path.AddEllipse(l, t, 200, 140);
        path.AddEllipse(l, t, 140, 200);
    }

    private static DateTime START_TIME = DateTime.Now;
    public static List<(float p, int l)>? parameters = null;
    private static void DrawAnimationLines(this Arc.Core.Path path, int l, int t)
    {
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
    }

    private static void DrawArc(this Arc.Core.Path path, int cx, int cy, int r)
    {
        path.AddCommand(new Command(CommandType.MoveTo, cx - r, cy - r));
        path.ArcTo(cx, cy, r, (float)Math.PI / 3, (float)Math.PI * 2 / 3, Winding.CW);
    }
} 