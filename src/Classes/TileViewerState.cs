using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Porno_Graphic.Classes
{
    public class TileViewerState
    {
        public Point Location { get; set; }
        public Size Size { get; set; }
        public Size Scale { get; set; }
        public uint Rotate { get; set; }
        public bool FlipX { get; set; }
        public bool FlipY { get; set; }

        public void Write(ChunkWriter writer)
        {
            writer.OpenChunk(ChunkType.TileViewerState, 19);
            writer.Write(Location.X);
            writer.Write(Location.Y);
            writer.Write(Size.Width);
            writer.Write(Size.Height);
            writer.Write((byte)Scale.Width);
            writer.Write((byte)Scale.Height);
            writer.Write((byte)((Rotate & 0x03U) | (FlipX ? 0x04U : 0x00U) | (FlipY ? 0x08U : 0x00U)));
            writer.CloseChunk();
        }

        public ulong ChunkSize()
        {
            return 16U + 19U;
        }
    }
}
