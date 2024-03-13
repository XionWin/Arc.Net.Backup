namespace Arc.Core;

public static class JoinsCalculator
{
    internal static void CalculateJoins(this Segment segment)
    {
        var leftCount = 0;
        foreach (var point in segment.Points)
        {
            // Clear flags, but keep the corner.
            point.Flags = point.Flags is PointFlags.None ? PointFlags.None : PointFlags.Corner;

            if(point.Previous is Point previousPoint)
            {
                // Keep track of left turns.
                var cross = point.Dx * previousPoint.Dy - previousPoint.Dx * point.Dy;
                if (cross > 0.0f)
                {
                    leftCount++;
                    point.Flags |= PointFlags.Left;
                }

                // Calculate if we should use bevel or miter for inner join.
                if(previousPoint.Len is float previousLen && point.Len is float len && point.Dmr2 is float dmr2)
                {
                    var state = segment.Path.State;
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

            if (point.Flags.Contains(PointFlags.Bevel | PointFlags.InnerBevel))
                segment.BevelCount++;
        }
        segment.IsConvex = leftCount == segment.Points.Length;
    }
}