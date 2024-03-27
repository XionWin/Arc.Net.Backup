using Extension;
using TrueType;
using TrueType.Domain;

namespace Arc.Core;

public static class ContextTextExtension
{
    public static void SetFontSize(this IContext context, float size)
    {

    }

    public static void SetFontFace(this IContext context, float faceName)
    {

    }
    
    public static void SetTextHorizontalAlign(this IContext context, HorizontalAlign align)
    {

    }
    
    public static void SetTextVerticalAlign(this IContext context, VerticalAlign align)
    {

    }

    public static void Text(this IContext context, float l, float t)
    {
        
    }

    public static int CreateFont(string name, string path) =>
        TTF.CreateFont(name, path).Id;

    public static TTFFont Getfont(string name) =>
        TTF.GetFont(name);

    public static TTFFont Getfont(int id) =>
        TTF.GetFont(id);
}