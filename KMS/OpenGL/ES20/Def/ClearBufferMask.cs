namespace OpenGL.Graphics.ES20;

[Flags]
public enum ClearBufferMask
{
    //
    // Summary:
    //     Original was GL_DEPTH_BUFFER_BIT = 0x00000100
    DepthBufferBit = 0x100,
    //
    // Summary:
    //     Original was GL_ACCUM_BUFFER_BIT = 0x00000200
    AccumBufferBit = 0x200,
    //
    // Summary:
    //     Original was GL_STENCIL_BUFFER_BIT = 0x00000400
    StencilBufferBit = 0x400,
    //
    // Summary:
    //     Original was GL_COLOR_BUFFER_BIT = 0x00004000
    ColorBufferBit = 0x4000,
    //
    // Summary:
    //     [requires: NV_coverage_sample] Original was GL_COVERAGE_BUFFER_BIT_NV = 0x00008000
    CoverageBufferBitNv = 0x8000
}