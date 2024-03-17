namespace Arc.Core;

public static class CommonCalculator
{
    internal static (int bevelCount, int leftCount) CalculateJoins(this IEnumerable<Point> points, State state, bool isClosed)
    {
        (int bevelCount, int leftCount) result = (0, 0);
        foreach (var point in points)
        {
            // Clear flags, but keep the corner.
            point.Flags = point.Flags is PointFlags.None ? PointFlags.None : PointFlags.Corner;

            if(point.Previous is Point previousPoint)
            {
                // Keep track of left turns.
                if(point.SetLeftFlag(previousPoint))
                {
                    result.leftCount++;
                }

                // Calculate if we should use bevel or miter for inner join.
                if(previousPoint.Len is float previousLen && point.Len is float len && point.Dmr2 is float dmr2)
                {
                    var strokeWidth = state.StrokeWidth;
                    var miterLimit = state.MiterLimit;
                    var lineJoin = state.LineJoin;
                    var iw = 0.0f;
                    if (strokeWidth > 0.0f)
                        iw = 1.0f / strokeWidth;
                    var limit = Math.Max(1.01f, Math.Min(previousLen, len) * iw);
                    if ((dmr2 * limit * limit) < 1.0f)
                        point.Flags |= PointFlags.InnerBevel;

                    // Check to see if the corner needs to be beveled.
                    if (point.Flags.Contains(PointFlags.Corner))
                    {
                        if ((dmr2 * miterLimit * miterLimit) < 1.0f ||
                            lineJoin == LineJoin.Bevel ||
                            lineJoin == LineJoin.Round)
                        {
                            point.Flags |= PointFlags.Bevel;
                        }
                    }
                }
            }

            if(isClosed is false)
            {
                var last = points.Last();
                var first = points.First();
                var lastPrevious = points.Skip(points.Count() - 2).First();

                var (dx, dy, _) = last.GetDXYL(first);
                if(first.SetLeftFlag(last, dx0: dx, dy0: dy))
                {
                    result.leftCount++;
                }
                if(last.SetLeftFlag(lastPrevious, dx1: dx, dy1: dy))
                {
                    result.leftCount++;
                }
            }

            if (point.Flags.Contains(PointFlags.Bevel | PointFlags.InnerBevel))
                result.bevelCount++;
        }
        return result;
    }

    private static bool SetLeftFlag(this Point point, Point previousPoint, float dx0 = 0, float dy0 = 0, float dx1 = 0, float dy1 = 0)
    {
        dx0 = previousPoint.Dx ?? dx0;
        dy0 = previousPoint.Dy ?? dy0;
        dx1 = point.Dx ?? dx1;
        dy1 = point.Dy ?? dy1;

        var cross = dx1 * dy0 - dx0 * dy1;
        if (cross > 0.0f)
        {
            point.Flags |= PointFlags.Left;
            return true;
        }
        return false;
    }

    internal static (float dx, float dy, float len) GetDXYL(this Point point, Point nextPoint)
    {
        var dx = nextPoint.X - point.X;
        var dy = nextPoint.Y - point.Y;
        var len = Math.Sqrt(Math.Pow(dx, 2) + Math.Pow(dy, 2));
        if(len > 0)
        {
            var iLen = 1.0f / len;
            dx = (float)(dx * iLen);
            dy = (float)(dy * iLen);
        }
        dx = dx == 0 ? 0 : dx;
        dy = dy == 0 ? 0 : dy;
        return (dx, dy, (float)len);
    }

    internal static (float dmx, float dmy, float dmr2) GetDMXYR(this Point point, Point previousPoint)
    {
        if(point.Dx is float dx1 && point.Dy is float dy1 &&
            previousPoint.Dx is float dx0 && previousPoint.Dy is float dy0)
        {
            var dlx0 = dy0;
            var dly0 = -dx0;
            var dlx1 = dy1;
            var dly1 = -dx1;
            var dmx = (dlx0 + dlx1) * 0.5f;
            var dmy = (dly0 + dly1) * 0.5f;
            var dmr2 = (float)Math.Pow(dmx, 2) + (float)Math.Pow(dmy, 2);
            if (dmr2 > 0.1e-6f)
            {
                float scale = 1.0f / dmr2;
                if (scale > 600.0f)
                {
                    scale = 600.0f;
                }
                dmx = dmx * scale;
                dmy = dmy * scale;
            }
            dmx = dmx == 0 ? 0 : dmx;
            dmy = dmy == 0 ? 0 : dmy;
            return (dmx, dmy, dmr2);
        }
        else
        {
            throw new Exception("Unexpected");
        }
    }
}