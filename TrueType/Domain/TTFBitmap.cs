using TrueType.Mode;

namespace TrueType.Domain
{
    public class TTFBitmap
    {
        public char Character { get; set; }
        public int Size { get; set; }
        public Rectangle TexRect { get; init; }

        public TTFBitmap(char character, int fontSize, Rectangle texRect)
        {
            Character = character;
            Size = fontSize;
            TexRect = texRect;
        }
    }
}
