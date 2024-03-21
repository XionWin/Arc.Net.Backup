using OpenGL.Graphics.ES20;

namespace App;

public class KMSWindow: IDisposable
{
    public EGL.KMSContext KMSContext { get; init; }
    public KMSWindow()
    {
        var files = Directory.GetFiles("/dev/dri");
        var cards = files.Where(x => System.Text.RegularExpressions.Regex.IsMatch(x, @"/dev/dri/card\d+"));

        var fds = cards.Select(x => LIBC.Context.open(x, LIBC.OpenFlags.ReadWrite));
        var drm = DRM.Extension.GetDrm(fds);

        this.KMSContext = new EGL.KMSContext(drm, EGL.RenderableSurfaceType.OpenGLES) { VerticalSynchronization = true }.Initialize(ContextInit);
        
        var shader = new Arc.ES20.Shader("Shaders/Arc.vert", "Shaders/Arc.frag");
        shader.Uniform2("aViewport", this.KMSContext.Width, this.KMSContext.Height);
    }

    public void Run()
    {
        this.KMSContext.Render(() => ContextRender());
    }

    private void ContextInit(EGL.KMSContext ctx)
    {
        Console.WriteLine($"GL Extensions: {GL.GetString(StringName.Extensions)}");
        Console.WriteLine($"GL Version: {GL.GetString(StringName.Version)}");
        Console.WriteLine($"GL Sharding Language Version: {GL.GetString(StringName.ShadingLanguageVersion)}");
        Console.WriteLine($"GL Vendor: {GL.GetString(StringName.Vendor)}");
        Console.WriteLine($"GL Renderer: {GL.GetString(StringName.Renderer)}");
    }

    private void ContextRender()
    {
        GL.ClearColor(0.5f, 0f, 0f, 1f);
        GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
    }

    public void Dispose()
    {
        if(this.KMSContext is EGL.KMSContext context)
        {
            context.Dispose();
        }
    }
} 