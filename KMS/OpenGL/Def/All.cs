namespace OpenGL.Def
{
    //
    // Summary:
    //     Used in GL.Amd.GetPerfMonitorCounterData, GL.Amd.GetPerfMonitorCounterInfo and
    //     358 other functions
    public enum All: int
    {
        //
        // Summary:
        //     Original was GL_FALSE = 0
        False = 0,
        //
        // Summary:
        //     Original was GL_LAYOUT_DEFAULT_INTEL = 0
        LayoutDefaultIntel = 0,
        //
        // Summary:
        //     [requires: EXT_robustness, or KHR_robustness] Original was GL_NO_ERROR = 0
        NoError = 0,
        //
        // Summary:
        //     [requires: KHR_context_flush_control] Original was GL_NONE = 0
        None = 0,
        //
        // Summary:
        //     Original was GL_NONE_OES = 0
        NoneOes = 0,
        //
        // Summary:
        //     Original was GL_Zero = 0
        Zero = 0,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_CLOSE_PATH_NV = 0x00
        ClosePathNv = 0,
        //
        // Summary:
        //     Original was GL_Points = 0X0000
        Points = 0,
        //
        // Summary:
        //     [requires: INTEL_performance_query] Original was GL_PERFQUERY_SINGLE_CONTEXT_INTEL
        //     = 0x00000000
        PerfquerySingleContextIntel = 0,
        //
        // Summary:
        //     Original was GL_CLIENT_PIXEL_STORE_BIT = 0x00000001
        ClientPixelStoreBit = 1,
        //
        // Summary:
        //     [requires: QCOM_tiled_rendering] Original was GL_COLOR_BUFFER_BIT0_QCOM = 0x00000001
        ColorBufferBit0Qcom = 1,
        //
        // Summary:
        //     Original was GL_CONTEXT_CORE_PROFILE_BIT = 0x00000001
        ContextCoreProfileBit = 1,
        //
        // Summary:
        //     Original was GL_CONTEXT_FLAG_FORWARD_COMPATIBLE_BIT = 0x00000001
        ContextFlagForwardCompatibleBit = 1,
        //
        // Summary:
        //     Original was GL_CURRENT_BIT = 0x00000001
        CurrentBit = 1,
        //
        // Summary:
        //     [requires: QCOM_framebuffer_foveated, or QCOM_texture_foveated] Original was
        //     GL_FOVEATION_ENABLE_BIT_QCOM = 0x00000001
        FoveationEnableBitQcom = 1,
        //
        // Summary:
        //     [requires: INTEL_performance_query] Original was GL_PERFQUERY_GLOBAL_CONTEXT_INTEL
        //     = 0x00000001
        PerfqueryGlobalContextIntel = 1,
        //
        // Summary:
        //     Original was GL_QUERY_DEPTH_PASS_EVENT_BIT_AMD = 0x00000001
        QueryDepthPassEventBitAmd = 1,
        //
        // Summary:
        //     Original was GL_SUBGROUP_FEATURE_BASIC_BIT_KHR = 0x00000001
        SubgroupFeatureBasicBitKhr = 1,
        //
        // Summary:
        //     Original was GL_SYNC_FLUSH_COMMANDS_BIT = 0x00000001
        SyncFlushCommandsBit = 1,
        //
        // Summary:
        //     [requires: APPLE_sync] Original was GL_SYNC_FLUSH_COMMANDS_BIT_APPLE = 0x00000001
        SyncFlushCommandsBitApple = 1,
        //
        // Summary:
        //     Original was GL_TEXTURE_STORAGE_SPARSE_BIT_AMD = 0x00000001
        TextureStorageSparseBitAmd = 1,
        //
        // Summary:
        //     Original was GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT = 0x00000001
        VertexAttribArrayBarrierBit = 1,
        //
        // Summary:
        //     Original was GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT_EXT = 0x00000001
        VertexAttribArrayBarrierBitExt = 1,
        //
        // Summary:
        //     Original was GL_VERTEX_SHADER_BIT = 0x00000001
        VertexShaderBit = 1,
        //
        // Summary:
        //     [requires: EXT_separate_shader_objects] Original was GL_VERTEX_SHADER_BIT_EXT
        //     = 0x00000001
        VertexShaderBitExt = 1,
        //
        // Summary:
        //     Original was GL_CLIENT_VERTEX_ARRAY_BIT = 0x00000002
        ClientVertexArrayBit = 2,
        //
        // Summary:
        //     [requires: QCOM_tiled_rendering] Original was GL_COLOR_BUFFER_BIT1_QCOM = 0x00000002
        ColorBufferBit1Qcom = 2,
        //
        // Summary:
        //     Original was GL_CONTEXT_COMPATIBILITY_PROFILE_BIT = 0x00000002
        ContextCompatibilityProfileBit = 2,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_CONTEXT_FLAG_DEBUG_BIT = 0x00000002
        ContextFlagDebugBit = 2,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_CONTEXT_FLAG_DEBUG_BIT_KHR = 0x00000002
        ContextFlagDebugBitKhr = 2,
        //
        // Summary:
        //     Original was GL_ELEMENT_ARRAY_BARRIER_BIT = 0x00000002
        ElementArrayBarrierBit = 2,
        //
        // Summary:
        //     Original was GL_ELEMENT_ARRAY_BARRIER_BIT_EXT = 0x00000002
        ElementArrayBarrierBitExt = 2,
        //
        // Summary:
        //     [requires: QCOM_framebuffer_foveated, or QCOM_texture_foveated] Original was
        //     GL_FOVEATION_SCALED_BIN_METHOD_BIT_QCOM = 0x00000002
        FoveationScaledBinMethodBitQcom = 2,
        //
        // Summary:
        //     Original was GL_FRAGMENT_SHADER_BIT = 0x00000002
        FragmentShaderBit = 2,
        //
        // Summary:
        //     [requires: EXT_separate_shader_objects] Original was GL_FRAGMENT_SHADER_BIT_EXT
        //     = 0x00000002
        FragmentShaderBitExt = 2,
        //
        // Summary:
        //     Original was GL_POINT_BIT = 0x00000002
        PointBit = 2,
        //
        // Summary:
        //     Original was GL_QUERY_DEPTH_FAIL_EVENT_BIT_AMD = 0x00000002
        QueryDepthFailEventBitAmd = 2,
        //
        // Summary:
        //     Original was GL_SUBGROUP_FEATURE_VOTE_BIT_KHR = 0x00000002
        SubgroupFeatureVoteBitKhr = 2,
        //
        // Summary:
        //     [requires: QCOM_tiled_rendering] Original was GL_COLOR_BUFFER_BIT2_QCOM = 0x00000004
        ColorBufferBit2Qcom = 4,
        //
        // Summary:
        //     Original was GL_CONTEXT_FLAG_ROBUST_ACCESS_BIT = 0x00000004
        ContextFlagRobustAccessBit = 4,
        //
        // Summary:
        //     Original was GL_CONTEXT_FLAG_ROBUST_ACCESS_BIT_ARB = 0x00000004
        ContextFlagRobustAccessBitArb = 4,
        //
        // Summary:
        //     Original was GL_GEOMETRY_SHADER_BIT = 0x00000004
        GeometryShaderBit = 4,
        //
        // Summary:
        //     [requires: EXT_geometry_shader] Original was GL_GEOMETRY_SHADER_BIT_EXT = 0x00000004
        GeometryShaderBitExt = 4,
        //
        // Summary:
        //     [requires: OES_geometry_shader] Original was GL_GEOMETRY_SHADER_BIT_OES = 0x00000004
        GeometryShaderBitOes = 4,
        //
        // Summary:
        //     Original was GL_LINE_BIT = 0x00000004
        LineBit = 4,
        //
        // Summary:
        //     Original was GL_QUERY_STENCIL_FAIL_EVENT_BIT_AMD = 0x00000004
        QueryStencilFailEventBitAmd = 4,
        //
        // Summary:
        //     Original was GL_SUBGROUP_FEATURE_ARITHMETIC_BIT_KHR = 0x00000004
        SubgroupFeatureArithmeticBitKhr = 4,
        //
        // Summary:
        //     Original was GL_UNIFORM_BARRIER_BIT = 0x00000004
        UniformBarrierBit = 4,
        //
        // Summary:
        //     Original was GL_UNIFORM_BARRIER_BIT_EXT = 0x00000004
        UniformBarrierBitExt = 4,
        //
        // Summary:
        //     [requires: QCOM_tiled_rendering] Original was GL_COLOR_BUFFER_BIT3_QCOM = 0x00000008
        ColorBufferBit3Qcom = 8,
        //
        // Summary:
        //     Original was GL_CONTEXT_FLAG_NO_ERROR_BIT = 0x00000008
        ContextFlagNoErrorBit = 8,
        //
        // Summary:
        //     [requires: KHR_no_error] Original was GL_CONTEXT_FLAG_NO_ERROR_BIT_KHR = 0x00000008
        ContextFlagNoErrorBitKhr = 8,
        //
        // Summary:
        //     Original was GL_POLYGON_BIT = 0x00000008
        PolygonBit = 8,
        //
        // Summary:
        //     Original was GL_QUERY_DEPTH_BOUNDS_FAIL_EVENT_BIT_AMD = 0x00000008
        QueryDepthBoundsFailEventBitAmd = 8,
        //
        // Summary:
        //     Original was GL_SUBGROUP_FEATURE_BALLOT_BIT_KHR = 0x00000008
        SubgroupFeatureBallotBitKhr = 8,
        //
        // Summary:
        //     Original was GL_TESS_CONTROL_SHADER_BIT = 0x00000008
        TessControlShaderBit = 8,
        //
        // Summary:
        //     [requires: EXT_tessellation_shader] Original was GL_TESS_CONTROL_SHADER_BIT_EXT
        //     = 0x00000008
        TessControlShaderBitExt = 8,
        //
        // Summary:
        //     [requires: OES_tessellation_shader] Original was GL_TESS_CONTROL_SHADER_BIT_OES
        //     = 0x00000008
        TessControlShaderBitOes = 8,
        //
        // Summary:
        //     Original was GL_TEXTURE_FETCH_BARRIER_BIT = 0x00000008
        TextureFetchBarrierBit = 8,
        //
        // Summary:
        //     Original was GL_TEXTURE_FETCH_BARRIER_BIT_EXT = 0x00000008
        TextureFetchBarrierBitExt = 8,
        //
        // Summary:
        //     [requires: QCOM_tiled_rendering] Original was GL_COLOR_BUFFER_BIT4_QCOM = 0x00000010
        ColorBufferBit4Qcom = 0x10,
        //
        // Summary:
        //     [requires: EXT_protected_textures] Original was GL_CONTEXT_FLAG_PROTECTED_CONTENT_BIT_EXT
        //     = 0x00000010
        ContextFlagProtectedContentBitExt = 0x10,
        //
        // Summary:
        //     Original was GL_POLYGON_STIPPLE_BIT = 0x00000010
        PolygonStippleBit = 0x10,
        //
        // Summary:
        //     Original was GL_SHADER_GLOBAL_ACCESS_BARRIER_BIT_NV = 0x00000010
        ShaderGlobalAccessBarrierBitNv = 0x10,
        //
        // Summary:
        //     Original was GL_SUBGROUP_FEATURE_SHUFFLE_BIT_KHR = 0x00000010
        SubgroupFeatureShuffleBitKhr = 0x10,
        //
        // Summary:
        //     Original was GL_TESS_EVALUATION_SHADER_BIT = 0x00000010
        TessEvaluationShaderBit = 0x10,
        //
        // Summary:
        //     [requires: EXT_tessellation_shader] Original was GL_TESS_EVALUATION_SHADER_BIT_EXT
        //     = 0x00000010
        TessEvaluationShaderBitExt = 0x10,
        //
        // Summary:
        //     [requires: OES_tessellation_shader] Original was GL_TESS_EVALUATION_SHADER_BIT_OES
        //     = 0x00000010
        TessEvaluationShaderBitOes = 0x10,
        //
        // Summary:
        //     [requires: QCOM_tiled_rendering] Original was GL_COLOR_BUFFER_BIT5_QCOM = 0x00000020
        ColorBufferBit5Qcom = 0x20,
        //
        // Summary:
        //     Original was GL_COMPUTE_SHADER_BIT = 0x00000020
        ComputeShaderBit = 0x20,
        //
        // Summary:
        //     Original was GL_PIXEL_MODE_BIT = 0x00000020
        PixelModeBit = 0x20,
        //
        // Summary:
        //     Original was GL_SHADER_IMAGE_ACCESS_BARRIER_BIT = 0x00000020
        ShaderImageAccessBarrierBit = 0x20,
        //
        // Summary:
        //     Original was GL_SHADER_IMAGE_ACCESS_BARRIER_BIT_EXT = 0x00000020
        ShaderImageAccessBarrierBitExt = 0x20,
        //
        // Summary:
        //     Original was GL_SUBGROUP_FEATURE_SHUFFLE_RELATIVE_BIT_KHR = 0x00000020
        SubgroupFeatureShuffleRelativeBitKhr = 0x20,
        //
        // Summary:
        //     [requires: QCOM_tiled_rendering] Original was GL_COLOR_BUFFER_BIT6_QCOM = 0x00000040
        ColorBufferBit6Qcom = 0x40,
        //
        // Summary:
        //     Original was GL_COMMAND_BARRIER_BIT = 0x00000040
        CommandBarrierBit = 0x40,
        //
        // Summary:
        //     Original was GL_COMMAND_BARRIER_BIT_EXT = 0x00000040
        CommandBarrierBitExt = 0x40,
        //
        // Summary:
        //     Original was GL_LIGHTING_BIT = 0x00000040
        LightingBit = 0x40,
        //
        // Summary:
        //     [requires: NV_mesh_shader] Original was GL_MESH_SHADER_BIT_NV = 0x00000040
        MeshShaderBitNv = 0x40,
        //
        // Summary:
        //     Original was GL_SUBGROUP_FEATURE_CLUSTERED_BIT_KHR = 0x00000040
        SubgroupFeatureClusteredBitKhr = 0x40,
        //
        // Summary:
        //     [requires: QCOM_tiled_rendering] Original was GL_COLOR_BUFFER_BIT7_QCOM = 0x00000080
        ColorBufferBit7Qcom = 0x80,
        //
        // Summary:
        //     Original was GL_FOG_BIT = 0x00000080
        FogBit = 0x80,
        //
        // Summary:
        //     Original was GL_PIXEL_BUFFER_BARRIER_BIT = 0x00000080
        PixelBufferBarrierBit = 0x80,
        //
        // Summary:
        //     Original was GL_PIXEL_BUFFER_BARRIER_BIT_EXT = 0x00000080
        PixelBufferBarrierBitExt = 0x80,
        //
        // Summary:
        //     Original was GL_SUBGROUP_FEATURE_QUAD_BIT_KHR = 0x00000080
        SubgroupFeatureQuadBitKhr = 0x80,
        //
        // Summary:
        //     [requires: NV_mesh_shader] Original was GL_TASK_SHADER_BIT_NV = 0x00000080
        TaskShaderBitNv = 0x80,
        //
        // Summary:
        //     Original was GL_DEPTH_BUFFER_BIT = 0x00000100
        DepthBufferBit = 0x100,
        //
        // Summary:
        //     [requires: QCOM_tiled_rendering] Original was GL_DEPTH_BUFFER_BIT0_QCOM = 0x00000100
        DepthBufferBit0Qcom = 0x100,
        //
        // Summary:
        //     Original was GL_TEXTURE_UPDATE_BARRIER_BIT = 0x00000100
        TextureUpdateBarrierBit = 0x100,
        //
        // Summary:
        //     Original was GL_TEXTURE_UPDATE_BARRIER_BIT_EXT = 0x00000100
        TextureUpdateBarrierBitExt = 0x100,
        //
        // Summary:
        //     Original was GL_ACCUM_BUFFER_BIT = 0x00000200
        AccumBufferBit = 0x200,
        //
        // Summary:
        //     Original was GL_BUFFER_UPDATE_BARRIER_BIT = 0x00000200
        BufferUpdateBarrierBit = 0x200,
        //
        // Summary:
        //     Original was GL_BUFFER_UPDATE_BARRIER_BIT_EXT = 0x00000200
        BufferUpdateBarrierBitExt = 0x200,
        //
        // Summary:
        //     [requires: QCOM_tiled_rendering] Original was GL_DEPTH_BUFFER_BIT1_QCOM = 0x00000200
        DepthBufferBit1Qcom = 0x200,
        //
        // Summary:
        //     [requires: QCOM_tiled_rendering] Original was GL_DEPTH_BUFFER_BIT2_QCOM = 0x00000400
        DepthBufferBit2Qcom = 0x400,
        //
        // Summary:
        //     Original was GL_FRAMEBUFFER_BARRIER_BIT = 0x00000400
        FramebufferBarrierBit = 0x400,
        //
        // Summary:
        //     Original was GL_FRAMEBUFFER_BARRIER_BIT_EXT = 0x00000400
        FramebufferBarrierBitExt = 0x400,
        //
        // Summary:
        //     Original was GL_STENCIL_BUFFER_BIT = 0x00000400
        StencilBufferBit = 0x400,
        //
        // Summary:
        //     [requires: QCOM_tiled_rendering] Original was GL_DEPTH_BUFFER_BIT3_QCOM = 0x00000800
        DepthBufferBit3Qcom = 0x800,
        //
        // Summary:
        //     Original was GL_TRANSFORM_FEEDBACK_BARRIER_BIT = 0x00000800
        TransformFeedbackBarrierBit = 0x800,
        //
        // Summary:
        //     Original was GL_TRANSFORM_FEEDBACK_BARRIER_BIT_EXT = 0x00000800
        TransformFeedbackBarrierBitExt = 0x800,
        //
        // Summary:
        //     Original was GL_VIEWPORT_BIT = 0x00000800
        ViewportBit = 0x800,
        //
        // Summary:
        //     Original was GL_ATOMIC_COUNTER_BARRIER_BIT = 0x00001000
        AtomicCounterBarrierBit = 0x1000,
        //
        // Summary:
        //     Original was GL_ATOMIC_COUNTER_BARRIER_BIT_EXT = 0x00001000
        AtomicCounterBarrierBitExt = 0x1000,
        //
        // Summary:
        //     [requires: QCOM_tiled_rendering] Original was GL_DEPTH_BUFFER_BIT4_QCOM = 0x00001000
        DepthBufferBit4Qcom = 0x1000,
        //
        // Summary:
        //     Original was GL_TRANSFORM_BIT = 0x00001000
        TransformBit = 0x1000,
        //
        // Summary:
        //     [requires: QCOM_tiled_rendering] Original was GL_DEPTH_BUFFER_BIT5_QCOM = 0x00002000
        DepthBufferBit5Qcom = 0x2000,
        //
        // Summary:
        //     Original was GL_ENABLE_BIT = 0x00002000
        EnableBit = 0x2000,
        //
        // Summary:
        //     Original was GL_SHADER_STORAGE_BARRIER_BIT = 0x00002000
        ShaderStorageBarrierBit = 0x2000,
        //
        // Summary:
        //     Original was GL_CLIENT_MAPPED_BUFFER_BARRIER_BIT = 0x00004000
        ClientMappedBufferBarrierBit = 0x4000,
        //
        // Summary:
        //     [requires: EXT_buffer_storage] Original was GL_CLIENT_MAPPED_BUFFER_BARRIER_BIT_EXT
        //     = 0x00004000
        ClientMappedBufferBarrierBitExt = 0x4000,
        //
        // Summary:
        //     Original was GL_COLOR_BUFFER_BIT = 0x00004000
        ColorBufferBit = 0x4000,
        //
        // Summary:
        //     [requires: QCOM_tiled_rendering] Original was GL_DEPTH_BUFFER_BIT6_QCOM = 0x00004000
        DepthBufferBit6Qcom = 0x4000,
        //
        // Summary:
        //     [requires: NV_coverage_sample] Original was GL_COVERAGE_BUFFER_BIT_NV = 0x00008000
        CoverageBufferBitNv = 0x8000,
        //
        // Summary:
        //     [requires: QCOM_tiled_rendering] Original was GL_DEPTH_BUFFER_BIT7_QCOM = 0x00008000
        DepthBufferBit7Qcom = 0x8000,
        //
        // Summary:
        //     Original was GL_HINT_BIT = 0x00008000
        HintBit = 0x8000,
        //
        // Summary:
        //     Original was GL_QUERY_BUFFER_BARRIER_BIT = 0x00008000
        QueryBufferBarrierBit = 0x8000,
        //
        // Summary:
        //     [requires: EXT_buffer_storage] Original was GL_MAP_READ_BIT = 0x0001
        MapReadBit = 1,
        //
        // Summary:
        //     [requires: EXT_map_buffer_range] Original was GL_MAP_READ_BIT_EXT = 0x0001
        MapReadBitExt = 1,
        //
        // Summary:
        //     Original was GL_Lines = 0X0001
        Lines = 1,
        //
        // Summary:
        //     Original was GL_EVAL_BIT = 0x00010000
        EvalBit = 0x10000,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_FONT_X_MIN_BOUNDS_BIT_NV = 0x00010000
        FontXMinBoundsBitNv = 0x10000,
        //
        // Summary:
        //     [requires: QCOM_tiled_rendering] Original was GL_STENCIL_BUFFER_BIT0_QCOM = 0x00010000
        StencilBufferBit0Qcom = 0x10000,
        //
        // Summary:
        //     Original was GL_LINE_LOOP = 0x0002
        LineLoop = 2,
        //
        // Summary:
        //     [requires: EXT_buffer_storage] Original was GL_MAP_WRITE_BIT = 0x0002
        MapWriteBit = 2,
        //
        // Summary:
        //     [requires: EXT_map_buffer_range] Original was GL_MAP_WRITE_BIT_EXT = 0x0002
        MapWriteBitExt = 2,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_FONT_Y_MIN_BOUNDS_BIT_NV = 0x00020000
        FontYMinBoundsBitNv = 0x20000,
        //
        // Summary:
        //     Original was GL_LIST_BIT = 0x00020000
        ListBit = 0x20000,
        //
        // Summary:
        //     [requires: QCOM_tiled_rendering] Original was GL_STENCIL_BUFFER_BIT1_QCOM = 0x00020000
        StencilBufferBit1Qcom = 0x20000,
        //
        // Summary:
        //     Original was GL_LINE_STRIP = 0x0003
        LineStrip = 3,
        //
        // Summary:
        //     Original was GL_MAP_INVALIDATE_RANGE_BIT = 0x0004
        MapInvalidateRangeBit = 4,
        //
        // Summary:
        //     [requires: EXT_map_buffer_range] Original was GL_MAP_INVALIDATE_RANGE_BIT_EXT
        //     = 0x0004
        MapInvalidateRangeBitExt = 4,
        //
        // Summary:
        //     Original was GL_Triangles = 0X0004
        Triangles = 4,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_FONT_X_MAX_BOUNDS_BIT_NV = 0x00040000
        FontXMaxBoundsBitNv = 0x40000,
        //
        // Summary:
        //     [requires: QCOM_tiled_rendering] Original was GL_STENCIL_BUFFER_BIT2_QCOM = 0x00040000
        StencilBufferBit2Qcom = 0x40000,
        //
        // Summary:
        //     Original was GL_TEXTURE_BIT = 0x00040000
        TextureBit = 0x40000,
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
        //     [requires: OES_tessellation_shader] Original was GL_QUADS_OES = 0x0007
        QuadsOes = 7,
        //
        // Summary:
        //     Original was GL_MAP_INVALIDATE_BUFFER_BIT = 0x0008
        MapInvalidateBufferBit = 8,
        //
        // Summary:
        //     [requires: EXT_map_buffer_range] Original was GL_MAP_INVALIDATE_BUFFER_BIT_EXT
        //     = 0x0008
        MapInvalidateBufferBitExt = 8,
        //
        // Summary:
        //     Original was GL_QUAD_STRIP = 0x0008
        QuadStrip = 8,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_FONT_Y_MAX_BOUNDS_BIT_NV = 0x00080000
        FontYMaxBoundsBitNv = 0x80000,
        //
        // Summary:
        //     Original was GL_SCISSOR_BIT = 0x00080000
        ScissorBit = 0x80000,
        //
        // Summary:
        //     [requires: QCOM_tiled_rendering] Original was GL_STENCIL_BUFFER_BIT3_QCOM = 0x00080000
        StencilBufferBit3Qcom = 0x80000,
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
        //     [requires: OES_geometry_shader] Original was GL_LINES_ADJACENCY_OES = 0x000A
        LinesAdjacencyOes = 10,
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
        //     [requires: OES_geometry_shader] Original was GL_LINE_STRIP_ADJACENCY_OES = 0x000B
        LineStripAdjacencyOes = 11,
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
        //     [requires: OES_geometry_shader] Original was GL_TRIANGLES_ADJACENCY_OES = 0x000C
        TrianglesAdjacencyOes = 12,
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
        //     [requires: OES_geometry_shader] Original was GL_TRIANGLE_STRIP_ADJACENCY_OES
        //     = 0x000D
        TriangleStripAdjacencyOes = 13,
        //
        // Summary:
        //     [requires: NV_gpu_shader5] Original was GL_PATCHES = 0x000E
        Patches = 14,
        //
        // Summary:
        //     [requires: EXT_tessellation_shader] Original was GL_PATCHES_EXT = 0x000E
        PatchesExt = 14,
        //
        // Summary:
        //     [requires: OES_tessellation_shader] Original was GL_PATCHES_OES = 0x000E
        PatchesOes = 14,
        //
        // Summary:
        //     Original was GL_MAP_FLUSH_EXPLICIT_BIT = 0x0010
        MapFlushExplicitBit = 0x10,
        //
        // Summary:
        //     [requires: EXT_map_buffer_range] Original was GL_MAP_FLUSH_EXPLICIT_BIT_EXT =
        //     0x0010
        MapFlushExplicitBitExt = 0x10,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_FONT_UNITS_PER_EM_BIT_NV = 0x00100000
        FontUnitsPerEmBitNv = 0x100000,
        //
        // Summary:
        //     [requires: QCOM_tiled_rendering] Original was GL_STENCIL_BUFFER_BIT4_QCOM = 0x00100000
        StencilBufferBit4Qcom = 0x100000,
        //
        // Summary:
        //     Original was GL_MAP_UNSYNCHRONIZED_BIT = 0x0020
        MapUnsynchronizedBit = 0x20,
        //
        // Summary:
        //     [requires: EXT_map_buffer_range] Original was GL_MAP_UNSYNCHRONIZED_BIT_EXT =
        //     0x0020
        MapUnsynchronizedBitExt = 0x20,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_FONT_ASCENDER_BIT_NV = 0x00200000
        FontAscenderBitNv = 0x200000,
        //
        // Summary:
        //     [requires: QCOM_tiled_rendering] Original was GL_STENCIL_BUFFER_BIT5_QCOM = 0x00200000
        StencilBufferBit5Qcom = 0x200000,
        //
        // Summary:
        //     Original was GL_MAP_PERSISTENT_BIT = 0x0040
        MapPersistentBit = 0x40,
        //
        // Summary:
        //     [requires: EXT_buffer_storage] Original was GL_MAP_PERSISTENT_BIT_EXT = 0x0040
        MapPersistentBitExt = 0x40,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_FONT_DESCENDER_BIT_NV = 0x00400000
        FontDescenderBitNv = 0x400000,
        //
        // Summary:
        //     [requires: QCOM_tiled_rendering] Original was GL_STENCIL_BUFFER_BIT6_QCOM = 0x00400000
        StencilBufferBit6Qcom = 0x400000,
        //
        // Summary:
        //     Original was GL_MAP_COHERENT_BIT = 0x0080
        MapCoherentBit = 0x80,
        //
        // Summary:
        //     [requires: EXT_buffer_storage] Original was GL_MAP_COHERENT_BIT_EXT = 0x0080
        MapCoherentBitExt = 0x80,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_FONT_HEIGHT_BIT_NV = 0x00800000
        FontHeightBitNv = 0x800000,
        //
        // Summary:
        //     [requires: QCOM_tiled_rendering] Original was GL_STENCIL_BUFFER_BIT7_QCOM = 0x00800000
        StencilBufferBit7Qcom = 0x800000,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_BOLD_BIT_NV = 0x01
        BoldBitNv = 1,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_GLYPH_WIDTH_BIT_NV = 0x01
        GlyphWidthBitNv = 1,
        //
        // Summary:
        //     Original was GL_ACCUM = 0x0100
        Accum = 0x100,
        //
        // Summary:
        //     Original was GL_DYNAMIC_STORAGE_BIT = 0x0100
        DynamicStorageBit = 0x100,
        //
        // Summary:
        //     [requires: EXT_buffer_storage] Original was GL_DYNAMIC_STORAGE_BIT_EXT = 0x0100
        DynamicStorageBitExt = 0x100,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_FONT_MAX_ADVANCE_WIDTH_BIT_NV =
        //     0x01000000
        FontMaxAdvanceWidthBitNv = 0x1000000,
        //
        // Summary:
        //     [requires: QCOM_tiled_rendering] Original was GL_MULTISAMPLE_BUFFER_BIT0_QCOM
        //     = 0x01000000
        MultisampleBufferBit0Qcom = 0x1000000,
        //
        // Summary:
        //     Original was GL_LOAD = 0x0101
        Load = 257,
        //
        // Summary:
        //     Original was GL_RETURN = 0x0102
        Return = 258,
        //
        // Summary:
        //     Original was GL_MULT = 0x0103
        Mult = 259,
        //
        // Summary:
        //     Original was GL_ADD = 0x0104
        Add = 260,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_GLYPH_HEIGHT_BIT_NV = 0x02
        GlyphHeightBitNv = 2,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_ITALIC_BIT_NV = 0x02
        ItalicBitNv = 2,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_MOVE_TO_NV = 0x02
        MoveToNv = 2,
        //
        // Summary:
        //     Original was GL_CLIENT_STORAGE_BIT = 0x0200
        ClientStorageBit = 0x200,
        //
        // Summary:
        //     [requires: EXT_buffer_storage] Original was GL_CLIENT_STORAGE_BIT_EXT = 0x0200
        ClientStorageBitExt = 0x200,
        //
        // Summary:
        //     Original was GL_Never = 0X0200
        Never = 0x200,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_FONT_MAX_ADVANCE_HEIGHT_BIT_NV
        //     = 0x02000000
        FontMaxAdvanceHeightBitNv = 0x2000000,
        //
        // Summary:
        //     [requires: QCOM_tiled_rendering] Original was GL_MULTISAMPLE_BUFFER_BIT1_QCOM
        //     = 0x02000000
        MultisampleBufferBit1Qcom = 0x2000000,
        //
        // Summary:
        //     Original was GL_Less = 0X0201
        Less = 513,
        //
        // Summary:
        //     Original was GL_Equal = 0X0202
        Equal = 514,
        //
        // Summary:
        //     Original was GL_Lequal = 0X0203
        Lequal = 515,
        //
        // Summary:
        //     Original was GL_Greater = 0X0204
        Greater = 516,
        //
        // Summary:
        //     Original was GL_Notequal = 0X0205
        Notequal = 517,
        //
        // Summary:
        //     Original was GL_Gequal = 0X0206
        Gequal = 518,
        //
        // Summary:
        //     Original was GL_Always = 0X0207
        Always = 519,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_RELATIVE_MOVE_TO_NV = 0x03
        RelativeMoveToNv = 3,
        //
        // Summary:
        //     [requires: EXT_draw_buffers_indexed, or OES_draw_buffers_indexed] Original was
        //     GL_SRC_COLOR = 0x0300
        SrcColor = 768,
        //
        // Summary:
        //     [requires: EXT_draw_buffers_indexed, or OES_draw_buffers_indexed] Original was
        //     GL_ONE_MINUS_SRC_COLOR = 0x0301
        OneMinusSrcColor = 769,
        //
        // Summary:
        //     [requires: EXT_draw_buffers_indexed, or OES_draw_buffers_indexed] Original was
        //     GL_SRC_ALPHA = 0x0302
        SrcAlpha = 770,
        //
        // Summary:
        //     [requires: EXT_draw_buffers_indexed, or OES_draw_buffers_indexed] Original was
        //     GL_ONE_MINUS_SRC_ALPHA = 0x0303
        OneMinusSrcAlpha = 771,
        //
        // Summary:
        //     [requires: EXT_draw_buffers_indexed, or OES_draw_buffers_indexed] Original was
        //     GL_DST_ALPHA = 0x0304
        DstAlpha = 772,
        //
        // Summary:
        //     [requires: EXT_draw_buffers_indexed, or OES_draw_buffers_indexed] Original was
        //     GL_ONE_MINUS_DST_ALPHA = 0x0305
        OneMinusDstAlpha = 773,
        //
        // Summary:
        //     [requires: EXT_draw_buffers_indexed, or OES_draw_buffers_indexed] Original was
        //     GL_DST_COLOR = 0x0306
        DstColor = 774,
        //
        // Summary:
        //     [requires: EXT_draw_buffers_indexed, or OES_draw_buffers_indexed] Original was
        //     GL_ONE_MINUS_DST_COLOR = 0x0307
        OneMinusDstColor = 775,
        //
        // Summary:
        //     [requires: EXT_draw_buffers_indexed, or OES_draw_buffers_indexed] Original was
        //     GL_SRC_ALPHA_SATURATE = 0x0308
        SrcAlphaSaturate = 776,
        //
        // Summary:
        //     [requires: EXT_blend_func_extended] Original was GL_SRC_ALPHA_SATURATE_EXT =
        //     0x0308
        SrcAlphaSaturateExt = 776,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_GLYPH_HORIZONTAL_BEARING_X_BIT_NV
        //     = 0x04
        GlyphHorizontalBearingXBitNv = 4,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_LINE_TO_NV = 0x04
        LineToNv = 4,
        //
        // Summary:
        //     Original was GL_FRONT_LEFT = 0x0400
        FrontLeft = 0x400,
        //
        // Summary:
        //     Original was GL_SPARSE_STORAGE_BIT_ARB = 0x0400
        SparseStorageBitArb = 0x400,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_FONT_UNDERLINE_POSITION_BIT_NV
        //     = 0x04000000
        FontUnderlinePositionBitNv = 0x4000000,
        //
        // Summary:
        //     [requires: QCOM_tiled_rendering] Original was GL_MULTISAMPLE_BUFFER_BIT2_QCOM
        //     = 0x04000000
        MultisampleBufferBit2Qcom = 0x4000000,
        //
        // Summary:
        //     Original was GL_FRONT_RIGHT = 0x0401
        FrontRight = 1025,
        //
        // Summary:
        //     Original was GL_BACK_LEFT = 0x0402
        BackLeft = 1026,
        //
        // Summary:
        //     Original was GL_BACK_RIGHT = 0x0403
        BackRight = 1027,
        //
        // Summary:
        //     Original was GL_Front = 0X0404
        Front = 1028,
        //
        // Summary:
        //     Original was GL_Back = 0X0405
        Back = 1029,
        //
        // Summary:
        //     Original was GL_LEFT = 0x0406
        Left = 1030,
        //
        // Summary:
        //     Original was GL_RIGHT = 0x0407
        Right = 1031,
        //
        // Summary:
        //     Original was GL_FRONT_AND_BACK = 0x0408
        FrontAndBack = 1032,
        //
        // Summary:
        //     Original was GL_AUX0 = 0x0409
        Aux0 = 1033,
        //
        // Summary:
        //     Original was GL_AUX1 = 0x040A
        Aux1 = 1034,
        //
        // Summary:
        //     Original was GL_AUX2 = 0x040B
        Aux2 = 1035,
        //
        // Summary:
        //     Original was GL_AUX3 = 0x040C
        Aux3 = 1036,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_RELATIVE_LINE_TO_NV = 0x05
        RelativeLineToNv = 5,
        //
        // Summary:
        //     Original was GL_INVALID_ENUM = 0x0500
        InvalidEnum = 1280,
        //
        // Summary:
        //     Original was GL_INVALID_VALUE = 0x0501
        InvalidValue = 1281,
        //
        // Summary:
        //     Original was GL_INVALID_OPERATION = 0x0502
        InvalidOperation = 1282,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_STACK_OVERFLOW = 0x0503
        StackOverflow = 1283,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_STACK_OVERFLOW_KHR = 0x0503
        StackOverflowKhr = 1283,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_STACK_UNDERFLOW = 0x0504
        StackUnderflow = 1284,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_STACK_UNDERFLOW_KHR = 0x0504
        StackUnderflowKhr = 1284,
        //
        // Summary:
        //     Original was GL_OUT_OF_MEMORY = 0x0505
        OutOfMemory = 1285,
        //
        // Summary:
        //     Original was GL_INVALID_FRAMEBUFFER_OPERATION = 0x0506
        InvalidFramebufferOperation = 1286,
        //
        // Summary:
        //     Original was GL_INVALID_FRAMEBUFFER_OPERATION_EXT = 0x0506
        InvalidFramebufferOperationExt = 1286,
        //
        // Summary:
        //     Original was GL_INVALID_FRAMEBUFFER_OPERATION_OES = 0x0506
        InvalidFramebufferOperationOes = 1286,
        //
        // Summary:
        //     [requires: KHR_robustness] Original was GL_CONTEXT_LOST = 0x0507
        ContextLost = 1287,
        //
        // Summary:
        //     [requires: KHR_robustness] Original was GL_CONTEXT_LOST_KHR = 0x0507
        ContextLostKhr = 1287,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_HORIZONTAL_LINE_TO_NV = 0x06
        HorizontalLineToNv = 6,
        //
        // Summary:
        //     Original was GL_2D = 0x0600
        Gl2D = 1536,
        //
        // Summary:
        //     Original was GL_3D = 0x0601
        Gl3D = 1537,
        //
        // Summary:
        //     Original was GL_3D_COLOR = 0x0602
        Gl3DColor = 1538,
        //
        // Summary:
        //     Original was GL_3D_COLOR_TEXTURE = 0x0603
        Gl3DColorTexture = 1539,
        //
        // Summary:
        //     Original was GL_4D_COLOR_TEXTURE = 0x0604
        Gl4DColorTexture = 1540,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_RELATIVE_HORIZONTAL_LINE_TO_NV
        //     = 0x07
        RelativeHorizontalLineToNv = 7,
        //
        // Summary:
        //     Original was GL_PASS_THROUGH_TOKEN = 0x0700
        PassThroughToken = 1792,
        //
        // Summary:
        //     Original was GL_POINT_TOKEN = 0x0701
        PointToken = 1793,
        //
        // Summary:
        //     Original was GL_LINE_TOKEN = 0x0702
        LineToken = 1794,
        //
        // Summary:
        //     Original was GL_POLYGON_TOKEN = 0x0703
        PolygonToken = 1795,
        //
        // Summary:
        //     Original was GL_BITMAP_TOKEN = 0x0704
        BitmapToken = 1796,
        //
        // Summary:
        //     Original was GL_DRAW_PIXEL_TOKEN = 0x0705
        DrawPixelToken = 1797,
        //
        // Summary:
        //     Original was GL_COPY_PIXEL_TOKEN = 0x0706
        CopyPixelToken = 1798,
        //
        // Summary:
        //     Original was GL_LINE_RESET_TOKEN = 0x0707
        LineResetToken = 1799,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_GLYPH_HORIZONTAL_BEARING_Y_BIT_NV
        //     = 0x08
        GlyphHorizontalBearingYBitNv = 8,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_VERTICAL_LINE_TO_NV = 0x08
        VerticalLineToNv = 8,
        //
        // Summary:
        //     Original was GL_EXP = 0x0800
        Exp = 0x800,
        //
        // Summary:
        //     Original was GL_LGPU_SEPARATE_STORAGE_BIT_NVX = 0x0800
        LgpuSeparateStorageBitNvx = 0x800,
        //
        // Summary:
        //     Original was GL_PER_GPU_STORAGE_BIT_NV = 0x0800
        PerGpuStorageBitNv = 0x800,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_FONT_UNDERLINE_THICKNESS_BIT_NV
        //     = 0x08000000
        FontUnderlineThicknessBitNv = 0x8000000,
        //
        // Summary:
        //     [requires: QCOM_tiled_rendering] Original was GL_MULTISAMPLE_BUFFER_BIT3_QCOM
        //     = 0x08000000
        MultisampleBufferBit3Qcom = 0x8000000,
        //
        // Summary:
        //     Original was GL_EXP2 = 0x0801
        Exp2 = 2049,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_RELATIVE_VERTICAL_LINE_TO_NV =
        //     0x09
        RelativeVerticalLineToNv = 9,
        //
        // Summary:
        //     Original was GL_Cw = 0X0900
        Cw = 2304,
        //
        // Summary:
        //     Original was GL_Ccw = 0X0901
        Ccw = 2305,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_QUADRATIC_CURVE_TO_NV = 0x0A
        QuadraticCurveToNv = 10,
        //
        // Summary:
        //     Original was GL_COEFF = 0x0A00
        Coeff = 2560,
        //
        // Summary:
        //     Original was GL_ORDER = 0x0A01
        Order = 2561,
        //
        // Summary:
        //     Original was GL_DOMAIN = 0x0A02
        Domain = 2562,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_RELATIVE_QUADRATIC_CURVE_TO_NV
        //     = 0x0B
        RelativeQuadraticCurveToNv = 11,
        //
        // Summary:
        //     Original was GL_CURRENT_COLOR = 0x0B00
        CurrentColor = 2816,
        //
        // Summary:
        //     Original was GL_CURRENT_INDEX = 0x0B01
        CurrentIndex = 2817,
        //
        // Summary:
        //     Original was GL_CURRENT_NORMAL = 0x0B02
        CurrentNormal = 2818,
        //
        // Summary:
        //     Original was GL_CURRENT_TEXTURE_COORDS = 0x0B03
        CurrentTextureCoords = 2819,
        //
        // Summary:
        //     Original was GL_CURRENT_RASTER_COLOR = 0x0B04
        CurrentRasterColor = 2820,
        //
        // Summary:
        //     Original was GL_CURRENT_RASTER_INDEX = 0x0B05
        CurrentRasterIndex = 2821,
        //
        // Summary:
        //     Original was GL_CURRENT_RASTER_TEXTURE_COORDS = 0x0B06
        CurrentRasterTextureCoords = 2822,
        //
        // Summary:
        //     Original was GL_CURRENT_RASTER_POSITION = 0x0B07
        CurrentRasterPosition = 2823,
        //
        // Summary:
        //     Original was GL_CURRENT_RASTER_POSITION_VALID = 0x0B08
        CurrentRasterPositionValid = 2824,
        //
        // Summary:
        //     Original was GL_CURRENT_RASTER_DISTANCE = 0x0B09
        CurrentRasterDistance = 2825,
        //
        // Summary:
        //     Original was GL_POINT_SMOOTH = 0x0B10
        PointSmooth = 2832,
        //
        // Summary:
        //     Original was GL_POINT_SIZE = 0x0B11
        PointSize = 2833,
        //
        // Summary:
        //     Original was GL_POINT_SIZE_RANGE = 0x0B12
        PointSizeRange = 2834,
        //
        // Summary:
        //     Original was GL_SMOOTH_POINT_SIZE_RANGE = 0x0B12
        SmoothPointSizeRange = 2834,
        //
        // Summary:
        //     Original was GL_POINT_SIZE_GRANULARITY = 0x0B13
        PointSizeGranularity = 2835,
        //
        // Summary:
        //     Original was GL_SMOOTH_POINT_SIZE_GRANULARITY = 0x0B13
        SmoothPointSizeGranularity = 2835,
        //
        // Summary:
        //     Original was GL_LINE_SMOOTH = 0x0B20
        LineSmooth = 2848,
        //
        // Summary:
        //     Original was GL_LINE_WIDTH = 0x0B21
        LineWidth = 2849,
        //
        // Summary:
        //     Original was GL_LINE_WIDTH_RANGE = 0x0B22
        LineWidthRange = 2850,
        //
        // Summary:
        //     Original was GL_SMOOTH_LINE_WIDTH_RANGE = 0x0B22
        SmoothLineWidthRange = 2850,
        //
        // Summary:
        //     Original was GL_LINE_WIDTH_GRANULARITY = 0x0B23
        LineWidthGranularity = 2851,
        //
        // Summary:
        //     Original was GL_SMOOTH_LINE_WIDTH_GRANULARITY = 0x0B23
        SmoothLineWidthGranularity = 2851,
        //
        // Summary:
        //     Original was GL_LINE_STIPPLE = 0x0B24
        LineStipple = 2852,
        //
        // Summary:
        //     Original was GL_LINE_STIPPLE_PATTERN = 0x0B25
        LineStipplePattern = 2853,
        //
        // Summary:
        //     Original was GL_LINE_STIPPLE_REPEAT = 0x0B26
        LineStippleRepeat = 2854,
        //
        // Summary:
        //     Original was GL_LIST_MODE = 0x0B30
        ListMode = 2864,
        //
        // Summary:
        //     Original was GL_MAX_LIST_NESTING = 0x0B31
        MaxListNesting = 2865,
        //
        // Summary:
        //     Original was GL_LIST_BASE = 0x0B32
        ListBase = 2866,
        //
        // Summary:
        //     Original was GL_LIST_INDEX = 0x0B33
        ListIndex = 2867,
        //
        // Summary:
        //     Original was GL_POLYGON_MODE = 0x0B40
        PolygonMode = 2880,
        //
        // Summary:
        //     [requires: NV_polygon_mode] Original was GL_POLYGON_MODE_NV = 0x0B40
        PolygonModeNv = 2880,
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
        //     Original was GL_EDGE_FLAG = 0x0B43
        EdgeFlag = 2883,
        //
        // Summary:
        //     Original was GL_CULL_FACE = 0x0B44
        CullFace = 2884,
        //
        // Summary:
        //     Original was GL_CULL_FACE_MODE = 0x0B45
        CullFaceMode = 2885,
        //
        // Summary:
        //     Original was GL_FRONT_FACE = 0x0B46
        FrontFace = 2886,
        //
        // Summary:
        //     Original was GL_LIGHTING = 0x0B50
        Lighting = 2896,
        //
        // Summary:
        //     Original was GL_LIGHT_MODEL_LOCAL_VIEWER = 0x0B51
        LightModelLocalViewer = 2897,
        //
        // Summary:
        //     Original was GL_LIGHT_MODEL_TWO_SIDE = 0x0B52
        LightModelTwoSide = 2898,
        //
        // Summary:
        //     Original was GL_LIGHT_MODEL_AMBIENT = 0x0B53
        LightModelAmbient = 2899,
        //
        // Summary:
        //     Original was GL_SHADE_MODEL = 0x0B54
        ShadeModel = 2900,
        //
        // Summary:
        //     Original was GL_COLOR_MATERIAL_FACE = 0x0B55
        ColorMaterialFace = 2901,
        //
        // Summary:
        //     Original was GL_COLOR_MATERIAL_PARAMETER = 0x0B56
        ColorMaterialParameter = 2902,
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
        //     Original was GL_FOG_INDEX = 0x0B61
        FogIndex = 2913,
        //
        // Summary:
        //     Original was GL_FOG_DENSITY = 0x0B62
        FogDensity = 2914,
        //
        // Summary:
        //     Original was GL_FOG_START = 0x0B63
        FogStart = 2915,
        //
        // Summary:
        //     Original was GL_FOG_END = 0x0B64
        FogEnd = 2916,
        //
        // Summary:
        //     Original was GL_FOG_MODE = 0x0B65
        FogMode = 2917,
        //
        // Summary:
        //     Original was GL_FOG_COLOR = 0x0B66
        FogColor = 2918,
        //
        // Summary:
        //     [requires: NV_viewport_array, or OES_viewport_array] Original was GL_DEPTH_RANGE
        //     = 0x0B70
        DepthRange = 2928,
        //
        // Summary:
        //     Original was GL_DEPTH_TEST = 0x0B71
        DepthTest = 2929,
        //
        // Summary:
        //     Original was GL_DEPTH_WRITEMASK = 0x0B72
        DepthWritemask = 2930,
        //
        // Summary:
        //     Original was GL_DEPTH_CLEAR_VALUE = 0x0B73
        DepthClearValue = 2931,
        //
        // Summary:
        //     Original was GL_DEPTH_FUNC = 0x0B74
        DepthFunc = 2932,
        //
        // Summary:
        //     Original was GL_ACCUM_CLEAR_VALUE = 0x0B80
        AccumClearValue = 2944,
        //
        // Summary:
        //     Original was GL_STENCIL_TEST = 0x0B90
        StencilTest = 2960,
        //
        // Summary:
        //     Original was GL_STENCIL_CLEAR_VALUE = 0x0B91
        StencilClearValue = 2961,
        //
        // Summary:
        //     Original was GL_STENCIL_FUNC = 0x0B92
        StencilFunc = 2962,
        //
        // Summary:
        //     Original was GL_STENCIL_VALUE_MASK = 0x0B93
        StencilValueMask = 2963,
        //
        // Summary:
        //     Original was GL_STENCIL_FAIL = 0x0B94
        StencilFail = 2964,
        //
        // Summary:
        //     Original was GL_STENCIL_PASS_DEPTH_FAIL = 0x0B95
        StencilPassDepthFail = 2965,
        //
        // Summary:
        //     Original was GL_STENCIL_PASS_DEPTH_PASS = 0x0B96
        StencilPassDepthPass = 2966,
        //
        // Summary:
        //     Original was GL_STENCIL_REF = 0x0B97
        StencilRef = 2967,
        //
        // Summary:
        //     Original was GL_STENCIL_WRITEMASK = 0x0B98
        StencilWritemask = 2968,
        //
        // Summary:
        //     Original was GL_MATRIX_MODE = 0x0BA0
        MatrixMode = 2976,
        //
        // Summary:
        //     Original was GL_NORMALIZE = 0x0BA1
        Normalize = 2977,
        //
        // Summary:
        //     Original was GL_Viewport = 0X0ba2
        Viewport = 2978,
        //
        // Summary:
        //     Original was GL_MODELVIEW0_STACK_DEPTH_EXT = 0x0BA3
        Modelview0StackDepthExt = 2979,
        //
        // Summary:
        //     Original was GL_MODELVIEW_STACK_DEPTH = 0x0BA3
        ModelviewStackDepth = 2979,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_PATH_MODELVIEW_STACK_DEPTH_NV =
        //     0x0BA3
        PathModelviewStackDepthNv = 2979,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_PATH_PROJECTION_STACK_DEPTH_NV
        //     = 0x0BA4
        PathProjectionStackDepthNv = 2980,
        //
        // Summary:
        //     Original was GL_PROJECTION_STACK_DEPTH = 0x0BA4
        ProjectionStackDepth = 2980,
        //
        // Summary:
        //     Original was GL_TEXTURE_STACK_DEPTH = 0x0BA5
        TextureStackDepth = 2981,
        //
        // Summary:
        //     Original was GL_MODELVIEW0_MATRIX_EXT = 0x0BA6
        Modelview0MatrixExt = 2982,
        //
        // Summary:
        //     Original was GL_MODELVIEW_MATRIX = 0x0BA6
        ModelviewMatrix = 2982,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_PATH_MODELVIEW_MATRIX_NV = 0x0BA6
        PathModelviewMatrixNv = 2982,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_PATH_PROJECTION_MATRIX_NV = 0x0BA7
        PathProjectionMatrixNv = 2983,
        //
        // Summary:
        //     Original was GL_PROJECTION_MATRIX = 0x0BA7
        ProjectionMatrix = 2983,
        //
        // Summary:
        //     Original was GL_TEXTURE_MATRIX = 0x0BA8
        TextureMatrix = 2984,
        //
        // Summary:
        //     Original was GL_ATTRIB_STACK_DEPTH = 0x0BB0
        AttribStackDepth = 2992,
        //
        // Summary:
        //     Original was GL_CLIENT_ATTRIB_STACK_DEPTH = 0x0BB1
        ClientAttribStackDepth = 2993,
        //
        // Summary:
        //     Original was GL_ALPHA_TEST = 0x0BC0
        AlphaTest = 3008,
        //
        // Summary:
        //     [requires: QCOM_alpha_test] Original was GL_ALPHA_TEST_QCOM = 0x0BC0
        AlphaTestQcom = 3008,
        //
        // Summary:
        //     Original was GL_ALPHA_TEST_FUNC = 0x0BC1
        AlphaTestFunc = 3009,
        //
        // Summary:
        //     [requires: QCOM_alpha_test] Original was GL_ALPHA_TEST_FUNC_QCOM = 0x0BC1
        AlphaTestFuncQcom = 3009,
        //
        // Summary:
        //     Original was GL_ALPHA_TEST_REF = 0x0BC2
        AlphaTestRef = 3010,
        //
        // Summary:
        //     [requires: QCOM_alpha_test] Original was GL_ALPHA_TEST_REF_QCOM = 0x0BC2
        AlphaTestRefQcom = 3010,
        //
        // Summary:
        //     Original was GL_Dither = 0X0bd0
        Dither = 3024,
        //
        // Summary:
        //     Original was GL_BLEND_DST = 0x0BE0
        BlendDst = 3040,
        //
        // Summary:
        //     Original was GL_BLEND_SRC = 0x0BE1
        BlendSrc = 3041,
        //
        // Summary:
        //     Original was GL_Blend = 0X0be2
        Blend = 3042,
        //
        // Summary:
        //     Original was GL_LOGIC_OP_MODE = 0x0BF0
        LogicOpMode = 3056,
        //
        // Summary:
        //     Original was GL_INDEX_LOGIC_OP = 0x0BF1
        IndexLogicOp = 3057,
        //
        // Summary:
        //     Original was GL_LOGIC_OP = 0x0BF1
        LogicOp = 3057,
        //
        // Summary:
        //     Original was GL_COLOR_LOGIC_OP = 0x0BF2
        ColorLogicOp = 3058,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_CUBIC_CURVE_TO_NV = 0x0C
        CubicCurveToNv = 12,
        //
        // Summary:
        //     Original was GL_AUX_BUFFERS = 0x0C00
        AuxBuffers = 3072,
        //
        // Summary:
        //     Original was GL_DRAW_BUFFER = 0x0C01
        DrawBuffer = 3073,
        //
        // Summary:
        //     [requires: EXT_multiview_draw_buffers] Original was GL_DRAW_BUFFER_EXT = 0x0C01
        DrawBufferExt = 3073,
        //
        // Summary:
        //     Original was GL_READ_BUFFER = 0x0C02
        ReadBuffer = 3074,
        //
        // Summary:
        //     [requires: EXT_multiview_draw_buffers] Original was GL_READ_BUFFER_EXT = 0x0C02
        ReadBufferExt = 3074,
        //
        // Summary:
        //     [requires: NV_read_buffer] Original was GL_READ_BUFFER_NV = 0x0C02
        ReadBufferNv = 3074,
        //
        // Summary:
        //     [requires: NV_viewport_array, or OES_viewport_array] Original was GL_SCISSOR_BOX
        //     = 0x0C10
        ScissorBox = 3088,
        //
        // Summary:
        //     [requires: NV_viewport_array, or OES_viewport_array] Original was GL_SCISSOR_TEST
        //     = 0x0C11
        ScissorTest = 3089,
        //
        // Summary:
        //     Original was GL_INDEX_CLEAR_VALUE = 0x0C20
        IndexClearValue = 3104,
        //
        // Summary:
        //     Original was GL_INDEX_WRITEMASK = 0x0C21
        IndexWritemask = 3105,
        //
        // Summary:
        //     Original was GL_COLOR_CLEAR_VALUE = 0x0C22
        ColorClearValue = 3106,
        //
        // Summary:
        //     [requires: EXT_draw_buffers_indexed, or OES_draw_buffers_indexed] Original was
        //     GL_COLOR_WRITEMASK = 0x0C23
        ColorWritemask = 3107,
        //
        // Summary:
        //     Original was GL_INDEX_MODE = 0x0C30
        IndexMode = 3120,
        //
        // Summary:
        //     Original was GL_RGBA_MODE = 0x0C31
        RgbaMode = 3121,
        //
        // Summary:
        //     Original was GL_DOUBLEBUFFER = 0x0C32
        Doublebuffer = 3122,
        //
        // Summary:
        //     Original was GL_STEREO = 0x0C33
        Stereo = 3123,
        //
        // Summary:
        //     Original was GL_RENDER_MODE = 0x0C40
        RenderMode = 3136,
        //
        // Summary:
        //     Original was GL_PERSPECTIVE_CORRECTION_HINT = 0x0C50
        PerspectiveCorrectionHint = 3152,
        //
        // Summary:
        //     Original was GL_POINT_SMOOTH_HINT = 0x0C51
        PointSmoothHint = 3153,
        //
        // Summary:
        //     Original was GL_LINE_SMOOTH_HINT = 0x0C52
        LineSmoothHint = 3154,
        //
        // Summary:
        //     Original was GL_POLYGON_SMOOTH_HINT = 0x0C53
        PolygonSmoothHint = 3155,
        //
        // Summary:
        //     Original was GL_FOG_HINT = 0x0C54
        FogHint = 3156,
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
        //     Original was GL_PIXEL_MAP_I_TO_I = 0x0C70
        PixelMapIToI = 3184,
        //
        // Summary:
        //     Original was GL_PIXEL_MAP_S_TO_S = 0x0C71
        PixelMapSToS = 3185,
        //
        // Summary:
        //     Original was GL_PIXEL_MAP_I_TO_R = 0x0C72
        PixelMapIToR = 3186,
        //
        // Summary:
        //     Original was GL_PIXEL_MAP_I_TO_G = 0x0C73
        PixelMapIToG = 3187,
        //
        // Summary:
        //     Original was GL_PIXEL_MAP_I_TO_B = 0x0C74
        PixelMapIToB = 3188,
        //
        // Summary:
        //     Original was GL_PIXEL_MAP_I_TO_A = 0x0C75
        PixelMapIToA = 3189,
        //
        // Summary:
        //     Original was GL_PIXEL_MAP_R_TO_R = 0x0C76
        PixelMapRToR = 3190,
        //
        // Summary:
        //     Original was GL_PIXEL_MAP_G_TO_G = 0x0C77
        PixelMapGToG = 3191,
        //
        // Summary:
        //     Original was GL_PIXEL_MAP_B_TO_B = 0x0C78
        PixelMapBToB = 3192,
        //
        // Summary:
        //     Original was GL_PIXEL_MAP_A_TO_A = 0x0C79
        PixelMapAToA = 3193,
        //
        // Summary:
        //     Original was GL_PIXEL_MAP_I_TO_I_SIZE = 0x0CB0
        PixelMapIToISize = 3248,
        //
        // Summary:
        //     Original was GL_PIXEL_MAP_S_TO_S_SIZE = 0x0CB1
        PixelMapSToSSize = 3249,
        //
        // Summary:
        //     Original was GL_PIXEL_MAP_I_TO_R_SIZE = 0x0CB2
        PixelMapIToRSize = 3250,
        //
        // Summary:
        //     Original was GL_PIXEL_MAP_I_TO_G_SIZE = 0x0CB3
        PixelMapIToGSize = 3251,
        //
        // Summary:
        //     Original was GL_PIXEL_MAP_I_TO_B_SIZE = 0x0CB4
        PixelMapIToBSize = 3252,
        //
        // Summary:
        //     Original was GL_PIXEL_MAP_I_TO_A_SIZE = 0x0CB5
        PixelMapIToASize = 3253,
        //
        // Summary:
        //     Original was GL_PIXEL_MAP_R_TO_R_SIZE = 0x0CB6
        PixelMapRToRSize = 3254,
        //
        // Summary:
        //     Original was GL_PIXEL_MAP_G_TO_G_SIZE = 0x0CB7
        PixelMapGToGSize = 3255,
        //
        // Summary:
        //     Original was GL_PIXEL_MAP_B_TO_B_SIZE = 0x0CB8
        PixelMapBToBSize = 3256,
        //
        // Summary:
        //     Original was GL_PIXEL_MAP_A_TO_A_SIZE = 0x0CB9
        PixelMapAToASize = 3257,
        //
        // Summary:
        //     Original was GL_UNPACK_SWAP_BYTES = 0x0CF0
        UnpackSwapBytes = 3312,
        //
        // Summary:
        //     Original was GL_UNPACK_LSB_FIRST = 0x0CF1
        UnpackLsbFirst = 3313,
        //
        // Summary:
        //     Original was GL_UNPACK_ROW_LENGTH = 0x0CF2
        UnpackRowLength = 3314,
        //
        // Summary:
        //     [requires: EXT_unpack_subimage] Original was GL_UNPACK_ROW_LENGTH_EXT = 0x0CF2
        UnpackRowLengthExt = 3314,
        //
        // Summary:
        //     Original was GL_UNPACK_SKIP_ROWS = 0x0CF3
        UnpackSkipRows = 3315,
        //
        // Summary:
        //     [requires: EXT_unpack_subimage] Original was GL_UNPACK_SKIP_ROWS_EXT = 0x0CF3
        UnpackSkipRowsExt = 3315,
        //
        // Summary:
        //     Original was GL_UNPACK_SKIP_PIXELS = 0x0CF4
        UnpackSkipPixels = 3316,
        //
        // Summary:
        //     [requires: EXT_unpack_subimage] Original was GL_UNPACK_SKIP_PIXELS_EXT = 0x0CF4
        UnpackSkipPixelsExt = 3316,
        //
        // Summary:
        //     Original was GL_UNPACK_ALIGNMENT = 0x0CF5
        UnpackAlignment = 3317,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_RELATIVE_CUBIC_CURVE_TO_NV = 0x0D
        RelativeCubicCurveToNv = 13,
        //
        // Summary:
        //     Original was GL_PACK_SWAP_BYTES = 0x0D00
        PackSwapBytes = 3328,
        //
        // Summary:
        //     Original was GL_PACK_LSB_FIRST = 0x0D01
        PackLsbFirst = 3329,
        //
        // Summary:
        //     Original was GL_PACK_ROW_LENGTH = 0x0D02
        PackRowLength = 3330,
        //
        // Summary:
        //     Original was GL_PACK_SKIP_ROWS = 0x0D03
        PackSkipRows = 3331,
        //
        // Summary:
        //     Original was GL_PACK_SKIP_PIXELS = 0x0D04
        PackSkipPixels = 3332,
        //
        // Summary:
        //     Original was GL_PACK_ALIGNMENT = 0x0D05
        PackAlignment = 3333,
        //
        // Summary:
        //     Original was GL_MAP_COLOR = 0x0D10
        MapColor = 3344,
        //
        // Summary:
        //     Original was GL_MAP_STENCIL = 0x0D11
        MapStencil = 3345,
        //
        // Summary:
        //     Original was GL_INDEX_SHIFT = 0x0D12
        IndexShift = 3346,
        //
        // Summary:
        //     Original was GL_INDEX_OFFSET = 0x0D13
        IndexOffset = 3347,
        //
        // Summary:
        //     Original was GL_RED_SCALE = 0x0D14
        RedScale = 3348,
        //
        // Summary:
        //     Original was GL_RED_BIAS = 0x0D15
        RedBias = 3349,
        //
        // Summary:
        //     Original was GL_ZOOM_X = 0x0D16
        ZoomX = 3350,
        //
        // Summary:
        //     Original was GL_ZOOM_Y = 0x0D17
        ZoomY = 3351,
        //
        // Summary:
        //     Original was GL_GREEN_SCALE = 0x0D18
        GreenScale = 3352,
        //
        // Summary:
        //     Original was GL_GREEN_BIAS = 0x0D19
        GreenBias = 3353,
        //
        // Summary:
        //     Original was GL_BLUE_SCALE = 0x0D1A
        BlueScale = 3354,
        //
        // Summary:
        //     Original was GL_BLUE_BIAS = 0x0D1B
        BlueBias = 3355,
        //
        // Summary:
        //     Original was GL_ALPHA_SCALE = 0x0D1C
        AlphaScale = 3356,
        //
        // Summary:
        //     Original was GL_ALPHA_BIAS = 0x0D1D
        AlphaBias = 3357,
        //
        // Summary:
        //     Original was GL_DEPTH_SCALE = 0x0D1E
        DepthScale = 3358,
        //
        // Summary:
        //     Original was GL_DEPTH_BIAS = 0x0D1F
        DepthBias = 3359,
        //
        // Summary:
        //     Original was GL_MAX_EVAL_ORDER = 0x0D30
        MaxEvalOrder = 3376,
        //
        // Summary:
        //     Original was GL_MAX_LIGHTS = 0x0D31
        MaxLights = 3377,
        //
        // Summary:
        //     Original was GL_MAX_CLIP_DISTANCES = 0x0D32
        MaxClipDistances = 3378,
        //
        // Summary:
        //     [requires: APPLE_clip_distance] Original was GL_MAX_CLIP_DISTANCES_APPLE = 0x0D32
        MaxClipDistancesApple = 3378,
        //
        // Summary:
        //     [requires: EXT_clip_cull_distance] Original was GL_MAX_CLIP_DISTANCES_EXT = 0x0D32
        MaxClipDistancesExt = 3378,
        //
        // Summary:
        //     Original was GL_MAX_CLIP_PLANES = 0x0D32
        MaxClipPlanes = 3378,
        //
        // Summary:
        //     Original was GL_MAX_TEXTURE_SIZE = 0x0D33
        MaxTextureSize = 3379,
        //
        // Summary:
        //     Original was GL_MAX_PIXEL_MAP_TABLE = 0x0D34
        MaxPixelMapTable = 3380,
        //
        // Summary:
        //     Original was GL_MAX_ATTRIB_STACK_DEPTH = 0x0D35
        MaxAttribStackDepth = 3381,
        //
        // Summary:
        //     Original was GL_MAX_MODELVIEW_STACK_DEPTH = 0x0D36
        MaxModelviewStackDepth = 3382,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_PATH_MAX_MODELVIEW_STACK_DEPTH_NV
        //     = 0x0D36
        PathMaxModelviewStackDepthNv = 3382,
        //
        // Summary:
        //     Original was GL_MAX_NAME_STACK_DEPTH = 0x0D37
        MaxNameStackDepth = 3383,
        //
        // Summary:
        //     Original was GL_MAX_PROJECTION_STACK_DEPTH = 0x0D38
        MaxProjectionStackDepth = 3384,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_PATH_MAX_PROJECTION_STACK_DEPTH_NV
        //     = 0x0D38
        PathMaxProjectionStackDepthNv = 3384,
        //
        // Summary:
        //     Original was GL_MAX_TEXTURE_STACK_DEPTH = 0x0D39
        MaxTextureStackDepth = 3385,
        //
        // Summary:
        //     Original was GL_MAX_VIEWPORT_DIMS = 0x0D3A
        MaxViewportDims = 3386,
        //
        // Summary:
        //     Original was GL_MAX_CLIENT_ATTRIB_STACK_DEPTH = 0x0D3B
        MaxClientAttribStackDepth = 3387,
        //
        // Summary:
        //     Original was GL_SUBPIXEL_BITS = 0x0D50
        SubpixelBits = 3408,
        //
        // Summary:
        //     Original was GL_INDEX_BITS = 0x0D51
        IndexBits = 3409,
        //
        // Summary:
        //     Original was GL_RED_BITS = 0x0D52
        RedBits = 3410,
        //
        // Summary:
        //     Original was GL_GREEN_BITS = 0x0D53
        GreenBits = 3411,
        //
        // Summary:
        //     Original was GL_BLUE_BITS = 0x0D54
        BlueBits = 3412,
        //
        // Summary:
        //     Original was GL_ALPHA_BITS = 0x0D55
        AlphaBits = 3413,
        //
        // Summary:
        //     Original was GL_DEPTH_BITS = 0x0D56
        DepthBits = 3414,
        //
        // Summary:
        //     Original was GL_STENCIL_BITS = 0x0D57
        StencilBits = 3415,
        //
        // Summary:
        //     Original was GL_ACCUM_RED_BITS = 0x0D58
        AccumRedBits = 3416,
        //
        // Summary:
        //     Original was GL_ACCUM_GREEN_BITS = 0x0D59
        AccumGreenBits = 3417,
        //
        // Summary:
        //     Original was GL_ACCUM_BLUE_BITS = 0x0D5A
        AccumBlueBits = 3418,
        //
        // Summary:
        //     Original was GL_ACCUM_ALPHA_BITS = 0x0D5B
        AccumAlphaBits = 3419,
        //
        // Summary:
        //     Original was GL_NAME_STACK_DEPTH = 0x0D70
        NameStackDepth = 3440,
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
        //     Original was GL_MAP1_GRID_DOMAIN = 0x0DD0
        Map1GridDomain = 3536,
        //
        // Summary:
        //     Original was GL_MAP1_GRID_SEGMENTS = 0x0DD1
        Map1GridSegments = 3537,
        //
        // Summary:
        //     Original was GL_MAP2_GRID_DOMAIN = 0x0DD2
        Map2GridDomain = 3538,
        //
        // Summary:
        //     Original was GL_MAP2_GRID_SEGMENTS = 0x0DD3
        Map2GridSegments = 3539,
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
        //     Original was GL_FEEDBACK_BUFFER_POINTER = 0x0DF0
        FeedbackBufferPointer = 3568,
        //
        // Summary:
        //     Original was GL_FEEDBACK_BUFFER_SIZE = 0x0DF1
        FeedbackBufferSize = 3569,
        //
        // Summary:
        //     Original was GL_FEEDBACK_BUFFER_TYPE = 0x0DF2
        FeedbackBufferType = 3570,
        //
        // Summary:
        //     Original was GL_SELECTION_BUFFER_POINTER = 0x0DF3
        SelectionBufferPointer = 3571,
        //
        // Summary:
        //     Original was GL_SELECTION_BUFFER_SIZE = 0x0DF4
        SelectionBufferSize = 3572,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_SMOOTH_QUADRATIC_CURVE_TO_NV =
        //     0x0E
        SmoothQuadraticCurveToNv = 14,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_RELATIVE_SMOOTH_QUADRATIC_CURVE_TO_NV
        //     = 0x0F
        RelativeSmoothQuadraticCurveToNv = 0xF,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_GLYPH_HORIZONTAL_BEARING_ADVANCE_BIT_NV
        //     = 0x10
        GlyphHorizontalBearingAdvanceBitNv = 0x10,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_SMOOTH_CUBIC_CURVE_TO_NV = 0x10
        SmoothCubicCurveToNv = 0x10,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_GLYPH_HAS_KERNING_BIT_NV = 0x100
        GlyphHasKerningBitNv = 0x100,
        //
        // Summary:
        //     Original was GL_TEXTURE_WIDTH = 0x1000
        TextureWidth = 0x1000,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_FONT_HAS_KERNING_BIT_NV = 0x10000000
        FontHasKerningBitNv = 0x10000000,
        //
        // Summary:
        //     [requires: QCOM_tiled_rendering] Original was GL_MULTISAMPLE_BUFFER_BIT4_QCOM
        //     = 0x10000000
        MultisampleBufferBit4Qcom = 0x10000000,
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
        //     [requires: EXT_texture_border_clamp] Original was GL_TEXTURE_BORDER_COLOR_EXT
        //     = 0x1004
        TextureBorderColorExt = 4100,
        //
        // Summary:
        //     [requires: NV_texture_border_clamp] Original was GL_TEXTURE_BORDER_COLOR_NV =
        //     0x1004
        TextureBorderColorNv = 4100,
        //
        // Summary:
        //     [requires: OES_texture_border_clamp] Original was GL_TEXTURE_BORDER_COLOR_OES
        //     = 0x1004
        TextureBorderColorOes = 4100,
        //
        // Summary:
        //     Original was GL_TEXTURE_BORDER = 0x1005
        TextureBorder = 4101,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_RELATIVE_SMOOTH_CUBIC_CURVE_TO_NV
        //     = 0x11
        RelativeSmoothCubicCurveToNv = 17,
        //
        // Summary:
        //     Original was GL_DONT_CARE = 0x1100
        DontCare = 4352,
        //
        // Summary:
        //     Original was GL_Fastest = 0X1101
        Fastest = 4353,
        //
        // Summary:
        //     Original was GL_Nicest = 0X1102
        Nicest = 4354,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_SMALL_CCW_ARC_TO_NV = 0x12
        SmallCcwArcToNv = 18,
        //
        // Summary:
        //     Original was GL_AMBIENT = 0x1200
        Ambient = 4608,
        //
        // Summary:
        //     Original was GL_DIFFUSE = 0x1201
        Diffuse = 4609,
        //
        // Summary:
        //     Original was GL_SPECULAR = 0x1202
        Specular = 4610,
        //
        // Summary:
        //     Original was GL_POSITION = 0x1203
        Position = 4611,
        //
        // Summary:
        //     Original was GL_SPOT_DIRECTION = 0x1204
        SpotDirection = 4612,
        //
        // Summary:
        //     Original was GL_SPOT_EXPONENT = 0x1205
        SpotExponent = 4613,
        //
        // Summary:
        //     Original was GL_SPOT_CUTOFF = 0x1206
        SpotCutoff = 4614,
        //
        // Summary:
        //     Original was GL_CONSTANT_ATTENUATION = 0x1207
        ConstantAttenuation = 4615,
        //
        // Summary:
        //     Original was GL_LINEAR_ATTENUATION = 0x1208
        LinearAttenuation = 4616,
        //
        // Summary:
        //     Original was GL_QUADRATIC_ATTENUATION = 0x1209
        QuadraticAttenuation = 4617,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_RELATIVE_SMALL_CCW_ARC_TO_NV =
        //     0x13
        RelativeSmallCcwArcToNv = 19,
        //
        // Summary:
        //     Original was GL_COMPILE = 0x1300
        Compile = 4864,
        //
        // Summary:
        //     Original was GL_COMPILE_AND_EXECUTE = 0x1301
        CompileAndExecute = 4865,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_SMALL_CW_ARC_TO_NV = 0x14
        SmallCwArcToNv = 20,
        //
        // Summary:
        //     Original was GL_Byte = 0X1400
        Byte = 5120,
        //
        // Summary:
        //     Original was GL_UNSIGNED_BYTE = 0x1401
        UnsignedByte = 5121,
        //
        // Summary:
        //     Original was GL_Short = 0X1402
        Short = 5122,
        //
        // Summary:
        //     [requires: ANGLE_depth_texture, or OES_depth_texture] Original was GL_UNSIGNED_SHORT
        //     = 0x1403
        UnsignedShort = 5123,
        //
        // Summary:
        //     Original was GL_Int = 0X1404
        Int = 5124,
        //
        // Summary:
        //     [requires: ANGLE_depth_texture, or OES_depth_texture, OES_element_index_uint]
        //     Original was GL_UNSIGNED_INT = 0x1405
        UnsignedInt = 5125,
        //
        // Summary:
        //     Original was GL_Float = 0X1406
        Float = 5126,
        //
        // Summary:
        //     Original was GL_2_BYTES = 0x1407
        Gl2Bytes = 5127,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_2_BYTES_NV = 0x1407
        Gl2BytesNv = 5127,
        //
        // Summary:
        //     Original was GL_3_BYTES = 0x1408
        Gl3Bytes = 5128,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_3_BYTES_NV = 0x1408
        Gl3BytesNv = 5128,
        //
        // Summary:
        //     Original was GL_4_BYTES = 0x1409
        Gl4Bytes = 5129,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_4_BYTES_NV = 0x1409
        Gl4BytesNv = 5129,
        //
        // Summary:
        //     Original was GL_DOUBLE = 0x140A
        Double = 5130,
        //
        // Summary:
        //     Original was GL_HALF_FLOAT = 0x140B
        HalfFloat = 5131,
        //
        // Summary:
        //     Original was GL_Fixed = 0X140c
        Fixed = 5132,
        //
        // Summary:
        //     [requires: NV_gpu_shader5] Original was GL_INT64_NV = 0x140E
        Int64Nv = 5134,
        //
        // Summary:
        //     [requires: NV_gpu_shader5] Original was GL_UNSIGNED_INT64_NV = 0x140F
        UnsignedInt64Nv = 5135,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_RELATIVE_SMALL_CW_ARC_TO_NV = 0x15
        RelativeSmallCwArcToNv = 21,
        //
        // Summary:
        //     Original was GL_CLEAR = 0x1500
        Clear = 5376,
        //
        // Summary:
        //     Original was GL_AND = 0x1501
        And = 5377,
        //
        // Summary:
        //     Original was GL_AND_REVERSE = 0x1502
        AndReverse = 5378,
        //
        // Summary:
        //     Original was GL_COPY = 0x1503
        Copy = 5379,
        //
        // Summary:
        //     Original was GL_AND_INVERTED = 0x1504
        AndInverted = 5380,
        //
        // Summary:
        //     Original was GL_NOOP = 0x1505
        Noop = 5381,
        //
        // Summary:
        //     Original was GL_XOR = 0x1506
        Xor = 5382,
        //
        // Summary:
        //     [requires: NV_blend_equation_advanced] Original was GL_XOR_NV = 0x1506
        XorNv = 5382,
        //
        // Summary:
        //     Original was GL_OR = 0x1507
        Or = 5383,
        //
        // Summary:
        //     Original was GL_NOR = 0x1508
        Nor = 5384,
        //
        // Summary:
        //     Original was GL_EQUIV = 0x1509
        Equiv = 5385,
        //
        // Summary:
        //     Original was GL_Invert = 0X150a
        Invert = 5386,
        //
        // Summary:
        //     Original was GL_OR_REVERSE = 0x150B
        OrReverse = 5387,
        //
        // Summary:
        //     Original was GL_COPY_INVERTED = 0x150C
        CopyInverted = 5388,
        //
        // Summary:
        //     Original was GL_OR_INVERTED = 0x150D
        OrInverted = 5389,
        //
        // Summary:
        //     Original was GL_NAND = 0x150E
        Nand = 5390,
        //
        // Summary:
        //     Original was GL_SET = 0x150F
        Set = 5391,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_LARGE_CCW_ARC_TO_NV = 0x16
        LargeCcwArcToNv = 22,
        //
        // Summary:
        //     Original was GL_EMISSION = 0x1600
        Emission = 5632,
        //
        // Summary:
        //     Original was GL_SHININESS = 0x1601
        Shininess = 5633,
        //
        // Summary:
        //     Original was GL_AMBIENT_AND_DIFFUSE = 0x1602
        AmbientAndDiffuse = 5634,
        //
        // Summary:
        //     Original was GL_COLOR_INDEXES = 0x1603
        ColorIndexes = 5635,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_RELATIVE_LARGE_CCW_ARC_TO_NV =
        //     0x17
        RelativeLargeCcwArcToNv = 23,
        //
        // Summary:
        //     Original was GL_MODELVIEW = 0x1700
        Modelview = 5888,
        //
        // Summary:
        //     Original was GL_MODELVIEW0_EXT = 0x1700
        Modelview0Ext = 5888,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_PATH_MODELVIEW_NV = 0x1700
        PathModelviewNv = 5888,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_PATH_PROJECTION_NV = 0x1701
        PathProjectionNv = 5889,
        //
        // Summary:
        //     Original was GL_PROJECTION = 0x1701
        Projection = 5889,
        //
        // Summary:
        //     Original was GL_TEXTURE = 0x1702
        Texture = 5890,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_LARGE_CW_ARC_TO_NV = 0x18
        LargeCwArcToNv = 24,
        //
        // Summary:
        //     Original was GL_COLOR = 0x1800
        Color = 6144,
        //
        // Summary:
        //     [requires: EXT_discard_framebuffer] Original was GL_COLOR_EXT = 0x1800
        ColorExt = 6144,
        //
        // Summary:
        //     Original was GL_DEPTH = 0x1801
        Depth = 6145,
        //
        // Summary:
        //     [requires: EXT_discard_framebuffer] Original was GL_DEPTH_EXT = 0x1801
        DepthExt = 6145,
        //
        // Summary:
        //     Original was GL_STENCIL = 0x1802
        Stencil = 6146,
        //
        // Summary:
        //     [requires: EXT_discard_framebuffer] Original was GL_STENCIL_EXT = 0x1802
        StencilExt = 6146,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_RELATIVE_LARGE_CW_ARC_TO_NV = 0x19
        RelativeLargeCwArcToNv = 25,
        //
        // Summary:
        //     Original was GL_COLOR_INDEX = 0x1900
        ColorIndex = 6400,
        //
        // Summary:
        //     Original was GL_STENCIL_INDEX = 0x1901
        StencilIndex = 6401,
        //
        // Summary:
        //     [requires: OES_texture_stencil8] Original was GL_STENCIL_INDEX_OES = 0x1901
        StencilIndexOes = 6401,
        //
        // Summary:
        //     [requires: ANGLE_depth_texture, or OES_depth_texture] Original was GL_DEPTH_COMPONENT
        //     = 0x1902
        DepthComponent = 6402,
        //
        // Summary:
        //     Original was GL_RED = 0x1903
        Red = 6403,
        //
        // Summary:
        //     [requires: EXT_texture_rg] Original was GL_RED_EXT = 0x1903
        RedExt = 6403,
        //
        // Summary:
        //     [requires: NV_blend_equation_advanced] Original was GL_RED_NV = 0x1903
        RedNv = 6403,
        //
        // Summary:
        //     Original was GL_GREEN = 0x1904
        Green = 6404,
        //
        // Summary:
        //     [requires: NV_blend_equation_advanced] Original was GL_GREEN_NV = 0x1904
        GreenNv = 6404,
        //
        // Summary:
        //     Original was GL_BLUE = 0x1905
        Blue = 6405,
        //
        // Summary:
        //     [requires: NV_blend_equation_advanced] Original was GL_BLUE_NV = 0x1905
        BlueNv = 6405,
        //
        // Summary:
        //     Original was GL_Alpha = 0X1906
        Alpha = 6406,
        //
        // Summary:
        //     Original was GL_Rgb = 0X1907
        Rgb = 6407,
        //
        // Summary:
        //     Original was GL_Rgba = 0X1908
        Rgba = 6408,
        //
        // Summary:
        //     Original was GL_Luminance = 0X1909
        Luminance = 6409,
        //
        // Summary:
        //     Original was GL_LUMINANCE_ALPHA = 0x190A
        LuminanceAlpha = 6410,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_CONIC_CURVE_TO_NV = 0x1A
        ConicCurveToNv = 26,
        //
        // Summary:
        //     Original was GL_BITMAP = 0x1A00
        Bitmap = 6656,
        //
        // Summary:
        //     Original was GL_PREFER_DOUBLEBUFFER_HINT_PGI = 0x1A1F8
        PreferDoublebufferHintPgi = 107000,
        //
        // Summary:
        //     Original was GL_CONSERVE_MEMORY_HINT_PGI = 0x1A1FD
        ConserveMemoryHintPgi = 107005,
        //
        // Summary:
        //     Original was GL_RECLAIM_MEMORY_HINT_PGI = 0x1A1FE
        ReclaimMemoryHintPgi = 107006,
        //
        // Summary:
        //     Original was GL_NATIVE_GRAPHICS_BEGIN_HINT_PGI = 0x1A203
        NativeGraphicsBeginHintPgi = 107011,
        //
        // Summary:
        //     Original was GL_NATIVE_GRAPHICS_END_HINT_PGI = 0x1A204
        NativeGraphicsEndHintPgi = 107012,
        //
        // Summary:
        //     Original was GL_ALWAYS_FAST_HINT_PGI = 0x1A20C
        AlwaysFastHintPgi = 107020,
        //
        // Summary:
        //     Original was GL_ALWAYS_SOFT_HINT_PGI = 0x1A20D
        AlwaysSoftHintPgi = 107021,
        //
        // Summary:
        //     Original was GL_ALLOW_DRAW_OBJ_HINT_PGI = 0x1A20E
        AllowDrawObjHintPgi = 107022,
        //
        // Summary:
        //     Original was GL_ALLOW_DRAW_WIN_HINT_PGI = 0x1A20F
        AllowDrawWinHintPgi = 107023,
        //
        // Summary:
        //     Original was GL_ALLOW_DRAW_FRG_HINT_PGI = 0x1A210
        AllowDrawFrgHintPgi = 107024,
        //
        // Summary:
        //     Original was GL_ALLOW_DRAW_MEM_HINT_PGI = 0x1A211
        AllowDrawMemHintPgi = 107025,
        //
        // Summary:
        //     Original was GL_STRICT_DEPTHFUNC_HINT_PGI = 0x1A216
        StrictDepthfuncHintPgi = 107030,
        //
        // Summary:
        //     Original was GL_STRICT_LIGHTING_HINT_PGI = 0x1A217
        StrictLightingHintPgi = 107031,
        //
        // Summary:
        //     Original was GL_STRICT_SCISSOR_HINT_PGI = 0x1A218
        StrictScissorHintPgi = 107032,
        //
        // Summary:
        //     Original was GL_FULL_STIPPLE_HINT_PGI = 0x1A219
        FullStippleHintPgi = 107033,
        //
        // Summary:
        //     Original was GL_CLIP_NEAR_HINT_PGI = 0x1A220
        ClipNearHintPgi = 107040,
        //
        // Summary:
        //     Original was GL_CLIP_FAR_HINT_PGI = 0x1A221
        ClipFarHintPgi = 107041,
        //
        // Summary:
        //     Original was GL_WIDE_LINE_HINT_PGI = 0x1A222
        WideLineHintPgi = 107042,
        //
        // Summary:
        //     Original was GL_BACK_NORMALS_HINT_PGI = 0x1A223
        BackNormalsHintPgi = 107043,
        //
        // Summary:
        //     Original was GL_VERTEX_DATA_HINT_PGI = 0x1A22A
        VertexDataHintPgi = 107050,
        //
        // Summary:
        //     Original was GL_VERTEX_CONSISTENT_HINT_PGI = 0x1A22B
        VertexConsistentHintPgi = 107051,
        //
        // Summary:
        //     Original was GL_MATERIAL_SIDE_HINT_PGI = 0x1A22C
        MaterialSideHintPgi = 107052,
        //
        // Summary:
        //     Original was GL_MAX_VERTEX_HINT_PGI = 0x1A22D
        MaxVertexHintPgi = 107053,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_RELATIVE_CONIC_CURVE_TO_NV = 0x1B
        RelativeConicCurveToNv = 27,
        //
        // Summary:
        //     Original was GL_POINT = 0x1B00
        Point = 6912,
        //
        // Summary:
        //     [requires: NV_polygon_mode] Original was GL_POINT_NV = 0x1B00
        PointNv = 6912,
        //
        // Summary:
        //     Original was GL_LINE = 0x1B01
        Line = 6913,
        //
        // Summary:
        //     [requires: NV_polygon_mode] Original was GL_LINE_NV = 0x1B01
        LineNv = 6913,
        //
        // Summary:
        //     Original was GL_FILL = 0x1B02
        Fill = 6914,
        //
        // Summary:
        //     [requires: NV_polygon_mode] Original was GL_FILL_NV = 0x1B02
        FillNv = 6914,
        //
        // Summary:
        //     Original was GL_RENDER = 0x1C00
        Render = 7168,
        //
        // Summary:
        //     Original was GL_FEEDBACK = 0x1C01
        Feedback = 7169,
        //
        // Summary:
        //     Original was GL_SELECT = 0x1C02
        Select = 7170,
        //
        // Summary:
        //     Original was GL_FLAT = 0x1D00
        Flat = 7424,
        //
        // Summary:
        //     Original was GL_SMOOTH = 0x1D01
        Smooth = 7425,
        //
        // Summary:
        //     Original was GL_Keep = 0X1e00
        Keep = 7680,
        //
        // Summary:
        //     Original was GL_Replace = 0X1e01
        Replace = 7681,
        //
        // Summary:
        //     Original was GL_Incr = 0X1e02
        Incr = 7682,
        //
        // Summary:
        //     Original was GL_Decr = 0X1e03
        Decr = 7683,
        //
        // Summary:
        //     Original was GL_Vendor = 0X1f00
        Vendor = 7936,
        //
        // Summary:
        //     Original was GL_Renderer = 0X1f01
        Renderer = 7937,
        //
        // Summary:
        //     Original was GL_Version = 0X1f02
        Version = 7938,
        //
        // Summary:
        //     Original was GL_Extensions = 0X1f03
        Extensions = 7939,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_GLYPH_VERTICAL_BEARING_X_BIT_NV
        //     = 0x20
        GlyphVerticalBearingXBitNv = 0x20,
        //
        // Summary:
        //     Original was GL_S = 0x2000
        S = 0x2000,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_FONT_NUM_GLYPH_INDICES_BIT_NV =
        //     0x20000000
        FontNumGlyphIndicesBitNv = 0x20000000,
        //
        // Summary:
        //     Original was GL_MULTISAMPLE_BIT = 0x20000000
        MultisampleBit = 0x20000000,
        //
        // Summary:
        //     Original was GL_MULTISAMPLE_BIT_3DFX = 0x20000000
        MultisampleBit3Dfx = 0x20000000,
        //
        // Summary:
        //     Original was GL_MULTISAMPLE_BIT_ARB = 0x20000000
        MultisampleBitArb = 0x20000000,
        //
        // Summary:
        //     Original was GL_MULTISAMPLE_BIT_EXT = 0x20000000
        MultisampleBitExt = 0x20000000,
        //
        // Summary:
        //     [requires: QCOM_tiled_rendering] Original was GL_MULTISAMPLE_BUFFER_BIT5_QCOM
        //     = 0x20000000
        MultisampleBufferBit5Qcom = 0x20000000,
        //
        // Summary:
        //     Original was GL_T = 0x2001
        T = 8193,
        //
        // Summary:
        //     Original was GL_R = 0x2002
        R = 8194,
        //
        // Summary:
        //     Original was GL_Q = 0x2003
        Q = 8195,
        //
        // Summary:
        //     Original was GL_MODULATE = 0x2100
        Modulate = 8448,
        //
        // Summary:
        //     Original was GL_DECAL = 0x2101
        Decal = 8449,
        //
        // Summary:
        //     Original was GL_TEXTURE_ENV_MODE = 0x2200
        TextureEnvMode = 8704,
        //
        // Summary:
        //     Original was GL_TEXTURE_ENV_COLOR = 0x2201
        TextureEnvColor = 8705,
        //
        // Summary:
        //     Original was GL_TEXTURE_ENV = 0x2300
        TextureEnv = 8960,
        //
        // Summary:
        //     Original was GL_EYE_LINEAR = 0x2400
        EyeLinear = 9216,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_EYE_LINEAR_NV = 0x2400
        EyeLinearNv = 9216,
        //
        // Summary:
        //     Original was GL_OBJECT_LINEAR = 0x2401
        ObjectLinear = 9217,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_OBJECT_LINEAR_NV = 0x2401
        ObjectLinearNv = 9217,
        //
        // Summary:
        //     Original was GL_SPHERE_MAP = 0x2402
        SphereMap = 9218,
        //
        // Summary:
        //     Original was GL_TEXTURE_GEN_MODE = 0x2500
        TextureGenMode = 9472,
        //
        // Summary:
        //     Original was GL_OBJECT_PLANE = 0x2501
        ObjectPlane = 9473,
        //
        // Summary:
        //     Original was GL_EYE_PLANE = 0x2502
        EyePlane = 9474,
        //
        // Summary:
        //     Original was GL_Nearest = 0X2600
        Nearest = 9728,
        //
        // Summary:
        //     Original was GL_Linear = 0X2601
        Linear = 9729,
        //
        // Summary:
        //     Original was GL_NEAREST_MIPMAP_NEAREST = 0x2700
        NearestMipmapNearest = 9984,
        //
        // Summary:
        //     Original was GL_LINEAR_MIPMAP_NEAREST = 0x2701
        LinearMipmapNearest = 9985,
        //
        // Summary:
        //     Original was GL_NEAREST_MIPMAP_LINEAR = 0x2702
        NearestMipmapLinear = 9986,
        //
        // Summary:
        //     Original was GL_LINEAR_MIPMAP_LINEAR = 0x2703
        LinearMipmapLinear = 9987,
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
        //     Original was GL_CLAMP = 0x2900
        Clamp = 10496,
        //
        // Summary:
        //     Original was GL_REPEAT = 0x2901
        Repeat = 10497,
        //
        // Summary:
        //     Original was GL_POLYGON_OFFSET_UNITS = 0x2A00
        PolygonOffsetUnits = 10752,
        //
        // Summary:
        //     Original was GL_POLYGON_OFFSET_POINT = 0x2A01
        PolygonOffsetPoint = 10753,
        //
        // Summary:
        //     [requires: NV_polygon_mode] Original was GL_POLYGON_OFFSET_POINT_NV = 0x2A01
        PolygonOffsetPointNv = 10753,
        //
        // Summary:
        //     Original was GL_POLYGON_OFFSET_LINE = 0x2A02
        PolygonOffsetLine = 10754,
        //
        // Summary:
        //     [requires: NV_polygon_mode] Original was GL_POLYGON_OFFSET_LINE_NV = 0x2A02
        PolygonOffsetLineNv = 10754,
        //
        // Summary:
        //     Original was GL_R3_G3_B2 = 0x2A10
        R3G3B2 = 10768,
        //
        // Summary:
        //     Original was GL_V2F = 0x2A20
        V2f = 10784,
        //
        // Summary:
        //     Original was GL_V3F = 0x2A21
        V3f = 10785,
        //
        // Summary:
        //     Original was GL_C4UB_V2F = 0x2A22
        C4ubV2f = 10786,
        //
        // Summary:
        //     Original was GL_C4UB_V3F = 0x2A23
        C4ubV3f = 10787,
        //
        // Summary:
        //     Original was GL_C3F_V3F = 0x2A24
        C3fV3f = 10788,
        //
        // Summary:
        //     Original was GL_N3F_V3F = 0x2A25
        N3fV3f = 10789,
        //
        // Summary:
        //     Original was GL_C4F_N3F_V3F = 0x2A26
        C4fN3fV3f = 10790,
        //
        // Summary:
        //     Original was GL_T2F_V3F = 0x2A27
        T2fV3f = 10791,
        //
        // Summary:
        //     Original was GL_T4F_V4F = 0x2A28
        T4fV4f = 10792,
        //
        // Summary:
        //     Original was GL_T2F_C4UB_V3F = 0x2A29
        T2fC4ubV3f = 10793,
        //
        // Summary:
        //     Original was GL_T2F_C3F_V3F = 0x2A2A
        T2fC3fV3f = 10794,
        //
        // Summary:
        //     Original was GL_T2F_N3F_V3F = 0x2A2B
        T2fN3fV3f = 10795,
        //
        // Summary:
        //     Original was GL_T2F_C4F_N3F_V3F = 0x2A2C
        T2fC4fN3fV3f = 10796,
        //
        // Summary:
        //     Original was GL_T4F_C4F_N3F_V4F = 0x2A2D
        T4fC4fN3fV4f = 10797,
        //
        // Summary:
        //     Original was GL_CLIP_DISTANCE0 = 0x3000
        ClipDistance0 = 12288,
        //
        // Summary:
        //     [requires: APPLE_clip_distance] Original was GL_CLIP_DISTANCE0_APPLE = 0x3000
        ClipDistance0Apple = 12288,
        //
        // Summary:
        //     [requires: EXT_clip_cull_distance] Original was GL_CLIP_DISTANCE0_EXT = 0x3000
        ClipDistance0Ext = 12288,
        //
        // Summary:
        //     Original was GL_CLIP_PLANE0 = 0x3000
        ClipPlane0 = 12288,
        //
        // Summary:
        //     Original was GL_CLIP_DISTANCE1 = 0x3001
        ClipDistance1 = 12289,
        //
        // Summary:
        //     [requires: APPLE_clip_distance] Original was GL_CLIP_DISTANCE1_APPLE = 0x3001
        ClipDistance1Apple = 12289,
        //
        // Summary:
        //     [requires: EXT_clip_cull_distance] Original was GL_CLIP_DISTANCE1_EXT = 0x3001
        ClipDistance1Ext = 12289,
        //
        // Summary:
        //     Original was GL_CLIP_PLANE1 = 0x3001
        ClipPlane1 = 12289,
        //
        // Summary:
        //     Original was GL_CLIP_DISTANCE2 = 0x3002
        ClipDistance2 = 12290,
        //
        // Summary:
        //     [requires: APPLE_clip_distance] Original was GL_CLIP_DISTANCE2_APPLE = 0x3002
        ClipDistance2Apple = 12290,
        //
        // Summary:
        //     [requires: EXT_clip_cull_distance] Original was GL_CLIP_DISTANCE2_EXT = 0x3002
        ClipDistance2Ext = 12290,
        //
        // Summary:
        //     Original was GL_CLIP_PLANE2 = 0x3002
        ClipPlane2 = 12290,
        //
        // Summary:
        //     Original was GL_CLIP_DISTANCE3 = 0x3003
        ClipDistance3 = 12291,
        //
        // Summary:
        //     [requires: APPLE_clip_distance] Original was GL_CLIP_DISTANCE3_APPLE = 0x3003
        ClipDistance3Apple = 12291,
        //
        // Summary:
        //     [requires: EXT_clip_cull_distance] Original was GL_CLIP_DISTANCE3_EXT = 0x3003
        ClipDistance3Ext = 12291,
        //
        // Summary:
        //     Original was GL_CLIP_PLANE3 = 0x3003
        ClipPlane3 = 12291,
        //
        // Summary:
        //     Original was GL_CLIP_DISTANCE4 = 0x3004
        ClipDistance4 = 12292,
        //
        // Summary:
        //     [requires: APPLE_clip_distance] Original was GL_CLIP_DISTANCE4_APPLE = 0x3004
        ClipDistance4Apple = 12292,
        //
        // Summary:
        //     [requires: EXT_clip_cull_distance] Original was GL_CLIP_DISTANCE4_EXT = 0x3004
        ClipDistance4Ext = 12292,
        //
        // Summary:
        //     Original was GL_CLIP_PLANE4 = 0x3004
        ClipPlane4 = 12292,
        //
        // Summary:
        //     Original was GL_CLIP_DISTANCE5 = 0x3005
        ClipDistance5 = 12293,
        //
        // Summary:
        //     [requires: APPLE_clip_distance] Original was GL_CLIP_DISTANCE5_APPLE = 0x3005
        ClipDistance5Apple = 12293,
        //
        // Summary:
        //     [requires: EXT_clip_cull_distance] Original was GL_CLIP_DISTANCE5_EXT = 0x3005
        ClipDistance5Ext = 12293,
        //
        // Summary:
        //     Original was GL_CLIP_PLANE5 = 0x3005
        ClipPlane5 = 12293,
        //
        // Summary:
        //     Original was GL_CLIP_DISTANCE6 = 0x3006
        ClipDistance6 = 12294,
        //
        // Summary:
        //     [requires: APPLE_clip_distance] Original was GL_CLIP_DISTANCE6_APPLE = 0x3006
        ClipDistance6Apple = 12294,
        //
        // Summary:
        //     [requires: EXT_clip_cull_distance] Original was GL_CLIP_DISTANCE6_EXT = 0x3006
        ClipDistance6Ext = 12294,
        //
        // Summary:
        //     Original was GL_CLIP_DISTANCE7 = 0x3007
        ClipDistance7 = 12295,
        //
        // Summary:
        //     [requires: APPLE_clip_distance] Original was GL_CLIP_DISTANCE7_APPLE = 0x3007
        ClipDistance7Apple = 12295,
        //
        // Summary:
        //     [requires: EXT_clip_cull_distance] Original was GL_CLIP_DISTANCE7_EXT = 0x3007
        ClipDistance7Ext = 12295,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_GLYPH_VERTICAL_BEARING_Y_BIT_NV
        //     = 0x40
        GlyphVerticalBearingYBitNv = 0x40,
        //
        // Summary:
        //     Original was GL_LIGHT0 = 0x4000
        Light0 = 0x4000,
        //
        // Summary:
        //     [requires: QCOM_tiled_rendering] Original was GL_MULTISAMPLE_BUFFER_BIT6_QCOM
        //     = 0x40000000
        MultisampleBufferBit6Qcom = 0x40000000,
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
        //     [requires: NV_path_rendering] Original was GL_GLYPH_VERTICAL_BEARING_ADVANCE_BIT_NV
        //     = 0x80
        GlyphVerticalBearingAdvanceBitNv = 0x80,
        //
        // Summary:
        //     Original was GL_ABGR_EXT = 0x8000
        AbgrExt = 0x8000,
        //
        // Summary:
        //     [requires: QCOM_tiled_rendering] Original was GL_MULTISAMPLE_BUFFER_BIT7_QCOM
        //     = 0x80000000
        MultisampleBufferBit7Qcom = int.MinValue,
        //
        // Summary:
        //     [requires: EXT_draw_buffers_indexed, or OES_draw_buffers_indexed] Original was
        //     GL_CONSTANT_COLOR = 0x8001
        ConstantColor = 32769,
        //
        // Summary:
        //     [requires: EXT_draw_buffers_indexed, or OES_draw_buffers_indexed] Original was
        //     GL_ONE_MINUS_CONSTANT_COLOR = 0x8002
        OneMinusConstantColor = 32770,
        //
        // Summary:
        //     [requires: EXT_draw_buffers_indexed, or OES_draw_buffers_indexed] Original was
        //     GL_CONSTANT_ALPHA = 0x8003
        ConstantAlpha = 32771,
        //
        // Summary:
        //     [requires: EXT_draw_buffers_indexed, or OES_draw_buffers_indexed] Original was
        //     GL_ONE_MINUS_CONSTANT_ALPHA = 0x8004
        OneMinusConstantAlpha = 32772,
        //
        // Summary:
        //     Original was GL_BLEND_COLOR = 0x8005
        BlendColor = 32773,
        //
        // Summary:
        //     Original was GL_BLEND_COLOR_EXT = 0x8005
        BlendColorExt = 32773,
        //
        // Summary:
        //     [requires: EXT_draw_buffers_indexed, or OES_draw_buffers_indexed] Original was
        //     GL_FUNC_ADD = 0x8006
        FuncAdd = 32774,
        //
        // Summary:
        //     [requires: EXT_blend_minmax] Original was GL_FUNC_ADD_EXT = 0x8006
        FuncAddExt = 32774,
        //
        // Summary:
        //     [requires: EXT_draw_buffers_indexed, or OES_draw_buffers_indexed] Original was
        //     GL_MIN = 0x8007
        Min = 32775,
        //
        // Summary:
        //     [requires: EXT_blend_minmax] Original was GL_MIN_EXT = 0x8007
        MinExt = 32775,
        //
        // Summary:
        //     [requires: EXT_draw_buffers_indexed, or OES_draw_buffers_indexed] Original was
        //     GL_MAX = 0x8008
        Max = 32776,
        //
        // Summary:
        //     [requires: EXT_blend_minmax] Original was GL_MAX_EXT = 0x8008
        MaxExt = 32776,
        //
        // Summary:
        //     Original was GL_BLEND_EQUATION = 0x8009
        BlendEquation = 32777,
        //
        // Summary:
        //     [requires: EXT_blend_minmax] Original was GL_BLEND_EQUATION_EXT = 0x8009
        BlendEquationExt = 32777,
        //
        // Summary:
        //     [requires: EXT_draw_buffers_indexed, or OES_draw_buffers_indexed] Original was
        //     GL_BLEND_EQUATION_RGB = 0x8009
        BlendEquationRgb = 32777,
        //
        // Summary:
        //     [requires: EXT_draw_buffers_indexed, or OES_draw_buffers_indexed] Original was
        //     GL_FUNC_SUBTRACT = 0x800A
        FuncSubtract = 32778,
        //
        // Summary:
        //     Original was GL_FUNC_SUBTRACT_EXT = 0x800A
        FuncSubtractExt = 32778,
        //
        // Summary:
        //     [requires: EXT_draw_buffers_indexed, or OES_draw_buffers_indexed] Original was
        //     GL_FUNC_REVERSE_SUBTRACT = 0x800B
        FuncReverseSubtract = 32779,
        //
        // Summary:
        //     Original was GL_FUNC_REVERSE_SUBTRACT_EXT = 0x800B
        FuncReverseSubtractExt = 32779,
        //
        // Summary:
        //     Original was GL_CMYK_EXT = 0x800C
        CmykExt = 32780,
        //
        // Summary:
        //     Original was GL_CMYKA_EXT = 0x800D
        CmykaExt = 32781,
        //
        // Summary:
        //     Original was GL_PACK_CMYK_HINT_EXT = 0x800E
        PackCmykHintExt = 32782,
        //
        // Summary:
        //     Original was GL_UNPACK_CMYK_HINT_EXT = 0x800F
        UnpackCmykHintExt = 32783,
        //
        // Summary:
        //     Original was GL_CONVOLUTION_1D = 0x8010
        Convolution1D = 32784,
        //
        // Summary:
        //     Original was GL_CONVOLUTION_1D_EXT = 0x8010
        Convolution1DExt = 32784,
        //
        // Summary:
        //     Original was GL_CONVOLUTION_2D = 0x8011
        Convolution2D = 32785,
        //
        // Summary:
        //     Original was GL_CONVOLUTION_2D_EXT = 0x8011
        Convolution2DExt = 32785,
        //
        // Summary:
        //     Original was GL_SEPARABLE_2D = 0x8012
        Separable2D = 32786,
        //
        // Summary:
        //     Original was GL_SEPARABLE_2D_EXT = 0x8012
        Separable2DExt = 32786,
        //
        // Summary:
        //     Original was GL_CONVOLUTION_BORDER_MODE = 0x8013
        ConvolutionBorderMode = 32787,
        //
        // Summary:
        //     Original was GL_CONVOLUTION_BORDER_MODE_EXT = 0x8013
        ConvolutionBorderModeExt = 32787,
        //
        // Summary:
        //     Original was GL_CONVOLUTION_FILTER_SCALE = 0x8014
        ConvolutionFilterScale = 32788,
        //
        // Summary:
        //     Original was GL_CONVOLUTION_FILTER_SCALE_EXT = 0x8014
        ConvolutionFilterScaleExt = 32788,
        //
        // Summary:
        //     Original was GL_CONVOLUTION_FILTER_BIAS = 0x8015
        ConvolutionFilterBias = 32789,
        //
        // Summary:
        //     Original was GL_CONVOLUTION_FILTER_BIAS_EXT = 0x8015
        ConvolutionFilterBiasExt = 32789,
        //
        // Summary:
        //     Original was GL_REDUCE = 0x8016
        Reduce = 32790,
        //
        // Summary:
        //     Original was GL_REDUCE_EXT = 0x8016
        ReduceExt = 32790,
        //
        // Summary:
        //     Original was GL_CONVOLUTION_FORMAT = 0x8017
        ConvolutionFormat = 32791,
        //
        // Summary:
        //     Original was GL_CONVOLUTION_FORMAT_EXT = 0x8017
        ConvolutionFormatExt = 32791,
        //
        // Summary:
        //     Original was GL_CONVOLUTION_WIDTH = 0x8018
        ConvolutionWidth = 32792,
        //
        // Summary:
        //     Original was GL_CONVOLUTION_WIDTH_EXT = 0x8018
        ConvolutionWidthExt = 32792,
        //
        // Summary:
        //     Original was GL_CONVOLUTION_HEIGHT = 0x8019
        ConvolutionHeight = 32793,
        //
        // Summary:
        //     Original was GL_CONVOLUTION_HEIGHT_EXT = 0x8019
        ConvolutionHeightExt = 32793,
        //
        // Summary:
        //     Original was GL_MAX_CONVOLUTION_WIDTH = 0x801A
        MaxConvolutionWidth = 32794,
        //
        // Summary:
        //     Original was GL_MAX_CONVOLUTION_WIDTH_EXT = 0x801A
        MaxConvolutionWidthExt = 32794,
        //
        // Summary:
        //     Original was GL_MAX_CONVOLUTION_HEIGHT = 0x801B
        MaxConvolutionHeight = 32795,
        //
        // Summary:
        //     Original was GL_MAX_CONVOLUTION_HEIGHT_EXT = 0x801B
        MaxConvolutionHeightExt = 32795,
        //
        // Summary:
        //     Original was GL_POST_CONVOLUTION_RED_SCALE = 0x801C
        PostConvolutionRedScale = 32796,
        //
        // Summary:
        //     Original was GL_POST_CONVOLUTION_RED_SCALE_EXT = 0x801C
        PostConvolutionRedScaleExt = 32796,
        //
        // Summary:
        //     Original was GL_POST_CONVOLUTION_GREEN_SCALE = 0x801D
        PostConvolutionGreenScale = 32797,
        //
        // Summary:
        //     Original was GL_POST_CONVOLUTION_GREEN_SCALE_EXT = 0x801D
        PostConvolutionGreenScaleExt = 32797,
        //
        // Summary:
        //     Original was GL_POST_CONVOLUTION_BLUE_SCALE = 0x801E
        PostConvolutionBlueScale = 32798,
        //
        // Summary:
        //     Original was GL_POST_CONVOLUTION_BLUE_SCALE_EXT = 0x801E
        PostConvolutionBlueScaleExt = 32798,
        //
        // Summary:
        //     Original was GL_POST_CONVOLUTION_ALPHA_SCALE = 0x801F
        PostConvolutionAlphaScale = 32799,
        //
        // Summary:
        //     Original was GL_POST_CONVOLUTION_ALPHA_SCALE_EXT = 0x801F
        PostConvolutionAlphaScaleExt = 32799,
        //
        // Summary:
        //     Original was GL_POST_CONVOLUTION_RED_BIAS = 0x8020
        PostConvolutionRedBias = 32800,
        //
        // Summary:
        //     Original was GL_POST_CONVOLUTION_RED_BIAS_EXT = 0x8020
        PostConvolutionRedBiasExt = 32800,
        //
        // Summary:
        //     Original was GL_POST_CONVOLUTION_GREEN_BIAS = 0x8021
        PostConvolutionGreenBias = 32801,
        //
        // Summary:
        //     Original was GL_POST_CONVOLUTION_GREEN_BIAS_EXT = 0x8021
        PostConvolutionGreenBiasExt = 32801,
        //
        // Summary:
        //     Original was GL_POST_CONVOLUTION_BLUE_BIAS = 0x8022
        PostConvolutionBlueBias = 32802,
        //
        // Summary:
        //     Original was GL_POST_CONVOLUTION_BLUE_BIAS_EXT = 0x8022
        PostConvolutionBlueBiasExt = 32802,
        //
        // Summary:
        //     Original was GL_POST_CONVOLUTION_ALPHA_BIAS = 0x8023
        PostConvolutionAlphaBias = 32803,
        //
        // Summary:
        //     Original was GL_POST_CONVOLUTION_ALPHA_BIAS_EXT = 0x8023
        PostConvolutionAlphaBiasExt = 32803,
        //
        // Summary:
        //     Original was GL_HISTOGRAM = 0x8024
        Histogram = 32804,
        //
        // Summary:
        //     Original was GL_HISTOGRAM_EXT = 0x8024
        HistogramExt = 32804,
        //
        // Summary:
        //     Original was GL_PROXY_HISTOGRAM = 0x8025
        ProxyHistogram = 32805,
        //
        // Summary:
        //     Original was GL_PROXY_HISTOGRAM_EXT = 0x8025
        ProxyHistogramExt = 32805,
        //
        // Summary:
        //     Original was GL_HISTOGRAM_WIDTH = 0x8026
        HistogramWidth = 32806,
        //
        // Summary:
        //     Original was GL_HISTOGRAM_WIDTH_EXT = 0x8026
        HistogramWidthExt = 32806,
        //
        // Summary:
        //     Original was GL_HISTOGRAM_FORMAT = 0x8027
        HistogramFormat = 32807,
        //
        // Summary:
        //     Original was GL_HISTOGRAM_FORMAT_EXT = 0x8027
        HistogramFormatExt = 32807,
        //
        // Summary:
        //     Original was GL_HISTOGRAM_RED_SIZE = 0x8028
        HistogramRedSize = 32808,
        //
        // Summary:
        //     Original was GL_HISTOGRAM_RED_SIZE_EXT = 0x8028
        HistogramRedSizeExt = 32808,
        //
        // Summary:
        //     Original was GL_HISTOGRAM_GREEN_SIZE = 0x8029
        HistogramGreenSize = 32809,
        //
        // Summary:
        //     Original was GL_HISTOGRAM_GREEN_SIZE_EXT = 0x8029
        HistogramGreenSizeExt = 32809,
        //
        // Summary:
        //     Original was GL_HISTOGRAM_BLUE_SIZE = 0x802A
        HistogramBlueSize = 32810,
        //
        // Summary:
        //     Original was GL_HISTOGRAM_BLUE_SIZE_EXT = 0x802A
        HistogramBlueSizeExt = 32810,
        //
        // Summary:
        //     Original was GL_HISTOGRAM_ALPHA_SIZE = 0x802B
        HistogramAlphaSize = 32811,
        //
        // Summary:
        //     Original was GL_HISTOGRAM_ALPHA_SIZE_EXT = 0x802B
        HistogramAlphaSizeExt = 32811,
        //
        // Summary:
        //     Original was GL_HISTOGRAM_LUMINANCE_SIZE = 0x802C
        HistogramLuminanceSize = 32812,
        //
        // Summary:
        //     Original was GL_HISTOGRAM_LUMINANCE_SIZE_EXT = 0x802C
        HistogramLuminanceSizeExt = 32812,
        //
        // Summary:
        //     Original was GL_HISTOGRAM_SINK = 0x802D
        HistogramSink = 32813,
        //
        // Summary:
        //     Original was GL_HISTOGRAM_SINK_EXT = 0x802D
        HistogramSinkExt = 32813,
        //
        // Summary:
        //     Original was GL_MINMAX = 0x802E
        Minmax = 32814,
        //
        // Summary:
        //     Original was GL_MINMAX_EXT = 0x802E
        MinmaxExt = 32814,
        //
        // Summary:
        //     Original was GL_MINMAX_FORMAT = 0x802F
        MinmaxFormat = 32815,
        //
        // Summary:
        //     Original was GL_MINMAX_FORMAT_EXT = 0x802F
        MinmaxFormatExt = 32815,
        //
        // Summary:
        //     Original was GL_MINMAX_SINK = 0x8030
        MinmaxSink = 32816,
        //
        // Summary:
        //     Original was GL_MINMAX_SINK_EXT = 0x8030
        MinmaxSinkExt = 32816,
        //
        // Summary:
        //     Original was GL_TABLE_TOO_LARGE = 0x8031
        TableTooLarge = 32817,
        //
        // Summary:
        //     Original was GL_TABLE_TOO_LARGE_EXT = 0x8031
        TableTooLargeExt = 32817,
        //
        // Summary:
        //     Original was GL_UNSIGNED_BYTE_3_3_2 = 0x8032
        UnsignedByte332 = 32818,
        //
        // Summary:
        //     Original was GL_UNSIGNED_BYTE_3_3_2_EXT = 0x8032
        UnsignedByte332Ext = 32818,
        //
        // Summary:
        //     Original was GL_UNSIGNED_SHORT_4_4_4_4 = 0x8033
        UnsignedShort4444 = 32819,
        //
        // Summary:
        //     Original was GL_UNSIGNED_SHORT_4_4_4_4_EXT = 0x8033
        UnsignedShort4444Ext = 32819,
        //
        // Summary:
        //     Original was GL_UNSIGNED_SHORT_5_5_5_1 = 0x8034
        UnsignedShort5551 = 32820,
        //
        // Summary:
        //     Original was GL_UNSIGNED_SHORT_5_5_5_1_EXT = 0x8034
        UnsignedShort5551Ext = 32820,
        //
        // Summary:
        //     Original was GL_UNSIGNED_INT_8_8_8_8 = 0x8035
        UnsignedInt8888 = 32821,
        //
        // Summary:
        //     Original was GL_UNSIGNED_INT_8_8_8_8_EXT = 0x8035
        UnsignedInt8888Ext = 32821,
        //
        // Summary:
        //     Original was GL_UNSIGNED_INT_10_10_10_2 = 0x8036
        UnsignedInt1010102 = 32822,
        //
        // Summary:
        //     Original was GL_UNSIGNED_INT_10_10_10_2_EXT = 0x8036
        UnsignedInt1010102Ext = 32822,
        //
        // Summary:
        //     Original was GL_POLYGON_OFFSET_FILL = 0x8037
        PolygonOffsetFill = 32823,
        //
        // Summary:
        //     Original was GL_POLYGON_OFFSET_FACTOR = 0x8038
        PolygonOffsetFactor = 32824,
        //
        // Summary:
        //     Original was GL_POLYGON_OFFSET_BIAS_EXT = 0x8039
        PolygonOffsetBiasExt = 32825,
        //
        // Summary:
        //     Original was GL_RESCALE_NORMAL_EXT = 0x803A
        RescaleNormalExt = 32826,
        //
        // Summary:
        //     Original was GL_ALPHA4 = 0x803B
        Alpha4 = 32827,
        //
        // Summary:
        //     Original was GL_ALPHA8 = 0x803C
        Alpha8 = 32828,
        //
        // Summary:
        //     [requires: EXT_texture_storage] Original was GL_ALPHA8_EXT = 0x803C
        Alpha8Ext = 32828,
        //
        // Summary:
        //     [requires: OES_required_internalformat] Original was GL_ALPHA8_OES = 0x803C
        Alpha8Oes = 32828,
        //
        // Summary:
        //     Original was GL_ALPHA12 = 0x803D
        Alpha12 = 32829,
        //
        // Summary:
        //     Original was GL_ALPHA16 = 0x803E
        Alpha16 = 32830,
        //
        // Summary:
        //     Original was GL_LUMINANCE4 = 0x803F
        Luminance4 = 32831,
        //
        // Summary:
        //     Original was GL_LUMINANCE8 = 0x8040
        Luminance8 = 32832,
        //
        // Summary:
        //     [requires: EXT_texture_storage] Original was GL_LUMINANCE8_EXT = 0x8040
        Luminance8Ext = 32832,
        //
        // Summary:
        //     [requires: OES_required_internalformat] Original was GL_LUMINANCE8_OES = 0x8040
        Luminance8Oes = 32832,
        //
        // Summary:
        //     Original was GL_LUMINANCE12 = 0x8041
        Luminance12 = 32833,
        //
        // Summary:
        //     Original was GL_LUMINANCE16 = 0x8042
        Luminance16 = 32834,
        //
        // Summary:
        //     Original was GL_LUMINANCE4_ALPHA4 = 0x8043
        Luminance4Alpha4 = 32835,
        //
        // Summary:
        //     [requires: OES_required_internalformat] Original was GL_LUMINANCE4_ALPHA4_OES
        //     = 0x8043
        Luminance4Alpha4Oes = 32835,
        //
        // Summary:
        //     Original was GL_LUMINANCE6_ALPHA2 = 0x8044
        Luminance6Alpha2 = 32836,
        //
        // Summary:
        //     Original was GL_LUMINANCE8_ALPHA8 = 0x8045
        Luminance8Alpha8 = 32837,
        //
        // Summary:
        //     [requires: EXT_texture_storage] Original was GL_LUMINANCE8_ALPHA8_EXT = 0x8045
        Luminance8Alpha8Ext = 32837,
        //
        // Summary:
        //     [requires: OES_required_internalformat] Original was GL_LUMINANCE8_ALPHA8_OES
        //     = 0x8045
        Luminance8Alpha8Oes = 32837,
        //
        // Summary:
        //     Original was GL_LUMINANCE12_ALPHA4 = 0x8046
        Luminance12Alpha4 = 32838,
        //
        // Summary:
        //     Original was GL_LUMINANCE12_ALPHA12 = 0x8047
        Luminance12Alpha12 = 32839,
        //
        // Summary:
        //     Original was GL_LUMINANCE16_ALPHA16 = 0x8048
        Luminance16Alpha16 = 32840,
        //
        // Summary:
        //     Original was GL_INTENSITY = 0x8049
        Intensity = 32841,
        //
        // Summary:
        //     Original was GL_INTENSITY4 = 0x804A
        Intensity4 = 32842,
        //
        // Summary:
        //     Original was GL_INTENSITY8 = 0x804B
        Intensity8 = 32843,
        //
        // Summary:
        //     Original was GL_INTENSITY12 = 0x804C
        Intensity12 = 32844,
        //
        // Summary:
        //     Original was GL_INTENSITY16 = 0x804D
        Intensity16 = 32845,
        //
        // Summary:
        //     Original was GL_RGB2_EXT = 0x804E
        Rgb2Ext = 32846,
        //
        // Summary:
        //     Original was GL_RGB4 = 0x804F
        Rgb4 = 32847,
        //
        // Summary:
        //     Original was GL_RGB4_EXT = 0x804F
        Rgb4Ext = 32847,
        //
        // Summary:
        //     Original was GL_RGB5 = 0x8050
        Rgb5 = 32848,
        //
        // Summary:
        //     Original was GL_RGB5_EXT = 0x8050
        Rgb5Ext = 32848,
        //
        // Summary:
        //     Original was GL_RGB8 = 0x8051
        Rgb8 = 32849,
        //
        // Summary:
        //     Original was GL_RGB8_EXT = 0x8051
        Rgb8Ext = 32849,
        //
        // Summary:
        //     [requires: OES_required_internalformat, or OES_rgb8_rgba8] Original was GL_RGB8_OES
        //     = 0x8051
        Rgb8Oes = 32849,
        //
        // Summary:
        //     Original was GL_RGB10 = 0x8052
        Rgb10 = 32850,
        //
        // Summary:
        //     [requires: EXT_texture_storage, or OES_required_internalformat] Original was
        //     GL_RGB10_EXT = 0x8052
        Rgb10Ext = 32850,
        //
        // Summary:
        //     Original was GL_RGB12 = 0x8053
        Rgb12 = 32851,
        //
        // Summary:
        //     Original was GL_RGB12_EXT = 0x8053
        Rgb12Ext = 32851,
        //
        // Summary:
        //     Original was GL_RGB16 = 0x8054
        Rgb16 = 32852,
        //
        // Summary:
        //     [requires: EXT_texture_norm16] Original was GL_RGB16_EXT = 0x8054
        Rgb16Ext = 32852,
        //
        // Summary:
        //     Original was GL_RGBA4_EXT = 0x8056
        Rgba4Ext = 32854,
        //
        // Summary:
        //     [requires: OES_required_internalformat] Original was GL_RGBA4_OES = 0x8056
        Rgba4Oes = 32854,
        //
        // Summary:
        //     Original was GL_Rgba4 = 0X8056
        Rgba4 = 32854,
        //
        // Summary:
        //     Original was GL_RGB5_A1 = 0x8057
        Rgb5A1 = 32855,
        //
        // Summary:
        //     Original was GL_RGB5_A1_EXT = 0x8057
        Rgb5A1Ext = 32855,
        //
        // Summary:
        //     [requires: OES_required_internalformat] Original was GL_RGB5_A1_OES = 0x8057
        Rgb5A1Oes = 32855,
        //
        // Summary:
        //     Original was GL_RGBA8 = 0x8058
        Rgba8 = 32856,
        //
        // Summary:
        //     Original was GL_RGBA8_EXT = 0x8058
        Rgba8Ext = 32856,
        //
        // Summary:
        //     [requires: OES_required_internalformat, or OES_rgb8_rgba8] Original was GL_RGBA8_OES
        //     = 0x8058
        Rgba8Oes = 32856,
        //
        // Summary:
        //     Original was GL_RGB10_A2 = 0x8059
        Rgb10A2 = 32857,
        //
        // Summary:
        //     [requires: EXT_texture_storage, or OES_required_internalformat] Original was
        //     GL_RGB10_A2_EXT = 0x8059
        Rgb10A2Ext = 32857,
        //
        // Summary:
        //     Original was GL_RGBA12 = 0x805A
        Rgba12 = 32858,
        //
        // Summary:
        //     Original was GL_RGBA12_EXT = 0x805A
        Rgba12Ext = 32858,
        //
        // Summary:
        //     Original was GL_RGBA16 = 0x805B
        Rgba16 = 32859,
        //
        // Summary:
        //     [requires: EXT_texture_norm16] Original was GL_RGBA16_EXT = 0x805B
        Rgba16Ext = 32859,
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
        //     Original was GL_REPLACE_EXT = 0x8062
        ReplaceExt = 32866,
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
        //     Original was GL_TEXTURE_TOO_LARGE_EXT = 0x8065
        TextureTooLargeExt = 32869,
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
        //     Original was GL_TEXTURE_BINDING_1D = 0x8068
        TextureBinding1D = 32872,
        //
        // Summary:
        //     Original was GL_TEXTURE_BINDING_2D = 0x8069
        TextureBinding2D = 32873,
        //
        // Summary:
        //     Original was GL_TEXTURE_3D_BINDING_EXT = 0x806A
        Texture3DBindingExt = 32874,
        //
        // Summary:
        //     Original was GL_TEXTURE_BINDING_3D = 0x806A
        TextureBinding3D = 32874,
        //
        // Summary:
        //     [requires: OES_texture_3D] Original was GL_TEXTURE_BINDING_3D_OES = 0x806A
        TextureBinding3DOes = 32874,
        //
        // Summary:
        //     Original was GL_PACK_SKIP_IMAGES = 0x806B
        PackSkipImages = 32875,
        //
        // Summary:
        //     Original was GL_PACK_SKIP_IMAGES_EXT = 0x806B
        PackSkipImagesExt = 32875,
        //
        // Summary:
        //     Original was GL_PACK_IMAGE_HEIGHT = 0x806C
        PackImageHeight = 32876,
        //
        // Summary:
        //     Original was GL_PACK_IMAGE_HEIGHT_EXT = 0x806C
        PackImageHeightExt = 32876,
        //
        // Summary:
        //     Original was GL_UNPACK_SKIP_IMAGES = 0x806D
        UnpackSkipImages = 32877,
        //
        // Summary:
        //     Original was GL_UNPACK_SKIP_IMAGES_EXT = 0x806D
        UnpackSkipImagesExt = 32877,
        //
        // Summary:
        //     Original was GL_UNPACK_IMAGE_HEIGHT = 0x806E
        UnpackImageHeight = 32878,
        //
        // Summary:
        //     Original was GL_UNPACK_IMAGE_HEIGHT_EXT = 0x806E
        UnpackImageHeightExt = 32878,
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
        //     Original was GL_MAX_3D_TEXTURE_SIZE = 0x8073
        Max3DTextureSize = 32883,
        //
        // Summary:
        //     Original was GL_MAX_3D_TEXTURE_SIZE_EXT = 0x8073
        Max3DTextureSizeExt = 32883,
        //
        // Summary:
        //     [requires: OES_texture_3D] Original was GL_MAX_3D_TEXTURE_SIZE_OES = 0x8073
        Max3DTextureSizeOes = 32883,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_VERTEX_ARRAY = 0x8074
        VertexArray = 32884,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_VERTEX_ARRAY_KHR = 0x8074
        VertexArrayKhr = 32884,
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
        //     Original was GL_VERTEX_ARRAY_SIZE = 0x807A
        VertexArraySize = 32890,
        //
        // Summary:
        //     Original was GL_VERTEX_ARRAY_TYPE = 0x807B
        VertexArrayType = 32891,
        //
        // Summary:
        //     Original was GL_VERTEX_ARRAY_STRIDE = 0x807C
        VertexArrayStride = 32892,
        //
        // Summary:
        //     Original was GL_VERTEX_ARRAY_COUNT_EXT = 0x807D
        VertexArrayCountExt = 32893,
        //
        // Summary:
        //     Original was GL_NORMAL_ARRAY_TYPE = 0x807E
        NormalArrayType = 32894,
        //
        // Summary:
        //     Original was GL_NORMAL_ARRAY_STRIDE = 0x807F
        NormalArrayStride = 32895,
        //
        // Summary:
        //     Original was GL_NORMAL_ARRAY_COUNT_EXT = 0x8080
        NormalArrayCountExt = 32896,
        //
        // Summary:
        //     Original was GL_COLOR_ARRAY_SIZE = 0x8081
        ColorArraySize = 32897,
        //
        // Summary:
        //     Original was GL_COLOR_ARRAY_TYPE = 0x8082
        ColorArrayType = 32898,
        //
        // Summary:
        //     Original was GL_COLOR_ARRAY_STRIDE = 0x8083
        ColorArrayStride = 32899,
        //
        // Summary:
        //     Original was GL_COLOR_ARRAY_COUNT_EXT = 0x8084
        ColorArrayCountExt = 32900,
        //
        // Summary:
        //     Original was GL_INDEX_ARRAY_TYPE = 0x8085
        IndexArrayType = 32901,
        //
        // Summary:
        //     Original was GL_INDEX_ARRAY_STRIDE = 0x8086
        IndexArrayStride = 32902,
        //
        // Summary:
        //     Original was GL_INDEX_ARRAY_COUNT_EXT = 0x8087
        IndexArrayCountExt = 32903,
        //
        // Summary:
        //     Original was GL_TEXTURE_COORD_ARRAY_SIZE = 0x8088
        TextureCoordArraySize = 32904,
        //
        // Summary:
        //     Original was GL_TEXTURE_COORD_ARRAY_TYPE = 0x8089
        TextureCoordArrayType = 32905,
        //
        // Summary:
        //     Original was GL_TEXTURE_COORD_ARRAY_STRIDE = 0x808A
        TextureCoordArrayStride = 32906,
        //
        // Summary:
        //     Original was GL_TEXTURE_COORD_ARRAY_COUNT_EXT = 0x808B
        TextureCoordArrayCountExt = 32907,
        //
        // Summary:
        //     Original was GL_EDGE_FLAG_ARRAY_STRIDE = 0x808C
        EdgeFlagArrayStride = 32908,
        //
        // Summary:
        //     Original was GL_EDGE_FLAG_ARRAY_COUNT_EXT = 0x808D
        EdgeFlagArrayCountExt = 32909,
        //
        // Summary:
        //     Original was GL_VERTEX_ARRAY_POINTER = 0x808E
        VertexArrayPointer = 32910,
        //
        // Summary:
        //     Original was GL_VERTEX_ARRAY_POINTER_EXT = 0x808E
        VertexArrayPointerExt = 32910,
        //
        // Summary:
        //     Original was GL_NORMAL_ARRAY_POINTER = 0x808F
        NormalArrayPointer = 32911,
        //
        // Summary:
        //     Original was GL_NORMAL_ARRAY_POINTER_EXT = 0x808F
        NormalArrayPointerExt = 32911,
        //
        // Summary:
        //     Original was GL_COLOR_ARRAY_POINTER = 0x8090
        ColorArrayPointer = 32912,
        //
        // Summary:
        //     Original was GL_COLOR_ARRAY_POINTER_EXT = 0x8090
        ColorArrayPointerExt = 32912,
        //
        // Summary:
        //     Original was GL_INDEX_ARRAY_POINTER = 0x8091
        IndexArrayPointer = 32913,
        //
        // Summary:
        //     Original was GL_INDEX_ARRAY_POINTER_EXT = 0x8091
        IndexArrayPointerExt = 32913,
        //
        // Summary:
        //     Original was GL_TEXTURE_COORD_ARRAY_POINTER = 0x8092
        TextureCoordArrayPointer = 32914,
        //
        // Summary:
        //     Original was GL_TEXTURE_COORD_ARRAY_POINTER_EXT = 0x8092
        TextureCoordArrayPointerExt = 32914,
        //
        // Summary:
        //     Original was GL_EDGE_FLAG_ARRAY_POINTER = 0x8093
        EdgeFlagArrayPointer = 32915,
        //
        // Summary:
        //     Original was GL_EDGE_FLAG_ARRAY_POINTER_EXT = 0x8093
        EdgeFlagArrayPointerExt = 32915,
        //
        // Summary:
        //     Original was GL_INTERLACE_SGIX = 0x8094
        InterlaceSgix = 32916,
        //
        // Summary:
        //     Original was GL_DETAIL_TEXTURE_2D_SGIS = 0x8095
        DetailTexture2DSgis = 32917,
        //
        // Summary:
        //     Original was GL_DETAIL_TEXTURE_2D_BINDING_SGIS = 0x8096
        DetailTexture2DBindingSgis = 32918,
        //
        // Summary:
        //     Original was GL_LINEAR_DETAIL_SGIS = 0x8097
        LinearDetailSgis = 32919,
        //
        // Summary:
        //     Original was GL_LINEAR_DETAIL_ALPHA_SGIS = 0x8098
        LinearDetailAlphaSgis = 32920,
        //
        // Summary:
        //     Original was GL_LINEAR_DETAIL_COLOR_SGIS = 0x8099
        LinearDetailColorSgis = 32921,
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
        //     [requires: EXT_multisampled_compatibility] Original was GL_MULTISAMPLE_EXT =
        //     0x809D
        MultisampleExt = 32925,
        //
        // Summary:
        //     Original was GL_MULTISAMPLE_SGIS = 0x809D
        MultisampleSgis = 32925,
        //
        // Summary:
        //     Original was GL_SAMPLE_ALPHA_TO_COVERAGE = 0x809E
        SampleAlphaToCoverage = 32926,
        //
        // Summary:
        //     Original was GL_SAMPLE_ALPHA_TO_MASK_SGIS = 0x809E
        SampleAlphaToMaskSgis = 32926,
        //
        // Summary:
        //     [requires: EXT_multisampled_compatibility] Original was GL_SAMPLE_ALPHA_TO_ONE_EXT
        //     = 0x809F
        SampleAlphaToOneExt = 32927,
        //
        // Summary:
        //     Original was GL_SAMPLE_ALPHA_TO_ONE_SGIS = 0x809F
        SampleAlphaToOneSgis = 32927,
        //
        // Summary:
        //     Original was GL_SAMPLE_COVERAGE = 0x80A0
        SampleCoverage = 32928,
        //
        // Summary:
        //     Original was GL_SAMPLE_MASK_SGIS = 0x80A0
        SampleMaskSgis = 32928,
        //
        // Summary:
        //     Original was GL_1PASS_EXT = 0x80A1
        Gl1PassExt = 32929,
        //
        // Summary:
        //     Original was GL_1PASS_SGIS = 0x80A1
        Gl1PassSgis = 32929,
        //
        // Summary:
        //     Original was GL_2PASS_0_EXT = 0x80A2
        Gl2Pass0Ext = 32930,
        //
        // Summary:
        //     Original was GL_2PASS_0_SGIS = 0x80A2
        Gl2Pass0Sgis = 32930,
        //
        // Summary:
        //     Original was GL_2PASS_1_EXT = 0x80A3
        Gl2Pass1Ext = 32931,
        //
        // Summary:
        //     Original was GL_2PASS_1_SGIS = 0x80A3
        Gl2Pass1Sgis = 32931,
        //
        // Summary:
        //     Original was GL_4PASS_0_EXT = 0x80A4
        Gl4Pass0Ext = 32932,
        //
        // Summary:
        //     Original was GL_4PASS_0_SGIS = 0x80A4
        Gl4Pass0Sgis = 32932,
        //
        // Summary:
        //     Original was GL_4PASS_1_EXT = 0x80A5
        Gl4Pass1Ext = 32933,
        //
        // Summary:
        //     Original was GL_4PASS_1_SGIS = 0x80A5
        Gl4Pass1Sgis = 32933,
        //
        // Summary:
        //     Original was GL_4PASS_2_EXT = 0x80A6
        Gl4Pass2Ext = 32934,
        //
        // Summary:
        //     Original was GL_4PASS_2_SGIS = 0x80A6
        Gl4Pass2Sgis = 32934,
        //
        // Summary:
        //     Original was GL_4PASS_3_EXT = 0x80A7
        Gl4Pass3Ext = 32935,
        //
        // Summary:
        //     Original was GL_4PASS_3_SGIS = 0x80A7
        Gl4Pass3Sgis = 32935,
        //
        // Summary:
        //     Original was GL_SAMPLE_BUFFERS = 0x80A8
        SampleBuffers = 32936,
        //
        // Summary:
        //     Original was GL_SAMPLE_BUFFERS_SGIS = 0x80A8
        SampleBuffersSgis = 32936,
        //
        // Summary:
        //     Original was GL_SAMPLES_SGIS = 0x80A9
        SamplesSgis = 32937,
        //
        // Summary:
        //     Original was GL_Samples = 0X80a9
        Samples = 32937,
        //
        // Summary:
        //     Original was GL_SAMPLE_COVERAGE_VALUE = 0x80AA
        SampleCoverageValue = 32938,
        //
        // Summary:
        //     Original was GL_SAMPLE_MASK_VALUE_SGIS = 0x80AA
        SampleMaskValueSgis = 32938,
        //
        // Summary:
        //     Original was GL_SAMPLE_COVERAGE_INVERT = 0x80AB
        SampleCoverageInvert = 32939,
        //
        // Summary:
        //     Original was GL_SAMPLE_MASK_INVERT_SGIS = 0x80AB
        SampleMaskInvertSgis = 32939,
        //
        // Summary:
        //     Original was GL_SAMPLE_PATTERN_SGIS = 0x80AC
        SamplePatternSgis = 32940,
        //
        // Summary:
        //     Original was GL_LINEAR_SHARPEN_SGIS = 0x80AD
        LinearSharpenSgis = 32941,
        //
        // Summary:
        //     Original was GL_LINEAR_SHARPEN_ALPHA_SGIS = 0x80AE
        LinearSharpenAlphaSgis = 32942,
        //
        // Summary:
        //     Original was GL_LINEAR_SHARPEN_COLOR_SGIS = 0x80AF
        LinearSharpenColorSgis = 32943,
        //
        // Summary:
        //     Original was GL_SHARPEN_TEXTURE_FUNC_POINTS_SGIS = 0x80B0
        SharpenTextureFuncPointsSgis = 32944,
        //
        // Summary:
        //     Original was GL_COLOR_MATRIX_SGI = 0x80B1
        ColorMatrixSgi = 32945,
        //
        // Summary:
        //     Original was GL_COLOR_MATRIX_STACK_DEPTH_SGI = 0x80B2
        ColorMatrixStackDepthSgi = 32946,
        //
        // Summary:
        //     Original was GL_MAX_COLOR_MATRIX_STACK_DEPTH_SGI = 0x80B3
        MaxColorMatrixStackDepthSgi = 32947,
        //
        // Summary:
        //     Original was GL_POST_COLOR_MATRIX_RED_SCALE = 0x80B4
        PostColorMatrixRedScale = 32948,
        //
        // Summary:
        //     Original was GL_POST_COLOR_MATRIX_RED_SCALE_SGI = 0x80B4
        PostColorMatrixRedScaleSgi = 32948,
        //
        // Summary:
        //     Original was GL_POST_COLOR_MATRIX_GREEN_SCALE = 0x80B5
        PostColorMatrixGreenScale = 32949,
        //
        // Summary:
        //     Original was GL_POST_COLOR_MATRIX_GREEN_SCALE_SGI = 0x80B5
        PostColorMatrixGreenScaleSgi = 32949,
        //
        // Summary:
        //     Original was GL_POST_COLOR_MATRIX_BLUE_SCALE = 0x80B6
        PostColorMatrixBlueScale = 32950,
        //
        // Summary:
        //     Original was GL_POST_COLOR_MATRIX_BLUE_SCALE_SGI = 0x80B6
        PostColorMatrixBlueScaleSgi = 32950,
        //
        // Summary:
        //     Original was GL_POST_COLOR_MATRIX_ALPHA_SCALE = 0x80B7
        PostColorMatrixAlphaScale = 32951,
        //
        // Summary:
        //     Original was GL_POST_COLOR_MATRIX_ALPHA_SCALE_SGI = 0x80B7
        PostColorMatrixAlphaScaleSgi = 32951,
        //
        // Summary:
        //     Original was GL_POST_COLOR_MATRIX_RED_BIAS = 0x80B8
        PostColorMatrixRedBias = 32952,
        //
        // Summary:
        //     Original was GL_POST_COLOR_MATRIX_RED_BIAS_SGI = 0x80B8
        PostColorMatrixRedBiasSgi = 32952,
        //
        // Summary:
        //     Original was GL_POST_COLOR_MATRIX_GREEN_BIAS = 0x80B9
        PostColorMatrixGreenBias = 32953,
        //
        // Summary:
        //     Original was GL_POST_COLOR_MATRIX_GREEN_BIAS_SGI = 0x80B9
        PostColorMatrixGreenBiasSgi = 32953,
        //
        // Summary:
        //     Original was GL_POST_COLOR_MATRIX_BLUE_BIAS = 0x80BA
        PostColorMatrixBlueBias = 32954,
        //
        // Summary:
        //     Original was GL_POST_COLOR_MATRIX_BLUE_BIAS_SGI = 0x80BA
        PostColorMatrixBlueBiasSgi = 32954,
        //
        // Summary:
        //     Original was GL_POST_COLOR_MATRIX_ALPHA_BIAS = 0x80BB
        PostColorMatrixAlphaBias = 32955,
        //
        // Summary:
        //     Original was GL_POST_COLOR_MATRIX_ALPHA_BIAS_SGI = 0x80BB
        PostColorMatrixAlphaBiasSgi = 32955,
        //
        // Summary:
        //     Original was GL_TEXTURE_COLOR_TABLE_SGI = 0x80BC
        TextureColorTableSgi = 32956,
        //
        // Summary:
        //     Original was GL_PROXY_TEXTURE_COLOR_TABLE_SGI = 0x80BD
        ProxyTextureColorTableSgi = 32957,
        //
        // Summary:
        //     Original was GL_TEXTURE_ENV_BIAS_SGIX = 0x80BE
        TextureEnvBiasSgix = 32958,
        //
        // Summary:
        //     Original was GL_SHADOW_AMBIENT_SGIX = 0x80BF
        ShadowAmbientSgix = 32959,
        //
        // Summary:
        //     [requires: EXT_draw_buffers_indexed, or OES_draw_buffers_indexed] Original was
        //     GL_BLEND_DST_RGB = 0x80C8
        BlendDstRgb = 32968,
        //
        // Summary:
        //     [requires: EXT_draw_buffers_indexed, or OES_draw_buffers_indexed] Original was
        //     GL_BLEND_SRC_RGB = 0x80C9
        BlendSrcRgb = 32969,
        //
        // Summary:
        //     [requires: EXT_draw_buffers_indexed, or OES_draw_buffers_indexed] Original was
        //     GL_BLEND_DST_ALPHA = 0x80CA
        BlendDstAlpha = 32970,
        //
        // Summary:
        //     [requires: EXT_draw_buffers_indexed, or OES_draw_buffers_indexed] Original was
        //     GL_BLEND_SRC_ALPHA = 0x80CB
        BlendSrcAlpha = 32971,
        //
        // Summary:
        //     Original was GL_COLOR_TABLE = 0x80D0
        ColorTable = 32976,
        //
        // Summary:
        //     Original was GL_COLOR_TABLE_SGI = 0x80D0
        ColorTableSgi = 32976,
        //
        // Summary:
        //     Original was GL_POST_CONVOLUTION_COLOR_TABLE = 0x80D1
        PostConvolutionColorTable = 32977,
        //
        // Summary:
        //     Original was GL_POST_CONVOLUTION_COLOR_TABLE_SGI = 0x80D1
        PostConvolutionColorTableSgi = 32977,
        //
        // Summary:
        //     Original was GL_POST_COLOR_MATRIX_COLOR_TABLE = 0x80D2
        PostColorMatrixColorTable = 32978,
        //
        // Summary:
        //     Original was GL_POST_COLOR_MATRIX_COLOR_TABLE_SGI = 0x80D2
        PostColorMatrixColorTableSgi = 32978,
        //
        // Summary:
        //     Original was GL_PROXY_COLOR_TABLE = 0x80D3
        ProxyColorTable = 32979,
        //
        // Summary:
        //     Original was GL_PROXY_COLOR_TABLE_SGI = 0x80D3
        ProxyColorTableSgi = 32979,
        //
        // Summary:
        //     Original was GL_PROXY_POST_CONVOLUTION_COLOR_TABLE = 0x80D4
        ProxyPostConvolutionColorTable = 32980,
        //
        // Summary:
        //     Original was GL_PROXY_POST_CONVOLUTION_COLOR_TABLE_SGI = 0x80D4
        ProxyPostConvolutionColorTableSgi = 32980,
        //
        // Summary:
        //     Original was GL_PROXY_POST_COLOR_MATRIX_COLOR_TABLE = 0x80D5
        ProxyPostColorMatrixColorTable = 32981,
        //
        // Summary:
        //     Original was GL_PROXY_POST_COLOR_MATRIX_COLOR_TABLE_SGI = 0x80D5
        ProxyPostColorMatrixColorTableSgi = 32981,
        //
        // Summary:
        //     Original was GL_COLOR_TABLE_SCALE = 0x80D6
        ColorTableScale = 32982,
        //
        // Summary:
        //     Original was GL_COLOR_TABLE_SCALE_SGI = 0x80D6
        ColorTableScaleSgi = 32982,
        //
        // Summary:
        //     Original was GL_COLOR_TABLE_BIAS = 0x80D7
        ColorTableBias = 32983,
        //
        // Summary:
        //     Original was GL_COLOR_TABLE_BIAS_SGI = 0x80D7
        ColorTableBiasSgi = 32983,
        //
        // Summary:
        //     Original was GL_COLOR_TABLE_FORMAT = 0x80D8
        ColorTableFormat = 32984,
        //
        // Summary:
        //     Original was GL_COLOR_TABLE_FORMAT_SGI = 0x80D8
        ColorTableFormatSgi = 32984,
        //
        // Summary:
        //     Original was GL_COLOR_TABLE_WIDTH = 0x80D9
        ColorTableWidth = 32985,
        //
        // Summary:
        //     Original was GL_COLOR_TABLE_WIDTH_SGI = 0x80D9
        ColorTableWidthSgi = 32985,
        //
        // Summary:
        //     Original was GL_COLOR_TABLE_RED_SIZE = 0x80DA
        ColorTableRedSize = 32986,
        //
        // Summary:
        //     Original was GL_COLOR_TABLE_RED_SIZE_SGI = 0x80DA
        ColorTableRedSizeSgi = 32986,
        //
        // Summary:
        //     Original was GL_COLOR_TABLE_GREEN_SIZE = 0x80DB
        ColorTableGreenSize = 32987,
        //
        // Summary:
        //     Original was GL_COLOR_TABLE_GREEN_SIZE_SGI = 0x80DB
        ColorTableGreenSizeSgi = 32987,
        //
        // Summary:
        //     Original was GL_COLOR_TABLE_BLUE_SIZE = 0x80DC
        ColorTableBlueSize = 32988,
        //
        // Summary:
        //     Original was GL_COLOR_TABLE_BLUE_SIZE_SGI = 0x80DC
        ColorTableBlueSizeSgi = 32988,
        //
        // Summary:
        //     Original was GL_COLOR_TABLE_ALPHA_SIZE = 0x80DD
        ColorTableAlphaSize = 32989,
        //
        // Summary:
        //     Original was GL_COLOR_TABLE_ALPHA_SIZE_SGI = 0x80DD
        ColorTableAlphaSizeSgi = 32989,
        //
        // Summary:
        //     Original was GL_COLOR_TABLE_LUMINANCE_SIZE = 0x80DE
        ColorTableLuminanceSize = 32990,
        //
        // Summary:
        //     Original was GL_COLOR_TABLE_LUMINANCE_SIZE_SGI = 0x80DE
        ColorTableLuminanceSizeSgi = 32990,
        //
        // Summary:
        //     Original was GL_COLOR_TABLE_INTENSITY_SIZE = 0x80DF
        ColorTableIntensitySize = 32991,
        //
        // Summary:
        //     Original was GL_COLOR_TABLE_INTENSITY_SIZE_SGI = 0x80DF
        ColorTableIntensitySizeSgi = 32991,
        //
        // Summary:
        //     [requires: APPLE_texture_format_BGRA8888, or EXT_read_format_bgra, EXT_texture_format_BGRA8888]
        //     Original was GL_BGRA_EXT = 0x80E1
        BgraExt = 32993,
        //
        // Summary:
        //     [requires: IMG_read_format] Original was GL_BGRA_IMG = 0x80E1
        BgraImg = 32993,
        //
        // Summary:
        //     Original was GL_MAX_ELEMENTS_VERTICES = 0x80E8
        MaxElementsVertices = 33000,
        //
        // Summary:
        //     Original was GL_MAX_ELEMENTS_INDICES = 0x80E9
        MaxElementsIndices = 33001,
        //
        // Summary:
        //     Original was GL_PHONG_HINT_WIN = 0x80EB
        PhongHintWin = 33003,
        //
        // Summary:
        //     Original was GL_CLIP_VOLUME_CLIPPING_HINT_EXT = 0x80F0
        ClipVolumeClippingHintExt = 33008,
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
        //     Original was GL_DUAL_TEXTURE_SELECT_SGIS = 0x8124
        DualTextureSelectSgis = 33060,
        //
        // Summary:
        //     Original was GL_QUAD_TEXTURE_SELECT_SGIS = 0x8125
        QuadTextureSelectSgis = 33061,
        //
        // Summary:
        //     Original was GL_POINT_SIZE_MIN = 0x8126
        PointSizeMin = 33062,
        //
        // Summary:
        //     Original was GL_POINT_SIZE_MIN_ARB = 0x8126
        PointSizeMinArb = 33062,
        //
        // Summary:
        //     Original was GL_POINT_SIZE_MIN_EXT = 0x8126
        PointSizeMinExt = 33062,
        //
        // Summary:
        //     Original was GL_POINT_SIZE_MIN_SGIS = 0x8126
        PointSizeMinSgis = 33062,
        //
        // Summary:
        //     Original was GL_POINT_SIZE_MAX = 0x8127
        PointSizeMax = 33063,
        //
        // Summary:
        //     Original was GL_POINT_SIZE_MAX_ARB = 0x8127
        PointSizeMaxArb = 33063,
        //
        // Summary:
        //     Original was GL_POINT_SIZE_MAX_EXT = 0x8127
        PointSizeMaxExt = 33063,
        //
        // Summary:
        //     Original was GL_POINT_SIZE_MAX_SGIS = 0x8127
        PointSizeMaxSgis = 33063,
        //
        // Summary:
        //     Original was GL_POINT_FADE_THRESHOLD_SIZE = 0x8128
        PointFadeThresholdSize = 33064,
        //
        // Summary:
        //     Original was GL_POINT_FADE_THRESHOLD_SIZE_ARB = 0x8128
        PointFadeThresholdSizeArb = 33064,
        //
        // Summary:
        //     Original was GL_POINT_FADE_THRESHOLD_SIZE_EXT = 0x8128
        PointFadeThresholdSizeExt = 33064,
        //
        // Summary:
        //     Original was GL_POINT_FADE_THRESHOLD_SIZE_SGIS = 0x8128
        PointFadeThresholdSizeSgis = 33064,
        //
        // Summary:
        //     Original was GL_DISTANCE_ATTENUATION_EXT = 0x8129
        DistanceAttenuationExt = 33065,
        //
        // Summary:
        //     Original was GL_DISTANCE_ATTENUATION_SGIS = 0x8129
        DistanceAttenuationSgis = 33065,
        //
        // Summary:
        //     Original was GL_POINT_DISTANCE_ATTENUATION = 0x8129
        PointDistanceAttenuation = 33065,
        //
        // Summary:
        //     Original was GL_POINT_DISTANCE_ATTENUATION_ARB = 0x8129
        PointDistanceAttenuationArb = 33065,
        //
        // Summary:
        //     Original was GL_FOG_FUNC_SGIS = 0x812A
        FogFuncSgis = 33066,
        //
        // Summary:
        //     Original was GL_FOG_FUNC_POINTS_SGIS = 0x812B
        FogFuncPointsSgis = 33067,
        //
        // Summary:
        //     Original was GL_MAX_FOG_FUNC_POINTS_SGIS = 0x812C
        MaxFogFuncPointsSgis = 33068,
        //
        // Summary:
        //     Original was GL_CLAMP_TO_BORDER = 0x812D
        ClampToBorder = 33069,
        //
        // Summary:
        //     Original was GL_CLAMP_TO_BORDER_ARB = 0x812D
        ClampToBorderArb = 33069,
        //
        // Summary:
        //     [requires: EXT_texture_border_clamp] Original was GL_CLAMP_TO_BORDER_EXT = 0x812D
        ClampToBorderExt = 33069,
        //
        // Summary:
        //     [requires: NV_texture_border_clamp] Original was GL_CLAMP_TO_BORDER_NV = 0x812D
        ClampToBorderNv = 33069,
        //
        // Summary:
        //     [requires: OES_texture_border_clamp] Original was GL_CLAMP_TO_BORDER_OES = 0x812D
        ClampToBorderOes = 33069,
        //
        // Summary:
        //     Original was GL_CLAMP_TO_BORDER_SGIS = 0x812D
        ClampToBorderSgis = 33069,
        //
        // Summary:
        //     Original was GL_TEXTURE_MULTI_BUFFER_HINT_SGIX = 0x812E
        TextureMultiBufferHintSgix = 33070,
        //
        // Summary:
        //     Original was GL_CLAMP_TO_EDGE = 0x812F
        ClampToEdge = 33071,
        //
        // Summary:
        //     Original was GL_CLAMP_TO_EDGE_SGIS = 0x812F
        ClampToEdgeSgis = 33071,
        //
        // Summary:
        //     Original was GL_PACK_SKIP_VOLUMES_SGIS = 0x8130
        PackSkipVolumesSgis = 33072,
        //
        // Summary:
        //     Original was GL_PACK_IMAGE_DEPTH_SGIS = 0x8131
        PackImageDepthSgis = 33073,
        //
        // Summary:
        //     Original was GL_UNPACK_SKIP_VOLUMES_SGIS = 0x8132
        UnpackSkipVolumesSgis = 33074,
        //
        // Summary:
        //     Original was GL_UNPACK_IMAGE_DEPTH_SGIS = 0x8133
        UnpackImageDepthSgis = 33075,
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
        //     Original was GL_TEXTURE_4DSIZE_SGIS = 0x8136
        Texture4DsizeSgis = 33078,
        //
        // Summary:
        //     Original was GL_TEXTURE_WRAP_Q_SGIS = 0x8137
        TextureWrapQSgis = 33079,
        //
        // Summary:
        //     Original was GL_MAX_4D_TEXTURE_SIZE_SGIS = 0x8138
        Max4DTextureSizeSgis = 33080,
        //
        // Summary:
        //     Original was GL_PIXEL_TEX_GEN_SGIX = 0x8139
        PixelTexGenSgix = 33081,
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
        //     [requires: APPLE_texture_max_level] Original was GL_TEXTURE_MAX_LEVEL_APPLE =
        //     0x813D
        TextureMaxLevelApple = 33085,
        //
        // Summary:
        //     Original was GL_TEXTURE_MAX_LEVEL_SGIS = 0x813D
        TextureMaxLevelSgis = 33085,
        //
        // Summary:
        //     Original was GL_PIXEL_TILE_BEST_ALIGNMENT_SGIX = 0x813E
        PixelTileBestAlignmentSgix = 33086,
        //
        // Summary:
        //     Original was GL_PIXEL_TILE_CACHE_INCREMENT_SGIX = 0x813F
        PixelTileCacheIncrementSgix = 33087,
        //
        // Summary:
        //     Original was GL_PIXEL_TILE_WIDTH_SGIX = 0x8140
        PixelTileWidthSgix = 33088,
        //
        // Summary:
        //     Original was GL_PIXEL_TILE_HEIGHT_SGIX = 0x8141
        PixelTileHeightSgix = 33089,
        //
        // Summary:
        //     Original was GL_PIXEL_TILE_GRID_WIDTH_SGIX = 0x8142
        PixelTileGridWidthSgix = 33090,
        //
        // Summary:
        //     Original was GL_PIXEL_TILE_GRID_HEIGHT_SGIX = 0x8143
        PixelTileGridHeightSgix = 33091,
        //
        // Summary:
        //     Original was GL_PIXEL_TILE_GRID_DEPTH_SGIX = 0x8144
        PixelTileGridDepthSgix = 33092,
        //
        // Summary:
        //     Original was GL_PIXEL_TILE_CACHE_SIZE_SGIX = 0x8145
        PixelTileCacheSizeSgix = 33093,
        //
        // Summary:
        //     Original was GL_FILTER4_SGIS = 0x8146
        Filter4Sgis = 33094,
        //
        // Summary:
        //     Original was GL_TEXTURE_FILTER4_SIZE_SGIS = 0x8147
        TextureFilter4SizeSgis = 33095,
        //
        // Summary:
        //     Original was GL_SPRITE_SGIX = 0x8148
        SpriteSgix = 33096,
        //
        // Summary:
        //     Original was GL_SPRITE_MODE_SGIX = 0x8149
        SpriteModeSgix = 33097,
        //
        // Summary:
        //     Original was GL_SPRITE_AXIS_SGIX = 0x814A
        SpriteAxisSgix = 33098,
        //
        // Summary:
        //     Original was GL_SPRITE_TRANSLATION_SGIX = 0x814B
        SpriteTranslationSgix = 33099,
        //
        // Summary:
        //     Original was GL_TEXTURE_4D_BINDING_SGIS = 0x814F
        Texture4DBindingSgis = 33103,
        //
        // Summary:
        //     Original was GL_CONVOLUTION_BORDER_COLOR = 0x8154
        ConvolutionBorderColor = 33108,
        //
        // Summary:
        //     Original was GL_LINEAR_CLIPMAP_LINEAR_SGIX = 0x8170
        LinearClipmapLinearSgix = 33136,
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
        //     Original was GL_MAX_CLIPMAP_DEPTH_SGIX = 0x8177
        MaxClipmapDepthSgix = 33143,
        //
        // Summary:
        //     Original was GL_MAX_CLIPMAP_VIRTUAL_DEPTH_SGIX = 0x8178
        MaxClipmapVirtualDepthSgix = 33144,
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
        //     Original was GL_POST_TEXTURE_FILTER_BIAS_RANGE_SGIX = 0x817B
        PostTextureFilterBiasRangeSgix = 33147,
        //
        // Summary:
        //     Original was GL_POST_TEXTURE_FILTER_SCALE_RANGE_SGIX = 0x817C
        PostTextureFilterScaleRangeSgix = 33148,
        //
        // Summary:
        //     Original was GL_REFERENCE_PLANE_SGIX = 0x817D
        ReferencePlaneSgix = 33149,
        //
        // Summary:
        //     Original was GL_REFERENCE_PLANE_EQUATION_SGIX = 0x817E
        ReferencePlaneEquationSgix = 33150,
        //
        // Summary:
        //     Original was GL_IR_INSTRUMENT1_SGIX = 0x817F
        IrInstrument1Sgix = 33151,
        //
        // Summary:
        //     Original was GL_INSTRUMENT_BUFFER_POINTER_SGIX = 0x8180
        InstrumentBufferPointerSgix = 33152,
        //
        // Summary:
        //     Original was GL_INSTRUMENT_MEASUREMENTS_SGIX = 0x8181
        InstrumentMeasurementsSgix = 33153,
        //
        // Summary:
        //     Original was GL_LIST_PRIORITY_SGIX = 0x8182
        ListPrioritySgix = 33154,
        //
        // Summary:
        //     Original was GL_CALLIGRAPHIC_FRAGMENT_SGIX = 0x8183
        CalligraphicFragmentSgix = 33155,
        //
        // Summary:
        //     Original was GL_PIXEL_TEX_GEN_Q_CEILING_SGIX = 0x8184
        PixelTexGenQCeilingSgix = 33156,
        //
        // Summary:
        //     Original was GL_PIXEL_TEX_GEN_Q_ROUND_SGIX = 0x8185
        PixelTexGenQRoundSgix = 33157,
        //
        // Summary:
        //     Original was GL_PIXEL_TEX_GEN_Q_FLOOR_SGIX = 0x8186
        PixelTexGenQFloorSgix = 33158,
        //
        // Summary:
        //     Original was GL_PIXEL_TEX_GEN_ALPHA_REPLACE_SGIX = 0x8187
        PixelTexGenAlphaReplaceSgix = 33159,
        //
        // Summary:
        //     Original was GL_PIXEL_TEX_GEN_ALPHA_NO_REPLACE_SGIX = 0x8188
        PixelTexGenAlphaNoReplaceSgix = 33160,
        //
        // Summary:
        //     Original was GL_PIXEL_TEX_GEN_ALPHA_LS_SGIX = 0x8189
        PixelTexGenAlphaLsSgix = 33161,
        //
        // Summary:
        //     Original was GL_PIXEL_TEX_GEN_ALPHA_MS_SGIX = 0x818A
        PixelTexGenAlphaMsSgix = 33162,
        //
        // Summary:
        //     Original was GL_FRAMEZOOM_SGIX = 0x818B
        FramezoomSgix = 33163,
        //
        // Summary:
        //     Original was GL_FRAMEZOOM_FACTOR_SGIX = 0x818C
        FramezoomFactorSgix = 33164,
        //
        // Summary:
        //     Original was GL_MAX_FRAMEZOOM_FACTOR_SGIX = 0x818D
        MaxFramezoomFactorSgix = 33165,
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
        //     Original was GL_GENERATE_MIPMAP_HINT = 0x8192
        GenerateMipmapHint = 33170,
        //
        // Summary:
        //     Original was GL_GENERATE_MIPMAP_HINT_SGIS = 0x8192
        GenerateMipmapHintSgis = 33170,
        //
        // Summary:
        //     Original was GL_GEOMETRY_DEFORMATION_SGIX = 0x8194
        GeometryDeformationSgix = 33172,
        //
        // Summary:
        //     Original was GL_TEXTURE_DEFORMATION_SGIX = 0x8195
        TextureDeformationSgix = 33173,
        //
        // Summary:
        //     Original was GL_DEFORMATIONS_MASK_SGIX = 0x8196
        DeformationsMaskSgix = 33174,
        //
        // Summary:
        //     Original was GL_FOG_OFFSET_SGIX = 0x8198
        FogOffsetSgix = 33176,
        //
        // Summary:
        //     Original was GL_FOG_OFFSET_VALUE_SGIX = 0x8199
        FogOffsetValueSgix = 33177,
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
        //     [requires: ANGLE_depth_texture] Original was GL_DEPTH_COMPONENT16 = 0x81A5
        DepthComponent16 = 33189,
        //
        // Summary:
        //     Original was GL_DEPTH_COMPONENT16_ARB = 0x81A5
        DepthComponent16Arb = 33189,
        //
        // Summary:
        //     [requires: OES_required_internalformat] Original was GL_DEPTH_COMPONENT16_OES
        //     = 0x81A5
        DepthComponent16Oes = 33189,
        //
        // Summary:
        //     Original was GL_DEPTH_COMPONENT16_SGIX = 0x81A5
        DepthComponent16Sgix = 33189,
        //
        // Summary:
        //     Original was GL_DEPTH_COMPONENT24 = 0x81A6
        DepthComponent24 = 33190,
        //
        // Summary:
        //     Original was GL_DEPTH_COMPONENT24_ARB = 0x81A6
        DepthComponent24Arb = 33190,
        //
        // Summary:
        //     [requires: OES_depth24, or OES_required_internalformat] Original was GL_DEPTH_COMPONENT24_OES
        //     = 0x81A6
        DepthComponent24Oes = 33190,
        //
        // Summary:
        //     Original was GL_DEPTH_COMPONENT24_SGIX = 0x81A6
        DepthComponent24Sgix = 33190,
        //
        // Summary:
        //     Original was GL_DEPTH_COMPONENT32_ARB = 0x81A7
        DepthComponent32Arb = 33191,
        //
        // Summary:
        //     [requires: ANGLE_depth_texture, or OES_depth32, OES_required_internalformat]
        //     Original was GL_DEPTH_COMPONENT32_OES = 0x81A7
        DepthComponent32Oes = 33191,
        //
        // Summary:
        //     Original was GL_DEPTH_COMPONENT32_SGIX = 0x81A7
        DepthComponent32Sgix = 33191,
        //
        // Summary:
        //     Original was GL_YCRCB_422_SGIX = 0x81BB
        Ycrcb422Sgix = 33211,
        //
        // Summary:
        //     Original was GL_YCRCB_444_SGIX = 0x81BC
        Ycrcb444Sgix = 33212,
        //
        // Summary:
        //     Original was GL_EYE_DISTANCE_TO_POINT_SGIS = 0x81F0
        EyeDistanceToPointSgis = 33264,
        //
        // Summary:
        //     Original was GL_OBJECT_DISTANCE_TO_POINT_SGIS = 0x81F1
        ObjectDistanceToPointSgis = 33265,
        //
        // Summary:
        //     Original was GL_EYE_DISTANCE_TO_LINE_SGIS = 0x81F2
        EyeDistanceToLineSgis = 33266,
        //
        // Summary:
        //     Original was GL_OBJECT_DISTANCE_TO_LINE_SGIS = 0x81F3
        ObjectDistanceToLineSgis = 33267,
        //
        // Summary:
        //     Original was GL_EYE_POINT_SGIS = 0x81F4
        EyePointSgis = 33268,
        //
        // Summary:
        //     Original was GL_OBJECT_POINT_SGIS = 0x81F5
        ObjectPointSgis = 33269,
        //
        // Summary:
        //     Original was GL_EYE_LINE_SGIS = 0x81F6
        EyeLineSgis = 33270,
        //
        // Summary:
        //     Original was GL_OBJECT_LINE_SGIS = 0x81F7
        ObjectLineSgis = 33271,
        //
        // Summary:
        //     Original was GL_LIGHT_MODEL_COLOR_CONTROL = 0x81F8
        LightModelColorControl = 33272,
        //
        // Summary:
        //     Original was GL_LIGHT_MODEL_COLOR_CONTROL_EXT = 0x81F8
        LightModelColorControlExt = 33272,
        //
        // Summary:
        //     Original was GL_SINGLE_COLOR = 0x81F9
        SingleColor = 33273,
        //
        // Summary:
        //     Original was GL_SINGLE_COLOR_EXT = 0x81F9
        SingleColorExt = 33273,
        //
        // Summary:
        //     Original was GL_SEPARATE_SPECULAR_COLOR = 0x81FA
        SeparateSpecularColor = 33274,
        //
        // Summary:
        //     Original was GL_SEPARATE_SPECULAR_COLOR_EXT = 0x81FA
        SeparateSpecularColorExt = 33274,
        //
        // Summary:
        //     Original was GL_SHARED_TEXTURE_PALETTE_EXT = 0x81FB
        SharedTexturePaletteExt = 33275,
        //
        // Summary:
        //     Original was GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING = 0x8210
        FramebufferAttachmentColorEncoding = 33296,
        //
        // Summary:
        //     [requires: EXT_sRGB] Original was GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING_EXT
        //     = 0x8210
        FramebufferAttachmentColorEncodingExt = 33296,
        //
        // Summary:
        //     Original was GL_FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE = 0x8211
        FramebufferAttachmentComponentType = 33297,
        //
        // Summary:
        //     [requires: EXT_color_buffer_half_float] Original was GL_FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE_EXT
        //     = 0x8211
        FramebufferAttachmentComponentTypeExt = 33297,
        //
        // Summary:
        //     Original was GL_FRAMEBUFFER_ATTACHMENT_RED_SIZE = 0x8212
        FramebufferAttachmentRedSize = 33298,
        //
        // Summary:
        //     Original was GL_FRAMEBUFFER_ATTACHMENT_GREEN_SIZE = 0x8213
        FramebufferAttachmentGreenSize = 33299,
        //
        // Summary:
        //     Original was GL_FRAMEBUFFER_ATTACHMENT_BLUE_SIZE = 0x8214
        FramebufferAttachmentBlueSize = 33300,
        //
        // Summary:
        //     Original was GL_FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE = 0x8215
        FramebufferAttachmentAlphaSize = 33301,
        //
        // Summary:
        //     Original was GL_FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE = 0x8216
        FramebufferAttachmentDepthSize = 33302,
        //
        // Summary:
        //     Original was GL_FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE = 0x8217
        FramebufferAttachmentStencilSize = 33303,
        //
        // Summary:
        //     Original was GL_FRAMEBUFFER_DEFAULT = 0x8218
        FramebufferDefault = 33304,
        //
        // Summary:
        //     Original was GL_FRAMEBUFFER_UNDEFINED = 0x8219
        FramebufferUndefined = 33305,
        //
        // Summary:
        //     [requires: OES_surfaceless_context] Original was GL_FRAMEBUFFER_UNDEFINED_OES
        //     = 0x8219
        FramebufferUndefinedOes = 33305,
        //
        // Summary:
        //     Original was GL_DEPTH_STENCIL_ATTACHMENT = 0x821A
        DepthStencilAttachment = 33306,
        //
        // Summary:
        //     Original was GL_MAJOR_VERSION = 0x821B
        MajorVersion = 33307,
        //
        // Summary:
        //     Original was GL_MINOR_VERSION = 0x821C
        MinorVersion = 33308,
        //
        // Summary:
        //     Original was GL_NUM_EXTENSIONS = 0x821D
        NumExtensions = 33309,
        //
        // Summary:
        //     Original was GL_BUFFER_IMMUTABLE_STORAGE = 0x821F
        BufferImmutableStorage = 33311,
        //
        // Summary:
        //     [requires: EXT_buffer_storage] Original was GL_BUFFER_IMMUTABLE_STORAGE_EXT =
        //     0x821F
        BufferImmutableStorageExt = 33311,
        //
        // Summary:
        //     Original was GL_BUFFER_STORAGE_FLAGS = 0x8220
        BufferStorageFlags = 33312,
        //
        // Summary:
        //     [requires: EXT_buffer_storage] Original was GL_BUFFER_STORAGE_FLAGS_EXT = 0x8220
        BufferStorageFlagsExt = 33312,
        //
        // Summary:
        //     [requires: EXT_tessellation_shader] Original was GL_PRIMITIVE_RESTART_FOR_PATCHES_SUPPORTED
        //     = 0x8221
        PrimitiveRestartForPatchesSupported = 33313,
        //
        // Summary:
        //     [requires: OES_tessellation_shader] Original was GL_PRIMITIVE_RESTART_FOR_PATCHES_SUPPORTED_OES
        //     = 0x8221
        PrimitiveRestartForPatchesSupportedOes = 33313,
        //
        // Summary:
        //     Original was GL_COMPRESSED_RED = 0x8225
        CompressedRed = 33317,
        //
        // Summary:
        //     Original was GL_COMPRESSED_RG = 0x8226
        CompressedRg = 33318,
        //
        // Summary:
        //     Original was GL_RG = 0x8227
        Rg = 33319,
        //
        // Summary:
        //     [requires: EXT_texture_rg] Original was GL_RG_EXT = 0x8227
        RgExt = 33319,
        //
        // Summary:
        //     Original was GL_RG_INTEGER = 0x8228
        RgInteger = 33320,
        //
        // Summary:
        //     Original was GL_R8 = 0x8229
        R8 = 33321,
        //
        // Summary:
        //     [requires: EXT_texture_rg, or EXT_texture_storage] Original was GL_R8_EXT = 0x8229
        R8Ext = 33321,
        //
        // Summary:
        //     Original was GL_R16 = 0x822A
        R16 = 33322,
        //
        // Summary:
        //     [requires: EXT_texture_norm16] Original was GL_R16_EXT = 0x822A
        R16Ext = 33322,
        //
        // Summary:
        //     Original was GL_RG8 = 0x822B
        Rg8 = 33323,
        //
        // Summary:
        //     [requires: EXT_texture_rg, or EXT_texture_storage] Original was GL_RG8_EXT =
        //     0x822B
        Rg8Ext = 33323,
        //
        // Summary:
        //     Original was GL_RG16 = 0x822C
        Rg16 = 33324,
        //
        // Summary:
        //     [requires: EXT_texture_norm16] Original was GL_RG16_EXT = 0x822C
        Rg16Ext = 33324,
        //
        // Summary:
        //     Original was GL_R16F = 0x822D
        R16f = 33325,
        //
        // Summary:
        //     [requires: EXT_color_buffer_half_float, or EXT_texture_storage] Original was
        //     GL_R16F_EXT = 0x822D
        R16fExt = 33325,
        //
        // Summary:
        //     Original was GL_R32F = 0x822E
        R32f = 33326,
        //
        // Summary:
        //     [requires: EXT_texture_storage] Original was GL_R32F_EXT = 0x822E
        R32fExt = 33326,
        //
        // Summary:
        //     Original was GL_RG16F = 0x822F
        Rg16f = 33327,
        //
        // Summary:
        //     [requires: EXT_color_buffer_half_float, or EXT_texture_storage] Original was
        //     GL_RG16F_EXT = 0x822F
        Rg16fExt = 33327,
        //
        // Summary:
        //     Original was GL_RG32F = 0x8230
        Rg32f = 33328,
        //
        // Summary:
        //     [requires: EXT_texture_storage] Original was GL_RG32F_EXT = 0x8230
        Rg32fExt = 33328,
        //
        // Summary:
        //     Original was GL_R8I = 0x8231
        R8i = 33329,
        //
        // Summary:
        //     Original was GL_R8UI = 0x8232
        R8ui = 33330,
        //
        // Summary:
        //     Original was GL_R16I = 0x8233
        R16i = 33331,
        //
        // Summary:
        //     Original was GL_R16UI = 0x8234
        R16ui = 33332,
        //
        // Summary:
        //     Original was GL_R32I = 0x8235
        R32i = 33333,
        //
        // Summary:
        //     Original was GL_R32UI = 0x8236
        R32ui = 33334,
        //
        // Summary:
        //     Original was GL_RG8I = 0x8237
        Rg8i = 33335,
        //
        // Summary:
        //     Original was GL_RG8UI = 0x8238
        Rg8ui = 33336,
        //
        // Summary:
        //     Original was GL_RG16I = 0x8239
        Rg16i = 33337,
        //
        // Summary:
        //     Original was GL_RG16UI = 0x823A
        Rg16ui = 33338,
        //
        // Summary:
        //     Original was GL_RG32I = 0x823B
        Rg32i = 33339,
        //
        // Summary:
        //     Original was GL_RG32UI = 0x823C
        Rg32ui = 33340,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_DEBUG_OUTPUT_SYNCHRONOUS = 0x8242
        DebugOutputSynchronous = 33346,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_DEBUG_OUTPUT_SYNCHRONOUS_KHR = 0x8242
        DebugOutputSynchronousKhr = 33346,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH = 0x8243
        DebugNextLoggedMessageLength = 33347,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH_KHR =
        //     0x8243
        DebugNextLoggedMessageLengthKhr = 33347,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_DEBUG_CALLBACK_FUNCTION = 0x8244
        DebugCallbackFunction = 33348,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_DEBUG_CALLBACK_FUNCTION_KHR = 0x8244
        DebugCallbackFunctionKhr = 33348,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_DEBUG_CALLBACK_USER_PARAM = 0x8245
        DebugCallbackUserParam = 33349,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_DEBUG_CALLBACK_USER_PARAM_KHR = 0x8245
        DebugCallbackUserParamKhr = 33349,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_DEBUG_SOURCE_API = 0x8246
        DebugSourceApi = 33350,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_DEBUG_SOURCE_API_KHR = 0x8246
        DebugSourceApiKhr = 33350,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_DEBUG_SOURCE_WINDOW_SYSTEM = 0x8247
        DebugSourceWindowSystem = 33351,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_DEBUG_SOURCE_WINDOW_SYSTEM_KHR = 0x8247
        DebugSourceWindowSystemKhr = 33351,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_DEBUG_SOURCE_SHADER_COMPILER = 0x8248
        DebugSourceShaderCompiler = 33352,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_DEBUG_SOURCE_SHADER_COMPILER_KHR = 0x8248
        DebugSourceShaderCompilerKhr = 33352,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_DEBUG_SOURCE_THIRD_PARTY = 0x8249
        DebugSourceThirdParty = 33353,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_DEBUG_SOURCE_THIRD_PARTY_KHR = 0x8249
        DebugSourceThirdPartyKhr = 33353,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_DEBUG_SOURCE_APPLICATION = 0x824A
        DebugSourceApplication = 33354,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_DEBUG_SOURCE_APPLICATION_KHR = 0x824A
        DebugSourceApplicationKhr = 33354,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_DEBUG_SOURCE_OTHER = 0x824B
        DebugSourceOther = 33355,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_DEBUG_SOURCE_OTHER_KHR = 0x824B
        DebugSourceOtherKhr = 33355,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_DEBUG_TYPE_ERROR = 0x824C
        DebugTypeError = 33356,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_DEBUG_TYPE_ERROR_KHR = 0x824C
        DebugTypeErrorKhr = 33356,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR = 0x824D
        DebugTypeDeprecatedBehavior = 33357,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR_KHR = 0x824D
        DebugTypeDeprecatedBehaviorKhr = 33357,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR = 0x824E
        DebugTypeUndefinedBehavior = 33358,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR_KHR = 0x824E
        DebugTypeUndefinedBehaviorKhr = 33358,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_DEBUG_TYPE_PORTABILITY = 0x824F
        DebugTypePortability = 33359,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_DEBUG_TYPE_PORTABILITY_KHR = 0x824F
        DebugTypePortabilityKhr = 33359,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_DEBUG_TYPE_PERFORMANCE = 0x8250
        DebugTypePerformance = 33360,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_DEBUG_TYPE_PERFORMANCE_KHR = 0x8250
        DebugTypePerformanceKhr = 33360,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_DEBUG_TYPE_OTHER = 0x8251
        DebugTypeOther = 33361,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_DEBUG_TYPE_OTHER_KHR = 0x8251
        DebugTypeOtherKhr = 33361,
        //
        // Summary:
        //     [requires: KHR_robustness] Original was GL_LOSE_CONTEXT_ON_RESET = 0x8252
        LoseContextOnReset = 33362,
        //
        // Summary:
        //     [requires: EXT_robustness] Original was GL_LOSE_CONTEXT_ON_RESET_EXT = 0x8252
        LoseContextOnResetExt = 33362,
        //
        // Summary:
        //     [requires: KHR_robustness] Original was GL_LOSE_CONTEXT_ON_RESET_KHR = 0x8252
        LoseContextOnResetKhr = 33362,
        //
        // Summary:
        //     [requires: KHR_robustness] Original was GL_GUILTY_CONTEXT_RESET = 0x8253
        GuiltyContextReset = 33363,
        //
        // Summary:
        //     [requires: EXT_robustness] Original was GL_GUILTY_CONTEXT_RESET_EXT = 0x8253
        GuiltyContextResetExt = 33363,
        //
        // Summary:
        //     [requires: KHR_robustness] Original was GL_GUILTY_CONTEXT_RESET_KHR = 0x8253
        GuiltyContextResetKhr = 33363,
        //
        // Summary:
        //     [requires: KHR_robustness] Original was GL_INNOCENT_CONTEXT_RESET = 0x8254
        InnocentContextReset = 33364,
        //
        // Summary:
        //     [requires: EXT_robustness] Original was GL_INNOCENT_CONTEXT_RESET_EXT = 0x8254
        InnocentContextResetExt = 33364,
        //
        // Summary:
        //     [requires: KHR_robustness] Original was GL_INNOCENT_CONTEXT_RESET_KHR = 0x8254
        InnocentContextResetKhr = 33364,
        //
        // Summary:
        //     [requires: KHR_robustness] Original was GL_UNKNOWN_CONTEXT_RESET = 0x8255
        UnknownContextReset = 33365,
        //
        // Summary:
        //     [requires: EXT_robustness] Original was GL_UNKNOWN_CONTEXT_RESET_EXT = 0x8255
        UnknownContextResetExt = 33365,
        //
        // Summary:
        //     [requires: KHR_robustness] Original was GL_UNKNOWN_CONTEXT_RESET_KHR = 0x8255
        UnknownContextResetKhr = 33365,
        //
        // Summary:
        //     [requires: KHR_robustness] Original was GL_RESET_NOTIFICATION_STRATEGY = 0x8256
        ResetNotificationStrategy = 33366,
        //
        // Summary:
        //     [requires: EXT_robustness] Original was GL_RESET_NOTIFICATION_STRATEGY_EXT =
        //     0x8256
        ResetNotificationStrategyExt = 33366,
        //
        // Summary:
        //     [requires: KHR_robustness] Original was GL_RESET_NOTIFICATION_STRATEGY_KHR =
        //     0x8256
        ResetNotificationStrategyKhr = 33366,
        //
        // Summary:
        //     Original was GL_PROGRAM_BINARY_RETRIEVABLE_HINT = 0x8257
        ProgramBinaryRetrievableHint = 33367,
        //
        // Summary:
        //     Original was GL_PROGRAM_SEPARABLE = 0x8258
        ProgramSeparable = 33368,
        //
        // Summary:
        //     [requires: EXT_separate_shader_objects] Original was GL_PROGRAM_SEPARABLE_EXT
        //     = 0x8258
        ProgramSeparableExt = 33368,
        //
        // Summary:
        //     Original was GL_ACTIVE_PROGRAM = 0x8259
        ActiveProgram = 33369,
        //
        // Summary:
        //     [requires: EXT_separate_shader_objects] Original was GL_ACTIVE_PROGRAM_EXT =
        //     0x8259
        ActiveProgramExt = 33369,
        //
        // Summary:
        //     [requires: EXT_separate_shader_objects] Original was GL_PROGRAM_PIPELINE_BINDING_EXT
        //     = 0x825A
        ProgramPipelineBindingExt = 33370,
        //
        // Summary:
        //     [requires: NV_viewport_array] Original was GL_MAX_VIEWPORTS_NV = 0x825B
        MaxViewportsNv = 33371,
        //
        // Summary:
        //     [requires: OES_viewport_array] Original was GL_MAX_VIEWPORTS_OES = 0x825B
        MaxViewportsOes = 33371,
        //
        // Summary:
        //     [requires: NV_viewport_array] Original was GL_VIEWPORT_SUBPIXEL_BITS_NV = 0x825C
        ViewportSubpixelBitsNv = 33372,
        //
        // Summary:
        //     [requires: OES_viewport_array] Original was GL_VIEWPORT_SUBPIXEL_BITS_OES = 0x825C
        ViewportSubpixelBitsOes = 33372,
        //
        // Summary:
        //     [requires: NV_viewport_array] Original was GL_VIEWPORT_BOUNDS_RANGE_NV = 0x825D
        ViewportBoundsRangeNv = 33373,
        //
        // Summary:
        //     [requires: OES_viewport_array] Original was GL_VIEWPORT_BOUNDS_RANGE_OES = 0x825D
        ViewportBoundsRangeOes = 33373,
        //
        // Summary:
        //     [requires: EXT_geometry_shader] Original was GL_LAYER_PROVOKING_VERTEX_EXT =
        //     0x825E
        LayerProvokingVertexExt = 33374,
        //
        // Summary:
        //     [requires: OES_geometry_shader] Original was GL_LAYER_PROVOKING_VERTEX_OES =
        //     0x825E
        LayerProvokingVertexOes = 33374,
        //
        // Summary:
        //     [requires: NV_viewport_array] Original was GL_VIEWPORT_INDEX_PROVOKING_VERTEX_NV
        //     = 0x825F
        ViewportIndexProvokingVertexNv = 33375,
        //
        // Summary:
        //     [requires: OES_viewport_array] Original was GL_VIEWPORT_INDEX_PROVOKING_VERTEX_OES
        //     = 0x825F
        ViewportIndexProvokingVertexOes = 33375,
        //
        // Summary:
        //     [requires: EXT_geometry_shader] Original was GL_UNDEFINED_VERTEX_EXT = 0x8260
        UndefinedVertexExt = 33376,
        //
        // Summary:
        //     [requires: OES_geometry_shader] Original was GL_UNDEFINED_VERTEX_OES = 0x8260
        UndefinedVertexOes = 33376,
        //
        // Summary:
        //     [requires: KHR_robustness] Original was GL_NO_RESET_NOTIFICATION = 0x8261
        NoResetNotification = 33377,
        //
        // Summary:
        //     [requires: EXT_robustness] Original was GL_NO_RESET_NOTIFICATION_EXT = 0x8261
        NoResetNotificationExt = 33377,
        //
        // Summary:
        //     [requires: KHR_robustness] Original was GL_NO_RESET_NOTIFICATION_KHR = 0x8261
        NoResetNotificationKhr = 33377,
        //
        // Summary:
        //     Original was GL_COMPUTE_WORK_GROUP_SIZE = 0x8267
        ComputeWorkGroupSize = 33383,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_DEBUG_TYPE_MARKER = 0x8268
        DebugTypeMarker = 33384,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_DEBUG_TYPE_MARKER_KHR = 0x8268
        DebugTypeMarkerKhr = 33384,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_DEBUG_TYPE_PUSH_GROUP = 0x8269
        DebugTypePushGroup = 33385,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_DEBUG_TYPE_PUSH_GROUP_KHR = 0x8269
        DebugTypePushGroupKhr = 33385,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_DEBUG_TYPE_POP_GROUP = 0x826A
        DebugTypePopGroup = 33386,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_DEBUG_TYPE_POP_GROUP_KHR = 0x826A
        DebugTypePopGroupKhr = 33386,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_DEBUG_SEVERITY_NOTIFICATION = 0x826B
        DebugSeverityNotification = 33387,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_DEBUG_SEVERITY_NOTIFICATION_KHR = 0x826B
        DebugSeverityNotificationKhr = 33387,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_MAX_DEBUG_GROUP_STACK_DEPTH = 0x826C
        MaxDebugGroupStackDepth = 33388,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_MAX_DEBUG_GROUP_STACK_DEPTH_KHR = 0x826C
        MaxDebugGroupStackDepthKhr = 33388,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_DEBUG_GROUP_STACK_DEPTH = 0x826D
        DebugGroupStackDepth = 33389,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_DEBUG_GROUP_STACK_DEPTH_KHR = 0x826D
        DebugGroupStackDepthKhr = 33389,
        //
        // Summary:
        //     Original was GL_INTERNALFORMAT_SUPPORTED = 0x826F
        InternalformatSupported = 33391,
        //
        // Summary:
        //     Original was GL_INTERNALFORMAT_PREFERRED = 0x8270
        InternalformatPreferred = 33392,
        //
        // Summary:
        //     Original was GL_INTERNALFORMAT_RED_SIZE = 0x8271
        InternalformatRedSize = 33393,
        //
        // Summary:
        //     Original was GL_INTERNALFORMAT_GREEN_SIZE = 0x8272
        InternalformatGreenSize = 33394,
        //
        // Summary:
        //     Original was GL_INTERNALFORMAT_BLUE_SIZE = 0x8273
        InternalformatBlueSize = 33395,
        //
        // Summary:
        //     Original was GL_INTERNALFORMAT_ALPHA_SIZE = 0x8274
        InternalformatAlphaSize = 33396,
        //
        // Summary:
        //     Original was GL_INTERNALFORMAT_DEPTH_SIZE = 0x8275
        InternalformatDepthSize = 33397,
        //
        // Summary:
        //     Original was GL_INTERNALFORMAT_STENCIL_SIZE = 0x8276
        InternalformatStencilSize = 33398,
        //
        // Summary:
        //     Original was GL_INTERNALFORMAT_SHARED_SIZE = 0x8277
        InternalformatSharedSize = 33399,
        //
        // Summary:
        //     Original was GL_INTERNALFORMAT_RED_TYPE = 0x8278
        InternalformatRedType = 33400,
        //
        // Summary:
        //     Original was GL_INTERNALFORMAT_GREEN_TYPE = 0x8279
        InternalformatGreenType = 33401,
        //
        // Summary:
        //     Original was GL_INTERNALFORMAT_BLUE_TYPE = 0x827A
        InternalformatBlueType = 33402,
        //
        // Summary:
        //     Original was GL_INTERNALFORMAT_ALPHA_TYPE = 0x827B
        InternalformatAlphaType = 33403,
        //
        // Summary:
        //     Original was GL_INTERNALFORMAT_DEPTH_TYPE = 0x827C
        InternalformatDepthType = 33404,
        //
        // Summary:
        //     Original was GL_INTERNALFORMAT_STENCIL_TYPE = 0x827D
        InternalformatStencilType = 33405,
        //
        // Summary:
        //     Original was GL_MAX_WIDTH = 0x827E
        MaxWidth = 33406,
        //
        // Summary:
        //     Original was GL_MAX_HEIGHT = 0x827F
        MaxHeight = 33407,
        //
        // Summary:
        //     Original was GL_MAX_DEPTH = 0x8280
        MaxDepth = 33408,
        //
        // Summary:
        //     Original was GL_MAX_LAYERS = 0x8281
        MaxLayers = 33409,
        //
        // Summary:
        //     Original was GL_COLOR_COMPONENTS = 0x8283
        ColorComponents = 33411,
        //
        // Summary:
        //     Original was GL_COLOR_RENDERABLE = 0x8286
        ColorRenderable = 33414,
        //
        // Summary:
        //     Original was GL_DEPTH_RENDERABLE = 0x8287
        DepthRenderable = 33415,
        //
        // Summary:
        //     Original was GL_STENCIL_RENDERABLE = 0x8288
        StencilRenderable = 33416,
        //
        // Summary:
        //     Original was GL_FRAMEBUFFER_RENDERABLE = 0x8289
        FramebufferRenderable = 33417,
        //
        // Summary:
        //     Original was GL_FRAMEBUFFER_RENDERABLE_LAYERED = 0x828A
        FramebufferRenderableLayered = 33418,
        //
        // Summary:
        //     Original was GL_FRAMEBUFFER_BLEND = 0x828B
        FramebufferBlend = 33419,
        //
        // Summary:
        //     Original was GL_READ_PIXELS = 0x828C
        ReadPixels = 33420,
        //
        // Summary:
        //     Original was GL_READ_PIXELS_FORMAT = 0x828D
        ReadPixelsFormat = 33421,
        //
        // Summary:
        //     Original was GL_READ_PIXELS_TYPE = 0x828E
        ReadPixelsType = 33422,
        //
        // Summary:
        //     Original was GL_TEXTURE_IMAGE_FORMAT = 0x828F
        TextureImageFormat = 33423,
        //
        // Summary:
        //     Original was GL_TEXTURE_IMAGE_TYPE = 0x8290
        TextureImageType = 33424,
        //
        // Summary:
        //     Original was GL_GET_TEXTURE_IMAGE_FORMAT = 0x8291
        GetTextureImageFormat = 33425,
        //
        // Summary:
        //     Original was GL_GET_TEXTURE_IMAGE_TYPE = 0x8292
        GetTextureImageType = 33426,
        //
        // Summary:
        //     Original was GL_MIPMAP = 0x8293
        Mipmap = 33427,
        //
        // Summary:
        //     Original was GL_AUTO_GENERATE_MIPMAP = 0x8295
        AutoGenerateMipmap = 33429,
        //
        // Summary:
        //     Original was GL_COLOR_ENCODING = 0x8296
        ColorEncoding = 33430,
        //
        // Summary:
        //     Original was GL_SRGB_READ = 0x8297
        SrgbRead = 33431,
        //
        // Summary:
        //     Original was GL_SRGB_WRITE = 0x8298
        SrgbWrite = 33432,
        //
        // Summary:
        //     Original was GL_FILTER = 0x829A
        Filter = 33434,
        //
        // Summary:
        //     Original was GL_VERTEX_TEXTURE = 0x829B
        VertexTexture = 33435,
        //
        // Summary:
        //     Original was GL_TESS_CONTROL_TEXTURE = 0x829C
        TessControlTexture = 33436,
        //
        // Summary:
        //     Original was GL_TESS_EVALUATION_TEXTURE = 0x829D
        TessEvaluationTexture = 33437,
        //
        // Summary:
        //     Original was GL_GEOMETRY_TEXTURE = 0x829E
        GeometryTexture = 33438,
        //
        // Summary:
        //     Original was GL_FRAGMENT_TEXTURE = 0x829F
        FragmentTexture = 33439,
        //
        // Summary:
        //     Original was GL_COMPUTE_TEXTURE = 0x82A0
        ComputeTexture = 33440,
        //
        // Summary:
        //     Original was GL_TEXTURE_SHADOW = 0x82A1
        TextureShadow = 33441,
        //
        // Summary:
        //     Original was GL_TEXTURE_GATHER = 0x82A2
        TextureGather = 33442,
        //
        // Summary:
        //     Original was GL_TEXTURE_GATHER_SHADOW = 0x82A3
        TextureGatherShadow = 33443,
        //
        // Summary:
        //     Original was GL_SHADER_IMAGE_LOAD = 0x82A4
        ShaderImageLoad = 33444,
        //
        // Summary:
        //     Original was GL_SHADER_IMAGE_STORE = 0x82A5
        ShaderImageStore = 33445,
        //
        // Summary:
        //     Original was GL_SHADER_IMAGE_ATOMIC = 0x82A6
        ShaderImageAtomic = 33446,
        //
        // Summary:
        //     Original was GL_IMAGE_TEXEL_SIZE = 0x82A7
        ImageTexelSize = 33447,
        //
        // Summary:
        //     Original was GL_IMAGE_COMPATIBILITY_CLASS = 0x82A8
        ImageCompatibilityClass = 33448,
        //
        // Summary:
        //     Original was GL_IMAGE_PIXEL_FORMAT = 0x82A9
        ImagePixelFormat = 33449,
        //
        // Summary:
        //     Original was GL_IMAGE_PIXEL_TYPE = 0x82AA
        ImagePixelType = 33450,
        //
        // Summary:
        //     Original was GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_TEST = 0x82AC
        SimultaneousTextureAndDepthTest = 33452,
        //
        // Summary:
        //     Original was GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_TEST = 0x82AD
        SimultaneousTextureAndStencilTest = 33453,
        //
        // Summary:
        //     Original was GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_WRITE = 0x82AE
        SimultaneousTextureAndDepthWrite = 33454,
        //
        // Summary:
        //     Original was GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_WRITE = 0x82AF
        SimultaneousTextureAndStencilWrite = 33455,
        //
        // Summary:
        //     Original was GL_TEXTURE_COMPRESSED_BLOCK_WIDTH = 0x82B1
        TextureCompressedBlockWidth = 33457,
        //
        // Summary:
        //     Original was GL_TEXTURE_COMPRESSED_BLOCK_HEIGHT = 0x82B2
        TextureCompressedBlockHeight = 33458,
        //
        // Summary:
        //     Original was GL_TEXTURE_COMPRESSED_BLOCK_SIZE = 0x82B3
        TextureCompressedBlockSize = 33459,
        //
        // Summary:
        //     Original was GL_CLEAR_BUFFER = 0x82B4
        ClearBuffer = 33460,
        //
        // Summary:
        //     Original was GL_TEXTURE_VIEW = 0x82B5
        TextureView = 33461,
        //
        // Summary:
        //     Original was GL_VIEW_COMPATIBILITY_CLASS = 0x82B6
        ViewCompatibilityClass = 33462,
        //
        // Summary:
        //     Original was GL_VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D5
        VertexAttribRelativeOffset = 33493,
        //
        // Summary:
        //     [requires: EXT_texture_view] Original was GL_TEXTURE_VIEW_MIN_LEVEL_EXT = 0x82DB
        TextureViewMinLevelExt = 33499,
        //
        // Summary:
        //     [requires: OES_texture_view] Original was GL_TEXTURE_VIEW_MIN_LEVEL_OES = 0x82DB
        TextureViewMinLevelOes = 33499,
        //
        // Summary:
        //     [requires: EXT_texture_view] Original was GL_TEXTURE_VIEW_NUM_LEVELS_EXT = 0x82DC
        TextureViewNumLevelsExt = 33500,
        //
        // Summary:
        //     [requires: OES_texture_view] Original was GL_TEXTURE_VIEW_NUM_LEVELS_OES = 0x82DC
        TextureViewNumLevelsOes = 33500,
        //
        // Summary:
        //     [requires: EXT_texture_view] Original was GL_TEXTURE_VIEW_MIN_LAYER_EXT = 0x82DD
        TextureViewMinLayerExt = 33501,
        //
        // Summary:
        //     [requires: OES_texture_view] Original was GL_TEXTURE_VIEW_MIN_LAYER_OES = 0x82DD
        TextureViewMinLayerOes = 33501,
        //
        // Summary:
        //     [requires: EXT_texture_view] Original was GL_TEXTURE_VIEW_NUM_LAYERS_EXT = 0x82DE
        TextureViewNumLayersExt = 33502,
        //
        // Summary:
        //     [requires: OES_texture_view] Original was GL_TEXTURE_VIEW_NUM_LAYERS_OES = 0x82DE
        TextureViewNumLayersOes = 33502,
        //
        // Summary:
        //     [requires: EXT_texture_view, or OES_texture_view] Original was GL_TEXTURE_IMMUTABLE_LEVELS
        //     = 0x82DF
        TextureImmutableLevels = 33503,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_BUFFER = 0x82E0
        Buffer = 33504,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_BUFFER_KHR = 0x82E0
        BufferKhr = 33504,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_SHADER = 0x82E1
        Shader = 33505,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_SHADER_KHR = 0x82E1
        ShaderKhr = 33505,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_PROGRAM = 0x82E2
        Program = 33506,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_PROGRAM_KHR = 0x82E2
        ProgramKhr = 33506,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_QUERY = 0x82E3
        Query = 33507,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_QUERY_KHR = 0x82E3
        QueryKhr = 33507,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_PROGRAM_PIPELINE = 0x82E4
        ProgramPipeline = 33508,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_PROGRAM_PIPELINE_KHR = 0x82E4
        ProgramPipelineKhr = 33508,
        //
        // Summary:
        //     [requires: EXT_debug_label, or KHR_debug] Original was GL_SAMPLER = 0x82E6
        Sampler = 33510,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_SAMPLER_KHR = 0x82E6
        SamplerKhr = 33510,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_DISPLAY_LIST = 0x82E7
        DisplayList = 33511,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_MAX_LABEL_LENGTH = 0x82E8
        MaxLabelLength = 33512,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_MAX_LABEL_LENGTH_KHR = 0x82E8
        MaxLabelLengthKhr = 33512,
        //
        // Summary:
        //     Original was GL_QUERY_TARGET = 0x82EA
        QueryTarget = 33514,
        //
        // Summary:
        //     [requires: EXT_clip_cull_distance] Original was GL_MAX_CULL_DISTANCES_EXT = 0x82F9
        MaxCullDistancesExt = 33529,
        //
        // Summary:
        //     [requires: EXT_clip_cull_distance] Original was GL_MAX_COMBINED_CLIP_AND_CULL_DISTANCES_EXT
        //     = 0x82FA
        MaxCombinedClipAndCullDistancesExt = 33530,
        //
        // Summary:
        //     [requires: KHR_context_flush_control] Original was GL_CONTEXT_RELEASE_BEHAVIOR
        //     = 0x82FB
        ContextReleaseBehavior = 33531,
        //
        // Summary:
        //     [requires: KHR_context_flush_control] Original was GL_CONTEXT_RELEASE_BEHAVIOR_KHR
        //     = 0x82FB
        ContextReleaseBehaviorKhr = 33531,
        //
        // Summary:
        //     [requires: KHR_context_flush_control] Original was GL_CONTEXT_RELEASE_BEHAVIOR_FLUSH
        //     = 0x82FC
        ContextReleaseBehaviorFlush = 33532,
        //
        // Summary:
        //     [requires: KHR_context_flush_control] Original was GL_CONTEXT_RELEASE_BEHAVIOR_FLUSH_KHR
        //     = 0x82FC
        ContextReleaseBehaviorFlushKhr = 33532,
        //
        // Summary:
        //     Original was GL_CONVOLUTION_HINT_SGIX = 0x8316
        ConvolutionHintSgix = 33558,
        //
        // Summary:
        //     Original was GL_ALPHA_MIN_SGIX = 0x8320
        AlphaMinSgix = 33568,
        //
        // Summary:
        //     Original was GL_ALPHA_MAX_SGIX = 0x8321
        AlphaMaxSgix = 33569,
        //
        // Summary:
        //     Original was GL_SCALEBIAS_HINT_SGIX = 0x8322
        ScalebiasHintSgix = 33570,
        //
        // Summary:
        //     Original was GL_ASYNC_MARKER_SGIX = 0x8329
        AsyncMarkerSgix = 33577,
        //
        // Summary:
        //     Original was GL_PIXEL_TEX_GEN_MODE_SGIX = 0x832B
        PixelTexGenModeSgix = 33579,
        //
        // Summary:
        //     Original was GL_ASYNC_HISTOGRAM_SGIX = 0x832C
        AsyncHistogramSgix = 33580,
        //
        // Summary:
        //     Original was GL_MAX_ASYNC_HISTOGRAM_SGIX = 0x832D
        MaxAsyncHistogramSgix = 33581,
        //
        // Summary:
        //     Original was GL_PIXEL_TEXTURE_SGIS = 0x8353
        PixelTextureSgis = 33619,
        //
        // Summary:
        //     Original was GL_PIXEL_FRAGMENT_RGB_SOURCE_SGIS = 0x8354
        PixelFragmentRgbSourceSgis = 33620,
        //
        // Summary:
        //     Original was GL_PIXEL_FRAGMENT_ALPHA_SOURCE_SGIS = 0x8355
        PixelFragmentAlphaSourceSgis = 33621,
        //
        // Summary:
        //     Original was GL_LINE_QUALITY_HINT_SGIX = 0x835B
        LineQualityHintSgix = 33627,
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
        //     Original was GL_MAX_ASYNC_TEX_IMAGE_SGIX = 0x835F
        MaxAsyncTexImageSgix = 33631,
        //
        // Summary:
        //     Original was GL_MAX_ASYNC_DRAW_PIXELS_SGIX = 0x8360
        MaxAsyncDrawPixelsSgix = 33632,
        //
        // Summary:
        //     Original was GL_MAX_ASYNC_READ_PIXELS_SGIX = 0x8361
        MaxAsyncReadPixelsSgix = 33633,
        //
        // Summary:
        //     Original was GL_UNSIGNED_SHORT_5_6_5 = 0x8363
        UnsignedShort565 = 33635,
        //
        // Summary:
        //     [requires: EXT_read_format_bgra] Original was GL_UNSIGNED_SHORT_4_4_4_4_REV_EXT
        //     = 0x8365
        UnsignedShort4444RevExt = 33637,
        //
        // Summary:
        //     [requires: IMG_read_format] Original was GL_UNSIGNED_SHORT_4_4_4_4_REV_IMG =
        //     0x8365
        UnsignedShort4444RevImg = 33637,
        //
        // Summary:
        //     [requires: EXT_read_format_bgra] Original was GL_UNSIGNED_SHORT_1_5_5_5_REV_EXT
        //     = 0x8366
        UnsignedShort1555RevExt = 33638,
        //
        // Summary:
        //     Original was GL_UNSIGNED_INT_2_10_10_10_REV = 0x8368
        UnsignedInt2101010Rev = 33640,
        //
        // Summary:
        //     [requires: EXT_texture_type_2_10_10_10_REV] Original was GL_UNSIGNED_INT_2_10_10_10_REV_EXT
        //     = 0x8368
        UnsignedInt2101010RevExt = 33640,
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
        //     Original was GL_MIRRORED_REPEAT = 0x8370
        MirroredRepeat = 33648,
        //
        // Summary:
        //     Original was GL_VERTEX_PRECLIP_SGIX = 0x83EE
        VertexPreclipSgix = 33774,
        //
        // Summary:
        //     Original was GL_VERTEX_PRECLIP_HINT_SGIX = 0x83EF
        VertexPreclipHintSgix = 33775,
        //
        // Summary:
        //     [requires: EXT_texture_compression_dxt1, or EXT_texture_compression_s3tc] Original
        //     was GL_COMPRESSED_RGB_S3TC_DXT1_EXT = 0x83F0
        CompressedRgbS3tcDxt1Ext = 33776,
        //
        // Summary:
        //     [requires: EXT_texture_compression_dxt1, or EXT_texture_compression_s3tc] Original
        //     was GL_COMPRESSED_RGBA_S3TC_DXT1_EXT = 0x83F1
        CompressedRgbaS3tcDxt1Ext = 33777,
        //
        // Summary:
        //     [requires: ANGLE_texture_compression_dxt3] Original was GL_COMPRESSED_RGBA_S3TC_DXT3_ANGLE
        //     = 0x83F2
        CompressedRgbaS3tcDxt3Angle = 33778,
        //
        // Summary:
        //     [requires: EXT_texture_compression_s3tc] Original was GL_COMPRESSED_RGBA_S3TC_DXT3_EXT
        //     = 0x83F2
        CompressedRgbaS3tcDxt3Ext = 33778,
        //
        // Summary:
        //     [requires: ANGLE_texture_compression_dxt5] Original was GL_COMPRESSED_RGBA_S3TC_DXT5_ANGLE
        //     = 0x83F3
        CompressedRgbaS3tcDxt5Angle = 33779,
        //
        // Summary:
        //     [requires: EXT_texture_compression_s3tc] Original was GL_COMPRESSED_RGBA_S3TC_DXT5_EXT
        //     = 0x83F3
        CompressedRgbaS3tcDxt5Ext = 33779,
        //
        // Summary:
        //     [requires: INTEL_performance_query] Original was GL_PERFQUERY_DONOT_FLUSH_INTEL
        //     = 0x83F9
        PerfqueryDonotFlushIntel = 33785,
        //
        // Summary:
        //     [requires: INTEL_performance_query] Original was GL_PERFQUERY_FLUSH_INTEL = 0x83FA
        PerfqueryFlushIntel = 33786,
        //
        // Summary:
        //     [requires: INTEL_performance_query] Original was GL_PERFQUERY_WAIT_INTEL = 0x83FB
        PerfqueryWaitIntel = 33787,
        //
        // Summary:
        //     [requires: INTEL_conservative_rasterization] Original was GL_CONSERVATIVE_RASTERIZATION_INTEL
        //     = 0x83FE
        ConservativeRasterizationIntel = 33790,
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
        //     Original was GL_FRAGMENT_COLOR_MATERIAL_FACE_SGIX = 0x8402
        FragmentColorMaterialFaceSgix = 33794,
        //
        // Summary:
        //     Original was GL_FRAGMENT_COLOR_MATERIAL_PARAMETER_SGIX = 0x8403
        FragmentColorMaterialParameterSgix = 33795,
        //
        // Summary:
        //     Original was GL_MAX_FRAGMENT_LIGHTS_SGIX = 0x8404
        MaxFragmentLightsSgix = 33796,
        //
        // Summary:
        //     Original was GL_MAX_ACTIVE_LIGHTS_SGIX = 0x8405
        MaxActiveLightsSgix = 33797,
        //
        // Summary:
        //     Original was GL_LIGHT_ENV_MODE_SGIX = 0x8407
        LightEnvModeSgix = 33799,
        //
        // Summary:
        //     Original was GL_FRAGMENT_LIGHT_MODEL_LOCAL_VIEWER_SGIX = 0x8408
        FragmentLightModelLocalViewerSgix = 33800,
        //
        // Summary:
        //     Original was GL_FRAGMENT_LIGHT_MODEL_TWO_SIDE_SGIX = 0x8409
        FragmentLightModelTwoSideSgix = 33801,
        //
        // Summary:
        //     Original was GL_FRAGMENT_LIGHT_MODEL_AMBIENT_SGIX = 0x840A
        FragmentLightModelAmbientSgix = 33802,
        //
        // Summary:
        //     Original was GL_FRAGMENT_LIGHT_MODEL_NORMAL_INTERPOLATION_SGIX = 0x840B
        FragmentLightModelNormalInterpolationSgix = 33803,
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
        //     Original was GL_PACK_RESAMPLE_SGIX = 0x842E
        PackResampleSgix = 33838,
        //
        // Summary:
        //     Original was GL_UNPACK_RESAMPLE_SGIX = 0x842F
        UnpackResampleSgix = 33839,
        //
        // Summary:
        //     Original was GL_RESAMPLE_DECIMATE_SGIX = 0x8430
        ResampleDecimateSgix = 33840,
        //
        // Summary:
        //     Original was GL_RESAMPLE_REPLICATE_SGIX = 0x8433
        ResampleReplicateSgix = 33843,
        //
        // Summary:
        //     Original was GL_RESAMPLE_ZERO_FILL_SGIX = 0x8434
        ResampleZeroFillSgix = 33844,
        //
        // Summary:
        //     Original was GL_NEAREST_CLIPMAP_NEAREST_SGIX = 0x844D
        NearestClipmapNearestSgix = 33869,
        //
        // Summary:
        //     Original was GL_NEAREST_CLIPMAP_LINEAR_SGIX = 0x844E
        NearestClipmapLinearSgix = 33870,
        //
        // Summary:
        //     Original was GL_LINEAR_CLIPMAP_NEAREST_SGIX = 0x844F
        LinearClipmapNearestSgix = 33871,
        //
        // Summary:
        //     Original was GL_FOG_COORD_SRC = 0x8450
        FogCoordSrc = 33872,
        //
        // Summary:
        //     Original was GL_ALIASED_POINT_SIZE_RANGE = 0x846D
        AliasedPointSizeRange = 33901,
        //
        // Summary:
        //     Original was GL_ALIASED_LINE_WIDTH_RANGE = 0x846E
        AliasedLineWidthRange = 33902,
        //
        // Summary:
        //     Original was GL_Texture0 = 0X84c0
        Texture0 = 33984,
        //
        // Summary:
        //     Original was GL_Texture1 = 0X84c1
        Texture1 = 33985,
        //
        // Summary:
        //     Original was GL_Texture2 = 0X84c2
        Texture2 = 33986,
        //
        // Summary:
        //     Original was GL_Texture3 = 0X84c3
        Texture3 = 33987,
        //
        // Summary:
        //     Original was GL_Texture4 = 0X84c4
        Texture4 = 33988,
        //
        // Summary:
        //     Original was GL_Texture5 = 0X84c5
        Texture5 = 33989,
        //
        // Summary:
        //     Original was GL_Texture6 = 0X84c6
        Texture6 = 33990,
        //
        // Summary:
        //     Original was GL_Texture7 = 0X84c7
        Texture7 = 33991,
        //
        // Summary:
        //     Original was GL_Texture8 = 0X84c8
        Texture8 = 33992,
        //
        // Summary:
        //     Original was GL_Texture9 = 0X84c9
        Texture9 = 33993,
        //
        // Summary:
        //     Original was GL_Texture10 = 0X84ca
        Texture10 = 33994,
        //
        // Summary:
        //     Original was GL_Texture11 = 0X84cb
        Texture11 = 33995,
        //
        // Summary:
        //     Original was GL_Texture12 = 0X84cc
        Texture12 = 33996,
        //
        // Summary:
        //     Original was GL_Texture13 = 0X84cd
        Texture13 = 33997,
        //
        // Summary:
        //     Original was GL_Texture14 = 0X84ce
        Texture14 = 33998,
        //
        // Summary:
        //     Original was GL_Texture15 = 0X84cf
        Texture15 = 33999,
        //
        // Summary:
        //     Original was GL_Texture16 = 0X84d0
        Texture16 = 34000,
        //
        // Summary:
        //     Original was GL_Texture17 = 0X84d1
        Texture17 = 34001,
        //
        // Summary:
        //     Original was GL_Texture18 = 0X84d2
        Texture18 = 34002,
        //
        // Summary:
        //     Original was GL_Texture19 = 0X84d3
        Texture19 = 34003,
        //
        // Summary:
        //     Original was GL_Texture20 = 0X84d4
        Texture20 = 34004,
        //
        // Summary:
        //     Original was GL_Texture21 = 0X84d5
        Texture21 = 34005,
        //
        // Summary:
        //     Original was GL_Texture22 = 0X84d6
        Texture22 = 34006,
        //
        // Summary:
        //     Original was GL_Texture23 = 0X84d7
        Texture23 = 34007,
        //
        // Summary:
        //     Original was GL_Texture24 = 0X84d8
        Texture24 = 34008,
        //
        // Summary:
        //     Original was GL_Texture25 = 0X84d9
        Texture25 = 34009,
        //
        // Summary:
        //     Original was GL_Texture26 = 0X84da
        Texture26 = 34010,
        //
        // Summary:
        //     Original was GL_Texture27 = 0X84db
        Texture27 = 34011,
        //
        // Summary:
        //     Original was GL_Texture28 = 0X84dc
        Texture28 = 34012,
        //
        // Summary:
        //     Original was GL_Texture29 = 0X84dd
        Texture29 = 34013,
        //
        // Summary:
        //     Original was GL_Texture30 = 0X84de
        Texture30 = 34014,
        //
        // Summary:
        //     Original was GL_Texture31 = 0X84df
        Texture31 = 34015,
        //
        // Summary:
        //     Original was GL_ACTIVE_TEXTURE = 0x84E0
        ActiveTexture = 34016,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_PATH_TRANSPOSE_MODELVIEW_MATRIX_NV
        //     = 0x84E3
        PathTransposeModelviewMatrixNv = 34019,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_PATH_TRANSPOSE_PROJECTION_MATRIX_NV
        //     = 0x84E4
        PathTransposeProjectionMatrixNv = 34020,
        //
        // Summary:
        //     Original was GL_MAX_RENDERBUFFER_SIZE = 0x84E8
        MaxRenderbufferSize = 34024,
        //
        // Summary:
        //     Original was GL_COMPRESSED_RGB = 0x84ED
        CompressedRgb = 34029,
        //
        // Summary:
        //     Original was GL_COMPRESSED_RGBA = 0x84EE
        CompressedRgba = 34030,
        //
        // Summary:
        //     Original was GL_TEXTURE_COMPRESSION_HINT = 0x84EF
        TextureCompressionHint = 34031,
        //
        // Summary:
        //     Original was GL_TEXTURE_COMPRESSION_HINT_ARB = 0x84EF
        TextureCompressionHintArb = 34031,
        //
        // Summary:
        //     Original was GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_CONTROL_SHADER = 0x84F0
        UniformBlockReferencedByTessControlShader = 34032,
        //
        // Summary:
        //     Original was GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x84F1
        UniformBlockReferencedByTessEvaluationShader = 34033,
        //
        // Summary:
        //     [requires: NV_fence] Original was GL_ALL_COMPLETED_NV = 0x84F2
        AllCompletedNv = 34034,
        //
        // Summary:
        //     [requires: NV_fence] Original was GL_FENCE_STATUS_NV = 0x84F3
        FenceStatusNv = 34035,
        //
        // Summary:
        //     [requires: NV_fence] Original was GL_FENCE_CONDITION_NV = 0x84F4
        FenceConditionNv = 34036,
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
        //     Original was GL_DEPTH_STENCIL = 0x84F9
        DepthStencil = 34041,
        //
        // Summary:
        //     Original was GL_DEPTH_STENCIL_EXT = 0x84F9
        DepthStencilExt = 34041,
        //
        // Summary:
        //     Original was GL_DEPTH_STENCIL_NV = 0x84F9
        DepthStencilNv = 34041,
        //
        // Summary:
        //     [requires: ANGLE_depth_texture, or OES_packed_depth_stencil] Original was GL_DEPTH_STENCIL_OES
        //     = 0x84F9
        DepthStencilOes = 34041,
        //
        // Summary:
        //     Original was GL_UNSIGNED_INT_24_8 = 0x84FA
        UnsignedInt248 = 34042,
        //
        // Summary:
        //     [requires: ANGLE_depth_texture, or OES_packed_depth_stencil] Original was GL_UNSIGNED_INT_24_8_OES
        //     = 0x84FA
        UnsignedInt248Oes = 34042,
        //
        // Summary:
        //     Original was GL_MAX_TEXTURE_LOD_BIAS = 0x84FD
        MaxTextureLodBias = 34045,
        //
        // Summary:
        //     [requires: EXT_texture_filter_anisotropic] Original was GL_TEXTURE_MAX_ANISOTROPY_EXT
        //     = 0x84FE
        TextureMaxAnisotropyExt = 34046,
        //
        // Summary:
        //     [requires: EXT_texture_filter_anisotropic] Original was GL_MAX_TEXTURE_MAX_ANISOTROPY_EXT
        //     = 0x84FF
        MaxTextureMaxAnisotropyExt = 34047,
        //
        // Summary:
        //     Original was GL_TEXTURE_LOD_BIAS = 0x8501
        TextureLodBias = 34049,
        //
        // Summary:
        //     Original was GL_INCR_WRAP = 0x8507
        IncrWrap = 34055,
        //
        // Summary:
        //     Original was GL_DECR_WRAP = 0x8508
        DecrWrap = 34056,
        //
        // Summary:
        //     [requires: EXT_sparse_texture] Original was GL_TEXTURE_CUBE_MAP = 0x8513
        TextureCubeMap = 34067,
        //
        // Summary:
        //     Original was GL_TEXTURE_BINDING_CUBE_MAP = 0x8514
        TextureBindingCubeMap = 34068,
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
        //     Original was GL_MAX_CUBE_MAP_TEXTURE_SIZE = 0x851C
        MaxCubeMapTextureSize = 34076,
        //
        // Summary:
        //     Original was GL_VERTEX_ARRAY_STORAGE_HINT_APPLE = 0x851F
        VertexArrayStorageHintApple = 34079,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_PRIMARY_COLOR_NV = 0x852C
        PrimaryColorNv = 34092,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_SECONDARY_COLOR_NV = 0x852D
        SecondaryColorNv = 34093,
        //
        // Summary:
        //     Original was GL_MULTISAMPLE_FILTER_HINT_NV = 0x8534
        MultisampleFilterHintNv = 34100,
        //
        // Summary:
        //     Original was GL_CONSTANT = 0x8576
        Constant = 34166,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_CONSTANT_NV = 0x8576
        ConstantNv = 34166,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_PRIMARY_COLOR = 0x8577
        PrimaryColor = 34167,
        //
        // Summary:
        //     Original was GL_SRC1_ALPHA = 0x8589
        Src1Alpha = 34185,
        //
        // Summary:
        //     [requires: EXT_blend_func_extended] Original was GL_SRC1_ALPHA_EXT = 0x8589
        Src1AlphaExt = 34185,
        //
        // Summary:
        //     Original was GL_PACK_SUBSAMPLE_RATE_SGIX = 0x85A0
        PackSubsampleRateSgix = 34208,
        //
        // Summary:
        //     Original was GL_UNPACK_SUBSAMPLE_RATE_SGIX = 0x85A1
        UnpackSubsampleRateSgix = 34209,
        //
        // Summary:
        //     Original was GL_PIXEL_SUBSAMPLE_4444_SGIX = 0x85A2
        PixelSubsample4444Sgix = 34210,
        //
        // Summary:
        //     Original was GL_PIXEL_SUBSAMPLE_2424_SGIX = 0x85A3
        PixelSubsample2424Sgix = 34211,
        //
        // Summary:
        //     Original was GL_PIXEL_SUBSAMPLE_4242_SGIX = 0x85A4
        PixelSubsample4242Sgix = 34212,
        //
        // Summary:
        //     Original was GL_TRANSFORM_HINT_APPLE = 0x85B1
        TransformHintApple = 34225,
        //
        // Summary:
        //     Original was GL_VERTEX_ARRAY_BINDING = 0x85B5
        VertexArrayBinding = 34229,
        //
        // Summary:
        //     [requires: OES_vertex_array_object] Original was GL_VERTEX_ARRAY_BINDING_OES
        //     = 0x85B5
        VertexArrayBindingOes = 34229,
        //
        // Summary:
        //     [requires: APPLE_rgb_422] Original was GL_UNSIGNED_SHORT_8_8_APPLE = 0x85BA
        UnsignedShort88Apple = 34234,
        //
        // Summary:
        //     [requires: APPLE_rgb_422] Original was GL_UNSIGNED_SHORT_8_8_REV_APPLE = 0x85BB
        UnsignedShort88RevApple = 34235,
        //
        // Summary:
        //     Original was GL_TEXTURE_STORAGE_HINT_APPLE = 0x85BC
        TextureStorageHintApple = 34236,
        //
        // Summary:
        //     Original was GL_VERTEX_ATTRIB_ARRAY_ENABLED = 0x8622
        VertexAttribArrayEnabled = 34338,
        //
        // Summary:
        //     Original was GL_VERTEX_ATTRIB_ARRAY_SIZE = 0x8623
        VertexAttribArraySize = 34339,
        //
        // Summary:
        //     Original was GL_VERTEX_ATTRIB_ARRAY_STRIDE = 0x8624
        VertexAttribArrayStride = 34340,
        //
        // Summary:
        //     Original was GL_VERTEX_ATTRIB_ARRAY_TYPE = 0x8625
        VertexAttribArrayType = 34341,
        //
        // Summary:
        //     Original was GL_CURRENT_VERTEX_ATTRIB = 0x8626
        CurrentVertexAttrib = 34342,
        //
        // Summary:
        //     Original was GL_VERTEX_ATTRIB_ARRAY_POINTER = 0x8645
        VertexAttribArrayPointer = 34373,
        //
        // Summary:
        //     Original was GL_TEXTURE_COMPRESSED = 0x86A1
        TextureCompressed = 34465,
        //
        // Summary:
        //     Original was GL_NUM_COMPRESSED_TEXTURE_FORMATS = 0x86A2
        NumCompressedTextureFormats = 34466,
        //
        // Summary:
        //     Original was GL_COMPRESSED_TEXTURE_FORMATS = 0x86A3
        CompressedTextureFormats = 34467,
        //
        // Summary:
        //     [requires: AMD_program_binary_Z400] Original was GL_Z400_BINARY_AMD = 0x8740
        Z400BinaryAmd = 34624,
        //
        // Summary:
        //     Original was GL_PROGRAM_BINARY_LENGTH = 0x8741
        ProgramBinaryLength = 34625,
        //
        // Summary:
        //     [requires: OES_get_program_binary] Original was GL_PROGRAM_BINARY_LENGTH_OES
        //     = 0x8741
        ProgramBinaryLengthOes = 34625,
        //
        // Summary:
        //     [requires: EXT_texture_mirror_clamp_to_edge] Original was GL_MIRROR_CLAMP_TO_EDGE_EXT
        //     = 0x8743
        MirrorClampToEdgeExt = 34627,
        //
        // Summary:
        //     Original was GL_VERTEX_ATTRIB_ARRAY_LONG = 0x874E
        VertexAttribArrayLong = 34638,
        //
        // Summary:
        //     Original was GL_DEPTH_STENCIL_MESA = 0x8750
        DepthStencilMesa = 34640,
        //
        // Summary:
        //     [requires: MESA_program_binary_formats] Original was GL_PROGRAM_BINARY_FORMAT_MESA
        //     = 0x875F
        ProgramBinaryFormatMesa = 34655,
        //
        // Summary:
        //     Original was GL_BUFFER_SIZE = 0x8764
        BufferSize = 34660,
        //
        // Summary:
        //     Original was GL_BUFFER_USAGE = 0x8765
        BufferUsage = 34661,
        //
        // Summary:
        //     [requires: AMD_compressed_ATC_texture] Original was GL_ATC_RGBA_INTERPOLATED_ALPHA_AMD
        //     = 0x87EE
        AtcRgbaInterpolatedAlphaAmd = 34798,
        //
        // Summary:
        //     [requires: AMD_compressed_3DC_texture] Original was GL_3DC_X_AMD = 0x87F9
        Gl3DcXAmd = 34809,
        //
        // Summary:
        //     [requires: AMD_compressed_3DC_texture] Original was GL_3DC_XY_AMD = 0x87FA
        Gl3DcXyAmd = 34810,
        //
        // Summary:
        //     Original was GL_NUM_PROGRAM_BINARY_FORMATS = 0x87FE
        NumProgramBinaryFormats = 34814,
        //
        // Summary:
        //     [requires: OES_get_program_binary] Original was GL_NUM_PROGRAM_BINARY_FORMATS_OES
        //     = 0x87FE
        NumProgramBinaryFormatsOes = 34814,
        //
        // Summary:
        //     Original was GL_PROGRAM_BINARY_FORMATS = 0x87FF
        ProgramBinaryFormats = 34815,
        //
        // Summary:
        //     [requires: OES_get_program_binary] Original was GL_PROGRAM_BINARY_FORMATS_OES
        //     = 0x87FF
        ProgramBinaryFormatsOes = 34815,
        //
        // Summary:
        //     Original was GL_STENCIL_BACK_FUNC = 0x8800
        StencilBackFunc = 34816,
        //
        // Summary:
        //     Original was GL_STENCIL_BACK_FAIL = 0x8801
        StencilBackFail = 34817,
        //
        // Summary:
        //     Original was GL_STENCIL_BACK_PASS_DEPTH_FAIL = 0x8802
        StencilBackPassDepthFail = 34818,
        //
        // Summary:
        //     Original was GL_STENCIL_BACK_PASS_DEPTH_PASS = 0x8803
        StencilBackPassDepthPass = 34819,
        //
        // Summary:
        //     Original was GL_RGBA32F = 0x8814
        Rgba32f = 34836,
        //
        // Summary:
        //     Original was GL_RGBA32F_ARB = 0x8814
        Rgba32fArb = 34836,
        //
        // Summary:
        //     [requires: EXT_texture_storage] Original was GL_RGBA32F_EXT = 0x8814
        Rgba32fExt = 34836,
        //
        // Summary:
        //     Original was GL_RGB32F = 0x8815
        Rgb32f = 34837,
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
        //     Original was GL_RGBA16F = 0x881A
        Rgba16f = 34842,
        //
        // Summary:
        //     Original was GL_RGBA16F_ARB = 0x881A
        Rgba16fArb = 34842,
        //
        // Summary:
        //     [requires: EXT_color_buffer_half_float, or EXT_texture_storage] Original was
        //     GL_RGBA16F_EXT = 0x881A
        Rgba16fExt = 34842,
        //
        // Summary:
        //     Original was GL_RGB16F = 0x881B
        Rgb16f = 34843,
        //
        // Summary:
        //     Original was GL_RGB16F_ARB = 0x881B
        Rgb16fArb = 34843,
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
        //     [requires: QCOM_writeonly_rendering] Original was GL_WRITEONLY_RENDERING_QCOM
        //     = 0x8823
        WriteonlyRenderingQcom = 34851,
        //
        // Summary:
        //     Original was GL_MAX_DRAW_BUFFERS = 0x8824
        MaxDrawBuffers = 34852,
        //
        // Summary:
        //     [requires: EXT_draw_buffers] Original was GL_MAX_DRAW_BUFFERS_EXT = 0x8824
        MaxDrawBuffersExt = 34852,
        //
        // Summary:
        //     [requires: NV_draw_buffers] Original was GL_MAX_DRAW_BUFFERS_NV = 0x8824
        MaxDrawBuffersNv = 34852,
        //
        // Summary:
        //     Original was GL_DRAW_BUFFER0 = 0x8825
        DrawBuffer0 = 34853,
        //
        // Summary:
        //     [requires: EXT_draw_buffers] Original was GL_DRAW_BUFFER0_EXT = 0x8825
        DrawBuffer0Ext = 34853,
        //
        // Summary:
        //     [requires: NV_draw_buffers] Original was GL_DRAW_BUFFER0_NV = 0x8825
        DrawBuffer0Nv = 34853,
        //
        // Summary:
        //     Original was GL_DRAW_BUFFER1 = 0x8826
        DrawBuffer1 = 34854,
        //
        // Summary:
        //     [requires: EXT_draw_buffers] Original was GL_DRAW_BUFFER1_EXT = 0x8826
        DrawBuffer1Ext = 34854,
        //
        // Summary:
        //     [requires: NV_draw_buffers] Original was GL_DRAW_BUFFER1_NV = 0x8826
        DrawBuffer1Nv = 34854,
        //
        // Summary:
        //     Original was GL_DRAW_BUFFER2 = 0x8827
        DrawBuffer2 = 34855,
        //
        // Summary:
        //     [requires: EXT_draw_buffers] Original was GL_DRAW_BUFFER2_EXT = 0x8827
        DrawBuffer2Ext = 34855,
        //
        // Summary:
        //     [requires: NV_draw_buffers] Original was GL_DRAW_BUFFER2_NV = 0x8827
        DrawBuffer2Nv = 34855,
        //
        // Summary:
        //     Original was GL_DRAW_BUFFER3 = 0x8828
        DrawBuffer3 = 34856,
        //
        // Summary:
        //     [requires: EXT_draw_buffers] Original was GL_DRAW_BUFFER3_EXT = 0x8828
        DrawBuffer3Ext = 34856,
        //
        // Summary:
        //     [requires: NV_draw_buffers] Original was GL_DRAW_BUFFER3_NV = 0x8828
        DrawBuffer3Nv = 34856,
        //
        // Summary:
        //     Original was GL_DRAW_BUFFER4 = 0x8829
        DrawBuffer4 = 34857,
        //
        // Summary:
        //     [requires: EXT_draw_buffers] Original was GL_DRAW_BUFFER4_EXT = 0x8829
        DrawBuffer4Ext = 34857,
        //
        // Summary:
        //     [requires: NV_draw_buffers] Original was GL_DRAW_BUFFER4_NV = 0x8829
        DrawBuffer4Nv = 34857,
        //
        // Summary:
        //     Original was GL_DRAW_BUFFER5 = 0x882A
        DrawBuffer5 = 34858,
        //
        // Summary:
        //     [requires: EXT_draw_buffers] Original was GL_DRAW_BUFFER5_EXT = 0x882A
        DrawBuffer5Ext = 34858,
        //
        // Summary:
        //     [requires: NV_draw_buffers] Original was GL_DRAW_BUFFER5_NV = 0x882A
        DrawBuffer5Nv = 34858,
        //
        // Summary:
        //     Original was GL_DRAW_BUFFER6 = 0x882B
        DrawBuffer6 = 34859,
        //
        // Summary:
        //     [requires: EXT_draw_buffers] Original was GL_DRAW_BUFFER6_EXT = 0x882B
        DrawBuffer6Ext = 34859,
        //
        // Summary:
        //     [requires: NV_draw_buffers] Original was GL_DRAW_BUFFER6_NV = 0x882B
        DrawBuffer6Nv = 34859,
        //
        // Summary:
        //     Original was GL_DRAW_BUFFER7 = 0x882C
        DrawBuffer7 = 34860,
        //
        // Summary:
        //     [requires: EXT_draw_buffers] Original was GL_DRAW_BUFFER7_EXT = 0x882C
        DrawBuffer7Ext = 34860,
        //
        // Summary:
        //     [requires: NV_draw_buffers] Original was GL_DRAW_BUFFER7_NV = 0x882C
        DrawBuffer7Nv = 34860,
        //
        // Summary:
        //     Original was GL_DRAW_BUFFER8 = 0x882D
        DrawBuffer8 = 34861,
        //
        // Summary:
        //     [requires: EXT_draw_buffers] Original was GL_DRAW_BUFFER8_EXT = 0x882D
        DrawBuffer8Ext = 34861,
        //
        // Summary:
        //     [requires: NV_draw_buffers] Original was GL_DRAW_BUFFER8_NV = 0x882D
        DrawBuffer8Nv = 34861,
        //
        // Summary:
        //     Original was GL_DRAW_BUFFER9 = 0x882E
        DrawBuffer9 = 34862,
        //
        // Summary:
        //     [requires: EXT_draw_buffers] Original was GL_DRAW_BUFFER9_EXT = 0x882E
        DrawBuffer9Ext = 34862,
        //
        // Summary:
        //     [requires: NV_draw_buffers] Original was GL_DRAW_BUFFER9_NV = 0x882E
        DrawBuffer9Nv = 34862,
        //
        // Summary:
        //     Original was GL_DRAW_BUFFER10 = 0x882F
        DrawBuffer10 = 34863,
        //
        // Summary:
        //     [requires: EXT_draw_buffers] Original was GL_DRAW_BUFFER10_EXT = 0x882F
        DrawBuffer10Ext = 34863,
        //
        // Summary:
        //     [requires: NV_draw_buffers] Original was GL_DRAW_BUFFER10_NV = 0x882F
        DrawBuffer10Nv = 34863,
        //
        // Summary:
        //     Original was GL_DRAW_BUFFER11 = 0x8830
        DrawBuffer11 = 34864,
        //
        // Summary:
        //     [requires: EXT_draw_buffers] Original was GL_DRAW_BUFFER11_EXT = 0x8830
        DrawBuffer11Ext = 34864,
        //
        // Summary:
        //     [requires: NV_draw_buffers] Original was GL_DRAW_BUFFER11_NV = 0x8830
        DrawBuffer11Nv = 34864,
        //
        // Summary:
        //     Original was GL_DRAW_BUFFER12 = 0x8831
        DrawBuffer12 = 34865,
        //
        // Summary:
        //     [requires: EXT_draw_buffers] Original was GL_DRAW_BUFFER12_EXT = 0x8831
        DrawBuffer12Ext = 34865,
        //
        // Summary:
        //     [requires: NV_draw_buffers] Original was GL_DRAW_BUFFER12_NV = 0x8831
        DrawBuffer12Nv = 34865,
        //
        // Summary:
        //     Original was GL_DRAW_BUFFER13 = 0x8832
        DrawBuffer13 = 34866,
        //
        // Summary:
        //     [requires: EXT_draw_buffers] Original was GL_DRAW_BUFFER13_EXT = 0x8832
        DrawBuffer13Ext = 34866,
        //
        // Summary:
        //     [requires: NV_draw_buffers] Original was GL_DRAW_BUFFER13_NV = 0x8832
        DrawBuffer13Nv = 34866,
        //
        // Summary:
        //     Original was GL_DRAW_BUFFER14 = 0x8833
        DrawBuffer14 = 34867,
        //
        // Summary:
        //     [requires: EXT_draw_buffers] Original was GL_DRAW_BUFFER14_EXT = 0x8833
        DrawBuffer14Ext = 34867,
        //
        // Summary:
        //     [requires: NV_draw_buffers] Original was GL_DRAW_BUFFER14_NV = 0x8833
        DrawBuffer14Nv = 34867,
        //
        // Summary:
        //     Original was GL_DRAW_BUFFER15 = 0x8834
        DrawBuffer15 = 34868,
        //
        // Summary:
        //     [requires: EXT_draw_buffers] Original was GL_DRAW_BUFFER15_EXT = 0x8834
        DrawBuffer15Ext = 34868,
        //
        // Summary:
        //     [requires: NV_draw_buffers] Original was GL_DRAW_BUFFER15_NV = 0x8834
        DrawBuffer15Nv = 34868,
        //
        // Summary:
        //     [requires: EXT_draw_buffers_indexed, or OES_draw_buffers_indexed] Original was
        //     GL_BLEND_EQUATION_ALPHA = 0x883D
        BlendEquationAlpha = 34877,
        //
        // Summary:
        //     Original was GL_TEXTURE_COMPARE_MODE = 0x884C
        TextureCompareMode = 34892,
        //
        // Summary:
        //     [requires: EXT_shadow_samplers] Original was GL_TEXTURE_COMPARE_MODE_EXT = 0x884C
        TextureCompareModeExt = 34892,
        //
        // Summary:
        //     Original was GL_TEXTURE_COMPARE_FUNC = 0x884D
        TextureCompareFunc = 34893,
        //
        // Summary:
        //     [requires: EXT_shadow_samplers] Original was GL_TEXTURE_COMPARE_FUNC_EXT = 0x884D
        TextureCompareFuncExt = 34893,
        //
        // Summary:
        //     Original was GL_COMPARE_REF_TO_TEXTURE = 0x884E
        CompareRefToTexture = 34894,
        //
        // Summary:
        //     [requires: EXT_shadow_samplers] Original was GL_COMPARE_REF_TO_TEXTURE_EXT =
        //     0x884E
        CompareRefToTextureExt = 34894,
        //
        // Summary:
        //     Original was GL_QUERY_COUNTER_BITS = 0x8864
        QueryCounterBits = 34916,
        //
        // Summary:
        //     [requires: EXT_disjoint_timer_query] Original was GL_QUERY_COUNTER_BITS_EXT =
        //     0x8864
        QueryCounterBitsExt = 34916,
        //
        // Summary:
        //     Original was GL_CURRENT_QUERY = 0x8865
        CurrentQuery = 34917,
        //
        // Summary:
        //     [requires: EXT_disjoint_timer_query, or EXT_occlusion_query_boolean] Original
        //     was GL_CURRENT_QUERY_EXT = 0x8865
        CurrentQueryExt = 34917,
        //
        // Summary:
        //     Original was GL_QUERY_RESULT = 0x8866
        QueryResult = 34918,
        //
        // Summary:
        //     [requires: EXT_disjoint_timer_query, or EXT_occlusion_query_boolean] Original
        //     was GL_QUERY_RESULT_EXT = 0x8866
        QueryResultExt = 34918,
        //
        // Summary:
        //     Original was GL_QUERY_RESULT_AVAILABLE = 0x8867
        QueryResultAvailable = 34919,
        //
        // Summary:
        //     [requires: EXT_disjoint_timer_query, or EXT_occlusion_query_boolean] Original
        //     was GL_QUERY_RESULT_AVAILABLE_EXT = 0x8867
        QueryResultAvailableExt = 34919,
        //
        // Summary:
        //     Original was GL_MAX_VERTEX_ATTRIBS = 0x8869
        MaxVertexAttribs = 34921,
        //
        // Summary:
        //     Original was GL_VERTEX_ATTRIB_ARRAY_NORMALIZED = 0x886A
        VertexAttribArrayNormalized = 34922,
        //
        // Summary:
        //     [requires: EXT_tessellation_shader] Original was GL_MAX_TESS_CONTROL_INPUT_COMPONENTS_EXT
        //     = 0x886C
        MaxTessControlInputComponentsExt = 34924,
        //
        // Summary:
        //     [requires: OES_tessellation_shader] Original was GL_MAX_TESS_CONTROL_INPUT_COMPONENTS_OES
        //     = 0x886C
        MaxTessControlInputComponentsOes = 34924,
        //
        // Summary:
        //     [requires: EXT_tessellation_shader] Original was GL_MAX_TESS_EVALUATION_INPUT_COMPONENTS_EXT
        //     = 0x886D
        MaxTessEvaluationInputComponentsExt = 34925,
        //
        // Summary:
        //     [requires: OES_tessellation_shader] Original was GL_MAX_TESS_EVALUATION_INPUT_COMPONENTS_OES
        //     = 0x886D
        MaxTessEvaluationInputComponentsOes = 34925,
        //
        // Summary:
        //     Original was GL_MAX_TEXTURE_IMAGE_UNITS = 0x8872
        MaxTextureImageUnits = 34930,
        //
        // Summary:
        //     [requires: EXT_geometry_shader] Original was GL_GEOMETRY_SHADER_INVOCATIONS_EXT
        //     = 0x887F
        GeometryShaderInvocationsExt = 34943,
        //
        // Summary:
        //     [requires: OES_geometry_shader] Original was GL_GEOMETRY_SHADER_INVOCATIONS_OES
        //     = 0x887F
        GeometryShaderInvocationsOes = 34943,
        //
        // Summary:
        //     Original was GL_ARRAY_BUFFER = 0x8892
        ArrayBuffer = 34962,
        //
        // Summary:
        //     Original was GL_ELEMENT_ARRAY_BUFFER = 0x8893
        ElementArrayBuffer = 34963,
        //
        // Summary:
        //     Original was GL_ARRAY_BUFFER_BINDING = 0x8894
        ArrayBufferBinding = 34964,
        //
        // Summary:
        //     Original was GL_ELEMENT_ARRAY_BUFFER_BINDING = 0x8895
        ElementArrayBufferBinding = 34965,
        //
        // Summary:
        //     Original was GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING = 0x889F
        VertexAttribArrayBufferBinding = 34975,
        //
        // Summary:
        //     Original was GL_READ_ONLY = 0x88B8
        ReadOnly = 35000,
        //
        // Summary:
        //     Original was GL_WRITE_ONLY = 0x88B9
        WriteOnly = 35001,
        //
        // Summary:
        //     [requires: OES_mapbuffer] Original was GL_WRITE_ONLY_OES = 0x88B9
        WriteOnlyOes = 35001,
        //
        // Summary:
        //     Original was GL_READ_WRITE = 0x88BA
        ReadWrite = 35002,
        //
        // Summary:
        //     Original was GL_BUFFER_ACCESS = 0x88BB
        BufferAccess = 35003,
        //
        // Summary:
        //     [requires: OES_mapbuffer] Original was GL_BUFFER_ACCESS_OES = 0x88BB
        BufferAccessOes = 35003,
        //
        // Summary:
        //     Original was GL_BUFFER_MAPPED = 0x88BC
        BufferMapped = 35004,
        //
        // Summary:
        //     [requires: OES_mapbuffer] Original was GL_BUFFER_MAPPED_OES = 0x88BC
        BufferMappedOes = 35004,
        //
        // Summary:
        //     Original was GL_BUFFER_MAP_POINTER = 0x88BD
        BufferMapPointer = 35005,
        //
        // Summary:
        //     [requires: OES_mapbuffer] Original was GL_BUFFER_MAP_POINTER_OES = 0x88BD
        BufferMapPointerOes = 35005,
        //
        // Summary:
        //     Original was GL_TIME_ELAPSED = 0x88BF
        TimeElapsed = 35007,
        //
        // Summary:
        //     [requires: EXT_disjoint_timer_query] Original was GL_TIME_ELAPSED_EXT = 0x88BF
        TimeElapsedExt = 35007,
        //
        // Summary:
        //     Original was GL_STREAM_DRAW = 0x88E0
        StreamDraw = 35040,
        //
        // Summary:
        //     Original was GL_STREAM_READ = 0x88E1
        StreamRead = 35041,
        //
        // Summary:
        //     Original was GL_STREAM_COPY = 0x88E2
        StreamCopy = 35042,
        //
        // Summary:
        //     Original was GL_STATIC_DRAW = 0x88E4
        StaticDraw = 35044,
        //
        // Summary:
        //     Original was GL_STATIC_READ = 0x88E5
        StaticRead = 35045,
        //
        // Summary:
        //     Original was GL_STATIC_COPY = 0x88E6
        StaticCopy = 35046,
        //
        // Summary:
        //     Original was GL_DYNAMIC_DRAW = 0x88E8
        DynamicDraw = 35048,
        //
        // Summary:
        //     Original was GL_DYNAMIC_READ = 0x88E9
        DynamicRead = 35049,
        //
        // Summary:
        //     Original was GL_DYNAMIC_COPY = 0x88EA
        DynamicCopy = 35050,
        //
        // Summary:
        //     Original was GL_PIXEL_PACK_BUFFER = 0x88EB
        PixelPackBuffer = 35051,
        //
        // Summary:
        //     [requires: NV_pixel_buffer_object] Original was GL_PIXEL_PACK_BUFFER_NV = 0x88EB
        PixelPackBufferNv = 35051,
        //
        // Summary:
        //     Original was GL_PIXEL_UNPACK_BUFFER = 0x88EC
        PixelUnpackBuffer = 35052,
        //
        // Summary:
        //     [requires: NV_pixel_buffer_object] Original was GL_PIXEL_UNPACK_BUFFER_NV = 0x88EC
        PixelUnpackBufferNv = 35052,
        //
        // Summary:
        //     Original was GL_PIXEL_PACK_BUFFER_BINDING = 0x88ED
        PixelPackBufferBinding = 35053,
        //
        // Summary:
        //     [requires: NV_pixel_buffer_object] Original was GL_PIXEL_PACK_BUFFER_BINDING_NV
        //     = 0x88ED
        PixelPackBufferBindingNv = 35053,
        //
        // Summary:
        //     [requires: NV_sRGB_formats] Original was GL_ETC1_SRGB8_NV = 0x88EE
        Etc1Srgb8Nv = 35054,
        //
        // Summary:
        //     Original was GL_PIXEL_UNPACK_BUFFER_BINDING = 0x88EF
        PixelUnpackBufferBinding = 35055,
        //
        // Summary:
        //     [requires: NV_pixel_buffer_object] Original was GL_PIXEL_UNPACK_BUFFER_BINDING_NV
        //     = 0x88EF
        PixelUnpackBufferBindingNv = 35055,
        //
        // Summary:
        //     Original was GL_DEPTH24_STENCIL8 = 0x88F0
        Depth24Stencil8 = 35056,
        //
        // Summary:
        //     Original was GL_DEPTH24_STENCIL8_EXT = 0x88F0
        Depth24Stencil8Ext = 35056,
        //
        // Summary:
        //     [requires: ANGLE_depth_texture, or OES_packed_depth_stencil, OES_required_internalformat]
        //     Original was GL_DEPTH24_STENCIL8_OES = 0x88F0
        Depth24Stencil8Oes = 35056,
        //
        // Summary:
        //     Original was GL_SRC1_COLOR = 0x88F9
        Src1Color = 35065,
        //
        // Summary:
        //     [requires: EXT_blend_func_extended] Original was GL_SRC1_COLOR_EXT = 0x88F9
        Src1ColorExt = 35065,
        //
        // Summary:
        //     [requires: EXT_blend_func_extended] Original was GL_ONE_MINUS_SRC1_COLOR_EXT
        //     = 0x88FA
        OneMinusSrc1ColorExt = 35066,
        //
        // Summary:
        //     [requires: EXT_blend_func_extended] Original was GL_ONE_MINUS_SRC1_ALPHA_EXT
        //     = 0x88FB
        OneMinusSrc1AlphaExt = 35067,
        //
        // Summary:
        //     [requires: EXT_blend_func_extended] Original was GL_MAX_DUAL_SOURCE_DRAW_BUFFERS_EXT
        //     = 0x88FC
        MaxDualSourceDrawBuffersExt = 35068,
        //
        // Summary:
        //     Original was GL_VERTEX_ATTRIB_ARRAY_INTEGER = 0x88FD
        VertexAttribArrayInteger = 35069,
        //
        // Summary:
        //     Original was GL_VERTEX_ATTRIB_ARRAY_DIVISOR = 0x88FE
        VertexAttribArrayDivisor = 35070,
        //
        // Summary:
        //     [requires: ANGLE_instanced_arrays] Original was GL_VERTEX_ATTRIB_ARRAY_DIVISOR_ANGLE
        //     = 0x88FE
        VertexAttribArrayDivisorAngle = 35070,
        //
        // Summary:
        //     [requires: EXT_instanced_arrays] Original was GL_VERTEX_ATTRIB_ARRAY_DIVISOR_EXT
        //     = 0x88FE
        VertexAttribArrayDivisorExt = 35070,
        //
        // Summary:
        //     [requires: NV_instanced_arrays] Original was GL_VERTEX_ATTRIB_ARRAY_DIVISOR_NV
        //     = 0x88FE
        VertexAttribArrayDivisorNv = 35070,
        //
        // Summary:
        //     Original was GL_MAX_ARRAY_TEXTURE_LAYERS = 0x88FF
        MaxArrayTextureLayers = 35071,
        //
        // Summary:
        //     Original was GL_MIN_PROGRAM_TEXEL_OFFSET = 0x8904
        MinProgramTexelOffset = 35076,
        //
        // Summary:
        //     Original was GL_MAX_PROGRAM_TEXEL_OFFSET = 0x8905
        MaxProgramTexelOffset = 35077,
        //
        // Summary:
        //     Original was GL_SAMPLES_PASSED = 0x8914
        SamplesPassed = 35092,
        //
        // Summary:
        //     [requires: EXT_geometry_shader] Original was GL_GEOMETRY_LINKED_VERTICES_OUT_EXT
        //     = 0x8916
        GeometryLinkedVerticesOutExt = 35094,
        //
        // Summary:
        //     [requires: OES_geometry_shader] Original was GL_GEOMETRY_LINKED_VERTICES_OUT_OES
        //     = 0x8916
        GeometryLinkedVerticesOutOes = 35094,
        //
        // Summary:
        //     Original was GL_GEOMETRY_VERTICES_OUT = 0x8916
        GeometryVerticesOut = 35094,
        //
        // Summary:
        //     Original was GL_GEOMETRY_INPUT_TYPE = 0x8917
        GeometryInputType = 35095,
        //
        // Summary:
        //     [requires: EXT_geometry_shader] Original was GL_GEOMETRY_LINKED_INPUT_TYPE_EXT
        //     = 0x8917
        GeometryLinkedInputTypeExt = 35095,
        //
        // Summary:
        //     [requires: OES_geometry_shader] Original was GL_GEOMETRY_LINKED_INPUT_TYPE_OES
        //     = 0x8917
        GeometryLinkedInputTypeOes = 35095,
        //
        // Summary:
        //     [requires: EXT_geometry_shader] Original was GL_GEOMETRY_LINKED_OUTPUT_TYPE_EXT
        //     = 0x8918
        GeometryLinkedOutputTypeExt = 35096,
        //
        // Summary:
        //     [requires: OES_geometry_shader] Original was GL_GEOMETRY_LINKED_OUTPUT_TYPE_OES
        //     = 0x8918
        GeometryLinkedOutputTypeOes = 35096,
        //
        // Summary:
        //     Original was GL_GEOMETRY_OUTPUT_TYPE = 0x8918
        GeometryOutputType = 35096,
        //
        // Summary:
        //     Original was GL_SAMPLER_BINDING = 0x8919
        SamplerBinding = 35097,
        //
        // Summary:
        //     Original was GL_MOV_ATI = 0x8961
        MovAti = 35169,
        //
        // Summary:
        //     Original was GL_ADD_ATI = 0x8963
        AddAti = 35171,
        //
        // Summary:
        //     Original was GL_MUL_ATI = 0x8964
        MulAti = 35172,
        //
        // Summary:
        //     Original was GL_SUB_ATI = 0x8965
        SubAti = 35173,
        //
        // Summary:
        //     Original was GL_DOT3_ATI = 0x8966
        Dot3Ati = 35174,
        //
        // Summary:
        //     Original was GL_DOT4_ATI = 0x8967
        Dot4Ati = 35175,
        //
        // Summary:
        //     Original was GL_MAD_ATI = 0x8968
        MadAti = 35176,
        //
        // Summary:
        //     Original was GL_LERP_ATI = 0x8969
        LerpAti = 35177,
        //
        // Summary:
        //     Original was GL_CND_ATI = 0x896A
        CndAti = 35178,
        //
        // Summary:
        //     Original was GL_CND0_ATI = 0x896B
        Cnd0Ati = 35179,
        //
        // Summary:
        //     Original was GL_DOT2_ADD_ATI = 0x896C
        Dot2AddAti = 35180,
        //
        // Summary:
        //     Original was GL_PACK_RESAMPLE_OML = 0x8984
        PackResampleOml = 35204,
        //
        // Summary:
        //     Original was GL_UNPACK_RESAMPLE_OML = 0x8985
        UnpackResampleOml = 35205,
        //
        // Summary:
        //     Original was GL_UNIFORM_BUFFER = 0x8A11
        UniformBuffer = 35345,
        //
        // Summary:
        //     [requires: APPLE_rgb_422] Original was GL_RGB_422_APPLE = 0x8A1F
        Rgb422Apple = 35359,
        //
        // Summary:
        //     Original was GL_UNIFORM_BUFFER_BINDING = 0x8A28
        UniformBufferBinding = 35368,
        //
        // Summary:
        //     Original was GL_UNIFORM_BUFFER_START = 0x8A29
        UniformBufferStart = 35369,
        //
        // Summary:
        //     Original was GL_UNIFORM_BUFFER_SIZE = 0x8A2A
        UniformBufferSize = 35370,
        //
        // Summary:
        //     Original was GL_MAX_VERTEX_UNIFORM_BLOCKS = 0x8A2B
        MaxVertexUniformBlocks = 35371,
        //
        // Summary:
        //     [requires: EXT_geometry_shader] Original was GL_MAX_GEOMETRY_UNIFORM_BLOCKS_EXT
        //     = 0x8A2C
        MaxGeometryUniformBlocksExt = 35372,
        //
        // Summary:
        //     [requires: OES_geometry_shader] Original was GL_MAX_GEOMETRY_UNIFORM_BLOCKS_OES
        //     = 0x8A2C
        MaxGeometryUniformBlocksOes = 35372,
        //
        // Summary:
        //     Original was GL_MAX_FRAGMENT_UNIFORM_BLOCKS = 0x8A2D
        MaxFragmentUniformBlocks = 35373,
        //
        // Summary:
        //     Original was GL_MAX_COMBINED_UNIFORM_BLOCKS = 0x8A2E
        MaxCombinedUniformBlocks = 35374,
        //
        // Summary:
        //     Original was GL_MAX_UNIFORM_BUFFER_BINDINGS = 0x8A2F
        MaxUniformBufferBindings = 35375,
        //
        // Summary:
        //     Original was GL_MAX_UNIFORM_BLOCK_SIZE = 0x8A30
        MaxUniformBlockSize = 35376,
        //
        // Summary:
        //     Original was GL_MAX_COMBINED_VERTEX_UNIFORM_COMPONENTS = 0x8A31
        MaxCombinedVertexUniformComponents = 35377,
        //
        // Summary:
        //     [requires: EXT_geometry_shader] Original was GL_MAX_COMBINED_GEOMETRY_UNIFORM_COMPONENTS_EXT
        //     = 0x8A32
        MaxCombinedGeometryUniformComponentsExt = 35378,
        //
        // Summary:
        //     [requires: OES_geometry_shader] Original was GL_MAX_COMBINED_GEOMETRY_UNIFORM_COMPONENTS_OES
        //     = 0x8A32
        MaxCombinedGeometryUniformComponentsOes = 35378,
        //
        // Summary:
        //     Original was GL_MAX_COMBINED_FRAGMENT_UNIFORM_COMPONENTS = 0x8A33
        MaxCombinedFragmentUniformComponents = 35379,
        //
        // Summary:
        //     Original was GL_UNIFORM_BUFFER_OFFSET_ALIGNMENT = 0x8A34
        UniformBufferOffsetAlignment = 35380,
        //
        // Summary:
        //     Original was GL_ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH = 0x8A35
        ActiveUniformBlockMaxNameLength = 35381,
        //
        // Summary:
        //     Original was GL_ACTIVE_UNIFORM_BLOCKS = 0x8A36
        ActiveUniformBlocks = 35382,
        //
        // Summary:
        //     Original was GL_UNIFORM_TYPE = 0x8A37
        UniformType = 35383,
        //
        // Summary:
        //     Original was GL_UNIFORM_SIZE = 0x8A38
        UniformSize = 35384,
        //
        // Summary:
        //     Original was GL_UNIFORM_NAME_LENGTH = 0x8A39
        UniformNameLength = 35385,
        //
        // Summary:
        //     Original was GL_UNIFORM_BLOCK_INDEX = 0x8A3A
        UniformBlockIndex = 35386,
        //
        // Summary:
        //     Original was GL_UNIFORM_OFFSET = 0x8A3B
        UniformOffset = 35387,
        //
        // Summary:
        //     Original was GL_UNIFORM_ARRAY_STRIDE = 0x8A3C
        UniformArrayStride = 35388,
        //
        // Summary:
        //     Original was GL_UNIFORM_MATRIX_STRIDE = 0x8A3D
        UniformMatrixStride = 35389,
        //
        // Summary:
        //     Original was GL_UNIFORM_IS_ROW_MAJOR = 0x8A3E
        UniformIsRowMajor = 35390,
        //
        // Summary:
        //     Original was GL_UNIFORM_BLOCK_BINDING = 0x8A3F
        UniformBlockBinding = 35391,
        //
        // Summary:
        //     Original was GL_UNIFORM_BLOCK_DATA_SIZE = 0x8A40
        UniformBlockDataSize = 35392,
        //
        // Summary:
        //     Original was GL_UNIFORM_BLOCK_NAME_LENGTH = 0x8A41
        UniformBlockNameLength = 35393,
        //
        // Summary:
        //     Original was GL_UNIFORM_BLOCK_ACTIVE_UNIFORMS = 0x8A42
        UniformBlockActiveUniforms = 35394,
        //
        // Summary:
        //     Original was GL_UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES = 0x8A43
        UniformBlockActiveUniformIndices = 35395,
        //
        // Summary:
        //     Original was GL_UNIFORM_BLOCK_REFERENCED_BY_VERTEX_SHADER = 0x8A44
        UniformBlockReferencedByVertexShader = 35396,
        //
        // Summary:
        //     Original was GL_UNIFORM_BLOCK_REFERENCED_BY_GEOMETRY_SHADER = 0x8A45
        UniformBlockReferencedByGeometryShader = 35397,
        //
        // Summary:
        //     Original was GL_UNIFORM_BLOCK_REFERENCED_BY_FRAGMENT_SHADER = 0x8A46
        UniformBlockReferencedByFragmentShader = 35398,
        //
        // Summary:
        //     [requires: EXT_texture_sRGB_decode] Original was GL_TEXTURE_SRGB_DECODE_EXT =
        //     0x8A48
        TextureSrgbDecodeExt = 35400,
        //
        // Summary:
        //     [requires: EXT_texture_sRGB_decode] Original was GL_DECODE_EXT = 0x8A49
        DecodeExt = 35401,
        //
        // Summary:
        //     [requires: EXT_texture_sRGB_decode] Original was GL_SKIP_DECODE_EXT = 0x8A4A
        SkipDecodeExt = 35402,
        //
        // Summary:
        //     [requires: EXT_debug_label] Original was GL_PROGRAM_PIPELINE_OBJECT_EXT = 0x8A4F
        ProgramPipelineObjectExt = 35407,
        //
        // Summary:
        //     [requires: APPLE_rgb_422] Original was GL_RGB_RAW_422_APPLE = 0x8A51
        RgbRaw422Apple = 35409,
        //
        // Summary:
        //     [requires: EXT_shader_framebuffer_fetch] Original was GL_FRAGMENT_SHADER_DISCARDS_SAMPLES_EXT
        //     = 0x8A52
        FragmentShaderDiscardsSamplesExt = 35410,
        //
        // Summary:
        //     [requires: APPLE_sync] Original was GL_SYNC_OBJECT_APPLE = 0x8A53
        SyncObjectApple = 35411,
        //
        // Summary:
        //     [requires: EXT_pvrtc_sRGB] Original was GL_COMPRESSED_SRGB_PVRTC_2BPPV1_EXT =
        //     0x8A54
        CompressedSrgbPvrtc2Bppv1Ext = 35412,
        //
        // Summary:
        //     [requires: EXT_pvrtc_sRGB] Original was GL_COMPRESSED_SRGB_PVRTC_4BPPV1_EXT =
        //     0x8A55
        CompressedSrgbPvrtc4Bppv1Ext = 35413,
        //
        // Summary:
        //     [requires: EXT_pvrtc_sRGB] Original was GL_COMPRESSED_SRGB_ALPHA_PVRTC_2BPPV1_EXT
        //     = 0x8A56
        CompressedSrgbAlphaPvrtc2Bppv1Ext = 35414,
        //
        // Summary:
        //     [requires: EXT_pvrtc_sRGB] Original was GL_COMPRESSED_SRGB_ALPHA_PVRTC_4BPPV1_EXT
        //     = 0x8A57
        CompressedSrgbAlphaPvrtc4Bppv1Ext = 35415,
        //
        // Summary:
        //     Original was GL_FRAGMENT_SHADER = 0x8B30
        FragmentShader = 35632,
        //
        // Summary:
        //     Original was GL_FRAGMENT_SHADER_ARB = 0x8B30
        FragmentShaderArb = 35632,
        //
        // Summary:
        //     Original was GL_VERTEX_SHADER = 0x8B31
        VertexShader = 35633,
        //
        // Summary:
        //     Original was GL_VERTEX_SHADER_ARB = 0x8B31
        VertexShaderArb = 35633,
        //
        // Summary:
        //     [requires: EXT_debug_label] Original was GL_PROGRAM_OBJECT_EXT = 0x8B40
        ProgramObjectExt = 35648,
        //
        // Summary:
        //     [requires: EXT_debug_label] Original was GL_SHADER_OBJECT_EXT = 0x8B48
        ShaderObjectExt = 35656,
        //
        // Summary:
        //     Original was GL_MAX_FRAGMENT_UNIFORM_COMPONENTS = 0x8B49
        MaxFragmentUniformComponents = 35657,
        //
        // Summary:
        //     Original was GL_MAX_VERTEX_UNIFORM_COMPONENTS = 0x8B4A
        MaxVertexUniformComponents = 35658,
        //
        // Summary:
        //     Original was GL_MAX_VARYING_COMPONENTS = 0x8B4B
        MaxVaryingComponents = 35659,
        //
        // Summary:
        //     Original was GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS = 0x8B4C
        MaxVertexTextureImageUnits = 35660,
        //
        // Summary:
        //     Original was GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS = 0x8B4D
        MaxCombinedTextureImageUnits = 35661,
        //
        // Summary:
        //     Original was GL_SHADER_TYPE = 0x8B4F
        ShaderType = 35663,
        //
        // Summary:
        //     Original was GL_FLOAT_VEC2 = 0x8B50
        FloatVec2 = 35664,
        //
        // Summary:
        //     Original was GL_FLOAT_VEC2_ARB = 0x8B50
        FloatVec2Arb = 35664,
        //
        // Summary:
        //     Original was GL_FLOAT_VEC3 = 0x8B51
        FloatVec3 = 35665,
        //
        // Summary:
        //     Original was GL_FLOAT_VEC3_ARB = 0x8B51
        FloatVec3Arb = 35665,
        //
        // Summary:
        //     Original was GL_FLOAT_VEC4 = 0x8B52
        FloatVec4 = 35666,
        //
        // Summary:
        //     Original was GL_FLOAT_VEC4_ARB = 0x8B52
        FloatVec4Arb = 35666,
        //
        // Summary:
        //     Original was GL_INT_VEC2 = 0x8B53
        IntVec2 = 35667,
        //
        // Summary:
        //     Original was GL_INT_VEC2_ARB = 0x8B53
        IntVec2Arb = 35667,
        //
        // Summary:
        //     Original was GL_INT_VEC3 = 0x8B54
        IntVec3 = 35668,
        //
        // Summary:
        //     Original was GL_INT_VEC3_ARB = 0x8B54
        IntVec3Arb = 35668,
        //
        // Summary:
        //     Original was GL_INT_VEC4 = 0x8B55
        IntVec4 = 35669,
        //
        // Summary:
        //     Original was GL_INT_VEC4_ARB = 0x8B55
        IntVec4Arb = 35669,
        //
        // Summary:
        //     Original was GL_BOOL_ARB = 0x8B56
        BoolArb = 35670,
        //
        // Summary:
        //     Original was GL_Bool = 0X8b56
        Bool = 35670,
        //
        // Summary:
        //     Original was GL_BOOL_VEC2 = 0x8B57
        BoolVec2 = 35671,
        //
        // Summary:
        //     Original was GL_BOOL_VEC2_ARB = 0x8B57
        BoolVec2Arb = 35671,
        //
        // Summary:
        //     Original was GL_BOOL_VEC3 = 0x8B58
        BoolVec3 = 35672,
        //
        // Summary:
        //     Original was GL_BOOL_VEC3_ARB = 0x8B58
        BoolVec3Arb = 35672,
        //
        // Summary:
        //     Original was GL_BOOL_VEC4 = 0x8B59
        BoolVec4 = 35673,
        //
        // Summary:
        //     Original was GL_BOOL_VEC4_ARB = 0x8B59
        BoolVec4Arb = 35673,
        //
        // Summary:
        //     Original was GL_FLOAT_MAT2 = 0x8B5A
        FloatMat2 = 35674,
        //
        // Summary:
        //     Original was GL_FLOAT_MAT2_ARB = 0x8B5A
        FloatMat2Arb = 35674,
        //
        // Summary:
        //     Original was GL_FLOAT_MAT3 = 0x8B5B
        FloatMat3 = 35675,
        //
        // Summary:
        //     Original was GL_FLOAT_MAT3_ARB = 0x8B5B
        FloatMat3Arb = 35675,
        //
        // Summary:
        //     Original was GL_FLOAT_MAT4 = 0x8B5C
        FloatMat4 = 35676,
        //
        // Summary:
        //     Original was GL_FLOAT_MAT4_ARB = 0x8B5C
        FloatMat4Arb = 35676,
        //
        // Summary:
        //     Original was GL_SAMPLER_1D = 0x8B5D
        Sampler1D = 35677,
        //
        // Summary:
        //     Original was GL_SAMPLER_1D_ARB = 0x8B5D
        Sampler1DArb = 35677,
        //
        // Summary:
        //     Original was GL_SAMPLER_2D = 0x8B5E
        Sampler2D = 35678,
        //
        // Summary:
        //     Original was GL_SAMPLER_2D_ARB = 0x8B5E
        Sampler2DArb = 35678,
        //
        // Summary:
        //     Original was GL_SAMPLER_3D = 0x8B5F
        Sampler3D = 35679,
        //
        // Summary:
        //     Original was GL_SAMPLER_3D_ARB = 0x8B5F
        Sampler3DArb = 35679,
        //
        // Summary:
        //     [requires: OES_texture_3D] Original was GL_SAMPLER_3D_OES = 0x8B5F
        Sampler3DOes = 35679,
        //
        // Summary:
        //     Original was GL_SAMPLER_CUBE = 0x8B60
        SamplerCube = 35680,
        //
        // Summary:
        //     Original was GL_SAMPLER_CUBE_ARB = 0x8B60
        SamplerCubeArb = 35680,
        //
        // Summary:
        //     Original was GL_SAMPLER_1D_SHADOW = 0x8B61
        Sampler1DShadow = 35681,
        //
        // Summary:
        //     Original was GL_SAMPLER_1D_SHADOW_ARB = 0x8B61
        Sampler1DShadowArb = 35681,
        //
        // Summary:
        //     Original was GL_SAMPLER_2D_SHADOW = 0x8B62
        Sampler2DShadow = 35682,
        //
        // Summary:
        //     Original was GL_SAMPLER_2D_SHADOW_ARB = 0x8B62
        Sampler2DShadowArb = 35682,
        //
        // Summary:
        //     [requires: EXT_shadow_samplers] Original was GL_SAMPLER_2D_SHADOW_EXT = 0x8B62
        Sampler2DShadowExt = 35682,
        //
        // Summary:
        //     Original was GL_SAMPLER_2D_RECT = 0x8B63
        Sampler2DRect = 35683,
        //
        // Summary:
        //     Original was GL_SAMPLER_2D_RECT_ARB = 0x8B63
        Sampler2DRectArb = 35683,
        //
        // Summary:
        //     Original was GL_SAMPLER_2D_RECT_SHADOW = 0x8B64
        Sampler2DRectShadow = 35684,
        //
        // Summary:
        //     Original was GL_SAMPLER_2D_RECT_SHADOW_ARB = 0x8B64
        Sampler2DRectShadowArb = 35684,
        //
        // Summary:
        //     Original was GL_FLOAT_MAT2x3 = 0x8B65
        FloatMat2x3 = 35685,
        //
        // Summary:
        //     [requires: NV_non_square_matrices] Original was GL_FLOAT_MAT2x3_NV = 0x8B65
        FloatMat2x3Nv = 35685,
        //
        // Summary:
        //     Original was GL_FLOAT_MAT2x4 = 0x8B66
        FloatMat2x4 = 35686,
        //
        // Summary:
        //     [requires: NV_non_square_matrices] Original was GL_FLOAT_MAT2x4_NV = 0x8B66
        FloatMat2x4Nv = 35686,
        //
        // Summary:
        //     Original was GL_FLOAT_MAT3x2 = 0x8B67
        FloatMat3x2 = 35687,
        //
        // Summary:
        //     [requires: NV_non_square_matrices] Original was GL_FLOAT_MAT3x2_NV = 0x8B67
        FloatMat3x2Nv = 35687,
        //
        // Summary:
        //     Original was GL_FLOAT_MAT3x4 = 0x8B68
        FloatMat3x4 = 35688,
        //
        // Summary:
        //     [requires: NV_non_square_matrices] Original was GL_FLOAT_MAT3x4_NV = 0x8B68
        FloatMat3x4Nv = 35688,
        //
        // Summary:
        //     Original was GL_FLOAT_MAT4x2 = 0x8B69
        FloatMat4x2 = 35689,
        //
        // Summary:
        //     [requires: NV_non_square_matrices] Original was GL_FLOAT_MAT4x2_NV = 0x8B69
        FloatMat4x2Nv = 35689,
        //
        // Summary:
        //     Original was GL_FLOAT_MAT4x3 = 0x8B6A
        FloatMat4x3 = 35690,
        //
        // Summary:
        //     [requires: NV_non_square_matrices] Original was GL_FLOAT_MAT4x3_NV = 0x8B6A
        FloatMat4x3Nv = 35690,
        //
        // Summary:
        //     Original was GL_DELETE_STATUS = 0x8B80
        DeleteStatus = 35712,
        //
        // Summary:
        //     Original was GL_COMPILE_STATUS = 0x8B81
        CompileStatus = 35713,
        //
        // Summary:
        //     Original was GL_LINK_STATUS = 0x8B82
        LinkStatus = 35714,
        //
        // Summary:
        //     Original was GL_VALIDATE_STATUS = 0x8B83
        ValidateStatus = 35715,
        //
        // Summary:
        //     Original was GL_INFO_LOG_LENGTH = 0x8B84
        InfoLogLength = 35716,
        //
        // Summary:
        //     Original was GL_ATTACHED_SHADERS = 0x8B85
        AttachedShaders = 35717,
        //
        // Summary:
        //     Original was GL_ACTIVE_UNIFORMS = 0x8B86
        ActiveUniforms = 35718,
        //
        // Summary:
        //     Original was GL_ACTIVE_UNIFORM_MAX_LENGTH = 0x8B87
        ActiveUniformMaxLength = 35719,
        //
        // Summary:
        //     Original was GL_SHADER_SOURCE_LENGTH = 0x8B88
        ShaderSourceLength = 35720,
        //
        // Summary:
        //     Original was GL_ACTIVE_ATTRIBUTES = 0x8B89
        ActiveAttributes = 35721,
        //
        // Summary:
        //     Original was GL_ACTIVE_ATTRIBUTE_MAX_LENGTH = 0x8B8A
        ActiveAttributeMaxLength = 35722,
        //
        // Summary:
        //     Original was GL_FRAGMENT_SHADER_DERIVATIVE_HINT = 0x8B8B
        FragmentShaderDerivativeHint = 35723,
        //
        // Summary:
        //     Original was GL_FRAGMENT_SHADER_DERIVATIVE_HINT_ARB = 0x8B8B
        FragmentShaderDerivativeHintArb = 35723,
        //
        // Summary:
        //     [requires: OES_standard_derivatives] Original was GL_FRAGMENT_SHADER_DERIVATIVE_HINT_OES
        //     = 0x8B8B
        FragmentShaderDerivativeHintOes = 35723,
        //
        // Summary:
        //     Original was GL_SHADING_LANGUAGE_VERSION = 0x8B8C
        ShadingLanguageVersion = 35724,
        //
        // Summary:
        //     Original was GL_CURRENT_PROGRAM = 0x8B8D
        CurrentProgram = 35725,
        //
        // Summary:
        //     [requires: OES_compressed_paletted_texture] Original was GL_PALETTE4_RGB8_OES
        //     = 0x8B90
        Palette4Rgb8Oes = 35728,
        //
        // Summary:
        //     [requires: OES_compressed_paletted_texture] Original was GL_PALETTE4_RGBA8_OES
        //     = 0x8B91
        Palette4Rgba8Oes = 35729,
        //
        // Summary:
        //     [requires: OES_compressed_paletted_texture] Original was GL_PALETTE4_R5_G6_B5_OES
        //     = 0x8B92
        Palette4R5G6B5Oes = 35730,
        //
        // Summary:
        //     [requires: OES_compressed_paletted_texture] Original was GL_PALETTE4_RGBA4_OES
        //     = 0x8B93
        Palette4Rgba4Oes = 35731,
        //
        // Summary:
        //     [requires: OES_compressed_paletted_texture] Original was GL_PALETTE4_RGB5_A1_OES
        //     = 0x8B94
        Palette4Rgb5A1Oes = 35732,
        //
        // Summary:
        //     [requires: OES_compressed_paletted_texture] Original was GL_PALETTE8_RGB8_OES
        //     = 0x8B95
        Palette8Rgb8Oes = 35733,
        //
        // Summary:
        //     [requires: OES_compressed_paletted_texture] Original was GL_PALETTE8_RGBA8_OES
        //     = 0x8B96
        Palette8Rgba8Oes = 35734,
        //
        // Summary:
        //     [requires: OES_compressed_paletted_texture] Original was GL_PALETTE8_R5_G6_B5_OES
        //     = 0x8B97
        Palette8R5G6B5Oes = 35735,
        //
        // Summary:
        //     [requires: OES_compressed_paletted_texture] Original was GL_PALETTE8_RGBA4_OES
        //     = 0x8B98
        Palette8Rgba4Oes = 35736,
        //
        // Summary:
        //     [requires: OES_compressed_paletted_texture] Original was GL_PALETTE8_RGB5_A1_OES
        //     = 0x8B99
        Palette8Rgb5A1Oes = 35737,
        //
        // Summary:
        //     Original was GL_IMPLEMENTATION_COLOR_READ_TYPE = 0x8B9A
        ImplementationColorReadType = 35738,
        //
        // Summary:
        //     Original was GL_IMPLEMENTATION_COLOR_READ_FORMAT = 0x8B9B
        ImplementationColorReadFormat = 35739,
        //
        // Summary:
        //     [requires: AMD_performance_monitor] Original was GL_COUNTER_TYPE_AMD = 0x8BC0
        CounterTypeAmd = 35776,
        //
        // Summary:
        //     [requires: AMD_performance_monitor] Original was GL_COUNTER_RANGE_AMD = 0x8BC1
        CounterRangeAmd = 35777,
        //
        // Summary:
        //     [requires: AMD_performance_monitor] Original was GL_UNSIGNED_INT64_AMD = 0x8BC2
        UnsignedInt64Amd = 35778,
        //
        // Summary:
        //     [requires: AMD_performance_monitor] Original was GL_PERCENTAGE_AMD = 0x8BC3
        PercentageAmd = 35779,
        //
        // Summary:
        //     [requires: AMD_performance_monitor] Original was GL_PERFMON_RESULT_AVAILABLE_AMD
        //     = 0x8BC4
        PerfmonResultAvailableAmd = 35780,
        //
        // Summary:
        //     [requires: AMD_performance_monitor] Original was GL_PERFMON_RESULT_SIZE_AMD =
        //     0x8BC5
        PerfmonResultSizeAmd = 35781,
        //
        // Summary:
        //     [requires: AMD_performance_monitor] Original was GL_PERFMON_RESULT_AMD = 0x8BC6
        PerfmonResultAmd = 35782,
        //
        // Summary:
        //     [requires: QCOM_extended_get] Original was GL_TEXTURE_WIDTH_QCOM = 0x8BD2
        TextureWidthQcom = 35794,
        //
        // Summary:
        //     [requires: QCOM_extended_get] Original was GL_TEXTURE_HEIGHT_QCOM = 0x8BD3
        TextureHeightQcom = 35795,
        //
        // Summary:
        //     [requires: QCOM_extended_get] Original was GL_TEXTURE_DEPTH_QCOM = 0x8BD4
        TextureDepthQcom = 35796,
        //
        // Summary:
        //     [requires: QCOM_extended_get] Original was GL_TEXTURE_INTERNAL_FORMAT_QCOM =
        //     0x8BD5
        TextureInternalFormatQcom = 35797,
        //
        // Summary:
        //     [requires: QCOM_extended_get] Original was GL_TEXTURE_FORMAT_QCOM = 0x8BD6
        TextureFormatQcom = 35798,
        //
        // Summary:
        //     [requires: QCOM_extended_get] Original was GL_TEXTURE_TYPE_QCOM = 0x8BD7
        TextureTypeQcom = 35799,
        //
        // Summary:
        //     [requires: QCOM_extended_get] Original was GL_TEXTURE_IMAGE_VALID_QCOM = 0x8BD8
        TextureImageValidQcom = 35800,
        //
        // Summary:
        //     [requires: QCOM_extended_get] Original was GL_TEXTURE_NUM_LEVELS_QCOM = 0x8BD9
        TextureNumLevelsQcom = 35801,
        //
        // Summary:
        //     [requires: QCOM_extended_get] Original was GL_TEXTURE_TARGET_QCOM = 0x8BDA
        TextureTargetQcom = 35802,
        //
        // Summary:
        //     [requires: QCOM_extended_get] Original was GL_TEXTURE_OBJECT_VALID_QCOM = 0x8BDB
        TextureObjectValidQcom = 35803,
        //
        // Summary:
        //     [requires: QCOM_extended_get] Original was GL_STATE_RESTORE = 0x8BDC
        StateRestore = 35804,
        //
        // Summary:
        //     [requires: EXT_YUV_target] Original was GL_SAMPLER_EXTERNAL_2D_Y2Y_EXT = 0x8BE7
        SamplerExternal2DY2yExt = 35815,
        //
        // Summary:
        //     [requires: EXT_protected_textures] Original was GL_TEXTURE_PROTECTED_EXT = 0x8BFA
        TextureProtectedExt = 35834,
        //
        // Summary:
        //     [requires: QCOM_texture_foveated] Original was GL_TEXTURE_FOVEATED_FEATURE_BITS_QCOM
        //     = 0x8BFB
        TextureFoveatedFeatureBitsQcom = 35835,
        //
        // Summary:
        //     [requires: QCOM_texture_foveated] Original was GL_TEXTURE_FOVEATED_MIN_PIXEL_DENSITY_QCOM
        //     = 0x8BFC
        TextureFoveatedMinPixelDensityQcom = 35836,
        //
        // Summary:
        //     [requires: QCOM_texture_foveated] Original was GL_TEXTURE_FOVEATED_FEATURE_QUERY_QCOM
        //     = 0x8BFD
        TextureFoveatedFeatureQueryQcom = 35837,
        //
        // Summary:
        //     [requires: QCOM_texture_foveated] Original was GL_TEXTURE_FOVEATED_NUM_FOCAL_POINTS_QUERY_QCOM
        //     = 0x8BFE
        TextureFoveatedNumFocalPointsQueryQcom = 35838,
        //
        // Summary:
        //     [requires: QCOM_texture_foveated] Original was GL_FRAMEBUFFER_INCOMPLETE_FOVEATION_QCOM
        //     = 0x8BFF
        FramebufferIncompleteFoveationQcom = 35839,
        //
        // Summary:
        //     [requires: IMG_texture_compression_pvrtc] Original was GL_COMPRESSED_RGB_PVRTC_4BPPV1_IMG
        //     = 0x8C00
        CompressedRgbPvrtc4Bppv1Img = 35840,
        //
        // Summary:
        //     [requires: IMG_texture_compression_pvrtc] Original was GL_COMPRESSED_RGB_PVRTC_2BPPV1_IMG
        //     = 0x8C01
        CompressedRgbPvrtc2Bppv1Img = 35841,
        //
        // Summary:
        //     [requires: IMG_texture_compression_pvrtc] Original was GL_COMPRESSED_RGBA_PVRTC_4BPPV1_IMG
        //     = 0x8C02
        CompressedRgbaPvrtc4Bppv1Img = 35842,
        //
        // Summary:
        //     [requires: IMG_texture_compression_pvrtc] Original was GL_COMPRESSED_RGBA_PVRTC_2BPPV1_IMG
        //     = 0x8C03
        CompressedRgbaPvrtc2Bppv1Img = 35843,
        //
        // Summary:
        //     [requires: IMG_shader_binary] Original was GL_SGX_BINARY_IMG = 0x8C0A
        SgxBinaryImg = 35850,
        //
        // Summary:
        //     Original was GL_UNSIGNED_NORMALIZED = 0x8C17
        UnsignedNormalized = 35863,
        //
        // Summary:
        //     [requires: EXT_color_buffer_half_float] Original was GL_UNSIGNED_NORMALIZED_EXT
        //     = 0x8C17
        UnsignedNormalizedExt = 35863,
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
        //     Original was GL_TEXTURE_BINDING_2D_ARRAY = 0x8C1D
        TextureBinding2DArray = 35869,
        //
        // Summary:
        //     [requires: EXT_geometry_shader] Original was GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS_EXT
        //     = 0x8C29
        MaxGeometryTextureImageUnitsExt = 35881,
        //
        // Summary:
        //     [requires: OES_geometry_shader] Original was GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS_OES
        //     = 0x8C29
        MaxGeometryTextureImageUnitsOes = 35881,
        //
        // Summary:
        //     Original was GL_TEXTURE_BUFFER = 0x8C2A
        TextureBuffer = 35882,
        //
        // Summary:
        //     [requires: EXT_texture_buffer] Original was GL_TEXTURE_BUFFER_BINDING_EXT = 0x8C2A
        TextureBufferBindingExt = 35882,
        //
        // Summary:
        //     [requires: OES_texture_buffer] Original was GL_TEXTURE_BUFFER_BINDING_OES = 0x8C2A
        TextureBufferBindingOes = 35882,
        //
        // Summary:
        //     [requires: EXT_texture_buffer] Original was GL_TEXTURE_BUFFER_EXT = 0x8C2A
        TextureBufferExt = 35882,
        //
        // Summary:
        //     [requires: OES_texture_buffer] Original was GL_TEXTURE_BUFFER_OES = 0x8C2A
        TextureBufferOes = 35882,
        //
        // Summary:
        //     [requires: EXT_texture_buffer] Original was GL_MAX_TEXTURE_BUFFER_SIZE_EXT =
        //     0x8C2B
        MaxTextureBufferSizeExt = 35883,
        //
        // Summary:
        //     [requires: OES_texture_buffer] Original was GL_MAX_TEXTURE_BUFFER_SIZE_OES =
        //     0x8C2B
        MaxTextureBufferSizeOes = 35883,
        //
        // Summary:
        //     [requires: EXT_texture_buffer] Original was GL_TEXTURE_BINDING_BUFFER_EXT = 0x8C2C
        TextureBindingBufferExt = 35884,
        //
        // Summary:
        //     [requires: OES_texture_buffer] Original was GL_TEXTURE_BINDING_BUFFER_OES = 0x8C2C
        TextureBindingBufferOes = 35884,
        //
        // Summary:
        //     [requires: EXT_texture_buffer] Original was GL_TEXTURE_BUFFER_DATA_STORE_BINDING_EXT
        //     = 0x8C2D
        TextureBufferDataStoreBindingExt = 35885,
        //
        // Summary:
        //     [requires: OES_texture_buffer] Original was GL_TEXTURE_BUFFER_DATA_STORE_BINDING_OES
        //     = 0x8C2D
        TextureBufferDataStoreBindingOes = 35885,
        //
        // Summary:
        //     Original was GL_ANY_SAMPLES_PASSED = 0x8C2F
        AnySamplesPassed = 35887,
        //
        // Summary:
        //     [requires: EXT_occlusion_query_boolean] Original was GL_ANY_SAMPLES_PASSED_EXT
        //     = 0x8C2F
        AnySamplesPassedExt = 35887,
        //
        // Summary:
        //     [requires: OES_sample_shading] Original was GL_SAMPLE_SHADING_OES = 0x8C36
        SampleShadingOes = 35894,
        //
        // Summary:
        //     [requires: OES_sample_shading] Original was GL_MIN_SAMPLE_SHADING_VALUE_OES =
        //     0x8C37
        MinSampleShadingValueOes = 35895,
        //
        // Summary:
        //     Original was GL_R11F_G11F_B10F = 0x8C3A
        R11fG11fB10f = 35898,
        //
        // Summary:
        //     [requires: APPLE_texture_packed_float] Original was GL_R11F_G11F_B10F_APPLE =
        //     0x8C3A
        R11fG11fB10fApple = 35898,
        //
        // Summary:
        //     Original was GL_R11F_G11F_B10F_EXT = 0x8C3A
        R11fG11fB10fExt = 35898,
        //
        // Summary:
        //     Original was GL_UNSIGNED_INT_10F_11F_11F_REV = 0x8C3B
        UnsignedInt10F11F11FRev = 35899,
        //
        // Summary:
        //     [requires: APPLE_texture_packed_float] Original was GL_UNSIGNED_INT_10F_11F_11F_REV_APPLE
        //     = 0x8C3B
        UnsignedInt10F11F11FRevApple = 35899,
        //
        // Summary:
        //     Original was GL_RGB9_E5 = 0x8C3D
        Rgb9E5 = 35901,
        //
        // Summary:
        //     [requires: APPLE_texture_packed_float] Original was GL_RGB9_E5_APPLE = 0x8C3D
        Rgb9E5Apple = 35901,
        //
        // Summary:
        //     Original was GL_RGB9_E5_EXT = 0x8C3D
        Rgb9E5Ext = 35901,
        //
        // Summary:
        //     Original was GL_UNSIGNED_INT_5_9_9_9_REV = 0x8C3E
        UnsignedInt5999Rev = 35902,
        //
        // Summary:
        //     [requires: APPLE_texture_packed_float] Original was GL_UNSIGNED_INT_5_9_9_9_REV_APPLE
        //     = 0x8C3E
        UnsignedInt5999RevApple = 35902,
        //
        // Summary:
        //     Original was GL_SRGB = 0x8C40
        Srgb = 35904,
        //
        // Summary:
        //     [requires: EXT_sRGB] Original was GL_SRGB_EXT = 0x8C40
        SrgbExt = 35904,
        //
        // Summary:
        //     Original was GL_SRGB8 = 0x8C41
        Srgb8 = 35905,
        //
        // Summary:
        //     Original was GL_SRGB8_EXT = 0x8C41
        Srgb8Ext = 35905,
        //
        // Summary:
        //     [requires: NV_sRGB_formats] Original was GL_SRGB8_NV = 0x8C41
        Srgb8Nv = 35905,
        //
        // Summary:
        //     Original was GL_SRGB_ALPHA = 0x8C42
        SrgbAlpha = 35906,
        //
        // Summary:
        //     [requires: EXT_sRGB] Original was GL_SRGB_ALPHA_EXT = 0x8C42
        SrgbAlphaExt = 35906,
        //
        // Summary:
        //     Original was GL_SRGB8_ALPHA8 = 0x8C43
        Srgb8Alpha8 = 35907,
        //
        // Summary:
        //     [requires: EXT_sRGB] Original was GL_SRGB8_ALPHA8_EXT = 0x8C43
        Srgb8Alpha8Ext = 35907,
        //
        // Summary:
        //     [requires: NV_sRGB_formats] Original was GL_SLUMINANCE_ALPHA_NV = 0x8C44
        SluminanceAlphaNv = 35908,
        //
        // Summary:
        //     [requires: NV_sRGB_formats] Original was GL_SLUMINANCE8_ALPHA8_NV = 0x8C45
        Sluminance8Alpha8Nv = 35909,
        //
        // Summary:
        //     [requires: NV_sRGB_formats] Original was GL_SLUMINANCE_NV = 0x8C46
        SluminanceNv = 35910,
        //
        // Summary:
        //     [requires: NV_sRGB_formats] Original was GL_SLUMINANCE8_NV = 0x8C47
        Sluminance8Nv = 35911,
        //
        // Summary:
        //     Original was GL_COMPRESSED_SRGB = 0x8C48
        CompressedSrgb = 35912,
        //
        // Summary:
        //     Original was GL_COMPRESSED_SRGB_ALPHA = 0x8C49
        CompressedSrgbAlpha = 35913,
        //
        // Summary:
        //     [requires: EXT_texture_compression_s3tc_srgb] Original was GL_COMPRESSED_SRGB_S3TC_DXT1_EXT
        //     = 0x8C4C
        CompressedSrgbS3tcDxt1Ext = 35916,
        //
        // Summary:
        //     [requires: NV_sRGB_formats] Original was GL_COMPRESSED_SRGB_S3TC_DXT1_NV = 0x8C4C
        CompressedSrgbS3tcDxt1Nv = 35916,
        //
        // Summary:
        //     [requires: EXT_texture_compression_s3tc_srgb] Original was GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT
        //     = 0x8C4D
        CompressedSrgbAlphaS3tcDxt1Ext = 35917,
        //
        // Summary:
        //     [requires: NV_sRGB_formats] Original was GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT1_NV
        //     = 0x8C4D
        CompressedSrgbAlphaS3tcDxt1Nv = 35917,
        //
        // Summary:
        //     [requires: EXT_texture_compression_s3tc_srgb] Original was GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT3_EXT
        //     = 0x8C4E
        CompressedSrgbAlphaS3tcDxt3Ext = 35918,
        //
        // Summary:
        //     [requires: NV_sRGB_formats] Original was GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT3_NV
        //     = 0x8C4E
        CompressedSrgbAlphaS3tcDxt3Nv = 35918,
        //
        // Summary:
        //     [requires: EXT_texture_compression_s3tc_srgb] Original was GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT
        //     = 0x8C4F
        CompressedSrgbAlphaS3tcDxt5Ext = 35919,
        //
        // Summary:
        //     [requires: NV_sRGB_formats] Original was GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT5_NV
        //     = 0x8C4F
        CompressedSrgbAlphaS3tcDxt5Nv = 35919,
        //
        // Summary:
        //     Original was GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH = 0x8C76
        TransformFeedbackVaryingMaxLength = 35958,
        //
        // Summary:
        //     Original was GL_TRANSFORM_FEEDBACK_BUFFER_MODE = 0x8C7F
        TransformFeedbackBufferMode = 35967,
        //
        // Summary:
        //     Original was GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS = 0x8C80
        MaxTransformFeedbackSeparateComponents = 35968,
        //
        // Summary:
        //     Original was GL_TRANSFORM_FEEDBACK_VARYINGS = 0x8C83
        TransformFeedbackVaryings = 35971,
        //
        // Summary:
        //     Original was GL_TRANSFORM_FEEDBACK_BUFFER_START = 0x8C84
        TransformFeedbackBufferStart = 35972,
        //
        // Summary:
        //     Original was GL_TRANSFORM_FEEDBACK_BUFFER_SIZE = 0x8C85
        TransformFeedbackBufferSize = 35973,
        //
        // Summary:
        //     Original was GL_PRIMITIVES_GENERATED = 0x8C87
        PrimitivesGenerated = 35975,
        //
        // Summary:
        //     [requires: EXT_geometry_shader] Original was GL_PRIMITIVES_GENERATED_EXT = 0x8C87
        PrimitivesGeneratedExt = 35975,
        //
        // Summary:
        //     [requires: OES_geometry_shader] Original was GL_PRIMITIVES_GENERATED_OES = 0x8C87
        PrimitivesGeneratedOes = 35975,
        //
        // Summary:
        //     Original was GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN = 0x8C88
        TransformFeedbackPrimitivesWritten = 35976,
        //
        // Summary:
        //     Original was GL_RASTERIZER_DISCARD = 0x8C89
        RasterizerDiscard = 35977,
        //
        // Summary:
        //     Original was GL_MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS = 0x8C8A
        MaxTransformFeedbackInterleavedComponents = 35978,
        //
        // Summary:
        //     Original was GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS = 0x8C8B
        MaxTransformFeedbackSeparateAttribs = 35979,
        //
        // Summary:
        //     Original was GL_INTERLEAVED_ATTRIBS = 0x8C8C
        InterleavedAttribs = 35980,
        //
        // Summary:
        //     Original was GL_SEPARATE_ATTRIBS = 0x8C8D
        SeparateAttribs = 35981,
        //
        // Summary:
        //     Original was GL_TRANSFORM_FEEDBACK_BUFFER = 0x8C8E
        TransformFeedbackBuffer = 35982,
        //
        // Summary:
        //     Original was GL_TRANSFORM_FEEDBACK_BUFFER_BINDING = 0x8C8F
        TransformFeedbackBufferBinding = 35983,
        //
        // Summary:
        //     [requires: AMD_compressed_ATC_texture] Original was GL_ATC_RGB_AMD = 0x8C92
        AtcRgbAmd = 35986,
        //
        // Summary:
        //     [requires: AMD_compressed_ATC_texture] Original was GL_ATC_RGBA_EXPLICIT_ALPHA_AMD
        //     = 0x8C93
        AtcRgbaExplicitAlphaAmd = 35987,
        //
        // Summary:
        //     Original was GL_LOWER_LEFT = 0x8CA1
        LowerLeft = 36001,
        //
        // Summary:
        //     [requires: EXT_clip_control] Original was GL_LOWER_LEFT_EXT = 0x8CA1
        LowerLeftExt = 36001,
        //
        // Summary:
        //     Original was GL_UPPER_LEFT = 0x8CA2
        UpperLeft = 36002,
        //
        // Summary:
        //     [requires: EXT_clip_control] Original was GL_UPPER_LEFT_EXT = 0x8CA2
        UpperLeftExt = 36002,
        //
        // Summary:
        //     Original was GL_STENCIL_BACK_REF = 0x8CA3
        StencilBackRef = 36003,
        //
        // Summary:
        //     Original was GL_STENCIL_BACK_VALUE_MASK = 0x8CA4
        StencilBackValueMask = 36004,
        //
        // Summary:
        //     Original was GL_STENCIL_BACK_WRITEMASK = 0x8CA5
        StencilBackWritemask = 36005,
        //
        // Summary:
        //     Original was GL_DRAW_FRAMEBUFFER_BINDING = 0x8CA6
        DrawFramebufferBinding = 36006,
        //
        // Summary:
        //     [requires: ANGLE_framebuffer_blit] Original was GL_DRAW_FRAMEBUFFER_BINDING_ANGLE
        //     = 0x8CA6
        DrawFramebufferBindingAngle = 36006,
        //
        // Summary:
        //     [requires: APPLE_framebuffer_multisample] Original was GL_DRAW_FRAMEBUFFER_BINDING_APPLE
        //     = 0x8CA6
        DrawFramebufferBindingApple = 36006,
        //
        // Summary:
        //     [requires: NV_framebuffer_blit] Original was GL_DRAW_FRAMEBUFFER_BINDING_NV =
        //     0x8CA6
        DrawFramebufferBindingNv = 36006,
        //
        // Summary:
        //     Original was GL_FRAMEBUFFER_BINDING = 0x8CA6
        FramebufferBinding = 36006,
        //
        // Summary:
        //     Original was GL_RENDERBUFFER_BINDING = 0x8CA7
        RenderbufferBinding = 36007,
        //
        // Summary:
        //     Original was GL_READ_FRAMEBUFFER = 0x8CA8
        ReadFramebuffer = 36008,
        //
        // Summary:
        //     [requires: ANGLE_framebuffer_blit] Original was GL_READ_FRAMEBUFFER_ANGLE = 0x8CA8
        ReadFramebufferAngle = 36008,
        //
        // Summary:
        //     [requires: APPLE_framebuffer_multisample] Original was GL_READ_FRAMEBUFFER_APPLE
        //     = 0x8CA8
        ReadFramebufferApple = 36008,
        //
        // Summary:
        //     [requires: NV_framebuffer_blit] Original was GL_READ_FRAMEBUFFER_NV = 0x8CA8
        ReadFramebufferNv = 36008,
        //
        // Summary:
        //     Original was GL_DRAW_FRAMEBUFFER = 0x8CA9
        DrawFramebuffer = 36009,
        //
        // Summary:
        //     [requires: ANGLE_framebuffer_blit] Original was GL_DRAW_FRAMEBUFFER_ANGLE = 0x8CA9
        DrawFramebufferAngle = 36009,
        //
        // Summary:
        //     [requires: APPLE_framebuffer_multisample] Original was GL_DRAW_FRAMEBUFFER_APPLE
        //     = 0x8CA9
        DrawFramebufferApple = 36009,
        //
        // Summary:
        //     [requires: NV_framebuffer_blit] Original was GL_DRAW_FRAMEBUFFER_NV = 0x8CA9
        DrawFramebufferNv = 36009,
        //
        // Summary:
        //     Original was GL_READ_FRAMEBUFFER_BINDING = 0x8CAA
        ReadFramebufferBinding = 36010,
        //
        // Summary:
        //     [requires: ANGLE_framebuffer_blit] Original was GL_READ_FRAMEBUFFER_BINDING_ANGLE
        //     = 0x8CAA
        ReadFramebufferBindingAngle = 36010,
        //
        // Summary:
        //     [requires: APPLE_framebuffer_multisample] Original was GL_READ_FRAMEBUFFER_BINDING_APPLE
        //     = 0x8CAA
        ReadFramebufferBindingApple = 36010,
        //
        // Summary:
        //     [requires: NV_framebuffer_blit] Original was GL_READ_FRAMEBUFFER_BINDING_NV =
        //     0x8CAA
        ReadFramebufferBindingNv = 36010,
        //
        // Summary:
        //     Original was GL_RENDERBUFFER_SAMPLES = 0x8CAB
        RenderbufferSamples = 36011,
        //
        // Summary:
        //     [requires: ANGLE_framebuffer_multisample] Original was GL_RENDERBUFFER_SAMPLES_ANGLE
        //     = 0x8CAB
        RenderbufferSamplesAngle = 36011,
        //
        // Summary:
        //     [requires: APPLE_framebuffer_multisample] Original was GL_RENDERBUFFER_SAMPLES_APPLE
        //     = 0x8CAB
        RenderbufferSamplesApple = 36011,
        //
        // Summary:
        //     [requires: EXT_multisampled_render_to_texture] Original was GL_RENDERBUFFER_SAMPLES_EXT
        //     = 0x8CAB
        RenderbufferSamplesExt = 36011,
        //
        // Summary:
        //     [requires: NV_framebuffer_multisample] Original was GL_RENDERBUFFER_SAMPLES_NV
        //     = 0x8CAB
        RenderbufferSamplesNv = 36011,
        //
        // Summary:
        //     Original was GL_DEPTH_COMPONENT32F = 0x8CAC
        DepthComponent32f = 36012,
        //
        // Summary:
        //     Original was GL_DEPTH32F_STENCIL8 = 0x8CAD
        Depth32fStencil8 = 36013,
        //
        // Summary:
        //     Original was GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE = 0x8CD0
        FramebufferAttachmentObjectType = 36048,
        //
        // Summary:
        //     Original was GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME = 0x8CD1
        FramebufferAttachmentObjectName = 36049,
        //
        // Summary:
        //     Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL = 0x8CD2
        FramebufferAttachmentTextureLevel = 36050,
        //
        // Summary:
        //     Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE = 0x8CD3
        FramebufferAttachmentTextureCubeMapFace = 36051,
        //
        // Summary:
        //     [requires: OES_texture_3D] Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_3D_ZOFFSET_OES
        //     = 0x8CD4
        FramebufferAttachmentTexture3DZoffsetOes = 36052,
        //
        // Summary:
        //     Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER = 0x8CD4
        FramebufferAttachmentTextureLayer = 36052,
        //
        // Summary:
        //     Original was GL_FRAMEBUFFER_COMPLETE = 0x8CD5
        FramebufferComplete = 36053,
        //
        // Summary:
        //     Original was GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT = 0x8CD6
        FramebufferIncompleteAttachment = 36054,
        //
        // Summary:
        //     Original was GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT = 0x8CD7
        FramebufferIncompleteMissingAttachment = 36055,
        //
        // Summary:
        //     Original was GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS = 0x8CD9
        FramebufferIncompleteDimensions = 36057,
        //
        // Summary:
        //     Original was GL_FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER = 0x8CDB
        FramebufferIncompleteDrawBuffer = 36059,
        //
        // Summary:
        //     Original was GL_FRAMEBUFFER_INCOMPLETE_READ_BUFFER = 0x8CDC
        FramebufferIncompleteReadBuffer = 36060,
        //
        // Summary:
        //     Original was GL_FRAMEBUFFER_UNSUPPORTED = 0x8CDD
        FramebufferUnsupported = 36061,
        //
        // Summary:
        //     Original was GL_MAX_COLOR_ATTACHMENTS = 0x8CDF
        MaxColorAttachments = 36063,
        //
        // Summary:
        //     [requires: EXT_draw_buffers] Original was GL_MAX_COLOR_ATTACHMENTS_EXT = 0x8CDF
        MaxColorAttachmentsExt = 36063,
        //
        // Summary:
        //     [requires: NV_fbo_color_attachments] Original was GL_MAX_COLOR_ATTACHMENTS_NV
        //     = 0x8CDF
        MaxColorAttachmentsNv = 36063,
        //
        // Summary:
        //     Original was GL_COLOR_ATTACHMENT0 = 0x8CE0
        ColorAttachment0 = 36064,
        //
        // Summary:
        //     [requires: EXT_draw_buffers] Original was GL_COLOR_ATTACHMENT0_EXT = 0x8CE0
        ColorAttachment0Ext = 36064,
        //
        // Summary:
        //     [requires: NV_draw_buffers, or NV_fbo_color_attachments] Original was GL_COLOR_ATTACHMENT0_NV
        //     = 0x8CE0
        ColorAttachment0Nv = 36064,
        //
        // Summary:
        //     Original was GL_COLOR_ATTACHMENT0_OES = 0x8CE0
        ColorAttachment0Oes = 36064,
        //
        // Summary:
        //     Original was GL_COLOR_ATTACHMENT1 = 0x8CE1
        ColorAttachment1 = 36065,
        //
        // Summary:
        //     [requires: EXT_draw_buffers] Original was GL_COLOR_ATTACHMENT1_EXT = 0x8CE1
        ColorAttachment1Ext = 36065,
        //
        // Summary:
        //     [requires: NV_draw_buffers, or NV_fbo_color_attachments] Original was GL_COLOR_ATTACHMENT1_NV
        //     = 0x8CE1
        ColorAttachment1Nv = 36065,
        //
        // Summary:
        //     Original was GL_COLOR_ATTACHMENT2 = 0x8CE2
        ColorAttachment2 = 36066,
        //
        // Summary:
        //     [requires: EXT_draw_buffers] Original was GL_COLOR_ATTACHMENT2_EXT = 0x8CE2
        ColorAttachment2Ext = 36066,
        //
        // Summary:
        //     [requires: NV_draw_buffers, or NV_fbo_color_attachments] Original was GL_COLOR_ATTACHMENT2_NV
        //     = 0x8CE2
        ColorAttachment2Nv = 36066,
        //
        // Summary:
        //     Original was GL_COLOR_ATTACHMENT3 = 0x8CE3
        ColorAttachment3 = 36067,
        //
        // Summary:
        //     [requires: EXT_draw_buffers] Original was GL_COLOR_ATTACHMENT3_EXT = 0x8CE3
        ColorAttachment3Ext = 36067,
        //
        // Summary:
        //     [requires: NV_draw_buffers, or NV_fbo_color_attachments] Original was GL_COLOR_ATTACHMENT3_NV
        //     = 0x8CE3
        ColorAttachment3Nv = 36067,
        //
        // Summary:
        //     Original was GL_COLOR_ATTACHMENT4 = 0x8CE4
        ColorAttachment4 = 36068,
        //
        // Summary:
        //     [requires: EXT_draw_buffers] Original was GL_COLOR_ATTACHMENT4_EXT = 0x8CE4
        ColorAttachment4Ext = 36068,
        //
        // Summary:
        //     [requires: NV_draw_buffers, or NV_fbo_color_attachments] Original was GL_COLOR_ATTACHMENT4_NV
        //     = 0x8CE4
        ColorAttachment4Nv = 36068,
        //
        // Summary:
        //     Original was GL_COLOR_ATTACHMENT5 = 0x8CE5
        ColorAttachment5 = 36069,
        //
        // Summary:
        //     [requires: EXT_draw_buffers] Original was GL_COLOR_ATTACHMENT5_EXT = 0x8CE5
        ColorAttachment5Ext = 36069,
        //
        // Summary:
        //     [requires: NV_draw_buffers, or NV_fbo_color_attachments] Original was GL_COLOR_ATTACHMENT5_NV
        //     = 0x8CE5
        ColorAttachment5Nv = 36069,
        //
        // Summary:
        //     Original was GL_COLOR_ATTACHMENT6 = 0x8CE6
        ColorAttachment6 = 36070,
        //
        // Summary:
        //     [requires: EXT_draw_buffers] Original was GL_COLOR_ATTACHMENT6_EXT = 0x8CE6
        ColorAttachment6Ext = 36070,
        //
        // Summary:
        //     [requires: NV_draw_buffers, or NV_fbo_color_attachments] Original was GL_COLOR_ATTACHMENT6_NV
        //     = 0x8CE6
        ColorAttachment6Nv = 36070,
        //
        // Summary:
        //     Original was GL_COLOR_ATTACHMENT7 = 0x8CE7
        ColorAttachment7 = 36071,
        //
        // Summary:
        //     [requires: EXT_draw_buffers] Original was GL_COLOR_ATTACHMENT7_EXT = 0x8CE7
        ColorAttachment7Ext = 36071,
        //
        // Summary:
        //     [requires: NV_draw_buffers, or NV_fbo_color_attachments] Original was GL_COLOR_ATTACHMENT7_NV
        //     = 0x8CE7
        ColorAttachment7Nv = 36071,
        //
        // Summary:
        //     Original was GL_COLOR_ATTACHMENT8 = 0x8CE8
        ColorAttachment8 = 36072,
        //
        // Summary:
        //     [requires: EXT_draw_buffers] Original was GL_COLOR_ATTACHMENT8_EXT = 0x8CE8
        ColorAttachment8Ext = 36072,
        //
        // Summary:
        //     [requires: NV_draw_buffers, or NV_fbo_color_attachments] Original was GL_COLOR_ATTACHMENT8_NV
        //     = 0x8CE8
        ColorAttachment8Nv = 36072,
        //
        // Summary:
        //     Original was GL_COLOR_ATTACHMENT9 = 0x8CE9
        ColorAttachment9 = 36073,
        //
        // Summary:
        //     [requires: EXT_draw_buffers] Original was GL_COLOR_ATTACHMENT9_EXT = 0x8CE9
        ColorAttachment9Ext = 36073,
        //
        // Summary:
        //     [requires: NV_draw_buffers, or NV_fbo_color_attachments] Original was GL_COLOR_ATTACHMENT9_NV
        //     = 0x8CE9
        ColorAttachment9Nv = 36073,
        //
        // Summary:
        //     Original was GL_COLOR_ATTACHMENT10 = 0x8CEA
        ColorAttachment10 = 36074,
        //
        // Summary:
        //     [requires: EXT_draw_buffers] Original was GL_COLOR_ATTACHMENT10_EXT = 0x8CEA
        ColorAttachment10Ext = 36074,
        //
        // Summary:
        //     [requires: NV_draw_buffers, or NV_fbo_color_attachments] Original was GL_COLOR_ATTACHMENT10_NV
        //     = 0x8CEA
        ColorAttachment10Nv = 36074,
        //
        // Summary:
        //     Original was GL_COLOR_ATTACHMENT11 = 0x8CEB
        ColorAttachment11 = 36075,
        //
        // Summary:
        //     [requires: EXT_draw_buffers] Original was GL_COLOR_ATTACHMENT11_EXT = 0x8CEB
        ColorAttachment11Ext = 36075,
        //
        // Summary:
        //     [requires: NV_draw_buffers, or NV_fbo_color_attachments] Original was GL_COLOR_ATTACHMENT11_NV
        //     = 0x8CEB
        ColorAttachment11Nv = 36075,
        //
        // Summary:
        //     Original was GL_COLOR_ATTACHMENT12 = 0x8CEC
        ColorAttachment12 = 36076,
        //
        // Summary:
        //     [requires: EXT_draw_buffers] Original was GL_COLOR_ATTACHMENT12_EXT = 0x8CEC
        ColorAttachment12Ext = 36076,
        //
        // Summary:
        //     [requires: NV_draw_buffers, or NV_fbo_color_attachments] Original was GL_COLOR_ATTACHMENT12_NV
        //     = 0x8CEC
        ColorAttachment12Nv = 36076,
        //
        // Summary:
        //     Original was GL_COLOR_ATTACHMENT13 = 0x8CED
        ColorAttachment13 = 36077,
        //
        // Summary:
        //     [requires: EXT_draw_buffers] Original was GL_COLOR_ATTACHMENT13_EXT = 0x8CED
        ColorAttachment13Ext = 36077,
        //
        // Summary:
        //     [requires: NV_draw_buffers, or NV_fbo_color_attachments] Original was GL_COLOR_ATTACHMENT13_NV
        //     = 0x8CED
        ColorAttachment13Nv = 36077,
        //
        // Summary:
        //     Original was GL_COLOR_ATTACHMENT14 = 0x8CEE
        ColorAttachment14 = 36078,
        //
        // Summary:
        //     [requires: EXT_draw_buffers] Original was GL_COLOR_ATTACHMENT14_EXT = 0x8CEE
        ColorAttachment14Ext = 36078,
        //
        // Summary:
        //     [requires: NV_draw_buffers, or NV_fbo_color_attachments] Original was GL_COLOR_ATTACHMENT14_NV
        //     = 0x8CEE
        ColorAttachment14Nv = 36078,
        //
        // Summary:
        //     Original was GL_COLOR_ATTACHMENT15 = 0x8CEF
        ColorAttachment15 = 36079,
        //
        // Summary:
        //     [requires: EXT_draw_buffers] Original was GL_COLOR_ATTACHMENT15_EXT = 0x8CEF
        ColorAttachment15Ext = 36079,
        //
        // Summary:
        //     [requires: NV_draw_buffers, or NV_fbo_color_attachments] Original was GL_COLOR_ATTACHMENT15_NV
        //     = 0x8CEF
        ColorAttachment15Nv = 36079,
        //
        // Summary:
        //     Original was GL_COLOR_ATTACHMENT16 = 0x8CF0
        ColorAttachment16 = 36080,
        //
        // Summary:
        //     Original was GL_COLOR_ATTACHMENT17 = 0x8CF1
        ColorAttachment17 = 36081,
        //
        // Summary:
        //     Original was GL_COLOR_ATTACHMENT18 = 0x8CF2
        ColorAttachment18 = 36082,
        //
        // Summary:
        //     Original was GL_COLOR_ATTACHMENT19 = 0x8CF3
        ColorAttachment19 = 36083,
        //
        // Summary:
        //     Original was GL_COLOR_ATTACHMENT20 = 0x8CF4
        ColorAttachment20 = 36084,
        //
        // Summary:
        //     Original was GL_COLOR_ATTACHMENT21 = 0x8CF5
        ColorAttachment21 = 36085,
        //
        // Summary:
        //     Original was GL_COLOR_ATTACHMENT22 = 0x8CF6
        ColorAttachment22 = 36086,
        //
        // Summary:
        //     Original was GL_COLOR_ATTACHMENT23 = 0x8CF7
        ColorAttachment23 = 36087,
        //
        // Summary:
        //     Original was GL_COLOR_ATTACHMENT24 = 0x8CF8
        ColorAttachment24 = 36088,
        //
        // Summary:
        //     Original was GL_COLOR_ATTACHMENT25 = 0x8CF9
        ColorAttachment25 = 36089,
        //
        // Summary:
        //     Original was GL_COLOR_ATTACHMENT26 = 0x8CFA
        ColorAttachment26 = 36090,
        //
        // Summary:
        //     Original was GL_COLOR_ATTACHMENT27 = 0x8CFB
        ColorAttachment27 = 36091,
        //
        // Summary:
        //     Original was GL_COLOR_ATTACHMENT28 = 0x8CFC
        ColorAttachment28 = 36092,
        //
        // Summary:
        //     Original was GL_COLOR_ATTACHMENT29 = 0x8CFD
        ColorAttachment29 = 36093,
        //
        // Summary:
        //     Original was GL_COLOR_ATTACHMENT30 = 0x8CFE
        ColorAttachment30 = 36094,
        //
        // Summary:
        //     Original was GL_COLOR_ATTACHMENT31 = 0x8CFF
        ColorAttachment31 = 36095,
        //
        // Summary:
        //     Original was GL_DEPTH_ATTACHMENT = 0x8D00
        DepthAttachment = 36096,
        //
        // Summary:
        //     Original was GL_DEPTH_ATTACHMENT_EXT = 0x8D00
        DepthAttachmentExt = 36096,
        //
        // Summary:
        //     Original was GL_DEPTH_ATTACHMENT_OES = 0x8D00
        DepthAttachmentOes = 36096,
        //
        // Summary:
        //     Original was GL_STENCIL_ATTACHMENT = 0x8D20
        StencilAttachment = 36128,
        //
        // Summary:
        //     Original was GL_Framebuffer = 0X8d40
        Framebuffer = 36160,
        //
        // Summary:
        //     Original was GL_Renderbuffer = 0X8d41
        Renderbuffer = 36161,
        //
        // Summary:
        //     Original was GL_RENDERBUFFER_WIDTH = 0x8D42
        RenderbufferWidth = 36162,
        //
        // Summary:
        //     Original was GL_RENDERBUFFER_HEIGHT = 0x8D43
        RenderbufferHeight = 36163,
        //
        // Summary:
        //     Original was GL_RENDERBUFFER_INTERNAL_FORMAT = 0x8D44
        RenderbufferInternalFormat = 36164,
        //
        // Summary:
        //     [requires: OES_stencil1] Original was GL_STENCIL_INDEX1_OES = 0x8D46
        StencilIndex1Oes = 36166,
        //
        // Summary:
        //     [requires: OES_stencil4] Original was GL_STENCIL_INDEX4_OES = 0x8D47
        StencilIndex4Oes = 36167,
        //
        // Summary:
        //     Original was GL_STENCIL_INDEX8 = 0x8D48
        StencilIndex8 = 36168,
        //
        // Summary:
        //     [requires: OES_texture_stencil8] Original was GL_STENCIL_INDEX8_OES = 0x8D48
        StencilIndex8Oes = 36168,
        //
        // Summary:
        //     Original was GL_RENDERBUFFER_RED_SIZE = 0x8D50
        RenderbufferRedSize = 36176,
        //
        // Summary:
        //     Original was GL_RENDERBUFFER_GREEN_SIZE = 0x8D51
        RenderbufferGreenSize = 36177,
        //
        // Summary:
        //     Original was GL_RENDERBUFFER_BLUE_SIZE = 0x8D52
        RenderbufferBlueSize = 36178,
        //
        // Summary:
        //     Original was GL_RENDERBUFFER_ALPHA_SIZE = 0x8D53
        RenderbufferAlphaSize = 36179,
        //
        // Summary:
        //     Original was GL_RENDERBUFFER_DEPTH_SIZE = 0x8D54
        RenderbufferDepthSize = 36180,
        //
        // Summary:
        //     Original was GL_RENDERBUFFER_STENCIL_SIZE = 0x8D55
        RenderbufferStencilSize = 36181,
        //
        // Summary:
        //     Original was GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE = 0x8D56
        FramebufferIncompleteMultisample = 36182,
        //
        // Summary:
        //     [requires: ANGLE_framebuffer_multisample] Original was GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_ANGLE
        //     = 0x8D56
        FramebufferIncompleteMultisampleAngle = 36182,
        //
        // Summary:
        //     [requires: APPLE_framebuffer_multisample] Original was GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_APPLE
        //     = 0x8D56
        FramebufferIncompleteMultisampleApple = 36182,
        //
        // Summary:
        //     [requires: EXT_multisampled_render_to_texture] Original was GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_EXT
        //     = 0x8D56
        FramebufferIncompleteMultisampleExt = 36182,
        //
        // Summary:
        //     [requires: NV_framebuffer_multisample] Original was GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_NV
        //     = 0x8D56
        FramebufferIncompleteMultisampleNv = 36182,
        //
        // Summary:
        //     Original was GL_MAX_SAMPLES = 0x8D57
        MaxSamples = 36183,
        //
        // Summary:
        //     [requires: ANGLE_framebuffer_multisample] Original was GL_MAX_SAMPLES_ANGLE =
        //     0x8D57
        MaxSamplesAngle = 36183,
        //
        // Summary:
        //     [requires: APPLE_framebuffer_multisample] Original was GL_MAX_SAMPLES_APPLE =
        //     0x8D57
        MaxSamplesApple = 36183,
        //
        // Summary:
        //     [requires: EXT_multisampled_render_to_texture] Original was GL_MAX_SAMPLES_EXT
        //     = 0x8D57
        MaxSamplesExt = 36183,
        //
        // Summary:
        //     [requires: NV_framebuffer_multisample] Original was GL_MAX_SAMPLES_NV = 0x8D57
        MaxSamplesNv = 36183,
        //
        // Summary:
        //     [requires: OES_texture_half_float, or OES_vertex_half_float] Original was GL_HALF_FLOAT_OES
        //     = 0x8D61
        HalfFloatOes = 36193,
        //
        // Summary:
        //     [requires: OES_required_internalformat] Original was GL_RGB565_OES = 0x8D62
        Rgb565Oes = 36194,
        //
        // Summary:
        //     Original was GL_Rgb565 = 0X8d62
        Rgb565 = 36194,
        //
        // Summary:
        //     [requires: OES_compressed_ETC1_RGB8_texture] Original was GL_ETC1_RGB8_OES =
        //     0x8D64
        Etc1Rgb8Oes = 36196,
        //
        // Summary:
        //     [requires: EXT_YUV_target, or OES_EGL_image_external] Original was GL_TEXTURE_EXTERNAL_OES
        //     = 0x8D65
        TextureExternalOes = 36197,
        //
        // Summary:
        //     [requires: OES_EGL_image_external] Original was GL_SAMPLER_EXTERNAL_OES = 0x8D66
        SamplerExternalOes = 36198,
        //
        // Summary:
        //     [requires: EXT_YUV_target, or OES_EGL_image_external] Original was GL_TEXTURE_BINDING_EXTERNAL_OES
        //     = 0x8D67
        TextureBindingExternalOes = 36199,
        //
        // Summary:
        //     [requires: EXT_YUV_target, or OES_EGL_image_external] Original was GL_REQUIRED_TEXTURE_IMAGE_UNITS_OES
        //     = 0x8D68
        RequiredTextureImageUnitsOes = 36200,
        //
        // Summary:
        //     Original was GL_PRIMITIVE_RESTART_FIXED_INDEX = 0x8D69
        PrimitiveRestartFixedIndex = 36201,
        //
        // Summary:
        //     Original was GL_ANY_SAMPLES_PASSED_CONSERVATIVE = 0x8D6A
        AnySamplesPassedConservative = 36202,
        //
        // Summary:
        //     [requires: EXT_occlusion_query_boolean] Original was GL_ANY_SAMPLES_PASSED_CONSERVATIVE_EXT
        //     = 0x8D6A
        AnySamplesPassedConservativeExt = 36202,
        //
        // Summary:
        //     Original was GL_MAX_ELEMENT_INDEX = 0x8D6B
        MaxElementIndex = 36203,
        //
        // Summary:
        //     [requires: EXT_multisampled_render_to_texture] Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_SAMPLES_EXT
        //     = 0x8D6C
        FramebufferAttachmentTextureSamplesExt = 36204,
        //
        // Summary:
        //     Original was GL_RGBA32UI = 0x8D70
        Rgba32ui = 36208,
        //
        // Summary:
        //     Original was GL_RGB32UI = 0x8D71
        Rgb32ui = 36209,
        //
        // Summary:
        //     Original was GL_RGBA16UI = 0x8D76
        Rgba16ui = 36214,
        //
        // Summary:
        //     Original was GL_RGB16UI = 0x8D77
        Rgb16ui = 36215,
        //
        // Summary:
        //     Original was GL_RGBA8UI = 0x8D7C
        Rgba8ui = 36220,
        //
        // Summary:
        //     Original was GL_RGB8UI = 0x8D7D
        Rgb8ui = 36221,
        //
        // Summary:
        //     Original was GL_RGBA32I = 0x8D82
        Rgba32i = 36226,
        //
        // Summary:
        //     Original was GL_RGB32I = 0x8D83
        Rgb32i = 36227,
        //
        // Summary:
        //     Original was GL_RGBA16I = 0x8D88
        Rgba16i = 36232,
        //
        // Summary:
        //     Original was GL_RGB16I = 0x8D89
        Rgb16i = 36233,
        //
        // Summary:
        //     Original was GL_RGBA8I = 0x8D8E
        Rgba8i = 36238,
        //
        // Summary:
        //     Original was GL_RGB8I = 0x8D8F
        Rgb8i = 36239,
        //
        // Summary:
        //     Original was GL_RED_INTEGER = 0x8D94
        RedInteger = 36244,
        //
        // Summary:
        //     Original was GL_RGB_INTEGER = 0x8D98
        RgbInteger = 36248,
        //
        // Summary:
        //     Original was GL_RGBA_INTEGER = 0x8D99
        RgbaInteger = 36249,
        //
        // Summary:
        //     Original was GL_INT_2_10_10_10_REV = 0x8D9F
        Int2101010Rev = 36255,
        //
        // Summary:
        //     Original was GL_FRAMEBUFFER_ATTACHMENT_LAYERED = 0x8DA7
        FramebufferAttachmentLayered = 36263,
        //
        // Summary:
        //     [requires: EXT_geometry_shader] Original was GL_FRAMEBUFFER_ATTACHMENT_LAYERED_EXT
        //     = 0x8DA7
        FramebufferAttachmentLayeredExt = 36263,
        //
        // Summary:
        //     [requires: OES_geometry_shader] Original was GL_FRAMEBUFFER_ATTACHMENT_LAYERED_OES
        //     = 0x8DA7
        FramebufferAttachmentLayeredOes = 36263,
        //
        // Summary:
        //     Original was GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS = 0x8DA8
        FramebufferIncompleteLayerTargets = 36264,
        //
        // Summary:
        //     [requires: EXT_geometry_shader] Original was GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS_EXT
        //     = 0x8DA8
        FramebufferIncompleteLayerTargetsExt = 36264,
        //
        // Summary:
        //     [requires: OES_geometry_shader] Original was GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS_OES
        //     = 0x8DA8
        FramebufferIncompleteLayerTargetsOes = 36264,
        //
        // Summary:
        //     Original was GL_DEPTH_COMPONENT32F_NV = 0x8DAB
        DepthComponent32fNv = 36267,
        //
        // Summary:
        //     Original was GL_DEPTH32F_STENCIL8_NV = 0x8DAC
        Depth32fStencil8Nv = 36268,
        //
        // Summary:
        //     Original was GL_FLOAT_32_UNSIGNED_INT_24_8_REV = 0x8DAD
        Float32UnsignedInt248Rev = 36269,
        //
        // Summary:
        //     [requires: EXT_sRGB_write_control] Original was GL_FRAMEBUFFER_SRGB_EXT = 0x8DB9
        FramebufferSrgbExt = 36281,
        //
        // Summary:
        //     Original was GL_COMPRESSED_RED_RGTC1 = 0x8DBB
        CompressedRedRgtc1 = 36283,
        //
        // Summary:
        //     [requires: EXT_texture_compression_rgtc] Original was GL_COMPRESSED_RED_RGTC1_EXT
        //     = 0x8DBB
        CompressedRedRgtc1Ext = 36283,
        //
        // Summary:
        //     Original was GL_COMPRESSED_SIGNED_RED_RGTC1 = 0x8DBC
        CompressedSignedRedRgtc1 = 36284,
        //
        // Summary:
        //     [requires: EXT_texture_compression_rgtc] Original was GL_COMPRESSED_SIGNED_RED_RGTC1_EXT
        //     = 0x8DBC
        CompressedSignedRedRgtc1Ext = 36284,
        //
        // Summary:
        //     [requires: EXT_texture_compression_rgtc] Original was GL_COMPRESSED_RED_GREEN_RGTC2_EXT
        //     = 0x8DBD
        CompressedRedGreenRgtc2Ext = 36285,
        //
        // Summary:
        //     Original was GL_COMPRESSED_RG_RGTC2 = 0x8DBD
        CompressedRgRgtc2 = 36285,
        //
        // Summary:
        //     [requires: EXT_texture_compression_rgtc] Original was GL_COMPRESSED_SIGNED_RED_GREEN_RGTC2_EXT
        //     = 0x8DBE
        CompressedSignedRedGreenRgtc2Ext = 36286,
        //
        // Summary:
        //     Original was GL_COMPRESSED_SIGNED_RG_RGTC2 = 0x8DBE
        CompressedSignedRgRgtc2 = 36286,
        //
        // Summary:
        //     Original was GL_SAMPLER_2D_ARRAY = 0x8DC1
        Sampler2DArray = 36289,
        //
        // Summary:
        //     [requires: EXT_texture_buffer] Original was GL_SAMPLER_BUFFER_EXT = 0x8DC2
        SamplerBufferExt = 36290,
        //
        // Summary:
        //     [requires: OES_texture_buffer] Original was GL_SAMPLER_BUFFER_OES = 0x8DC2
        SamplerBufferOes = 36290,
        //
        // Summary:
        //     Original was GL_SAMPLER_2D_ARRAY_SHADOW = 0x8DC4
        Sampler2DArrayShadow = 36292,
        //
        // Summary:
        //     [requires: NV_shadow_samplers_array] Original was GL_SAMPLER_2D_ARRAY_SHADOW_NV
        //     = 0x8DC4
        Sampler2DArrayShadowNv = 36292,
        //
        // Summary:
        //     Original was GL_SAMPLER_CUBE_SHADOW = 0x8DC5
        SamplerCubeShadow = 36293,
        //
        // Summary:
        //     [requires: NV_shadow_samplers_cube] Original was GL_SAMPLER_CUBE_SHADOW_NV =
        //     0x8DC5
        SamplerCubeShadowNv = 36293,
        //
        // Summary:
        //     Original was GL_UNSIGNED_INT_VEC2 = 0x8DC6
        UnsignedIntVec2 = 36294,
        //
        // Summary:
        //     Original was GL_UNSIGNED_INT_VEC3 = 0x8DC7
        UnsignedIntVec3 = 36295,
        //
        // Summary:
        //     Original was GL_UNSIGNED_INT_VEC4 = 0x8DC8
        UnsignedIntVec4 = 36296,
        //
        // Summary:
        //     Original was GL_INT_SAMPLER_2D = 0x8DCA
        IntSampler2D = 36298,
        //
        // Summary:
        //     Original was GL_INT_SAMPLER_3D = 0x8DCB
        IntSampler3D = 36299,
        //
        // Summary:
        //     Original was GL_INT_SAMPLER_CUBE = 0x8DCC
        IntSamplerCube = 36300,
        //
        // Summary:
        //     Original was GL_INT_SAMPLER_2D_ARRAY = 0x8DCF
        IntSampler2DArray = 36303,
        //
        // Summary:
        //     [requires: EXT_texture_buffer] Original was GL_INT_SAMPLER_BUFFER_EXT = 0x8DD0
        IntSamplerBufferExt = 36304,
        //
        // Summary:
        //     [requires: OES_texture_buffer] Original was GL_INT_SAMPLER_BUFFER_OES = 0x8DD0
        IntSamplerBufferOes = 36304,
        //
        // Summary:
        //     Original was GL_UNSIGNED_INT_SAMPLER_2D = 0x8DD2
        UnsignedIntSampler2D = 36306,
        //
        // Summary:
        //     Original was GL_UNSIGNED_INT_SAMPLER_3D = 0x8DD3
        UnsignedIntSampler3D = 36307,
        //
        // Summary:
        //     Original was GL_UNSIGNED_INT_SAMPLER_CUBE = 0x8DD4
        UnsignedIntSamplerCube = 36308,
        //
        // Summary:
        //     Original was GL_UNSIGNED_INT_SAMPLER_2D_ARRAY = 0x8DD7
        UnsignedIntSampler2DArray = 36311,
        //
        // Summary:
        //     [requires: EXT_texture_buffer] Original was GL_UNSIGNED_INT_SAMPLER_BUFFER_EXT
        //     = 0x8DD8
        UnsignedIntSamplerBufferExt = 36312,
        //
        // Summary:
        //     [requires: OES_texture_buffer] Original was GL_UNSIGNED_INT_SAMPLER_BUFFER_OES
        //     = 0x8DD8
        UnsignedIntSamplerBufferOes = 36312,
        //
        // Summary:
        //     Original was GL_GEOMETRY_SHADER = 0x8DD9
        GeometryShader = 36313,
        //
        // Summary:
        //     [requires: EXT_geometry_shader] Original was GL_GEOMETRY_SHADER_EXT = 0x8DD9
        GeometryShaderExt = 36313,
        //
        // Summary:
        //     [requires: OES_geometry_shader] Original was GL_GEOMETRY_SHADER_OES = 0x8DD9
        GeometryShaderOes = 36313,
        //
        // Summary:
        //     [requires: EXT_geometry_shader] Original was GL_MAX_GEOMETRY_UNIFORM_COMPONENTS_EXT
        //     = 0x8DDF
        MaxGeometryUniformComponentsExt = 36319,
        //
        // Summary:
        //     [requires: OES_geometry_shader] Original was GL_MAX_GEOMETRY_UNIFORM_COMPONENTS_OES
        //     = 0x8DDF
        MaxGeometryUniformComponentsOes = 36319,
        //
        // Summary:
        //     [requires: EXT_geometry_shader] Original was GL_MAX_GEOMETRY_OUTPUT_VERTICES_EXT
        //     = 0x8DE0
        MaxGeometryOutputVerticesExt = 36320,
        //
        // Summary:
        //     [requires: OES_geometry_shader] Original was GL_MAX_GEOMETRY_OUTPUT_VERTICES_OES
        //     = 0x8DE0
        MaxGeometryOutputVerticesOes = 36320,
        //
        // Summary:
        //     [requires: EXT_geometry_shader] Original was GL_MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS_EXT
        //     = 0x8DE1
        MaxGeometryTotalOutputComponentsExt = 36321,
        //
        // Summary:
        //     [requires: OES_geometry_shader] Original was GL_MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS_OES
        //     = 0x8DE1
        MaxGeometryTotalOutputComponentsOes = 36321,
        //
        // Summary:
        //     Original was GL_ACTIVE_SUBROUTINES = 0x8DE5
        ActiveSubroutines = 36325,
        //
        // Summary:
        //     Original was GL_ACTIVE_SUBROUTINE_UNIFORMS = 0x8DE6
        ActiveSubroutineUniforms = 36326,
        //
        // Summary:
        //     Original was GL_LOW_FLOAT = 0x8DF0
        LowFloat = 36336,
        //
        // Summary:
        //     Original was GL_MEDIUM_FLOAT = 0x8DF1
        MediumFloat = 36337,
        //
        // Summary:
        //     Original was GL_HIGH_FLOAT = 0x8DF2
        HighFloat = 36338,
        //
        // Summary:
        //     Original was GL_LOW_INT = 0x8DF3
        LowInt = 36339,
        //
        // Summary:
        //     Original was GL_MEDIUM_INT = 0x8DF4
        MediumInt = 36340,
        //
        // Summary:
        //     Original was GL_HIGH_INT = 0x8DF5
        HighInt = 36341,
        //
        // Summary:
        //     [requires: OES_vertex_type_10_10_10_2] Original was GL_UNSIGNED_INT_10_10_10_2_OES
        //     = 0x8DF6
        UnsignedInt1010102Oes = 36342,
        //
        // Summary:
        //     [requires: OES_vertex_type_10_10_10_2] Original was GL_INT_10_10_10_2_OES = 0x8DF7
        Int1010102Oes = 36343,
        //
        // Summary:
        //     Original was GL_SHADER_BINARY_FORMATS = 0x8DF8
        ShaderBinaryFormats = 36344,
        //
        // Summary:
        //     Original was GL_NUM_SHADER_BINARY_FORMATS = 0x8DF9
        NumShaderBinaryFormats = 36345,
        //
        // Summary:
        //     Original was GL_SHADER_COMPILER = 0x8DFA
        ShaderCompiler = 36346,
        //
        // Summary:
        //     Original was GL_MAX_VERTEX_UNIFORM_VECTORS = 0x8DFB
        MaxVertexUniformVectors = 36347,
        //
        // Summary:
        //     Original was GL_MAX_VARYING_VECTORS = 0x8DFC
        MaxVaryingVectors = 36348,
        //
        // Summary:
        //     Original was GL_MAX_FRAGMENT_UNIFORM_VECTORS = 0x8DFD
        MaxFragmentUniformVectors = 36349,
        //
        // Summary:
        //     Original was GL_QUERY_WAIT = 0x8E13
        QueryWait = 36371,
        //
        // Summary:
        //     [requires: NV_conditional_render] Original was GL_QUERY_WAIT_NV = 0x8E13
        QueryWaitNv = 36371,
        //
        // Summary:
        //     Original was GL_QUERY_NO_WAIT = 0x8E14
        QueryNoWait = 36372,
        //
        // Summary:
        //     [requires: NV_conditional_render] Original was GL_QUERY_NO_WAIT_NV = 0x8E14
        QueryNoWaitNv = 36372,
        //
        // Summary:
        //     Original was GL_QUERY_BY_REGION_WAIT = 0x8E15
        QueryByRegionWait = 36373,
        //
        // Summary:
        //     [requires: NV_conditional_render] Original was GL_QUERY_BY_REGION_WAIT_NV = 0x8E15
        QueryByRegionWaitNv = 36373,
        //
        // Summary:
        //     Original was GL_QUERY_BY_REGION_NO_WAIT = 0x8E16
        QueryByRegionNoWait = 36374,
        //
        // Summary:
        //     [requires: NV_conditional_render] Original was GL_QUERY_BY_REGION_NO_WAIT_NV
        //     = 0x8E16
        QueryByRegionNoWaitNv = 36374,
        //
        // Summary:
        //     [requires: EXT_polygon_offset_clamp] Original was GL_POLYGON_OFFSET_CLAMP_EXT
        //     = 0x8E1B
        PolygonOffsetClampExt = 36379,
        //
        // Summary:
        //     [requires: EXT_tessellation_shader] Original was GL_MAX_COMBINED_TESS_CONTROL_UNIFORM_COMPONENTS_EXT
        //     = 0x8E1E
        MaxCombinedTessControlUniformComponentsExt = 36382,
        //
        // Summary:
        //     [requires: OES_tessellation_shader] Original was GL_MAX_COMBINED_TESS_CONTROL_UNIFORM_COMPONENTS_OES
        //     = 0x8E1E
        MaxCombinedTessControlUniformComponentsOes = 36382,
        //
        // Summary:
        //     [requires: EXT_tessellation_shader] Original was GL_MAX_COMBINED_TESS_EVALUATION_UNIFORM_COMPONENTS_EXT
        //     = 0x8E1F
        MaxCombinedTessEvaluationUniformComponentsExt = 36383,
        //
        // Summary:
        //     [requires: OES_tessellation_shader] Original was GL_MAX_COMBINED_TESS_EVALUATION_UNIFORM_COMPONENTS_OES
        //     = 0x8E1F
        MaxCombinedTessEvaluationUniformComponentsOes = 36383,
        //
        // Summary:
        //     [requires: NV_framebuffer_mixed_samples] Original was GL_COLOR_SAMPLES_NV = 0x8E20
        ColorSamplesNv = 36384,
        //
        // Summary:
        //     [requires: EXT_debug_label] Original was GL_TRANSFORM_FEEDBACK = 0x8E22
        TransformFeedback = 36386,
        //
        // Summary:
        //     Original was GL_TRANSFORM_FEEDBACK_PAUSED = 0x8E23
        TransformFeedbackPaused = 36387,
        //
        // Summary:
        //     Original was GL_TRANSFORM_FEEDBACK_ACTIVE = 0x8E24
        TransformFeedbackActive = 36388,
        //
        // Summary:
        //     Original was GL_TRANSFORM_FEEDBACK_BINDING = 0x8E25
        TransformFeedbackBinding = 36389,
        //
        // Summary:
        //     [requires: EXT_disjoint_timer_query] Original was GL_TIMESTAMP_EXT = 0x8E28
        TimestampExt = 36392,
        //
        // Summary:
        //     [requires: NV_depth_nonlinear] Original was GL_DEPTH_COMPONENT16_NONLINEAR_NV
        //     = 0x8E2C
        DepthComponent16NonlinearNv = 36396,
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
        //     Original was GL_ACTIVE_SUBROUTINE_UNIFORM_LOCATIONS = 0x8E47
        ActiveSubroutineUniformLocations = 36423,
        //
        // Summary:
        //     Original was GL_ACTIVE_SUBROUTINE_MAX_LENGTH = 0x8E48
        ActiveSubroutineMaxLength = 36424,
        //
        // Summary:
        //     Original was GL_ACTIVE_SUBROUTINE_UNIFORM_MAX_LENGTH = 0x8E49
        ActiveSubroutineUniformMaxLength = 36425,
        //
        // Summary:
        //     Original was GL_NUM_COMPATIBLE_SUBROUTINES = 0x8E4A
        NumCompatibleSubroutines = 36426,
        //
        // Summary:
        //     Original was GL_COMPATIBLE_SUBROUTINES = 0x8E4B
        CompatibleSubroutines = 36427,
        //
        // Summary:
        //     Original was GL_FIRST_VERTEX_CONVENTION = 0x8E4D
        FirstVertexConvention = 36429,
        //
        // Summary:
        //     [requires: EXT_geometry_shader] Original was GL_FIRST_VERTEX_CONVENTION_EXT =
        //     0x8E4D
        FirstVertexConventionExt = 36429,
        //
        // Summary:
        //     [requires: OES_geometry_shader] Original was GL_FIRST_VERTEX_CONVENTION_OES =
        //     0x8E4D
        FirstVertexConventionOes = 36429,
        //
        // Summary:
        //     Original was GL_LAST_VERTEX_CONVENTION = 0x8E4E
        LastVertexConvention = 36430,
        //
        // Summary:
        //     [requires: EXT_geometry_shader] Original was GL_LAST_VERTEX_CONVENTION_EXT =
        //     0x8E4E
        LastVertexConventionExt = 36430,
        //
        // Summary:
        //     [requires: OES_geometry_shader] Original was GL_LAST_VERTEX_CONVENTION_OES =
        //     0x8E4E
        LastVertexConventionOes = 36430,
        //
        // Summary:
        //     [requires: NV_sample_locations] Original was GL_SAMPLE_LOCATION_NV = 0x8E50
        SampleLocationNv = 36432,
        //
        // Summary:
        //     [requires: EXT_geometry_shader] Original was GL_MAX_GEOMETRY_SHADER_INVOCATIONS_EXT
        //     = 0x8E5A
        MaxGeometryShaderInvocationsExt = 36442,
        //
        // Summary:
        //     [requires: OES_geometry_shader] Original was GL_MAX_GEOMETRY_SHADER_INVOCATIONS_OES
        //     = 0x8E5A
        MaxGeometryShaderInvocationsOes = 36442,
        //
        // Summary:
        //     [requires: OES_shader_multisample_interpolation] Original was GL_MIN_FRAGMENT_INTERPOLATION_OFFSET_OES
        //     = 0x8E5B
        MinFragmentInterpolationOffsetOes = 36443,
        //
        // Summary:
        //     [requires: OES_shader_multisample_interpolation] Original was GL_MAX_FRAGMENT_INTERPOLATION_OFFSET_OES
        //     = 0x8E5C
        MaxFragmentInterpolationOffsetOes = 36444,
        //
        // Summary:
        //     [requires: OES_shader_multisample_interpolation] Original was GL_FRAGMENT_INTERPOLATION_OFFSET_BITS_OES
        //     = 0x8E5D
        FragmentInterpolationOffsetBitsOes = 36445,
        //
        // Summary:
        //     [requires: NV_mesh_shader] Original was GL_MAX_MESH_UNIFORM_BLOCKS_NV = 0x8E60
        MaxMeshUniformBlocksNv = 36448,
        //
        // Summary:
        //     [requires: NV_mesh_shader] Original was GL_MAX_MESH_TEXTURE_IMAGE_UNITS_NV =
        //     0x8E61
        MaxMeshTextureImageUnitsNv = 36449,
        //
        // Summary:
        //     [requires: NV_mesh_shader] Original was GL_MAX_MESH_IMAGE_UNIFORMS_NV = 0x8E62
        MaxMeshImageUniformsNv = 36450,
        //
        // Summary:
        //     [requires: NV_mesh_shader] Original was GL_MAX_MESH_UNIFORM_COMPONENTS_NV = 0x8E63
        MaxMeshUniformComponentsNv = 36451,
        //
        // Summary:
        //     [requires: NV_mesh_shader] Original was GL_MAX_MESH_ATOMIC_COUNTER_BUFFERS_NV
        //     = 0x8E64
        MaxMeshAtomicCounterBuffersNv = 36452,
        //
        // Summary:
        //     [requires: NV_mesh_shader] Original was GL_MAX_MESH_ATOMIC_COUNTERS_NV = 0x8E65
        MaxMeshAtomicCountersNv = 36453,
        //
        // Summary:
        //     [requires: NV_mesh_shader] Original was GL_MAX_MESH_SHADER_STORAGE_BLOCKS_NV
        //     = 0x8E66
        MaxMeshShaderStorageBlocksNv = 36454,
        //
        // Summary:
        //     [requires: NV_mesh_shader] Original was GL_MAX_COMBINED_MESH_UNIFORM_COMPONENTS_NV
        //     = 0x8E67
        MaxCombinedMeshUniformComponentsNv = 36455,
        //
        // Summary:
        //     [requires: NV_mesh_shader] Original was GL_MAX_TASK_UNIFORM_BLOCKS_NV = 0x8E68
        MaxTaskUniformBlocksNv = 36456,
        //
        // Summary:
        //     [requires: NV_mesh_shader] Original was GL_MAX_TASK_TEXTURE_IMAGE_UNITS_NV =
        //     0x8E69
        MaxTaskTextureImageUnitsNv = 36457,
        //
        // Summary:
        //     [requires: NV_mesh_shader] Original was GL_MAX_TASK_IMAGE_UNIFORMS_NV = 0x8E6A
        MaxTaskImageUniformsNv = 36458,
        //
        // Summary:
        //     [requires: NV_mesh_shader] Original was GL_MAX_TASK_UNIFORM_COMPONENTS_NV = 0x8E6B
        MaxTaskUniformComponentsNv = 36459,
        //
        // Summary:
        //     [requires: NV_mesh_shader] Original was GL_MAX_TASK_ATOMIC_COUNTER_BUFFERS_NV
        //     = 0x8E6C
        MaxTaskAtomicCounterBuffersNv = 36460,
        //
        // Summary:
        //     [requires: NV_mesh_shader] Original was GL_MAX_TASK_ATOMIC_COUNTERS_NV = 0x8E6D
        MaxTaskAtomicCountersNv = 36461,
        //
        // Summary:
        //     [requires: NV_mesh_shader] Original was GL_MAX_TASK_SHADER_STORAGE_BLOCKS_NV
        //     = 0x8E6E
        MaxTaskShaderStorageBlocksNv = 36462,
        //
        // Summary:
        //     [requires: NV_mesh_shader] Original was GL_MAX_COMBINED_TASK_UNIFORM_COMPONENTS_NV
        //     = 0x8E6F
        MaxCombinedTaskUniformComponentsNv = 36463,
        //
        // Summary:
        //     Original was GL_PATCH_VERTICES = 0x8E72
        PatchVertices = 36466,
        //
        // Summary:
        //     [requires: EXT_tessellation_shader] Original was GL_PATCH_VERTICES_EXT = 0x8E72
        PatchVerticesExt = 36466,
        //
        // Summary:
        //     [requires: OES_tessellation_shader] Original was GL_PATCH_VERTICES_OES = 0x8E72
        PatchVerticesOes = 36466,
        //
        // Summary:
        //     Original was GL_PATCH_DEFAULT_INNER_LEVEL = 0x8E73
        PatchDefaultInnerLevel = 36467,
        //
        // Summary:
        //     Original was GL_PATCH_DEFAULT_OUTER_LEVEL = 0x8E74
        PatchDefaultOuterLevel = 36468,
        //
        // Summary:
        //     [requires: EXT_tessellation_shader] Original was GL_TESS_CONTROL_OUTPUT_VERTICES_EXT
        //     = 0x8E75
        TessControlOutputVerticesExt = 36469,
        //
        // Summary:
        //     [requires: OES_tessellation_shader] Original was GL_TESS_CONTROL_OUTPUT_VERTICES_OES
        //     = 0x8E75
        TessControlOutputVerticesOes = 36469,
        //
        // Summary:
        //     [requires: EXT_tessellation_shader] Original was GL_TESS_GEN_MODE_EXT = 0x8E76
        TessGenModeExt = 36470,
        //
        // Summary:
        //     [requires: OES_tessellation_shader] Original was GL_TESS_GEN_MODE_OES = 0x8E76
        TessGenModeOes = 36470,
        //
        // Summary:
        //     [requires: EXT_tessellation_shader] Original was GL_TESS_GEN_SPACING_EXT = 0x8E77
        TessGenSpacingExt = 36471,
        //
        // Summary:
        //     [requires: OES_tessellation_shader] Original was GL_TESS_GEN_SPACING_OES = 0x8E77
        TessGenSpacingOes = 36471,
        //
        // Summary:
        //     [requires: EXT_tessellation_shader] Original was GL_TESS_GEN_VERTEX_ORDER_EXT
        //     = 0x8E78
        TessGenVertexOrderExt = 36472,
        //
        // Summary:
        //     [requires: OES_tessellation_shader] Original was GL_TESS_GEN_VERTEX_ORDER_OES
        //     = 0x8E78
        TessGenVertexOrderOes = 36472,
        //
        // Summary:
        //     [requires: EXT_tessellation_shader] Original was GL_TESS_GEN_POINT_MODE_EXT =
        //     0x8E79
        TessGenPointModeExt = 36473,
        //
        // Summary:
        //     [requires: OES_tessellation_shader] Original was GL_TESS_GEN_POINT_MODE_OES =
        //     0x8E79
        TessGenPointModeOes = 36473,
        //
        // Summary:
        //     [requires: EXT_tessellation_shader] Original was GL_ISOLINES_EXT = 0x8E7A
        IsolinesExt = 36474,
        //
        // Summary:
        //     [requires: OES_tessellation_shader] Original was GL_ISOLINES_OES = 0x8E7A
        IsolinesOes = 36474,
        //
        // Summary:
        //     [requires: EXT_tessellation_shader] Original was GL_FRACTIONAL_ODD_EXT = 0x8E7B
        FractionalOddExt = 36475,
        //
        // Summary:
        //     [requires: OES_tessellation_shader] Original was GL_FRACTIONAL_ODD_OES = 0x8E7B
        FractionalOddOes = 36475,
        //
        // Summary:
        //     [requires: EXT_tessellation_shader] Original was GL_FRACTIONAL_EVEN_EXT = 0x8E7C
        FractionalEvenExt = 36476,
        //
        // Summary:
        //     [requires: OES_tessellation_shader] Original was GL_FRACTIONAL_EVEN_OES = 0x8E7C
        FractionalEvenOes = 36476,
        //
        // Summary:
        //     [requires: EXT_tessellation_shader] Original was GL_MAX_PATCH_VERTICES_EXT =
        //     0x8E7D
        MaxPatchVerticesExt = 36477,
        //
        // Summary:
        //     [requires: OES_tessellation_shader] Original was GL_MAX_PATCH_VERTICES_OES =
        //     0x8E7D
        MaxPatchVerticesOes = 36477,
        //
        // Summary:
        //     [requires: EXT_tessellation_shader] Original was GL_MAX_TESS_GEN_LEVEL_EXT =
        //     0x8E7E
        MaxTessGenLevelExt = 36478,
        //
        // Summary:
        //     [requires: OES_tessellation_shader] Original was GL_MAX_TESS_GEN_LEVEL_OES =
        //     0x8E7E
        MaxTessGenLevelOes = 36478,
        //
        // Summary:
        //     [requires: EXT_tessellation_shader] Original was GL_MAX_TESS_CONTROL_UNIFORM_COMPONENTS_EXT
        //     = 0x8E7F
        MaxTessControlUniformComponentsExt = 36479,
        //
        // Summary:
        //     [requires: OES_tessellation_shader] Original was GL_MAX_TESS_CONTROL_UNIFORM_COMPONENTS_OES
        //     = 0x8E7F
        MaxTessControlUniformComponentsOes = 36479,
        //
        // Summary:
        //     [requires: EXT_tessellation_shader] Original was GL_MAX_TESS_EVALUATION_UNIFORM_COMPONENTS_EXT
        //     = 0x8E80
        MaxTessEvaluationUniformComponentsExt = 36480,
        //
        // Summary:
        //     [requires: OES_tessellation_shader] Original was GL_MAX_TESS_EVALUATION_UNIFORM_COMPONENTS_OES
        //     = 0x8E80
        MaxTessEvaluationUniformComponentsOes = 36480,
        //
        // Summary:
        //     [requires: EXT_tessellation_shader] Original was GL_MAX_TESS_CONTROL_TEXTURE_IMAGE_UNITS_EXT
        //     = 0x8E81
        MaxTessControlTextureImageUnitsExt = 36481,
        //
        // Summary:
        //     [requires: OES_tessellation_shader] Original was GL_MAX_TESS_CONTROL_TEXTURE_IMAGE_UNITS_OES
        //     = 0x8E81
        MaxTessControlTextureImageUnitsOes = 36481,
        //
        // Summary:
        //     [requires: EXT_tessellation_shader] Original was GL_MAX_TESS_EVALUATION_TEXTURE_IMAGE_UNITS_EXT
        //     = 0x8E82
        MaxTessEvaluationTextureImageUnitsExt = 36482,
        //
        // Summary:
        //     [requires: OES_tessellation_shader] Original was GL_MAX_TESS_EVALUATION_TEXTURE_IMAGE_UNITS_OES
        //     = 0x8E82
        MaxTessEvaluationTextureImageUnitsOes = 36482,
        //
        // Summary:
        //     [requires: EXT_tessellation_shader] Original was GL_MAX_TESS_CONTROL_OUTPUT_COMPONENTS_EXT
        //     = 0x8E83
        MaxTessControlOutputComponentsExt = 36483,
        //
        // Summary:
        //     [requires: OES_tessellation_shader] Original was GL_MAX_TESS_CONTROL_OUTPUT_COMPONENTS_OES
        //     = 0x8E83
        MaxTessControlOutputComponentsOes = 36483,
        //
        // Summary:
        //     [requires: EXT_tessellation_shader] Original was GL_MAX_TESS_PATCH_COMPONENTS_EXT
        //     = 0x8E84
        MaxTessPatchComponentsExt = 36484,
        //
        // Summary:
        //     [requires: OES_tessellation_shader] Original was GL_MAX_TESS_PATCH_COMPONENTS_OES
        //     = 0x8E84
        MaxTessPatchComponentsOes = 36484,
        //
        // Summary:
        //     [requires: EXT_tessellation_shader] Original was GL_MAX_TESS_CONTROL_TOTAL_OUTPUT_COMPONENTS_EXT
        //     = 0x8E85
        MaxTessControlTotalOutputComponentsExt = 36485,
        //
        // Summary:
        //     [requires: OES_tessellation_shader] Original was GL_MAX_TESS_CONTROL_TOTAL_OUTPUT_COMPONENTS_OES
        //     = 0x8E85
        MaxTessControlTotalOutputComponentsOes = 36485,
        //
        // Summary:
        //     [requires: EXT_tessellation_shader] Original was GL_MAX_TESS_EVALUATION_OUTPUT_COMPONENTS_EXT
        //     = 0x8E86
        MaxTessEvaluationOutputComponentsExt = 36486,
        //
        // Summary:
        //     [requires: OES_tessellation_shader] Original was GL_MAX_TESS_EVALUATION_OUTPUT_COMPONENTS_OES
        //     = 0x8E86
        MaxTessEvaluationOutputComponentsOes = 36486,
        //
        // Summary:
        //     Original was GL_TESS_EVALUATION_SHADER = 0x8E87
        TessEvaluationShader = 36487,
        //
        // Summary:
        //     [requires: EXT_tessellation_shader] Original was GL_TESS_EVALUATION_SHADER_EXT
        //     = 0x8E87
        TessEvaluationShaderExt = 36487,
        //
        // Summary:
        //     [requires: OES_tessellation_shader] Original was GL_TESS_EVALUATION_SHADER_OES
        //     = 0x8E87
        TessEvaluationShaderOes = 36487,
        //
        // Summary:
        //     Original was GL_TESS_CONTROL_SHADER = 0x8E88
        TessControlShader = 36488,
        //
        // Summary:
        //     [requires: EXT_tessellation_shader] Original was GL_TESS_CONTROL_SHADER_EXT =
        //     0x8E88
        TessControlShaderExt = 36488,
        //
        // Summary:
        //     [requires: OES_tessellation_shader] Original was GL_TESS_CONTROL_SHADER_OES =
        //     0x8E88
        TessControlShaderOes = 36488,
        //
        // Summary:
        //     [requires: EXT_tessellation_shader] Original was GL_MAX_TESS_CONTROL_UNIFORM_BLOCKS_EXT
        //     = 0x8E89
        MaxTessControlUniformBlocksExt = 36489,
        //
        // Summary:
        //     [requires: OES_tessellation_shader] Original was GL_MAX_TESS_CONTROL_UNIFORM_BLOCKS_OES
        //     = 0x8E89
        MaxTessControlUniformBlocksOes = 36489,
        //
        // Summary:
        //     [requires: EXT_tessellation_shader] Original was GL_MAX_TESS_EVALUATION_UNIFORM_BLOCKS_EXT
        //     = 0x8E8A
        MaxTessEvaluationUniformBlocksExt = 36490,
        //
        // Summary:
        //     [requires: OES_tessellation_shader] Original was GL_MAX_TESS_EVALUATION_UNIFORM_BLOCKS_OES
        //     = 0x8E8A
        MaxTessEvaluationUniformBlocksOes = 36490,
        //
        // Summary:
        //     Original was GL_COMPRESSED_RGBA_BPTC_UNORM = 0x8E8C
        CompressedRgbaBptcUnorm = 36492,
        //
        // Summary:
        //     [requires: EXT_texture_compression_bptc] Original was GL_COMPRESSED_RGBA_BPTC_UNORM_EXT
        //     = 0x8E8C
        CompressedRgbaBptcUnormExt = 36492,
        //
        // Summary:
        //     Original was GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM = 0x8E8D
        CompressedSrgbAlphaBptcUnorm = 36493,
        //
        // Summary:
        //     [requires: EXT_texture_compression_bptc] Original was GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM_EXT
        //     = 0x8E8D
        CompressedSrgbAlphaBptcUnormExt = 36493,
        //
        // Summary:
        //     Original was GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT = 0x8E8E
        CompressedRgbBptcSignedFloat = 36494,
        //
        // Summary:
        //     [requires: EXT_texture_compression_bptc] Original was GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT_EXT
        //     = 0x8E8E
        CompressedRgbBptcSignedFloatExt = 36494,
        //
        // Summary:
        //     Original was GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT = 0x8E8F
        CompressedRgbBptcUnsignedFloat = 36495,
        //
        // Summary:
        //     [requires: EXT_texture_compression_bptc] Original was GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT_EXT
        //     = 0x8E8F
        CompressedRgbBptcUnsignedFloatExt = 36495,
        //
        // Summary:
        //     [requires: NV_coverage_sample] Original was GL_COVERAGE_COMPONENT_NV = 0x8ED0
        CoverageComponentNv = 36560,
        //
        // Summary:
        //     [requires: NV_coverage_sample] Original was GL_COVERAGE_COMPONENT4_NV = 0x8ED1
        CoverageComponent4Nv = 36561,
        //
        // Summary:
        //     [requires: NV_coverage_sample] Original was GL_COVERAGE_ATTACHMENT_NV = 0x8ED2
        CoverageAttachmentNv = 36562,
        //
        // Summary:
        //     [requires: NV_coverage_sample] Original was GL_COVERAGE_BUFFERS_NV = 0x8ED3
        CoverageBuffersNv = 36563,
        //
        // Summary:
        //     [requires: NV_coverage_sample] Original was GL_COVERAGE_SAMPLES_NV = 0x8ED4
        CoverageSamplesNv = 36564,
        //
        // Summary:
        //     [requires: NV_coverage_sample] Original was GL_COVERAGE_ALL_FRAGMENTS_NV = 0x8ED5
        CoverageAllFragmentsNv = 36565,
        //
        // Summary:
        //     [requires: NV_coverage_sample] Original was GL_COVERAGE_EDGE_FRAGMENTS_NV = 0x8ED6
        CoverageEdgeFragmentsNv = 36566,
        //
        // Summary:
        //     [requires: NV_coverage_sample] Original was GL_COVERAGE_AUTOMATIC_NV = 0x8ED7
        CoverageAutomaticNv = 36567,
        //
        // Summary:
        //     [requires: EXT_window_rectangles] Original was GL_INCLUSIVE_EXT = 0x8F10
        InclusiveExt = 36624,
        //
        // Summary:
        //     [requires: EXT_window_rectangles] Original was GL_EXCLUSIVE_EXT = 0x8F11
        ExclusiveExt = 36625,
        //
        // Summary:
        //     [requires: EXT_window_rectangles] Original was GL_WINDOW_RECTANGLE_EXT = 0x8F12
        WindowRectangleExt = 36626,
        //
        // Summary:
        //     [requires: EXT_window_rectangles] Original was GL_WINDOW_RECTANGLE_MODE_EXT =
        //     0x8F13
        WindowRectangleModeExt = 36627,
        //
        // Summary:
        //     [requires: EXT_window_rectangles] Original was GL_MAX_WINDOW_RECTANGLES_EXT =
        //     0x8F14
        MaxWindowRectanglesExt = 36628,
        //
        // Summary:
        //     [requires: EXT_window_rectangles] Original was GL_NUM_WINDOW_RECTANGLES_EXT =
        //     0x8F15
        NumWindowRectanglesExt = 36629,
        //
        // Summary:
        //     Original was GL_COPY_READ_BUFFER = 0x8F36
        CopyReadBuffer = 36662,
        //
        // Summary:
        //     Original was GL_COPY_READ_BUFFER_BINDING = 0x8F36
        CopyReadBufferBinding = 36662,
        //
        // Summary:
        //     [requires: NV_copy_buffer] Original was GL_COPY_READ_BUFFER_NV = 0x8F36
        CopyReadBufferNv = 36662,
        //
        // Summary:
        //     Original was GL_COPY_WRITE_BUFFER = 0x8F37
        CopyWriteBuffer = 36663,
        //
        // Summary:
        //     Original was GL_COPY_WRITE_BUFFER_BINDING = 0x8F37
        CopyWriteBufferBinding = 36663,
        //
        // Summary:
        //     [requires: NV_copy_buffer] Original was GL_COPY_WRITE_BUFFER_NV = 0x8F37
        CopyWriteBufferNv = 36663,
        //
        // Summary:
        //     Original was GL_DRAW_INDIRECT_BUFFER = 0x8F3F
        DrawIndirectBuffer = 36671,
        //
        // Summary:
        //     Original was GL_MALI_SHADER_BINARY_ARM = 0x8F60
        MaliShaderBinaryArm = 36704,
        //
        // Summary:
        //     Original was GL_MALI_PROGRAM_BINARY_ARM = 0x8F61
        MaliProgramBinaryArm = 36705,
        //
        // Summary:
        //     [requires: EXT_shader_pixel_local_storage] Original was GL_MAX_SHADER_PIXEL_LOCAL_STORAGE_FAST_SIZE_EXT
        //     = 0x8F63
        MaxShaderPixelLocalStorageFastSizeExt = 36707,
        //
        // Summary:
        //     [requires: EXT_shader_pixel_local_storage] Original was GL_SHADER_PIXEL_LOCAL_STORAGE_EXT
        //     = 0x8F64
        ShaderPixelLocalStorageExt = 36708,
        //
        // Summary:
        //     Original was GL_FETCH_PER_SAMPLE_ARM = 0x8F65
        FetchPerSampleArm = 36709,
        //
        // Summary:
        //     Original was GL_FRAGMENT_SHADER_FRAMEBUFFER_FETCH_MRT_ARM = 0x8F66
        FragmentShaderFramebufferFetchMrtArm = 36710,
        //
        // Summary:
        //     [requires: EXT_shader_pixel_local_storage] Original was GL_MAX_SHADER_PIXEL_LOCAL_STORAGE_SIZE_EXT
        //     = 0x8F67
        MaxShaderPixelLocalStorageSizeExt = 36711,
        //
        // Summary:
        //     [requires: EXT_texture_compression_astc_decode_mode] Original was GL_TEXTURE_ASTC_DECODE_PRECISION_EXT
        //     = 0x8F69
        TextureAstcDecodePrecisionExt = 36713,
        //
        // Summary:
        //     [requires: EXT_render_snorm] Original was GL_R8_SNORM = 0x8F94
        R8Snorm = 36756,
        //
        // Summary:
        //     [requires: EXT_render_snorm] Original was GL_RG8_SNORM = 0x8F95
        Rg8Snorm = 36757,
        //
        // Summary:
        //     Original was GL_RGB8_SNORM = 0x8F96
        Rgb8Snorm = 36758,
        //
        // Summary:
        //     [requires: EXT_render_snorm] Original was GL_RGBA8_SNORM = 0x8F97
        Rgba8Snorm = 36759,
        //
        // Summary:
        //     Original was GL_R16_SNORM = 0x8F98
        R16Snorm = 36760,
        //
        // Summary:
        //     [requires: EXT_render_snorm, or EXT_texture_norm16] Original was GL_R16_SNORM_EXT
        //     = 0x8F98
        R16SnormExt = 36760,
        //
        // Summary:
        //     Original was GL_RG16_SNORM = 0x8F99
        Rg16Snorm = 36761,
        //
        // Summary:
        //     [requires: EXT_render_snorm, or EXT_texture_norm16] Original was GL_RG16_SNORM_EXT
        //     = 0x8F99
        Rg16SnormExt = 36761,
        //
        // Summary:
        //     Original was GL_RGB16_SNORM = 0x8F9A
        Rgb16Snorm = 36762,
        //
        // Summary:
        //     [requires: EXT_texture_norm16] Original was GL_RGB16_SNORM_EXT = 0x8F9A
        Rgb16SnormExt = 36762,
        //
        // Summary:
        //     [requires: EXT_render_snorm, or EXT_texture_norm16] Original was GL_RGBA16_SNORM_EXT
        //     = 0x8F9B
        Rgba16SnormExt = 36763,
        //
        // Summary:
        //     Original was GL_SIGNED_NORMALIZED = 0x8F9C
        SignedNormalized = 36764,
        //
        // Summary:
        //     [requires: QCOM_perfmon_global_mode] Original was GL_PERFMON_GLOBAL_MODE_QCOM
        //     = 0x8FA0
        PerfmonGlobalModeQcom = 36768,
        //
        // Summary:
        //     [requires: QCOM_binning_control] Original was GL_BINNING_CONTROL_HINT_QCOM =
        //     0x8FB0
        BinningControlHintQcom = 36784,
        //
        // Summary:
        //     [requires: QCOM_binning_control] Original was GL_CPU_OPTIMIZED_QCOM = 0x8FB1
        CpuOptimizedQcom = 36785,
        //
        // Summary:
        //     [requires: QCOM_binning_control] Original was GL_GPU_OPTIMIZED_QCOM = 0x8FB2
        GpuOptimizedQcom = 36786,
        //
        // Summary:
        //     [requires: QCOM_binning_control] Original was GL_RENDER_DIRECT_TO_FRAMEBUFFER_QCOM
        //     = 0x8FB3
        RenderDirectToFramebufferQcom = 36787,
        //
        // Summary:
        //     [requires: EXT_disjoint_timer_query] Original was GL_GPU_DISJOINT_EXT = 0x8FBB
        GpuDisjointExt = 36795,
        //
        // Summary:
        //     [requires: EXT_texture_sRGB_R8] Original was GL_SR8_EXT = 0x8FBD
        Sr8Ext = 36797,
        //
        // Summary:
        //     [requires: EXT_texture_sRGB_RG8] Original was GL_SRG8_EXT = 0x8FBE
        Srg8Ext = 36798,
        //
        // Summary:
        //     Original was GL_SHADER_BINARY_VIV = 0x8FC4
        ShaderBinaryViv = 36804,
        //
        // Summary:
        //     [requires: NV_gpu_shader5] Original was GL_INT8_NV = 0x8FE0
        Int8Nv = 36832,
        //
        // Summary:
        //     [requires: NV_gpu_shader5] Original was GL_INT8_VEC2_NV = 0x8FE1
        Int8Vec2Nv = 36833,
        //
        // Summary:
        //     [requires: NV_gpu_shader5] Original was GL_INT8_VEC3_NV = 0x8FE2
        Int8Vec3Nv = 36834,
        //
        // Summary:
        //     [requires: NV_gpu_shader5] Original was GL_INT8_VEC4_NV = 0x8FE3
        Int8Vec4Nv = 36835,
        //
        // Summary:
        //     [requires: NV_gpu_shader5] Original was GL_INT16_NV = 0x8FE4
        Int16Nv = 36836,
        //
        // Summary:
        //     [requires: NV_gpu_shader5] Original was GL_INT16_VEC2_NV = 0x8FE5
        Int16Vec2Nv = 36837,
        //
        // Summary:
        //     [requires: NV_gpu_shader5] Original was GL_INT16_VEC3_NV = 0x8FE6
        Int16Vec3Nv = 36838,
        //
        // Summary:
        //     [requires: NV_gpu_shader5] Original was GL_INT16_VEC4_NV = 0x8FE7
        Int16Vec4Nv = 36839,
        //
        // Summary:
        //     [requires: NV_gpu_shader5] Original was GL_INT64_VEC2_NV = 0x8FE9
        Int64Vec2Nv = 36841,
        //
        // Summary:
        //     [requires: NV_gpu_shader5] Original was GL_INT64_VEC3_NV = 0x8FEA
        Int64Vec3Nv = 36842,
        //
        // Summary:
        //     [requires: NV_gpu_shader5] Original was GL_INT64_VEC4_NV = 0x8FEB
        Int64Vec4Nv = 36843,
        //
        // Summary:
        //     [requires: NV_gpu_shader5] Original was GL_UNSIGNED_INT8_NV = 0x8FEC
        UnsignedInt8Nv = 36844,
        //
        // Summary:
        //     [requires: NV_gpu_shader5] Original was GL_UNSIGNED_INT8_VEC2_NV = 0x8FED
        UnsignedInt8Vec2Nv = 36845,
        //
        // Summary:
        //     [requires: NV_gpu_shader5] Original was GL_UNSIGNED_INT8_VEC3_NV = 0x8FEE
        UnsignedInt8Vec3Nv = 36846,
        //
        // Summary:
        //     [requires: NV_gpu_shader5] Original was GL_UNSIGNED_INT8_VEC4_NV = 0x8FEF
        UnsignedInt8Vec4Nv = 36847,
        //
        // Summary:
        //     [requires: NV_gpu_shader5] Original was GL_UNSIGNED_INT16_NV = 0x8FF0
        UnsignedInt16Nv = 36848,
        //
        // Summary:
        //     [requires: NV_gpu_shader5] Original was GL_UNSIGNED_INT16_VEC2_NV = 0x8FF1
        UnsignedInt16Vec2Nv = 36849,
        //
        // Summary:
        //     [requires: NV_gpu_shader5] Original was GL_UNSIGNED_INT16_VEC3_NV = 0x8FF2
        UnsignedInt16Vec3Nv = 36850,
        //
        // Summary:
        //     [requires: NV_gpu_shader5] Original was GL_UNSIGNED_INT16_VEC4_NV = 0x8FF3
        UnsignedInt16Vec4Nv = 36851,
        //
        // Summary:
        //     [requires: NV_gpu_shader5] Original was GL_UNSIGNED_INT64_VEC2_NV = 0x8FF5
        UnsignedInt64Vec2Nv = 36853,
        //
        // Summary:
        //     [requires: NV_gpu_shader5] Original was GL_UNSIGNED_INT64_VEC3_NV = 0x8FF6
        UnsignedInt64Vec3Nv = 36854,
        //
        // Summary:
        //     [requires: NV_gpu_shader5] Original was GL_UNSIGNED_INT64_VEC4_NV = 0x8FF7
        UnsignedInt64Vec4Nv = 36855,
        //
        // Summary:
        //     [requires: NV_gpu_shader5] Original was GL_FLOAT16_NV = 0x8FF8
        Float16Nv = 36856,
        //
        // Summary:
        //     [requires: NV_gpu_shader5] Original was GL_FLOAT16_VEC2_NV = 0x8FF9
        Float16Vec2Nv = 36857,
        //
        // Summary:
        //     [requires: NV_gpu_shader5] Original was GL_FLOAT16_VEC3_NV = 0x8FFA
        Float16Vec3Nv = 36858,
        //
        // Summary:
        //     [requires: NV_gpu_shader5] Original was GL_FLOAT16_VEC4_NV = 0x8FFB
        Float16Vec4Nv = 36859,
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
        //     [requires: EXT_texture_cube_map_array] Original was GL_TEXTURE_BINDING_CUBE_MAP_ARRAY_EXT
        //     = 0x900A
        TextureBindingCubeMapArrayExt = 36874,
        //
        // Summary:
        //     [requires: OES_texture_cube_map_array] Original was GL_TEXTURE_BINDING_CUBE_MAP_ARRAY_OES
        //     = 0x900A
        TextureBindingCubeMapArrayOes = 36874,
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
        //     [requires: EXT_texture_cube_map_array] Original was GL_SAMPLER_CUBE_MAP_ARRAY_EXT
        //     = 0x900C
        SamplerCubeMapArrayExt = 36876,
        //
        // Summary:
        //     [requires: OES_texture_cube_map_array] Original was GL_SAMPLER_CUBE_MAP_ARRAY_OES
        //     = 0x900C
        SamplerCubeMapArrayOes = 36876,
        //
        // Summary:
        //     [requires: EXT_texture_cube_map_array] Original was GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW_EXT
        //     = 0x900D
        SamplerCubeMapArrayShadowExt = 36877,
        //
        // Summary:
        //     [requires: OES_texture_cube_map_array] Original was GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW_OES
        //     = 0x900D
        SamplerCubeMapArrayShadowOes = 36877,
        //
        // Summary:
        //     [requires: EXT_texture_cube_map_array] Original was GL_INT_SAMPLER_CUBE_MAP_ARRAY_EXT
        //     = 0x900E
        IntSamplerCubeMapArrayExt = 36878,
        //
        // Summary:
        //     [requires: OES_texture_cube_map_array] Original was GL_INT_SAMPLER_CUBE_MAP_ARRAY_OES
        //     = 0x900E
        IntSamplerCubeMapArrayOes = 36878,
        //
        // Summary:
        //     [requires: EXT_texture_cube_map_array] Original was GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY_EXT
        //     = 0x900F
        UnsignedIntSamplerCubeMapArrayExt = 36879,
        //
        // Summary:
        //     [requires: OES_texture_cube_map_array] Original was GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY_OES
        //     = 0x900F
        UnsignedIntSamplerCubeMapArrayOes = 36879,
        //
        // Summary:
        //     [requires: NV_blend_minmax_factor] Original was GL_FACTOR_MIN_AMD = 0x901C
        FactorMinAmd = 36892,
        //
        // Summary:
        //     [requires: NV_blend_minmax_factor] Original was GL_FACTOR_MAX_AMD = 0x901D
        FactorMaxAmd = 36893,
        //
        // Summary:
        //     [requires: EXT_texture_buffer] Original was GL_IMAGE_BUFFER_EXT = 0x9051
        ImageBufferExt = 36945,
        //
        // Summary:
        //     [requires: OES_texture_buffer] Original was GL_IMAGE_BUFFER_OES = 0x9051
        ImageBufferOes = 36945,
        //
        // Summary:
        //     [requires: EXT_texture_cube_map_array] Original was GL_IMAGE_CUBE_MAP_ARRAY_EXT
        //     = 0x9054
        ImageCubeMapArrayExt = 36948,
        //
        // Summary:
        //     [requires: OES_texture_cube_map_array] Original was GL_IMAGE_CUBE_MAP_ARRAY_OES
        //     = 0x9054
        ImageCubeMapArrayOes = 36948,
        //
        // Summary:
        //     [requires: EXT_texture_buffer] Original was GL_INT_IMAGE_BUFFER_EXT = 0x905C
        IntImageBufferExt = 36956,
        //
        // Summary:
        //     [requires: OES_texture_buffer] Original was GL_INT_IMAGE_BUFFER_OES = 0x905C
        IntImageBufferOes = 36956,
        //
        // Summary:
        //     [requires: EXT_texture_cube_map_array] Original was GL_INT_IMAGE_CUBE_MAP_ARRAY_EXT
        //     = 0x905F
        IntImageCubeMapArrayExt = 36959,
        //
        // Summary:
        //     [requires: OES_texture_cube_map_array] Original was GL_INT_IMAGE_CUBE_MAP_ARRAY_OES
        //     = 0x905F
        IntImageCubeMapArrayOes = 36959,
        //
        // Summary:
        //     [requires: EXT_texture_buffer] Original was GL_UNSIGNED_INT_IMAGE_BUFFER_EXT
        //     = 0x9067
        UnsignedIntImageBufferExt = 36967,
        //
        // Summary:
        //     [requires: OES_texture_buffer] Original was GL_UNSIGNED_INT_IMAGE_BUFFER_OES
        //     = 0x9067
        UnsignedIntImageBufferOes = 36967,
        //
        // Summary:
        //     [requires: EXT_texture_cube_map_array] Original was GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY_EXT
        //     = 0x906A
        UnsignedIntImageCubeMapArrayExt = 36970,
        //
        // Summary:
        //     [requires: OES_texture_cube_map_array] Original was GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY_OES
        //     = 0x906A
        UnsignedIntImageCubeMapArrayOes = 36970,
        //
        // Summary:
        //     Original was GL_RGB10_A2UI = 0x906F
        Rgb10A2ui = 36975,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_PATH_FORMAT_SVG_NV = 0x9070
        PathFormatSvgNv = 36976,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_PATH_FORMAT_PS_NV = 0x9071
        PathFormatPsNv = 36977,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_STANDARD_FONT_NAME_NV = 0x9072
        StandardFontNameNv = 36978,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_SYSTEM_FONT_NAME_NV = 0x9073
        SystemFontNameNv = 36979,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_FILE_NAME_NV = 0x9074
        FileNameNv = 36980,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_PATH_STROKE_WIDTH_NV = 0x9075
        PathStrokeWidthNv = 36981,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_PATH_END_CAPS_NV = 0x9076
        PathEndCapsNv = 36982,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_PATH_INITIAL_END_CAP_NV = 0x9077
        PathInitialEndCapNv = 36983,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_PATH_TERMINAL_END_CAP_NV = 0x9078
        PathTerminalEndCapNv = 36984,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_PATH_JOIN_STYLE_NV = 0x9079
        PathJoinStyleNv = 36985,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_PATH_MITER_LIMIT_NV = 0x907A
        PathMiterLimitNv = 36986,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_PATH_DASH_CAPS_NV = 0x907B
        PathDashCapsNv = 36987,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_PATH_INITIAL_DASH_CAP_NV = 0x907C
        PathInitialDashCapNv = 36988,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_PATH_TERMINAL_DASH_CAP_NV = 0x907D
        PathTerminalDashCapNv = 36989,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_PATH_DASH_OFFSET_NV = 0x907E
        PathDashOffsetNv = 36990,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_PATH_CLIENT_LENGTH_NV = 0x907F
        PathClientLengthNv = 36991,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_PATH_FILL_MODE_NV = 0x9080
        PathFillModeNv = 36992,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_PATH_FILL_MASK_NV = 0x9081
        PathFillMaskNv = 36993,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_PATH_FILL_COVER_MODE_NV = 0x9082
        PathFillCoverModeNv = 36994,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_PATH_STROKE_COVER_MODE_NV = 0x9083
        PathStrokeCoverModeNv = 36995,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_PATH_STROKE_MASK_NV = 0x9084
        PathStrokeMaskNv = 36996,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_COUNT_UP_NV = 0x9088
        CountUpNv = 37000,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_COUNT_DOWN_NV = 0x9089
        CountDownNv = 37001,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_PATH_OBJECT_BOUNDING_BOX_NV = 0x908A
        PathObjectBoundingBoxNv = 37002,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_CONVEX_HULL_NV = 0x908B
        ConvexHullNv = 37003,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_BOUNDING_BOX_NV = 0x908D
        BoundingBoxNv = 37005,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_TRANSLATE_X_NV = 0x908E
        TranslateXNv = 37006,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_TRANSLATE_Y_NV = 0x908F
        TranslateYNv = 37007,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_TRANSLATE_2D_NV = 0x9090
        Translate2DNv = 37008,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_TRANSLATE_3D_NV = 0x9091
        Translate3DNv = 37009,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_AFFINE_2D_NV = 0x9092
        Affine2DNv = 37010,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_AFFINE_3D_NV = 0x9094
        Affine3DNv = 37012,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_TRANSPOSE_AFFINE_2D_NV = 0x9096
        TransposeAffine2DNv = 37014,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_TRANSPOSE_AFFINE_3D_NV = 0x9098
        TransposeAffine3DNv = 37016,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_UTF8_NV = 0x909A
        Utf8Nv = 37018,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_UTF16_NV = 0x909B
        Utf16Nv = 37019,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_BOUNDING_BOX_OF_BOUNDING_BOXES_NV
        //     = 0x909C
        BoundingBoxOfBoundingBoxesNv = 37020,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_PATH_COMMAND_COUNT_NV = 0x909D
        PathCommandCountNv = 37021,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_PATH_COORD_COUNT_NV = 0x909E
        PathCoordCountNv = 37022,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_PATH_DASH_ARRAY_COUNT_NV = 0x909F
        PathDashArrayCountNv = 37023,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_PATH_COMPUTED_LENGTH_NV = 0x90A0
        PathComputedLengthNv = 37024,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_PATH_FILL_BOUNDING_BOX_NV = 0x90A1
        PathFillBoundingBoxNv = 37025,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_PATH_STROKE_BOUNDING_BOX_NV = 0x90A2
        PathStrokeBoundingBoxNv = 37026,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_SQUARE_NV = 0x90A3
        SquareNv = 37027,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_ROUND_NV = 0x90A4
        RoundNv = 37028,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_TRIANGULAR_NV = 0x90A5
        TriangularNv = 37029,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_BEVEL_NV = 0x90A6
        BevelNv = 37030,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_MITER_REVERT_NV = 0x90A7
        MiterRevertNv = 37031,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_MITER_TRUNCATE_NV = 0x90A8
        MiterTruncateNv = 37032,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_SKIP_MISSING_GLYPH_NV = 0x90A9
        SkipMissingGlyphNv = 37033,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_USE_MISSING_GLYPH_NV = 0x90AA
        UseMissingGlyphNv = 37034,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_PATH_ERROR_POSITION_NV = 0x90AB
        PathErrorPositionNv = 37035,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_PATH_FOG_GEN_MODE_NV = 0x90AC
        PathFogGenModeNv = 37036,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_ACCUM_ADJACENT_PAIRS_NV = 0x90AD
        AccumAdjacentPairsNv = 37037,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_ADJACENT_PAIRS_NV = 0x90AE
        AdjacentPairsNv = 37038,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_FIRST_TO_REST_NV = 0x90AF
        FirstToRestNv = 37039,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_PATH_GEN_MODE_NV = 0x90B0
        PathGenModeNv = 37040,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_PATH_GEN_COEFF_NV = 0x90B1
        PathGenCoeffNv = 37041,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_PATH_GEN_COLOR_FORMAT_NV = 0x90B2
        PathGenColorFormatNv = 37042,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_PATH_GEN_COMPONENTS_NV = 0x90B3
        PathGenComponentsNv = 37043,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_PATH_DASH_OFFSET_RESET_NV = 0x90B4
        PathDashOffsetResetNv = 37044,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_MOVE_TO_RESETS_NV = 0x90B5
        MoveToResetsNv = 37045,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_MOVE_TO_CONTINUES_NV = 0x90B6
        MoveToContinuesNv = 37046,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_PATH_STENCIL_FUNC_NV = 0x90B7
        PathStencilFuncNv = 37047,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_PATH_STENCIL_REF_NV = 0x90B8
        PathStencilRefNv = 37048,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_PATH_STENCIL_VALUE_MASK_NV = 0x90B9
        PathStencilValueMaskNv = 37049,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_PATH_STENCIL_DEPTH_OFFSET_FACTOR_NV
        //     = 0x90BD
        PathStencilDepthOffsetFactorNv = 37053,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_PATH_STENCIL_DEPTH_OFFSET_UNITS_NV
        //     = 0x90BE
        PathStencilDepthOffsetUnitsNv = 37054,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_PATH_COVER_DEPTH_FUNC_NV = 0x90BF
        PathCoverDepthFuncNv = 37055,
        //
        // Summary:
        //     Original was GL_IMAGE_FORMAT_COMPATIBILITY_TYPE = 0x90C7
        ImageFormatCompatibilityType = 37063,
        //
        // Summary:
        //     [requires: EXT_tessellation_shader] Original was GL_MAX_TESS_CONTROL_IMAGE_UNIFORMS_EXT
        //     = 0x90CB
        MaxTessControlImageUniformsExt = 37067,
        //
        // Summary:
        //     [requires: OES_tessellation_shader] Original was GL_MAX_TESS_CONTROL_IMAGE_UNIFORMS_OES
        //     = 0x90CB
        MaxTessControlImageUniformsOes = 37067,
        //
        // Summary:
        //     [requires: EXT_tessellation_shader] Original was GL_MAX_TESS_EVALUATION_IMAGE_UNIFORMS_EXT
        //     = 0x90CC
        MaxTessEvaluationImageUniformsExt = 37068,
        //
        // Summary:
        //     [requires: OES_tessellation_shader] Original was GL_MAX_TESS_EVALUATION_IMAGE_UNIFORMS_OES
        //     = 0x90CC
        MaxTessEvaluationImageUniformsOes = 37068,
        //
        // Summary:
        //     [requires: EXT_geometry_shader] Original was GL_MAX_GEOMETRY_IMAGE_UNIFORMS_EXT
        //     = 0x90CD
        MaxGeometryImageUniformsExt = 37069,
        //
        // Summary:
        //     [requires: OES_geometry_shader] Original was GL_MAX_GEOMETRY_IMAGE_UNIFORMS_OES
        //     = 0x90CD
        MaxGeometryImageUniformsOes = 37069,
        //
        // Summary:
        //     Original was GL_SHADER_STORAGE_BUFFER = 0x90D2
        ShaderStorageBuffer = 37074,
        //
        // Summary:
        //     [requires: EXT_geometry_shader] Original was GL_MAX_GEOMETRY_SHADER_STORAGE_BLOCKS_EXT
        //     = 0x90D7
        MaxGeometryShaderStorageBlocksExt = 37079,
        //
        // Summary:
        //     [requires: OES_geometry_shader] Original was GL_MAX_GEOMETRY_SHADER_STORAGE_BLOCKS_OES
        //     = 0x90D7
        MaxGeometryShaderStorageBlocksOes = 37079,
        //
        // Summary:
        //     [requires: EXT_tessellation_shader] Original was GL_MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS_EXT
        //     = 0x90D8
        MaxTessControlShaderStorageBlocksExt = 37080,
        //
        // Summary:
        //     [requires: OES_tessellation_shader] Original was GL_MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS_OES
        //     = 0x90D8
        MaxTessControlShaderStorageBlocksOes = 37080,
        //
        // Summary:
        //     [requires: EXT_tessellation_shader] Original was GL_MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS_EXT
        //     = 0x90D9
        MaxTessEvaluationShaderStorageBlocksExt = 37081,
        //
        // Summary:
        //     [requires: OES_tessellation_shader] Original was GL_MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS_OES
        //     = 0x90D9
        MaxTessEvaluationShaderStorageBlocksOes = 37081,
        //
        // Summary:
        //     Original was GL_DEPTH_STENCIL_TEXTURE_MODE = 0x90EA
        DepthStencilTextureMode = 37098,
        //
        // Summary:
        //     Original was GL_UNIFORM_BLOCK_REFERENCED_BY_COMPUTE_SHADER = 0x90EC
        UniformBlockReferencedByComputeShader = 37100,
        //
        // Summary:
        //     Original was GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_COMPUTE_SHADER = 0x90ED
        AtomicCounterBufferReferencedByComputeShader = 37101,
        //
        // Summary:
        //     Original was GL_DISPATCH_INDIRECT_BUFFER = 0x90EE
        DispatchIndirectBuffer = 37102,
        //
        // Summary:
        //     [requires: EXT_multiview_draw_buffers] Original was GL_COLOR_ATTACHMENT_EXT =
        //     0x90F0
        ColorAttachmentExt = 37104,
        //
        // Summary:
        //     [requires: EXT_multiview_draw_buffers] Original was GL_MULTIVIEW_EXT = 0x90F1
        MultiviewExt = 37105,
        //
        // Summary:
        //     [requires: EXT_multiview_draw_buffers] Original was GL_MAX_MULTIVIEW_BUFFERS_EXT
        //     = 0x90F2
        MaxMultiviewBuffersExt = 37106,
        //
        // Summary:
        //     [requires: KHR_robustness] Original was GL_CONTEXT_ROBUST_ACCESS = 0x90F3
        ContextRobustAccess = 37107,
        //
        // Summary:
        //     [requires: EXT_robustness] Original was GL_CONTEXT_ROBUST_ACCESS_EXT = 0x90F3
        ContextRobustAccessExt = 37107,
        //
        // Summary:
        //     [requires: KHR_robustness] Original was GL_CONTEXT_ROBUST_ACCESS_KHR = 0x90F3
        ContextRobustAccessKhr = 37107,
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
        //     [requires: OES_texture_storage_multisample_2d_array] Original was GL_TEXTURE_2D_MULTISAMPLE_ARRAY_OES
        //     = 0x9102
        Texture2DMultisampleArrayOes = 37122,
        //
        // Summary:
        //     Original was GL_PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9103
        ProxyTexture2DMultisampleArray = 37123,
        //
        // Summary:
        //     [requires: OES_texture_storage_multisample_2d_array] Original was GL_TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY_OES
        //     = 0x9105
        TextureBinding2DMultisampleArrayOes = 37125,
        //
        // Summary:
        //     [requires: OES_texture_storage_multisample_2d_array] Original was GL_SAMPLER_2D_MULTISAMPLE_ARRAY_OES
        //     = 0x910B
        Sampler2DMultisampleArrayOes = 37131,
        //
        // Summary:
        //     [requires: OES_texture_storage_multisample_2d_array] Original was GL_INT_SAMPLER_2D_MULTISAMPLE_ARRAY_OES
        //     = 0x910C
        IntSampler2DMultisampleArrayOes = 37132,
        //
        // Summary:
        //     [requires: OES_texture_storage_multisample_2d_array] Original was GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY_OES
        //     = 0x910D
        UnsignedIntSampler2DMultisampleArrayOes = 37133,
        //
        // Summary:
        //     Original was GL_MAX_SERVER_WAIT_TIMEOUT = 0x9111
        MaxServerWaitTimeout = 37137,
        //
        // Summary:
        //     [requires: APPLE_sync] Original was GL_MAX_SERVER_WAIT_TIMEOUT_APPLE = 0x9111
        MaxServerWaitTimeoutApple = 37137,
        //
        // Summary:
        //     Original was GL_OBJECT_TYPE = 0x9112
        ObjectType = 37138,
        //
        // Summary:
        //     [requires: APPLE_sync] Original was GL_OBJECT_TYPE_APPLE = 0x9112
        ObjectTypeApple = 37138,
        //
        // Summary:
        //     Original was GL_SYNC_CONDITION = 0x9113
        SyncCondition = 37139,
        //
        // Summary:
        //     [requires: APPLE_sync] Original was GL_SYNC_CONDITION_APPLE = 0x9113
        SyncConditionApple = 37139,
        //
        // Summary:
        //     Original was GL_SYNC_STATUS = 0x9114
        SyncStatus = 37140,
        //
        // Summary:
        //     [requires: APPLE_sync] Original was GL_SYNC_STATUS_APPLE = 0x9114
        SyncStatusApple = 37140,
        //
        // Summary:
        //     Original was GL_SYNC_FLAGS = 0x9115
        SyncFlags = 37141,
        //
        // Summary:
        //     [requires: APPLE_sync] Original was GL_SYNC_FLAGS_APPLE = 0x9115
        SyncFlagsApple = 37141,
        //
        // Summary:
        //     Original was GL_SYNC_FENCE = 0x9116
        SyncFence = 37142,
        //
        // Summary:
        //     [requires: APPLE_sync] Original was GL_SYNC_FENCE_APPLE = 0x9116
        SyncFenceApple = 37142,
        //
        // Summary:
        //     Original was GL_SYNC_GPU_COMMANDS_COMPLETE = 0x9117
        SyncGpuCommandsComplete = 37143,
        //
        // Summary:
        //     [requires: APPLE_sync] Original was GL_SYNC_GPU_COMMANDS_COMPLETE_APPLE = 0x9117
        SyncGpuCommandsCompleteApple = 37143,
        //
        // Summary:
        //     Original was GL_UNSIGNALED = 0x9118
        Unsignaled = 37144,
        //
        // Summary:
        //     [requires: APPLE_sync] Original was GL_UNSIGNALED_APPLE = 0x9118
        UnsignaledApple = 37144,
        //
        // Summary:
        //     Original was GL_SIGNALED = 0x9119
        Signaled = 37145,
        //
        // Summary:
        //     [requires: APPLE_sync] Original was GL_SIGNALED_APPLE = 0x9119
        SignaledApple = 37145,
        //
        // Summary:
        //     Original was GL_ALREADY_SIGNALED = 0x911A
        AlreadySignaled = 37146,
        //
        // Summary:
        //     [requires: APPLE_sync] Original was GL_ALREADY_SIGNALED_APPLE = 0x911A
        AlreadySignaledApple = 37146,
        //
        // Summary:
        //     Original was GL_TIMEOUT_EXPIRED = 0x911B
        TimeoutExpired = 37147,
        //
        // Summary:
        //     [requires: APPLE_sync] Original was GL_TIMEOUT_EXPIRED_APPLE = 0x911B
        TimeoutExpiredApple = 37147,
        //
        // Summary:
        //     Original was GL_CONDITION_SATISFIED = 0x911C
        ConditionSatisfied = 37148,
        //
        // Summary:
        //     [requires: APPLE_sync] Original was GL_CONDITION_SATISFIED_APPLE = 0x911C
        ConditionSatisfiedApple = 37148,
        //
        // Summary:
        //     Original was GL_WAIT_FAILED = 0x911D
        WaitFailed = 37149,
        //
        // Summary:
        //     [requires: APPLE_sync] Original was GL_WAIT_FAILED_APPLE = 0x911D
        WaitFailedApple = 37149,
        //
        // Summary:
        //     Original was GL_BUFFER_ACCESS_FLAGS = 0x911F
        BufferAccessFlags = 37151,
        //
        // Summary:
        //     Original was GL_BUFFER_MAP_LENGTH = 0x9120
        BufferMapLength = 37152,
        //
        // Summary:
        //     Original was GL_BUFFER_MAP_OFFSET = 0x9121
        BufferMapOffset = 37153,
        //
        // Summary:
        //     Original was GL_MAX_VERTEX_OUTPUT_COMPONENTS = 0x9122
        MaxVertexOutputComponents = 37154,
        //
        // Summary:
        //     [requires: EXT_geometry_shader] Original was GL_MAX_GEOMETRY_INPUT_COMPONENTS_EXT
        //     = 0x9123
        MaxGeometryInputComponentsExt = 37155,
        //
        // Summary:
        //     [requires: OES_geometry_shader] Original was GL_MAX_GEOMETRY_INPUT_COMPONENTS_OES
        //     = 0x9123
        MaxGeometryInputComponentsOes = 37155,
        //
        // Summary:
        //     [requires: EXT_geometry_shader] Original was GL_MAX_GEOMETRY_OUTPUT_COMPONENTS_EXT
        //     = 0x9124
        MaxGeometryOutputComponentsExt = 37156,
        //
        // Summary:
        //     [requires: OES_geometry_shader] Original was GL_MAX_GEOMETRY_OUTPUT_COMPONENTS_OES
        //     = 0x9124
        MaxGeometryOutputComponentsOes = 37156,
        //
        // Summary:
        //     Original was GL_MAX_FRAGMENT_INPUT_COMPONENTS = 0x9125
        MaxFragmentInputComponents = 37157,
        //
        // Summary:
        //     Original was GL_TEXTURE_IMMUTABLE_FORMAT = 0x912F
        TextureImmutableFormat = 37167,
        //
        // Summary:
        //     [requires: EXT_texture_storage] Original was GL_TEXTURE_IMMUTABLE_FORMAT_EXT
        //     = 0x912F
        TextureImmutableFormatExt = 37167,
        //
        // Summary:
        //     [requires: IMG_program_binary] Original was GL_SGX_PROGRAM_BINARY_IMG = 0x9130
        SgxProgramBinaryImg = 37168,
        //
        // Summary:
        //     [requires: IMG_multisampled_render_to_texture] Original was GL_RENDERBUFFER_SAMPLES_IMG
        //     = 0x9133
        RenderbufferSamplesImg = 37171,
        //
        // Summary:
        //     [requires: IMG_multisampled_render_to_texture] Original was GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_IMG
        //     = 0x9134
        FramebufferIncompleteMultisampleImg = 37172,
        //
        // Summary:
        //     [requires: IMG_multisampled_render_to_texture] Original was GL_MAX_SAMPLES_IMG
        //     = 0x9135
        MaxSamplesImg = 37173,
        //
        // Summary:
        //     [requires: IMG_multisampled_render_to_texture] Original was GL_TEXTURE_SAMPLES_IMG
        //     = 0x9136
        TextureSamplesImg = 37174,
        //
        // Summary:
        //     [requires: IMG_texture_compression_pvrtc2] Original was GL_COMPRESSED_RGBA_PVRTC_2BPPV2_IMG
        //     = 0x9137
        CompressedRgbaPvrtc2Bppv2Img = 37175,
        //
        // Summary:
        //     [requires: IMG_texture_compression_pvrtc2] Original was GL_COMPRESSED_RGBA_PVRTC_4BPPV2_IMG
        //     = 0x9138
        CompressedRgbaPvrtc4Bppv2Img = 37176,
        //
        // Summary:
        //     [requires: IMG_texture_filter_cubic] Original was GL_CUBIC_IMG = 0x9139
        CubicImg = 37177,
        //
        // Summary:
        //     [requires: IMG_texture_filter_cubic] Original was GL_CUBIC_MIPMAP_NEAREST_IMG
        //     = 0x913A
        CubicMipmapNearestImg = 37178,
        //
        // Summary:
        //     [requires: IMG_texture_filter_cubic] Original was GL_CUBIC_MIPMAP_LINEAR_IMG
        //     = 0x913B
        CubicMipmapLinearImg = 37179,
        //
        // Summary:
        //     [requires: IMG_framebuffer_downsample] Original was GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_AND_DOWNSAMPLE_IMG
        //     = 0x913C
        FramebufferIncompleteMultisampleAndDownsampleImg = 37180,
        //
        // Summary:
        //     [requires: IMG_framebuffer_downsample] Original was GL_NUM_DOWNSAMPLE_SCALES_IMG
        //     = 0x913D
        NumDownsampleScalesImg = 37181,
        //
        // Summary:
        //     [requires: IMG_framebuffer_downsample] Original was GL_DOWNSAMPLE_SCALES_IMG
        //     = 0x913E
        DownsampleScalesImg = 37182,
        //
        // Summary:
        //     [requires: IMG_framebuffer_downsample] Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_SCALE_IMG
        //     = 0x913F
        FramebufferAttachmentTextureScaleImg = 37183,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_MAX_DEBUG_MESSAGE_LENGTH = 0x9143
        MaxDebugMessageLength = 37187,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_MAX_DEBUG_MESSAGE_LENGTH_KHR = 0x9143
        MaxDebugMessageLengthKhr = 37187,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_MAX_DEBUG_LOGGED_MESSAGES = 0x9144
        MaxDebugLoggedMessages = 37188,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_MAX_DEBUG_LOGGED_MESSAGES_KHR = 0x9144
        MaxDebugLoggedMessagesKhr = 37188,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_DEBUG_LOGGED_MESSAGES = 0x9145
        DebugLoggedMessages = 37189,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_DEBUG_LOGGED_MESSAGES_KHR = 0x9145
        DebugLoggedMessagesKhr = 37189,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_DEBUG_SEVERITY_HIGH = 0x9146
        DebugSeverityHigh = 37190,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_DEBUG_SEVERITY_HIGH_KHR = 0x9146
        DebugSeverityHighKhr = 37190,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_DEBUG_SEVERITY_MEDIUM = 0x9147
        DebugSeverityMedium = 37191,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_DEBUG_SEVERITY_MEDIUM_KHR = 0x9147
        DebugSeverityMediumKhr = 37191,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_DEBUG_SEVERITY_LOW = 0x9148
        DebugSeverityLow = 37192,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_DEBUG_SEVERITY_LOW_KHR = 0x9148
        DebugSeverityLowKhr = 37192,
        //
        // Summary:
        //     [requires: EXT_debug_label] Original was GL_BUFFER_OBJECT_EXT = 0x9151
        BufferObjectExt = 37201,
        //
        // Summary:
        //     [requires: EXT_debug_label] Original was GL_QUERY_OBJECT_EXT = 0x9153
        QueryObjectExt = 37203,
        //
        // Summary:
        //     [requires: EXT_debug_label] Original was GL_VERTEX_ARRAY_OBJECT_EXT = 0x9154
        VertexArrayObjectExt = 37204,
        //
        // Summary:
        //     Original was GL_QUERY_BUFFER = 0x9192
        QueryBuffer = 37266,
        //
        // Summary:
        //     Original was GL_QUERY_RESULT_NO_WAIT = 0x9194
        QueryResultNoWait = 37268,
        //
        // Summary:
        //     [requires: EXT_sparse_texture] Original was GL_VIRTUAL_PAGE_SIZE_X_EXT = 0x9195
        VirtualPageSizeXExt = 37269,
        //
        // Summary:
        //     [requires: EXT_sparse_texture] Original was GL_VIRTUAL_PAGE_SIZE_Y_EXT = 0x9196
        VirtualPageSizeYExt = 37270,
        //
        // Summary:
        //     [requires: EXT_sparse_texture] Original was GL_VIRTUAL_PAGE_SIZE_Z_EXT = 0x9197
        VirtualPageSizeZExt = 37271,
        //
        // Summary:
        //     [requires: EXT_sparse_texture] Original was GL_MAX_SPARSE_TEXTURE_SIZE_EXT =
        //     0x9198
        MaxSparseTextureSizeExt = 37272,
        //
        // Summary:
        //     [requires: EXT_sparse_texture] Original was GL_MAX_SPARSE_3D_TEXTURE_SIZE_EXT
        //     = 0x9199
        MaxSparse3DTextureSizeExt = 37273,
        //
        // Summary:
        //     [requires: EXT_sparse_texture] Original was GL_MAX_SPARSE_ARRAY_TEXTURE_LAYERS_EXT
        //     = 0x919A
        MaxSparseArrayTextureLayersExt = 37274,
        //
        // Summary:
        //     [requires: EXT_texture_buffer] Original was GL_TEXTURE_BUFFER_OFFSET_EXT = 0x919D
        TextureBufferOffsetExt = 37277,
        //
        // Summary:
        //     [requires: OES_texture_buffer] Original was GL_TEXTURE_BUFFER_OFFSET_OES = 0x919D
        TextureBufferOffsetOes = 37277,
        //
        // Summary:
        //     [requires: EXT_texture_buffer] Original was GL_TEXTURE_BUFFER_SIZE_EXT = 0x919E
        TextureBufferSizeExt = 37278,
        //
        // Summary:
        //     [requires: OES_texture_buffer] Original was GL_TEXTURE_BUFFER_SIZE_OES = 0x919E
        TextureBufferSizeOes = 37278,
        //
        // Summary:
        //     [requires: EXT_texture_buffer] Original was GL_TEXTURE_BUFFER_OFFSET_ALIGNMENT_EXT
        //     = 0x919F
        TextureBufferOffsetAlignmentExt = 37279,
        //
        // Summary:
        //     [requires: OES_texture_buffer] Original was GL_TEXTURE_BUFFER_OFFSET_ALIGNMENT_OES
        //     = 0x919F
        TextureBufferOffsetAlignmentOes = 37279,
        //
        // Summary:
        //     [requires: EXT_sparse_texture] Original was GL_TEXTURE_SPARSE_EXT = 0x91A6
        TextureSparseExt = 37286,
        //
        // Summary:
        //     [requires: EXT_sparse_texture] Original was GL_VIRTUAL_PAGE_SIZE_INDEX_EXT =
        //     0x91A7
        VirtualPageSizeIndexExt = 37287,
        //
        // Summary:
        //     [requires: EXT_sparse_texture] Original was GL_NUM_VIRTUAL_PAGE_SIZES_EXT = 0x91A8
        NumVirtualPageSizesExt = 37288,
        //
        // Summary:
        //     [requires: EXT_sparse_texture] Original was GL_SPARSE_TEXTURE_FULL_ARRAY_CUBE_MIPMAPS_EXT
        //     = 0x91A9
        SparseTextureFullArrayCubeMipmapsExt = 37289,
        //
        // Summary:
        //     [requires: EXT_sparse_texture] Original was GL_NUM_SPARSE_LEVELS_EXT = 0x91AA
        NumSparseLevelsExt = 37290,
        //
        // Summary:
        //     [requires: KHR_parallel_shader_compile] Original was GL_MAX_SHADER_COMPILER_THREADS_KHR
        //     = 0x91B0
        MaxShaderCompilerThreadsKhr = 37296,
        //
        // Summary:
        //     [requires: KHR_parallel_shader_compile] Original was GL_COMPLETION_STATUS_KHR
        //     = 0x91B1
        CompletionStatusKhr = 37297,
        //
        // Summary:
        //     Original was GL_COMPUTE_SHADER = 0x91B9
        ComputeShader = 37305,
        //
        // Summary:
        //     Original was GL_SHADER_BINARY_DMP = 0x9250
        ShaderBinaryDmp = 37456,
        //
        // Summary:
        //     Original was GL_SMAPHS30_PROGRAM_BINARY_DMP = 0x9251
        Smaphs30ProgramBinaryDmp = 37457,
        //
        // Summary:
        //     Original was GL_SMAPHS_PROGRAM_BINARY_DMP = 0x9252
        SmaphsProgramBinaryDmp = 37458,
        //
        // Summary:
        //     Original was GL_DMP_PROGRAM_BINARY_DMP = 0x9253
        DmpProgramBinaryDmp = 37459,
        //
        // Summary:
        //     Original was GL_GCCSO_SHADER_BINARY_FJ = 0x9260
        GccsoShaderBinaryFj = 37472,
        //
        // Summary:
        //     Original was GL_COMPRESSED_R11_EAC = 0x9270
        CompressedR11Eac = 37488,
        //
        // Summary:
        //     Original was GL_COMPRESSED_SIGNED_R11_EAC = 0x9271
        CompressedSignedR11Eac = 37489,
        //
        // Summary:
        //     Original was GL_COMPRESSED_RG11_EAC = 0x9272
        CompressedRg11Eac = 37490,
        //
        // Summary:
        //     Original was GL_COMPRESSED_SIGNED_RG11_EAC = 0x9273
        CompressedSignedRg11Eac = 37491,
        //
        // Summary:
        //     Original was GL_COMPRESSED_RGB8_ETC2 = 0x9274
        CompressedRgb8Etc2 = 37492,
        //
        // Summary:
        //     Original was GL_COMPRESSED_SRGB8_ETC2 = 0x9275
        CompressedSrgb8Etc2 = 37493,
        //
        // Summary:
        //     Original was GL_COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9276
        CompressedRgb8PunchthroughAlpha1Etc2 = 37494,
        //
        // Summary:
        //     Original was GL_COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9277
        CompressedSrgb8PunchthroughAlpha1Etc2 = 37495,
        //
        // Summary:
        //     Original was GL_COMPRESSED_RGBA8_ETC2_EAC = 0x9278
        CompressedRgba8Etc2Eac = 37496,
        //
        // Summary:
        //     Original was GL_COMPRESSED_SRGB8_ALPHA8_ETC2_EAC = 0x9279
        CompressedSrgb8Alpha8Etc2Eac = 37497,
        //
        // Summary:
        //     [requires: NV_blend_equation_advanced] Original was GL_BLEND_PREMULTIPLIED_SRC_NV
        //     = 0x9280
        BlendPremultipliedSrcNv = 37504,
        //
        // Summary:
        //     [requires: NV_blend_equation_advanced] Original was GL_BLEND_OVERLAP_NV = 0x9281
        BlendOverlapNv = 37505,
        //
        // Summary:
        //     [requires: NV_blend_equation_advanced] Original was GL_UNCORRELATED_NV = 0x9282
        UncorrelatedNv = 37506,
        //
        // Summary:
        //     [requires: NV_blend_equation_advanced] Original was GL_DISJOINT_NV = 0x9283
        DisjointNv = 37507,
        //
        // Summary:
        //     [requires: NV_blend_equation_advanced] Original was GL_CONJOINT_NV = 0x9284
        ConjointNv = 37508,
        //
        // Summary:
        //     [requires: KHR_blend_equation_advanced, or KHR_blend_equation_advanced_coherent]
        //     Original was GL_BLEND_ADVANCED_COHERENT_KHR = 0x9285
        BlendAdvancedCoherentKhr = 37509,
        //
        // Summary:
        //     [requires: NV_blend_equation_advanced_coherent] Original was GL_BLEND_ADVANCED_COHERENT_NV
        //     = 0x9285
        BlendAdvancedCoherentNv = 37509,
        //
        // Summary:
        //     [requires: NV_blend_equation_advanced] Original was GL_SRC_NV = 0x9286
        SrcNv = 37510,
        //
        // Summary:
        //     [requires: NV_blend_equation_advanced] Original was GL_DST_NV = 0x9287
        DstNv = 37511,
        //
        // Summary:
        //     [requires: NV_blend_equation_advanced] Original was GL_SRC_OVER_NV = 0x9288
        SrcOverNv = 37512,
        //
        // Summary:
        //     [requires: NV_blend_equation_advanced] Original was GL_DST_OVER_NV = 0x9289
        DstOverNv = 37513,
        //
        // Summary:
        //     [requires: NV_blend_equation_advanced] Original was GL_SRC_IN_NV = 0x928A
        SrcInNv = 37514,
        //
        // Summary:
        //     [requires: NV_blend_equation_advanced] Original was GL_DST_IN_NV = 0x928B
        DstInNv = 37515,
        //
        // Summary:
        //     [requires: NV_blend_equation_advanced] Original was GL_SRC_OUT_NV = 0x928C
        SrcOutNv = 37516,
        //
        // Summary:
        //     [requires: NV_blend_equation_advanced] Original was GL_DST_OUT_NV = 0x928D
        DstOutNv = 37517,
        //
        // Summary:
        //     [requires: NV_blend_equation_advanced] Original was GL_SRC_ATOP_NV = 0x928E
        SrcAtopNv = 37518,
        //
        // Summary:
        //     [requires: NV_blend_equation_advanced] Original was GL_DST_ATOP_NV = 0x928F
        DstAtopNv = 37519,
        //
        // Summary:
        //     [requires: NV_blend_equation_advanced] Original was GL_PLUS_NV = 0x9291
        PlusNv = 37521,
        //
        // Summary:
        //     [requires: NV_blend_equation_advanced] Original was GL_PLUS_DARKER_NV = 0x9292
        PlusDarkerNv = 37522,
        //
        // Summary:
        //     [requires: KHR_blend_equation_advanced] Original was GL_MULTIPLY_KHR = 0x9294
        MultiplyKhr = 37524,
        //
        // Summary:
        //     [requires: NV_blend_equation_advanced] Original was GL_MULTIPLY_NV = 0x9294
        MultiplyNv = 37524,
        //
        // Summary:
        //     [requires: KHR_blend_equation_advanced] Original was GL_SCREEN_KHR = 0x9295
        ScreenKhr = 37525,
        //
        // Summary:
        //     [requires: NV_blend_equation_advanced] Original was GL_SCREEN_NV = 0x9295
        ScreenNv = 37525,
        //
        // Summary:
        //     [requires: KHR_blend_equation_advanced] Original was GL_OVERLAY_KHR = 0x9296
        OverlayKhr = 37526,
        //
        // Summary:
        //     [requires: NV_blend_equation_advanced] Original was GL_OVERLAY_NV = 0x9296
        OverlayNv = 37526,
        //
        // Summary:
        //     [requires: KHR_blend_equation_advanced] Original was GL_DARKEN_KHR = 0x9297
        DarkenKhr = 37527,
        //
        // Summary:
        //     [requires: NV_blend_equation_advanced] Original was GL_DARKEN_NV = 0x9297
        DarkenNv = 37527,
        //
        // Summary:
        //     [requires: KHR_blend_equation_advanced] Original was GL_LIGHTEN_KHR = 0x9298
        LightenKhr = 37528,
        //
        // Summary:
        //     [requires: NV_blend_equation_advanced] Original was GL_LIGHTEN_NV = 0x9298
        LightenNv = 37528,
        //
        // Summary:
        //     [requires: KHR_blend_equation_advanced] Original was GL_COLORDODGE_KHR = 0x9299
        ColordodgeKhr = 37529,
        //
        // Summary:
        //     [requires: NV_blend_equation_advanced] Original was GL_COLORDODGE_NV = 0x9299
        ColordodgeNv = 37529,
        //
        // Summary:
        //     [requires: KHR_blend_equation_advanced] Original was GL_COLORBURN_KHR = 0x929A
        ColorburnKhr = 37530,
        //
        // Summary:
        //     [requires: NV_blend_equation_advanced] Original was GL_COLORBURN_NV = 0x929A
        ColorburnNv = 37530,
        //
        // Summary:
        //     [requires: KHR_blend_equation_advanced] Original was GL_HARDLIGHT_KHR = 0x929B
        HardlightKhr = 37531,
        //
        // Summary:
        //     [requires: NV_blend_equation_advanced] Original was GL_HARDLIGHT_NV = 0x929B
        HardlightNv = 37531,
        //
        // Summary:
        //     [requires: KHR_blend_equation_advanced] Original was GL_SOFTLIGHT_KHR = 0x929C
        SoftlightKhr = 37532,
        //
        // Summary:
        //     [requires: NV_blend_equation_advanced] Original was GL_SOFTLIGHT_NV = 0x929C
        SoftlightNv = 37532,
        //
        // Summary:
        //     [requires: KHR_blend_equation_advanced] Original was GL_DIFFERENCE_KHR = 0x929E
        DifferenceKhr = 37534,
        //
        // Summary:
        //     [requires: NV_blend_equation_advanced] Original was GL_DIFFERENCE_NV = 0x929E
        DifferenceNv = 37534,
        //
        // Summary:
        //     [requires: NV_blend_equation_advanced] Original was GL_MINUS_NV = 0x929F
        MinusNv = 37535,
        //
        // Summary:
        //     [requires: KHR_blend_equation_advanced] Original was GL_EXCLUSION_KHR = 0x92A0
        ExclusionKhr = 37536,
        //
        // Summary:
        //     [requires: NV_blend_equation_advanced] Original was GL_EXCLUSION_NV = 0x92A0
        ExclusionNv = 37536,
        //
        // Summary:
        //     [requires: NV_blend_equation_advanced] Original was GL_CONTRAST_NV = 0x92A1
        ContrastNv = 37537,
        //
        // Summary:
        //     [requires: NV_blend_equation_advanced] Original was GL_INVERT_RGB_NV = 0x92A3
        InvertRgbNv = 37539,
        //
        // Summary:
        //     [requires: NV_blend_equation_advanced] Original was GL_LINEARDODGE_NV = 0x92A4
        LineardodgeNv = 37540,
        //
        // Summary:
        //     [requires: NV_blend_equation_advanced] Original was GL_LINEARBURN_NV = 0x92A5
        LinearburnNv = 37541,
        //
        // Summary:
        //     [requires: NV_blend_equation_advanced] Original was GL_VIVIDLIGHT_NV = 0x92A6
        VividlightNv = 37542,
        //
        // Summary:
        //     [requires: NV_blend_equation_advanced] Original was GL_LINEARLIGHT_NV = 0x92A7
        LinearlightNv = 37543,
        //
        // Summary:
        //     [requires: NV_blend_equation_advanced] Original was GL_PINLIGHT_NV = 0x92A8
        PinlightNv = 37544,
        //
        // Summary:
        //     [requires: NV_blend_equation_advanced] Original was GL_HARDMIX_NV = 0x92A9
        HardmixNv = 37545,
        //
        // Summary:
        //     [requires: KHR_blend_equation_advanced] Original was GL_HSL_HUE_KHR = 0x92AD
        HslHueKhr = 37549,
        //
        // Summary:
        //     [requires: NV_blend_equation_advanced] Original was GL_HSL_HUE_NV = 0x92AD
        HslHueNv = 37549,
        //
        // Summary:
        //     [requires: KHR_blend_equation_advanced] Original was GL_HSL_SATURATION_KHR =
        //     0x92AE
        HslSaturationKhr = 37550,
        //
        // Summary:
        //     [requires: NV_blend_equation_advanced] Original was GL_HSL_SATURATION_NV = 0x92AE
        HslSaturationNv = 37550,
        //
        // Summary:
        //     [requires: KHR_blend_equation_advanced] Original was GL_HSL_COLOR_KHR = 0x92AF
        HslColorKhr = 37551,
        //
        // Summary:
        //     [requires: NV_blend_equation_advanced] Original was GL_HSL_COLOR_NV = 0x92AF
        HslColorNv = 37551,
        //
        // Summary:
        //     [requires: KHR_blend_equation_advanced] Original was GL_HSL_LUMINOSITY_KHR =
        //     0x92B0
        HslLuminosityKhr = 37552,
        //
        // Summary:
        //     [requires: NV_blend_equation_advanced] Original was GL_HSL_LUMINOSITY_NV = 0x92B0
        HslLuminosityNv = 37552,
        //
        // Summary:
        //     [requires: NV_blend_equation_advanced] Original was GL_PLUS_CLAMPED_NV = 0x92B1
        PlusClampedNv = 37553,
        //
        // Summary:
        //     [requires: NV_blend_equation_advanced] Original was GL_PLUS_CLAMPED_ALPHA_NV
        //     = 0x92B2
        PlusClampedAlphaNv = 37554,
        //
        // Summary:
        //     [requires: NV_blend_equation_advanced] Original was GL_MINUS_CLAMPED_NV = 0x92B3
        MinusClampedNv = 37555,
        //
        // Summary:
        //     [requires: NV_blend_equation_advanced] Original was GL_INVERT_OVG_NV = 0x92B4
        InvertOvgNv = 37556,
        //
        // Summary:
        //     [requires: EXT_primitive_bounding_box] Original was GL_PRIMITIVE_BOUNDING_BOX_EXT
        //     = 0x92BE
        PrimitiveBoundingBoxExt = 37566,
        //
        // Summary:
        //     [requires: OES_primitive_bounding_box] Original was GL_PRIMITIVE_BOUNDING_BOX_OES
        //     = 0x92BE
        PrimitiveBoundingBoxOes = 37566,
        //
        // Summary:
        //     Original was GL_ATOMIC_COUNTER_BUFFER = 0x92C0
        AtomicCounterBuffer = 37568,
        //
        // Summary:
        //     Original was GL_ATOMIC_COUNTER_BUFFER_BINDING = 0x92C1
        AtomicCounterBufferBinding = 37569,
        //
        // Summary:
        //     Original was GL_ATOMIC_COUNTER_BUFFER_DATA_SIZE = 0x92C4
        AtomicCounterBufferDataSize = 37572,
        //
        // Summary:
        //     Original was GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTERS = 0x92C5
        AtomicCounterBufferActiveAtomicCounters = 37573,
        //
        // Summary:
        //     Original was GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTER_INDICES = 0x92C6
        AtomicCounterBufferActiveAtomicCounterIndices = 37574,
        //
        // Summary:
        //     Original was GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_VERTEX_SHADER = 0x92C7
        AtomicCounterBufferReferencedByVertexShader = 37575,
        //
        // Summary:
        //     Original was GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_CONTROL_SHADER = 0x92C8
        AtomicCounterBufferReferencedByTessControlShader = 37576,
        //
        // Summary:
        //     Original was GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_EVALUATION_SHADER =
        //     0x92C9
        AtomicCounterBufferReferencedByTessEvaluationShader = 37577,
        //
        // Summary:
        //     Original was GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_GEOMETRY_SHADER = 0x92CA
        AtomicCounterBufferReferencedByGeometryShader = 37578,
        //
        // Summary:
        //     Original was GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_FRAGMENT_SHADER = 0x92CB
        AtomicCounterBufferReferencedByFragmentShader = 37579,
        //
        // Summary:
        //     [requires: EXT_tessellation_shader] Original was GL_MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS_EXT
        //     = 0x92CD
        MaxTessControlAtomicCounterBuffersExt = 37581,
        //
        // Summary:
        //     [requires: OES_tessellation_shader] Original was GL_MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS_OES
        //     = 0x92CD
        MaxTessControlAtomicCounterBuffersOes = 37581,
        //
        // Summary:
        //     [requires: EXT_tessellation_shader] Original was GL_MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS_EXT
        //     = 0x92CE
        MaxTessEvaluationAtomicCounterBuffersExt = 37582,
        //
        // Summary:
        //     [requires: OES_tessellation_shader] Original was GL_MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS_OES
        //     = 0x92CE
        MaxTessEvaluationAtomicCounterBuffersOes = 37582,
        //
        // Summary:
        //     [requires: EXT_geometry_shader] Original was GL_MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS_EXT
        //     = 0x92CF
        MaxGeometryAtomicCounterBuffersExt = 37583,
        //
        // Summary:
        //     [requires: OES_geometry_shader] Original was GL_MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS_OES
        //     = 0x92CF
        MaxGeometryAtomicCounterBuffersOes = 37583,
        //
        // Summary:
        //     [requires: EXT_tessellation_shader] Original was GL_MAX_TESS_CONTROL_ATOMIC_COUNTERS_EXT
        //     = 0x92D3
        MaxTessControlAtomicCountersExt = 37587,
        //
        // Summary:
        //     [requires: OES_tessellation_shader] Original was GL_MAX_TESS_CONTROL_ATOMIC_COUNTERS_OES
        //     = 0x92D3
        MaxTessControlAtomicCountersOes = 37587,
        //
        // Summary:
        //     [requires: EXT_tessellation_shader] Original was GL_MAX_TESS_EVALUATION_ATOMIC_COUNTERS_EXT
        //     = 0x92D4
        MaxTessEvaluationAtomicCountersExt = 37588,
        //
        // Summary:
        //     [requires: OES_tessellation_shader] Original was GL_MAX_TESS_EVALUATION_ATOMIC_COUNTERS_OES
        //     = 0x92D4
        MaxTessEvaluationAtomicCountersOes = 37588,
        //
        // Summary:
        //     [requires: EXT_geometry_shader] Original was GL_MAX_GEOMETRY_ATOMIC_COUNTERS_EXT
        //     = 0x92D5
        MaxGeometryAtomicCountersExt = 37589,
        //
        // Summary:
        //     [requires: OES_geometry_shader] Original was GL_MAX_GEOMETRY_ATOMIC_COUNTERS_OES
        //     = 0x92D5
        MaxGeometryAtomicCountersOes = 37589,
        //
        // Summary:
        //     Original was GL_ACTIVE_ATOMIC_COUNTER_BUFFERS = 0x92D9
        ActiveAtomicCounterBuffers = 37593,
        //
        // Summary:
        //     Original was GL_UNIFORM_ATOMIC_COUNTER_BUFFER_INDEX = 0x92DA
        UniformAtomicCounterBufferIndex = 37594,
        //
        // Summary:
        //     [requires: NV_fragment_coverage_to_color] Original was GL_FRAGMENT_COVERAGE_TO_COLOR_NV
        //     = 0x92DD
        FragmentCoverageToColorNv = 37597,
        //
        // Summary:
        //     [requires: NV_fragment_coverage_to_color] Original was GL_FRAGMENT_COVERAGE_COLOR_NV
        //     = 0x92DE
        FragmentCoverageColorNv = 37598,
        //
        // Summary:
        //     [requires: NV_mesh_shader] Original was GL_MESH_OUTPUT_PER_VERTEX_GRANULARITY_NV
        //     = 0x92DF
        MeshOutputPerVertexGranularityNv = 37599,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_DEBUG_OUTPUT = 0x92E0
        DebugOutput = 37600,
        //
        // Summary:
        //     [requires: KHR_debug] Original was GL_DEBUG_OUTPUT_KHR = 0x92E0
        DebugOutputKhr = 37600,
        //
        // Summary:
        //     Original was GL_UNIFORM = 0x92E1
        Uniform = 37601,
        //
        // Summary:
        //     Original was GL_UNIFORM_BLOCK = 0x92E2
        UniformBlock = 37602,
        //
        // Summary:
        //     Original was GL_PROGRAM_INPUT = 0x92E3
        ProgramInput = 37603,
        //
        // Summary:
        //     Original was GL_PROGRAM_OUTPUT = 0x92E4
        ProgramOutput = 37604,
        //
        // Summary:
        //     Original was GL_BUFFER_VARIABLE = 0x92E5
        BufferVariable = 37605,
        //
        // Summary:
        //     Original was GL_SHADER_STORAGE_BLOCK = 0x92E6
        ShaderStorageBlock = 37606,
        //
        // Summary:
        //     [requires: EXT_tessellation_shader] Original was GL_IS_PER_PATCH_EXT = 0x92E7
        IsPerPatchExt = 37607,
        //
        // Summary:
        //     [requires: OES_tessellation_shader] Original was GL_IS_PER_PATCH_OES = 0x92E7
        IsPerPatchOes = 37607,
        //
        // Summary:
        //     Original was GL_VERTEX_SUBROUTINE = 0x92E8
        VertexSubroutine = 37608,
        //
        // Summary:
        //     Original was GL_TESS_CONTROL_SUBROUTINE = 0x92E9
        TessControlSubroutine = 37609,
        //
        // Summary:
        //     Original was GL_TESS_EVALUATION_SUBROUTINE = 0x92EA
        TessEvaluationSubroutine = 37610,
        //
        // Summary:
        //     Original was GL_GEOMETRY_SUBROUTINE = 0x92EB
        GeometrySubroutine = 37611,
        //
        // Summary:
        //     Original was GL_FRAGMENT_SUBROUTINE = 0x92EC
        FragmentSubroutine = 37612,
        //
        // Summary:
        //     Original was GL_COMPUTE_SUBROUTINE = 0x92ED
        ComputeSubroutine = 37613,
        //
        // Summary:
        //     Original was GL_VERTEX_SUBROUTINE_UNIFORM = 0x92EE
        VertexSubroutineUniform = 37614,
        //
        // Summary:
        //     Original was GL_TESS_CONTROL_SUBROUTINE_UNIFORM = 0x92EF
        TessControlSubroutineUniform = 37615,
        //
        // Summary:
        //     Original was GL_TESS_EVALUATION_SUBROUTINE_UNIFORM = 0x92F0
        TessEvaluationSubroutineUniform = 37616,
        //
        // Summary:
        //     Original was GL_GEOMETRY_SUBROUTINE_UNIFORM = 0x92F1
        GeometrySubroutineUniform = 37617,
        //
        // Summary:
        //     Original was GL_FRAGMENT_SUBROUTINE_UNIFORM = 0x92F2
        FragmentSubroutineUniform = 37618,
        //
        // Summary:
        //     Original was GL_COMPUTE_SUBROUTINE_UNIFORM = 0x92F3
        ComputeSubroutineUniform = 37619,
        //
        // Summary:
        //     Original was GL_TRANSFORM_FEEDBACK_VARYING = 0x92F4
        TransformFeedbackVarying = 37620,
        //
        // Summary:
        //     Original was GL_ACTIVE_RESOURCES = 0x92F5
        ActiveResources = 37621,
        //
        // Summary:
        //     Original was GL_MAX_NAME_LENGTH = 0x92F6
        MaxNameLength = 37622,
        //
        // Summary:
        //     Original was GL_MAX_NUM_ACTIVE_VARIABLES = 0x92F7
        MaxNumActiveVariables = 37623,
        //
        // Summary:
        //     Original was GL_MAX_NUM_COMPATIBLE_SUBROUTINES = 0x92F8
        MaxNumCompatibleSubroutines = 37624,
        //
        // Summary:
        //     [requires: EXT_tessellation_shader] Original was GL_REFERENCED_BY_TESS_CONTROL_SHADER_EXT
        //     = 0x9307
        ReferencedByTessControlShaderExt = 37639,
        //
        // Summary:
        //     [requires: OES_tessellation_shader] Original was GL_REFERENCED_BY_TESS_CONTROL_SHADER_OES
        //     = 0x9307
        ReferencedByTessControlShaderOes = 37639,
        //
        // Summary:
        //     [requires: EXT_tessellation_shader] Original was GL_REFERENCED_BY_TESS_EVALUATION_SHADER_EXT
        //     = 0x9308
        ReferencedByTessEvaluationShaderExt = 37640,
        //
        // Summary:
        //     [requires: OES_tessellation_shader] Original was GL_REFERENCED_BY_TESS_EVALUATION_SHADER_OES
        //     = 0x9308
        ReferencedByTessEvaluationShaderOes = 37640,
        //
        // Summary:
        //     [requires: EXT_geometry_shader] Original was GL_REFERENCED_BY_GEOMETRY_SHADER_EXT
        //     = 0x9309
        ReferencedByGeometryShaderExt = 37641,
        //
        // Summary:
        //     [requires: OES_geometry_shader] Original was GL_REFERENCED_BY_GEOMETRY_SHADER_OES
        //     = 0x9309
        ReferencedByGeometryShaderOes = 37641,
        //
        // Summary:
        //     [requires: EXT_blend_func_extended] Original was GL_LOCATION_INDEX_EXT = 0x930F
        LocationIndexExt = 37647,
        //
        // Summary:
        //     Original was GL_FRAMEBUFFER_DEFAULT_WIDTH = 0x9310
        FramebufferDefaultWidth = 37648,
        //
        // Summary:
        //     Original was GL_FRAMEBUFFER_DEFAULT_HEIGHT = 0x9311
        FramebufferDefaultHeight = 37649,
        //
        // Summary:
        //     Original was GL_FRAMEBUFFER_DEFAULT_LAYERS = 0x9312
        FramebufferDefaultLayers = 37650,
        //
        // Summary:
        //     [requires: EXT_geometry_shader] Original was GL_FRAMEBUFFER_DEFAULT_LAYERS_EXT
        //     = 0x9312
        FramebufferDefaultLayersExt = 37650,
        //
        // Summary:
        //     [requires: OES_geometry_shader] Original was GL_FRAMEBUFFER_DEFAULT_LAYERS_OES
        //     = 0x9312
        FramebufferDefaultLayersOes = 37650,
        //
        // Summary:
        //     Original was GL_FRAMEBUFFER_DEFAULT_SAMPLES = 0x9313
        FramebufferDefaultSamples = 37651,
        //
        // Summary:
        //     Original was GL_FRAMEBUFFER_DEFAULT_FIXED_SAMPLE_LOCATIONS = 0x9314
        FramebufferDefaultFixedSampleLocations = 37652,
        //
        // Summary:
        //     [requires: EXT_geometry_shader] Original was GL_MAX_FRAMEBUFFER_LAYERS_EXT =
        //     0x9317
        MaxFramebufferLayersExt = 37655,
        //
        // Summary:
        //     [requires: OES_geometry_shader] Original was GL_MAX_FRAMEBUFFER_LAYERS_OES =
        //     0x9317
        MaxFramebufferLayersOes = 37655,
        //
        // Summary:
        //     [requires: EXT_raster_multisample, or EXT_texture_filter_minmax, NV_framebuffer_mixed_samples]
        //     Original was GL_RASTER_MULTISAMPLE_EXT = 0x9327
        RasterMultisampleExt = 37671,
        //
        // Summary:
        //     [requires: EXT_raster_multisample, or EXT_texture_filter_minmax, NV_framebuffer_mixed_samples]
        //     Original was GL_RASTER_SAMPLES_EXT = 0x9328
        RasterSamplesExt = 37672,
        //
        // Summary:
        //     [requires: EXT_raster_multisample, or EXT_texture_filter_minmax, NV_framebuffer_mixed_samples]
        //     Original was GL_MAX_RASTER_SAMPLES_EXT = 0x9329
        MaxRasterSamplesExt = 37673,
        //
        // Summary:
        //     [requires: EXT_raster_multisample, or EXT_texture_filter_minmax, NV_framebuffer_mixed_samples]
        //     Original was GL_RASTER_FIXED_SAMPLE_LOCATIONS_EXT = 0x932A
        RasterFixedSampleLocationsExt = 37674,
        //
        // Summary:
        //     [requires: EXT_raster_multisample, or EXT_texture_filter_minmax, NV_framebuffer_mixed_samples]
        //     Original was GL_MULTISAMPLE_RASTERIZATION_ALLOWED_EXT = 0x932B
        MultisampleRasterizationAllowedExt = 37675,
        //
        // Summary:
        //     [requires: EXT_raster_multisample, or EXT_texture_filter_minmax, NV_framebuffer_mixed_samples]
        //     Original was GL_EFFECTIVE_RASTER_SAMPLES_EXT = 0x932C
        EffectiveRasterSamplesExt = 37676,
        //
        // Summary:
        //     [requires: NV_framebuffer_mixed_samples] Original was GL_DEPTH_SAMPLES_NV = 0x932D
        DepthSamplesNv = 37677,
        //
        // Summary:
        //     [requires: NV_framebuffer_mixed_samples] Original was GL_STENCIL_SAMPLES_NV =
        //     0x932E
        StencilSamplesNv = 37678,
        //
        // Summary:
        //     [requires: NV_framebuffer_mixed_samples] Original was GL_MIXED_DEPTH_SAMPLES_SUPPORTED_NV
        //     = 0x932F
        MixedDepthSamplesSupportedNv = 37679,
        //
        // Summary:
        //     [requires: NV_framebuffer_mixed_samples] Original was GL_MIXED_STENCIL_SAMPLES_SUPPORTED_NV
        //     = 0x9330
        MixedStencilSamplesSupportedNv = 37680,
        //
        // Summary:
        //     [requires: NV_framebuffer_mixed_samples] Original was GL_COVERAGE_MODULATION_TABLE_NV
        //     = 0x9331
        CoverageModulationTableNv = 37681,
        //
        // Summary:
        //     [requires: NV_framebuffer_mixed_samples] Original was GL_COVERAGE_MODULATION_NV
        //     = 0x9332
        CoverageModulationNv = 37682,
        //
        // Summary:
        //     [requires: NV_framebuffer_mixed_samples] Original was GL_COVERAGE_MODULATION_TABLE_SIZE_NV
        //     = 0x9333
        CoverageModulationTableSizeNv = 37683,
        //
        // Summary:
        //     [requires: NV_fill_rectangle] Original was GL_FILL_RECTANGLE_NV = 0x933C
        FillRectangleNv = 37692,
        //
        // Summary:
        //     [requires: NV_sample_locations] Original was GL_SAMPLE_LOCATION_SUBPIXEL_BITS_NV
        //     = 0x933D
        SampleLocationSubpixelBitsNv = 37693,
        //
        // Summary:
        //     [requires: NV_sample_locations] Original was GL_SAMPLE_LOCATION_PIXEL_GRID_WIDTH_NV
        //     = 0x933E
        SampleLocationPixelGridWidthNv = 37694,
        //
        // Summary:
        //     [requires: NV_sample_locations] Original was GL_SAMPLE_LOCATION_PIXEL_GRID_HEIGHT_NV
        //     = 0x933F
        SampleLocationPixelGridHeightNv = 37695,
        //
        // Summary:
        //     [requires: NV_sample_locations] Original was GL_PROGRAMMABLE_SAMPLE_LOCATION_TABLE_SIZE_NV
        //     = 0x9340
        ProgrammableSampleLocationTableSizeNv = 37696,
        //
        // Summary:
        //     [requires: NV_sample_locations] Original was GL_PROGRAMMABLE_SAMPLE_LOCATION_NV
        //     = 0x9341
        ProgrammableSampleLocationNv = 37697,
        //
        // Summary:
        //     [requires: NV_sample_locations] Original was GL_FRAMEBUFFER_PROGRAMMABLE_SAMPLE_LOCATIONS_NV
        //     = 0x9342
        FramebufferProgrammableSampleLocationsNv = 37698,
        //
        // Summary:
        //     [requires: NV_sample_locations] Original was GL_FRAMEBUFFER_SAMPLE_LOCATION_PIXEL_GRID_NV
        //     = 0x9343
        FramebufferSampleLocationPixelGridNv = 37699,
        //
        // Summary:
        //     [requires: NV_conservative_raster] Original was GL_CONSERVATIVE_RASTERIZATION_NV
        //     = 0x9346
        ConservativeRasterizationNv = 37702,
        //
        // Summary:
        //     [requires: NV_conservative_raster] Original was GL_SUBPIXEL_PRECISION_BIAS_X_BITS_NV
        //     = 0x9347
        SubpixelPrecisionBiasXBitsNv = 37703,
        //
        // Summary:
        //     [requires: NV_conservative_raster] Original was GL_SUBPIXEL_PRECISION_BIAS_Y_BITS_NV
        //     = 0x9348
        SubpixelPrecisionBiasYBitsNv = 37704,
        //
        // Summary:
        //     [requires: NV_conservative_raster] Original was GL_MAX_SUBPIXEL_PRECISION_BIAS_BITS_NV
        //     = 0x9349
        MaxSubpixelPrecisionBiasBitsNv = 37705,
        //
        // Summary:
        //     [requires: NV_viewport_swizzle] Original was GL_VIEWPORT_SWIZZLE_POSITIVE_X_NV
        //     = 0x9350
        ViewportSwizzlePositiveXNv = 37712,
        //
        // Summary:
        //     [requires: NV_viewport_swizzle] Original was GL_VIEWPORT_SWIZZLE_NEGATIVE_X_NV
        //     = 0x9351
        ViewportSwizzleNegativeXNv = 37713,
        //
        // Summary:
        //     [requires: NV_viewport_swizzle] Original was GL_VIEWPORT_SWIZZLE_POSITIVE_Y_NV
        //     = 0x9352
        ViewportSwizzlePositiveYNv = 37714,
        //
        // Summary:
        //     [requires: NV_viewport_swizzle] Original was GL_VIEWPORT_SWIZZLE_NEGATIVE_Y_NV
        //     = 0x9353
        ViewportSwizzleNegativeYNv = 37715,
        //
        // Summary:
        //     [requires: NV_viewport_swizzle] Original was GL_VIEWPORT_SWIZZLE_POSITIVE_Z_NV
        //     = 0x9354
        ViewportSwizzlePositiveZNv = 37716,
        //
        // Summary:
        //     [requires: NV_viewport_swizzle] Original was GL_VIEWPORT_SWIZZLE_NEGATIVE_Z_NV
        //     = 0x9355
        ViewportSwizzleNegativeZNv = 37717,
        //
        // Summary:
        //     [requires: NV_viewport_swizzle] Original was GL_VIEWPORT_SWIZZLE_POSITIVE_W_NV
        //     = 0x9356
        ViewportSwizzlePositiveWNv = 37718,
        //
        // Summary:
        //     [requires: NV_viewport_swizzle] Original was GL_VIEWPORT_SWIZZLE_NEGATIVE_W_NV
        //     = 0x9357
        ViewportSwizzleNegativeWNv = 37719,
        //
        // Summary:
        //     [requires: NV_viewport_swizzle] Original was GL_VIEWPORT_SWIZZLE_X_NV = 0x9358
        ViewportSwizzleXNv = 37720,
        //
        // Summary:
        //     [requires: NV_viewport_swizzle] Original was GL_VIEWPORT_SWIZZLE_Y_NV = 0x9359
        ViewportSwizzleYNv = 37721,
        //
        // Summary:
        //     [requires: NV_viewport_swizzle] Original was GL_VIEWPORT_SWIZZLE_Z_NV = 0x935A
        ViewportSwizzleZNv = 37722,
        //
        // Summary:
        //     [requires: NV_viewport_swizzle] Original was GL_VIEWPORT_SWIZZLE_W_NV = 0x935B
        ViewportSwizzleWNv = 37723,
        //
        // Summary:
        //     [requires: EXT_clip_control] Original was GL_CLIP_ORIGIN_EXT = 0x935C
        ClipOriginExt = 37724,
        //
        // Summary:
        //     [requires: EXT_clip_control] Original was GL_CLIP_DEPTH_MODE_EXT = 0x935D
        ClipDepthModeExt = 37725,
        //
        // Summary:
        //     Original was GL_NEGATIVE_ONE_TO_ONE = 0x935E
        NegativeOneToOne = 37726,
        //
        // Summary:
        //     [requires: EXT_clip_control] Original was GL_NEGATIVE_ONE_TO_ONE_EXT = 0x935E
        NegativeOneToOneExt = 37726,
        //
        // Summary:
        //     Original was GL_ZERO_TO_ONE = 0x935F
        ZeroToOne = 37727,
        //
        // Summary:
        //     [requires: EXT_clip_control] Original was GL_ZERO_TO_ONE_EXT = 0x935F
        ZeroToOneExt = 37727,
        //
        // Summary:
        //     Original was GL_CLEAR_TEXTURE = 0x9365
        ClearTexture = 37733,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_FONT_GLYPHS_AVAILABLE_NV = 0x9368
        FontGlyphsAvailableNv = 37736,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_FONT_TARGET_UNAVAILABLE_NV = 0x9369
        FontTargetUnavailableNv = 37737,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_FONT_UNAVAILABLE_NV = 0x936A
        FontUnavailableNv = 37738,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_FONT_UNINTELLIGIBLE_NV = 0x936B
        FontUnintelligibleNv = 37739,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_STANDARD_FONT_FORMAT_NV = 0x936C
        StandardFontFormatNv = 37740,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_FRAGMENT_INPUT_NV = 0x936D
        FragmentInputNv = 37741,
        //
        // Summary:
        //     [requires: NV_internalformat_sample_query] Original was GL_MULTISAMPLES_NV =
        //     0x9371
        MultisamplesNv = 37745,
        //
        // Summary:
        //     [requires: NV_internalformat_sample_query] Original was GL_SUPERSAMPLE_SCALE_X_NV
        //     = 0x9372
        SupersampleScaleXNv = 37746,
        //
        // Summary:
        //     [requires: NV_internalformat_sample_query] Original was GL_SUPERSAMPLE_SCALE_Y_NV
        //     = 0x9373
        SupersampleScaleYNv = 37747,
        //
        // Summary:
        //     [requires: NV_internalformat_sample_query] Original was GL_CONFORMANT_NV = 0x9374
        ConformantNv = 37748,
        //
        // Summary:
        //     [requires: NV_clip_space_w_scaling] Original was GL_VIEWPORT_POSITION_W_SCALE_NV
        //     = 0x937C
        ViewportPositionWScaleNv = 37756,
        //
        // Summary:
        //     [requires: NV_clip_space_w_scaling] Original was GL_VIEWPORT_POSITION_W_SCALE_X_COEFF_NV
        //     = 0x937D
        ViewportPositionWScaleXCoeffNv = 37757,
        //
        // Summary:
        //     [requires: NV_clip_space_w_scaling] Original was GL_VIEWPORT_POSITION_W_SCALE_Y_COEFF_NV
        //     = 0x937E
        ViewportPositionWScaleYCoeffNv = 37758,
        //
        // Summary:
        //     [requires: NV_representative_fragment_test] Original was GL_REPRESENTATIVE_FRAGMENT_TEST_NV
        //     = 0x937F
        RepresentativeFragmentTestNv = 37759,
        //
        // Summary:
        //     Original was GL_NUM_SAMPLE_COUNTS = 0x9380
        NumSampleCounts = 37760,
        //
        // Summary:
        //     [requires: ANGLE_translated_shader_source] Original was GL_TRANSLATED_SHADER_SOURCE_LENGTH_ANGLE
        //     = 0x93A0
        TranslatedShaderSourceLengthAngle = 37792,
        //
        // Summary:
        //     [requires: APPLE_texture_format_BGRA8888, or EXT_texture_storage] Original was
        //     GL_BGRA8_EXT = 0x93A1
        Bgra8Ext = 37793,
        //
        // Summary:
        //     [requires: ANGLE_texture_usage] Original was GL_TEXTURE_USAGE_ANGLE = 0x93A2
        TextureUsageAngle = 37794,
        //
        // Summary:
        //     [requires: ANGLE_texture_usage] Original was GL_FRAMEBUFFER_ATTACHMENT_ANGLE
        //     = 0x93A3
        FramebufferAttachmentAngle = 37795,
        //
        // Summary:
        //     [requires: ANGLE_pack_reverse_row_order] Original was GL_PACK_REVERSE_ROW_ORDER_ANGLE
        //     = 0x93A4
        PackReverseRowOrderAngle = 37796,
        //
        // Summary:
        //     [requires: ANGLE_program_binary] Original was GL_PROGRAM_BINARY_ANGLE = 0x93A6
        ProgramBinaryAngle = 37798,
        //
        // Summary:
        //     [requires: KHR_texture_compression_astc_hdr, or KHR_texture_compression_astc_ldr,
        //     OES_texture_compression_astc] Original was GL_COMPRESSED_RGBA_ASTC_4x4_KHR =
        //     0x93B0
        CompressedRgbaAstc4X4Khr = 37808,
        //
        // Summary:
        //     [requires: KHR_texture_compression_astc_hdr, or KHR_texture_compression_astc_ldr,
        //     OES_texture_compression_astc] Original was GL_COMPRESSED_RGBA_ASTC_5x4_KHR =
        //     0x93B1
        CompressedRgbaAstc5X4Khr = 37809,
        //
        // Summary:
        //     [requires: KHR_texture_compression_astc_hdr, or KHR_texture_compression_astc_ldr,
        //     OES_texture_compression_astc] Original was GL_COMPRESSED_RGBA_ASTC_5x5_KHR =
        //     0x93B2
        CompressedRgbaAstc5X5Khr = 37810,
        //
        // Summary:
        //     [requires: KHR_texture_compression_astc_hdr, or KHR_texture_compression_astc_ldr,
        //     OES_texture_compression_astc] Original was GL_COMPRESSED_RGBA_ASTC_6x5_KHR =
        //     0x93B3
        CompressedRgbaAstc6X5Khr = 37811,
        //
        // Summary:
        //     [requires: KHR_texture_compression_astc_hdr, or KHR_texture_compression_astc_ldr,
        //     OES_texture_compression_astc] Original was GL_COMPRESSED_RGBA_ASTC_6x6_KHR =
        //     0x93B4
        CompressedRgbaAstc6X6Khr = 37812,
        //
        // Summary:
        //     [requires: KHR_texture_compression_astc_hdr, or KHR_texture_compression_astc_ldr,
        //     OES_texture_compression_astc] Original was GL_COMPRESSED_RGBA_ASTC_8x5_KHR =
        //     0x93B5
        CompressedRgbaAstc8X5Khr = 37813,
        //
        // Summary:
        //     [requires: KHR_texture_compression_astc_hdr, or KHR_texture_compression_astc_ldr,
        //     OES_texture_compression_astc] Original was GL_COMPRESSED_RGBA_ASTC_8x6_KHR =
        //     0x93B6
        CompressedRgbaAstc8X6Khr = 37814,
        //
        // Summary:
        //     [requires: KHR_texture_compression_astc_hdr, or KHR_texture_compression_astc_ldr,
        //     OES_texture_compression_astc] Original was GL_COMPRESSED_RGBA_ASTC_8x8_KHR =
        //     0x93B7
        CompressedRgbaAstc8X8Khr = 37815,
        //
        // Summary:
        //     [requires: KHR_texture_compression_astc_hdr, or KHR_texture_compression_astc_ldr,
        //     OES_texture_compression_astc] Original was GL_COMPRESSED_RGBA_ASTC_10x5_KHR =
        //     0x93B8
        CompressedRgbaAstc10X5Khr = 37816,
        //
        // Summary:
        //     [requires: KHR_texture_compression_astc_hdr, or KHR_texture_compression_astc_ldr,
        //     OES_texture_compression_astc] Original was GL_COMPRESSED_RGBA_ASTC_10x6_KHR =
        //     0x93B9
        CompressedRgbaAstc10X6Khr = 37817,
        //
        // Summary:
        //     [requires: KHR_texture_compression_astc_hdr, or KHR_texture_compression_astc_ldr,
        //     OES_texture_compression_astc] Original was GL_COMPRESSED_RGBA_ASTC_10x8_KHR =
        //     0x93BA
        CompressedRgbaAstc10X8Khr = 37818,
        //
        // Summary:
        //     [requires: KHR_texture_compression_astc_hdr, or KHR_texture_compression_astc_ldr,
        //     OES_texture_compression_astc] Original was GL_COMPRESSED_RGBA_ASTC_10x10_KHR
        //     = 0x93BB
        CompressedRgbaAstc10X10Khr = 37819,
        //
        // Summary:
        //     [requires: KHR_texture_compression_astc_hdr, or KHR_texture_compression_astc_ldr,
        //     OES_texture_compression_astc] Original was GL_COMPRESSED_RGBA_ASTC_12x10_KHR
        //     = 0x93BC
        CompressedRgbaAstc12X10Khr = 37820,
        //
        // Summary:
        //     [requires: KHR_texture_compression_astc_hdr, or KHR_texture_compression_astc_ldr,
        //     OES_texture_compression_astc] Original was GL_COMPRESSED_RGBA_ASTC_12x12_KHR
        //     = 0x93BD
        CompressedRgbaAstc12X12Khr = 37821,
        //
        // Summary:
        //     [requires: OES_texture_compression_astc] Original was GL_COMPRESSED_RGBA_ASTC_3x3x3_OES
        //     = 0x93C0
        CompressedRgbaAstc3X3x3Oes = 37824,
        //
        // Summary:
        //     [requires: OES_texture_compression_astc] Original was GL_COMPRESSED_RGBA_ASTC_4x3x3_OES
        //     = 0x93C1
        CompressedRgbaAstc4X3x3Oes = 37825,
        //
        // Summary:
        //     [requires: OES_texture_compression_astc] Original was GL_COMPRESSED_RGBA_ASTC_4x4x3_OES
        //     = 0x93C2
        CompressedRgbaAstc4X4x3Oes = 37826,
        //
        // Summary:
        //     [requires: OES_texture_compression_astc] Original was GL_COMPRESSED_RGBA_ASTC_4x4x4_OES
        //     = 0x93C3
        CompressedRgbaAstc4X4x4Oes = 37827,
        //
        // Summary:
        //     [requires: OES_texture_compression_astc] Original was GL_COMPRESSED_RGBA_ASTC_5x4x4_OES
        //     = 0x93C4
        CompressedRgbaAstc5X4x4Oes = 37828,
        //
        // Summary:
        //     [requires: OES_texture_compression_astc] Original was GL_COMPRESSED_RGBA_ASTC_5x5x4_OES
        //     = 0x93C5
        CompressedRgbaAstc5X5x4Oes = 37829,
        //
        // Summary:
        //     [requires: OES_texture_compression_astc] Original was GL_COMPRESSED_RGBA_ASTC_5x5x5_OES
        //     = 0x93C6
        CompressedRgbaAstc5X5x5Oes = 37830,
        //
        // Summary:
        //     [requires: OES_texture_compression_astc] Original was GL_COMPRESSED_RGBA_ASTC_6x5x5_OES
        //     = 0x93C7
        CompressedRgbaAstc6X5x5Oes = 37831,
        //
        // Summary:
        //     [requires: OES_texture_compression_astc] Original was GL_COMPRESSED_RGBA_ASTC_6x6x5_OES
        //     = 0x93C8
        CompressedRgbaAstc6X6x5Oes = 37832,
        //
        // Summary:
        //     [requires: OES_texture_compression_astc] Original was GL_COMPRESSED_RGBA_ASTC_6x6x6_OES
        //     = 0x93C9
        CompressedRgbaAstc6X6x6Oes = 37833,
        //
        // Summary:
        //     [requires: KHR_texture_compression_astc_hdr, or KHR_texture_compression_astc_ldr,
        //     OES_texture_compression_astc] Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4_KHR
        //     = 0x93D0
        CompressedSrgb8Alpha8Astc4X4Khr = 37840,
        //
        // Summary:
        //     [requires: KHR_texture_compression_astc_hdr, or KHR_texture_compression_astc_ldr,
        //     OES_texture_compression_astc] Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x4_KHR
        //     = 0x93D1
        CompressedSrgb8Alpha8Astc5X4Khr = 37841,
        //
        // Summary:
        //     [requires: KHR_texture_compression_astc_hdr, or KHR_texture_compression_astc_ldr,
        //     OES_texture_compression_astc] Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x5_KHR
        //     = 0x93D2
        CompressedSrgb8Alpha8Astc5X5Khr = 37842,
        //
        // Summary:
        //     [requires: KHR_texture_compression_astc_hdr, or KHR_texture_compression_astc_ldr,
        //     OES_texture_compression_astc] Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x5_KHR
        //     = 0x93D3
        CompressedSrgb8Alpha8Astc6X5Khr = 37843,
        //
        // Summary:
        //     [requires: KHR_texture_compression_astc_hdr, or KHR_texture_compression_astc_ldr,
        //     OES_texture_compression_astc] Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x6_KHR
        //     = 0x93D4
        CompressedSrgb8Alpha8Astc6X6Khr = 37844,
        //
        // Summary:
        //     [requires: KHR_texture_compression_astc_hdr, or KHR_texture_compression_astc_ldr,
        //     OES_texture_compression_astc] Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x5_KHR
        //     = 0x93D5
        CompressedSrgb8Alpha8Astc8X5Khr = 37845,
        //
        // Summary:
        //     [requires: KHR_texture_compression_astc_hdr, or KHR_texture_compression_astc_ldr,
        //     OES_texture_compression_astc] Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x6_KHR
        //     = 0x93D6
        CompressedSrgb8Alpha8Astc8X6Khr = 37846,
        //
        // Summary:
        //     [requires: KHR_texture_compression_astc_hdr, or KHR_texture_compression_astc_ldr,
        //     OES_texture_compression_astc] Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x8_KHR
        //     = 0x93D7
        CompressedSrgb8Alpha8Astc8X8Khr = 37847,
        //
        // Summary:
        //     [requires: KHR_texture_compression_astc_hdr, or KHR_texture_compression_astc_ldr,
        //     OES_texture_compression_astc] Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x5_KHR
        //     = 0x93D8
        CompressedSrgb8Alpha8Astc10X5Khr = 37848,
        //
        // Summary:
        //     [requires: KHR_texture_compression_astc_hdr, or KHR_texture_compression_astc_ldr,
        //     OES_texture_compression_astc] Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x6_KHR
        //     = 0x93D9
        CompressedSrgb8Alpha8Astc10X6Khr = 37849,
        //
        // Summary:
        //     [requires: KHR_texture_compression_astc_hdr, or KHR_texture_compression_astc_ldr,
        //     OES_texture_compression_astc] Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x8_KHR
        //     = 0x93DA
        CompressedSrgb8Alpha8Astc10X8Khr = 37850,
        //
        // Summary:
        //     [requires: KHR_texture_compression_astc_hdr, or KHR_texture_compression_astc_ldr,
        //     OES_texture_compression_astc] Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x10_KHR
        //     = 0x93DB
        CompressedSrgb8Alpha8Astc10X10Khr = 37851,
        //
        // Summary:
        //     [requires: KHR_texture_compression_astc_hdr, or KHR_texture_compression_astc_ldr,
        //     OES_texture_compression_astc] Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC_12x10_KHR
        //     = 0x93DC
        CompressedSrgb8Alpha8Astc12X10Khr = 37852,
        //
        // Summary:
        //     [requires: KHR_texture_compression_astc_hdr, or KHR_texture_compression_astc_ldr,
        //     OES_texture_compression_astc] Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC_12x12_KHR
        //     = 0x93DD
        CompressedSrgb8Alpha8Astc12X12Khr = 37853,
        //
        // Summary:
        //     [requires: OES_texture_compression_astc] Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC_3x3x3_OES
        //     = 0x93E0
        CompressedSrgb8Alpha8Astc3X3x3Oes = 37856,
        //
        // Summary:
        //     [requires: OES_texture_compression_astc] Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x3x3_OES
        //     = 0x93E1
        CompressedSrgb8Alpha8Astc4X3x3Oes = 37857,
        //
        // Summary:
        //     [requires: OES_texture_compression_astc] Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4x3_OES
        //     = 0x93E2
        CompressedSrgb8Alpha8Astc4X4x3Oes = 37858,
        //
        // Summary:
        //     [requires: OES_texture_compression_astc] Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4x4_OES
        //     = 0x93E3
        CompressedSrgb8Alpha8Astc4X4x4Oes = 37859,
        //
        // Summary:
        //     [requires: OES_texture_compression_astc] Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x4x4_OES
        //     = 0x93E4
        CompressedSrgb8Alpha8Astc5X4x4Oes = 37860,
        //
        // Summary:
        //     [requires: OES_texture_compression_astc] Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x5x4_OES
        //     = 0x93E5
        CompressedSrgb8Alpha8Astc5X5x4Oes = 37861,
        //
        // Summary:
        //     [requires: OES_texture_compression_astc] Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x5x5_OES
        //     = 0x93E6
        CompressedSrgb8Alpha8Astc5X5x5Oes = 37862,
        //
        // Summary:
        //     [requires: OES_texture_compression_astc] Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x5x5_OES
        //     = 0x93E7
        CompressedSrgb8Alpha8Astc6X5x5Oes = 37863,
        //
        // Summary:
        //     [requires: OES_texture_compression_astc] Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x6x5_OES
        //     = 0x93E8
        CompressedSrgb8Alpha8Astc6X6x5Oes = 37864,
        //
        // Summary:
        //     [requires: OES_texture_compression_astc] Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x6x6_OES
        //     = 0x93E9
        CompressedSrgb8Alpha8Astc6X6x6Oes = 37865,
        //
        // Summary:
        //     [requires: EXT_pvrtc_sRGB] Original was GL_COMPRESSED_SRGB_ALPHA_PVRTC_2BPPV2_IMG
        //     = 0x93F0
        CompressedSrgbAlphaPvrtc2Bppv2Img = 37872,
        //
        // Summary:
        //     [requires: EXT_pvrtc_sRGB] Original was GL_COMPRESSED_SRGB_ALPHA_PVRTC_4BPPV2_IMG
        //     = 0x93F1
        CompressedSrgbAlphaPvrtc4Bppv2Img = 37873,
        //
        // Summary:
        //     [requires: INTEL_performance_query] Original was GL_PERFQUERY_COUNTER_EVENT_INTEL
        //     = 0x94F0
        PerfqueryCounterEventIntel = 38128,
        //
        // Summary:
        //     [requires: INTEL_performance_query] Original was GL_PERFQUERY_COUNTER_DURATION_NORM_INTEL
        //     = 0x94F1
        PerfqueryCounterDurationNormIntel = 38129,
        //
        // Summary:
        //     [requires: INTEL_performance_query] Original was GL_PERFQUERY_COUNTER_DURATION_RAW_INTEL
        //     = 0x94F2
        PerfqueryCounterDurationRawIntel = 38130,
        //
        // Summary:
        //     [requires: INTEL_performance_query] Original was GL_PERFQUERY_COUNTER_THROUGHPUT_INTEL
        //     = 0x94F3
        PerfqueryCounterThroughputIntel = 38131,
        //
        // Summary:
        //     [requires: INTEL_performance_query] Original was GL_PERFQUERY_COUNTER_RAW_INTEL
        //     = 0x94F4
        PerfqueryCounterRawIntel = 38132,
        //
        // Summary:
        //     [requires: INTEL_performance_query] Original was GL_PERFQUERY_COUNTER_TIMESTAMP_INTEL
        //     = 0x94F5
        PerfqueryCounterTimestampIntel = 38133,
        //
        // Summary:
        //     [requires: INTEL_performance_query] Original was GL_PERFQUERY_COUNTER_DATA_UINT32_INTEL
        //     = 0x94F8
        PerfqueryCounterDataUint32Intel = 38136,
        //
        // Summary:
        //     [requires: INTEL_performance_query] Original was GL_PERFQUERY_COUNTER_DATA_UINT64_INTEL
        //     = 0x94F9
        PerfqueryCounterDataUint64Intel = 38137,
        //
        // Summary:
        //     [requires: INTEL_performance_query] Original was GL_PERFQUERY_COUNTER_DATA_FLOAT_INTEL
        //     = 0x94FA
        PerfqueryCounterDataFloatIntel = 38138,
        //
        // Summary:
        //     [requires: INTEL_performance_query] Original was GL_PERFQUERY_COUNTER_DATA_DOUBLE_INTEL
        //     = 0x94FB
        PerfqueryCounterDataDoubleIntel = 38139,
        //
        // Summary:
        //     [requires: INTEL_performance_query] Original was GL_PERFQUERY_COUNTER_DATA_BOOL32_INTEL
        //     = 0x94FC
        PerfqueryCounterDataBool32Intel = 38140,
        //
        // Summary:
        //     [requires: INTEL_performance_query] Original was GL_PERFQUERY_QUERY_NAME_LENGTH_MAX_INTEL
        //     = 0x94FD
        PerfqueryQueryNameLengthMaxIntel = 38141,
        //
        // Summary:
        //     [requires: INTEL_performance_query] Original was GL_PERFQUERY_COUNTER_NAME_LENGTH_MAX_INTEL
        //     = 0x94FE
        PerfqueryCounterNameLengthMaxIntel = 38142,
        //
        // Summary:
        //     [requires: INTEL_performance_query] Original was GL_PERFQUERY_COUNTER_DESC_LENGTH_MAX_INTEL
        //     = 0x94FF
        PerfqueryCounterDescLengthMaxIntel = 38143,
        //
        // Summary:
        //     [requires: INTEL_performance_query] Original was GL_PERFQUERY_GPA_EXTENDED_COUNTERS_INTEL
        //     = 0x9500
        PerfqueryGpaExtendedCountersIntel = 38144,
        //
        // Summary:
        //     [requires: EXT_semaphore] Original was GL_LAYOUT_DEPTH_READ_ONLY_STENCIL_ATTACHMENT_EXT
        //     = 0x9530
        LayoutDepthReadOnlyStencilAttachmentExt = 38192,
        //
        // Summary:
        //     [requires: EXT_semaphore] Original was GL_LAYOUT_DEPTH_ATTACHMENT_STENCIL_READ_ONLY_EXT
        //     = 0x9531
        LayoutDepthAttachmentStencilReadOnlyExt = 38193,
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
        //     [requires: NV_mesh_shader] Original was GL_MAX_MESH_TOTAL_MEMORY_SIZE_NV = 0x9536
        MaxMeshTotalMemorySizeNv = 38198,
        //
        // Summary:
        //     [requires: NV_mesh_shader] Original was GL_MAX_TASK_TOTAL_MEMORY_SIZE_NV = 0x9537
        MaxTaskTotalMemorySizeNv = 38199,
        //
        // Summary:
        //     [requires: NV_mesh_shader] Original was GL_MAX_MESH_OUTPUT_VERTICES_NV = 0x9538
        MaxMeshOutputVerticesNv = 38200,
        //
        // Summary:
        //     [requires: NV_mesh_shader] Original was GL_MAX_MESH_OUTPUT_PRIMITIVES_NV = 0x9539
        MaxMeshOutputPrimitivesNv = 38201,
        //
        // Summary:
        //     [requires: NV_mesh_shader] Original was GL_MAX_TASK_OUTPUT_COUNT_NV = 0x953A
        MaxTaskOutputCountNv = 38202,
        //
        // Summary:
        //     [requires: NV_mesh_shader] Original was GL_MAX_MESH_WORK_GROUP_SIZE_NV = 0x953B
        MaxMeshWorkGroupSizeNv = 38203,
        //
        // Summary:
        //     [requires: NV_mesh_shader] Original was GL_MAX_TASK_WORK_GROUP_SIZE_NV = 0x953C
        MaxTaskWorkGroupSizeNv = 38204,
        //
        // Summary:
        //     [requires: NV_mesh_shader] Original was GL_MAX_DRAW_MESH_TASKS_COUNT_NV = 0x953D
        MaxDrawMeshTasksCountNv = 38205,
        //
        // Summary:
        //     [requires: NV_mesh_shader] Original was GL_MESH_WORK_GROUP_SIZE_NV = 0x953E
        MeshWorkGroupSizeNv = 38206,
        //
        // Summary:
        //     [requires: NV_mesh_shader] Original was GL_TASK_WORK_GROUP_SIZE_NV = 0x953F
        TaskWorkGroupSizeNv = 38207,
        //
        // Summary:
        //     [requires: NV_mesh_shader] Original was GL_MESH_OUTPUT_PER_PRIMITIVE_GRANULARITY_NV
        //     = 0x9543
        MeshOutputPerPrimitiveGranularityNv = 38211,
        //
        // Summary:
        //     [requires: NV_conservative_raster_pre_snap_triangles] Original was GL_CONSERVATIVE_RASTER_MODE_NV
        //     = 0x954D
        ConservativeRasterModeNv = 38221,
        //
        // Summary:
        //     [requires: NV_conservative_raster_pre_snap_triangles] Original was GL_CONSERVATIVE_RASTER_MODE_POST_SNAP_NV
        //     = 0x954E
        ConservativeRasterModePostSnapNv = 38222,
        //
        // Summary:
        //     [requires: NV_conservative_raster_pre_snap_triangles] Original was GL_CONSERVATIVE_RASTER_MODE_PRE_SNAP_TRIANGLES_NV
        //     = 0x954F
        ConservativeRasterModePreSnapTrianglesNv = 38223,
        //
        // Summary:
        //     [requires: NV_conservative_raster_pre_snap] Original was GL_CONSERVATIVE_RASTER_MODE_PRE_SNAP_NV
        //     = 0x9550
        ConservativeRasterModePreSnapNv = 38224,
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
        //     [requires: NV_mesh_shader] Original was GL_MAX_MESH_VIEWS_NV = 0x9557
        MaxMeshViewsNv = 38231,
        //
        // Summary:
        //     [requires: NV_mesh_shader] Original was GL_MESH_SHADER_NV = 0x9559
        MeshShaderNv = 38233,
        //
        // Summary:
        //     [requires: NV_mesh_shader] Original was GL_TASK_SHADER_NV = 0x955A
        TaskShaderNv = 38234,
        //
        // Summary:
        //     [requires: NV_shading_rate_image] Original was GL_SHADING_RATE_IMAGE_BINDING_NV
        //     = 0x955B
        ShadingRateImageBindingNv = 38235,
        //
        // Summary:
        //     [requires: NV_shading_rate_image] Original was GL_SHADING_RATE_IMAGE_TEXEL_WIDTH_NV
        //     = 0x955C
        ShadingRateImageTexelWidthNv = 38236,
        //
        // Summary:
        //     [requires: NV_shading_rate_image] Original was GL_SHADING_RATE_IMAGE_TEXEL_HEIGHT_NV
        //     = 0x955D
        ShadingRateImageTexelHeightNv = 38237,
        //
        // Summary:
        //     [requires: NV_shading_rate_image] Original was GL_SHADING_RATE_IMAGE_PALETTE_SIZE_NV
        //     = 0x955E
        ShadingRateImagePaletteSizeNv = 38238,
        //
        // Summary:
        //     [requires: NV_shading_rate_image] Original was GL_MAX_COARSE_FRAGMENT_SAMPLES_NV
        //     = 0x955F
        MaxCoarseFragmentSamplesNv = 38239,
        //
        // Summary:
        //     [requires: NV_shading_rate_image] Original was GL_SHADING_RATE_IMAGE_NV = 0x9563
        ShadingRateImageNv = 38243,
        //
        // Summary:
        //     [requires: NV_shading_rate_image] Original was GL_SHADING_RATE_NO_INVOCATIONS_NV
        //     = 0x9564
        ShadingRateNoInvocationsNv = 38244,
        //
        // Summary:
        //     [requires: NV_shading_rate_image] Original was GL_SHADING_RATE_1_INVOCATION_PER_PIXEL_NV
        //     = 0x9565
        ShadingRate1InvocationPerPixelNv = 38245,
        //
        // Summary:
        //     [requires: NV_shading_rate_image] Original was GL_SHADING_RATE_1_INVOCATION_PER_1X2_PIXELS_NV
        //     = 0x9566
        ShadingRate1InvocationPer1X2PixelsNv = 38246,
        //
        // Summary:
        //     [requires: NV_shading_rate_image] Original was GL_SHADING_RATE_1_INVOCATION_PER_2X1_PIXELS_NV
        //     = 0x9567
        ShadingRate1InvocationPer2X1PixelsNv = 38247,
        //
        // Summary:
        //     [requires: NV_shading_rate_image] Original was GL_SHADING_RATE_1_INVOCATION_PER_2X2_PIXELS_NV
        //     = 0x9568
        ShadingRate1InvocationPer2X2PixelsNv = 38248,
        //
        // Summary:
        //     [requires: NV_shading_rate_image] Original was GL_SHADING_RATE_1_INVOCATION_PER_2X4_PIXELS_NV
        //     = 0x9569
        ShadingRate1InvocationPer2X4PixelsNv = 38249,
        //
        // Summary:
        //     [requires: NV_shading_rate_image] Original was GL_SHADING_RATE_1_INVOCATION_PER_4X2_PIXELS_NV
        //     = 0x956A
        ShadingRate1InvocationPer4X2PixelsNv = 38250,
        //
        // Summary:
        //     [requires: NV_shading_rate_image] Original was GL_SHADING_RATE_1_INVOCATION_PER_4X4_PIXELS_NV
        //     = 0x956B
        ShadingRate1InvocationPer4X4PixelsNv = 38251,
        //
        // Summary:
        //     [requires: NV_shading_rate_image] Original was GL_SHADING_RATE_2_INVOCATIONS_PER_PIXEL_NV
        //     = 0x956C
        ShadingRate2InvocationsPerPixelNv = 38252,
        //
        // Summary:
        //     [requires: NV_shading_rate_image] Original was GL_SHADING_RATE_4_INVOCATIONS_PER_PIXEL_NV
        //     = 0x956D
        ShadingRate4InvocationsPerPixelNv = 38253,
        //
        // Summary:
        //     [requires: NV_shading_rate_image] Original was GL_SHADING_RATE_8_INVOCATIONS_PER_PIXEL_NV
        //     = 0x956E
        ShadingRate8InvocationsPerPixelNv = 38254,
        //
        // Summary:
        //     [requires: NV_shading_rate_image] Original was GL_SHADING_RATE_16_INVOCATIONS_PER_PIXEL_NV
        //     = 0x956F
        ShadingRate16InvocationsPerPixelNv = 38255,
        //
        // Summary:
        //     [requires: NV_mesh_shader] Original was GL_MESH_VERTICES_OUT_NV = 0x9579
        MeshVerticesOutNv = 38265,
        //
        // Summary:
        //     [requires: NV_mesh_shader] Original was GL_MESH_PRIMITIVES_OUT_NV = 0x957A
        MeshPrimitivesOutNv = 38266,
        //
        // Summary:
        //     [requires: NV_mesh_shader] Original was GL_MESH_OUTPUT_TYPE_NV = 0x957B
        MeshOutputTypeNv = 38267,
        //
        // Summary:
        //     [requires: NV_mesh_shader] Original was GL_MESH_SUBROUTINE_NV = 0x957C
        MeshSubroutineNv = 38268,
        //
        // Summary:
        //     [requires: NV_mesh_shader] Original was GL_TASK_SUBROUTINE_NV = 0x957D
        TaskSubroutineNv = 38269,
        //
        // Summary:
        //     [requires: NV_mesh_shader] Original was GL_MESH_SUBROUTINE_UNIFORM_NV = 0x957E
        MeshSubroutineUniformNv = 38270,
        //
        // Summary:
        //     [requires: NV_mesh_shader] Original was GL_TASK_SUBROUTINE_UNIFORM_NV = 0x957F
        TaskSubroutineUniformNv = 38271,
        //
        // Summary:
        //     [requires: EXT_memory_object] Original was GL_TEXTURE_TILING_EXT = 0x9580
        TextureTilingExt = 38272,
        //
        // Summary:
        //     [requires: EXT_memory_object] Original was GL_DEDICATED_MEMORY_OBJECT_EXT = 0x9581
        DedicatedMemoryObjectExt = 38273,
        //
        // Summary:
        //     [requires: EXT_memory_object] Original was GL_NUM_TILING_TYPES_EXT = 0x9582
        NumTilingTypesExt = 38274,
        //
        // Summary:
        //     [requires: EXT_memory_object] Original was GL_TILING_TYPES_EXT = 0x9583
        TilingTypesExt = 38275,
        //
        // Summary:
        //     [requires: EXT_memory_object] Original was GL_OPTIMAL_TILING_EXT = 0x9584
        OptimalTilingExt = 38276,
        //
        // Summary:
        //     [requires: EXT_memory_object] Original was GL_LINEAR_TILING_EXT = 0x9585
        LinearTilingExt = 38277,
        //
        // Summary:
        //     [requires: EXT_memory_object_fd, or EXT_semaphore_fd] Original was GL_HANDLE_TYPE_OPAQUE_FD_EXT
        //     = 0x9586
        HandleTypeOpaqueFdExt = 38278,
        //
        // Summary:
        //     [requires: EXT_memory_object_win32, or EXT_semaphore_win32] Original was GL_HANDLE_TYPE_OPAQUE_WIN32_EXT
        //     = 0x9587
        HandleTypeOpaqueWin32Ext = 38279,
        //
        // Summary:
        //     [requires: EXT_memory_object_win32, or EXT_semaphore_win32] Original was GL_HANDLE_TYPE_OPAQUE_WIN32_KMT_EXT
        //     = 0x9588
        HandleTypeOpaqueWin32KmtExt = 38280,
        //
        // Summary:
        //     [requires: EXT_memory_object_win32] Original was GL_HANDLE_TYPE_D3D12_TILEPOOL_EXT
        //     = 0x9589
        HandleTypeD3D12TilepoolExt = 38281,
        //
        // Summary:
        //     [requires: EXT_memory_object_win32] Original was GL_HANDLE_TYPE_D3D12_RESOURCE_EXT
        //     = 0x958A
        HandleTypeD3D12ResourceExt = 38282,
        //
        // Summary:
        //     [requires: EXT_memory_object_win32] Original was GL_HANDLE_TYPE_D3D11_IMAGE_EXT
        //     = 0x958B
        HandleTypeD3D11ImageExt = 38283,
        //
        // Summary:
        //     [requires: EXT_memory_object_win32] Original was GL_HANDLE_TYPE_D3D11_IMAGE_KMT_EXT
        //     = 0x958C
        HandleTypeD3D11ImageKmtExt = 38284,
        //
        // Summary:
        //     [requires: EXT_semaphore] Original was GL_LAYOUT_GENERAL_EXT = 0x958D
        LayoutGeneralExt = 38285,
        //
        // Summary:
        //     [requires: EXT_semaphore] Original was GL_LAYOUT_COLOR_ATTACHMENT_EXT = 0x958E
        LayoutColorAttachmentExt = 38286,
        //
        // Summary:
        //     [requires: EXT_semaphore] Original was GL_LAYOUT_DEPTH_STENCIL_ATTACHMENT_EXT
        //     = 0x958F
        LayoutDepthStencilAttachmentExt = 38287,
        //
        // Summary:
        //     [requires: EXT_semaphore] Original was GL_LAYOUT_DEPTH_STENCIL_READ_ONLY_EXT
        //     = 0x9590
        LayoutDepthStencilReadOnlyExt = 38288,
        //
        // Summary:
        //     [requires: EXT_semaphore] Original was GL_LAYOUT_SHADER_READ_ONLY_EXT = 0x9591
        LayoutShaderReadOnlyExt = 38289,
        //
        // Summary:
        //     [requires: EXT_semaphore] Original was GL_LAYOUT_TRANSFER_SRC_EXT = 0x9592
        LayoutTransferSrcExt = 38290,
        //
        // Summary:
        //     [requires: EXT_semaphore] Original was GL_LAYOUT_TRANSFER_DST_EXT = 0x9593
        LayoutTransferDstExt = 38291,
        //
        // Summary:
        //     [requires: EXT_semaphore_win32] Original was GL_HANDLE_TYPE_D3D12_FENCE_EXT =
        //     0x9594
        HandleTypeD3D12FenceExt = 38292,
        //
        // Summary:
        //     [requires: EXT_semaphore_win32] Original was GL_D3D12_FENCE_VALUE_EXT = 0x9595
        D3D12FenceValueExt = 38293,
        //
        // Summary:
        //     [requires: EXT_memory_object, or EXT_semaphore] Original was GL_NUM_DEVICE_UUIDS_EXT
        //     = 0x9596
        NumDeviceUuidsExt = 38294,
        //
        // Summary:
        //     [requires: EXT_memory_object, or EXT_semaphore] Original was GL_DEVICE_UUID_EXT
        //     = 0x9597
        DeviceUuidExt = 38295,
        //
        // Summary:
        //     [requires: EXT_memory_object, or EXT_semaphore] Original was GL_DRIVER_UUID_EXT
        //     = 0x9598
        DriverUuidExt = 38296,
        //
        // Summary:
        //     [requires: EXT_memory_object_win32, or EXT_semaphore_win32] Original was GL_DEVICE_LUID_EXT
        //     = 0x9599
        DeviceLuidExt = 38297,
        //
        // Summary:
        //     [requires: EXT_memory_object_win32, or EXT_semaphore_win32] Original was GL_DEVICE_NODE_MASK_EXT
        //     = 0x959A
        DeviceNodeMaskExt = 38298,
        //
        // Summary:
        //     [requires: EXT_memory_object] Original was GL_PROTECTED_MEMORY_OBJECT_EXT = 0x959B
        ProtectedMemoryObjectExt = 38299,
        //
        // Summary:
        //     [requires: NV_mesh_shader] Original was GL_UNIFORM_BLOCK_REFERENCED_BY_MESH_SHADER_NV
        //     = 0x959C
        UniformBlockReferencedByMeshShaderNv = 38300,
        //
        // Summary:
        //     [requires: NV_mesh_shader] Original was GL_UNIFORM_BLOCK_REFERENCED_BY_TASK_SHADER_NV
        //     = 0x959D
        UniformBlockReferencedByTaskShaderNv = 38301,
        //
        // Summary:
        //     [requires: NV_mesh_shader] Original was GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_MESH_SHADER_NV
        //     = 0x959E
        AtomicCounterBufferReferencedByMeshShaderNv = 38302,
        //
        // Summary:
        //     [requires: NV_mesh_shader] Original was GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TASK_SHADER_NV
        //     = 0x959F
        AtomicCounterBufferReferencedByTaskShaderNv = 38303,
        //
        // Summary:
        //     [requires: NV_mesh_shader] Original was GL_REFERENCED_BY_MESH_SHADER_NV = 0x95A0
        ReferencedByMeshShaderNv = 38304,
        //
        // Summary:
        //     [requires: NV_mesh_shader] Original was GL_REFERENCED_BY_TASK_SHADER_NV = 0x95A1
        ReferencedByTaskShaderNv = 38305,
        //
        // Summary:
        //     [requires: NV_mesh_shader] Original was GL_MAX_MESH_WORK_GROUP_INVOCATIONS_NV
        //     = 0x95A2
        MaxMeshWorkGroupInvocationsNv = 38306,
        //
        // Summary:
        //     [requires: NV_mesh_shader] Original was GL_MAX_TASK_WORK_GROUP_INVOCATIONS_NV
        //     = 0x95A3
        MaxTaskWorkGroupInvocationsNv = 38307,
        //
        // Summary:
        //     [requires: NV_shading_rate_image] Original was GL_SHADING_RATE_SAMPLE_ORDER_DEFAULT_NV
        //     = 0x95AE
        ShadingRateSampleOrderDefaultNv = 38318,
        //
        // Summary:
        //     [requires: NV_shading_rate_image] Original was GL_SHADING_RATE_SAMPLE_ORDER_PIXEL_MAJOR_NV
        //     = 0x95AF
        ShadingRateSampleOrderPixelMajorNv = 38319,
        //
        // Summary:
        //     [requires: NV_shading_rate_image] Original was GL_SHADING_RATE_SAMPLE_ORDER_SAMPLE_MAJOR_NV
        //     = 0x95B0
        ShadingRateSampleOrderSampleMajorNv = 38320,
        //
        // Summary:
        //     [requires: NV_primitive_shading_rate] Original was GL_SHADING_RATE_IMAGE_PER_PRIMITIVE_NV
        //     = 0x95B1
        ShadingRateImagePerPrimitiveNv = 38321,
        //
        // Summary:
        //     [requires: NV_primitive_shading_rate] Original was GL_SHADING_RATE_IMAGE_PALETTE_COUNT_NV
        //     = 0x95B2
        ShadingRateImagePaletteCountNv = 38322,
        //
        // Summary:
        //     [requires: OVR_multiview] Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_NUM_VIEWS_OVR
        //     = 0x9630
        FramebufferAttachmentTextureNumViewsOvr = 38448,
        //
        // Summary:
        //     [requires: OVR_multiview] Original was GL_MAX_VIEWS_OVR = 0x9631
        MaxViewsOvr = 38449,
        //
        // Summary:
        //     [requires: OVR_multiview] Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_BASE_VIEW_INDEX_OVR
        //     = 0x9632
        FramebufferAttachmentTextureBaseViewIndexOvr = 38450,
        //
        // Summary:
        //     [requires: OVR_multiview] Original was GL_FRAMEBUFFER_INCOMPLETE_VIEW_TARGETS_OVR
        //     = 0x9633
        FramebufferIncompleteViewTargetsOvr = 38451,
        //
        // Summary:
        //     [requires: EXT_shader_pixel_local_storage2] Original was GL_MAX_SHADER_COMBINED_LOCAL_STORAGE_FAST_SIZE_EXT
        //     = 0x9650
        MaxShaderCombinedLocalStorageFastSizeExt = 38480,
        //
        // Summary:
        //     [requires: EXT_shader_pixel_local_storage2] Original was GL_MAX_SHADER_COMBINED_LOCAL_STORAGE_SIZE_EXT
        //     = 0x9651
        MaxShaderCombinedLocalStorageSizeExt = 38481,
        //
        // Summary:
        //     [requires: EXT_shader_pixel_local_storage2] Original was GL_FRAMEBUFFER_INCOMPLETE_INSUFFICIENT_SHADER_COMBINED_LOCAL_STORAGE_EXT
        //     = 0x9652
        FramebufferIncompleteInsufficientShaderCombinedLocalStorageExt = 38482,
        //
        // Summary:
        //     [requires: QCOM_shader_framebuffer_fetch_noncoherent] Original was GL_FRAMEBUFFER_FETCH_NONCOHERENT_QCOM
        //     = 0x96A2
        FramebufferFetchNoncoherentQcom = 38562,
        //
        // Summary:
        //     [requires: NV_path_rendering_shared_edge] Original was GL_SHARED_EDGE_NV = 0xC0
        SharedEdgeNv = 192,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_ROUNDED_RECT_NV = 0xE8
        RoundedRectNv = 232,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_RELATIVE_ROUNDED_RECT_NV = 0xE9
        RelativeRoundedRectNv = 233,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_ROUNDED_RECT2_NV = 0xEA
        RoundedRect2Nv = 234,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_RELATIVE_ROUNDED_RECT2_NV = 0xEB
        RelativeRoundedRect2Nv = 235,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_ROUNDED_RECT4_NV = 0xEC
        RoundedRect4Nv = 236,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_RELATIVE_ROUNDED_RECT4_NV = 0xED
        RelativeRoundedRect4Nv = 237,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_ROUNDED_RECT8_NV = 0xEE
        RoundedRect8Nv = 238,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_RELATIVE_ROUNDED_RECT8_NV = 0xEF
        RelativeRoundedRect8Nv = 239,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_RESTART_PATH_NV = 0xF0
        RestartPathNv = 240,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_DUP_FIRST_CUBIC_CURVE_TO_NV = 0xF2
        DupFirstCubicCurveToNv = 242,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_DUP_LAST_CUBIC_CURVE_TO_NV = 0xF4
        DupLastCubicCurveToNv = 244,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_RECT_NV = 0xF6
        RectNv = 246,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_RELATIVE_RECT_NV = 0xF7
        RelativeRectNv = 247,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_CIRCULAR_CCW_ARC_TO_NV = 0xF8
        CircularCcwArcToNv = 248,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_CIRCULAR_CW_ARC_TO_NV = 0xFA
        CircularCwArcToNv = 250,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_CIRCULAR_TANGENT_ARC_TO_NV = 0xFC
        CircularTangentArcToNv = 252,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_ARC_TO_NV = 0xFE
        ArcToNv = 254,
        //
        // Summary:
        //     [requires: NV_path_rendering] Original was GL_RELATIVE_ARC_TO_NV = 0xFF
        RelativeArcToNv = 0xFF,
        //
        // Summary:
        //     Original was GL_ALL_ATTRIB_BITS = 0xFFFFFFFF
        AllAttribBits = -1,
        //
        // Summary:
        //     Original was GL_ALL_BARRIER_BITS = 0xFFFFFFFF
        AllBarrierBits = -1,
        //
        // Summary:
        //     Original was GL_ALL_BARRIER_BITS_EXT = 0xFFFFFFFF
        AllBarrierBitsExt = -1,
        //
        // Summary:
        //     Original was GL_ALL_SHADER_BITS = 0xFFFFFFFF
        AllShaderBits = -1,
        //
        // Summary:
        //     [requires: EXT_separate_shader_objects] Original was GL_ALL_SHADER_BITS_EXT =
        //     0xFFFFFFFF
        AllShaderBitsExt = -1,
        //
        // Summary:
        //     Original was GL_CLIENT_ALL_ATTRIB_BITS = 0xFFFFFFFF
        ClientAllAttribBits = -1,
        //
        // Summary:
        //     Original was GL_INVALID_INDEX = 0xFFFFFFFF
        InvalidIndex = -1,
        //
        // Summary:
        //     Original was GL_QUERY_ALL_EVENT_BITS_AMD = 0xFFFFFFFF
        QueryAllEventBitsAmd = -1,
        //
        // Summary:
        //     Original was GL_TIMEOUT_IGNORED = 0xFFFFFFFFFFFFFFFF
        TimeoutIgnored = -1,
        //
        // Summary:
        //     [requires: APPLE_sync] Original was GL_TIMEOUT_IGNORED_APPLE = 0xFFFFFFFFFFFFFFFF
        TimeoutIgnoredApple = -1,
        //
        // Summary:
        //     Original was GL_LAYOUT_LINEAR_INTEL = 1
        LayoutLinearIntel = 1,
        //
        // Summary:
        //     Original was GL_One = 1
        One = 1,
        //
        // Summary:
        //     Original was GL_TRUE = 1
        True = 1,
        //
        // Summary:
        //     [requires: EXT_memory_object, or EXT_semaphore] Original was GL_UUID_SIZE_EXT
        //     = 16
        UuidSizeExt = 0x10,
        //
        // Summary:
        //     Original was GL_LAYOUT_LINEAR_CPU_CACHED_INTEL = 2
        LayoutLinearCpuCachedIntel = 2,
        //
        // Summary:
        //     [requires: EXT_memory_object_win32, or EXT_semaphore_win32] Original was GL_LUID_SIZE_EXT
        //     = 8
        LuidSizeExt = 8
    }
}