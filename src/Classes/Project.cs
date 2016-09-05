using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Porno_Graphic.Classes
{
    public class Project
    {
        private string mDisplayName = null;
        private bool mDirty;
        private GfxElementSet mGfxSet = null;
        private string mFilePath = null;

        public string DisplayName { get { return mDisplayName; } }
        public bool Dirty { get { return mDirty; } }
        public string FilePath { get { return mFilePath; } }

        public Project(string displayName, GfxElementSet gfxSet)
        {
            mDisplayName = displayName;
            mDirty = true;
            mGfxSet = gfxSet;
        }

        public void SetDirty()
        {
            mDirty = true;
        }

        public void Save(string path)
        {
            ChunkWriter writer = new ChunkWriter(new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write));
            using (writer)
            {
                writer.OpenChunk(ChunkType.ProjectHeader, 0U);
                writer.CloseChunk();
                writer.StartCompression();
                if ((mGfxSet != null) && ((mGfxSet.Elements != null) || (mGfxSet.ImportMetadata != null)))
                    mGfxSet.Write(writer);
            }
            mDirty = false;
            mFilePath = path;
            mDisplayName = Path.GetFileName(path);
        }
    }
}
