using App.Objects;
using Arc.ES20;
using Extension;
using OpenTK.Graphics.ES20;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.GraphicsLibraryFramework;
using System.Drawing;

namespace App
{
    public class Window : GLWindow
    {
        static int MARGIN = 20;
        public Window(int width, int height) : base("Pencil", width, height)
        { }

        private Dictionary<string, Texture> _textures = new Dictionary<string, Texture>();

        private List<IRenderObject> _renderObjects = new List<IRenderObject>();

        protected override void OnLoad()
        {
            base.OnLoad(); 


            GL.PixelStore(PixelStoreParameter.UnpackAlignment, 1);
            _textures.Add(
                "bg",  new Texture(TextureUnit.Texture0, TextureMinFilter.Nearest).With(x => x.LoadImage(@"Resources/Images/bg.png"))
            );
            _textures.Add(
                "container",  new Texture(TextureUnit.Texture0, TextureMinFilter.Nearest).With(x => x.LoadImage(@"Resources/Images/container.png"))
            );
            _textures.Add(
                "icon",  new Texture(TextureUnit.Texture0, TextureMinFilter.Nearest).With(x => x.LoadImage(@"Resources/Images/icon.png"))
            );


            GL.ActiveTexture(TextureUnit.Texture0);
            GL.BindTexture(TextureTarget.Texture2D, _textures["bg"]?.Id ?? 0);
            var x1 = 500;
            var y1 = 200;
            var w = 1;
            var h = 4;
            var subData = Enumerable.Repeat((byte)0x00, w * h * 4).ToArray();

            GL.PixelStore(PixelStoreParameter.UnpackAlignment, 1);
            GL.TexSubImage2D(TextureTarget2d.Texture2D, 0, x1, y1, w, h, PixelFormat.Rgba, PixelType.UnsignedByte, subData);

            _renderObjects.AddRange(
                [
                    // new TextureObject(new Rectangle(0, 0, 800, 480), _textures["bg"]),
                    // new TextureObject(new Rectangle(100, 100, 100, 100), _textures["bg"]),
                    // new TextureObject(new Rectangle(400, 100, 256, 256), _textures["container"]),
                    new TextureObject(new Rectangle(800 - 64 - MARGIN , MARGIN, 64, 64), _textures["icon"]),
                ]
            );

            // var primitives = ArcTest.Test();
            // _renderObjects.Add(
            //     new VertexObject(primitives, null)
            // );

            GL.ClearColor(Color.MidnightBlue);
            
            foreach (var renderObject in _renderObjects)
            {
                renderObject.OnLoad(this.Shader);
            }
        }

        protected override void OnRenderFrame(FrameEventArgs args)
        {
            base.OnRenderFrame(args);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.Viewport(0, 0, this.Size.X, this.Size.Y);


            if(_renderObjects.FirstOrDefault( x => x is VertexObject) is VertexObject vertexObject)
            {
                vertexObject.SetVertices(ArcTest.Test());
                vertexObject.Reload(this.Shader);
            }
            else
            {
                var newVertexObject = new VertexObject(ArcTest.Test(), null);
                newVertexObject.OnLoad(this.Shader);
                _renderObjects.Add(newVertexObject);
            }
            
            foreach (var renderObject in _renderObjects)
            {
                // GL.Disable(EnableCap.DepthTest);
                // GL.ColorMask(false, false, false, false);
                renderObject.OnRenderFrame(this.Shader);
                // GL.Enable(EnableCap.DepthTest);
                // GL.ColorMask(true,true,true,true);
                // GL.DepthFunc(DepthFunction.Lequal);
            }

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

    public static class WindowExtension
    {
        public static Arc.Core.Vertex[] ToVertex(this Arc.Core.Point[] points) =>
            points.Select(x => new Arc.Core.Vertex(x.X, x.Y, 0, 0)).ToArray();
    }
}
