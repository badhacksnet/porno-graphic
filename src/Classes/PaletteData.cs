/*
 * PaletteData - Primary representation of palette data.
 * WORK IN PROGRESS IMPLEMENTATION SUBJECT TO CHANGE
 * PLEASE DISCUSS -kadong
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Porno_Graphic
{
	/*
	 * -- Thoughts about the PaletteData class --
	 * We draw to a DirectBitmap, which expects PARGB data as Int32.
	 *
	 * Some consoles have a fixed palette (e.g. NES, GB); others have a
	 * multi-component system (e.g. TG16/PCE, Genesis, Neo-Geo).
	 * This file does not deal with that, as far as I can tell.
	 */

	public enum PaletteType {
		Component = 0, // separate RGB components
		Fixed = 1,     // hardcoded system palette (e.g. NES)
		NUM_PaletteType
	};

	/* Systems with fixed palettes */
	public enum PaletteSystem {
		None = 0, // for PaletteType.Component
		NES, // NES has hardcoded colors in indexes.
		NUM_PaletteSystem
	};

	class PaletteData
	{
		public int NumPalEntries; // entries per palette set (e.g. 4 on NES, 16 on Genesis, SNES, etc.)
		public Int32[] PalEntries; // palette data
		public PaletteType PalType; // palette type (component vs. fixed)
		public PaletteSystem PalSystem; // palette system (only useful for fixed)

		public PaletteData(PaletteType _type, int _entries){
			NumPalEntries = _entries;
			PalType = PaletteType.Component;
			PalEntries = new Int32[NumPalEntries];
			PalSystem = PaletteSystem.None;
		}

		public PaletteData(PaletteType _type, int _entries, PaletteSystem _system) {
			NumPalEntries = _entries;
			PalType = PaletteType.Component;
			PalEntries = new Int32[NumPalEntries];
			PalSystem = _system;
		}
	}
}
