using System.Runtime.InteropServices;

namespace OpenGL.Graphics.ES20;

public static class GL
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



}