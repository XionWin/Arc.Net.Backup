﻿using OpenTK.Windowing.Common.Input;
using SixLabors.ImageSharp.PixelFormats;
using System.Runtime.InteropServices;
using Extension;
using Arc.Core;

namespace Arc.ES20;
public static class ImageExtension
{
    public static ImageData GetImageData(string iconPath)
    {
        using var image = SixLabors.ImageSharp.Image.Load<Rgba32>(iconPath);
        var pixelData = new byte[image.Width * image.Height * Marshal.SizeOf<Rgba32>()];
        return new ImageData(image.Width, image.Height, pixelData.With(x => image.CopyPixelDataTo(x)));
    }

    public static WindowIcon CreateWindowIcon(string iconPath) =>
        GetImageData(iconPath) is ImageData imageData ?
        new WindowIcon(new Image(imageData.Width, imageData.Height, imageData.Value)) :
        throw new Exception("CreateWindowIcon error");
}
