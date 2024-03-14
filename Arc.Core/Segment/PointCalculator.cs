namespace Arc.Core;

public static class PointCalculator
{
    internal static void Update(this IEnumerable<Point> points, bool isClosed)
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

    private static void UpdateClosed(this IEnumerable<Point> points)
    {
        // if(points.First() is var first && points.Last() is var last)
        // {
        //     var len = Math.Sqrt(Math.Pow(last.X - first.X, 2) + Math.Pow(last.Y - first.Y, 2));

        //     var dx = first.X - last.X;
        //     var dy = first.Y - last.Y;
        //     if(len > 0)
        //     {
        //         var iLen = 1.0f / len;
        //         dx = dx * iLen is var dx2 && dx2 == 0 ? 0 : (float)dx2;
        //         dy = dy * iLen is var dy2 && dy2 == 0 ? 0 : (float)dy2;
        //     }
        //     last.Dx = dx;
        //     last.Dy = dy;
        //     last.Len = (float)len;
        // }

        if(points.First() is var first && points.Last() is var last)
        {
            var (dx, dy, len) = last.GetDXYL(first);
            last.Dx = dx;
            last.Dy = dy;
            last.Len = (float)len;
        }

        foreach (var point in points)
        {
            if(point.Next is Point nextPoint)
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
                point.Previous is Point previousPoint &&
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
    
    private static void UpdateUnclosed(this IEnumerable<Point> points)
    {
        var last = points.Last();
        foreach (var point in points)
        {
            if(point.Next is Point nextPoint)
            {
                var (dx, dy, len) = point.GetDXYL(nextPoint);
                point.Dx = dx;
                point.Dy = dy;
                point.Len = point == last ? 0 : (float)len;
            }

            if(point.Dx is float && point.Dy is float &&
                point.Previous is Point previousPoint &&
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
