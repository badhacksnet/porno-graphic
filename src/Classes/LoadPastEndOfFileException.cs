using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Porno_Graphic.Classes
{
    class LoadPastEndOfFileException : Exception
    {
        private LoadRegion.File mFile;
        private int mInstructionIndex;
        private int mRead;

        public LoadRegion.File File { get { return mFile; } }
        public int InstructionIndex { get { return mInstructionIndex; } }
        public LoadRegion.Instruction Instruction { get { return mFile.Instructions[mInstructionIndex]; } }
        public int Read { get { return mRead; } }

        public LoadPastEndOfFileException(LoadRegion.File file, int instructionIndex, int read)
            : base(
                  string.Format(
                      "Attempted to read 0x{0:x} bytes from file {1} to load at offset 0x{2:x} but only got 0x{3:x} bytes",
                      file.Instructions[instructionIndex].Size,
                      file.Name,
                      file.Instructions[instructionIndex].Offset,
                      read))
        {
            mFile = file;
            mInstructionIndex = instructionIndex;
            mRead = read;
        }
    }
}
