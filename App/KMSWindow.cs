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
        GL.ClearColor(System.Drawing.Color.Black);
    }

    private void ContextRender(EGL.KMSContext ctx)
    {
        GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
        this.Shader.Uniform2("aViewport", this.KMSContext.Width, this.KMSContext.Height);
        
        ArcCanvas.Draw(this.ArcContext, (ctx.Width, ctx.Height));
    }

    public void Dispose()
    {
        if(this.KMSContext is EGL.KMSContext context)
        {
            context.Dispose();
        }
    }
} 