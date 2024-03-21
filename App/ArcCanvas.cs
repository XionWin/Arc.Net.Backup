#if KMS_MODE
using OpenGL.Graphics.ES20;
#else
using OpenTK.Graphics.ES20;
#endif
using Arc.Core;
using Arc.ES20;
using Extension;

namespace App;

public static class ArcCanvas
{
    static Dictionary<string, Texture> TEXTURES = new Dictionary<string, Texture>();
    public static void Init()
    {
        TEXTURES.Add(
            "bg",  new Texture(TextureUnit.Texture0, TextureMinFilter.Linear).With(x => x.LoadImage(@"Resources/Images/bg.png"))
        );
        TEXTURES.Add(
            "container",  new Texture(TextureUnit.Texture0, TextureMinFilter.Linear).With(x => x.LoadImage(@"Resources/Images/container.png"))
        );
        TEXTURES.Add(
            "icon",  new Texture(TextureUnit.Texture0, TextureMinFilter.Linear).With(x => x.LoadImage(@"Resources/Images/icon.png"))
        );
        TEXTURES.Add(
            "arc",  new Texture(TextureUnit.Texture0, TextureMinFilter.Linear).With(x => x.LoadImage(@"Resources/Images/arc.png"))
        );
        TEXTURES.Add(
            "wallpaper",  new Texture(TextureUnit.Texture0, TextureMinFilter.Linear).With(x => x.LoadImage(@"Resources/Images/wallpaper.png"))
        );
    }

    static int MARGIN = 20;
    public static RenderData Draw(Context<Renderer> context)
    {
        var width = 1280;
        var height = 1024;
        context.BeginFrame();

        context.GetState().StrokeWidth = 2;
        context.GetState().LineCap = LineCap.Butt;
        context.GetState().LineJoin = LineJoin.Round;
        context.GetState().StrokePaint.InnerColor = new Color(255, 255, 255, 255);
        context.GetState().FillPaint.InnerColor = new Color(0, 0, 0, 168);

        // DrawBGImage(context, 0, 0, width, height);
        DrawWindow(context, MARGIN, MARGIN, width - 2 * MARGIN, height - 2 * MARGIN);



        // DrawRadioButton(context, MARGIN, MARGIN + 28, 48, 36);
        // DrawCircle(context, 400, 240, 50);
        // DrawRotatedImage(context, 400 - 40, 240 - 40, 80, 80);


        // context.SaveState();
        // context.GetState().StrokeWidth = 1;
        // context.GetState().StrokePaint.InnerColor = new Color(64, 80, 128, 128);
        // DrawRadioButton(context, MARGIN, MARGIN + 28 + 80, 48, 36);
        // context.RestoreState();
    
        // DrawRadioButtonFill(context, MARGIN, MARGIN + 28 + 160, 48, 36);
        // DrawFill(context, MARGIN, MARGIN + 28 + 240, 48, 36);

        
        // DrawClock(context, 800 - MARGIN - 64, MARGIN + 64, 64);
        // DrawNonConvexFillImage(context, 800 - MARGIN - 64 - 40, MARGIN + 64 + 64 + 20, 80, 80);

        context.EndFrame();
        return context.Renderer.Data;
    }
    private static void DrawWindow(IContext context, int l, int t, int w, int h)
    {
        // context.SaveState();
        // context.GetState().StrokeWidth = 1;
        // context.GetState().StrokePaint.InnerColor = new Color(0, 0, 0, 255);
        // context.GetState().FillPaint.InnerColor = new Color(0, 0, 0, 168);
        // context.AddRoundRectangle(l, t, w, h, 10);
        // context.Fill();
        // context.Stroke();
        // context.RestoreState();

        var top = 0;
        // DrawLogo(context, l + w / 2 - 32, top += t + MARGIN, 64, 64);
        DrawHorizontalLine(context, l + MARGIN, top += 64 + MARGIN, w - MARGIN * 2);
        
    }
    
    private static void DrawLogo(IContext context, int l, int t, int w, int h)
    {
        context.AddEllipse(l + w / 2, t + h / 2, w / 2, h / 2);
        context.Fill();
        context.Stroke();
        var imageWidth = (int)Math.Floor(w *0.8f);
        var imageHeight = (int)Math.Floor(h *0.8f);
        var imageX = l + (w - imageWidth) / 2;
        var imageY = t + (h - imageHeight) / 2;
        DrawRotatedImage(context, imageX, imageY, imageWidth, imageHeight);
    }
    
    private static void DrawHorizontalLine(IContext context, int x, int y, int l)
    {
        // context.SaveState();
        // context.GetState().StrokeWidth = 1;
        // context.GetState().FillPaint.InnerColor = new Color(80, 80, 80, 255);
        // context.AddCommand(CommandType.MoveTo, x, y);
        // context.AddCommand(CommandType.LineTo, x + l, y);
        // context.AddCommand(CommandType.LineTo, x + l, y + 1);
        // context.AddCommand(CommandType.LineTo, x, y + 1);
        // context.AddCommand(CommandType.Close);
        // context.Fill();
        // context.RestoreState();

        context.SaveState();
        context.GetState().StrokeWidth = 1;
        context.AddCommand(CommandType.MoveTo, x, y);
        context.AddCommand(CommandType.LineTo, x + l, y);
        context.Stroke();
        context.RestoreState();
    }

    private static void DrawRotatedImage(IContext context, int l, int t, int w, int h)
    {
        context.SaveState();
        var now = DateTime.Now;
        // var ms = now.Hour * RATES.h + now.Minute * RATES.m + now.Second * RATES.s + now.Millisecond;
        // var s = ms % RATES.h % RATES.m /RATES.s;
        context.GetState().FillPaintTexture(4, new Rectangle(l, t, w, h), 0, 0.8f);
        context.AddRectangle(l, t, w, h);
        context.Fill();
        context.RestoreState();
    }

    private static void DrawBGImage(IContext context, int l, int t, int w, int h)
    {
        context.SaveState();
        context.GetState().FillPaintTexture(5, new Rectangle(l, t, w, h), 0, 1f);
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
        context.RestoreState();

        
        context.SaveState();
        context.GetState().FillPaint.InnerColor = new Color(255, 255, 255, 255);
        context.GetState().StrokePaint.InnerColor = new Color(255, 255, 255, 255);
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

        context.AddEllipse(cx, cy, 3, 3);
        context.Fill();
        context.Stroke();

        context.RestoreState();
    }

} 