namespace Porno_Graphic
{
	partial class NewFileDialog
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cbox_DefaultFormat = new System.Windows.Forms.ComboBox();
			this.label_DefaultFormat = new System.Windows.Forms.Label();
			this.label_Kilobytes = new System.Windows.Forms.Label();
			this.label_NewFileSize = new System.Windows.Forms.Label();
			this.okButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.numUD_NewFileSize = new System.Windows.Forms.NumericUpDown();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numUD_NewFileSize)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.numUD_NewFileSize);
			this.groupBox1.Controls.Add(this.cbox_DefaultFormat);
			this.groupBox1.Controls.Add(this.label_DefaultFormat);
			this.groupBox1.Controls.Add(this.label_Kilobytes);
			this.groupBox1.Controls.Add(this.label_NewFileSize);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(268, 85);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "New File Settings";
			// 
			// cbox_DefaultFormat
			// 
			this.cbox_DefaultFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbox_DefaultFormat.FormattingEnabled = true;
			this.cbox_DefaultFormat.Items.AddRange(new object[] {
            "1bpp"});
			this.cbox_DefaultFormat.Location = new System.Drawing.Point(88, 49);
			this.cbox_DefaultFormat.Name = "cbox_DefaultFormat";
			this.cbox_DefaultFormat.Size = new System.Drawing.Size(174, 21);
			this.cbox_DefaultFormat.TabIndex = 4;
			// 
			// label_DefaultFormat
			// 
			this.label_DefaultFormat.AutoSize = true;
			this.label_DefaultFormat.Location = new System.Drawing.Point(6, 52);
			this.label_DefaultFormat.Name = "label_DefaultFormat";
			this.label_DefaultFormat.Size = new System.Drawing.Size(76, 13);
			this.label_DefaultFormat.TabIndex = 3;
			this.label_DefaultFormat.Text = "Default Format";
			// 
			// label_Kilobytes
			// 
			this.label_Kilobytes.AutoSize = true;
			this.label_Kilobytes.Location = new System.Drawing.Point(241, 26);
			this.label_Kilobytes.Name = "label_Kilobytes";
			this.label_Kilobytes.Size = new System.Drawing.Size(21, 13);
			this.label_Kilobytes.TabIndex = 2;
			this.label_Kilobytes.Text = "KB";
			// 
			// label_NewFileSize
			// 
			this.label_NewFileSize.AutoSize = true;
			this.label_NewFileSize.Location = new System.Drawing.Point(36, 26);
			this.label_NewFileSize.Name = "label_NewFileSize";
			this.label_NewFileSize.Size = new System.Drawing.Size(46, 13);
			this.label_NewFileSize.TabIndex = 0;
			this.label_NewFileSize.Text = "File Size";
			this.label_NewFileSize.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// okButton
			// 
			this.okButton.Location = new System.Drawing.Point(124, 103);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 1;
			this.okButton.Text = "OK";
			this.okButton.UseVisualStyleBackColor = true;
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(205, 103);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 2;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// numUD_NewFileSize
			// 
			this.numUD_NewFileSize.Location = new System.Drawing.Point(88, 23);
			this.numUD_NewFileSize.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
			this.numUD_NewFileSize.Name = "numUD_NewFileSize";
			this.numUD_NewFileSize.Size = new System.Drawing.Size(147, 20);
			this.numUD_NewFileSize.TabIndex = 5;
			// 
			// NewFileDialog
			// 
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(292, 136);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "NewFileDialog";
			this.Text = "New File";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numUD_NewFileSize)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.ComboBox cbox_DefaultFormat;
		private System.Windows.Forms.Label label_DefaultFormat;
		private System.Windows.Forms.Label label_Kilobytes;
		private System.Windows.Forms.Label label_NewFileSize;
		private System.Windows.Forms.NumericUpDown numUD_NewFileSize;

	}
}