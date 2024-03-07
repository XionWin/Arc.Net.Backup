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

        return [];
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

        // var innerPoints = segment.Points.Skip(1).Take(segment.Points.Length - 2).ToArray();
        // var previewPoint  =  segment.Points.FirstOrDefault() ?? throw new Exception("No preview point for the innerPoint");
        // foreach (var innerPoint in innerPoints)
        // {
        //     var innerPointVertices = innerPoint.GetJoin(previewPoint, w, lineJoin);
        //     result.AddRange(innerPointVertices);
        //     previewPoint = innerPoint;
        // }

        // // Add end cap
        // var endPoint = path.Points.LastOrDefault() ?? throw new Exception("No end point in this path");
        // var endCapVertices = endPoint.GetEnd(lineCap, w, aa, nCap);
        // result.AddRange(endCapVertices);

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
}