using Extension;
using TrueType;
using TrueType.Domain;
using TrueType.Mode;

namespace Arc.Core;

public static class ContextTextExtension
{
    public static void SetFontFace(this IContext context, string faceName) =>
        context.GetState().fontId = TTF.GetFont(faceName).Id;
    public static void SetFontSize(this IContext context, float fontSize) =>
        context.GetState().fontSize = fontSize;

    public static float Text(this IContext context, string text, float x, float y, TrueType.Mode.VerticalAlign verticalAlign = VerticalAlign.Top, TrueType.Mode.HorizontalAlign horizontalAlign = HorizontalAlign.Left, int spacing = 0)
    {
        var fontId = context.GetState().fontId;
        var fontSize = (int)context.GetState().fontSize;
        var fontBlur = (int)context.GetState().fontBlur;
        var font = TTF.GetFont(fontId);
        var glyphs = text.Select((x, p) => font.GetGlyph(x, fontSize, fontBlur, p > 0 ? text.ElementAt(p - 1) : null));


        var offsetY = font.GetVertAlign(verticalAlign, fontSize);

        var textWidth = glyphs.Sum(x => x.Size.Width);
        var offsetX = horizontalAlign switch {
            HorizontalAlign.Left => 0,
            HorizontalAlign.Center => (int)(-textWidth / 2f),
            HorizontalAlign.Right => (int)(-textWidth),
            _ => throw new Exception("Unexpected")
        };

        context.SaveState();
        context.GetState().FillPaint.Texture = context.FontTextureId;
        int postionX = 0;
        foreach (var glyph in glyphs)
        {
            var (width, height) = (glyph.Size.Width, glyph.Size.Height);
            var quad = font.GetTextureQuad(glyph);
            var glyphOffsetY = glyph.Offset.Y;
            context.Triangles(
                [
                    new Vertex(x + postionX + offsetX, y + offsetY + glyphOffsetY, quad.S0, quad.T0),
                    new Vertex(x + postionX + offsetX, y + offsetY + glyphOffsetY + height, quad.S0, quad.T1),
                    new Vertex(x + postionX + offsetX + width, y + offsetY + glyphOffsetY, quad.S1, quad.T0),
                    new Vertex(x + postionX + offsetX + width, y + offsetY + glyphOffsetY + height, quad.S1, quad.T1),
                ]
            );
            postionX += width + spacing;
        }
        context.RestoreState();
        
        return textWidth + spacing * (text.Length - 1);
    }

    internal static void UpdateFontTexture(this IContext context)
    {
        var canvas = TTF.CANVAS;
        var imageData = new ImageData(canvas.Size.Width, canvas.Size.Height, canvas.Pixels);
        context.UpdateTexture(context.FontTextureId, 0, 0, imageData, TextureType.Alpha);
    }

    public static int CreateFont(string name, string path) =>
        TTF.CreateFont(name, path).Id;

    public static TTFFont Getfont(string name) =>
        TTF.GetFont(name);

    public static TTFFont Getfont(int id) =>
        TTF.GetFont(id);
}