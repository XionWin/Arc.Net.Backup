namespace OpenGL.Objects
{
    public class GLProgram: GLObject
    {
        public GLProgram(string vertexShaderPath, string fragmentShaderPath): base()
        {
            this.Id = ES20.glCreateProgram();

            using(var vertexShader = new GLShader(Def.ShaderType.VertexShader, vertexShaderPath).Load().Check())
            using(var fragmentShader = new GLShader(Def.ShaderType.FragmentShader, fragmentShaderPath).Load().Check())
            {
                this.AttachShader(vertexShader)
                .AttachShader(fragmentShader)
                .Link()
                .Check();
            }
        }

        protected override void Release() => ES20.glDeleteProgram(this.Id);
    }

    public static class GLProgramExtension {
        public static GLProgram AttachShader(this GLProgram program, GLShader shader) {
            ES20.glAttachShader(program.Id, shader.Id);
            return program;
        }
        public static GLProgram Link(this GLProgram program) {
            ES20.glLinkProgram(program.Id);
            program.CheckLink();
            return program;
        }

        public static GLProgram CheckLink(this GLProgram program) {
            if(ES20.glGetProgramLinkedStatus(program) is false)
            {
                throw new OpenGLESException(ES20.glGetProgramLinkedInformation(program));
            }
            return program;
        }

        public static uint GetUniformLocation(this GLProgram program, string name) =>
            OpenGL.ES20.glGetUniformLocation(program, name);

        public static void SetUniform1(this GLProgram program, string name, int v0) =>
            OpenGL.ES20.glUniform1i(program.GetUniformLocation(name), v0);
        public static void SetUniform2(this GLProgram program, string name, float v0, float v1) =>
            OpenGL.ES20.glUniform2f(program.GetUniformLocation(name), v0, v1);
    }
}
