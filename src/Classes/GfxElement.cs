using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Porno_Graphic.Classes
{
    public class GfxElement
    {
        public uint Width { get; private set; }
        public uint Height { get; private set; }
        public uint[] Pixels { get; private set; }

        public GfxElement(uint width, uint height, uint fill)
        {
            Width = width;
            Height = height;
            Pixels = new uint[Width * Height];
            for (int i = 0; i < Pixels.Length; i++)
                Pixels[i] = fill;
        }

        public GfxElement(byte[] data, CharLayout layout, uint offset, uint ch)
        {
            Width = layout.Width;
            Height = layout.Height;
            Pixels = new uint[Width * Height];
            uint charOffset = (8 * offset) + (layout.Stride * ch);
            for (uint y = 0; y < Height; y++)
            {
                uint rowOffset = charOffset + layout.YOffset(data, y);
                for (uint x = 0; x < Width; x++)
                {
                    uint pixOffset = rowOffset + layout.XOffset(data, x);
                    uint pixel = 0;
                    uint planeBit = 1U << (int)(layout.Planes - 1);
                    for (uint plane = 0; plane < layout.Planes; plane++, planeBit >>= 1)
                    {
                        uint bitOffset = pixOffset + layout.PlaneOffset(data, plane);
                        if (((data[bitOffset / 8] >> (int)(7 - (bitOffset % 8))) & 1U) != 0)
                            pixel |= planeBit;
                    }
                    Pixels[x + (Width * y)] = pixel;
                }
            }
        }

        public void Write(byte[] data, CharLayout layout, uint offset, uint ch)
        {
            uint charOffset = (8 * offset) + (layout.Stride * ch);
            for (uint y = 0; y < Height; y++)
            {
                uint rowOffset = charOffset + layout.YOffset(data, y);
                for (uint x = 0; x < Width; x++)
                {
                    uint pixOffset = rowOffset + layout.XOffset(data, x);
                    uint planeBit = 1U << (int)(layout.Planes - 1);
                    for (uint plane = 0; plane < layout.Planes; plane++, planeBit >>= 1)
                    {
                        uint bitOffset = pixOffset + layout.PlaneOffset(data, plane);
                        uint byteOffset = bitOffset / 8;
                        byte mask = (byte)(0x0080U >> (int)(7 - (bitOffset % 8)));
                        if ((Pixels[x + (Width * y)] & planeBit) != 0)
                            data[byteOffset] |= mask;
                        else
                            data[byteOffset] &= (byte)(~mask);
                    }
                }
            }
        }

        public void Write(ChunkWriter writer)
        {
            writer.OpenChunk(ChunkType.GfxElement, 8U + (4U * Width * Height));
            writer.Write(Width);
            writer.Write(Height);
            for (uint pixel = 0; pixel < (Width * Height); pixel++)
                writer.Write(Pixels[pixel]);
            writer.CloseChunk();
        }

        public ulong ChunkSize()
        {
            return 16U + 8U + (4U * Width * Height);
        }

        public void Draw(Graphics graphics, IPalette palette, int[,] transform)
        {
            Rectangle rowStart = new Rectangle(transform[0, 2], transform[1, 2], transform[0, 0] + transform[0, 1], transform[1, 0] + transform[1, 1]);
            if (rowStart.Width < 0)
            {
                rowStart.X += rowStart.Width;
                rowStart.Width = -rowStart.Width;
            }
            if (rowStart.Height < 0)
            {
                rowStart.Y += rowStart.Height;
                rowStart.Height = -rowStart.Height;
            }
            Point yStep = new Point(transform[0, 1], transform[1, 1]);
            Point xStep = new Point(transform[0, 0], transform[1, 0]);
            for (uint y = 0; y < Height; y++, rowStart.Offset(yStep))
            {
                Rectangle pixel = rowStart;
                for (uint x = 0; x < Width; x++, pixel.Offset(xStep))
                    graphics.FillRectangle(palette.GetBrush(GetPixel(x, y)), pixel);
            }
        }

        public uint GetPixel(uint x, uint y) { return Pixels[x + (Width * y)]; }
        public void SetPixel(uint value, uint x, uint y) { Pixels[x + (Width * y)] = value; }
    }
}
