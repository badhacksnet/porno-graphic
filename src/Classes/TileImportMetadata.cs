using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Porno_Graphic.Classes
{
    public class TileImportMetadata
    {
        public string ProfileFile { get; set; }
        public string ProfileName { get; set; }
        public string RegionName { get; set; }
        public string LayoutName { get; set; }
        public string Offset { get; set; }

        public void Write(ChunkWriter writer)
        {
            writer.OpenChunk(ChunkType.TileImportMetadata, ChunkContentLength());
            writer.Write(ProfileFile);
            writer.Write(ProfileName);
            writer.Write(RegionName);
            writer.Write(LayoutName);
            writer.Write(Offset);
            writer.CloseChunk();
        }

        public ulong ChunkSize()
        {
            return 16U + ChunkContentLength();
        }

        private ulong ChunkContentLength()
        {
            return (ulong)((5U * 4U)
                + ((ProfileFile != null) ? Encoding.BigEndianUnicode.GetByteCount(ProfileFile) : 0)
                + ((ProfileName != null) ? Encoding.BigEndianUnicode.GetByteCount(ProfileName) : 0)
                + ((RegionName != null) ? Encoding.BigEndianUnicode.GetByteCount(RegionName) : 0)
                + ((LayoutName != null) ? Encoding.BigEndianUnicode.GetByteCount(LayoutName) : 0)
                + ((Offset != null) ? Encoding.BigEndianUnicode.GetByteCount(Offset) : 0));
        }
    }
}
