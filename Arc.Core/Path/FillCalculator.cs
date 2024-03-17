namespace Arc.Core;

public static class FillCalculator
{
    internal static Vertex[] ToFillVertex(this Path path, State state, int nCap, float fringeWidth)
    {
        return path.GetClosedFillVertex(state, nCap, fringeWidth);
    }
    private static Vertex[] GetClosedFillVertex(this Path path, State state, int nCap, float fringeWidth)
    {
        var strokeWidth = state.StrokeWidth;
        var w = strokeWidth * 0.5f + fringeWidth * 0.5f;
        var isFringe = w > 0;
        var woff = fringeWidth * 0.5f;

        var vertices = new List<Vertex>();
        if(isFringe)
        {
            foreach (var point in path.FillPoints)
            {
                if(point.Dx is float dx1 && point.Dy is float dy1 &&
                    point.Dmx is float dmx && point.Dmy is float dmy &&
                    point.Previous is Point previousPoint &&
                    previousPoint.Dx is float dx0 && previousPoint.Dy is float dy0)
                {
                    if(point.Flags.Contains(PointFlags.Bevel))
                    {
                        var dlx0 = dy0;
                        var dly0 = -dx0;
                        var dlx1 = dy1;
                        var dly1 = -dx1;
                        if(point.Flags.Contains(PointFlags.Left))
                        {
                            var x = point.X + dmx * woff;
                            var y = point.Y + dmy * woff;
                            vertices.Add(new Vertex(x, y, 0.5f, 1));
                        }
                        else
                        {
                            float x0 = point.X + dlx0 * woff;
                            float y0 = point.Y + dly0 * woff;
                            float x1 = point.X + dlx1 * woff;
                            float y1 = point.Y + dly1 * woff;
                            vertices.Add(new Vertex(x0, y0, 0.5f, 1));
                            vertices.Add(new Vertex(x0, y0, 0.5f, 1));
                        }
                    }
                    else
                    {
                        vertices.Add(new Vertex(point.X, point.Y, 0.5f, 1));
                    }
                }
                else
                {
                    throw new Exception("Unexpected");
                }
            }
        }
        return vertices.ToArray();
    }
    
}