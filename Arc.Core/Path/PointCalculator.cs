namespace Arc.Core;

public static class PointCalculator
{
    internal static void Update(this IEnumerable<PathPoint> points, bool isClosed)
    {
        if(isClosed)
        {
            points.UpdateClosed();
        }
        else
        {
            points.UpdateUnclosed();
        }
    }

    private static void UpdateClosed(this IEnumerable<PathPoint> points)
    {
        // Cause we need calculate the following dx_y with foreach loop and calculate the dmx_y base on dx_y array, so we should update the last point dx_y frist.
        if(points.First() is var first && points.Last() is var last)
        {
            var (dx, dy, len) = last.GetDXYL(first);
            last.Dx = dx;
            last.Dy = dy;
            last.Len = (float)len;
        }

        foreach (var point in points)
        {
            if(point.Next is PathPoint nextPoint)
            {
                var (dx, dy, len) = point.GetDXYL(nextPoint);
                point.Dx = dx;
                point.Dy = dy;
                point.Len = (float)len;
            }
            else
            {
                throw new Exception("Unexpected");
            }

            if(point.Dx is float dx1 && point.Dy is float dy1 &&
                point.Previous is PathPoint previousPoint &&
                previousPoint.Dx is float dx0 && previousPoint.Dy is float dy0)
            {
                var (dmx, dmy, dmr2) = point.GetDMXYR(previousPoint);
                point.Dmx = dmx;
                point.Dmy = dmy;
                point.Dmr2 = dmr2;
            }
            else
            {
                throw new Exception("Unexpected");
            }
        }
    }
    
    private static void UpdateUnclosed(this IEnumerable<PathPoint> points)
    {
        var last = points.Last();
        foreach (var point in points)
        {
            if(point.Next is PathPoint nextPoint)
            {
                var (dx, dy, len) = point.GetDXYL(nextPoint);
                point.Dx = dx;
                point.Dy = dy;
                point.Len = point == last ? 0 : (float)len;
            }

            if(point.Dx is float && point.Dy is float &&
                point.Previous is PathPoint previousPoint &&
                previousPoint.Dx is float && previousPoint.Dy is float)
            {
                var (dmx, dmy, dmr2) = point.GetDMXYR(previousPoint);
                point.Dmx = dmx;
                point.Dmy = dmy;
                point.Dmr2 = dmr2;
            }
        }
    }
}
