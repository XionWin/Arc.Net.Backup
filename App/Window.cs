#if KMS_MODE
using OpenGL.Graphics.ES20;
#else
using OpenTK.Graphics.ES20;
#endif
using Arc.Core;
using Arc.ES20;
using Extension;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.GraphicsLibraryFramework;

namespace App
{
    public class Window : GLWindow
    {
        public Window(int width, int height) : base("Arc", width, height)
        {
            this.ArcContext = new Context<Renderer>(new Renderer(this.Shader));
        }

        private Dictionary<string, Texture> _textures = new Dictionary<string, Texture>();

        public Context<Renderer> ArcContext { get; init; }
        protected override void OnLoad()
        {
            base.OnLoad();

            GL.PixelStore(PixelStoreParameter.UnpackAlignment, 1);
            _textures.Add(
                "bg",  new Texture(TextureUnit.Texture0, TextureMinFilter.Linear).With(x => x.LoadImage(@"Resources/Images/bg.png"))
            );
            _textures.Add(
                "container",  new Texture(TextureUnit.Texture0, TextureMinFilter.Linear).With(x => x.LoadImage(@"Resources/Images/container.png"))
            );
            _textures.Add(
                "icon",  new Texture(TextureUnit.Texture0, TextureMinFilter.Linear).With(x => x.LoadImage(@"Resources/Images/icon.png"))
            );
            _textures.Add(
                "arc",  new Texture(TextureUnit.Texture0, TextureMinFilter.Linear).With(x => x.LoadImage(@"Resources/Images/arc_blue.png"))
            );

            // GL.ActiveTexture(TextureUnit.Texture0);
            // GL.BindTexture(TextureTarget.Texture2D, _textures["bg"]?.Id ?? 0);
            // var x1 = 500;
            // var y1 = 200;
            // var w = 1;
            // var h = 4;
            // var subData = Enumerable.Repeat((byte)0x00, w * h * 4).ToArray();

            // GL.PixelStore(PixelStoreParameter.UnpackAlignment, 1);
            // GL.TexSubImage2D(TextureTarget2d.Texture2D, 0, x1, y1, w, h, PixelFormat.Rgba, PixelType.UnsignedByte, subData);

            GL.ClearColor(System.Drawing.Color.MidnightBlue);
        }

        protected override void OnRenderFrame(FrameEventArgs args)
        {
            base.OnRenderFrame(args);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.Viewport(0, 0, this.Size.X, this.Size.Y);
            ArcCanvas.Draw(this.ArcContext);

            SwapBuffers();
        }

        protected override void OnUpdateFrame(FrameEventArgs args)
        {
            base.OnUpdateFrame(args);

            if (this.KeyboardState.IsKeyDown(Keys.Escape))
            {
                Close();
            }
        }

        protected override void OnResize(ResizeEventArgs e)
        {
            base.OnResize(e);

            // When the window gets resized, we have to call GL.Viewport to resize OpenGL's viewport to match the new size.
            // If we don't, the NDC will no longer be correct.
            GL.Viewport(0, 0, Size.X, Size.Y);
            this.Shader.Uniform2("aViewport", this.Size.X, this.Size.Y);
        }

        protected override void OnUnload()
        {
            // Unbind all the resources by binding the targets to 0/null.
            GL.BindBuffer(BufferTarget.ArrayBuffer, 0);
            GL.Oes.BindVertexArray(0);
            GL.UseProgram(0);
            GL.DeleteProgram(Shader.ProgramHandle);
            base.OnUnload();
        }
    }
}
