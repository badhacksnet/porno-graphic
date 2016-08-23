using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Porno_Graphic.Classes
{
    public class LoadOutsideRegionException : Exception
    {
        LoadRegion mRegion;
        int mFileIndex;
        uint mOffset;

        public LoadRegion Region
        {
            get { return mRegion; }
        }
        public int FileIndex
        {
            get { return mFileIndex; }
        }
        public LoadRegion.File File
        {
            get { return mRegion.Files[mFileIndex]; }
        }
        public uint Offset
        {
            get { return mOffset; }
        }

        public LoadOutsideRegionException(LoadRegion region, int fileIndex, uint offset)
            : base(string.Format("Attempted to load from file {0} to offset 0x{1:x} in region {2} of length 0x{3:x}", region.Files[fileIndex].Name, offset, region.Name, region.Length))
        {
            mRegion = region;
            mFileIndex = fileIndex;
            mOffset = offset;
        }
    }
}
