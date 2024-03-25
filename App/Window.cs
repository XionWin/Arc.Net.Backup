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
        protected override void OnLoad()
        {
            base.OnLoad();

            var fontName = "SmileySans";
            var path = @$"Resources/Fonts/{fontName}.ttf";
            if (File.Exists(path))
            {
                var maxTextureSize = GL.GetInteger(GetPName.MaxTextureSize);
                var canvas = new TrueType.Domain.MonoCanvas(new TrueType.Mode.Size(maxTextureSize, maxTextureSize));
                var ttf = new TrueType.Domain.TTF(fontName, path, canvas);

                var fontSize = 28;
                var x = 10;
                var y = fontSize;

                "原神启动！".Foreach(
                    (c, p) =>
                    {
                        var glyph = ttf.GetGlyph(c, fontSize, 0, p);
                        var bitmap = glyph.Bitmap;
                        var texCoordX = (float)bitmap.TexRect.X / canvas.Size.Width;
                        var texCoordY = (float)bitmap.TexRect.Y / canvas.Size.Height;
                        var texCoordWidth = (float)bitmap.TexRect.Width / canvas.Size.Width;
                        var texCoordHeight = (float)bitmap.TexRect.Height / canvas.Size.Height;
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
                
                var data = canvas.Pixels;
                this._fontTexture = new Texture(TextureUnit.Texture1, TextureMinFilter.Nearest).With(x => x.LoadRaw(data, canvas.Size.Width, canvas.Size.Height, PixelFormat.Alpha, TextureComponentCount.Alpha));
                _renderObjects.Add(new Objects.TextureObject(new System.Drawing.Rectangle(280 + 100, 200, canvas.Size.Width, canvas.Size.Height), this._fontTexture));
            }
            
            foreach (var renderObject in _renderObjects)
            {
                renderObject.OnLoad(this.Shader);
            }

            ArcCanvas.Init();
            GL.ClearColor(System.Drawing.Color.MidnightBlue);
        }

        protected override void OnRenderFrame(FrameEventArgs args)
        {
            base.OnRenderFrame(args);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.Viewport(0, 0, this.Size.X, this.Size.Y);
            ArcCanvas.Draw(this.ArcContext, (this.Size.X, this.Size.Y));

            foreach (var renderObject in _renderObjects)
            {
                renderObject.OnRenderFrame(this.Shader);
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
}
