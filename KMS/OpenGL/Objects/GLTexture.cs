using OpenGL.Def;

namespace OpenGL.Objects
{
    public class GLTexture : GLObject
    {
        private TextureUnit _textureUnit = TextureUnit.Texture0;
        public TextureUnit TextureUnit  => _textureUnit;
        private TextureMinFilter _textureMinFilter = TextureMinFilter.Linear;
        public TextureMinFilter TextureMinFilter => _textureMinFilter;

        public GLTexture(TextureUnit textureUnit, TextureMinFilter textureMinFilter) : base()
        {
            this.Id = ES20.GenTexture();
            this._textureUnit = textureUnit;
            this._textureMinFilter = textureMinFilter;
        }

        protected override void Release()
        {
            ES20.DeleteTexture(this.Id);
        }
    }

    public class ImageData
    {
        public int Width { get; init; }
        public int Height { get; init; }
        public byte[] Value { get; init; }

        public ImageData(int width, int height, byte[] value)
        {
            this.Width = width;
            this.Height = height;
            this.Value = value;
        }
    }

    public static class GLTextureExtension
    {
        public static void Load(this GLTexture texture, ImageData imageData, PixelFormat pixelFormat, PixelInternalFormat pixelInternalFormat)
        {
            OpenGL.ES20.glActiveTexture(texture.TextureUnit);
            OpenGL.ES20.glBindTexture(TextureTarget.Texture2D, texture.Id);

            OpenGL.ES20.glTexImage2D(TextureTarget.Texture2D, 0, pixelInternalFormat, imageData.Width, imageData.Height, 0, pixelFormat, PixelType.UnsignedByte, imageData.Value);

            // Now that our texture is loaded, we can set a few settings to affect how the image appears on rendering.

            // First, we set the min and mag filter. These are used for when the texture is scaled down and up, respectively.
            // Here, we use Linear for both. This means that OpenGL will try to blend pixels, meaning that textures scaled too far will look blurred.
            // You could also use (amongst other options) Nearest, which just grabs the nearest pixel, which makes the texture look pixelated if scaled too far.
            // NOTE: The default settings for both of these are LinearMipmap. If you leave these as default but don't generate mipmaps,
            // your image will fail to render at all (usually resulting in pure black instead).
            OpenGL.ES20.glTexParameteri(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)texture.TextureMinFilter);
            OpenGL.ES20.glTexParameteri(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int)texture.TextureMinFilter);

            // Now, set the wrapping mode. S is for the X axis, and T is for the Y axis.
            // We set this to Repeat so that textures will repeat when wrapped. Not demonstrated here since the texture coordinates exactly match
            OpenGL.ES20.glTexParameteri(TextureTarget.Texture2D, TextureParameterName.TextureWrapS, (int)TextureWrapMode.Repeat);
            OpenGL.ES20.glTexParameteri(TextureTarget.Texture2D, TextureParameterName.TextureWrapT, (int)TextureWrapMode.Repeat);

            // Next, generate mipmaps.
            // Mipmaps are smaller copies of the texture, scaled down. Each mipmap level is half the size of the previous one
            // Generated mipmaps go all the way down to just one pixel.
            // OpenGL will automatically switch between mipmaps when an object gets sufficiently far away.
            // This prevents moiré effects, as well as saving on texture bandwidth.
            // Here you can see and read about the morié effect https://en.wikipedia.org/wiki/Moir%C3%A9_pattern
            // Here is an example of mips in action https://en.wikipedia.org/wiki/File:Mipmap_Aliasing_Comparison.png
            OpenGL.ES20.glGenerateMipmap(GenerateMipmapTarget.Texture2D);
        }
        
    }
}
