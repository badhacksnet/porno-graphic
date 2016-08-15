using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Porno_Graphic
{
	public partial class OptionsDialog : Form
	{
		public OptionsDialog() {
			InitializeComponent();
		}

		private void buttonOK_Click(object sender, EventArgs e) {
			/* save options */
			this.Close();
		}

		private void buttonCancel_Click(object sender, EventArgs e) {
			/* ignore changes/restore settings from load */
			this.Close();
		}
	}
}
