namespace OpenGL.Graphics.ES20;

public enum TextureComponentCount
{
    //
    // Summary:
    //     Original was GL_ALPHA = 0X1906
    Alpha = 6406,
    //
    // Summary:
    //     Original was GL_RGB = 0X1907
    Rgb = 6407,
    //
    // Summary:
    //     Original was GL_RGBA = 0X1908
    Rgba = 6408,
    //
    // Summary:
    //     Original was GL_LUMINANCE = 0X1909
    Luminance = 6409,
    //
    // Summary:
    //     Original was GL_LUMINANCE_ALPHA = 0x190A
    LuminanceAlpha = 6410,
    //
    // Summary:
    //     [requires: EXT_texture_storage] Original was GL_ALPHA8_EXT = 0x803C
    Alpha8Ext = 32828,
    //
    // Summary:
    //     [requires: EXT_texture_storage] Original was GL_LUMINANCE8_EXT = 0x8040
    Luminance8Ext = 32832,
    //
    // Summary:
    //     [requires: EXT_texture_storage] Original was GL_LUMINANCE8_ALPHA8_EXT = 0x8045
    Luminance8Alpha8Ext = 32837,
    //
    // Summary:
    //     [requires: EXT_texture_storage, or OES_required_internalformat] Original was
    //     GL_RGB10_EXT = 0x8052
    Rgb10Ext = 32850,
    //
    // Summary:
    //     [requires: EXT_texture_storage, or OES_required_internalformat] Original was
    //     GL_RGB10_A2_EXT = 0x8059
    Rgb10A2Ext = 32857,
    //
    // Summary:
    //     [requires: EXT_texture_rg, or EXT_texture_storage] Original was GL_R8_EXT = 0x8229
    R8Ext = 33321,
    //
    // Summary:
    //     [requires: EXT_texture_rg, or EXT_texture_storage] Original was GL_RG8_EXT =
    //     0x822B
    Rg8Ext = 33323,
    //
    // Summary:
    //     [requires: EXT_color_buffer_half_float, or EXT_texture_storage] Original was
    //     GL_R16F_EXT = 0x822D
    R16fExt = 33325,
    //
    // Summary:
    //     [requires: EXT_texture_storage] Original was GL_R32F_EXT = 0x822E
    R32fExt = 33326,
    //
    // Summary:
    //     [requires: EXT_color_buffer_half_float, or EXT_texture_storage] Original was
    //     GL_RG16F_EXT = 0x822F
    Rg16fExt = 33327,
    //
    // Summary:
    //     [requires: EXT_texture_storage] Original was GL_RG32F_EXT = 0x8230
    Rg32fExt = 33328,
    //
    // Summary:
    //     [requires: EXT_texture_storage] Original was GL_RGBA32F_EXT = 0x8814
    Rgba32fExt = 34836,
    //
    // Summary:
    //     [requires: EXT_texture_storage] Original was GL_RGB32F_EXT = 0x8815
    Rgb32fExt = 34837,
    //
    // Summary:
    //     [requires: EXT_texture_storage] Original was GL_ALPHA32F_EXT = 0x8816
    Alpha32fExt = 34838,
    //
    // Summary:
    //     [requires: EXT_texture_storage] Original was GL_LUMINANCE32F_EXT = 0x8818
    Luminance32fExt = 34840,
    //
    // Summary:
    //     [requires: EXT_texture_storage] Original was GL_LUMINANCE_ALPHA32F_EXT = 0x8819
    LuminanceAlpha32fExt = 34841,
    //
    // Summary:
    //     [requires: EXT_color_buffer_half_float, or EXT_texture_storage] Original was
    //     GL_RGBA16F_EXT = 0x881A
    Rgba16fExt = 34842,
    //
    // Summary:
    //     [requires: EXT_color_buffer_half_float, or EXT_texture_storage] Original was
    //     GL_RGB16F_EXT = 0x881B
    Rgb16fExt = 34843,
    //
    // Summary:
    //     [requires: EXT_texture_storage] Original was GL_ALPHA16F_EXT = 0x881C
    Alpha16fExt = 34844,
    //
    // Summary:
    //     [requires: EXT_texture_storage] Original was GL_LUMINANCE16F_EXT = 0x881E
    Luminance16fExt = 34846,
    //
    // Summary:
    //     [requires: EXT_texture_storage] Original was GL_LUMINANCE_ALPHA16F_EXT = 0x881F
    LuminanceAlpha16fExt = 34847,
    //
    // Summary:
    //     [requires: APPLE_rgb_422] Original was GL_RGB_RAW_422_APPLE = 0x8A51
    RgbRaw422Apple = 35409,
    //
    // Summary:
    //     [requires: APPLE_texture_format_BGRA8888, or EXT_texture_storage] Original was
    //     GL_BGRA8_EXT = 0x93A1
    Bgra8Ext = 37793
}
