using Extension;
using TrueType.Domain;
using TrueType.Mode;

namespace TrueType;
public static class TTF
{
    private static ICanvas? _CANVAS = null;
    public static ICanvas CANVAS => _CANVAS ?? throw new Exception("Unexpected");
    private static List<TTFFont> FONTS { get; } = new List<TTFFont>();

    public static void Init(Size size)
    {
        _CANVAS = new MonoCanvas(size);
    }

    public static TTFFont CreateFont(string name, string path) =>
        new TTFFont(FONTS.Count, name, path).With(x => FONTS.Add(x));

    public static TTFFont GetFont(int id) =>
        id < FONTS.Count ? FONTS[id] : throw new Exception("Unexpected");

    public static TTFFont GetFont(string name) =>
        FONTS.FirstOrDefault(x => x.Name == name) ?? throw new Exception("Unexpected");

    // public TTFGlyph GetGlyph(char character, int size, int blur, char? pervious)
    // {
    //     var index = new TTFIndex(character, size, blur);

    //     return this.Atlas.GetGlyph(index);
    // }
}
