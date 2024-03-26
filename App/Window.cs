﻿#if KMS_MODE
using OpenGL.Graphics.ES20;
#else
using OpenTK.Graphics.ES20;
#endif
using Arc.Core;
using Arc.ES20;
using Extension;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.GraphicsLibraryFramework;
using App.Objects;

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
        public TrueType.Domain.TTF? TTF { get; private set; }
        public TrueType.Domain.ICanvas? Canvas { get; private set; }
        protected override void OnLoad()
        {
            base.OnLoad();

            var fontName = "SmileySans";
            var path = @$"Resources/Fonts/{fontName}.ttf";
            if (File.Exists(path))
            {
                var maxTextureSize = GL.GetInteger(GetPName.MaxTextureSize);
                this.Canvas = new TrueType.Domain.MonoCanvas(new TrueType.Mode.Size(512, maxTextureSize));
                this.TTF = new TrueType.Domain.TTF(fontName, path, this.Canvas);

                var data = this.Canvas!.Pixels;
                this._fontTexture = new Texture(TextureUnit.Texture0, TextureMinFilter.Nearest).With(x => x.LoadRaw(data, this.Canvas!.Size.Width, this.Canvas!.Size.Height, PixelFormat.Alpha, TextureComponentCount.Alpha));
                _renderObjects.Add(new Objects.TextureObject(new System.Drawing.Rectangle(40, 240, this.Canvas!.Size.Width, this.Canvas!.Size.Height), this._fontTexture));
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
                if(DateTime.Now.Microsecond is var ms &&  ms / 10 is var tick && updatedTick != tick && renderObject is TextureObject textureObject)
                {
                    updatedTick = tick;
                    UpdateTexture(textureObject);
                }
                renderObject.OnRenderFrame(this.Shader);
            }

            SwapBuffers();
        }

        static int counter = 158;
        static int updatedTick = 0;
        static List<int> notIncludedList = new List<int>(){ 32, 160};
        private void UpdateTexture(TextureObject textureObject)
        {
            var fontSize = 28;
            // var x = 10;
            // var y = fontSize;

            this.Shader.Uniform1("aTexture", 0);
			GL.BindTexture(TextureTarget.Texture2D, textureObject.Texture.Id);
            
            var lastCounter = counter;
            counter++;
            if(notIncludedList.Contains(counter))
            {
                ++counter;
            }
            counter = counter % 255;
            var glyph = this.TTF!.GetGlyph((char)(counter), fontSize, 0, (char)(lastCounter));

            var data = this.Canvas!.Pixels;
            GL.TexSubImage2D(TextureTarget2d.Texture2D, 0, 0, 0, this.Canvas!.Size.Width, this.Canvas!.Size.Height, PixelFormat.Alpha, PixelType.UnsignedByte, data);

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
