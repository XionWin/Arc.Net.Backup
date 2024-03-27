using TrueType.Extension;
using TrueType.Mode;

namespace TrueType.Domain
{
    public class TTFAtlas: Dictionary<TTFIndex, TTFGlyph>
    {
        internal TTFRaw Raw { get; init; }
        public ICanvas Canvas { get; init; }
        internal TTFAtlas(TTFRaw raw, ICanvas canvas) {
            this.Raw = raw;
            this.Canvas = canvas;
        }

        public TTFGlyph GetGlyph(TTFIndex ttfIndex)
        {
            if (this.ContainsKey(ttfIndex))
            {
                return this[ttfIndex];
            }
            var raw = this.Raw;
            var character = ttfIndex.Character;
            var size = ttfIndex.Size;
            var blur = ttfIndex.Blur;


            // Find code point and size.
            var h = TTFExtension.HashInt(character) & (Consts.FONS_HASH_LUT_SIZE - 1);

            if (size < 2)
                throw new Exception("Unsupported size");
            if (blur > 20)
                blur = 20;
            var pad = blur + 2;

            var scaleValue = raw.GetPixelHeightScale(size);
            var scale = new PointF(scaleValue, scaleValue);

            var index = raw.GetGlyphIndex((int)character);
            var vector = raw.GetVector(character);


            var (advanceWidth, leftSideBearing) = raw.GetGlyphHMetrics(index);
            var (x0, y0, x1, y1) = vector.GetGlyphBox(size, scale);

            var renderSize = new Size(x1 - x0, y1 - y0);
            var glyphSize = new Size(renderSize.Width + pad * 2, renderSize.Height + pad * 2);

            // Location-related
            //AtlasAddRect(Atlas.Instance, this._raw, glyphSize);

            var xadv = (short)(scaleValue * advanceWidth * 10.0f);
            var offset = new Point(x0, y0);


            var bitmap = vector.Rasterize(this.Canvas, ttfIndex, renderSize, scale, offset);

            var glyph = new TTFGlyph()
            {
                Index = index,
                Scale = scaleValue,
                AdvanceWidth = advanceWidth,
                LeftSideBearing = leftSideBearing,
                XAdvanceWidth = xadv,
                Size = renderSize,
                Offset = offset,
                Bitmap = bitmap,
            };

            this.Add(ttfIndex, glyph);
            return glyph;
        }
        
    }


}
