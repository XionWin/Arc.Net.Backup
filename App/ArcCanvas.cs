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
        TEXTURES.Add(
            "genshin_avatar",  new Texture(TextureUnit.Texture0, TextureMinFilter.Linear).With(x => x.LoadImage(@"Resources/Images/genshin_avatar.png"))
        );
        TEXTURES.Add(
            "genshin_logo",  new Texture(TextureUnit.Texture0, TextureMinFilter.Linear).With(x => x.LoadImage(@"Resources/Images/genshin_logo.png"))
        );
        TEXTURES.Add(
            "genshin_character",  new Texture(TextureUnit.Texture0, TextureMinFilter.Linear).With(x => x.LoadImage(@"Resources/Images/genshin_character.png"))
        );  
    }

    static int MARGIN = 20;
    static int INNER_MARGIN = MARGIN / 2;
    public static RenderData Draw(Context<Renderer> context, (int width, int height) viewSize)
    {
        var width = viewSize.width;
        var height = viewSize.height;
        context.BeginFrame();

        context.GetState().StrokeWidth = 1;
        context.GetState().LineCap = LineCap.Butt;
        context.GetState().LineJoin = LineJoin.Round;
        context.GetState().StrokePaint.InnerColor = new Color(255, 255, 255, 255);
        context.GetState().FillPaint.InnerColor = new Color(255, 255, 255, 255);

        DrawBGImage(context, 0, 0, width, height);
        DrawWindow(context, MARGIN, MARGIN, width - 2 * MARGIN, height - 2 * MARGIN);

        // context.AddCommand(CommandType.MoveTo, 1, 1);
        // context.AddCommand(CommandType.LineTo, 100, 1);
        // context.AddCommand(CommandType.LineTo, 100, 100);
        // context.AddCommand(CommandType.LineTo, 1, 100);
        // context.AddCommand(CommandType.Close);
        // context.Fill();


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
        context.SaveState();
        context.GetState().StrokeMode =  StrokeMode.PixelAccurate;
        context.GetState().StrokeWidth = 1;
        context.GetState().StrokePaint.InnerColor = new Color(0, 0, 24, 255);
        context.GetState().FillPaint.InnerColor = new Color(0, 0, 0, 136);
        context.AddRoundRectangle(l, t, w, h, 16);
        context.Fill();
        context.Stroke();
        context.RestoreState();

        DrawLogo(context, l + w / 2 - 111, t + (MARGIN + 96 + MARGIN - 148) / 2, 222, 148);
        DrawAvatar(context, l + w - MARGIN - 96, t + MARGIN, 96, 96);
        var top = t + MARGIN + 96;
        DrawHorizontalLine(context, l + INNER_MARGIN, top += INNER_MARGIN, w - INNER_MARGIN * 2, 18);
        DrawCaracter(context, l, t, 240, h, (h - 408));

        DrawClock(context, l + w - MARGIN - 96, top += 18 + INNER_MARGIN, 96, 96);

        DrawRadioButtonFill(context, l + 240 + MARGIN, top += MARGIN, 48, 36);
    }

    

    private static void DrawRadioButtonFill(IContext context, int l, int t, int w, int h)
    {
        context.SaveState();
        context.GetState().FillPaint.InnerColor = new Color(0, 0, 0, 168);
        context.GetState().StrokePaint.InnerColor = new Color(255, 255, 255, 255);
        DrawCapsule(context, l, t, w, h);
        context.Fill();
        context.Stroke();
        context.RestoreState();

        context.SaveState();
        var r = h / 2f;
        var cr = r * 0.78f;
        context.AddEllipse(l + r, t + r, cr, cr);
        context.Fill();
        context.Stroke();
        context.RestoreState();
    }
    private static void DrawCaracter(IContext context, int l, int t, int w, int h, int balckHeight)
    {
        context.SaveState();
        // var now = DateTime.Now;
        // var ms = now.Hour * RATES.h + now.Minute * RATES.m + now.Second * RATES.s + now.Millisecond;
        // var s = ms % RATES.h % RATES.m /RATES.s;
        // var moveWidth = 4;
        // var moveHeight = 8;
        // var moveAngle = (float)Math.PI / 120;
        // var dx = moveWidth * (float)Math.Cos(s / 5f * Math.PI * 2);
        // var dy = moveHeight * (float)Math.Sin(s / 8f * Math.PI * 2);
        // var da = moveAngle * (float)Math.Sin(s / 10f * Math.PI * 2);
        // dx -= dx % 1e-1f;
        // dy -= dy % 1e-1f;
        // context.GetState().FillPaintTexture(TEXTURES["genshin_character"].Id, new Rectangle(l - moveWidth + dx, t + balckHeight + balckHeight + dy, w, h - balckHeight), moveAngle + da, 1);
        context.GetState().FillPaintTexture(TEXTURES["genshin_character"].Id, new Rectangle(l, t + balckHeight, w, h - balckHeight), 0, 1);
        context.AddRoundRectangle(l + 1, t - 1, w + 10, h, 16);
        context.Fill();
        context.RestoreState();
    }

    private static void DrawHorizontalLine(IContext context, int l, int t, int w, int h)
    {
        context.SaveState();
        context.GetState().StrokeMode =  StrokeMode.PixelAccurate;
        context.GetState().StrokeWidth = 1;
        context.AddCommand(CommandType.MoveTo, l, t + h / 2);
        context.AddCommand(CommandType.LineTo, l + w, t + h / 2);
        context.Stroke();
        context.RestoreState();

        DrawLineDecoration(context, l + w / 2 - h / 2, t, h, h);
    }

    private static void DrawLineDecoration(IContext context, float l, float t, float w, float h)
    {
        l -= 0.5f;
        t -= 0.5f;
        var rx = w /2 * 0.4f;
        var ry = h /2 * 0.4f;
        context.SaveState();
        context.GetState().StrokeMode = StrokeMode.Average;
        context.GetState().StrokeWidth = 1f;
        context.GetState().LineCap = LineCap.Butt;
        context.GetState().LineJoin = LineJoin.Miter;
        context.AddCommand(CommandType.MoveTo, l + w / 2, t);
        context.AddCommand(CommandType.BezierTo,
        l + w / 2, t + ry,
        l + w - rx, t + h / 2,
        l + w, t + h / 2);
        context.AddCommand(CommandType.BezierTo,
        l + w - rx, t + h / 2,
        l + w / 2, t + h - ry,
        l + w / 2, t + h);
        context.AddCommand(CommandType.BezierTo,
        l + w / 2, t + h - ry,
        l + rx, t + h / 2,
        l, t + h / 2);
        context.AddCommand(CommandType.BezierTo,
        l + rx, t + h / 2,
        l + w / 2, t + ry,
        l + w / 2, t);
        context.AddCommand(CommandType.Close);
        context.Stroke();
        context.Fill();

        // context.AddCommand(CommandType.MoveTo, l + w / 2, t + 1);
        // context.AddCommand(CommandType.LineTo, l + w / 2, t + h - 2);
        // context.Stroke();

        // context.AddCommand(CommandType.MoveTo, l + 1, t + h / 2);
        // context.AddCommand(CommandType.LineTo, l + w - 2, t + h / 2);
        // context.Stroke();
        context.RestoreState();
    }
    
    private static void DrawAvatar(IContext context, int l, int t, int w, int h)
    {
        context.RestoreState();
        context.SaveState();
        context.GetState().FillPaint.InnerColor = new Color(95, 78, 84, 168);
        context.AddEllipse(l + w / 2, t + h / 2, w / 2, h / 2);
        context.Fill();
        context.RestoreState();

        FillImage(context, TEXTURES["genshin_avatar"].Id, l, t, w, h);

        context.RestoreState();
        context.SaveState();
        context.GetState().StrokeWidth = 2;
        context.AddEllipse(l + w / 2, t + h / 2, w / 2, h / 2);
        context.Stroke();
        context.RestoreState();
    }
    
    private static void DrawLogo(IContext context, int l, int t, int w, int h)
    {
        FillImage(context, TEXTURES["genshin_logo"].Id, l, t, w, h);
    }

    private static void FillImage(IContext context, int texture, int l, int t, int w, int h)
    {
        context.SaveState();
        // var now = DateTime.Now;
        // var ms = now.Hour * RATES.h + now.Minute * RATES.m + now.Second * RATES.s + now.Millisecond;
        // var s = ms % RATES.h % RATES.m /RATES.s;
        context.GetState().FillPaintTexture(texture, new Rectangle(l, t, w, h), 0, 1);
        context.AddEllipse(l + w / 2, t + h / 2, w / 2, h / 2);
        context.Fill();
        context.RestoreState();
    }

    private static void DrawBGImage(IContext context, int l, int t, int w, int h)
    {
        context.SaveState();
        context.GetState().StrokeWidth = 0;
        context.GetState().FillPaintTexture(TEXTURES["wallpaper"].Id, new Rectangle(l, t, w, h), 0, 1f);
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


    static (float h, float m, float s) RATES = (60f * 60f * 1000f, 60f * 1000f, 1000f);
    private static void DrawClock(IContext context, int l, int t, int width, int height)
    {
        int cx = l + width / 2;
        int cy = t + height / 2;
        int r = Math.Min(width, height) / 2;

        context.SaveState();
        context.GetState().StrokeWidth = 2;
        context.GetState().LineCap = LineCap.Round;
        context.GetState().LineJoin = LineJoin.Round;

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
        
        context.SaveState();
        context.GetState().StrokeWidth = 2;
        context.GetState().LineCap = LineCap.Round;
        context.GetState().LineJoin = LineJoin.Round;
        context.AddEllipse(cx, cy, r, r);
        context.Stroke();
        context.RestoreState();

        context.SaveState();
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
        context.GetState().StrokeWidth = 2;
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