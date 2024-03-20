namespace OpenGL.Def
{
    public enum GenerateMipmapTarget
    {
        //
        // Summary:
        //     [requires: v1.0 or ARB_internalformat_query2] Original was GL_TEXTURE_1D = 0x0DE0
        Texture1D = 3552,
        //
        // Summary:
        //     [requires: v1.0 or ARB_internalformat_query2] Original was GL_TEXTURE_2D = 0x0DE1
        Texture2D = 3553,
        //
        // Summary:
        //     [requires: v1.2 or ARB_internalformat_query2] Original was GL_TEXTURE_3D = 0x806F
        Texture3D = 32879,
        //
        // Summary:
        //     [requires: v1.3 or ARB_internalformat_query2] Original was GL_TEXTURE_CUBE_MAP
        //     = 0x8513
        TextureCubeMap = 34067,
        //
        // Summary:
        //     [requires: v3.0 or ARB_internalformat_query2] Original was GL_TEXTURE_1D_ARRAY
        //     = 0x8C18
        Texture1DArray = 35864,
        //
        // Summary:
        //     [requires: v3.0 or ARB_internalformat_query2] Original was GL_TEXTURE_2D_ARRAY
        //     = 0x8C1A
        Texture2DArray = 35866,
        //
        // Summary:
        //     [requires: v4.0 or ARB_internalformat_query2] Original was GL_TEXTURE_CUBE_MAP_ARRAY
        //     = 0x9009
        TextureCubeMapArray = 36873,
        //
        // Summary:
        //     [requires: v3.2 or ARB_internalformat_query2, ARB_texture_multisample, NV_internalformat_sample_query]
        //     Original was GL_TEXTURE_2D_MULTISAMPLE = 0x9100
        Texture2DMultisample = 37120,
        //
        // Summary:
        //     [requires: v3.2 or ARB_internalformat_query2, ARB_texture_multisample, NV_internalformat_sample_query]
        //     Original was GL_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9102
        Texture2DMultisampleArray = 37122
    }
}