using Arc.Core;
using Arc.ES20;

namespace App;

public static class ArcCanvas
{
    static int MARGIN = 20;
    
    public static RenderData Draw(Context<Renderer> context)
    {
        context.BeginFrame();

        context.GetState().StrokeWidth = 2;
        context.GetState().LineCap = LineCap.Round;
        context.GetState().LineJoin = LineJoin.Round;
        context.GetState().StrokePaint.InnerColor = new Color(128, 140, 216, 255);
        context.GetState().FillPaint.InnerColor = new Color(150, 140, 216, 128);

        DrawRadioButton(context, MARGIN, MARGIN + 28, 48, 36);
        DrawCircle(context, 400, 240, 50);
        DrawRotatedImage(context, 400 - 40, 240 - 40, 80, 80);

        context.SaveState();
        context.GetState().StrokeWidth = 1;
        context.GetState().StrokePaint.InnerColor = new Color(64, 80, 128, 128);
        DrawRadioButton(context, MARGIN, MARGIN + 28 + 80, 48, 36);
        context.RestoreState();
    
        DrawRadioButtonFill(context, MARGIN, MARGIN + 28 + 160, 48, 36);
        DrawFill(context, MARGIN, MARGIN + 28 + 240, 48, 36);
        // DrawImage(context, 800 - MARGIN - 80, MARGIN, 80, 80);

        
        DrawClock(context, 800 - MARGIN - 64, MARGIN + 64, 64);
        DrawNonConvexFillImage(context, 800 - MARGIN - 64 - 40, MARGIN + 64 + 64 + 20, 80, 80);

        context.EndFrame();
        return context.Renderer.Data;
    }

    private static void DrawImage(IContext context, int l, int t, int w, int h)
    {
        context.SaveState();
        var now = DateTime.Now;
        var ms = now.Hour * RATES.h + now.Minute * RATES.m + now.Second * RATES.s + now.Millisecond;
        var s = ms % RATES.h % RATES.m /RATES.s;
        context.GetState().FillPaintTexture(3, new Rectangle(l, t, w, h), 0, 1f);
        context.AddRectangle(l, t, w, h);
        context.Fill();
        context.RestoreState();
    }

    private static void DrawRotatedImage(IContext context, int l, int t, int w, int h)
    {
        context.SaveState();
        var now = DateTime.Now;
        var ms = now.Hour * RATES.h + now.Minute * RATES.m + now.Second * RATES.s + now.Millisecond;
        var s = ms % RATES.h % RATES.m /RATES.s;
        context.GetState().FillPaintTexture(3, new Rectangle(l, t, w, h), (float)(s / 60f * Math.PI * 2), 1f);
        context.AddRectangle(l, t, w, h);
        context.Fill();
        context.RestoreState();
    }
    
    private static void DrawNonConvexFillImage(IContext context, int l, int t, int w, int h)
    {
        context.SaveState();
        context.GetState().StrokeWidth = 1;
        context.GetState().FillPaintTexture(3, new Rectangle(l, t, w, h), 0, 0.25f);
        context.AddCommand(new Command(CommandType.MoveTo, l + w / 2, t));
        context.AddCommand(new Command(CommandType.LineTo, l + w / 2, t + h / 2));
        context.AddCommand(new Command(CommandType.LineTo, l, t + h / 2));
        context.AddCommand(new Command(CommandType.LineTo, l, t + h));
        context.AddCommand(new Command(CommandType.LineTo, l + w, t + h));
        context.AddCommand(new Command(CommandType.LineTo, l + w, t));
        context.AddCommand(new Command(CommandType.LineTo, l + w / 2, t));
        context.AddCommand(new Command(CommandType.Close));
        context.Fill();
        context.RestoreState();
        context.SaveState();
        context.Stroke();
        context.RestoreState();
    }

    private static void DrawFill(IContext context, int l, int t, int w, int h)
    {
        context.SaveState();
        context.GetState().StrokeWidth = 5;
        context.AddCommand(new Command(CommandType.MoveTo, l, t + h));
        context.AddCommand(new Command(CommandType.LineTo, l + w, t + h));
        context.AddCommand(new Command(CommandType.LineTo, l + w, t + h + h));
        context.AddCommand(new Command(CommandType.LineTo, l, t + h + h));
        context.AddCommand(new Command(CommandType.LineTo, l, t + h + h + h));
        context.AddCommand(new Command(CommandType.LineTo, l + w + w, t + h + h + h));
        context.AddCommand(new Command(CommandType.LineTo, l + w + w, t));
        context.AddCommand(new Command(CommandType.LineTo, l, t));
        context.AddCommand(new Command(CommandType.Close));
        context.Fill();
        context.Stroke();
        context.RestoreState();

        context.SaveState();
        context.GetState().StrokeWidth = 2;
        context.GetState().StrokePaint.InnerColor = new Color(255, 255, 255, 255);
        context.GetState().FillPaint.InnerColor = new Color(150, 140, 216, 128);
        context.AddRectangle(l + 2 * w - 0.5f * w, t + 0.5f * h , w, h);
        context.Fill();
        context.Stroke();
        context.RestoreState();
        
        var r = h / 2f;
        var cr = r * 0.6f;
        context.SaveState();
        context.GetState().FillPaint.InnerColor = new Color(196, 224, 255, 255);
        context.GetState().StrokePaint.InnerColor = new Color(196, 224, 255, 255);
        context.AddEllipse(l + r, t + r, cr, cr);
        context.Fill();
        context.Stroke();
        context.RestoreState();
    }

    const float KAPPA90 = 0.5522847493f;
    private static void DrawCapsule(IContext context, int l, int t, int w, int h)
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
        context.Stroke();
    }
    private static void DrawRadioButton(IContext context, int l, int t, int w, int h)
    {
        DrawCapsule(context, l, t, w, h);
        var r = h / 2f;
        var cr = r * 0.8f;
        context.AddEllipse(l + r, t + r, cr, cr);
        context.Stroke();
    }

    private static void DrawRadioButtonFill(IContext context, int l, int t, int w, int h)
    {
        DrawCapsule(context, l, t, w, h);
        context.Fill();
        context.Stroke();

        var r = h / 2f;
        var cr = r * 0.8f;
        context.SaveState();
        context.GetState().FillPaint.InnerColor = new Color(196, 224, 255, 255);
        context.GetState().StrokePaint.InnerColor = new Color(196, 224, 255, 255);
        context.AddEllipse(l + r, t + r, cr, cr);
        context.Fill();
        context.Stroke();
        context.RestoreState();
    }

    private static void DrawCircle(IContext context, int l, int t, int r)
    {
        context.SaveState();
        context.GetState().FillPaint.InnerColor = new Color(16, 16, 64, 128);
        context.AddEllipse(l, t, r, r);
        context.Fill();
        context.Stroke();
        context.RestoreState();

        context.AddEllipse(l, t, r * 2, r * 1.4f);
        context.Stroke();
        context.AddEllipse(l, t, r * 1.4f, r * 2);
        context.Stroke();
    }

    static (float h, float m, float s) RATES = (60f * 60f * 1000f, 60f * 1000f, 1000f);
    private static void DrawClock(IContext context, int cx, int cy, int r)
    {
        context.SaveState();
        context.GetState().StrokeWidth = 2;
        context.GetState().LineCap = LineCap.Round;
        context.GetState().LineJoin = LineJoin.Round;
        context.GetState().StrokePaint.InnerColor = new Color(128, 140, 216, 255);
        context.GetState().FillPaint.InnerColor = new Color(128, 140, 216, 255);

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
        context.Stroke();
        context.AddEllipse(cx, cy, 3, 3);
        context.Fill();
        context.Stroke();
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
            context.Stroke();
        }
        for (int i = 0; i < 4; i++)
        {
            var dir = Math.PI / 2 * i;
            var start = r * 0.8f;
            context.AddCommand(new Command(CommandType.MoveTo, cx + start * (float)Math.Sin(dir), cy + start * (float)Math.Cos(dir)));
            context.AddCommand(new Command(CommandType.LineTo, cx + r * (float)Math.Sin(dir), cy + r * (float)Math.Cos(dir)));
            context.Stroke();
        }
        foreach (var pointer in pointers)
        {
            context.AddCommand(new Command(CommandType.MoveTo, cx, cy));
            var dir = -pointer.dir + Math.PI;
            var len = pointer.len;
            context.AddCommand(new Command(CommandType.LineTo, cx + len * (float)Math.Sin(dir), cy + len * (float)Math.Cos(dir)));
            context.Stroke();
        }

        context.GetState().StrokeWidth = 3;
        context.AddCommand(new Command(CommandType.MoveTo, cx, cy));
        var secondExtendDir = -pointers.Last().dir;
        var secondExtendLen = pointers.Last().len / 4.5f;
        context.AddCommand(new Command(CommandType.LineTo, cx + secondExtendLen * (float)Math.Sin(secondExtendDir), cy + secondExtendLen * (float)Math.Cos(secondExtendDir)));
        context.Stroke();

        context.RestoreState();
    }

} 