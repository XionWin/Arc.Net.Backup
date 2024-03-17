using Arc.Core;
using Arc.ES20;

namespace App;

public static class ArcTest
{
    static int MARGIN = 20;
    
    public static RenderCache Test()
    {
        var renderer = new Renderer();
        var context = new Context(renderer);
        context.BeginFrame();

        context.GetState().StrokeWidth = 2;
        context.GetState().LineCap = LineCap.Round;
        context.GetState().LineJoin = LineJoin.Round;
        context.GetState().StrokePaint.InnerColor = new Color(128, 140, 216, 255);
        context.GetState().FillPaint.InnerColor = new Color(150, 140, 216, 128);

        context.BeginPath();
        DrawRadioButton(context, MARGIN, MARGIN + 28, 48, 36);
        DrawCircle(context, 400, 240, 50);
        DrawClock(context, 800 - MARGIN - 64 - MARGIN - 64, MARGIN + 64, 64);
        context.Stroke();

        context.SaveState();

        context.BeginPath();
        context.GetState().StrokeWidth = 1;
        context.GetState().StrokePaint.InnerColor = new Color(168, 131, 236, 128);
        DrawRadioButton(context, MARGIN, MARGIN + 28 + 100, 48, 36);
        context.Stroke();
        
        context.RestoreState();
        context.BeginPath();
        DrawRadioButton(context, MARGIN, MARGIN + 28 + 200, 48, 36);
        context.Stroke();

        context.BeginPath();
        DrawCapsule(context, MARGIN, MARGIN + 28 + 300, 48, 36);
        context.Fill();
        context.Stroke();

        context.BeginPath();
        DrawFill(context, 800 - MARGIN - 200, 160, 100, 100);
        context.Fill();
        context.Stroke();

        context.BeginPath();
        context.AddRectangle(800 - MARGIN - 200 - 24, 160 + 32, 48, 36);
        context.Fill();
        context.Stroke();
        
        context.EndFrame();
        return renderer?.Cache ?? throw new Exception("Unexpected");
    }

    private static void DrawFill(Context context, int l, int t, int w, int h)
    {
        context.AddCommand(new Command(CommandType.MoveTo, l, t + h));
        context.AddCommand(new Command(CommandType.LineTo, l + w, t + h));
        context.AddCommand(new Command(CommandType.LineTo, l + w, t + h + h));
        context.AddCommand(new Command(CommandType.LineTo, l, t + h + h));
        context.AddCommand(new Command(CommandType.LineTo, l, t + h + h + h));
        context.AddCommand(new Command(CommandType.LineTo, l + w + w, t + h + h + h));
        context.AddCommand(new Command(CommandType.LineTo, l + w + w, t));
        context.AddCommand(new Command(CommandType.LineTo, l, t));
        context.AddCommand(new Command(CommandType.Close));
    }

    const float KAPPA90 = 0.5522847493f;
    private static void DrawCapsule(Context context, int l, int t, int w, int h)
    {
        var r = h / 2f;
        context.AddCommand(new Command(CommandType.MoveTo, l + r, t));
        context.AddCommand(new Command(CommandType.LineTo, l + r + w, t));
        context.AddCommand(new Command(CommandType.BezierTo, l + r + w + r * KAPPA90, t, l + r + w + r, t + r - r * KAPPA90, l + r + w + r, t + r));
        context.AddCommand(new Command(CommandType.BezierTo, l + r + w + r, t + r + r * KAPPA90, l + r + w + r * KAPPA90, t + h, l + r + w, t + h));
        context.AddCommand(new Command(CommandType.LineTo, l + r, t + h));

        context.AddCommand(
            new Command(
                CommandType.BezierTo, 
                l + r - r * KAPPA90, t + h,
                l, t + r + r * KAPPA90,
                l, t + r
            )
        );
        context.AddCommand(
            new Command(
                CommandType.BezierTo, 
                l, t + r - r * KAPPA90,
                l + r - r * KAPPA90, t,
                l+ r, t
            )
        );
    }
    private static void DrawRadioButton(Context context, int l, int t, int w, int h)
    {
        DrawCapsule(context, l, t, w, h);
        var r = h / 2f;
        var cr = r * 0.8f;
        context.AddEllipse(l + r, t + r, cr, cr);
    }

    private static void DrawCircle(Context context, int l, int t, int r)
    {
        context.AddEllipse(l, t, r, r);
        context.AddEllipse(l, t, r * 2, r * 1.4f);
        context.AddEllipse(l, t, r * 1.4f, r * 2);
    }

    static (float h, float m, float s) RATES = (60f * 60f * 1000f, 60f * 1000f, 1000f);
    private static void DrawClock(Context context, int cx, int cy, int r)
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
        context.AddEllipse(cx, cy, r, r);
        context.AddEllipse(cx, cy, 2, 2);
        context.AddEllipse(cx, cy, 3, 3);
        for (int i = 0; i < 12; i++)
        {
            if(i % 3 == 0)
            {
                continue;
            }
            var dir = Math.PI / 6 * i;
            var start = r * 0.92f;
            context.AddCommand(new Command(CommandType.MoveTo, cx + start * (float)Math.Sin(dir), cy + start * (float)Math.Cos(dir)));
            context.AddCommand(new Command(CommandType.LineTo, cx + r * (float)Math.Sin(dir), cy + r * (float)Math.Cos(dir)));
        }
        for (int i = 0; i < 4; i++)
        {
            var dir = Math.PI / 2 * i;
            var start = r * 0.8f;
            context.AddCommand(new Command(CommandType.MoveTo, cx + start * (float)Math.Sin(dir), cy + start * (float)Math.Cos(dir)));
            context.AddCommand(new Command(CommandType.LineTo, cx + r * (float)Math.Sin(dir), cy + r * (float)Math.Cos(dir)));
        }
        foreach (var pointer in pointers)
        {
            context.AddCommand(new Command(CommandType.MoveTo, cx, cy));
            var dir = -pointer.dir + Math.PI;
            var len = pointer.len;
            context.AddCommand(new Command(CommandType.LineTo, cx + len * (float)Math.Sin(dir), cy + len * (float)Math.Cos(dir)));
        }
    }

} 