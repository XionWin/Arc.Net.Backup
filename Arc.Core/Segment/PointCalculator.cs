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
        if(points.First() is var first && points.Last() is var last)
        {
            var len = Math.Sqrt(Math.Pow(last.X - first.X, 2) + Math.Pow(last.Y - first.Y, 2));

            var dx = first.X - last.X;
            var dy = first.Y - last.Y;
            if(len > 0)
            {
                var iLen = 1.0f / len;
                dx = dx * iLen is var dx2 && dx2 == 0 ? 0 : (float)dx2;
                dy = dy * iLen is var dy2 && dy2 == 0 ? 0 : (float)dy2;
            }
            last.Dx = dx;
            last.Dy = dy;
            last.Len = (float)len;
        }

        foreach (var point in points)
        {
            if(point.Next is Point nextPoint)
            {
                var len = Math.Sqrt(Math.Pow(point.X - nextPoint.X, 2) + Math.Pow(point.Y - nextPoint.Y, 2));

                var dx = nextPoint.X - point.X;
                var dy = nextPoint.Y - point.Y;
                if(len > 0)
                {
                    var iLen = 1.0f / len;
                    dx = dx * iLen is var dx2 && dx2 == 0 ? 0 : (float)dx2;
                    dy = dy * iLen is var dy2 && dy2 == 0 ? 0 : (float)dy2;
                }
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
                var dmx = (dy0 + dy1) / 2f;
                var dmy = (-dx0 - dx1) / 2f;
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
                point.Dmx = dmx == 0 ? 0 : (float)dmx;
                point.Dmy = dmy == 0 ? 0 : (float)dmy;
                point.Dmr2 = (float)Math.Pow(dmx, 2) + (float)Math.Pow(dmy, 2);
            }
            else
            {
                throw new Exception("Unexpected");
            }
        }
    }
    
    private static void UpdateUnclosed(this IEnumerable<Point> points)
    {
        var first = points.First();
        var last = points.Last();

        foreach (var point in points)
        {
            if(point.Next is Point nextPoint)
            {
                var len = Math.Sqrt(Math.Pow(point.X - nextPoint.X, 2) + Math.Pow(point.Y - nextPoint.Y, 2));

                var dx = nextPoint.X - point.X;
                var dy = nextPoint.Y - point.Y;
                if(len > 0)
                {
                    var iLen = 1.0f / len;
                    dx = dx * iLen is var dx2 && dx2 == 0 ? 0 : (float)dx2;
                    dy = dy * iLen is var dy2 && dy2 == 0 ? 0 : (float)dy2;
                }
                point.Dx = dx;
                point.Dy = dy;
                point.Len = point == last ? 0 : (float)len;
            }

            if(point.Dx is float dx1 && point.Dy is float dy1 &&
                point.Previous is Point previousPoint &&
                previousPoint.Dx is float dx0 && previousPoint.Dy is float dy0)
            {
                var dmx = (dy0 + dy1) / 2f;
                var dmy = (-dx0 - dx1) / 2f;
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
                point.Dmx = dmx;
                point.Dmy = dmy;
                point.Dmr2 = (float)Math.Pow(dmx, 2) + (float)Math.Pow(dmy, 2);
            }
        }
    }
}
