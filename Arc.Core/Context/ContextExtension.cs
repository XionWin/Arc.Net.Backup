using Extension;

namespace Arc.Core;

public static class ContextExtension
{
    public static void AddRectangle(this IContext context, float l, float t, float w, float h)
    {
        context.AddCommand(new Command(CommandType.MoveTo, l, t));
        context.AddCommand(new Command(CommandType.LineTo, l + w, t));
        context.AddCommand(new Command(CommandType.LineTo, l + w, t + h));
        context.AddCommand(new Command(CommandType.LineTo, l, t + h));
        context.AddCommand(new Command(CommandType.Close));
    }

    public static void AddRoundRectangle(this IContext context, float l, float t, float w, float h, float r)
    {
        context.AddCommand(new Command(CommandType.MoveTo, l + r, t));
        context.AddCommand(new Command(CommandType.LineTo, l + w - r, t));
        context.AddCommand(new Command(CommandType.BezierTo, 
        l + w - r + r * KAPPA90, t,
        l + w, t + r - r * KAPPA90,
        l + w, t + r));
        context.AddCommand(new Command(CommandType.LineTo, l + w, t + h - r));
        context.AddCommand(new Command(CommandType.BezierTo,
        l + w, t + h - r + r * KAPPA90,
        l + w - r + r * KAPPA90, t + h,
        l + w - r, t + h));
        context.AddCommand(new Command(CommandType.LineTo, l + r, t + h));
        context.AddCommand(new Command(CommandType.BezierTo,
        l + r - r * KAPPA90, t + h,
        l, t + h - r + r *KAPPA90,
        l, t + h - r));
        context.AddCommand(new Command(CommandType.LineTo, l, t + r));
        context.AddCommand(new Command(CommandType.BezierTo,
        l, t + r - r * KAPPA90,
        l + r - r * KAPPA90, t,
        l + r, t));
        context.AddCommand(new Command(CommandType.Close));
    }

    const float KAPPA90 = 0.5522847493f;
    public static void AddEllipse(this IContext context, float cx, float cy, float rx, float ry)
    {
        context.AddCommand(new Command(CommandType.MoveTo, cx + rx, cy));
        context.AddCommand(new Command(CommandType.BezierTo,
                                    cx + rx, cy + ry * KAPPA90,
                                    cx + rx * KAPPA90, cy + ry,
                                    cx, cy + ry));
        context.AddCommand(new Command(CommandType.BezierTo,
                                    cx - rx * KAPPA90, cy + ry,
                                    cx - rx, cy + ry * KAPPA90,
                                    cx - rx, cy));
        context.AddCommand(new Command(CommandType.BezierTo,
                                    cx - rx, cy - ry * KAPPA90,
                                    cx - rx * KAPPA90, cy - ry,
                                    cx, cy - ry));
        context.AddCommand(new Command(CommandType.BezierTo,
                                    cx + rx * KAPPA90, cy - ry,
                                    cx + rx, cy - ry * KAPPA90,
                                    cx + rx, cy));
        context.AddCommand(new Command(CommandType.Close));
    }

    public static void ArcTo(this IContext context, float cx, float cy, float r, float a0, float a1, Winding winding)
    {
        var firstCommandType = context.LastPath.LastEditPoint is Point ? CommandType.LineTo : CommandType.MoveTo;
        // Clamp angles
        var da = a1 - a0;
        if (winding is Winding.CW)
        {
            if (Math.Abs(da) >= Math.PI * 2)
            {
                da = (float)Math.PI * 2;
            }
            else
            {
                while (da < 0.0f)
                {
                    da += (float)Math.PI * 2;
                }
            }
        }
        else
        {
            if (Math.Abs(da) >= Math.PI * 2)
            {
                da = -(float)Math.PI * 2;
            }
            else
            {
                while (da > 0.0f)
                {
                    da -= (float)Math.PI * 2;
                }
            }
        }

        // Split arc into max 90 degree segments.
        var ndivs = Math.Max(1, Math.Min((int)(Math.Abs(da) / (Math.PI * 0.5f) + 0.5f), 5));
        var hda = (da / (float)ndivs) / 2.0f;
        var kappa = Math.Abs(4.0f / 3.0f * (1.0f - Math.Cos(hda)) / Math.Sin(hda));

        if (winding is Winding.CCW)
        {
            kappa = -kappa;
        }
        
        var px =0d;
        var py =0d;
        var ptanx =0d;
        var ptany =0d;
        for (int i = 0; i <= ndivs; i++)
        {
            var a = a0 + da * (i / (float)ndivs);
            var dx = Math.Cos(a);
            var dy = Math.Sin(a);
            var x = cx + dx * r;
            var y = cy + dy * r;
            var tanx = -dy * r * kappa;
            var tany = dx * r * kappa;
            var command = i switch
            {
                0 => new Command(firstCommandType, (float)x, (float)y),
                _ => new Command(CommandType.BezierTo,
                    (float)(px + ptanx), (float)(py + ptany),
                    (float)(x - tanx), (float)(y - tany),
                    (float)x, (float)y)
            };

            context.AddCommand(command);
            px = x;
            py = y;
            ptanx = tanx;
            ptany = tany;
        }
    }
}