namespace App.VG;


public class Path
{
    private List<Command> _commands = new List<Command>();
    public List<Command> Commands => this._commands;
    private PathPoint[]? _points = null;
    public PathPoint[] Points => this._points ?? throw new Exception("No point in this path");

    private Vertex[]? _vertices = null;
    public Vertex[] Vertices => this._vertices ?? throw new Exception("No vertex in this path");

    public int Count => this.Points?.Length ?? 0;
    public int BevelCount { get; set; }
    public int VertexCount => this._vertices?.Length ?? 0;
    public bool IsClosed { get; set; }
    public Winding Winding { get; set; }
    public bool IsConvex { get; set; }
    public Rect Bounds { get; private set; }
    public bool IsFinalized { get; set; }

    public void AddCommand(Command command)
    {
        if(this.IsFinalized)
        {
            throw new Exception("Can't add command into a finalized path");
        }
        if(this.IsClosed)
        {
            throw new Exception("Can't add command into a closed path");
        }
        this.Commands.Add(command);
    }

    public void Stroke(Context context, PathType pathType)
    {
        // Finalize path
        this.IsFinalized = true;
        this._points = this.FinalizePath(context.DistTol);
        this.UpdateBounds();

        this._vertices = this.Expand(context, pathType);
    }

    // [TODO] Need update turly bounds when primitive generated
    private void UpdateBounds()
    {
        var minX = this.Points.Min(x => x.X);
        var maxX = this.Points.Max(x => x.X);
        var minY = this.Points.Min(x => x.Y);
        var maxY = this.Points.Max(x => x.Y);
        this.Bounds = new Rect (
            minX,
            minY,
            maxX,
            maxY
        );
    }
}

public static class FinalizedPathExtension
{
    public static PathPoint[] FinalizePath(this Path path, float distTol) =>
        path.TryClosePath().SelectMany(x => x.ToPathPoints()).ToList()
        .Optimize(distTol)
        .EnforceWinding(path.Winding, path.IsClosed);

    private static IEnumerable<Command> TryClosePath(this Path path)
    {
        if(path.Commands.Last().CommandType is CommandType.Close)
        {
            path.IsClosed = path.Commands.Any(x => x.CommandType == CommandType.Close);
            return path.Commands.Take(path.Commands.Count - 1);
        }
        else
        {
            return path.Commands;
        }
    }

    private static IEnumerable<PathPoint> ToPathPoints(this Command command) =>
        command.CommandType switch
        {
            var type when type is CommandType.MoveTo || type is CommandType.LineTo => 
                command.Points.Select(x => new PathPoint(x.X, x.Y, PointFlags.Corner)),
            _ => throw new NotImplementedException()
        };

    internal static PathPoint[] EnforceWinding(this List<PathPoint> points, Winding winding, bool isClosed)
    {

        if(points.Area() is float area)
        {
            if((winding is Winding.CCW && area < 0) || winding is Winding.CW && area > 0)
            {
                points.Reverse();
            }
        }

        for (int i = 0; i < points.Count - 1; i++)
        {
            var current = points[i];
            var next = points[i + 1];
            current.UpdateDelta(next.X - current.X, next.Y - current.Y);
        }

        if(isClosed)
        {
            var last = points.Last();
            var first = points.First();
            last.UpdateDelta(first.X - last.X, first.Y - last.Y);
        }
        else
        {
            var last = points.Last();
            var previous = points.Skip(points.Count - 2).FirstOrDefault() ?? throw new Exception("No previous point for the last point");
            last.UpdateDelta(last.X - previous.X, last.Y - previous.Y);
        }
        return points.ToArray();
    }
    
    public static List<PathPoint> Optimize(this List<PathPoint> points, float distTol)
    {
        for (int i = 1; i < points.Count; i++)
        {
            var current = points[i];
            var last = points[i - 1];
            if(last.Distance(current) < distTol)
            {
                last.Flags |= current.Flags;
                points.Remove(current);
            }
        }
        return points;
    }

    private static float? Area(this List<PathPoint> points)
    {
        var area = 0f;
        if(points.Count > 2)
        {
            for (int i = 2; i < points.Count; i++)
            {
                var a = points[0];
                var b = points[i - 1];
                var c = points[i];

                float abx = b.X - a.X;
                float aby = b.Y - a.Y;
                float acx = c.X - a.X;
                float acy = c.Y - a.Y;
                area += (acx * aby - abx * acy) / 2;
            }
            return area;
        }
        else
        {
            return null;
        }
    }

    public static Vertex[] Expand(this Path path, Context context, PathType pathType)
    {
        var state = context.GetState();
        var scale = state.GetAverageScale();
        var strokeWidth = Math.Clamp(state.StrokeWidth * scale, 0.0f, 200.0f);

        var strokePaint = state.StrokePaint.Clone();

        if (strokeWidth < context.FringeWidth)
        {
            // If the stroke width is less than pixel size, use alpha to emulate coverage.
            // Since coverage is area, scale by alpha*alpha.
            float alpha = Math.Clamp(strokeWidth / context.FringeWidth, 0.0f, 1.0f);
            strokePaint.InnerColor.A *= alpha * alpha;
            strokePaint.OuterColor.A *= alpha * alpha;
            strokeWidth = context.FringeWidth;
        }

        // Apply global alpha
        strokePaint.InnerColor.A *= state.alpha;
        strokePaint.OuterColor.A *= state.alpha;

        path.CalculateJoins(context);


        var vertices = path.ToVertex(context);
        return vertices;
        // var vertices = new List<Vertex>(){
        //     new Vertex(345.5f, 320f, 0f, 1f),
        //     new Vertex(320f, 320f, 0.5f, 1f),
        //     new Vertex(344.4671f, 327.1842f, 0f, 1f),
        //     new Vertex(320f, 320f, 0.5f, 1f),
        //     new Vertex(341.452f, 333.7863f, 0f, 1f),
        //     new Vertex(320f, 320f, 0.5f, 1f),
        //     new Vertex(336.6989f, 339.2716f, 0f, 1f),
        //     new Vertex(320f, 320f, 0.5f, 1f),
        //     new Vertex(330.5931f, 343.1956f, 0f, 1f),
        //     new Vertex(320f, 320f, 0.5f, 1f),
        //     new Vertex(323.629f, 345.2404f, 0f, 1f),
        //     new Vertex(320f, 320f, 0.5f, 1f),
        //     new Vertex(316.371f, 345.2404f, 0f, 1f),
        //     new Vertex(320f, 320f, 0.5f, 1f),
        //     new Vertex(309.4069f, 343.1956f, 0f, 1f),
        //     new Vertex(320f, 320f, 0.5f, 1f),
        //     new Vertex(303.3011f, 339.2716f, 0f, 1f),
        //     new Vertex(320f, 320f, 0.5f, 1f),
        //     new Vertex(298.548f, 333.7863f, 0f, 1f),
        //     new Vertex(320f, 320f, 0.5f, 1f),
        //     new Vertex(295.5329f, 327.1842f, 0f, 1f),
        //     new Vertex(320f, 320f, 0.5f, 1f),
        //     new Vertex(294.5f, 320f, 0f, 1f),
        //     new Vertex(320f, 320f, 0.5f, 1f),
        //     new Vertex(294.5f, 320f, 0f, 1f),
        //     new Vertex(345.5f, 320f, 1f, 1f),

        //     new Vertex(294.5f, 125.5f, 0f, 1f),
        //     new Vertex(345.5f, 74.5f, 1f, 1f),

        //     new Vertex(100f, 125.5f, 0f, 1f),
        //     new Vertex(100f, 74.5f, 1f, 1f),
        //     new Vertex(100f, 100f, 0.5f, 1f),
        //     new Vertex(100f, 74.5f, 0f, 1f),
        //     new Vertex(100f, 100f, 0.5f, 1f),
        //     new Vertex(92.81582f, 75.53293f, 0f, 1f),
        //     new Vertex(100f, 100f, 0.5f, 1f),
        //     new Vertex(86.21366f, 78.54803f, 0f, 1f),
        //     new Vertex(100f, 100f, 0.5f, 1f),
        //     new Vertex(80.72839f, 83.30106f, 0f, 1f),
        //     new Vertex(100f, 100f, 0.5f, 1f),
        //     new Vertex(76.80438f, 89.40692f, 0f, 1f),
        //     new Vertex(100f, 100f, 0.5f, 1f),
        //     new Vertex(74.75955f, 96.37097f, 0f, 1f),
        //     new Vertex(100f, 100f, 0.5f, 1f),
        //     new Vertex(74.75955f, 103.629f, 0f, 1f),
        //     new Vertex(100f, 100f, 0.5f, 1f),
        //     new Vertex(76.80438f, 110.5931f, 0f, 1f),
        //     new Vertex(100f, 100f, 0.5f, 1f),
        //     new Vertex(80.72839f, 116.699f, 0f, 1f),
        //     new Vertex(100f, 100f, 0.5f, 1f),
        //     new Vertex(86.21366f, 121.452f, 0f, 1f),
        //     new Vertex(100f, 100f, 0.5f, 1f),
        //     new Vertex(92.81583f, 124.4671f, 0f, 1f),
        //     new Vertex(100f, 100f, 0.5f, 1f),
        //     new Vertex(100f, 125.5f, 0f, 1f),
        // };

        // return vertices.ToArray();
    }

    private static Vertex[] ToVertex(this Path path, Context context)
    {
        
        return path.IsClosed ? path.GetClosedVertex(context) : path.GetUnclosedVertex(context);
    }

    private static Vertex[] GetUnclosedVertex(this Path path, Context context)
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
        var startPoint = path.Points.FirstOrDefault() ?? throw new Exception("No start point in this path");
        var startCapVertices = startPoint.GetStart(lineCap, w, aa, nCap);
        result.AddRange(startCapVertices);

        var innerPoints = path.Points.Skip(1).Take(path.Points.Length - 2).ToArray();
        var previewPoint  =  path.Points.FirstOrDefault() ?? throw new Exception("No preview point for the innerPoint");
        foreach (var innerPoint in innerPoints)
        {
            var innerPointVertices = innerPoint.GetJoin(previewPoint, w, lineJoin);
            result.AddRange(innerPointVertices);
            previewPoint = innerPoint;
        }

        // Add end cap
        var endPoint = path.Points.LastOrDefault() ?? throw new Exception("No end point in this path");
        var endCapVertices = endPoint.GetEnd(lineCap, w, aa, nCap);
        result.AddRange(endCapVertices);

        return result.ToArray();
    }

    private static Vertex[] GetStart(this PathPoint point, LineCap lineCap, float w, float aa, int nCap) =>
        lineCap switch
        {
            LineCap.Butt => point.GetSquareStart(w, -aa * 0.5f, aa),
            LineCap.Square => point.GetSquareStart(w, w -aa, aa),
            LineCap.Round => point.GetRoundStart(w, 0, aa, nCap),
            _ => throw new NotImplementedException()
        };
    
    private static Vertex[] GetSquareStart(this PathPoint point, float w, float extendedLen, float aa)
    {
        var vertices = new List<Vertex>();
        var dx = point.Dx;
        var dy = point.Dy;
        var px = point.X - dx * extendedLen;
        var py = point.Y - dy * extendedLen;
        var dlx = point.Dy;
        var dly = -point.Dx;

        vertices.Add(new Vertex(px + dlx * w - dx * aa, py + dly * w - dy * aa, 0, 0));
        vertices.Add(new Vertex(px - dlx * w - dx * aa, py - dly * w - dy * aa, 1, 0));
        vertices.Add(new Vertex(px + dlx * w, py + dly * w, 0, 1));
        vertices.Add(new Vertex(px - dlx * w, py - dly * w, 1, 1));
        return vertices.ToArray();
    }
    
    private static Vertex[] GetRoundStart(this PathPoint point, float w, float extendedLen, float aa, int nCap)
    {
        var vertices = new List<Vertex>();
        var dx = point.Dx;
        var dy = point.Dy;
        var px = point.X;
        var py = point.Y;
        var dlx = point.Dy;
        var dly = -point.Dx;
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

    private static Vertex[] GetEnd(this PathPoint point, LineCap lineCap, float w, float aa, int nCap) =>
        lineCap switch
        {
            LineCap.Butt => point.GetSquareEnd(w, -aa * 0.5f, aa),
            LineCap.Square => point.GetSquareEnd(w, w -aa, aa),
            LineCap.Round => point.GetRoundEnd(w, 0, aa, nCap),
            _ => throw new NotImplementedException()
        };
    
    private static Vertex[] GetSquareEnd(this PathPoint point, float w, float extendedLen, float aa)
    {
        var vertices = new List<Vertex>();
        var dx = point.Dx;
        var dy = point.Dy;
        var px = point.X - dx * extendedLen;
        var py = point.Y - dy * extendedLen;
        var dlx = point.Dy;
        var dly = -point.Dx;

        vertices.Add(new Vertex(px + dlx * w - dx * aa, py + dly * w - dy * aa, 0, 0));
        vertices.Add(new Vertex(px - dlx * w - dx * aa, py - dly * w - dy * aa, 1, 0));
        vertices.Add(new Vertex(px + dlx * w, py + dly * w, 0, 1));
        vertices.Add(new Vertex(px - dlx * w, py - dly * w, 1, 1));
        return vertices.ToArray();
    }
    
    private static Vertex[] GetRoundEnd(this PathPoint point, float w, float extendedLen, float aa, int nCap)
    {
        var vertices = new List<Vertex>();
        var dx = point.Dx;
        var dy = point.Dy;
        var px = point.X;
        var py = point.Y;
        var dlx = point.Dy;
        var dly = -point.Dx;

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

    private static Vertex[] GetJoin(this PathPoint point, PathPoint previewPoint, float w, LineJoin lineJoin)
    {
        if(point.Flags.Contains(PointFlags.Bevel) || point.Flags.Contains(PointFlags.InnerBevel))
        {
            if(lineJoin is LineJoin.Round)
            {
                return point. GetBevelJoin(previewPoint, w);
            }
            else
            {
                return point.GetBevelJoin(previewPoint, w);
            }
        }
        else
        {
            var vertices = new List<Vertex>();
            var dmx = point.Dmx;
            var dmy = point.Dmy;
            var px = point.X;
            var py = point.Y;

            vertices.Add(new Vertex(px + dmx * w, py + dmy * w, 0, 1));
            vertices.Add(new Vertex(px - dmx * w, py - dmy * w, 1, 1));

            return vertices.ToArray();
        }

    }

    private static Vertex[] GetBevelJoin(this PathPoint point, PathPoint previewPoint, float w)
    {
        var vertices = new List<Vertex>();
        float dlx0 = previewPoint.Dy;
        float dly0 = -previewPoint.Dx;
        float dlx1 = point.Dy;
        float dly1 = -point.Dx;

        float lu = 0;
        float ru = 1;


        if(point.Flags.Contains(PointFlags.Left))
        {
            var (lx0, ly0, lx1, ly1) = point.ChooseBevel(previewPoint, w);
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
                var rx0 = point.X - point.Dmx * w;
                var ry0 = point.Y - point.Dmy * w;
                
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

        }

        return vertices.ToArray();
    }

    private static (float x0, float y0, float x1, float y1) ChooseBevel(this PathPoint point, PathPoint previewPoint, float w)
    {
        
			if (point.Flags is PointFlags.Null)
			{
				var x0 = point.X + point.Dmx * w;
				var y0 = point.Y + point.Dmy * w;
				var x1 = point.X + point.Dmx * w;
				var y1 = point.Y + point.Dmy * w;
                return (x0, y0, x1, y1);
			}
			else
			{
				var x0 = point.X + previewPoint.Dy * w;
				var y0 = point.Y - previewPoint.Dx * w;
				var x1 = point.X + point.Dy * w;
				var y1 = point.Y - point.Dx * w;
                return (x0, y0, x1, y1);
			}
    }


    private static Vertex[] GetClosedVertex(this Path path, Context context)
    {
        var state = context.GetState();
        int nCap = context.CurveDivs(state);

        return [];
    }

    private static void CalculateJoins(this Path path, Context context)
    {
        var points = path.Points;

        var leftCount = 0;

        var lastPoint = points.LastOrDefault() is PathPoint lastPointTemp ? lastPointTemp : throw new Exception("The last point is null");
        foreach (var point in points)
        {
            var dlx0 = lastPoint.Dy;
            var dly0 = -lastPoint.Dx; 
            var dlx1 = point.Dy;
            var dly1 = -point.Dx; 

            var dmx = (dlx0 + dlx1) / 2f;
            var dmy = (dly0 + dly1) / 2f;
            var dmr2 = (float)Math.Pow(dmx, 2) + (float)Math.Pow(dmy, 2);
            if (dmr2 > 0.1e-6f)
            {
                float scale = 1.0f / dmr2;
                if (scale > 600.0f)
                {
                    scale = 600.0f;
                }
                point.Dmx = dmx * scale;
                point.Dmy = dmy * scale;
            }

            // Clear flags, but keep the corner.
            point.Flags = (point.Flags & PointFlags.Corner) != PointFlags.Null ? PointFlags.Corner : PointFlags.Null;

            // Keep track of left turns.
            var cross = point.Dx * lastPoint.Dy - lastPoint.Dx * point.Dy;
            if (cross > 0.0f)
            {
                leftCount++;
                point.Flags |= PointFlags.Left;
            }

            // Calculate if we should use bevel or miter for inner join.
            var strokeWidth = context.GetState().StrokeWidth;
            var miterLimit = context.GetState().MiterLimit;
            var lineJoin = context.GetState().LineJoin;
			var iw = 0.0f;
			if (strokeWidth > 0.0f)
				iw = 1.0f / strokeWidth;
            var limit = Math.Max(1.01f, Math.Min(lastPoint.Len, point.Len) * iw);
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

            if (point.Flags.Contains(PointFlags.Bevel | PointFlags.InnerBevel))
                path.BevelCount++;

            lastPoint = point;
        }
        path.IsConvex = leftCount == points.Length;

    }



}