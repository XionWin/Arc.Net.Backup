#if KMS_MODE
using OpenGL.Graphics.ES20;
#else
using OpenTK.Graphics.ES20;
#endif
using Arc.ES20;
using Extension;
using Arc.Core;

namespace App;

public class KMSWindow: IDisposable
{
    public EGL.KMSContext KMSContext { get; init; }
    public Shader Shader { get; init; }

    /// <summary>
    /// For Testing
    /// </summary>
    private Texture? _fontTexture;
    private List<Objects.TextureObject> _renderObjects = new List<Objects.TextureObject>();
    /// <summary>
    /// For Testing End
    /// </summary>
    /// 

    public Context<Renderer> ArcContext { get; init; }
    public KMSWindow()
    {
        var files = Directory.GetFiles("/dev/dri");
        var cards = files.Where(x => System.Text.RegularExpressions.Regex.IsMatch(x, @"/dev/dri/card\d+"));

        var fds = cards.Select(x => LIBC.Context.open(x, LIBC.OpenFlags.ReadWrite));
        var drm = DRM.Extension.GetDrm(fds);

        this.KMSContext = new EGL.KMSContext(drm, EGL.RenderableSurfaceType.OpenGLES) { VerticalSynchronization = true }.Initialize(ContextInit);
        
        this.Shader = new Arc.ES20.Shader("Shaders/Arc.vert", "Shaders/Arc.frag");
        this.Shader.Uniform2("aViewport", this.KMSContext.Width, this.KMSContext.Height);
        
        this.ArcContext = new Context<Renderer>(new Renderer(this.Shader));
        TestContentInit();
    }

    public void Run()
    {
        this.KMSContext.Render(() => ContextRender(this.KMSContext));
    }

    private void ContextInit(EGL.KMSContext ctx)
    {
        Console.WriteLine($"GL Extensions: {GL.GetString(StringName.Extensions)}");
        Console.WriteLine($"GL Version: {GL.GetString(StringName.Version)}");
        Console.WriteLine($"GL Sharding Language Version: {GL.GetString(StringName.ShadingLanguageVersion)}");
        Console.WriteLine($"GL Vendor: {GL.GetString(StringName.Vendor)}");
        Console.WriteLine($"GL Renderer: {GL.GetString(StringName.Renderer)}");
    
        ArcCanvas.Init();
        GL.ClearColor(System.Drawing.Color.MidnightBlue);
    }

    private void TestContentInit()
    {
        var fontName = "SmileySans";
        var path = @$"Resources/Fonts/{fontName}.ttf";
        if (File.Exists(path))
        {
            var ttf = new TrueType.Domain.TTF(fontName, path);

            var fontSize = 28;
            var x = 10;
            var y = fontSize;

            "原神启动！".Foreach(
                (c, p) =>
                {
                    var glyph = ttf.GetGlyph(c, fontSize, 0, p);
                    var bitmap = glyph.Bitmap;
                    var texCoordX = (float)bitmap.TexRect.X / TrueType.Domain.MonoCanvas.Instance.Size.Width;
                    var texCoordY = (float)bitmap.TexRect.Y / TrueType.Domain.MonoCanvas.Instance.Size.Height;
                    var texCoordWidth = (float)bitmap.TexRect.Width / TrueType.Domain.MonoCanvas.Instance.Size.Width;
                    var texCoordHeight = (float)bitmap.TexRect.Height / TrueType.Domain.MonoCanvas.Instance.Size.Height;
                    var texCoord = new System.Drawing.RectangleF(texCoordX, texCoordY, texCoordWidth, texCoordHeight);

                    // Why can't use the offset x?
                    if (x + glyph.Size.Width > 1024)
                    {
                        x = 0;
                        y += fontSize;
                    }
                    x += glyph.Size.Width + 5;
                }
            );
            
            var canvas = TrueType.Domain.MonoCanvas.Instance;
            var data = canvas.Pixels;
            this._fontTexture = new Texture(TextureUnit.Texture0, TextureMinFilter.Nearest).With(x => x.LoadRaw(data, canvas.Size.Width, canvas.Size.Height, PixelFormat.Alpha, TextureComponentCount.Alpha));
            _renderObjects.Add(new Objects.TextureObject(new System.Drawing.Rectangle(280 + 100, 200, canvas.Size.Width, canvas.Size.Height), this._fontTexture));
        }
        
        foreach (var renderObject in _renderObjects)
        {
            renderObject.OnLoad(this.Shader);
        }
    }

    private void ContextRender(EGL.KMSContext ctx)
    {
        GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
        this.Shader.Uniform2("aViewport", this.KMSContext.Width, this.KMSContext.Height);
        
        ArcCanvas.Draw(this.ArcContext, (ctx.Width, ctx.Height));

        foreach (var renderObject in _renderObjects)
        {
            renderObject.OnRenderFrame(this.Shader);
        }
    }

    public void Dispose()
    {
        if(this.KMSContext is EGL.KMSContext context)
        {
            context.Dispose();
        }
    }
} 