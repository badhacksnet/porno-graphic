using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Porno_Graphic
{
	public partial class NewFileDialog : Form
	{
		public NewFileDialog() {
			InitializeComponent();
			cbox_DefaultFormat.SelectedIndex = 0;
		}

		private void cancelButton_Click(object sender, EventArgs e) {
			this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Close();
		}

		private void okButton_Click(object sender, EventArgs e) {
			// create new file with specified settings
			this.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.Close();
		}
	}
}
