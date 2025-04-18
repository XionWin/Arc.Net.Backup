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
    public static void Init(Context<Renderer> context)
    {
        TEXTURES.Add(
            "icon", new Texture(TextureUnit.Texture0, TextureMinFilter.Linear).With(x => x.LoadImage(@"Resources/Images/icon.png"))
        );
        TEXTURES.Add(
            "wallpaper", new Texture(TextureUnit.Texture0, TextureMinFilter.Linear).With(x => x.LoadImage(@"Resources/Images/wallpaper.png"))
        );
        TEXTURES.Add(
            "genshin_avatar", new Texture(TextureUnit.Texture0, TextureMinFilter.Linear).With(x => x.LoadImage(@"Resources/Images/genshin_avatar.png"))
        );

        var fontName = "Arial";
        var path = @$"Resources/Fonts/{fontName}.ttf";
        if (File.Exists(path))
        {
            TrueType.TTF.CreateFont(fontName, path);
        }

        fontName = "SmileySans";
        path = @$"Resources/Fonts/{fontName}.ttf";
        if (File.Exists(path))
        {
            TrueType.TTF.CreateFont(fontName, path);
        }

        fontName = "Zpix";
        path = @$"Resources/Fonts/{fontName}.ttf";
        if (File.Exists(path))
        {
            TrueType.TTF.CreateFont(fontName, path);
        }

        fontName = "PixelMix";
        path = @$"Resources/Fonts/{fontName}.ttf";
        if (File.Exists(path))
        {
            TrueType.TTF.CreateFont(fontName, path);
        }

        fontName = "DroidSerif-Regular";
        path = @$"Resources/Fonts/{fontName}.ttf";
        if (File.Exists(path))
        {
            TrueType.TTF.CreateFont(fontName, path);
        }

        fontName = "DroidSerif-Italic";
        path = @$"Resources/Fonts/{fontName}.ttf";
        if (File.Exists(path))
        {
            TrueType.TTF.CreateFont(fontName, path);
        }
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

        context.EndFrame();
        return context.Renderer.Data;
    }

    private static void DrawWindow(IContext context, int l, int t, int w, int h)
    {
        context.SaveState();
        context.GetState().StrokeMode = StrokeMode.PixelAccurate;
        context.GetState().StrokeWidth = 1;
        context.GetState().StrokePaint.InnerColor = new Color(0, 0, 24, 255);
        context.GetState().FillPaint.InnerColor = new Color(0, 0, 0, 168);
        context.AddRoundRectangle(l, t, w, h, 16);
        context.Fill();
        context.Stroke();
        context.RestoreState();

        var topRight = t;
        DrawAvatar(context, l + w - MARGIN - 96, topRight += MARGIN, 96, 96);
        
        var topLeft = t;
        DrawTextAlign(context, l + 60 + MARGIN, topLeft += MARGIN, 270, 160);
        DrawTextTest(context, l + MARGIN, topLeft += 160 + INNER_MARGIN, 270, 160);

        DrawClock(context, l + w - MARGIN - 96, topRight += 96 + MARGIN + MARGIN, 96, 96);

        DrawTextRadioButtonFill(context, l + w - MARGIN - 110, t + h - MARGIN - 24 / 2, 24, 24, "DEBUG", false);
    }

    private static void DrawTextAlign(IContext context, int l, int t, int w, int h)
    {
        var fontSize = 26;
        context.SaveState();
        context.GetState().StrokeMode = StrokeMode.PixelAccurate;
        context.GetState().StrokeWidth = 1;
        context.GetState().StrokePaint.InnerColor = new Color(255, 255, 255, 96);
        context.AddCommand(CommandType.MoveTo, l, t + 50);
        context.AddCommand(CommandType.LineTo, l + w, t + 50);
        context.Stroke();
        context.RestoreState();

        context.SaveState();
        context.SetFontFace("SmileySans");
        context.SetFontSize(fontSize);
        var left = (float)l + INNER_MARGIN;
        left += INNER_MARGIN + context.Text("Top", left, t + 50, TrueType.Mode.VerticalAlign.Top);
        left += INNER_MARGIN + context.Text("Middle", left, t + 50, TrueType.Mode.VerticalAlign.Middle);
        left += INNER_MARGIN + context.Text("Baseline", left, t + 50, TrueType.Mode.VerticalAlign.Baseline);
        left += INNER_MARGIN + context.Text("Bottom", left, t + 50, TrueType.Mode.VerticalAlign.Bottom);
        context.RestoreState();

        context.SaveState();
        context.GetState().StrokeMode = StrokeMode.PixelAccurate;
        context.GetState().StrokeWidth = 1;
        context.GetState().StrokePaint.InnerColor = new Color(255, 255, 255, 96);
        context.AddCommand(CommandType.MoveTo, l + w / 2, t + 50);
        context.AddCommand(CommandType.LineTo, l + w / 2, t + h);
        context.Stroke();
        context.RestoreState();

        context.SaveState();
        context.SetFontFace("SmileySans");
        context.SetFontSize(fontSize);
        var top = (float)t + 50 + INNER_MARGIN;
        context.Text("左", l + w / 2, top, TrueType.Mode.VerticalAlign.Top, TrueType.Mode.HorizontalAlign.Left);
        top += fontSize + INNER_MARGIN;
        context.Text("中", l + w / 2, top, TrueType.Mode.VerticalAlign.Top, TrueType.Mode.HorizontalAlign.Center);
        top += fontSize + INNER_MARGIN;
        context.Text("右", l + w / 2, top, TrueType.Mode.VerticalAlign.Top, TrueType.Mode.HorizontalAlign.Right);
        top += fontSize + INNER_MARGIN;
        context.RestoreState();
    }

    private static void DrawTextTest(IContext context, int l, int t, int w, int h)
    {
        var top = t;
        var fontSize = 21;
        context.SaveState();
        context.SetFontFace("DroidSerif-Regular");
        context.SetFontSize(fontSize);
        context.Text("The quick brown fox jumps over the lazy dog.", l, top, TrueType.Mode.VerticalAlign.Top, TrueType.Mode.HorizontalAlign.Left);
        top += fontSize + INNER_MARGIN;

        fontSize = 22;
        context.SaveState();
        context.SetFontFace("SmileySans");
        context.SetFontSize(fontSize);
        context.Text("得意黑是一款在人文观感和几何特征中寻找视觉平衡的现代窄斜体。", l, top, TrueType.Mode.VerticalAlign.Top, TrueType.Mode.HorizontalAlign.Left);
        top += fontSize + INNER_MARGIN;

        fontSize = 18;
        context.SaveState();
        context.SetFontFace("SmileySans");
        context.SetFontSize(fontSize);
        context.Text("私はガラスを食べられます。それは私を傷つけません。", l, top, TrueType.Mode.VerticalAlign.Top, TrueType.Mode.HorizontalAlign.Left);
        top += fontSize + INNER_MARGIN;

        fontSize = 12;
        context.SaveState();
        context.SetFontFace("Zpix");
        context.SetFontSize(fontSize);
        context.Text("汉字之美，美在精髓。汉字之美，美在风骨。汉字之美，美在形体。", l, top, TrueType.Mode.VerticalAlign.Top, TrueType.Mode.HorizontalAlign.Left);
        top += fontSize + INNER_MARGIN;

        fontSize = 12;
        context.SaveState();
        context.SetFontFace("Zpix");
        context.SetFontSize(fontSize);
        context.Text("漢字之美，美在精髓。漢字之美，美在風骨。漢字之美，美在形體。", l, top, TrueType.Mode.VerticalAlign.Top, TrueType.Mode.HorizontalAlign.Left);
        top += fontSize + INNER_MARGIN;

    }

    private static void DrawTextRadioButtonFill(IContext context, int l, int t, int w, int h, string text, bool isOpened)
    {
        context.SetFontSize(22);
        var textWidth = context.Text(text, l, t, TrueType.Mode.VerticalAlign.Middle);
        DrawRadioButtonFill(context, l + INNER_MARGIN + textWidth, t - h / 2, w, h, isOpened);

        context.SaveState();
        var r = 4;
        context.AddEllipse(l - 12, t, r, r);
        context.Fill();
        context.Stroke();
        context.RestoreState();
    }


    private static void DrawRadioButtonFill(IContext context, int l, int t, int w, int h, bool isOpened)
    {
        context.SaveState();
        context.GetState().FillPaint.InnerColor = isOpened ? new Color(255, 255, 255, 80) : new Color(0, 0, 0, 128);
        context.GetState().StrokePaint.InnerColor = new Color(255, 255, 255, 255);
        DrawCapsule(context, l, t, w, h);
        context.Fill();
        context.Stroke();
        context.RestoreState();

        context.SaveState();
        var r = h / 2f;
        var cr = r * 0.78f;
        context.AddEllipse(isOpened ? l + w + r * 2 - r : l + r, t + r, cr, cr);
        context.Fill();
        context.Stroke();
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
        context.GetState().FillPaintTexture(TEXTURES["wallpaper"].Id, new Rectangle(l, t, w, h), 0, 1);
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
        context.AddRectangle(l + 2 * w - 0.5f * w, t + 0.5f * h, w, h);
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
                l + r, t
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
        var s = ms % RATES.h % RATES.m / RATES.s;
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
        context.GetState().StrokeWidth = 1;
        for (int i = 0; i < 12; i++)
        {
            if (i % 3 == 0)
            {
                continue;
            }
            var dir = Math.PI / 6 * i;
            var start = r * 0.9f;
            // context.AddCommand(new Command(CommandType.MoveTo, cx + start * (float)Math.Sin(dir), cy + start * (float)Math.Cos(dir)));
            // context.AddCommand(new Command(CommandType.LineTo, cx + r * (float)Math.Sin(dir), cy + r * (float)Math.Cos(dir)));
            context.AddEllipse(cx + start * (float)Math.Sin(dir), cy + start * (float)Math.Cos(dir), 1, 1);
            context.Fill();
            context.Stroke();
        }

        string[] titles = ["6", "3", "12", "9"];
        for (int i = 0; i < titles.Length; i++)
        {
            var dir = Math.PI * 2 / titles.Length * i;
            var start = r * 0.8f;
            // context.AddCommand(new Command(CommandType.MoveTo, cx + start * (float)Math.Sin(dir), cy + start * (float)Math.Cos(dir)));
            // context.AddCommand(new Command(CommandType.LineTo, cx + r * (float)Math.Sin(dir), cy + r * (float)Math.Cos(dir)));
            // context.Stroke();

            // var textStart = r * 0.6f;
            var fontSize = 18;
            context.SaveState();
            context.SetFontFace("SmileySans");
            context.SetFontSize(fontSize);
            context.Text(titles[i], (int)(cx + start * (float)Math.Sin(dir)), (int)(cy + start * (float)Math.Cos(dir)), TrueType.Mode.VerticalAlign.Middle, TrueType.Mode.HorizontalAlign.Center);
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
