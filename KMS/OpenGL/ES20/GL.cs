using System.Runtime.InteropServices;

namespace OpenGL.Graphics.ES20;

public static partial class GL
{
    public static uint GetError() =>
        FFI.glGetError();

    public static int CreateProgram() =>
        FFI.glCreateProgram();

    public static void LinkProgram (int id) =>
        FFI.glLinkProgram(id);
    
    public static void DeleteProgram(int id) =>
        FFI.glDeleteProgram(id);
    public static void UseProgram(int id) =>
        FFI.glUseProgram(id);


    public static int CreateShader(ShaderType type) =>
        FFI.glCreateShader(type);
    
    public static void ShaderSource(int shader, string source) =>
        FFI.glShaderSource(shader, 1, [source], 0);
    
    public static void CompileShader (int shader) =>
        FFI.glCompileShader(shader);
    
    public static void AttachShader(int programId, int shaderId) =>
        FFI.glAttachShader(programId, shaderId);

    public static string? GetString(StringName name) =>
        Marshal.PtrToStringAuto(FFI.glGetString(name));

    public static void Viewport(int x, int y, int w, int h) =>
        FFI.glViewport(x, y, w, h);

    public static void Clear(ClearBufferMask mask) =>
        FFI.glClear(mask);
    
    public static void ClearColor(float r, float g, float b, float a) =>
        FFI.glClearColor(r, g, b, a);
    public static void ClearColor(System.Drawing.Color color) =>
        ClearColor(color.R / 255f, color.G / 255f, color.B / 255f, color.A / 255f);


    public static void Uniform1(int location, int v) =>
        FFI.glUniform1i(location, v);

    public static void Uniform1(int location, float v) =>
        FFI.glUniform1f(location, v);

    public static void Uniform2(int location, float v0, float v1) =>
        FFI.glUniform2f(location, v0, v1);

    public static void Uniform2(int location, int len, float[] vs) =>
        FFI.glUniform2fv(location, len, vs);

    public static void Uniform4(int location, float v0, float v1, float v2, float v3) =>
        FFI.glUniform4f(location, v0, v1, v2, v3);

    public static void Uniform4(int location, int len, float[] vs) =>
        FFI.glUniform4fv(location, len, vs);

    public static void UniformMatrix2(int location, int count, bool transpose, float[] value) =>
        FFI.glUniformMatrix2fv(location, count, transpose, value);

    public static int GetAttribLocation(int programId, string name) =>
        FFI.glGetAttribLocation(programId, name);

    public static void EnableVertexAttribArray(int index) =>
        FFI.glEnableVertexAttribArray(index);

    public static void VertexAttribPointer(int index, int size, VertexAttribPointerType type, bool normalized, int stride, int offset) =>
        FFI.glVertexAttribPointer(index, size, type, normalized, stride, offset);
    

    public static void GetShader(int shaderId, ShaderParameter shaderParameter, out int value) =>
        FFI.glGetShaderiv(shaderId, shaderParameter, out value);
    
     public static string GetShaderInfoLog(int shaderId)
    {
        GetShader(shaderId, ShaderParameter.InfoLogLength, out var len);
        if (len == 0)
        {
            return string.Empty;
        }
        else
        {
            var bs = new byte[len];
            FFI.glGetShaderInfoLog(shaderId, len, null, bs);
            return System.Text.Encoding.ASCII.GetString(bs);
        }
    }
    
    public static void DetachShader(int program, int shader) =>
        FFI.glDetachShader(program, shader);

    public static void DeleteShader(int shader) =>
        FFI.glDeleteShader(shader);

    public static void GetProgram(int program, GetProgramParameterName programParameter, out int value) =>
        FFI.glGetProgramiv(program, programParameter, out value);


    public static string GetActiveUniform(int program, int uniformIndex, out int size, out ActiveUniformType type)
    {
        GetProgram(program, GetProgramParameterName.ActiveUniformMaxLength, out var len);
        return GetActiveUniform(program, uniformIndex, (len == 0) ? 1 : len, out len, out size, out type);
    }


    public static string GetActiveUniform(int shaderId)
    {
        GetShader(shaderId, ShaderParameter.InfoLogLength, out var len);
        if (len == 0)
        {
            return string.Empty;
        }
        else
        {
            var bs = new byte[len];
            FFI.glGetShaderInfoLog(shaderId, len, null, bs);
            return System.Text.Encoding.ASCII.GetString(bs);
        }
    }

    public static string GetActiveUniform(int program, int index, int bufSize, out int length, out int size, out ActiveUniformType type)
    {
        var bs = new byte[bufSize];
        FFI.glGetActiveUniform(program, index, bufSize, out length, out size, out type, bs);
        return System.Text.Encoding.ASCII.GetString(bs.Take(length).ToArray());
    }

    public static int GetUniformLocation(int program, [MarshalAs(UnmanagedType.LPStr)]string name) =>
        FFI.glGetUniformLocation(program, name);

    public static int GenTexture()
    {
        FFI.glGenTextures(1, out var textureId);
        return textureId;
    }

    public static void ActiveTexture(TextureUnit textureUnit) =>
        FFI.glActiveTexture(textureUnit);

    public static void BindTexture(TextureTarget target, int textureId) =>
        FFI.glBindTexture(target, textureId);

    public static void TexImage2D(TextureTarget2d target, int level, TextureComponentCount internalformat, int width, int height, int border, PixelFormat format, PixelType type, [In][Out] byte[] pixels) =>
        FFI.glTexImage2D(target, level, internalformat, width, height, border, format, type, pixels);

    public static void TexSubImage2D(TextureTarget2d target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, byte[] pixels) =>
        FFI.glTexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels);

    public static void TexParameter(TextureTarget target, TextureParameterName parameterName, int v) =>
        FFI.glTexParameteri(target, parameterName, v);

    public static void GenerateMipmap(TextureTarget target) =>
        FFI.glGenerateMipmap(target);

    public static void PixelStore(PixelStoreParameter parameter, int v) =>
        FFI.glPixelStorei(parameter, v);

    public static int GenBuffer()
    {
        FFI.glGenBuffers(1, out var bufferId);
        return bufferId;
    }

    public static void BindBuffer(BufferTarget target, int bufferId) =>
        FFI.glBindBuffer(target, bufferId);

    public static void DeleteBuffer(int bufferId)
    {
        FFI.glDeleteBuffers(1, [bufferId]);
    }

    public static void BufferData(BufferTarget target, int size, float[] data, BufferUsageHint bufferUsageHint)
    {
        unsafe{
            fixed(float * ptr = data)
            {
                FFI.glBufferData(target, size, (nint)ptr, bufferUsageHint);
            }
        }
    }

    public static void Enable(EnableCap cap) =>
        FFI.glEnable(cap);
    
    public static void Disable(EnableCap cap) =>
        FFI.glDisable(cap);

    public static void BlendFunc(BlendingFactorSrc src, BlendingFactorDest dest) =>
        FFI.glBlendFunc(src, dest);

    public static void DrawArrays(PrimitiveType primitiveType, int index, int len) =>
        FFI.glDrawArrays(primitiveType, index, len);

    public static void StencilMask(int mask) =>
        FFI.glStencilMask((uint)mask);

    public static void StencilFunc(StencilFunction func, int @ref, int mask) =>
        FFI.glStencilFunc(func, @ref, (uint)mask);

    public static void ColorMask(bool r, bool g, bool b, bool a) =>
        FFI.glColorMask(r, g, b, a);

    public static void StencilOpSeparate(StencilFace face, StencilOp sfail, StencilOp dpfail, StencilOp dppass) =>
        FFI.glStencilOpSeparate(face, sfail, dpfail, dppass);

    public static void StencilOp(StencilOp fail, StencilOp zfail, StencilOp zpass) =>
        FFI.glStencilOp(fail, zfail, zpass);

    public static int GetInteger(GetPName pName)
    {
        FFI.glGetIntegerv(pName, out var value);
        return value;
    }
}