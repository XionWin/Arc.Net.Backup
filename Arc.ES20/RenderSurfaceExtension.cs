#if KMS_MODE
using OpenGL.Graphics.ES20;
#else
using Arc.Core;
using Extension;
using OpenTK.Graphics.ES20;
#endif

namespace Arc.ES20;

public static class RenderSurfaceExtension
{
    public static Size GetMaxTextureSize(this Renderer renderer)
    {
        var maxTextureSize = GL.GetInteger(GetPName.MaxTextureSize);
        return new Size(maxTextureSize, maxTextureSize);
    }

    public static void RenderFrame(this Renderer renderer)
    {
        GL.Oes.BindVertexArray(renderer.VAO);
        // bind vbo and set data for vbo
        GL.BindBuffer(BufferTarget.ArrayBuffer, renderer.VBO);
        var vertices = renderer.Data.Vertices.GetRaw();
        GL.BufferData(BufferTarget.ArrayBuffer, vertices.Length * sizeof(float), vertices, BufferUsageHint.StaticDraw);
        renderer.Shader.EnableAttribs(Vertex2.AttribLocations);

        var fragUniforms = renderer.Data.FragUniforms;
        foreach (var call in renderer.Data.Calls)
        {
            if(call.Type is CallType.Stroke)
            {
                GL.Enable(EnableCap.Blend);
                GL.BlendFunc(BlendingFactorSrc.SrcAlpha, BlendingFactorDest.OneMinusSrcAlpha);

                renderer.Shader.Uniform4(
                    "aFrag",
                    fragUniforms[call.UniformOffset].Values
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
                    
                    renderer.Shader.Uniform4(
                        "aFrag",
                        fragUniforms[renderFillCall.UniformOffset].Values
                    );
                    GL.StencilOpSeparate(StencilFace.Front, StencilOp.Keep, StencilOp.Keep, StencilOp.IncrWrap);
                    GL.StencilOpSeparate(StencilFace.Back, StencilOp.Keep, StencilOp.Keep, StencilOp.DecrWrap);
                    GL.Disable(EnableCap.CullFace);
                    GL.DrawArrays(PrimitiveType.TriangleFan, renderFillCall.Offset, renderFillCall.Length);
                    GL.Enable(EnableCap.CullFace);
                    GL.ColorMask(true, true, true, true);

                    var fillFragUniform = fragUniforms[renderFillCall.TriangleUniformOffset];
                    renderer.Shader.Uniform4(
                        "aFrag",
                        fillFragUniform.Values
                    );
                    
                    GL.ActiveTexture(TextureUnit.Texture0);
                    renderer.Shader.Uniform1("aTexture", 0);
                    if(fillFragUniform.Type is Core.FragUniformType.FillTexture)
                    {
                        GL.BindTexture(TextureTarget.Texture2D, call.Texture);
                    }
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

                var fillFragUniform = fragUniforms[call.UniformOffset];
                renderer.Shader.Uniform4(
                    "aFrag",
                    fillFragUniform.Values
                );

                GL.ActiveTexture(TextureUnit.Texture0);
                renderer.Shader.Uniform1("aTexture", 0);
                if(fillFragUniform.Type is Core.FragUniformType.FillTexture)
                {
                    GL.BindTexture(TextureTarget.Texture2D, call.Texture);
                }

                GL.DrawArrays(PrimitiveType.TriangleFan, call.Offset, call.Length);
            }
            else if(call.Type is CallType.Rectangle)
            {
                renderer.Shader.Uniform4(
                    "aFrag",
                    fragUniforms[call.UniformOffset].Values
                );
                GL.DrawArrays(PrimitiveType.TriangleStrip, call.Offset, call.Length);
            }
        }
    }
}