using TrueType.Extension;

namespace TrueType.Domain;
public class TTFFont
{
    public int Id { get; init; }
    public string Name { get; init; }
    public string Path { get; init; }
    private TTFAtlas Atlas { get; init; }

    internal TTFFont(int id, string name, string path)
    {
        this.Id = id;
        Name = name;
        Path = path;
        var raw = new TTFRaw(name, File.ReadAllBytes(path));
        Atlas = new TTFAtlas(raw, TTF.CANVAS);

        var lineGap = 0;
        var vMetrics = this.Atlas.Raw.GetFontVMetrics();
        var fontHeight = vMetrics.ascent - vMetrics.descent;
        var fontascender = (float)vMetrics.ascent / fontHeight;
        var fontdescender = (float)vMetrics.descent / fontHeight;
        var fontLineHeight = (float)(fontHeight + lineGap) / fontHeight;

    }

    public TTFGlyph GetGlyph(char character, int size, int blur, char? pervious)
    {
        var index = new TTFIndex(character, size, blur);

        return this.Atlas.GetGlyph(index);
    }
}
