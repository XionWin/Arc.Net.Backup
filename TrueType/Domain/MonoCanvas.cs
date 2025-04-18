﻿using TrueType.Mode;

namespace TrueType.Domain
{
    public class MonoCanvas: ICanvas
    {
        private Point _nextCharacterLocation;

        public Size Size { get; init; }
        public byte[] Pixels { get; private set; }

        public MonoCanvas(Size size)
        {
            Size = size;
            Pixels = new byte[size.Width * size.Height];
        }

        static List<int> CURRENT_LINE_HIGHT_CACHE = new List<int>();
        public TTFBitmap LocateCharacter(TTFIndex index, byte[] data, Size renderSize, int lineHeight)
        {
            var location = _nextCharacterLocation;
            if (_nextCharacterLocation.X + renderSize.Width > Size.Width)
            {
                location.X = 0;
                location.Y += CURRENT_LINE_HIGHT_CACHE.Max();
                CURRENT_LINE_HIGHT_CACHE.Clear();
            }

            var steps = renderSize.Height;
            for (int i = 0; i < steps; i++)
            {
                Array.Copy(data, i * renderSize.Width, Pixels, location.X + location.Y * Size.Width + i * Size.Width, renderSize.Width);
            }
            var bitmap = new TTFBitmap(index.Character, index.Size, new Rectangle(location.X, location.Y, renderSize.Width, renderSize.Height));

            location.X += renderSize.Width;
            _nextCharacterLocation = location;
            CURRENT_LINE_HIGHT_CACHE.Add(renderSize.Height);

            return bitmap;
        }

        public void Clear()
        {
            this._nextCharacterLocation = new Point();
            Array.Fill<byte>(this.Pixels, 0);
        }
    }
}
