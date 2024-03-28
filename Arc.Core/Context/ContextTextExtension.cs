using Extension;
using TrueType;
using TrueType.Domain;

namespace Arc.Core;

public static class ContextTextExtension
{
    public static void SetFontSize(this IContext context, float fontSize) =>
        context.GetState().fontSize = fontSize;

    public static void SetFontFace(this IContext context, string fontName)
    {
        context.GetState().fontId = TTF.GetFont(fontName).Id;
    }
    
    public static void SetTextHorizontalAlign(this IContext context, HorizontalAlign align)
    {

    }
    
    public static void SetTextVerticalAlign(this IContext context, VerticalAlign align)
    {

    }

    public static void Text(this IContext context, string text, float x, float y)
    {
        var fontId = context.GetState().fontId;
        var fontSize = (int)context.GetState().fontSize;
        var fontBlur = (int)context.GetState().fontBlur;
        var font = TTF.GetFont(fontId);
        var glyphs = text.Select((x, p) => font.GetGlyph(x, fontSize, fontBlur, p > 0 ? text.ElementAt(p - 1) : null));


        context.SaveState();
        context.GetState().FillPaint.Texture = context.FontTexture;
        Console.WriteLine($"FontId: {context.FontTexture}");
        var dx = x;
        foreach (var glyph in glyphs)
        {
            var (width, height) = (glyph.Size.Width, glyph.Size.Height);
            var quad = font.GetQuad(glyph);

            context.Triangles(
                [
                    new Vertex(dx, y, quad.S0, quad.T0),
                    new Vertex(dx, y + height, quad.S0, quad.T1),
                    new Vertex(dx + width, y, quad.S1, quad.T0),
                    new Vertex(dx + width, y + height, quad.S1, quad.T1),
                ]
            );

            dx += width;
            
        }
        context.RestoreState();
        context.UpdateFontTexture();
    }

    public static int CreateFont(string name, string path) =>
        TTF.CreateFont(name, path).Id;

    public static TTFFont Getfont(string name) =>
        TTF.GetFont(name);

    public static TTFFont Getfont(int id) =>
        TTF.GetFont(id);
}