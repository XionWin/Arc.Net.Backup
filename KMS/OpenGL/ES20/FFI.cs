using System.Runtime.InteropServices;

namespace OpenGL.Graphics.ES20;

public static class FFI
{

    [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern uint glGetError();


    [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int glCreateProgram();
    [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glLinkProgram (int program);
    [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glDeleteProgram(int program);
    [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glUseProgram(int program);


    [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int glCreateShader(ShaderType shaderType);

    [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glShaderSource (int shader, int count, string[] source, int len);
    [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glCompileShader (int shader);
    [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glAttachShader (int program, int shaderId);


    [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern nint glGetString(StringName name);
    [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glClearColor(float r, float g, float b, float a);
    [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glViewport(int x, int y, int w, int h);
    [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glClear(ClearBufferMask mask);


    [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glUniform1i(int location, int v);
    [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glUniform1f(int location, float v);
    [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glUniform2f(int location, float v0, float v1);
    [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glUniform2fv(int location, int len, float[] vs);
    [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glUniform4f(int location, float v0, float v1, float v2, float v3);
    [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glUniform4fv(int location, int len, float[] vs);


    [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glUniformMatrix2fv(int location, int count, bool transpose, float[] value);
    
    

    [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int glGetAttribLocation (int program, [MarshalAs(UnmanagedType.LPStr)]string name);

    


    [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glEnableVertexAttribArray (int index);

    [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glVertexAttribPointer(int index, int size, VertexAttribPointerType type, bool normalized, int stride, nint pointer);

    [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glGetShaderInfoLog (int shaderId, int bufSize, int[]? length, byte[] infoLog);

    
    [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glGetShaderiv (int shaderId, ShaderParameter shaderParameter, out int value);

    [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glDetachShader(int program, int shader);

    [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glDeleteShader(int shader);


    [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glGetProgramiv(int program, GetProgramParameterName programParameter, out int value);

    [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void glGetActiveUniform(int program, int index, int bufSize, out int length, out int size, out ActiveUniformType type, byte[] name);

    [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int glGetUniformLocation (int program, [MarshalAs(UnmanagedType.LPStr)]string name);












    // public static bool glGetShaderCompiledStatus(int id)
    // {
    //     glGetShaderiv(id, ShaderParameter.CompileStatus, out var isCompiled);
    //     return isCompiled == 1;
    // }

    // public static string glGetShaderCompiledInformation(int shaderId)
    // {
    //     glGetShaderiv(shaderId, ShaderParameter.InfoLogLength, out var len);
    //     if(len > 1)
    //     {
    //         var bs = new byte[len];
    //         glGetShaderInfoLog(shaderId, len, null, bs);
    //         return System.Text.Encoding.ASCII.GetString(bs);
    //     }
    //     return string.Empty;
    // }
    
    

    // [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
    // private static extern void glGetProgramInfoLog (int program, int bufSize, int[]? length, byte[] infoLog);
    // public static bool glGetProgramLinkedStatus(int program)
    // {
    //     var isLinked = 0;
    //     glGetProgramiv(program, ProgramParameter.LinkStatus, ref isLinked);
    //     return isLinked == 1;
    // }

    // public static string glGetProgramLinkedInformation(int program)
    // {
    //     var len = 0;
    //     glGetProgramiv(program, ProgramParameter.InfoLogLength, ref len);
    //     if(len > 1)
    //     {
    //         var bs = new byte[len];
    //         glGetProgramInfoLog(program, len, null, bs);
    //         return System.Text.Encoding.ASCII.GetString(bs);
    //     }
    //     return string.Empty;
    // }


    // [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
    // private static extern void glVertexAttribPointer (uint index, int size, VertexAttribPointerType type, bool normalized, uint stride, nint pointer);

    // public unsafe static void glVertexAttribPointerF(uint index, int size, bool normalized, uint stride, float[] data)
    // {
    //     fixed(float *ptr = data)
    //     {
    //         glVertexAttribPointer(index, size, VertexAttribPointerType.Float, normalized, stride, (nint)ptr);
    //     }
    // }
    // public unsafe static void glVertexAttribPointerN(uint index, int size, bool normalized, uint stride, nint offset)
    // {
    //     glVertexAttribPointer(index, size, VertexAttribPointerType.Float, normalized, stride, (nint)offset);
    // }




    // [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
    // public static extern void glEnableVertexAttribArray (uint index);
    
    // [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
    // public static extern void glDrawArrays(BeginMode beginMode, int first, uint count);

    // [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
    // public static extern void glDrawElements (BeginMode beginMode, int count, DrawElementsType type, int indices);

    // [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
    // public static extern void glGenVertexArrays (uint n, out uint arrayId);
    // public static uint GenVertexArray()
    // {
    //     glGenVertexArrays(1, out var id);
    //     return id;
    // }

    // [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
    // public static extern void glBindVertexArray (uint array);

    // [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
    // private static extern void glGenBuffers (uint n, [In, Out] uint[] buffer);
    // public static uint GenBuffer ()
    // {
    //     var buffer = new uint[1];
    //     glGenBuffers(1, buffer);
    //     return buffer[0];
    // }
    // public static void GenBuffers (uint n, out uint[] buffer)
    // {
    //     buffer = new uint[n];
    //     glGenBuffers(n, buffer);
    // }

    // [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
    // public static extern void glBindBuffer (BufferTarget target, uint bufferId);

    // [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
    // public static extern void glBufferData (BufferTarget target, int size, nint data, BufferUsageHint bufferUsageHint);

    // [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
    // public static extern void glUniformMatrix4fv (uint location, uint count, [MarshalAs(UnmanagedType.Bool)]bool transpose, float[] value);

    // [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
    // unsafe public static extern void glUniformMatrix4fv (uint location, uint count, [MarshalAs(UnmanagedType.Bool)]bool transpose, float *value);

    // [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
    // public static extern void glEnable (EnableCap cap);

    // [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
    // public static extern void glBlendFunc(BlendingFactorSrc src, BlendingFactorDest dfactor);
  




    // [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
    //     public static extern void glGenTextures (uint n, [In, Out] uint[] buffer);

    //     public static uint GenTexture()
    //     {
    //     var buffer = new uint[1];
    //     glGenTextures(1, buffer);
    //     return buffer[0];
    //     }

    // [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
    // public static extern void glDeleteTextures  (uint n, [In, Out] uint[] buffer);
    //     public static void DeleteTexture(uint textureId)
    //     {
    //     var buffer = new [] {textureId};
    //     glDeleteTextures(1, buffer);
    //     }

    // [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
    // public static extern void glActiveTexture(TextureUnit textureUnit);
        
    // [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
    // public static extern void glBindTexture (TextureTarget target, uint textureId);

    // [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
    // public static extern void glTexImage2D (TextureTarget target, int level, TextureComponentCount internalformat, int width, int height, int border, PixelFormat format, PixelType type, [In][Out] byte[] pixels);

    // [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
    // public static extern void glTexParameteri (TextureTarget target, TextureParameterName textureParameterName, int v);

    // [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
    // public static extern void glPixelStorei (PixelStoreParameter pixelStoreParameter, int v0);
}
