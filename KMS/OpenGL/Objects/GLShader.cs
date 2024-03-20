namespace OpenGL.Objects
{
    public class GLShader: GLObject
    {
        public string Source { get; init; }
        public Def.ShaderType ShaderType { get; init; }

        internal GLShader(Def.ShaderType shaderType, string path): base()
        {
            this.Id = ES20.glCreateShader(this.ShaderType = shaderType);
            using (var sr = new System.IO.StreamReader(path))
            {
                this.Source = sr.ReadToEnd();
            }
        }

        protected override void Release()
        {
            ES20.glDeleteShader(this.Id);
        }
    }

    static class GLShaderExtension {
        public static GLShader Load(this GLShader shader) {
            ES20.glShaderSource(shader.Id, 1, new []{shader.Source}, 0);
            ES20.glCompileShader(shader.Id);
            shader.CheckCompile();
            return shader;
        }

        public static GLShader CheckCompile(this GLShader shader) {
            if(ES20.glGetShaderCompiledStatus(shader) is false)
            {
                throw new OpenGLESException(ES20.glGetShaderCompiledInformation(shader));
            }
            return shader;
        }
    }
}
