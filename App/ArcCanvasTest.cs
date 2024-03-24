// #if KMS_MODE
// using OpenGL.Graphics.ES20;
// #else
// using OpenTK.Graphics.ES20;
// #endif
// using Arc.Core;
// using Arc.ES20;
// using Extension;

// namespace App;

// public static class ArcCanvas
// {
//     static Dictionary<string, Texture> TEXTURES = new Dictionary<string, Texture>();
//     public static void Init()
//     {
//         TEXTURES.Add(
//             "bg",  new Texture(TextureUnit.Texture0, TextureMinFilter.Linear).With(x => x.LoadImage(@"Resources/Images/bg.png"))
//         );
//         TEXTURES.Add(
//             "container",  new Texture(TextureUnit.Texture0, TextureMinFilter.Linear).With(x => x.LoadImage(@"Resources/Images/container.png"))
//         );
//         TEXTURES.Add(
//             "icon",  new Texture(TextureUnit.Texture0, TextureMinFilter.Linear).With(x => x.LoadImage(@"Resources/Images/icon.png"))
//         );
//         TEXTURES.Add(
//             "arc",  new Texture(TextureUnit.Texture0, TextureMinFilter.Linear).With(x => x.LoadImage(@"Resources/Images/arc.png"))
//         );
//         TEXTURES.Add(
//             "wallpaper",  new Texture(TextureUnit.Texture0, TextureMinFilter.Linear).With(x => x.LoadImage(@"Resources/Images/wallpaper.png"))
//         );
//         TEXTURES.Add(
//             "genshin_avatar",  new Texture(TextureUnit.Texture0, TextureMinFilter.Linear).With(x => x.LoadImage(@"Resources/Images/genshin_avatar.png"))
//         );
//         TEXTURES.Add(
//             "genshin_logo",  new Texture(TextureUnit.Texture0, TextureMinFilter.Linear).With(x => x.LoadImage(@"Resources/Images/genshin_logo.png"))
//         );
//         TEXTURES.Add(
//             "genshin_character",  new Texture(TextureUnit.Texture0, TextureMinFilter.Linear).With(x => x.LoadImage(@"Resources/Images/genshin_character.png"))
//         );  
//     }

//     static int MARGIN = 20;
//     static int INNER_MARGIN = MARGIN / 2;
//     public static RenderData Draw(Context<Renderer> context, (int width, int height) viewSize)
//     {
//         var width = viewSize.width;
//         var height = viewSize.height;
//         context.BeginFrame();

//         context.GetState().StrokeWidth = 1;
//         context.GetState().LineCap = LineCap.Round;
//         context.GetState().LineJoin = LineJoin.Round;
//         context.GetState().StrokePaint.InnerColor = new Color(255, 255, 255, 255);
//         context.GetState().FillPaint.InnerColor = new Color(255, 255, 255, 255);

//         DrawLineDecoration(context, 200, 100, 100, 100);

//         context.EndFrame();
//         return context.Renderer.Data;
//     }
    
//     private static void DrawLineDecoration(IContext context, float l, float t, int w, int h)
//     {
//         l += 0.5f;
//         t += 0.5f;
//         var rx = w /2 * 0.5f;
//         var ry = h /2 * 0.5f;
//         context.SaveState();
//         context.GetState().StrokeWidth = 5;
//         context.GetState().LineCap = LineCap.Butt;
//         context.GetState().LineJoin = LineJoin.Miter;
//         context.GetState().StrokePaint.InnerColor = new Color(255, 255, 255, 255);
//         context.GetState().FillPaint.InnerColor = new Color(255, 255, 255, 32);
//         context.AddCommand(CommandType.MoveTo, l + w / 2, t);
//         context.AddCommand(CommandType.BezierTo,
//         l + w / 2, t + ry,
//         l + w - rx, t + h / 2,
//         l + w, t + h / 2);
//         context.AddCommand(CommandType.BezierTo,
//         l + w - rx, t + h / 2,
//         l + w / 2, t + h - ry,
//         l + w / 2, t + h);
//         context.AddCommand(CommandType.BezierTo,
//         l + w / 2, t + h - ry,
//         l + rx, t + h / 2,
//         l, t + h / 2);
//         context.AddCommand(CommandType.BezierTo,
//         l + rx, t + h / 2,
//         l + w / 2, t + ry,
//         l + w / 2, t);
//         context.AddCommand(CommandType.Close);
//         context.Fill();
//         context.Stroke();

//         context.RestoreState();
//     }
    

// } 