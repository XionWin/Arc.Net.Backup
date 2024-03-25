using TrueType.Extension;
using TrueType.Mode;

namespace TrueType.Domain
{
    public class TTF : IDisposable
    {
        public string Name { get; init; }
        public string Path { get; init; }
        private TTFAtlas Atlas { get; init; }
        private TTFRaw Raw { get; init; }

        public TTF(string name, string path, ICanvas canvas)
        {
            Name = name;
            Path = path;
            Atlas = new TTFAtlas(canvas);
            this.Raw = new TTFRaw(name, File.ReadAllBytes(path));

            var lineGap = 0;
            var vMetrics = this.Raw.GetFontVMetrics();
            var fontHeight = vMetrics.ascent - vMetrics.descent;
            var fontascender = (float)vMetrics.ascent / fontHeight;
            var fontdescender = (float)vMetrics.descent / fontHeight;
            var fontLineHeight = (float)(fontHeight + lineGap) / fontHeight;

        }

        public TTFGlyph GetGlyph(char character, int size, int blur, char? pervious)
        {
            var index = new TTFIndex(character, size, blur);

            return this.Atlas.GetGlyph(index, this.Raw);
        }

        public void Dispose()
        {

        }
    }
}