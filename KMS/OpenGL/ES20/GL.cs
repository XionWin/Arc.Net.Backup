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
    public static void UseProgram(uint id) =>
        FFI.glUseProgram(id);


    public static int CreateShader(ShaderType type) =>
        FFI.glCreateShader(type);
    
    public static void ShaderSource(int shader, string source) =>
        FFI.glShaderSource(shader, 1, [source], source.Length);
    
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

    
    
}