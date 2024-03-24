using Arc.ES20;
using OpenTK.Graphics.ES20;
using OpenTK.Mathematics;
using System.Drawing;

namespace App.Objects
{
    internal class TextureObject : IRenderObject
    {
        public int VAO { get; set; }

        public int VBO { get; set; }

        public Rectangle Rectangle { get; set; }
        public Texture Texture { get; init; }
        public RectangleF TexCoord { get; set; }

        protected Vertex2[]? _vertices = null;
        public Vertex2[] Vertices => this._vertices ?? throw new ArgumentException();

        public Matrix3 Matrix { get; set; } = Matrix3.Identity;
        public Point Center => new Point(this.Rectangle.X + this.Rectangle.Width / 2, this.Rectangle.Y + this.Rectangle.Height / 2);

        private static RectangleF DEFAULT_TEXCOORD = new RectangleF(0, 0, 1, 1);

        public TextureObject(Rectangle rectangle, Texture texture, RectangleF? texCoord = null)
        {
            this.Rectangle = rectangle;
            this.Texture = texture;
            this.TexCoord = texCoord ?? DEFAULT_TEXCOORD;
        }

        public virtual void OnLoad(Shader shader)
        {
            this.VAO = GL.Oes.GenVertexArray();
            this.VBO = GL.GenBuffer();

            GL.Oes.BindVertexArray(this.VAO);

            SetVertexes(shader);

            // bind vbo and set data for vbo
            GL.BindBuffer(BufferTarget.ArrayBuffer, this.VBO);
            var vertices = this.Vertices.GetRaw();
            GL.BufferData(BufferTarget.ArrayBuffer, vertices.Length * sizeof(float), vertices, BufferUsageHint.StaticDraw);

            shader.EnableAttribs(Vertex2.AttribLocations);
        }
        
        public virtual void SetVertexes(Shader shader)
        {
            _vertices =
            [
                new Vertex2(new Vector2(this.Rectangle.X, this.Rectangle.Y), new Vector2(this.TexCoord.Left, this.TexCoord.Top)),
                new Vertex2(new Vector2(this.Rectangle.X + this.Rectangle.Width, this.Rectangle.Y), new Vector2(this.TexCoord.Right, this.TexCoord.Top)),
                new Vertex2(new Vector2(this.Rectangle.X, this.Rectangle.Y + this.Rectangle.Height), new Vector2(this.TexCoord.Left, this.TexCoord.Bottom)),
                new Vertex2(new Vector2(this.Rectangle.X + this.Rectangle.Width, this.Rectangle.Y + this.Rectangle.Height), new Vector2(this.TexCoord.Right, this.TexCoord.Bottom)),
            ];
        }

        public virtual void OnRenderFrame(Shader shader, int textureUnit)
        {
            // Bind the VAO
            GL.Oes.BindVertexArray(this.VAO);

            // Enable Alpha
            GL.Enable(EnableCap.Blend);
            GL.BlendFunc(BlendingFactorSrc.SrcAlpha, BlendingFactorDest.OneMinusSrcAlpha);

            shader.Uniform1("aTexture", textureUnit);
            shader.Uniform4(
                "aFrag",
                new FragUniform()
                {
                    Type = Arc.Core.FragUniformType.Image,
                    InnerColor = new Arc.Core.Color(255, 255, 255, 255)
                }.Values
            );
            GL.BindTexture(TextureTarget.Texture2D, this.Texture?.Id ?? 0);

            GL.DrawArrays(PrimitiveType.TriangleStrip, 0, this.Vertices.Length);
        }

        public void Dispose()
        {
            // Unbind all the resources by binding the targets to 0/null.
            GL.BindBuffer(BufferTarget.ArrayBuffer, this.VBO);
            GL.Oes.BindVertexArray(this.VAO);

            // Delete all the resources.
            GL.DeleteBuffer(this.VBO);
            GL.Oes.DeleteVertexArray(this.VAO);
        }

        public void Reload(Shader shader)
        {
            throw new NotImplementedException();
        }
    }
}