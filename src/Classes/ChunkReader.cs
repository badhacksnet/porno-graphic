using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;

namespace Porno_Graphic.Classes
{
    public class ChunkReader : ChunkIOBase
    {
        private bool mDecompressing;

        public ChunkReader(Stream stream) : base(stream)
        {
            mDecompressing = false;
        }

        public ChunkType ReadChunkHeader()
        {
            if (mOpenChunks.Count() > 0)
                mOpenChunks.Peek().SetContainsSubChunks();
            byte[] buffer = new byte[8];
            int count;
            count = mStream.Read(buffer, 0, 8);
            if (count != 8)
                throw new Exception(string.Format("Need 8 bytes but only got {0}", count));
            if (BitConverter.IsLittleEndian)
                buffer.Reverse();
            ChunkType type = (ChunkType)BitConverter.ToUInt64(buffer, 0);
            count = mStream.Read(buffer, 0, 8);
            if (count != 8)
                throw new Exception(string.Format("Need 8 bytes but only got {0}", count));
            if (BitConverter.IsLittleEndian)
                buffer.Reverse();
            ulong length = BitConverter.ToUInt64(buffer, 0);
            if (mOpenChunks.Count() > 0)
                mOpenChunks.Peek().Consume(16U + length);
            mOpenChunks.Push(new ChunkInfo(type, length));
            return type;
        }

        public void SkipRemainingChunk()
        {
            ChunkInfo current = mOpenChunks.Peek();
            byte[] buffer = new byte[256];
            while (current.Remaining > 0)
            {
                int block = (int)Math.Min(current.Remaining, 256U);
                int count = mStream.Read(buffer, 0, block);
                if (count != block)
                    throw new Exception(string.Format("Need {0} bytes but only got {0}", block, count));
                current.Consume((ulong)count);
            }
            mOpenChunks.Pop();
        }

        public void StartDecompression()
        {
            if (mDecompressing)
                throw new Exception("Attempt to start decompression while already decompressing");
            if (mOpenChunks.Count() > 0)
                throw new Exception("Attempt to start compression partway through chunk");
            mStream = new DeflateStream(mStream, CompressionMode.Decompress);
            mDecompressing = true;
        }
    }
}
