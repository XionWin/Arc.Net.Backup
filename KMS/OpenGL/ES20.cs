using System.Runtime.InteropServices;
using OpenGL.Def;
using OpenGL.Objects;

namespace OpenGL
{
    public class ES20
    {
        [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
        private static extern nint glGetString(Def.StringName stringName);
        public static string? GetString(Def.StringName stringName) => Marshal.PtrToStringAuto(glGetString(stringName));

        [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void glClearColor(float red, float green, float blue, float alpha);
        [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void glViewport(int x, int y, int width, int height);
        [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void glClear(Def.ClearBufferMask mask);

        [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint glGetError();

        [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint glCreateProgram ();

        [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint glCreateShader(Def.ShaderType shaderType);

        [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void glShaderSource (uint shader, int count, string[] source, int len);
        [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void glCompileShader (uint shader);
        [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void glAttachShader (uint programId, uint shaderId);

        [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void glLinkProgram (uint programId);

        [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void glDeleteShader (uint shaderId);
        [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
        private static extern void glGetShaderiv (uint shaderId, Def.ShaderParameter shaderParameter, ref int value);
        [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
        private static extern void glGetShaderInfoLog (uint shaderId, int bufSize, int[]? length, byte[] infoLog);
        public static bool glGetShaderCompiledStatus(GLShader shader)
        {
            var isCompiled = 0;
            glGetShaderiv(shader.Id, Def.ShaderParameter.CompileStatus, ref isCompiled);
            return isCompiled == 1;
        }

        public static string glGetShaderCompiledInformation(GLShader shader)
        {
            var len = 0;
            glGetShaderiv(shader.Id, Def.ShaderParameter.InfoLogLength, ref len);
            if(len > 1)
            {
                var bs = new byte[len];
                glGetShaderInfoLog(shader.Id, len, null, bs);
                return System.Text.Encoding.ASCII.GetString(bs);
            }
            return string.Empty;
        }
        
        [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void glDeleteProgram(uint programId);
        [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
        private static extern void glGetProgramiv (uint programId, Def.ProgramParameter programParameter, ref int value);
        [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
        private static extern void glGetProgramInfoLog (uint programId, int bufSize, int[]? length, byte[] infoLog);
        public static bool glGetProgramLinkedStatus(GLProgram program)
        {
            var isLinked = 0;
            glGetProgramiv(program.Id, Def.ProgramParameter.LinkStatus, ref isLinked);
            return isLinked == 1;
        }

        public static string glGetProgramLinkedInformation(GLProgram program)
        {
            var len = 0;
            glGetProgramiv(program.Id, Def.ProgramParameter.InfoLogLength, ref len);
            if(len > 1)
            {
                var bs = new byte[len];
                glGetProgramInfoLog(program.Id, len, null, bs);
                return System.Text.Encoding.ASCII.GetString(bs);
            }
            return string.Empty;
        }

        [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
        private static extern void glUseProgram(uint programId);

        public static void glUseProgram(GLProgram program) => glUseProgram(program.Id);

        [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
        private static extern void glVertexAttribPointer (uint index, int size, Def.VertexAttribPointerType type, bool normalized, uint stride, nint pointer);

        public unsafe static void glVertexAttribPointerF(uint index, int size, bool normalized, uint stride, float[] data)
        {
            fixed(float *ptr = data)
            {
                glVertexAttribPointer(index, size, Def.VertexAttribPointerType.Float, normalized, stride, (nint)ptr);
            }
        }
        public unsafe static void glVertexAttribPointerN(uint index, int size, bool normalized, uint stride, nint offset)
        {
            glVertexAttribPointer(index, size, Def.VertexAttribPointerType.Float, normalized, stride, (nint)offset);
        }


        [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
        private static extern int glGetAttribLocation (uint programId, [MarshalAs(UnmanagedType.LPStr)]string name);
        public static uint glGetAttribLocation (GLProgram program, string name)
        {
            return glGetAttribLocation(program.Id, name) is var r && r >= 0 ? (uint)r : throw new OpenGLESException();
        }

        [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
        private static extern int glGetUniformLocation (uint programId, [MarshalAs(UnmanagedType.LPStr)]string name);
        public static uint glGetUniformLocation (GLProgram program, string name)
        {
            return glGetUniformLocation(program.Id, name) is var r && r >= 0 ? (uint)r : throw new OpenGLESException();
        }


        [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void glEnableVertexAttribArray (uint index);
        
        [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void glDrawArrays(Def.BeginMode beginMode, int first, uint count);

        [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void glDrawElements (Def.BeginMode beginMode, int count, Def.DrawElementsType type, int indices);

        [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void glGenVertexArrays (uint n, out uint arrayId);
        public static uint GenVertexArray()
        {
            glGenVertexArrays(1, out var id);
            return id;
        }

        [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void glBindVertexArray (uint array);

        [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
        private static extern void glGenBuffers (uint n, [In, Out] uint[] buffer);
        public static uint GenBuffer ()
        {
            var buffer = new uint[1];
            glGenBuffers(1, buffer);
            return buffer[0];
        }
        public static void GenBuffers (uint n, out uint[] buffer)
        {
            buffer = new uint[n];
            glGenBuffers(n, buffer);
        }

        [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void glBindBuffer (Def.BufferTarget target, uint bufferId);

        [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void glBufferData (Def.BufferTarget target, int size, nint data, Def.BufferUsageHint bufferUsageHint);

        [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void glUniformMatrix4fv (uint location, uint count, [MarshalAs(UnmanagedType.Bool)]bool transpose, float[] value);

        [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
        unsafe public static extern void glUniformMatrix4fv (uint location, uint count, [MarshalAs(UnmanagedType.Bool)]bool transpose, float *value);
    
        [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void glEnable (EnableCap cap);

        [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void glBlendFunc(All sfactor, All dfactor);
        [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void glUniform1i(uint location, int v0);

        [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void glUniform2f(uint location, float v0, float v1);


        [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
         public static extern void glGenTextures (uint n, [In, Out] uint[] buffer);

         public static uint GenTexture()
         {
            var buffer = new uint[1];
            glGenTextures(1, buffer);
            return buffer[0];
         }

        [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void glDeleteTextures  (uint n, [In, Out] uint[] buffer);
         public static void DeleteTexture(uint textureId)
         {
            var buffer = new [] {textureId};
            glDeleteTextures(1, buffer);
         }

        [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void glActiveTexture(TextureUnit textureUnit);
          
        [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void glBindTexture (TextureTarget target, uint textureId);

        [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void glTexImage2D (TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int border, PixelFormat format, PixelType type, [In][Out] byte[] pixels);

        [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void glTexParameteri (TextureTarget target, TextureParameterName textureParameterName, int v);

        [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void glGenerateMipmap (GenerateMipmapTarget target);

        [DllImport(Lib.Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void glPixelStorei (PixelStoreParameter pixelStoreParameter, int v0);
    }
}
