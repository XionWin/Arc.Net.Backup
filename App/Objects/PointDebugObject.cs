using Arc.Core;
using Common;
using OpenTK.Graphics.ES20;
using System.Drawing;

namespace App.Objects
{
    internal class PointDebugObject : IRenderObject
    {
        public int VAO { get; set; }

        public int VBO { get; set; }

        public int EBO { get; set; }

        public Texture? Texture { get; init; }
        public RectangleF TexCoord { get; set; }

        protected Vertex2[]? _vertices = null;
        public Vertex2[] Vertices => this._vertices ?? throw new ArgumentException();

        protected uint[]? _indices = null;
        public uint[] Indices => this._indices ?? throw new ArgumentException();

        private static RectangleF DEFAULT_TEXCOORD = new RectangleF(0, 0, 1, 1);
        public PointDebugObject(Vertex[] vertices, Texture? texture)
        {
            this._vertices = vertices.GetVertex2();

            this._indices = Enumerable.Range(0, this._vertices.Length).Select(x => (uint)x).ToArray();

            this.Texture = texture;
        }

        public void SetVertices(Vertex[] vertices)
        {
            this._vertices = vertices.GetVertex2();
            this._indices = Enumerable.Range(0, this._vertices.Length).Select(x => (uint)x).ToArray();
        }

        public virtual void OnLoad(Shader shader)
        {
            this.VAO = GL.Oes.GenVertexArray();
            this.VBO = GL.GenBuffer();
            this.EBO = GL.GenBuffer();

            GL.Oes.BindVertexArray(this.VAO);

            // bind vbo and set data for vbo
            GL.BindBuffer(BufferTarget.ArrayBuffer, this.VBO);
            var vertices = this.Vertices.GetRaw();
            GL.BufferData(BufferTarget.ArrayBuffer, vertices.Length * sizeof(float), vertices, BufferUsageHint.StaticDraw);

            // bind ebo and set data for ebo
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, this.EBO);
            GL.BufferData(BufferTarget.ElementArrayBuffer, Indices.Length * sizeof(uint), Indices, BufferUsageHint.StaticDraw);

            shader.EnableAttribs(Vertex2.AttribLocations);
        }

        public virtual void Reload(Shader shader)
        {
            GL.Oes.BindVertexArray(this.VAO);

            // bind vbo and set data for vbo
            GL.BindBuffer(BufferTarget.ArrayBuffer, this.VBO);
            var vertices = this.Vertices.GetRaw();
            GL.BufferData(BufferTarget.ArrayBuffer, vertices.Length * sizeof(float), vertices, BufferUsageHint.StaticDraw);

            // bind ebo and set data for ebo
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, this.EBO);
            GL.BufferData(BufferTarget.ElementArrayBuffer, Indices.Length * sizeof(uint), Indices, BufferUsageHint.StaticDraw);

            shader.EnableAttribs(Vertex2.AttribLocations);
        }
        

        public virtual void OnRenderFrame(Shader shader)
        {
            // Bind the VAO
            GL.Oes.BindVertexArray(this.VAO);

            shader.Uniform1("aPointSize", 1);
            if(this.Texture is Texture texture)
            {
                shader.Uniform1("aTexture", 0);
                GL.BindTexture(TextureTarget.Texture2D, texture.Id);
                shader.Uniform1("aMode", 0);
            }
            else
            {
                shader.Uniform1("aTexture", 1);
            }

            // Enable Alpha
            GL.Enable(EnableCap.Blend);
            GL.BlendFunc(BlendingFactorSrc.SrcAlpha, BlendingFactorDest.OneMinusSrcAlpha);

            GL.DrawElements(PrimitiveType.TriangleStrip, this.Indices.Length, DrawElementsType.UnsignedInt, 0);
            
            shader.Uniform1("aMode", 1);
            GL.DrawElements(PrimitiveType.Points, this.Indices.Length, DrawElementsType.UnsignedInt, 0);
            
            shader.Uniform1("aMode", 0);
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
    }
}

public static class PointDebugObjectExtension
{
    internal static Vertex2[] GetVertex2(this Vertex[] vertices)
    {
        return vertices.Select(x => new Vertex2(x.Position.X, x.Position.Y, x.Coordinate.X, x.Coordinate.Y)).ToArray();
    }
}