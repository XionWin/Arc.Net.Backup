using OpenGL.Graphics.ES20;

namespace App;

public static class KMSSurface
{
    public static void Run()
    {
        var files = System.IO.Directory.GetFiles("/dev/dri");
        var cards = files.Where(x => System.Text.RegularExpressions.Regex.IsMatch(x, @"/dev/dri/card\d+"));

        var fds = cards.Select(x => LIBC.Context.open(x, LIBC.OpenFlags.ReadWrite));
        var drm = DRM.Extension.GetDrm(fds);

        using (var ctx = new EGL.KMSContext(drm, EGL.RenderableSurfaceType.OpenGLES) { VerticalSynchronization = true }.Initialize(ContextInit))
        {
            var shader = new Arc.ES20.Shader("Shaders/Arc.vert", "Shaders/Arc.frag");
            shader.Uniform2("aViewport", ctx.Width, ctx.Height);
            
            ctx.Render(() => ContextRender());
        }

    }

    private static void ContextInit(EGL.KMSContext ctx)
    {
        Console.WriteLine($"GL Extensions: {GL.GetString(StringName.Extensions)}");
        Console.WriteLine($"GL Version: {GL.GetString(StringName.Version)}");
        Console.WriteLine($"GL Sharding Language Version: {GL.GetString(StringName.ShadingLanguageVersion)}");
        Console.WriteLine($"GL Vendor: {GL.GetString(StringName.Vendor)}");
        Console.WriteLine($"GL Renderer: {GL.GetString(StringName.Renderer)}");

    }

    private static void ContextRender()
    {
        // GL.ClearColor(0.5f, 0, 0, 1f);
        // GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
        GL.ClearColor(0.5f, 0f, 0f, 1f);
        GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

    }

} 