namespace Arc.Core;

public static class StrokeCalculator
{
    internal static Vertex[] ToStrokeVertex(this Path path, State state, int nCap, float fringeWidth)
    {
        return path.IsClosed ? path.GetClosedVertex(state, nCap, fringeWidth) : path.GetUnclosedVertex(state, nCap, fringeWidth);
    }
    
    private static Vertex[] GetClosedVertex(this Path path, State state, int nCap, float fringeWidth)
    {
        var lineCap = state.LineCap;
        var lineJoin = state.LineJoin;

        var strokeWidth = state.StrokeWidth;
        var iStrokeWidth = (int)strokeWidth;
        var (lw, rw) = state.StrokeMode switch {
            StrokeMode.PixelAccurate when strokeWidth % 1 == 0 => (
                iStrokeWidth / 2 + iStrokeWidth % 2 == 0 ? 0 : 1 + fringeWidth * 0.5f,
                iStrokeWidth / 2 + fringeWidth * 0.5f
            ),
            _ =>  (
                strokeWidth / 2 + fringeWidth * 0.5f,
                strokeWidth / 2 + fringeWidth * 0.5f
            )
        };

        var result = new List<Vertex>();
        var innerPoints = path.Points.ToList();
        //Enforce close the path when generating the vertices
        innerPoints.Add(path.Points.First());
        foreach (var innerPoint in innerPoints)
        {
            var innerPointVertices = innerPoint.GetJoin(lw, rw, lineJoin, nCap);
            result.AddRange(innerPointVertices);
        }
        return result.ToArray();
    }
    
    private static Vertex[] GetJoin(this Point point, float lw, float rw, LineJoin lineJoin, int nCap)
    {
        if(point.Dmx is float dmx && point.Dmy is float dmy)
        {
            if(point.Flags.Contains(PointFlags.Bevel) || point.Flags.Contains(PointFlags.InnerBevel))
            {
                if(lineJoin is LineJoin.Round)
                {
                    return point.GetRoundJoin(lw, rw, nCap);
                }
                else
                {
                    return point.GetBevelJoin(lw, rw);
                }
            }
            else
            {
                var vertices = new List<Vertex>();
                var px = point.X;
                var py = point.Y;
                vertices.Add(new Vertex(px + dmx * lw, py + dmy * lw, 0, 1));
                vertices.Add(new Vertex(px - dmx * rw, py - dmy * rw, 1, 1));
                return vertices.ToArray();
            }
        }
        else
        {
            throw new Exception("Unexpected");
        }
    }
    
    private static Vertex[] GetUnclosedVertex(this Path path, State state, int nCap, float fringeWidth)
    {
        var lineCap = state.LineCap;
        var lineJoin = state.LineJoin;

        var strokeWidth = state.StrokeWidth;
        var iStrokeWidth = (int)strokeWidth;
        var (lw, rw) = state.StrokeMode switch {
            StrokeMode.PixelAccurate when strokeWidth % 1 == 0 => (
                iStrokeWidth / 2 + iStrokeWidth % 2 == 0 ? 0 : 1 + fringeWidth * 0.5f,
                iStrokeWidth / 2 + fringeWidth * 0.5f
            ),
            _ =>  (
                strokeWidth / 2 + fringeWidth * 0.5f,
                strokeWidth / 2 + fringeWidth * 0.5f
            )
        };
        var aa = fringeWidth;
        
        var result = new List<Vertex>();
        // Add start cap
        var startPoint = path.Points.FirstOrDefault() ?? throw new Exception("No start point in this path");
        var startCapVertices = startPoint.GetStart(lineCap, lw, rw, aa, nCap);
        result.AddRange(startCapVertices);

        var innerPoints = path.Points.Skip(1).Take(path.Points.Length - 2).ToArray();
        foreach (var innerPoint in innerPoints)
        {
            var innerPointVertices = innerPoint.GetJoin(lw, rw, lineJoin, nCap);
            result.AddRange(innerPointVertices);
        }

        // Add end cap
        var endPoint = path.Points.LastOrDefault() ?? throw new Exception("No end point in this path");
        var endCapVertices = endPoint.GetEnd(lineCap, lw, rw, aa, nCap);
        result.AddRange(endCapVertices);

        return result.ToArray();
    }

     private static Vertex[] GetStart(this Point point, LineCap lineCap, float lw, float rw, float aa, int nCap) =>
        lineCap switch
        {
            LineCap.Butt => point.GetSquareStart(lw, rw, -aa * 0.5f, aa),
            LineCap.Square => point.GetSquareStart(lw, rw, -aa, aa),
            LineCap.Round => point.GetRoundStart(lw, rw, nCap),
            _ => throw new NotImplementedException()
        };

    private static Vertex[] GetSquareStart(this Point point, float lw, float rw, float extendedLen, float aa)
    {
        if(point.Dx is float dx && point.Dy is float dy)
        {
            var vertices = new List<Vertex>();
            var px = point.X - dx * extendedLen;
            var py = point.Y - dy * extendedLen;
            var dlx = dy;
            var dly = -dx;

            vertices.Add(new Vertex(px + dlx * lw - dx * aa, py + dly * lw - dy * aa, 0, 0));
            vertices.Add(new Vertex(px - dlx * rw - dx * aa, py - dly * rw - dy * aa, 1, 0));
            vertices.Add(new Vertex(px + dlx * lw, py + dly * lw, 0, 1));
            vertices.Add(new Vertex(px - dlx * rw, py - dly * rw, 1, 1));
            return vertices.ToArray();
        }
        else
        {
            throw new Exception("Unexpected");
        }
    }
    
    private static Vertex[] GetRoundStart(this Point point, float lw, float rw, int nCap)
    {
        if(point.Dx is float dx && point.Dy is float dy)
        {
            var vertices = new List<Vertex>();
            var px = point.X;
            var py = point.Y;
            var dlx = dy;
            var dly = -dx;
            
            if(lw != rw)
            {
                var dw = (lw - rw) * 0.5f;
                px += dlx * dw;
                py += dly * dw;
            }
            var w = (lw + rw) * 0.5f;


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

private static Vertex[] GetRoundJoin(this Point point, float lw, float rw, int nCap)
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
                var (lx0, ly0, lx1, ly1) = point.ChooseBevel(lw);
                
				var a0 = (float)Math.Atan2(-dly0, -dlx0);
				var a1 = (float)Math.Atan2(-dly1, -dlx1);
				if (a1 > a0)
					a1 -= (float)(Math.PI * 2);

                vertices.Add(new Vertex(lx0, ly0, lu, 1));
                vertices.Add(new Vertex(point.X - dlx0 * rw, point.Y - dly0 * rw, ru, 1));

                var n = Math.Clamp((int)Math.Ceiling((a0 - a1) / Math.PI * nCap), 2, nCap);
                for (int i = 0; i < n; i++)
                {
					float u = i / (float)(n - 1);
					float a = a0 + u * (a1 - a0);
					float rx = (float)(point.X + Math.Cos(a) * rw);
					float ry = (float)(point.Y + Math.Sin(a) * rw);
                    vertices.Add(new Vertex(point.X, point.Y, 0.5f, 1));
                    vertices.Add(new Vertex(rx, ry, ru, 1));

                }
                vertices.Add(new Vertex(lx1, ly1, lu, 1));
                vertices.Add(new Vertex(point.X - dlx1 * rw, point.Y - dly1 * rw, ru, 1));
            }
            else
            {
                var (rx0, ry0, rx1, ry1) = point.ChooseBevel(-rw);
                var a0 = (float)Math.Atan2(dly0, dlx0);
                var a1 = (float)Math.Atan2(dly1, dlx1);
                if (a1 < a0)
                    a1 += (float)(Math.PI * 2);
                
                vertices.Add(new Vertex(point.X + dlx0 * rw, point.Y + dly0 * rw, lu, 1));
                vertices.Add(new Vertex(rx0, ry0, ru, 1));

                var n = Math.Clamp((int)Math.Ceiling((a1 - a0) / Math.PI * nCap), 2, nCap);
                for (int i = 0; i < n; i++)
                {
					float u = i / (float)(n - 1);
					float a = a0 + u * (a1 - a0);
					float lx = (float)(point.X + Math.Cos(a) * lw);
					float ly = (float)(point.Y + Math.Sin(a) * lw);
                    vertices.Add(new Vertex(lx, ly, lu, 1));
                    vertices.Add(new Vertex(point.X, point.Y, 0.5f, 1));
                }
                vertices.Add(new Vertex(point.X + dlx1 * rw, point.Y + dly1 * rw, lu, 1));
                vertices.Add(new Vertex(rx1, ry1, ru, 1));
            }
            return vertices.ToArray();
        }
        else
        {
            throw new Exception("Unexpected");
        }
    }
    
    private static Vertex[] GetBevelJoin(this Point point, float lw, float rw)
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
                var (lx0, ly0, lx1, ly1) = point.ChooseBevel(lw);
                vertices.Add(new Vertex(lx0, ly0, lu, 1));
                vertices.Add(new Vertex(point.X - dlx0 * rw, point.Y - dly0 * rw, ru, 1));

                if(point.Flags.Contains(PointFlags.Bevel))
                {
                    vertices.Add(new Vertex(lx0, ly0, lu, 1));
                    vertices.Add(new Vertex(point.X - dlx0 * rw, point.Y - dly0 * rw, ru, 1));
                    
                    vertices.Add(new Vertex(lx1, ly1, lu, 1));
                    vertices.Add(new Vertex(point.X - dlx1 * rw, point.Y - dly1 * rw, ru, 1));

                }
                else
                {
                    var rx0 = point.X - dmx1 * rw;
                    var ry0 = point.Y - dmy1 * rw;
                    
                    vertices.Add(new Vertex(point.X, point.Y, 0.5f, 1));
                    vertices.Add(new Vertex(point.X - dlx0 * rw, point.Y - dly0 * rw, ru, 1));
                    
                    vertices.Add(new Vertex(rx0, ry0, ru, 1));
                    vertices.Add(new Vertex(rx0, ry0, ru, 1));
                    
                    vertices.Add(new Vertex(point.X, point.Y, 0.5f, 1));
                    vertices.Add(new Vertex(point.X - dlx1 * rw, point.Y - dly1 * rw, ru, 1));
                }

                vertices.Add(new Vertex(lx1, ly1, lu, 1));
                vertices.Add(new Vertex(point.X - dlx1 * rw, point.Y - dly1 * rw, ru, 1));
            }
            else
            {
                var (rx0, ry0, rx1, ry1) = point.ChooseBevel(-rw);

                vertices.Add(new Vertex(point.X + dlx0 * lw, point.Y + dly0 * lw, lu, 1));
                vertices.Add(new Vertex(rx0, ry0, ru, 1));

                if(point.Flags.Contains(PointFlags.Bevel))
                {
                    vertices.Add(new Vertex(point.X + dlx0 * lw, point.Y + dly0 * lw, lu, 1));
                    vertices.Add(new Vertex(rx0, ry0, ru, 1));

                    vertices.Add(new Vertex(point.X + dlx1 * lw, point.Y + dly1 * lw, lu, 1));
                    vertices.Add(new Vertex(rx1, ry1, ru, 1));
                }
                else
                {
					var lx0 = point.X + dmx1 * lw;
					var ly0 = point.Y + dmy1 * lw;

                    vertices.Add(new Vertex(point.X + dlx0 * lw, point.Y + dly0 * lw, lu, 1));
                    vertices.Add(new Vertex(point.X, point.Y, 0.5f, 1));
                    
                    vertices.Add(new Vertex(lx0, ly0, lu, 1));
                    vertices.Add(new Vertex(lx0, ly0, lu, 1));

                    vertices.Add(new Vertex(point.X + dlx1 * lw, point.Y + dly1 * lw, lu, 1));
                    vertices.Add(new Vertex(point.X, point.Y, 0.5f, 1));
                }
                vertices.Add(new Vertex(point.X + dlx1 * lw, point.Y + dly1 * lw, lu, 1));
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

    private static Vertex[] GetEnd(this Point point, LineCap lineCap, float lw, float rw, float aa, int nCap) =>
        lineCap switch
        {
            LineCap.Butt => point.GetSquareEnd(lw, rw, -aa * 0.5f, aa),
            LineCap.Square => point.GetSquareEnd(lw, rw, (lw + rw) * 0.5f -aa, aa),
            LineCap.Round => point.GetRoundEnd(lw, rw, nCap),
            _ => throw new NotImplementedException()
        };
    
    private static Vertex[] GetSquareEnd(this Point point, float lw, float rw, float extendedLen, float aa)
    {
        if(point.Previous?.Dx is float dx && point.Previous?.Dy is float dy)
        {
            var vertices = new List<Vertex>();
            var px = point.X - dx * extendedLen;
            var py = point.Y - dy * extendedLen;
            var dlx = dy;
            var dly = -dx;

            vertices.Add(new Vertex(px + dlx * lw - dx * aa, py + dly * lw - dy * aa, 0, 1));
            vertices.Add(new Vertex(px - dlx * rw - dx * aa, py - dly * rw - dy * aa, 1, 1));
            vertices.Add(new Vertex(px + dlx * lw, py + dly * lw, 0, 0));
            vertices.Add(new Vertex(px - dlx * rw, py - dly * rw, 1, 0));
            return vertices.ToArray();
        }
        else
        {
            throw new Exception("Unexpected");
        }
    }
    
    private static Vertex[] GetRoundEnd(this Point point, float lw, float rw, int nCap)
    {
        if(point.Previous?.Dx is float dx && point.Previous?.Dy is float dy)
        {
            var vertices = new List<Vertex>();
            var px = point.X;
            var py = point.Y;
            var dlx = dy;
            var dly = -dx;
            
            if(lw != rw)
            {
                var dw = (lw - rw) * 0.5f;
                px += dlx * dw;
                py += dly * dw;
            }
            var w = (lw + rw) * 0.5f;

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