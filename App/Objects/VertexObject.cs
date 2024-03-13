using Arc.Core;
using Arc.ES20;
using Common;
using OpenTK.Graphics.ES20;

namespace App.Objects
{
    internal class VertexObject : IRenderObject
    {
        public int VAO { get; set; }
        public int VBO { get; set; }
        public IEnumerable<Primitive> Primitives { get; private set; }

        public Texture? Texture { get; init; }

        protected Vertex2[]? _vertices = null;
        public Vertex2[] Vertices => this._vertices ?? (this._vertices = this.Primitives.SelectMany(x => x.VertexMat.SelectMany(x => x)).ToArray().GetVertex2());

        public VertexObject(IEnumerable<Primitive> primitives, Texture? texture)
        {
            this.Primitives = primitives;
            this._vertices = null;
            this.Texture = texture;
        }

        public void SetVertices(IEnumerable<Primitive> primitives)
        {
            this.Primitives = primitives;
            this._vertices = null;
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
            if(this.Texture is Texture texture)
            {
                shader.Uniform1("aTexture", 0);
                shader.Uniform4(
                    "aFrag",
                    new FragUniforms()
                    { 
                        Type = 0
                    }.Values
                );
                GL.BindTexture(TextureTarget.Texture2D, texture.Id);
            }
            else
            {
                shader.Uniform4(
                    "aFrag",
                    new FragUniforms()
                    {
                        Type = 1,
                        StrokeMultiple = 2.0f,
                        InnerColor = new Arc.Core.Color(128f/255f, 140f/255f, 216f/255f, 255f/255f) 
                    }.Values
                );
            }

            // Enable Alpha
            GL.Enable(EnableCap.Blend);
            // GL.BlendFuncSeparate(BlendingFactorSrc.One, BlendingFactorDest.OneMinusSrcAlpha, BlendingFactorSrc.One, BlendingFactorDest.OneMinusSrcAlpha);
            GL.BlendFunc(BlendingFactorSrc.One, BlendingFactorDest.OneMinusSrcAlpha);
            // GL.DepthFunc(DepthFunction.Lequal);

            var index = 0;
            foreach (var primitive in this.Primitives)
            {
                shader.Uniform4(
                    "aFrag",
                    new FragUniforms()
                    {
                        Type = 1,
                        StrokeMultiple = primitive.State.StrokeWidth,
                        InnerColor = primitive.State.FillPaint.InnerColor
                    }.Values
                );
                
                foreach (var row in primitive.VertexMat)
                {
                    GL.DrawArrays(PrimitiveType.TriangleStrip, index, row.Length);
                    index += row.Length;
                }
            }

            // shader.Uniform4("aColor", new OpenTK.Mathematics.Color4(255, 0, 0, 255));
            // shader.Uniform1("aMode", 9);
            // GL.DrawArrays(PrimitiveType.Points, 0, this.Vertices.Length);
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

public static class VertexObjectExtension
{
    internal static Vertex2[] GetVertex2(this Vertex[] vertices)
    {
        return vertices.Select(x => new Vertex2(x.Position.X, x.Position.Y, x.Coordinate.X, x.Coordinate.Y)).ToArray();
    }
}