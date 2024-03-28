using TrueType.Domain;

namespace TrueType.Extension;
internal static class TTFGlyphExtension
{
    internal  static TTFQuad GetQuad(this TTFGlyph glyph, ICanvas canvas)
    {
        var x0 = glyph.Bitmap.TexRect.X;
        var y0 = glyph.Bitmap.TexRect.Y;
        var x1 = glyph.Bitmap.TexRect.X + glyph.Bitmap.TexRect.Width;
        var y1 = glyph.Bitmap.TexRect.Y + glyph.Bitmap.TexRect.Height;
        
        var s0 = (float)x0 / canvas.Size.Width;
        var t0 = (float)y0 / canvas.Size.Height;
        var s1 = (float)x1 / canvas.Size.Width;
        var t1 = (float)y1 / canvas.Size.Height;

        return new TTFQuad(){
            X0 = x0,
            Y0 = y0,
            S0 = s0,
            T0 = t0,
            X1 = x1,
            Y1 = y1,
            S1 = s1,
            T1 = t1,
        };
    }
}
