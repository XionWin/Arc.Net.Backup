namespace OpenGL.Graphics.ES20;

public enum EnableCap
{
    //
    // Summary:
    //     Original was GL_POINT_SMOOTH = 0x0B10
    PointSmooth = 2832,
    //
    // Summary:
    //     Original was GL_LINE_SMOOTH = 0x0B20
    LineSmooth = 2848,
    //
    // Summary:
    //     Original was GL_LINE_STIPPLE = 0x0B24
    LineStipple = 2852,
    //
    // Summary:
    //     Original was GL_POLYGON_SMOOTH = 0x0B41
    PolygonSmooth = 2881,
    //
    // Summary:
    //     Original was GL_POLYGON_STIPPLE = 0x0B42
    PolygonStipple = 2882,
    //
    // Summary:
    //     Original was GL_CULL_FACE = 0x0B44
    CullFace = 2884,
    //
    // Summary:
    //     Original was GL_LIGHTING = 0x0B50
    Lighting = 2896,
    //
    // Summary:
    //     Original was GL_COLOR_MATERIAL = 0x0B57
    ColorMaterial = 2903,
    //
    // Summary:
    //     Original was GL_FOG = 0x0B60
    Fog = 2912,
    //
    // Summary:
    //     Original was GL_DEPTH_TEST = 0x0B71
    DepthTest = 2929,
    //
    // Summary:
    //     Original was GL_STENCIL_TEST = 0x0B90
    StencilTest = 2960,
    //
    // Summary:
    //     Original was GL_NORMALIZE = 0x0BA1
    Normalize = 2977,
    //
    // Summary:
    //     Original was GL_ALPHA_TEST = 0x0BC0
    AlphaTest = 3008,
    //
    // Summary:
    //     Original was GL_Dither = 0X0bd0
    Dither = 3024,
    //
    // Summary:
    //     Original was GL_Blend = 0X0be2
    Blend = 3042,
    //
    // Summary:
    //     Original was GL_INDEX_LOGIC_OP = 0x0BF1
    IndexLogicOp = 3057,
    //
    // Summary:
    //     Original was GL_COLOR_LOGIC_OP = 0x0BF2
    ColorLogicOp = 3058,
    //
    // Summary:
    //     [requires: NV_viewport_array, or OES_viewport_array] Original was GL_SCISSOR_TEST
    //     = 0x0C11
    ScissorTest = 3089,
    //
    // Summary:
    //     Original was GL_TEXTURE_GEN_S = 0x0C60
    TextureGenS = 3168,
    //
    // Summary:
    //     Original was GL_TEXTURE_GEN_T = 0x0C61
    TextureGenT = 3169,
    //
    // Summary:
    //     Original was GL_TEXTURE_GEN_R = 0x0C62
    TextureGenR = 3170,
    //
    // Summary:
    //     Original was GL_TEXTURE_GEN_Q = 0x0C63
    TextureGenQ = 3171,
    //
    // Summary:
    //     Original was GL_AUTO_NORMAL = 0x0D80
    AutoNormal = 3456,
    //
    // Summary:
    //     Original was GL_MAP1_COLOR_4 = 0x0D90
    Map1Color4 = 3472,
    //
    // Summary:
    //     Original was GL_MAP1_INDEX = 0x0D91
    Map1Index = 3473,
    //
    // Summary:
    //     Original was GL_MAP1_NORMAL = 0x0D92
    Map1Normal = 3474,
    //
    // Summary:
    //     Original was GL_MAP1_TEXTURE_COORD_1 = 0x0D93
    Map1TextureCoord1 = 3475,
    //
    // Summary:
    //     Original was GL_MAP1_TEXTURE_COORD_2 = 0x0D94
    Map1TextureCoord2 = 3476,
    //
    // Summary:
    //     Original was GL_MAP1_TEXTURE_COORD_3 = 0x0D95
    Map1TextureCoord3 = 3477,
    //
    // Summary:
    //     Original was GL_MAP1_TEXTURE_COORD_4 = 0x0D96
    Map1TextureCoord4 = 3478,
    //
    // Summary:
    //     Original was GL_MAP1_VERTEX_3 = 0x0D97
    Map1Vertex3 = 3479,
    //
    // Summary:
    //     Original was GL_MAP1_VERTEX_4 = 0x0D98
    Map1Vertex4 = 3480,
    //
    // Summary:
    //     Original was GL_MAP2_COLOR_4 = 0x0DB0
    Map2Color4 = 3504,
    //
    // Summary:
    //     Original was GL_MAP2_INDEX = 0x0DB1
    Map2Index = 3505,
    //
    // Summary:
    //     Original was GL_MAP2_NORMAL = 0x0DB2
    Map2Normal = 3506,
    //
    // Summary:
    //     Original was GL_MAP2_TEXTURE_COORD_1 = 0x0DB3
    Map2TextureCoord1 = 3507,
    //
    // Summary:
    //     Original was GL_MAP2_TEXTURE_COORD_2 = 0x0DB4
    Map2TextureCoord2 = 3508,
    //
    // Summary:
    //     Original was GL_MAP2_TEXTURE_COORD_3 = 0x0DB5
    Map2TextureCoord3 = 3509,
    //
    // Summary:
    //     Original was GL_MAP2_TEXTURE_COORD_4 = 0x0DB6
    Map2TextureCoord4 = 3510,
    //
    // Summary:
    //     Original was GL_MAP2_VERTEX_3 = 0x0DB7
    Map2Vertex3 = 3511,
    //
    // Summary:
    //     Original was GL_MAP2_VERTEX_4 = 0x0DB8
    Map2Vertex4 = 3512,
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
    //     Original was GL_POLYGON_OFFSET_POINT = 0x2A01
    PolygonOffsetPoint = 10753,
    //
    // Summary:
    //     Original was GL_POLYGON_OFFSET_LINE = 0x2A02
    PolygonOffsetLine = 10754,
    //
    // Summary:
    //     Original was GL_CLIP_PLANE0 = 0x3000
    ClipPlane0 = 12288,
    //
    // Summary:
    //     Original was GL_CLIP_PLANE1 = 0x3001
    ClipPlane1 = 12289,
    //
    // Summary:
    //     Original was GL_CLIP_PLANE2 = 0x3002
    ClipPlane2 = 12290,
    //
    // Summary:
    //     Original was GL_CLIP_PLANE3 = 0x3003
    ClipPlane3 = 12291,
    //
    // Summary:
    //     Original was GL_CLIP_PLANE4 = 0x3004
    ClipPlane4 = 12292,
    //
    // Summary:
    //     Original was GL_CLIP_PLANE5 = 0x3005
    ClipPlane5 = 12293,
    //
    // Summary:
    //     Original was GL_LIGHT0 = 0x4000
    Light0 = 16384,
    //
    // Summary:
    //     Original was GL_LIGHT1 = 0x4001
    Light1 = 16385,
    //
    // Summary:
    //     Original was GL_LIGHT2 = 0x4002
    Light2 = 16386,
    //
    // Summary:
    //     Original was GL_LIGHT3 = 0x4003
    Light3 = 16387,
    //
    // Summary:
    //     Original was GL_LIGHT4 = 0x4004
    Light4 = 16388,
    //
    // Summary:
    //     Original was GL_LIGHT5 = 0x4005
    Light5 = 16389,
    //
    // Summary:
    //     Original was GL_LIGHT6 = 0x4006
    Light6 = 16390,
    //
    // Summary:
    //     Original was GL_LIGHT7 = 0x4007
    Light7 = 16391,
    //
    // Summary:
    //     Original was GL_CONVOLUTION_1D_EXT = 0x8010
    Convolution1DExt = 32784,
    //
    // Summary:
    //     Original was GL_CONVOLUTION_2D_EXT = 0x8011
    Convolution2DExt = 32785,
    //
    // Summary:
    //     Original was GL_SEPARABLE_2D_EXT = 0x8012
    Separable2DExt = 32786,
    //
    // Summary:
    //     Original was GL_HISTOGRAM_EXT = 0x8024
    HistogramExt = 32804,
    //
    // Summary:
    //     Original was GL_MINMAX_EXT = 0x802E
    MinmaxExt = 32814,
    //
    // Summary:
    //     Original was GL_POLYGON_OFFSET_FILL = 0x8037
    PolygonOffsetFill = 32823,
    //
    // Summary:
    //     Original was GL_RESCALE_NORMAL_EXT = 0x803A
    RescaleNormalExt = 32826,
    //
    // Summary:
    //     Original was GL_TEXTURE_3D_EXT = 0x806F
    Texture3DExt = 32879,
    //
    // Summary:
    //     [requires: KHR_debug] Original was GL_VERTEX_ARRAY = 0x8074
    VertexArray = 32884,
    //
    // Summary:
    //     Original was GL_NORMAL_ARRAY = 0x8075
    NormalArray = 32885,
    //
    // Summary:
    //     Original was GL_COLOR_ARRAY = 0x8076
    ColorArray = 32886,
    //
    // Summary:
    //     Original was GL_INDEX_ARRAY = 0x8077
    IndexArray = 32887,
    //
    // Summary:
    //     Original was GL_TEXTURE_COORD_ARRAY = 0x8078
    TextureCoordArray = 32888,
    //
    // Summary:
    //     Original was GL_EDGE_FLAG_ARRAY = 0x8079
    EdgeFlagArray = 32889,
    //
    // Summary:
    //     Original was GL_INTERLACE_SGIX = 0x8094
    InterlaceSgix = 32916,
    //
    // Summary:
    //     Original was GL_MULTISAMPLE_SGIS = 0x809D
    MultisampleSgis = 32925,
    //
    // Summary:
    //     Original was GL_SAMPLE_ALPHA_TO_MASK_SGIS = 0x809E
    SampleAlphaToMaskSgis = 32926,
    //
    // Summary:
    //     Original was GL_SampleAlphaToCoverage = 0X809e
    SampleAlphaToCoverage = 32926,
    //
    // Summary:
    //     Original was GL_SAMPLE_ALPHA_TO_ONE_SGIS = 0x809F
    SampleAlphaToOneSgis = 32927,
    //
    // Summary:
    //     Original was GL_SAMPLE_MASK_SGIS = 0x80A0
    SampleMaskSgis = 32928,
    //
    // Summary:
    //     Original was GL_SampleCoverage = 0X80a0
    SampleCoverage = 32928,
    //
    // Summary:
    //     Original was GL_TEXTURE_COLOR_TABLE_SGI = 0x80BC
    TextureColorTableSgi = 32956,
    //
    // Summary:
    //     Original was GL_COLOR_TABLE_SGI = 0x80D0
    ColorTableSgi = 32976,
    //
    // Summary:
    //     Original was GL_POST_CONVOLUTION_COLOR_TABLE_SGI = 0x80D1
    PostConvolutionColorTableSgi = 32977,
    //
    // Summary:
    //     Original was GL_POST_COLOR_MATRIX_COLOR_TABLE_SGI = 0x80D2
    PostColorMatrixColorTableSgi = 32978,
    //
    // Summary:
    //     Original was GL_TEXTURE_4D_SGIS = 0x8134
    Texture4DSgis = 33076,
    //
    // Summary:
    //     Original was GL_PIXEL_TEX_GEN_SGIX = 0x8139
    PixelTexGenSgix = 33081,
    //
    // Summary:
    //     Original was GL_SPRITE_SGIX = 0x8148
    SpriteSgix = 33096,
    //
    // Summary:
    //     Original was GL_REFERENCE_PLANE_SGIX = 0x817D
    ReferencePlaneSgix = 33149,
    //
    // Summary:
    //     Original was GL_IR_INSTRUMENT1_SGIX = 0x817F
    IrInstrument1Sgix = 33151,
    //
    // Summary:
    //     Original was GL_CALLIGRAPHIC_FRAGMENT_SGIX = 0x8183
    CalligraphicFragmentSgix = 33155,
    //
    // Summary:
    //     Original was GL_FRAMEZOOM_SGIX = 0x818B
    FramezoomSgix = 33163,
    //
    // Summary:
    //     Original was GL_FOG_OFFSET_SGIX = 0x8198
    FogOffsetSgix = 33176,
    //
    // Summary:
    //     Original was GL_SHARED_TEXTURE_PALETTE_EXT = 0x81FB
    SharedTexturePaletteExt = 33275,
    //
    // Summary:
    //     Original was GL_ASYNC_HISTOGRAM_SGIX = 0x832C
    AsyncHistogramSgix = 33580,
    //
    // Summary:
    //     Original was GL_PIXEL_TEXTURE_SGIS = 0x8353
    PixelTextureSgis = 33619,
    //
    // Summary:
    //     Original was GL_ASYNC_TEX_IMAGE_SGIX = 0x835C
    AsyncTexImageSgix = 33628,
    //
    // Summary:
    //     Original was GL_ASYNC_DRAW_PIXELS_SGIX = 0x835D
    AsyncDrawPixelsSgix = 33629,
    //
    // Summary:
    //     Original was GL_ASYNC_READ_PIXELS_SGIX = 0x835E
    AsyncReadPixelsSgix = 33630,
    //
    // Summary:
    //     Original was GL_FRAGMENT_LIGHTING_SGIX = 0x8400
    FragmentLightingSgix = 33792,
    //
    // Summary:
    //     Original was GL_FRAGMENT_COLOR_MATERIAL_SGIX = 0x8401
    FragmentColorMaterialSgix = 33793,
    //
    // Summary:
    //     Original was GL_FRAGMENT_LIGHT0_SGIX = 0x840C
    FragmentLight0Sgix = 33804,
    //
    // Summary:
    //     Original was GL_FRAGMENT_LIGHT1_SGIX = 0x840D
    FragmentLight1Sgix = 33805,
    //
    // Summary:
    //     Original was GL_FRAGMENT_LIGHT2_SGIX = 0x840E
    FragmentLight2Sgix = 33806,
    //
    // Summary:
    //     Original was GL_FRAGMENT_LIGHT3_SGIX = 0x840F
    FragmentLight3Sgix = 33807,
    //
    // Summary:
    //     Original was GL_FRAGMENT_LIGHT4_SGIX = 0x8410
    FragmentLight4Sgix = 33808,
    //
    // Summary:
    //     Original was GL_FRAGMENT_LIGHT5_SGIX = 0x8411
    FragmentLight5Sgix = 33809,
    //
    // Summary:
    //     Original was GL_FRAGMENT_LIGHT6_SGIX = 0x8412
    FragmentLight6Sgix = 33810,
    //
    // Summary:
    //     Original was GL_FRAGMENT_LIGHT7_SGIX = 0x8413
    FragmentLight7Sgix = 33811,
    //
    // Summary:
    //     [requires: NV_representative_fragment_test] Original was GL_REPRESENTATIVE_FRAGMENT_TEST_NV
    //     = 0x937F
    RepresentativeFragmentTestNv = 37759,
    //
    // Summary:
    //     Original was GL_SUBGROUP_SIZE_KHR = 0x9532
    SubgroupSizeKhr = 38194,
    //
    // Summary:
    //     Original was GL_SUBGROUP_SUPPORTED_STAGES_KHR = 0x9533
    SubgroupSupportedStagesKhr = 38195,
    //
    // Summary:
    //     Original was GL_SUBGROUP_SUPPORTED_FEATURES_KHR = 0x9534
    SubgroupSupportedFeaturesKhr = 38196,
    //
    // Summary:
    //     Original was GL_SUBGROUP_QUAD_ALL_STAGES_KHR = 0x9535
    SubgroupQuadAllStagesKhr = 38197,
    //
    // Summary:
    //     [requires: NV_scissor_exclusive] Original was GL_SCISSOR_TEST_EXCLUSIVE_NV =
    //     0x9555
    ScissorTestExclusiveNv = 38229,
    //
    // Summary:
    //     [requires: NV_scissor_exclusive] Original was GL_SCISSOR_BOX_EXCLUSIVE_NV = 0x9556
    ScissorBoxExclusiveNv = 38230,
    //
    // Summary:
    //     [requires: NV_primitive_shading_rate] Original was GL_SHADING_RATE_IMAGE_PER_PRIMITIVE_NV
    //     = 0x95B1
    ShadingRateImagePerPrimitiveNv = 38321,
    //
    // Summary:
    //     [requires: NV_primitive_shading_rate] Original was GL_SHADING_RATE_IMAGE_PALETTE_COUNT_NV
    //     = 0x95B2
    ShadingRateImagePaletteCountNv = 38322
}