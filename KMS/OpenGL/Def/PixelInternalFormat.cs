namespace OpenGL.Def
{
    //
    // Summary:
    //     Used in GL.ClearBufferData, GL.ClearBufferSubData and 12 other functions
    public enum PixelInternalFormat
    {
        //
        // Summary:
        //     [requires: v1.0] Original was GL_DEPTH_COMPONENT = 0x1902
        DepthComponent = 6402,
        //
        // Summary:
        //     [requires: v1.0] Original was GL_ALPHA = 0x1906
        Alpha = 6406,
        //
        // Summary:
        //     [requires: v1.0] Original was GL_RGB = 0x1907
        Rgb = 6407,
        //
        // Summary:
        //     [requires: v1.0] Original was GL_RGBA = 0x1908
        Rgba = 6408,
        //
        // Summary:
        //     Original was GL_LUMINANCE = 0x1909
        Luminance = 6409,
        //
        // Summary:
        //     Original was GL_LUMINANCE_ALPHA = 0x190A
        LuminanceAlpha = 6410,
        //
        // Summary:
        //     [requires: v1.1] Original was GL_R3_G3_B2 = 0x2A10
        R3G3B2 = 10768,
        //
        // Summary:
        //     Original was GL_RGB2_EXT = 0x804E
        Rgb2Ext = 32846,
        //
        // Summary:
        //     [requires: v1.1] Original was GL_RGB4 = 0x804F
        Rgb4 = 32847,
        //
        // Summary:
        //     [requires: v1.1] Original was GL_RGB5 = 0x8050
        Rgb5 = 32848,
        //
        // Summary:
        //     [requires: v1.1] Original was GL_RGB8 = 0x8051
        Rgb8 = 32849,
        //
        // Summary:
        //     [requires: v1.1] Original was GL_RGB10 = 0x8052
        Rgb10 = 32850,
        //
        // Summary:
        //     [requires: v1.1] Original was GL_RGB12 = 0x8053
        Rgb12 = 32851,
        //
        // Summary:
        //     [requires: v1.1] Original was GL_RGB16 = 0x8054
        Rgb16 = 32852,
        //
        // Summary:
        //     [requires: v1.1] Original was GL_RGBA2 = 0x8055
        Rgba2 = 32853,
        //
        // Summary:
        //     [requires: v1.1] Original was GL_RGBA4 = 0x8056
        Rgba4 = 32854,
        //
        // Summary:
        //     [requires: v1.1] Original was GL_RGB5_A1 = 0x8057
        Rgb5A1 = 32855,
        //
        // Summary:
        //     [requires: v1.1] Original was GL_RGBA8 = 0x8058
        Rgba8 = 32856,
        //
        // Summary:
        //     [requires: v1.1] Original was GL_RGB10_A2 = 0x8059
        Rgb10A2 = 32857,
        //
        // Summary:
        //     [requires: v1.1] Original was GL_RGBA12 = 0x805A
        Rgba12 = 32858,
        //
        // Summary:
        //     [requires: v1.1] Original was GL_RGBA16 = 0x805B
        Rgba16 = 32859,
        //
        // Summary:
        //     Original was GL_DUAL_ALPHA4_SGIS = 0x8110
        DualAlpha4Sgis = 33040,
        //
        // Summary:
        //     Original was GL_DUAL_ALPHA8_SGIS = 0x8111
        DualAlpha8Sgis = 33041,
        //
        // Summary:
        //     Original was GL_DUAL_ALPHA12_SGIS = 0x8112
        DualAlpha12Sgis = 33042,
        //
        // Summary:
        //     Original was GL_DUAL_ALPHA16_SGIS = 0x8113
        DualAlpha16Sgis = 33043,
        //
        // Summary:
        //     Original was GL_DUAL_LUMINANCE4_SGIS = 0x8114
        DualLuminance4Sgis = 33044,
        //
        // Summary:
        //     Original was GL_DUAL_LUMINANCE8_SGIS = 0x8115
        DualLuminance8Sgis = 33045,
        //
        // Summary:
        //     Original was GL_DUAL_LUMINANCE12_SGIS = 0x8116
        DualLuminance12Sgis = 33046,
        //
        // Summary:
        //     Original was GL_DUAL_LUMINANCE16_SGIS = 0x8117
        DualLuminance16Sgis = 33047,
        //
        // Summary:
        //     Original was GL_DUAL_INTENSITY4_SGIS = 0x8118
        DualIntensity4Sgis = 33048,
        //
        // Summary:
        //     Original was GL_DUAL_INTENSITY8_SGIS = 0x8119
        DualIntensity8Sgis = 33049,
        //
        // Summary:
        //     Original was GL_DUAL_INTENSITY12_SGIS = 0x811A
        DualIntensity12Sgis = 33050,
        //
        // Summary:
        //     Original was GL_DUAL_INTENSITY16_SGIS = 0x811B
        DualIntensity16Sgis = 33051,
        //
        // Summary:
        //     Original was GL_DUAL_LUMINANCE_ALPHA4_SGIS = 0x811C
        DualLuminanceAlpha4Sgis = 33052,
        //
        // Summary:
        //     Original was GL_DUAL_LUMINANCE_ALPHA8_SGIS = 0x811D
        DualLuminanceAlpha8Sgis = 33053,
        //
        // Summary:
        //     Original was GL_QUAD_ALPHA4_SGIS = 0x811E
        QuadAlpha4Sgis = 33054,
        //
        // Summary:
        //     Original was GL_QUAD_ALPHA8_SGIS = 0x811F
        QuadAlpha8Sgis = 33055,
        //
        // Summary:
        //     Original was GL_QUAD_LUMINANCE4_SGIS = 0x8120
        QuadLuminance4Sgis = 33056,
        //
        // Summary:
        //     Original was GL_QUAD_LUMINANCE8_SGIS = 0x8121
        QuadLuminance8Sgis = 33057,
        //
        // Summary:
        //     Original was GL_QUAD_INTENSITY4_SGIS = 0x8122
        QuadIntensity4Sgis = 33058,
        //
        // Summary:
        //     Original was GL_QUAD_INTENSITY8_SGIS = 0x8123
        QuadIntensity8Sgis = 33059,
        //
        // Summary:
        //     [requires: v1.4] Original was GL_DEPTH_COMPONENT16 = 0x81a5
        DepthComponent16 = 33189,
        //
        // Summary:
        //     Original was GL_DEPTH_COMPONENT16_SGIX = 0x81A5
        DepthComponent16Sgix = 33189,
        //
        // Summary:
        //     [requires: v1.4] Original was GL_DEPTH_COMPONENT24 = 0x81a6
        DepthComponent24 = 33190,
        //
        // Summary:
        //     Original was GL_DEPTH_COMPONENT24_SGIX = 0x81A6
        DepthComponent24Sgix = 33190,
        //
        // Summary:
        //     [requires: v1.4] Original was GL_DEPTH_COMPONENT32 = 0x81a7
        DepthComponent32 = 33191,
        //
        // Summary:
        //     Original was GL_DEPTH_COMPONENT32_SGIX = 0x81A7
        DepthComponent32Sgix = 33191,
        //
        // Summary:
        //     [requires: v3.0] Original was GL_COMPRESSED_RED = 0x8225
        CompressedRed = 33317,
        //
        // Summary:
        //     [requires: v3.0] Original was GL_COMPRESSED_RG = 0x8226
        CompressedRg = 33318,
        //
        // Summary:
        //     [requires: v3.0 or ARB_texture_rg] Original was GL_R8 = 0x8229
        R8 = 33321,
        //
        // Summary:
        //     [requires: v3.0 or ARB_texture_rg] Original was GL_R16 = 0x822A
        R16 = 33322,
        //
        // Summary:
        //     [requires: v3.0 or ARB_texture_rg] Original was GL_RG8 = 0x822B
        Rg8 = 33323,
        //
        // Summary:
        //     [requires: v3.0 or ARB_texture_rg] Original was GL_RG16 = 0x822C
        Rg16 = 33324,
        //
        // Summary:
        //     [requires: v3.0 or ARB_texture_rg] Original was GL_R16F = 0x822D
        R16f = 33325,
        //
        // Summary:
        //     [requires: v3.0 or ARB_texture_rg] Original was GL_R32F = 0x822E
        R32f = 33326,
        //
        // Summary:
        //     [requires: v3.0 or ARB_texture_rg] Original was GL_RG16F = 0x822F
        Rg16f = 33327,
        //
        // Summary:
        //     [requires: v3.0 or ARB_texture_rg] Original was GL_RG32F = 0x8230
        Rg32f = 33328,
        //
        // Summary:
        //     [requires: v3.0 or ARB_texture_rg] Original was GL_R8I = 0x8231
        R8i = 33329,
        //
        // Summary:
        //     [requires: v3.0 or ARB_texture_rg] Original was GL_R8UI = 0x8232
        R8ui = 33330,
        //
        // Summary:
        //     [requires: v3.0 or ARB_texture_rg] Original was GL_R16I = 0x8233
        R16i = 33331,
        //
        // Summary:
        //     [requires: v3.0 or ARB_texture_rg] Original was GL_R16UI = 0x8234
        R16ui = 33332,
        //
        // Summary:
        //     [requires: v3.0 or ARB_texture_rg] Original was GL_R32I = 0x8235
        R32i = 33333,
        //
        // Summary:
        //     [requires: v3.0 or ARB_texture_rg] Original was GL_R32UI = 0x8236
        R32ui = 33334,
        //
        // Summary:
        //     [requires: v3.0 or ARB_texture_rg] Original was GL_RG8I = 0x8237
        Rg8i = 33335,
        //
        // Summary:
        //     [requires: v3.0 or ARB_texture_rg] Original was GL_RG8UI = 0x8238
        Rg8ui = 33336,
        //
        // Summary:
        //     [requires: v3.0 or ARB_texture_rg] Original was GL_RG16I = 0x8239
        Rg16i = 33337,
        //
        // Summary:
        //     [requires: v3.0 or ARB_texture_rg] Original was GL_RG16UI = 0x823A
        Rg16ui = 33338,
        //
        // Summary:
        //     [requires: v3.0 or ARB_texture_rg] Original was GL_RG32I = 0x823B
        Rg32i = 33339,
        //
        // Summary:
        //     [requires: v3.0 or ARB_texture_rg] Original was GL_RG32UI = 0x823C
        Rg32ui = 33340,
        //
        // Summary:
        //     [requires: EXT_texture_compression_s3tc] Original was GL_COMPRESSED_RGB_S3TC_DXT1_EXT
        //     = 0x83F0
        CompressedRgbS3tcDxt1Ext = 33776,
        //
        // Summary:
        //     [requires: EXT_texture_compression_s3tc] Original was GL_COMPRESSED_RGBA_S3TC_DXT1_EXT
        //     = 0x83F1
        CompressedRgbaS3tcDxt1Ext = 33777,
        //
        // Summary:
        //     [requires: EXT_texture_compression_s3tc] Original was GL_COMPRESSED_RGBA_S3TC_DXT3_EXT
        //     = 0x83F2
        CompressedRgbaS3tcDxt3Ext = 33778,
        //
        // Summary:
        //     [requires: EXT_texture_compression_s3tc] Original was GL_COMPRESSED_RGBA_S3TC_DXT5_EXT
        //     = 0x83F3
        CompressedRgbaS3tcDxt5Ext = 33779,
        //
        // Summary:
        //     [requires: SGIX_icc_texture] Original was GL_RGB_ICC_SGIX = 0x8460
        RgbIccSgix = 33888,
        //
        // Summary:
        //     [requires: SGIX_icc_texture] Original was GL_RGBA_ICC_SGIX = 0x8461
        RgbaIccSgix = 33889,
        //
        // Summary:
        //     [requires: SGIX_icc_texture] Original was GL_ALPHA_ICC_SGIX = 0x8462
        AlphaIccSgix = 33890,
        //
        // Summary:
        //     [requires: SGIX_icc_texture] Original was GL_LUMINANCE_ICC_SGIX = 0x8463
        LuminanceIccSgix = 33891,
        //
        // Summary:
        //     [requires: SGIX_icc_texture] Original was GL_INTENSITY_ICC_SGIX = 0x8464
        IntensityIccSgix = 33892,
        //
        // Summary:
        //     [requires: SGIX_icc_texture] Original was GL_LUMINANCE_ALPHA_ICC_SGIX = 0x8465
        LuminanceAlphaIccSgix = 33893,
        //
        // Summary:
        //     [requires: SGIX_icc_texture] Original was GL_R5_G6_B5_ICC_SGIX = 0x8466
        R5G6B5IccSgix = 33894,
        //
        // Summary:
        //     [requires: SGIX_icc_texture] Original was GL_R5_G6_B5_A8_ICC_SGIX = 0x8467
        R5G6B5A8IccSgix = 33895,
        //
        // Summary:
        //     [requires: SGIX_icc_texture] Original was GL_ALPHA16_ICC_SGIX = 0x8468
        Alpha16IccSgix = 33896,
        //
        // Summary:
        //     [requires: SGIX_icc_texture] Original was GL_LUMINANCE16_ICC_SGIX = 0x8469
        Luminance16IccSgix = 33897,
        //
        // Summary:
        //     [requires: SGIX_icc_texture] Original was GL_INTENSITY16_ICC_SGIX = 0x846A
        Intensity16IccSgix = 33898,
        //
        // Summary:
        //     [requires: SGIX_icc_texture] Original was GL_LUMINANCE16_ALPHA8_ICC_SGIX = 0x846B
        Luminance16Alpha8IccSgix = 33899,
        //
        // Summary:
        //     Original was GL_COMPRESSED_ALPHA = 0x84E9
        CompressedAlpha = 34025,
        //
        // Summary:
        //     Original was GL_COMPRESSED_LUMINANCE = 0x84EA
        CompressedLuminance = 34026,
        //
        // Summary:
        //     Original was GL_COMPRESSED_LUMINANCE_ALPHA = 0x84EB
        CompressedLuminanceAlpha = 34027,
        //
        // Summary:
        //     Original was GL_COMPRESSED_INTENSITY = 0x84EC
        CompressedIntensity = 34028,
        //
        // Summary:
        //     [requires: v1.3] Original was GL_COMPRESSED_RGB = 0x84ED
        CompressedRgb = 34029,
        //
        // Summary:
        //     [requires: v1.3] Original was GL_COMPRESSED_RGBA = 0x84EE
        CompressedRgba = 34030,
        //
        // Summary:
        //     [requires: v3.0 or ARB_framebuffer_object] Original was GL_DEPTH_STENCIL = 0x84F9
        DepthStencil = 34041,
        //
        // Summary:
        //     [requires: v3.0] Original was GL_RGBA32F = 0x8814
        Rgba32f = 34836,
        //
        // Summary:
        //     [requires: v3.0 or ARB_texture_buffer_object_rgb32] Original was GL_RGB32F =
        //     0x8815
        Rgb32f = 34837,
        //
        // Summary:
        //     [requires: v3.0] Original was GL_RGBA16F = 0x881A
        Rgba16f = 34842,
        //
        // Summary:
        //     [requires: v3.0] Original was GL_RGB16F = 0x881B
        Rgb16f = 34843,
        //
        // Summary:
        //     [requires: v3.0 or ARB_framebuffer_object] Original was GL_DEPTH24_STENCIL8 =
        //     0x88F0
        Depth24Stencil8 = 35056,
        //
        // Summary:
        //     [requires: v3.0] Original was GL_R11F_G11F_B10F = 0x8C3A
        R11fG11fB10f = 35898,
        //
        // Summary:
        //     [requires: v3.0] Original was GL_RGB9_E5 = 0x8C3D
        Rgb9E5 = 35901,
        //
        // Summary:
        //     [requires: v2.1] Original was GL_SRGB = 0x8C40
        Srgb = 35904,
        //
        // Summary:
        //     [requires: v2.1] Original was GL_SRGB8 = 0x8C41
        Srgb8 = 35905,
        //
        // Summary:
        //     [requires: v2.1] Original was GL_SRGB_ALPHA = 0x8C42
        SrgbAlpha = 35906,
        //
        // Summary:
        //     [requires: v2.1] Original was GL_SRGB8_ALPHA8 = 0x8C43
        Srgb8Alpha8 = 35907,
        //
        // Summary:
        //     Original was GL_SLUMINANCE_ALPHA = 0x8C44
        SluminanceAlpha = 35908,
        //
        // Summary:
        //     Original was GL_SLUMINANCE8_ALPHA8 = 0x8C45
        Sluminance8Alpha8 = 35909,
        //
        // Summary:
        //     Original was GL_SLUMINANCE = 0x8C46
        Sluminance = 35910,
        //
        // Summary:
        //     Original was GL_SLUMINANCE8 = 0x8C47
        Sluminance8 = 35911,
        //
        // Summary:
        //     [requires: v2.1] Original was GL_COMPRESSED_SRGB = 0x8C48
        CompressedSrgb = 35912,
        //
        // Summary:
        //     [requires: v2.1] Original was GL_COMPRESSED_SRGB_ALPHA = 0x8C49
        CompressedSrgbAlpha = 35913,
        //
        // Summary:
        //     Original was GL_COMPRESSED_SLUMINANCE = 0x8C4A
        CompressedSluminance = 35914,
        //
        // Summary:
        //     Original was GL_COMPRESSED_SLUMINANCE_ALPHA = 0x8C4B
        CompressedSluminanceAlpha = 35915,
        //
        // Summary:
        //     Original was GL_COMPRESSED_SRGB_S3TC_DXT1_EXT = 0x8C4C
        CompressedSrgbS3tcDxt1Ext = 35916,
        //
        // Summary:
        //     Original was GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT = 0x8C4D
        CompressedSrgbAlphaS3tcDxt1Ext = 35917,
        //
        // Summary:
        //     Original was GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT3_EXT = 0x8C4E
        CompressedSrgbAlphaS3tcDxt3Ext = 35918,
        //
        // Summary:
        //     Original was GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT = 0x8C4F
        CompressedSrgbAlphaS3tcDxt5Ext = 35919,
        //
        // Summary:
        //     [requires: v3.0 or ARB_depth_buffer_float] Original was GL_DEPTH_COMPONENT32F
        //     = 0x8CAC
        DepthComponent32f = 36012,
        //
        // Summary:
        //     [requires: v3.0 or ARB_depth_buffer_float] Original was GL_DEPTH32F_STENCIL8
        //     = 0x8CAD
        Depth32fStencil8 = 36013,
        //
        // Summary:
        //     [requires: v3.0] Original was GL_RGBA32UI = 0x8D70
        Rgba32ui = 36208,
        //
        // Summary:
        //     [requires: v3.0 or ARB_texture_buffer_object_rgb32] Original was GL_RGB32UI =
        //     0x8D71
        Rgb32ui = 36209,
        //
        // Summary:
        //     [requires: v3.0] Original was GL_RGBA16UI = 0x8D76
        Rgba16ui = 36214,
        //
        // Summary:
        //     [requires: v3.0] Original was GL_RGB16UI = 0x8D77
        Rgb16ui = 36215,
        //
        // Summary:
        //     [requires: v3.0] Original was GL_RGBA8UI = 0x8D7C
        Rgba8ui = 36220,
        //
        // Summary:
        //     [requires: v3.0] Original was GL_RGB8UI = 0x8D7D
        Rgb8ui = 36221,
        //
        // Summary:
        //     [requires: v3.0] Original was GL_RGBA32I = 0x8D82
        Rgba32i = 36226,
        //
        // Summary:
        //     [requires: v3.0 or ARB_texture_buffer_object_rgb32, ARB_vertex_attrib_64bit]
        //     Original was GL_RGB32I = 0x8D83
        Rgb32i = 36227,
        //
        // Summary:
        //     [requires: v3.0] Original was GL_RGBA16I = 0x8D88
        Rgba16i = 36232,
        //
        // Summary:
        //     [requires: v3.0] Original was GL_RGB16I = 0x8D89
        Rgb16i = 36233,
        //
        // Summary:
        //     [requires: v3.0] Original was GL_RGBA8I = 0x8D8E
        Rgba8i = 36238,
        //
        // Summary:
        //     [requires: v3.0] Original was GL_RGB8I = 0x8D8F
        Rgb8i = 36239,
        //
        // Summary:
        //     [requires: v3.0 or ARB_depth_buffer_float] Original was GL_FLOAT_32_UNSIGNED_INT_24_8_REV
        //     = 0x8DAD
        Float32UnsignedInt248Rev = 36269,
        //
        // Summary:
        //     [requires: v3.0 or ARB_texture_compression_rgtc] Original was GL_COMPRESSED_RED_RGTC1
        //     = 0x8DBB
        CompressedRedRgtc1 = 36283,
        //
        // Summary:
        //     [requires: v3.0 or ARB_texture_compression_rgtc] Original was GL_COMPRESSED_SIGNED_RED_RGTC1
        //     = 0x8DBC
        CompressedSignedRedRgtc1 = 36284,
        //
        // Summary:
        //     [requires: v3.0 or ARB_texture_compression_rgtc] Original was GL_COMPRESSED_RG_RGTC2
        //     = 0x8DBD
        CompressedRgRgtc2 = 36285,
        //
        // Summary:
        //     [requires: v3.0 or ARB_texture_compression_rgtc] Original was GL_COMPRESSED_SIGNED_RG_RGTC2
        //     = 0x8DBE
        CompressedSignedRgRgtc2 = 36286,
        //
        // Summary:
        //     [requires: v4.2] Original was GL_COMPRESSED_RGBA_BPTC_UNORM = 0x8E8C
        CompressedRgbaBptcUnorm = 36492,
        //
        // Summary:
        //     [requires: v4.2] Original was GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM = 0x8E8D
        CompressedSrgbAlphaBptcUnorm = 36493,
        //
        // Summary:
        //     [requires: v4.2] Original was GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT = 0x8E8E
        CompressedRgbBptcSignedFloat = 36494,
        //
        // Summary:
        //     [requires: v4.2] Original was GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT = 0x8E8F
        CompressedRgbBptcUnsignedFloat = 36495,
        //
        // Summary:
        //     [requires: v3.1] Original was GL_R8_SNORM = 0x8F94
        R8Snorm = 36756,
        //
        // Summary:
        //     [requires: v3.1] Original was GL_RG8_SNORM = 0x8F95
        Rg8Snorm = 36757,
        //
        // Summary:
        //     [requires: v3.1] Original was GL_RGB8_SNORM = 0x8F96
        Rgb8Snorm = 36758,
        //
        // Summary:
        //     [requires: v3.1] Original was GL_RGBA8_SNORM = 0x8F97
        Rgba8Snorm = 36759,
        //
        // Summary:
        //     [requires: v3.1] Original was GL_R16_SNORM = 0x8F98
        R16Snorm = 36760,
        //
        // Summary:
        //     [requires: v3.1] Original was GL_RG16_SNORM = 0x8F99
        Rg16Snorm = 36761,
        //
        // Summary:
        //     [requires: v3.1] Original was GL_RGB16_SNORM = 0x8F9A
        Rgb16Snorm = 36762,
        //
        // Summary:
        //     [requires: v3.1] Original was GL_RGBA16_SNORM = 0x8F9B
        Rgba16Snorm = 36763,
        //
        // Summary:
        //     [requires: v3.3 or ARB_texture_rgb10_a2ui] Original was GL_RGB10_A2UI = 0x906F
        Rgb10A2ui = 36975,
        //
        // Summary:
        //     [requires: v1.0] Original was GL_ONE = 1
        One = 1,
        //
        // Summary:
        //     Original was GL_TWO = 2
        Two = 2,
        //
        // Summary:
        //     Original was GL_THREE = 3
        Three = 3,
        //
        // Summary:
        //     Original was GL_FOUR = 4
        Four = 4
    }
}
