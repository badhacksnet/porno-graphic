using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Porno_Graphic.Classes
{
    [Flags]
    public enum ChunkType : ulong
    {
        ProjectHeader = 0x706f726e70726f6a, // 'pornproj'

        GfxElementSet = 0x676678656c656d73, // 'gfxelems'
        GfxElementSetInfo = 0x74696c65696e666f, // 'tileinfo'
        GfxElement = 0x706f726e6f676678, // 'pornogfx'
        TileImportMetadata = 0x696d706f72746564, // 'imported'
        TileViewerState = 0x74696c6576696577 // 'tileview'
    }
}
