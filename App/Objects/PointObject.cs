using Arc.Core;
using Common;
using OpenTK.Graphics.ES20;
using System.Drawing;

namespace App.Objects
{
    internal class PointObject : IRenderObject
    {
        public int VAO { get; set; }

        public int VBO { get; set; }

        protected Vertex2[]? _vertices = null;
        public Vertex2[] Vertices => this._vertices ?? throw new ArgumentException();

        protected uint[]? _indices = null;
        public uint[] Indices => this._indices ?? throw new ArgumentException();

        private static RectangleF DEFAULT_TEXCOORD = new RectangleF(0, 0, 1, 1);
        public PointObject(Vertex[] vertices)
        {
            this._vertices = vertices.GetVertex2();

            this._indices = Enumerable.Range(0, this._vertices.Length).Select(x => (uint)x).ToArray();
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

            GL.Oes.BindVertexArray(this.VAO);

            // bind vbo and set data for vbo
            GL.BindBuffer(BufferTarget.ArrayBuffer, this.VBO);
            var vertices = this.Vertices.GetRaw();
            GL.BufferData(BufferTarget.ArrayBuffer, vertices.Length * sizeof(float), vertices, BufferUsageHint.StaticDraw);

            shader.EnableAttribs(Vertex2.AttribLocations);
        }

        public virtual void Reload(Shader shader)
        {
            GL.Oes.BindVertexArray(this.VAO);

            // bind vbo and set data for vbo
            GL.BindBuffer(BufferTarget.ArrayBuffer, this.VBO);
            var vertices = this.Vertices.GetRaw();
            GL.BufferData(BufferTarget.ArrayBuffer, vertices.Length * sizeof(float), vertices, BufferUsageHint.StaticDraw);
        }
        

        public virtual void OnRenderFrame(Shader shader)
        {
            // Bind the VAO
            GL.Oes.BindVertexArray(this.VAO);

            shader.Uniform1("aPointSize", 1);
            shader.Uniform4("aColor", new OpenTK.Mathematics.Color4(255, 0, 0, 128));

            // Enable Alpha
            GL.Enable(EnableCap.Blend);
            GL.BlendFunc(BlendingFactorSrc.SrcAlpha, BlendingFactorDest.OneMinusSrcAlpha);

            shader.Uniform1("aMode", 9);
            GL.DrawArrays(PrimitiveType.Points, 0, this.Vertices.Length);
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