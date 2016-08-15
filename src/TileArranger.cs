/*
 * TileArranger - A scratchpad for arranging/drawing tiles.
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
	public partial class TileArranger : Form
	{
		public bool ShowGrid;

		public TileArranger() {
			InitializeComponent();
			ShowGrid = Porno_Graphic.Properties.Settings.Default.ArrangerGrid;
		}

		private void TileArranger_Resize(object sender, EventArgs e) {
			// something about snapping to tile multiples (e.g. 8px)
		}
	}
}
