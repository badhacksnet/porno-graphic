using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Porno_Graphic
{
	public partial class PaletteSets : Form
	{
		public PaletteSets() {
			InitializeComponent();
			cboxPalSets.SelectedIndex = 0;
		}

		private void rb_Decimal_CheckedChanged(object sender, EventArgs e) {
			numUD_Red.Hexadecimal = false;
			numUD_Green.Hexadecimal = false;
			numUD_Blue.Hexadecimal = false;
		}

		private void rb_Hex_CheckedChanged(object sender, EventArgs e) {
			numUD_Red.Hexadecimal = true;
			numUD_Green.Hexadecimal = true;
			numUD_Blue.Hexadecimal = true;
		}

		private void numUD_Red_ValueChanged(object sender, EventArgs e) {
			// update palette thing
		}

		private void numUD_Green_ValueChanged(object sender, EventArgs e) {
			// update palette thing
		}

		private void numUD_Blue_ValueChanged(object sender, EventArgs e) {
			// update palette thing
		}
	}
}
