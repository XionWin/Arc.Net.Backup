namespace Arc.Core;

public static class VertexCalculator
{
    internal static Vertex[] ToVertex(this Segment segment, Context context)
    {
        return segment.IsClosed ? segment.GetClosedVertex(context) : segment.GetUnclosedVertex(context);
    }  
    
    private static Vertex[] GetClosedVertex(this Segment segment, Context context)
    {
        var state = context.GetState();
        int nCap = context.CurveDivs(state);

        var lineCap = context.GetState().LineCap;
        var lineJoin = context.GetState().LineJoin;

        var strokeWidth = context.GetState().StrokeWidth;
        var w = strokeWidth / 2;
        var aa = context.FringeWidth;
        
        var result = new List<Vertex>();
        var innerPoints = segment.Points.ToList();
        //Enforce close the path when generating the vertices
        innerPoints.Add(segment.Points.First());
        foreach (var innerPoint in innerPoints)
        {
            var innerPointVertices = innerPoint.GetJoin(w, lineJoin, nCap);
            result.AddRange(innerPointVertices);
        }

        return result.ToArray();
    }
    
    private static Vertex[] GetUnclosedVertex(this Segment segment, Context context)
    {
        var state = context.GetState();
        int nCap = context.CurveDivs(state);

        var lineCap = context.GetState().LineCap;
        var lineJoin = context.GetState().LineJoin;

        var strokeWidth = context.GetState().StrokeWidth;
        var w = strokeWidth / 2;
        var aa = context.FringeWidth;
        
        var result = new List<Vertex>();
        // Add start cap
        var startPoint = segment.Points.FirstOrDefault() ?? throw new Exception("No start point in this path");
        var startCapVertices = startPoint.GetStart(lineCap, w, aa, nCap);
        result.AddRange(startCapVertices);

        var innerPoints = segment.Points.Skip(1).Take(segment.Points.Length - 2).ToArray();
        foreach (var innerPoint in innerPoints)
        {
            var innerPointVertices = innerPoint.GetJoin(w, lineJoin, nCap);
            result.AddRange(innerPointVertices);
        }

        // Add end cap
        var endPoint = segment.Points.LastOrDefault() ?? throw new Exception("No end point in this path");
        var endCapVertices = endPoint.GetEnd(lineCap, w, aa, nCap);
        result.AddRange(endCapVertices);

        return result.ToArray();
    }

     private static Vertex[] GetStart(this Point point, LineCap lineCap, float w, float aa, int nCap) =>
        lineCap switch
        {
            LineCap.Butt => point.GetSquareStart(w, -aa * 0.5f, aa),
            LineCap.Square => point.GetSquareStart(w, w -aa, aa),
            LineCap.Round => point.GetRoundStart(w, 0, aa, nCap),
            _ => throw new NotImplementedException()
        };

    private static Vertex[] GetSquareStart(this Point point, float w, float extendedLen, float aa)
    {
        if(point.Dx is float dx && point.Dy is float dy)
        {
            var vertices = new List<Vertex>();
            var px = point.X - dx * extendedLen;
            var py = point.Y - dy * extendedLen;
            var dlx = dy;
            var dly = -dx;

            vertices.Add(new Vertex(px + dlx * w - dx * aa, py + dly * w - dy * aa, 0, 0));
            vertices.Add(new Vertex(px - dlx * w - dx * aa, py - dly * w - dy * aa, 1, 0));
            vertices.Add(new Vertex(px + dlx * w, py + dly * w, 0, 1));
            vertices.Add(new Vertex(px - dlx * w, py - dly * w, 1, 1));
            return vertices.ToArray();
        }
        else
        {
            throw new Exception("Unexpected");
        }
    }
    
    private static Vertex[] GetRoundStart(this Point point, float w, float extendedLen, float aa, int nCap)
    {
        if(point.Dx is float dx && point.Dy is float dy)
        {
            var vertices = new List<Vertex>();
            var px = point.X;
            var py = point.Y;
            var dlx = dy;
            var dly = -dx;
            for (int i = 0; i < nCap; i++)
            {
                var a = (float)((double)i / (nCap - 1) * Math.PI);
                var ax = (float)Math.Cos(a) * w;
                var ay = (float)Math.Sin(a) * w;
                vertices.Add(new Vertex(px - dlx * ax - dx * ay, py - dly * ax - dy * ay, 0, 1));
                vertices.Add(new Vertex(px, py, 0.5f, 1));
            }
            vertices.Add(new Vertex(px + dlx * w, py + dly * w, 0, 1));
            vertices.Add(new Vertex(px - dlx * w, py - dly * w, 1, 1));
            return vertices.ToArray();
        }
        else
        {
            throw new Exception("Unexpected");
        }
    }

    private static Vertex[] GetJoin(this Point point, float w, LineJoin lineJoin, int ncap)
    {
        if(point.Dmx is float dmx && point.Dmy is float dmy)
        {
            if(point.Flags.Contains(PointFlags.Bevel) || point.Flags.Contains(PointFlags.InnerBevel))
            {
                if(lineJoin is LineJoin.Round)
                {
                    return point.GetBevelJoin(w);
                }
                else
                {
                    return point.GetBevelJoin(w);
                }
            }
            else
            {
                var vertices = new List<Vertex>();
                var px = point.X;
                var py = point.Y;

                vertices.Add(new Vertex(px + dmx * w, py + dmy * w, 0, 1));
                vertices.Add(new Vertex(px - dmx * w, py - dmy * w, 1, 1));

                return vertices.ToArray();
            }
        }
        else
        {
            throw new Exception("Unexpected");
        }
    }

    
    private static Vertex[] GetBevelJoin(this Point point, float w)
    {
        if(point.Dx is float dx1 && point.Dy is float dy1 &&
            point.Dmx is float dmx1 && point.Dmy is float dmy1 &&
            point.Previous is Point previous &&
            previous.Dx is float dx0 && previous.Dy is float dy0)
        {
            var vertices = new List<Vertex>();
            float dlx0 = dy0;
            float dly0 = -dx0;
            float dlx1 = dy1;
            float dly1 = -dx1;

            float lu = 0;
            float ru = 1;
            if(point.Flags.Contains(PointFlags.Left))
            {
                var (lx0, ly0, lx1, ly1) = point.ChooseBevel(w);
                vertices.Add(new Vertex(lx0, ly0, lu, 1));
                vertices.Add(new Vertex(point.X - dlx0 * w, point.Y - dly0 * w, ru, 1));

                if(point.Flags.Contains(PointFlags.Bevel))
                {
                    vertices.Add(new Vertex(lx0, ly0, lu, 1));
                    vertices.Add(new Vertex(point.X - dlx0 * w, point.Y - dly0 * w, ru, 1));
                    
                    vertices.Add(new Vertex(lx1, ly1, lu, 1));
                    vertices.Add(new Vertex(point.X - dlx1 * w, point.Y - dly1 * w, ru, 1));

                }
                else
                {
                    var rx0 = point.X - dmx1 * w;
                    var ry0 = point.Y - dmy1 * w;
                    
                    vertices.Add(new Vertex(point.X, point.Y, 0.5f, 1));
                    vertices.Add(new Vertex(point.X - dlx0 * w, point.Y - dly0 * w, ru, 1));
                    
                    vertices.Add(new Vertex(rx0, ry0, ru, 1));
                    vertices.Add(new Vertex(rx0, ry0, ru, 1));
                    
                    vertices.Add(new Vertex(point.X, point.Y, 0.5f, 1));
                    vertices.Add(new Vertex(point.X - dlx1 * w, point.Y - dly1 * w, ru, 1));
                }

                vertices.Add(new Vertex(lx1, ly1, lu, 1));
                vertices.Add(new Vertex(point.X - dlx1 * w, point.Y - dly1 * w, ru, 1));
            }
            else
            {
                var (rx0, ry0, rx1, ry1) = point.ChooseBevel(w);
                
                vertices.Add(new Vertex(point.X - dlx0 * w, point.Y - dly0 * w, lu, 1));
                vertices.Add(new Vertex(rx0, ry0, ru, 1));

                if(point.Flags.Contains(PointFlags.Bevel))
                {
                    vertices.Add(new Vertex(point.X - dlx0 * w, point.Y - dly0 * w, lu, 1));
                    vertices.Add(new Vertex(rx0, ry0, ru, 1));

                    vertices.Add(new Vertex(point.X - dlx1 * w, point.Y - dly1 * w, lu, 1));
                    vertices.Add(new Vertex(rx1, ry1, ru, 1));
                }
                else
                {
					var lx0 = point.X + dmx1 * w;
					var ly0 = point.Y + dmy1 * w;

                    vertices.Add(new Vertex(point.X - dlx0 * w, point.Y - dly0 * w, lu, 1));
                    vertices.Add(new Vertex(point.X, point.Y, 0.5f, 1));
                    
                    vertices.Add(new Vertex(lx0, ly0, lu, 1));
                    vertices.Add(new Vertex(lx0, ly0, lu, 1));

                    vertices.Add(new Vertex(point.X - dlx1 * w, point.Y - dly1 * w, lu, 1));
                    vertices.Add(new Vertex(point.X, point.Y, 0.5f, 1));
                }
                vertices.Add(new Vertex(point.X - dlx1 * w, point.Y - dly1 * w, lu, 1));
                vertices.Add(new Vertex(rx1, ry1, ru, 1));
            }
            return vertices.ToArray();
        }
        else
        {
            throw new Exception("Unexpected");
        }
    }
    
    private static (float x0, float y0, float x1, float y1) ChooseBevel(this Point point, float w)
    {
        if(point.Dx is float dx1 && point.Dy is float dy1 &&
            point.Dmx is float dmx1 && point.Dmy is float dmy1 &&
            point.Previous is Point previous &&
            previous.Dx is float dx0 && previous.Dy is float dy0)
        {
			if (point.Flags.Contains(PointFlags.InnerBevel))
			{
                var x0 = point.X + dy0 * w;
                var y0 = point.Y - dx0 * w;
                var x1 = point.X + dy1 * w;
                var y1 = point.Y - dx1 * w;
                return (x0, y0, x1, y1);
			}
			else
			{
				var x0 = point.X + dmx1 * w;
				var y0 = point.Y + dmy1 * w;
				var x1 = point.X + dmx1 * w;
				var y1 = point.Y + dmy1 * w;
                return (x0, y0, x1, y1);
			}
        }
        else
        {
            throw new Exception("Unexpected");
        }
    }

    private static Vertex[] GetEnd(this Point point, LineCap lineCap, float w, float aa, int nCap) =>
        lineCap switch
        {
            LineCap.Butt => point.GetSquareEnd(w, -aa * 0.5f, aa),
            LineCap.Square => point.GetSquareEnd(w, w -aa, aa),
            LineCap.Round => point.GetRoundEnd(w, 0, aa, nCap),
            _ => throw new NotImplementedException()
        };
    
    private static Vertex[] GetSquareEnd(this Point point, float w, float extendedLen, float aa)
    {
        if(point.Previous?.Dx is float dx && point.Previous?.Dy is float dy)
        {
            var vertices = new List<Vertex>();
            var px = point.X - dx * extendedLen;
            var py = point.Y - dy * extendedLen;
            var dlx = dy;
            var dly = -dx;

            vertices.Add(new Vertex(px + dlx * w - dx * aa, py + dly * w - dy * aa, 0, 0));
            vertices.Add(new Vertex(px - dlx * w - dx * aa, py - dly * w - dy * aa, 1, 0));
            vertices.Add(new Vertex(px + dlx * w, py + dly * w, 0, 1));
            vertices.Add(new Vertex(px - dlx * w, py - dly * w, 1, 1));
            return vertices.ToArray();
        }
        else
        {
            throw new Exception("Unexpected");
        }
    }
    
    private static Vertex[] GetRoundEnd(this Point point, float w, float extendedLen, float aa, int nCap)
    {
        if(point.Previous?.Dx is float dx && point.Previous?.Dy is float dy)
        {
            var vertices = new List<Vertex>();
            var px = point.X;
            var py = point.Y;
            var dlx = dy;
            var dly = -dx;

            vertices.Add(new Vertex(px + dlx * w, py + dly * w, 0, 1));
            vertices.Add(new Vertex(px - dlx * w, py - dly * w, 1, 1));

            for (int i = 0; i < nCap; i++)
            {
                var a = (float)((double)i / (nCap - 1) * Math.PI);
                var ax = (float)Math.Cos(a) * w;
                var ay = (float)Math.Sin(a) * w;
                vertices.Add(new Vertex(px, py, 0.5f, 1));
                vertices.Add(new Vertex(px - dlx * ax + dx * ay, py - dly * ax + dy * ay, 0, 1));
            }
            return vertices.ToArray();
        }
        else
        {
            throw new Exception("Unexpected");
        }
    }
}