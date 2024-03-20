namespace OpenGL.Objects
{
    public abstract class GLObject: IDisposable
    {
        public uint Id { get; init; }
        protected abstract void Release();

        public void Dispose() => this.Release();
    }

    static class GLObjectExtension {
        public static T Check<T>(this T obj)
        where T: GLObject
        {
            if(ES20.glGetError() != 0) throw new OpenGLESException();
            return obj;
        }
    }
}
