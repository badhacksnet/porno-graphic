using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Porno_Graphic.Classes
{
    public abstract class ChunkIOBase : IDisposable
    {
        protected class ChunkInfo
        {
            public ChunkType Type { get; private set; }
            public ulong Length { get; private set; }
            public ulong Remaining { get; private set; }
            public bool ContainsSubChunks { get; private set; }

            public ChunkInfo(ChunkType type, ulong length)
            {
                Type = type;
                Length = length;
                Remaining = length;
                ContainsSubChunks = false;
            }

            public void Consume(ulong size)
            {
                if (Remaining < size)
                    throw new Exception(string.Format("Attempt to consume {0} bytes from chunk with {1} bytes remaining", size, Remaining));
                Remaining -= size;
            }

            public void SetContainsSubChunks()
            {
                if (!ContainsSubChunks)
                {
                    if (Remaining < Length)
                        throw new Exception(string.Format("Attempt to add subchunks to chunk containing {0} bytes of raw data", Length - Remaining));
                    ContainsSubChunks = true;
                }
            }
        };

        protected Stream mStream;
        protected Stack<ChunkInfo> mOpenChunks;

        protected ChunkIOBase(Stream stream)
        {
            mStream = stream;
            mOpenChunks = new Stack<ChunkInfo>();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (mStream != null)
                    mStream.Dispose();
            }
        }
    }
}
