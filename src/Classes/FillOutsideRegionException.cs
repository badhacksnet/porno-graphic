using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Porno_Graphic.Classes
{
    class FillOutsideRegionException : Exception
    {
        LoadRegion mRegion;
        int mFillIndex;
        uint mOffset;

        public LoadRegion Region
        {
            get { return mRegion; }
        }
        public int FillIndex
        {
            get { return mFillIndex; }
        }
        public LoadRegion.Fill Fill
        {
            get { return mRegion.Fills[mFillIndex]; }
        }
        public uint Offset
        {
            get { return mOffset; }
        }

        public FillOutsideRegionException(LoadRegion region, int fillIndex, uint offset)
            : base(string.Format("Attempted to fill offset 0x{0:x} in region {1} of length 0x{2:x} with value 0x{3:x}", offset, region.Name, region.Length, region.Fills[fillIndex].Value))
        {
            mRegion = region;
            mFillIndex = fillIndex;
            mOffset = offset;
        }
    }
}
