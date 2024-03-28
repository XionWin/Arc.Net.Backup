using TrueType.Mode;

namespace TrueType.Domain;

public interface ICanvas
{
    public Size Size { get; }
    public byte[] Pixels { get; }
    internal TTFBitmap LocateCharacter(TTFIndex index, byte[] data, Size renderSize, int lineHeight);
    internal void Clear();
}
