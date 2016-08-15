namespace Porno_Graphic
{
	partial class PaletteSets
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
			this.cboxPalSets = new System.Windows.Forms.ComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.numUD_Blue = new System.Windows.Forms.NumericUpDown();
			this.labelBlue = new System.Windows.Forms.Label();
			this.numUD_Green = new System.Windows.Forms.NumericUpDown();
			this.labelGreen = new System.Windows.Forms.Label();
			this.numUD_Red = new System.Windows.Forms.NumericUpDown();
			this.labelRed = new System.Windows.Forms.Label();
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.button_AddPalset = new System.Windows.Forms.Button();
			this.button_RemovePalset = new System.Windows.Forms.Button();
			this.rb_Decimal = new System.Windows.Forms.RadioButton();
			this.rb_Hex = new System.Windows.Forms.RadioButton();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numUD_Blue)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numUD_Green)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numUD_Red)).BeginInit();
			this.SuspendLayout();
			// 
			// cboxPalSets
			// 
			this.cboxPalSets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboxPalSets.FormattingEnabled = true;
			this.cboxPalSets.Items.AddRange(new object[] {
            "Default"});
			this.cboxPalSets.Location = new System.Drawing.Point(12, 12);
			this.cboxPalSets.Name = "cboxPalSets";
			this.cboxPalSets.Size = new System.Drawing.Size(310, 21);
			this.cboxPalSets.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.numUD_Blue);
			this.groupBox1.Controls.Add(this.labelBlue);
			this.groupBox1.Controls.Add(this.numUD_Green);
			this.groupBox1.Controls.Add(this.labelGreen);
			this.groupBox1.Controls.Add(this.numUD_Red);
			this.groupBox1.Controls.Add(this.labelRed);
			this.groupBox1.Location = new System.Drawing.Point(12, 39);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(441, 183);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Palette Data";
			// 
			// numUD_Blue
			// 
			this.numUD_Blue.Location = new System.Drawing.Point(57, 157);
			this.numUD_Blue.Name = "numUD_Blue";
			this.numUD_Blue.Size = new System.Drawing.Size(67, 20);
			this.numUD_Blue.TabIndex = 5;
			this.numUD_Blue.ValueChanged += new System.EventHandler(this.numUD_Blue_ValueChanged);
			// 
			// labelBlue
			// 
			this.labelBlue.AutoSize = true;
			this.labelBlue.Location = new System.Drawing.Point(6, 159);
			this.labelBlue.Name = "labelBlue";
			this.labelBlue.Size = new System.Drawing.Size(28, 13);
			this.labelBlue.TabIndex = 4;
			this.labelBlue.Text = "Blue";
			// 
			// numUD_Green
			// 
			this.numUD_Green.Location = new System.Drawing.Point(57, 131);
			this.numUD_Green.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.numUD_Green.Name = "numUD_Green";
			this.numUD_Green.Size = new System.Drawing.Size(67, 20);
			this.numUD_Green.TabIndex = 3;
			this.numUD_Green.ValueChanged += new System.EventHandler(this.numUD_Green_ValueChanged);
			// 
			// labelGreen
			// 
			this.labelGreen.AutoSize = true;
			this.labelGreen.Location = new System.Drawing.Point(6, 133);
			this.labelGreen.Name = "labelGreen";
			this.labelGreen.Size = new System.Drawing.Size(36, 13);
			this.labelGreen.TabIndex = 2;
			this.labelGreen.Text = "Green";
			// 
			// numUD_Red
			// 
			this.numUD_Red.Location = new System.Drawing.Point(57, 105);
			this.numUD_Red.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.numUD_Red.Name = "numUD_Red";
			this.numUD_Red.Size = new System.Drawing.Size(67, 20);
			this.numUD_Red.TabIndex = 1;
			this.numUD_Red.ValueChanged += new System.EventHandler(this.numUD_Red_ValueChanged);
			// 
			// labelRed
			// 
			this.labelRed.AutoSize = true;
			this.labelRed.Location = new System.Drawing.Point(6, 107);
			this.labelRed.Name = "labelRed";
			this.labelRed.Size = new System.Drawing.Size(27, 13);
			this.labelRed.TabIndex = 0;
			this.labelRed.Text = "Red";
			// 
			// buttonOK
			// 
			this.buttonOK.Location = new System.Drawing.Point(297, 238);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 2;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(378, 238);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 3;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// button_AddPalset
			// 
			this.button_AddPalset.Location = new System.Drawing.Point(328, 10);
			this.button_AddPalset.Name = "button_AddPalset";
			this.button_AddPalset.Size = new System.Drawing.Size(60, 23);
			this.button_AddPalset.TabIndex = 4;
			this.button_AddPalset.Text = "Add";
			this.button_AddPalset.UseVisualStyleBackColor = true;
			// 
			// button_RemovePalset
			// 
			this.button_RemovePalset.Location = new System.Drawing.Point(394, 10);
			this.button_RemovePalset.Name = "button_RemovePalset";
			this.button_RemovePalset.Size = new System.Drawing.Size(60, 23);
			this.button_RemovePalset.TabIndex = 5;
			this.button_RemovePalset.Text = "Remove";
			this.button_RemovePalset.UseVisualStyleBackColor = true;
			// 
			// rb_Decimal
			// 
			this.rb_Decimal.AutoSize = true;
			this.rb_Decimal.Checked = true;
			this.rb_Decimal.Location = new System.Drawing.Point(12, 241);
			this.rb_Decimal.Name = "rb_Decimal";
			this.rb_Decimal.Size = new System.Drawing.Size(63, 17);
			this.rb_Decimal.TabIndex = 6;
			this.rb_Decimal.TabStop = true;
			this.rb_Decimal.Text = "Decimal";
			this.rb_Decimal.UseVisualStyleBackColor = true;
			this.rb_Decimal.CheckedChanged += new System.EventHandler(this.rb_Decimal_CheckedChanged);
			// 
			// rb_Hex
			// 
			this.rb_Hex.AutoSize = true;
			this.rb_Hex.Location = new System.Drawing.Point(81, 241);
			this.rb_Hex.Name = "rb_Hex";
			this.rb_Hex.Size = new System.Drawing.Size(86, 17);
			this.rb_Hex.TabIndex = 7;
			this.rb_Hex.Text = "Hexadecimal";
			this.rb_Hex.UseVisualStyleBackColor = true;
			this.rb_Hex.CheckedChanged += new System.EventHandler(this.rb_Hex_CheckedChanged);
			// 
			// PaletteSets
			// 
			this.AcceptButton = this.buttonOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(465, 273);
			this.Controls.Add(this.rb_Hex);
			this.Controls.Add(this.rb_Decimal);
			this.Controls.Add(this.button_RemovePalset);
			this.Controls.Add(this.button_AddPalset);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.cboxPalSets);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "PaletteSets";
			this.Text = "Palette Sets";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numUD_Blue)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numUD_Green)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numUD_Red)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cboxPalSets;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button button_AddPalset;
		private System.Windows.Forms.Button button_RemovePalset;
		private System.Windows.Forms.NumericUpDown numUD_Blue;
		private System.Windows.Forms.Label labelBlue;
		private System.Windows.Forms.NumericUpDown numUD_Green;
		private System.Windows.Forms.Label labelGreen;
		private System.Windows.Forms.NumericUpDown numUD_Red;
		private System.Windows.Forms.Label labelRed;
		private System.Windows.Forms.RadioButton rb_Decimal;
		private System.Windows.Forms.RadioButton rb_Hex;
	}
}