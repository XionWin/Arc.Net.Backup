using Extension;

namespace Arc.Core;

public static class ContextExtension
{
    public static void AddRectangle(this Context context, float l, float t, float w, float h)
    {
        context.LastEditPath.AddRectangle(l, t, w, h);
    }

    public static void AddEllipse(this Context context, float cx, float cy, float rx, float ry)
    {
        context.LastEditPath.AddEllipse(cx, cy, rx, ry);
    }
    
    public static void ArcTo(this Context context, float cx, float cy, float r, float a0, float a1, Winding winding)
    {
        context.LastEditPath.ArcTo(cx, cy, r, a0, a1, winding);
    }
}