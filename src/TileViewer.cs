/*
 * TileViewer - The interface for viewing and selecting tiles.
 * Handles most of the heavy lifting that isn't related to editing.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Porno_Graphic
{
	public partial class TileViewer : Form
	{
		/* todo: things we might need for each tile viewer...
		 * - File this window is associated with (or null if unsaved new file)
		 * - Current location in file
		 * - Current encoding type (e.g. 1bpp, 2bpp nes, etc.)
		 * - Currently selected tile
		 * - Current active palette
		 */

		public bool ShowGrid;
		public bool IsDirty; // Is the data is "dirty"? (has been edited since previous save)

		public TileViewer() {
			InitializeComponent();

			/* initialize tile viewer variables */
			ShowGrid = false; // xxx: should use current setting
			IsDirty = false;
		}

		private void TileViewer_Resize(object sender, EventArgs e) {
			// act like TLP:
			// * restrict size to 8 columns of 8px tiles minimum; 128 columns max??
			// * only resize by multiples of 8
		}
	}
}
