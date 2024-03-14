namespace Arc.Core;

public static class FillCalculator
{
    internal static Vertex[] ToFillVertex(this Segment segment, int nCap, float fringeWidth)
    {
        return segment.GetClosedFillVertex(nCap, fringeWidth);
    }
    private static Vertex[] GetClosedFillVertex(this Segment segment, int nCap, float fringeWidth)
    {
        // var state = segment.Path.State;

        // var lineCap = state.LineCap;
        // var lineJoin = state.LineJoin;

        // var strokeWidth = state.StrokeWidth;
        // var w = strokeWidth * 0.5f + fringeWidth * 0.5f;
        
        // var result = new List<Vertex>();
        // var innerPoints = segment.Points.ToList();
        // //Enforce close the path when generating the vertices
        // innerPoints.Add(segment.Points.First());
        // foreach (var innerPoint in innerPoints)
        // {
        //     var innerPointVertices = innerPoint.GetJoin(w, lineJoin, nCap);
        //     result.AddRange(innerPointVertices);
        // }
        return [];
    }
    
}