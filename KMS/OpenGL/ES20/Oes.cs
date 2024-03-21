namespace OpenGL.Graphics.ES20;

public static partial class GL
{
    public static class Oes
    {
        public static int GenVertexArray()
        {
            FFI.glGenVertexArrays(1, out var id);
            return id;
        }

        public static void BindVertexArray(int array) =>
            FFI.glBindVertexArray(array);

        public static void DeleteVertexArray(int arrayId)
        {
            FFI.glDeleteVertexArrays(1, [arrayId]);
        }
    }
}