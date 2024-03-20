namespace OpenGL.Graphics.ES20;

public enum TextureParameterName
{
    //
    // Summary:
    //     Original was GL_TEXTURE_WIDTH = 0x1000
    TextureWidth = 4096,
    //
    // Summary:
    //     Original was GL_TEXTURE_HEIGHT = 0x1001
    TextureHeight = 4097,
    //
    // Summary:
    //     Original was GL_TEXTURE_COMPONENTS = 0x1003
    TextureComponents = 4099,
    //
    // Summary:
    //     Original was GL_TEXTURE_INTERNAL_FORMAT = 0x1003
    TextureInternalFormat = 4099,
    //
    // Summary:
    //     Original was GL_TEXTURE_BORDER_COLOR = 0x1004
    TextureBorderColor = 4100,
    //
    // Summary:
    //     [requires: NV_texture_border_clamp] Original was GL_TEXTURE_BORDER_COLOR_NV =
    //     0x1004
    TextureBorderColorNv = 4100,
    //
    // Summary:
    //     Original was GL_TEXTURE_BORDER = 0x1005
    TextureBorder = 4101,
    //
    // Summary:
    //     Original was GL_TEXTURE_MAG_FILTER = 0x2800
    TextureMagFilter = 10240,
    //
    // Summary:
    //     Original was GL_TEXTURE_MIN_FILTER = 0x2801
    TextureMinFilter = 10241,
    //
    // Summary:
    //     Original was GL_TEXTURE_WRAP_S = 0x2802
    TextureWrapS = 10242,
    //
    // Summary:
    //     Original was GL_TEXTURE_WRAP_T = 0x2803
    TextureWrapT = 10243,
    //
    // Summary:
    //     Original was GL_TEXTURE_RED_SIZE = 0x805C
    TextureRedSize = 32860,
    //
    // Summary:
    //     Original was GL_TEXTURE_GREEN_SIZE = 0x805D
    TextureGreenSize = 32861,
    //
    // Summary:
    //     Original was GL_TEXTURE_BLUE_SIZE = 0x805E
    TextureBlueSize = 32862,
    //
    // Summary:
    //     Original was GL_TEXTURE_ALPHA_SIZE = 0x805F
    TextureAlphaSize = 32863,
    //
    // Summary:
    //     Original was GL_TEXTURE_LUMINANCE_SIZE = 0x8060
    TextureLuminanceSize = 32864,
    //
    // Summary:
    //     Original was GL_TEXTURE_INTENSITY_SIZE = 0x8061
    TextureIntensitySize = 32865,
    //
    // Summary:
    //     Original was GL_TEXTURE_PRIORITY = 0x8066
    TexturePriority = 32870,
    //
    // Summary:
    //     Original was GL_TEXTURE_PRIORITY_EXT = 0x8066
    TexturePriorityExt = 32870,
    //
    // Summary:
    //     Original was GL_TEXTURE_RESIDENT = 0x8067
    TextureResident = 32871,
    //
    // Summary:
    //     Original was GL_TEXTURE_DEPTH_EXT = 0x8071
    TextureDepthExt = 32881,
    //
    // Summary:
    //     Original was GL_TEXTURE_WRAP_R = 0x8072
    TextureWrapR = 32882,
    //
    // Summary:
    //     Original was GL_TEXTURE_WRAP_R_EXT = 0x8072
    TextureWrapRExt = 32882,
    //
    // Summary:
    //     [requires: OES_texture_3D] Original was GL_TEXTURE_WRAP_R_OES = 0x8072
    TextureWrapROes = 32882,
    //
    // Summary:
    //     Original was GL_DETAIL_TEXTURE_LEVEL_SGIS = 0x809A
    DetailTextureLevelSgis = 32922,
    //
    // Summary:
    //     Original was GL_DETAIL_TEXTURE_MODE_SGIS = 0x809B
    DetailTextureModeSgis = 32923,
    //
    // Summary:
    //     Original was GL_DETAIL_TEXTURE_FUNC_POINTS_SGIS = 0x809C
    DetailTextureFuncPointsSgis = 32924,
    //
    // Summary:
    //     Original was GL_SHARPEN_TEXTURE_FUNC_POINTS_SGIS = 0x80B0
    SharpenTextureFuncPointsSgis = 32944,
    //
    // Summary:
    //     Original was GL_SHADOW_AMBIENT_SGIX = 0x80BF
    ShadowAmbientSgix = 32959,
    //
    // Summary:
    //     Original was GL_DUAL_TEXTURE_SELECT_SGIS = 0x8124
    DualTextureSelectSgis = 33060,
    //
    // Summary:
    //     Original was GL_QUAD_TEXTURE_SELECT_SGIS = 0x8125
    QuadTextureSelectSgis = 33061,
    //
    // Summary:
    //     Original was GL_TEXTURE_4DSIZE_SGIS = 0x8136
    Texture4DsizeSgis = 33078,
    //
    // Summary:
    //     Original was GL_TEXTURE_WRAP_Q_SGIS = 0x8137
    TextureWrapQSgis = 33079,
    //
    // Summary:
    //     Original was GL_TEXTURE_MIN_LOD = 0x813A
    TextureMinLod = 33082,
    //
    // Summary:
    //     Original was GL_TEXTURE_MIN_LOD_SGIS = 0x813A
    TextureMinLodSgis = 33082,
    //
    // Summary:
    //     Original was GL_TEXTURE_MAX_LOD = 0x813B
    TextureMaxLod = 33083,
    //
    // Summary:
    //     Original was GL_TEXTURE_MAX_LOD_SGIS = 0x813B
    TextureMaxLodSgis = 33083,
    //
    // Summary:
    //     Original was GL_TEXTURE_BASE_LEVEL = 0x813C
    TextureBaseLevel = 33084,
    //
    // Summary:
    //     Original was GL_TEXTURE_BASE_LEVEL_SGIS = 0x813C
    TextureBaseLevelSgis = 33084,
    //
    // Summary:
    //     Original was GL_TEXTURE_MAX_LEVEL = 0x813D
    TextureMaxLevel = 33085,
    //
    // Summary:
    //     Original was GL_TEXTURE_MAX_LEVEL_SGIS = 0x813D
    TextureMaxLevelSgis = 33085,
    //
    // Summary:
    //     Original was GL_TEXTURE_FILTER4_SIZE_SGIS = 0x8147
    TextureFilter4SizeSgis = 33095,
    //
    // Summary:
    //     Original was GL_TEXTURE_CLIPMAP_CENTER_SGIX = 0x8171
    TextureClipmapCenterSgix = 33137,
    //
    // Summary:
    //     Original was GL_TEXTURE_CLIPMAP_FRAME_SGIX = 0x8172
    TextureClipmapFrameSgix = 33138,
    //
    // Summary:
    //     Original was GL_TEXTURE_CLIPMAP_OFFSET_SGIX = 0x8173
    TextureClipmapOffsetSgix = 33139,
    //
    // Summary:
    //     Original was GL_TEXTURE_CLIPMAP_VIRTUAL_DEPTH_SGIX = 0x8174
    TextureClipmapVirtualDepthSgix = 33140,
    //
    // Summary:
    //     Original was GL_TEXTURE_CLIPMAP_LOD_OFFSET_SGIX = 0x8175
    TextureClipmapLodOffsetSgix = 33141,
    //
    // Summary:
    //     Original was GL_TEXTURE_CLIPMAP_DEPTH_SGIX = 0x8176
    TextureClipmapDepthSgix = 33142,
    //
    // Summary:
    //     Original was GL_POST_TEXTURE_FILTER_BIAS_SGIX = 0x8179
    PostTextureFilterBiasSgix = 33145,
    //
    // Summary:
    //     Original was GL_POST_TEXTURE_FILTER_SCALE_SGIX = 0x817A
    PostTextureFilterScaleSgix = 33146,
    //
    // Summary:
    //     Original was GL_TEXTURE_LOD_BIAS_S_SGIX = 0x818E
    TextureLodBiasSSgix = 33166,
    //
    // Summary:
    //     Original was GL_TEXTURE_LOD_BIAS_T_SGIX = 0x818F
    TextureLodBiasTSgix = 33167,
    //
    // Summary:
    //     Original was GL_TEXTURE_LOD_BIAS_R_SGIX = 0x8190
    TextureLodBiasRSgix = 33168,
    //
    // Summary:
    //     Original was GL_GENERATE_MIPMAP = 0x8191
    GenerateMipmap = 33169,
    //
    // Summary:
    //     Original was GL_GENERATE_MIPMAP_SGIS = 0x8191
    GenerateMipmapSgis = 33169,
    //
    // Summary:
    //     Original was GL_TEXTURE_COMPARE_SGIX = 0x819A
    TextureCompareSgix = 33178,
    //
    // Summary:
    //     Original was GL_TEXTURE_COMPARE_OPERATOR_SGIX = 0x819B
    TextureCompareOperatorSgix = 33179,
    //
    // Summary:
    //     Original was GL_TEXTURE_LEQUAL_R_SGIX = 0x819C
    TextureLequalRSgix = 33180,
    //
    // Summary:
    //     Original was GL_TEXTURE_GEQUAL_R_SGIX = 0x819D
    TextureGequalRSgix = 33181,
    //
    // Summary:
    //     Original was GL_TEXTURE_MAX_CLAMP_S_SGIX = 0x8369
    TextureMaxClampSSgix = 33641,
    //
    // Summary:
    //     Original was GL_TEXTURE_MAX_CLAMP_T_SGIX = 0x836A
    TextureMaxClampTSgix = 33642,
    //
    // Summary:
    //     Original was GL_TEXTURE_MAX_CLAMP_R_SGIX = 0x836B
    TextureMaxClampRSgix = 33643,
    //
    // Summary:
    //     Original was GL_TEXTURE_LOD_BIAS = 0x8501
    TextureLodBias = 34049,
    //
    // Summary:
    //     Original was GL_TEXTURE_COMPARE_MODE = 0x884C
    TextureCompareMode = 34892,
    //
    // Summary:
    //     Original was GL_TEXTURE_COMPARE_FUNC = 0x884D
    TextureCompareFunc = 34893,
    //
    // Summary:
    //     Original was GL_TEXTURE_SWIZZLE_R = 0x8E42
    TextureSwizzleR = 36418,
    //
    // Summary:
    //     Original was GL_TEXTURE_SWIZZLE_G = 0x8E43
    TextureSwizzleG = 36419,
    //
    // Summary:
    //     Original was GL_TEXTURE_SWIZZLE_B = 0x8E44
    TextureSwizzleB = 36420,
    //
    // Summary:
    //     Original was GL_TEXTURE_SWIZZLE_A = 0x8E45
    TextureSwizzleA = 36421,
    //
    // Summary:
    //     Original was GL_TEXTURE_SWIZZLE_RGBA = 0x8E46
    TextureSwizzleRgba = 36422,
    //
    // Summary:
    //     Original was GL_DEPTH_STENCIL_TEXTURE_MODE = 0x90EA
    DepthStencilTextureMode = 37098,
    //
    // Summary:
    //     [requires: EXT_memory_object] Original was GL_TEXTURE_TILING_EXT = 0x9580
    TextureTilingExt = 38272
}