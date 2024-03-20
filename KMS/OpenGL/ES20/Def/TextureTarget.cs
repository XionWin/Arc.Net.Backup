namespace OpenGL.Graphics.ES20;

public enum TextureTarget
{
    //
    // Summary:
    //     Original was GL_TEXTURE_1D = 0x0DE0
    Texture1D = 3552,
    //
    // Summary:
    //     [requires: EXT_sparse_texture] Original was GL_TEXTURE_2D = 0x0DE1
    Texture2D = 3553,
    //
    // Summary:
    //     Original was GL_PROXY_TEXTURE_1D = 0x8063
    ProxyTexture1D = 32867,
    //
    // Summary:
    //     Original was GL_PROXY_TEXTURE_1D_EXT = 0x8063
    ProxyTexture1DExt = 32867,
    //
    // Summary:
    //     Original was GL_PROXY_TEXTURE_2D = 0x8064
    ProxyTexture2D = 32868,
    //
    // Summary:
    //     Original was GL_PROXY_TEXTURE_2D_EXT = 0x8064
    ProxyTexture2DExt = 32868,
    //
    // Summary:
    //     [requires: EXT_sparse_texture] Original was GL_TEXTURE_3D = 0x806F
    Texture3D = 32879,
    //
    // Summary:
    //     Original was GL_TEXTURE_3D_EXT = 0x806F
    Texture3DExt = 32879,
    //
    // Summary:
    //     [requires: OES_texture_3D] Original was GL_TEXTURE_3D_OES = 0x806F
    Texture3DOes = 32879,
    //
    // Summary:
    //     Original was GL_PROXY_TEXTURE_3D = 0x8070
    ProxyTexture3D = 32880,
    //
    // Summary:
    //     Original was GL_PROXY_TEXTURE_3D_EXT = 0x8070
    ProxyTexture3DExt = 32880,
    //
    // Summary:
    //     Original was GL_DETAIL_TEXTURE_2D_SGIS = 0x8095
    DetailTexture2DSgis = 32917,
    //
    // Summary:
    //     Original was GL_TEXTURE_4D_SGIS = 0x8134
    Texture4DSgis = 33076,
    //
    // Summary:
    //     Original was GL_PROXY_TEXTURE_4D_SGIS = 0x8135
    ProxyTexture4DSgis = 33077,
    //
    // Summary:
    //     Original was GL_TEXTURE_RECTANGLE = 0x84F5
    TextureRectangle = 34037,
    //
    // Summary:
    //     Original was GL_PROXY_TEXTURE_RECTANGLE = 0x84F7
    ProxyTextureRectangle = 34039,
    //
    // Summary:
    //     Original was GL_PROXY_TEXTURE_RECTANGLE_ARB = 0x84F7
    ProxyTextureRectangleArb = 34039,
    //
    // Summary:
    //     Original was GL_PROXY_TEXTURE_RECTANGLE_NV = 0x84F7
    ProxyTextureRectangleNv = 34039,
    //
    // Summary:
    //     [requires: EXT_sparse_texture] Original was GL_TEXTURE_CUBE_MAP = 0x8513
    TextureCubeMap = 34067,
    //
    // Summary:
    //     Original was GL_TEXTURE_CUBE_MAP_POSITIVE_X = 0x8515
    TextureCubeMapPositiveX = 34069,
    //
    // Summary:
    //     Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_X = 0x8516
    TextureCubeMapNegativeX = 34070,
    //
    // Summary:
    //     Original was GL_TEXTURE_CUBE_MAP_POSITIVE_Y = 0x8517
    TextureCubeMapPositiveY = 34071,
    //
    // Summary:
    //     Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x8518
    TextureCubeMapNegativeY = 34072,
    //
    // Summary:
    //     Original was GL_TEXTURE_CUBE_MAP_POSITIVE_Z = 0x8519
    TextureCubeMapPositiveZ = 34073,
    //
    // Summary:
    //     Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x851A
    TextureCubeMapNegativeZ = 34074,
    //
    // Summary:
    //     Original was GL_PROXY_TEXTURE_CUBE_MAP = 0x851B
    ProxyTextureCubeMap = 34075,
    //
    // Summary:
    //     Original was GL_PROXY_TEXTURE_CUBE_MAP_ARB = 0x851B
    ProxyTextureCubeMapArb = 34075,
    //
    // Summary:
    //     Original was GL_PROXY_TEXTURE_CUBE_MAP_EXT = 0x851B
    ProxyTextureCubeMapExt = 34075,
    //
    // Summary:
    //     Original was GL_TEXTURE_1D_ARRAY = 0x8C18
    Texture1DArray = 35864,
    //
    // Summary:
    //     Original was GL_PROXY_TEXTURE_1D_ARRAY = 0x8C19
    ProxyTexture1DArray = 35865,
    //
    // Summary:
    //     Original was GL_PROXY_TEXTURE_1D_ARRAY_EXT = 0x8C19
    ProxyTexture1DArrayExt = 35865,
    //
    // Summary:
    //     [requires: EXT_sparse_texture] Original was GL_TEXTURE_2D_ARRAY = 0x8C1A
    Texture2DArray = 35866,
    //
    // Summary:
    //     Original was GL_PROXY_TEXTURE_2D_ARRAY = 0x8C1B
    ProxyTexture2DArray = 35867,
    //
    // Summary:
    //     Original was GL_PROXY_TEXTURE_2D_ARRAY_EXT = 0x8C1B
    ProxyTexture2DArrayExt = 35867,
    //
    // Summary:
    //     Original was GL_TEXTURE_CUBE_MAP_ARRAY = 0x9009
    TextureCubeMapArray = 36873,
    //
    // Summary:
    //     Original was GL_TEXTURE_CUBE_MAP_ARRAY_ARB = 0x9009
    TextureCubeMapArrayArb = 36873,
    //
    // Summary:
    //     [requires: EXT_texture_cube_map_array] Original was GL_TEXTURE_CUBE_MAP_ARRAY_EXT
    //     = 0x9009
    TextureCubeMapArrayExt = 36873,
    //
    // Summary:
    //     [requires: EXT_sparse_texture, or OES_texture_cube_map_array] Original was GL_TEXTURE_CUBE_MAP_ARRAY_OES
    //     = 0x9009
    TextureCubeMapArrayOes = 36873,
    //
    // Summary:
    //     Original was GL_PROXY_TEXTURE_CUBE_MAP_ARRAY = 0x900B
    ProxyTextureCubeMapArray = 36875,
    //
    // Summary:
    //     Original was GL_PROXY_TEXTURE_CUBE_MAP_ARRAY_ARB = 0x900B
    ProxyTextureCubeMapArrayArb = 36875,
    //
    // Summary:
    //     [requires: NV_internalformat_sample_query] Original was GL_TEXTURE_2D_MULTISAMPLE
    //     = 0x9100
    Texture2DMultisample = 37120,
    //
    // Summary:
    //     Original was GL_PROXY_TEXTURE_2D_MULTISAMPLE = 0x9101
    ProxyTexture2DMultisample = 37121,
    //
    // Summary:
    //     [requires: NV_internalformat_sample_query] Original was GL_TEXTURE_2D_MULTISAMPLE_ARRAY
    //     = 0x9102
    Texture2DMultisampleArray = 37122,
    //
    // Summary:
    //     Original was GL_PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9103
    ProxyTexture2DMultisampleArray = 37123
}