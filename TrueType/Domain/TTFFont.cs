using Extension;
using TrueType.Extension;
using TrueType.Mode;

namespace TrueType.Domain;
public class TTFFont
{
    public int Id { get; init; }
    public string Name { get; init; }
    public string Path { get; init; }
    private TTFAtlas Atlas { get; init; }

    internal float FontMetricAscender { get; init; }
    internal float FontMetricDscender { get; init; }

    internal TTFFont(int id, string name, string path)
    {
        this.Id = id;
        Name = name;
        Path = path;
        var raw = new TTFRaw(name, File.ReadAllBytes(path));
        Atlas = new TTFAtlas(raw, TTF.CANVAS);

        var vMetrics = this.Atlas.Raw.GetGlyphVMetrics();
        var fontHeight = vMetrics.ascent - vMetrics.descent;
        this.FontMetricAscender = (float)vMetrics.ascent / fontHeight;
        this.FontMetricDscender = (float)vMetrics.descent / fontHeight;
    }

    public TTFGlyph GetGlyph(char character, int size, int blur, char? pervious)
    {
        var index = new TTFIndex(character, size, blur);

        return this.Atlas.GetGlyph(index);
    }

    public TTFTextureQuad GetTextureQuad(TTFGlyph glyph)
    {
        return glyph.GetTextureQuad(TTF.CANVAS);
    }

    public int GetVertAlign(VerticalAlign verticalAlign, int size)
    {

        if (verticalAlign.BitwiseContains(VerticalAlign.Top))
        {
            return (int)(this.FontMetricAscender * (float)size);
        }
        else if (verticalAlign.BitwiseContains(VerticalAlign.Middle))
        {
            return (int)((this.FontMetricAscender + this.FontMetricDscender) / 2.0f * (float)size);
        }
        else if (verticalAlign.BitwiseContains(VerticalAlign.Baseline))
        {
            return 0;
        }
        else if (verticalAlign.BitwiseContains(VerticalAlign.Bottom))
        {
            return (int)(this.FontMetricDscender * (float)size);
        }
        else
        {
            throw new Exception("Unexpected");
        }
    }

    internal void Clear()
    {
        this.Atlas.Clear();
    }
}
