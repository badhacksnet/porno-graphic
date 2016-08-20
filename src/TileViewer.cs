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

        public uint ElementWidth { get { return tileGrid.ElementWidth; } set { tileGrid.ElementWidth = value; } }
        public uint ElementHeight { get { return tileGrid.ElementHeight; } set { tileGrid.ElementHeight = value; } }
        public Classes.GfxElement[] Elements { get { return tileGrid.Elements; } set { tileGrid.Elements = value; } }
        public Classes.IPalette Palette { get { return tileGrid.Palette; } set { tileGrid.Palette = value; } }

        public bool ShowGrid;
		public bool IsDirty; // Is the data is "dirty"? (has been edited since previous save)

		public TileViewer() {
			InitializeComponent();

            rotate.SelectedIndex = 0;

			/* initialize tile viewer variables */
			ShowGrid = false; // xxx: should use current setting
			IsDirty = false;
		}

		private void TileViewer_Resize(object sender, EventArgs e) {
			// act like TLP:
			// * restrict size to 8 columns of 8px tiles minimum; 128 columns max??
			// * only resize by multiples of 8
		}

        private void xScale_ValueChanged(object sender, EventArgs e)
        {
            tileGrid.ScaleX = (uint)xScale.Value;
            if (lockScale.Checked)
                yScale.Value = xScale.Value;
        }

        private void yScale_ValueChanged(object sender, EventArgs e)
        {
            tileGrid.ScaleY = (uint)yScale.Value;
            if (lockScale.Checked)
                xScale.Value = yScale.Value;
        }

        private void lockScale_CheckedChanged(object sender, EventArgs e)
        {
            if (lockScale.Checked)
                yScale.Value = xScale.Value;
        }

        private void xFlip_CheckedChanged(object sender, EventArgs e)
        {
            tileGrid.FlipX = xFlip.Checked;
        }

        private void yFlip_CheckedChanged(object sender, EventArgs e)
        {
            tileGrid.FlipY = yFlip.Checked;
        }

        private void rotate_SelectedIndexChanged(object sender, EventArgs e)
        {
            tileGrid.Rotate = (uint)rotate.SelectedIndex;
        }
    }
}
