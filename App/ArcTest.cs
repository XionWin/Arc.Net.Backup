using Arc.Core;
using Extension;

namespace App;

public static class ArcTest
{
    static int MARGIN = 20;
    public static (Vertex[][] vertexGroup, Point[][] pointGroup) Test()
    {
        var vertexGroup = new List<Vertex[]>();
        var pointGroup = new List<Point[]>();

        var context = new Context();
        context.GetState().StrokeWidth = 2;
        context.GetState().LineCap = LineCap.Round;
        context.GetState().LineJoin = LineJoin.Round;

        var path1 = context.BeginPath();
        path1.DrawCurve(MARGIN, MARGIN + 28, 48, 36);
        path1.DrawCircle(400, 240, 50);
        path1.DrawClock(800 - MARGIN - 64 - MARGIN - 64, MARGIN + 64, 64);
    
        vertexGroup.AddRange(path1.Stroke());
        pointGroup.AddRange(path1.Segments.Select(x => x.Points));

        return (vertexGroup.ToArray(), pointGroup.ToArray());
    }


    const float KAPPA90 = 0.5522847493f;
    private static void DrawCurve(this Arc.Core.Path path, int l, int t, int w, int h)
    {
        var r = h / 2f;
        path.AddCommand(new Command(CommandType.MoveTo, l + r, t));
        path.AddCommand(new Command(CommandType.LineTo, l + r + w, t));
        path.AddCommand(new Command(CommandType.BezierTo, l + r + w + r * KAPPA90, t, l + r + w + r, t + r - r * KAPPA90, l + r + w + r, t + r));
        path.AddCommand(new Command(CommandType.BezierTo, l + r + w + r, t + r + r * KAPPA90, l + r + w + r * KAPPA90, t + h, l + r + w, t + h));
        path.AddCommand(new Command(CommandType.LineTo, l + r, t + h));

        path.AddCommand(
            new Command(
                CommandType.BezierTo, 
                l + r - r * KAPPA90, t + h,
                l, t + r + r * KAPPA90,
                l, t + r
            )
        );
        path.AddCommand(
            new Command(
                CommandType.BezierTo, 
                l, t + r - r * KAPPA90,
                l + r - r * KAPPA90, t,
                l+ r, t
            )
        );

        var cr = r * 0.8f;
        path.AddEllipse(l + r, t + r, cr, cr);
    }

    private static void DrawCircle(this Arc.Core.Path path, int l, int t, int r)
    {
        path.AddEllipse(l, t, r, r);
        path.AddEllipse(l, t, r * 2, r * 1.4f);
        path.AddEllipse(l, t, r * 1.4f, r * 2);
    }

    static (float h, float m, float s) RATES = (60f * 60f * 1000f, 60f * 1000f, 1000f);
    private static void DrawClock(this Arc.Core.Path path, int cx, int cy, int r)
    {
        var now = DateTime.Now;
        var ms = now.Hour * RATES.h + now.Minute * RATES.m + now.Second * RATES.s + now.Millisecond;
        var h = ms / RATES.h;
        var m = ms % RATES.h / RATES.m;
        var s = ms % RATES.h % RATES.m /RATES.s;
        (float dir, float len)[] pointers = [
            ((float)(h / 12f * Math.PI * 2), r * 0.55f),
            ((float)(m / 60f * Math.PI * 2), r * 0.75f),
            ((float)(s / 60f * Math.PI * 2), r * 0.85f),
        ];
        path.AddEllipse(cx, cy, r, r);
        path.AddEllipse(cx, cy, 2, 2);
        path.AddEllipse(cx, cy, 3, 3);
        for (int i = 0; i < 12; i++)
        {
            if(i % 3 == 0)
            {
                continue;
            }
            var dir = Math.PI / 6 * i;
            var start = r * 0.92f;
            path.AddCommand(new Command(CommandType.MoveTo, cx + start * (float)Math.Sin(dir), cy + start * (float)Math.Cos(dir)));
            path.AddCommand(new Command(CommandType.LineTo, cx + r * (float)Math.Sin(dir), cy + r * (float)Math.Cos(dir)));
        }
        for (int i = 0; i < 4; i++)
        {
            var dir = Math.PI / 2 * i;
            var start = r * 0.8f;
            path.AddCommand(new Command(CommandType.MoveTo, cx + start * (float)Math.Sin(dir), cy + start * (float)Math.Cos(dir)));
            path.AddCommand(new Command(CommandType.LineTo, cx + r * (float)Math.Sin(dir), cy + r * (float)Math.Cos(dir)));
        }
        foreach (var pointer in pointers)
        {
            path.AddCommand(new Command(CommandType.MoveTo, cx, cy));
            var dir = -pointer.dir + Math.PI;
            var len = pointer.len;
            path.AddCommand(new Command(CommandType.LineTo, cx + len * (float)Math.Sin(dir), cy + len * (float)Math.Cos(dir)));
        }
    }

} 