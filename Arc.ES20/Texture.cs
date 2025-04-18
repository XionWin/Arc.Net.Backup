﻿#if KMS_MODE
using OpenGL.Graphics.ES20;
#else
using OpenTK.Graphics.ES20;
#endif
using OpenTK.Mathematics;

namespace Arc.ES20;
public class Texture
{
    public TextureUnit TextureUnit { get; init; }
    public int Id { get; init; }
    private TextureMinFilter _textureMinFilter { get; init; }
    public Vector2 Size { get; private set; }

    public Texture(TextureUnit textureUnit, TextureMinFilter textureMinFilter = TextureMinFilter.Linear)
    {
        this.Id = GL.GenTexture();
        this.TextureUnit = textureUnit;
        this._textureMinFilter = textureMinFilter;
    }

    public void LoadImage(string path)
    {
        GL.ActiveTexture(this.TextureUnit);
        GL.BindTexture(TextureTarget.Texture2D, this.Id);

        var image = ImageExtension.GetImageData(path);
        this.Size = new Vector2(image.Width, image.Height);
        
        GL.TexImage2D(TextureTarget2d.Texture2D, 0, TextureComponentCount.Rgba, image.Width, image.Height, 0, PixelFormat.Rgba, PixelType.UnsignedByte, image.Value);

        // Now that our texture is loaded, we can set a few settings to affect how the image appears on rendering.

        // First, we set the min and mag filter. These are used for when the texture is scaled down and up, respectively.
        // Here, we use Linear for both. This means that OpenGL will try to blend pixels, meaning that textures scaled too far will look blurred.
        // You could also use (amongst other options) Nearest, which just grabs the nearest pixel, which makes the texture look pixelated if scaled too far.
        // NOTE: The default settings for both of these are LinearMipmap. If you leave these as default but don't generate mipmaps,
        // your image will fail to render at all (usually resulting in pure black instead).
        GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)this._textureMinFilter);
        GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int)this._textureMinFilter);
        
        // Now, set the wrapping mode. S is for the X axis, and T is for the Y axis.
        // We set this to Repeat so that textures will repeat when wrapped. Not demonstrated here since the texture coordinates exactly match
        GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapS, (int)TextureWrapMode.ClampToBorder);
        GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapT, (int)TextureWrapMode.ClampToBorder);

        // Next, generate mipmaps.
        // Mipmaps are smaller copies of the texture, scaled down. Each mipmap level is half the size of the previous one
        // Generated mipmaps go all the way down to just one pixel.
        // OpenGL will automatically switch between mipmaps when an object gets sufficiently far away.
        // This prevents moiré effects, as well as saving on texture bandwidth.
        // Here you can see and read about the morié effect https://en.wikipedia.org/wiki/Moir%C3%A9_pattern
        // Here is an example of mips in action https://en.wikipedia.org/wiki/File:Mipmap_Aliasing_Comparison.png
        GL.GenerateMipmap(TextureTarget.Texture2D);
    }

    public void LoadRaw(byte[] data, int width, int height, PixelFormat pixelFormat, TextureComponentCount pixelInternalFormat)
    {
        GL.ActiveTexture(this.TextureUnit);
        GL.BindTexture(TextureTarget.Texture2D, this.Id);

        this.Size = new Vector2(width, height);

        GL.TexImage2D(TextureTarget2d.Texture2D, 0, pixelInternalFormat, width, height, 0, pixelFormat, PixelType.UnsignedByte, data);

        // Now that our texture is loaded, we can set a few settings to affect how the image appears on rendering.

        // First, we set the min and mag filter. These are used for when the texture is scaled down and up, respectively.
        // Here, we use Linear for both. This means that OpenGL will try to blend pixels, meaning that textures scaled too far will look blurred.
        // You could also use (amongst other options) Nearest, which just grabs the nearest pixel, which makes the texture look pixelated if scaled too far.
        // NOTE: The default settings for both of these are LinearMipmap. If you leave these as default but don't generate mipmaps,
        // your image will fail to render at all (usually resulting in pure black instead).
        GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)this._textureMinFilter);
        GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int)this._textureMinFilter);

        // Now, set the wrapping mode. S is for the X axis, and T is for the Y axis.
        // We set this to Repeat so that textures will repeat when wrapped. Not demonstrated here since the texture coordinates exactly match
        GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapS, (int)TextureWrapMode.Repeat);
        GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapT, (int)TextureWrapMode.Repeat);

        // Next, generate mipmaps.
        // Mipmaps are smaller copies of the texture, scaled down. Each mipmap level is half the size of the previous one
        // Generated mipmaps go all the way down to just one pixel.
        // OpenGL will automatically switch between mipmaps when an object gets sufficiently far away.
        // This prevents moiré effects, as well as saving on texture bandwidth.
        // Here you can see and read about the morié effect https://en.wikipedia.org/wiki/Moir%C3%A9_pattern
        // Here is an example of mips in action https://en.wikipedia.org/wiki/File:Mipmap_Aliasing_Comparison.png
        GL.GenerateMipmap(TextureTarget.Texture2D);
    }


    //// Activate texture
    //// Multiple textures can be bound, if your shader needs more than just one.
    //// If you want to do that, use GL.ActiveTexture to set which slot GL.BindTexture binds to.
    //// The OpenGL standard requires that there be at least 16, but there can be more depending on your graphics card.
    //public void Use(TextureUnit textureUnit)
    //{
    //    GL.ActiveTexture(textureUnit);
    //    GL.BindTexture(TextureTarget.Texture2D, _handle);
    //}
}
