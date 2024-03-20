using OpenGL.Def;
using OpenGL.Objects;

namespace App;

public static class KMSSurface
{
    public static void Run()
    {
        var files = System.IO.Directory.GetFiles("/dev/dri");
        var cards = files.Where(x => System.Text.RegularExpressions.Regex.IsMatch(x, @"/dev/dri/card\d+"));

        var fds = cards.Select(x => LIBC.Context.open(x, LIBC.OpenFlags.ReadWrite));
        var drm = DRM.Extension.GetDrm(fds);


        // float angle = 0f;
        using (var ctx = new EGL.KMSContext(drm, EGL.RenderableSurfaceType.OpenGLES) { VerticalSynchronization = true }.Initialize(ContextInit))
        {
            using (var program = new GLProgram(@"Shaders/Arc.vert", @"Shaders/Arc.frag"))
            {
                OpenGL.ES20.glUseProgram(program);
                program.SetUniform2("aViewport", ctx.Width, ctx.Height);
                ctx.Render(() => ContextRender(program));
            }
        }

    }

    
    private static void ContextInit(EGL.KMSContext ctx)
    {
        Console.WriteLine($"GL Extensions: {OpenGL.ES20.GetString(OpenGL.Def.StringName.Extensions)}");
        Console.WriteLine($"GL Version: {OpenGL.ES20.GetString(OpenGL.Def.StringName.Version)}");
        Console.WriteLine($"GL Sharding Language Version: {OpenGL.ES20.GetString(OpenGL.Def.StringName.ShadingLanguageVersion)}");
        Console.WriteLine($"GL Vendor: {OpenGL.ES20.GetString(OpenGL.Def.StringName.Vendor)}");
        Console.WriteLine($"GL Renderer: {OpenGL.ES20.GetString(OpenGL.Def.StringName.Renderer)}");

        OpenGL.ES20.glClearColor(0f, 0f, 0f, 1f);
        OpenGL.ES20.glViewport(0, 0, ctx.Width, ctx.Height);
    }

    private static void ContextRender(OpenGL.Objects.GLProgram program)
{
    // angle += 2;
    // var color = new Graphic.Drawing.Color.HSLA(angle = angle >= 360 ? 0 : angle, 1f, 0.2f, 1f);
    // var rgb = color.ToRGB();

    // GL.ClearColor(0.5f, 0, 0, 1f);
    // GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
    OpenGL.ES20.glClearColor(0.5f, 0f, 0f, 1f);
    OpenGL.ES20.glClear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

    // Enable Alpha
    // OpenGL.ES.glEnable(EnableCap.Blend);
    // OpenGL.ES.glBlendFunc(All.SrcAlpha, All.OneMinusSrcAlpha);

    // program.SetUniform1("aTexture", 0);
    

}

} 