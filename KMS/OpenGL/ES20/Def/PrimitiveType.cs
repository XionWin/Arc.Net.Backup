namespace OpenGL.Graphics.ES20;

public enum PrimitiveType
{
    //
    // Summary:
    //     Original was GL_POINTS = 0x0000
    Points = 0,
    //
    // Summary:
    //     Original was GL_LINES = 0x0001
    Lines = 1,
    //
    // Summary:
    //     Original was GL_LINE_LOOP = 0x0002
    LineLoop = 2,
    //
    // Summary:
    //     Original was GL_LINE_STRIP = 0x0003
    LineStrip = 3,
    //
    // Summary:
    //     [requires: EXT_tessellation_shader, or OES_tessellation_shader] Original was
    //     GL_TRIANGLES = 0x0004
    Triangles = 4,
    //
    // Summary:
    //     Original was GL_TRIANGLE_STRIP = 0x0005
    TriangleStrip = 5,
    //
    // Summary:
    //     Original was GL_TRIANGLE_FAN = 0x0006
    TriangleFan = 6,
    //
    // Summary:
    //     Original was GL_QUADS = 0x0007
    Quads = 7,
    //
    // Summary:
    //     [requires: EXT_tessellation_shader] Original was GL_QUADS_EXT = 0x0007
    QuadsExt = 7,
    //
    // Summary:
    //     Original was GL_QUAD_STRIP = 0x0008
    QuadStrip = 8,
    //
    // Summary:
    //     Original was GL_POLYGON = 0x0009
    Polygon = 9,
    //
    // Summary:
    //     Original was GL_LINES_ADJACENCY = 0x000A
    LinesAdjacency = 10,
    //
    // Summary:
    //     Original was GL_LINES_ADJACENCY_ARB = 0x000A
    LinesAdjacencyArb = 10,
    //
    // Summary:
    //     [requires: EXT_geometry_shader] Original was GL_LINES_ADJACENCY_EXT = 0x000A
    LinesAdjacencyExt = 10,
    //
    // Summary:
    //     Original was GL_LINE_STRIP_ADJACENCY = 0x000B
    LineStripAdjacency = 11,
    //
    // Summary:
    //     Original was GL_LINE_STRIP_ADJACENCY_ARB = 0x000B
    LineStripAdjacencyArb = 11,
    //
    // Summary:
    //     [requires: EXT_geometry_shader] Original was GL_LINE_STRIP_ADJACENCY_EXT = 0x000B
    LineStripAdjacencyExt = 11,
    //
    // Summary:
    //     Original was GL_TRIANGLES_ADJACENCY = 0x000C
    TrianglesAdjacency = 12,
    //
    // Summary:
    //     Original was GL_TRIANGLES_ADJACENCY_ARB = 0x000C
    TrianglesAdjacencyArb = 12,
    //
    // Summary:
    //     [requires: EXT_geometry_shader] Original was GL_TRIANGLES_ADJACENCY_EXT = 0x000C
    TrianglesAdjacencyExt = 12,
    //
    // Summary:
    //     Original was GL_TRIANGLE_STRIP_ADJACENCY = 0x000D
    TriangleStripAdjacency = 13,
    //
    // Summary:
    //     Original was GL_TRIANGLE_STRIP_ADJACENCY_ARB = 0x000D
    TriangleStripAdjacencyArb = 13,
    //
    // Summary:
    //     [requires: EXT_geometry_shader] Original was GL_TRIANGLE_STRIP_ADJACENCY_EXT
    //     = 0x000D
    TriangleStripAdjacencyExt = 13,
    //
    // Summary:
    //     [requires: NV_gpu_shader5] Original was GL_PATCHES = 0x000E
    Patches = 14,
    //
    // Summary:
    //     [requires: EXT_tessellation_shader] Original was GL_PATCHES_EXT = 0x000E
    PatchesExt = 14
}