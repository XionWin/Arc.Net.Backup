using Arc.Core;
using Arc.ES20;
using OpenTK.Graphics.ES20;

namespace App.Objects
{
    internal class VertexObject : IRenderObject
    {
        public int VAO { get; set; }
        public int VBO { get; set; }
        public IEnumerable<RenderCall> Calls { get; private set; }
        public FragUniform[] FragUniforms { get; private set; }

        public Texture? Texture { get; init; }

        public Vertex2[] Vertices { get; private set; }

        public VertexObject(RenderCache renderCache, Texture? texture)
        {

            this.Calls = renderCache.Calls;
            this.Vertices = renderCache.Vertices.ToArray();
            this.FragUniforms = renderCache.FragUniforms.ToArray();
            this.Texture = texture;
        }

        public void SetVertices(RenderCache renderCache)
        {
            this.Calls = renderCache.Calls;
            this.Vertices = renderCache.Vertices.ToArray();
            this.FragUniforms = renderCache.FragUniforms.ToArray();
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
                    new FragUniform()
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
                    new FragUniform()
                    {
                        Type = FragUniformType.FillImage,
                        StrokeMultiple = 2.0f,
                        InnerColor = new Arc.Core.Color(128f/255f, 140f/255f, 216f/255f, 255f/255f) 
                    }.Values
                );
            }

            // Enable Alpha
            // GL.Enable(EnableCap.Blend);
            // GL.BlendFuncSeparate(BlendingFactorSrc.One, BlendingFactorDest.OneMinusSrcAlpha, BlendingFactorSrc.One, BlendingFactorDest.OneMinusSrcAlpha);
            // GL.BlendFunc(BlendingFactorSrc.One, BlendingFactorDest.OneMinusSrcAlpha);
            // GL.DepthFunc(DepthFunction.Lequal);

            foreach (var call in this.Calls)
            {
                

                if(call.Type is CallType.Stroke)
                {
                    GL.Enable(EnableCap.Blend);
                    GL.BlendFunc(BlendingFactorSrc.One, BlendingFactorDest.OneMinusSrcAlpha);

                    shader.Uniform4(
                        "aFrag",
                        this.FragUniforms[call.UniformOffset].Values
                    );
                    GL.DrawArrays(PrimitiveType.TriangleStrip, call.Offset, call.Length);
                }
                else if(call.Type is CallType.Fill)
                {
                    if(call is RenderFillCall renderFillCall)
                    {
                        GL.Enable(EnableCap.Blend);
                        GL.BlendFunc(BlendingFactorSrc.SrcAlpha, BlendingFactorDest.OneMinusSrcAlpha);

                        GL.Enable(EnableCap.StencilTest);
                        GL.StencilMask(0xff);
                        GL.StencilFunc(StencilFunction.Always, 0x00, 0xff);
                        GL.ColorMask(false, false, false, false);
                        
                        shader.Uniform4(
                            "aFrag",
                            this.FragUniforms[renderFillCall.UniformOffset].Values
                        );

                        GL.StencilOpSeparate(StencilFace.Front, StencilOp.Keep, StencilOp.Keep, StencilOp.IncrWrap);
                        GL.StencilOpSeparate(StencilFace.Back, StencilOp.Keep, StencilOp.Keep, StencilOp.DecrWrap);
                        GL.Disable(EnableCap.CullFace);

                        GL.DrawArrays(PrimitiveType.TriangleFan, renderFillCall.Offset, renderFillCall.Length);

                        GL.Enable(EnableCap.CullFace);
                        GL.ColorMask(true, true, true, true);

                        shader.Uniform4(
                            "aFrag",
                            this.FragUniforms[renderFillCall.TriangleUniformOffset].Values
                        );

                        GL.StencilFunc(StencilFunction.Notequal, 0x0, 0xff);
                        GL.StencilOp(StencilOp.Zero, StencilOp.Zero, StencilOp.Zero);

                        GL.DrawArrays(PrimitiveType.TriangleStrip, renderFillCall.TriangleOffset, renderFillCall.TriangleLength);
                        
                        GL.Disable(EnableCap.StencilTest);
                        GL.Disable(EnableCap.CullFace);
                    }
                    else
                    {
                        throw new Exception("Unexpected");
                    }
                }
                else if(call.Type is CallType.ConvexFill)
                {
                    GL.Enable(EnableCap.Blend);
                    GL.BlendFunc(BlendingFactorSrc.SrcAlpha, BlendingFactorDest.OneMinusSrcAlpha);
                    shader.Uniform4(
                        "aFrag",
                        this.FragUniforms[call.UniformOffset].Values
                    );
                    GL.DrawArrays(PrimitiveType.TriangleFan, call.Offset, call.Length);
                }
                else if(call.Type is CallType.Triangle)
                {
                    shader.Uniform4(
                        "aFrag",
                        this.FragUniforms[call.UniformOffset].Values
                    );
                    GL.DrawArrays(PrimitiveType.TriangleStrip, call.Offset, call.Length);
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