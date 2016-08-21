namespace Porno_Graphic
{
	partial class TileViewer
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
			this.xScaleLabel = new System.Windows.Forms.Label();
			this.xScale = new System.Windows.Forms.NumericUpDown();
			this.yScaleLabel = new System.Windows.Forms.Label();
			this.yScale = new System.Windows.Forms.NumericUpDown();
			this.lockScale = new System.Windows.Forms.CheckBox();
			this.xFlip = new System.Windows.Forms.CheckBox();
			this.yFlip = new System.Windows.Forms.CheckBox();
			this.rotateLabel = new System.Windows.Forms.Label();
			this.rotate = new System.Windows.Forms.ComboBox();
			this.groupBox_Options = new System.Windows.Forms.GroupBox();
			this.tileGrid = new Porno_Graphic.Classes.ElementGridView();
			((System.ComponentModel.ISupportInitialize)(this.xScale)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.yScale)).BeginInit();
			this.groupBox_Options.SuspendLayout();
			this.SuspendLayout();
			// 
			// xScaleLabel
			// 
			this.xScaleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.xScaleLabel.Location = new System.Drawing.Point(12, 33);
			this.xScaleLabel.Name = "xScaleLabel";
			this.xScaleLabel.Size = new System.Drawing.Size(47, 13);
			this.xScaleLabel.TabIndex = 1;
			this.xScaleLabel.Text = "X Scale:";
			// 
			// xScale
			// 
			this.xScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.xScale.Location = new System.Drawing.Point(65, 31);
			this.xScale.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
			this.xScale.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.xScale.Name = "xScale";
			this.xScale.Size = new System.Drawing.Size(48, 20);
			this.xScale.TabIndex = 2;
			this.xScale.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.xScale.ValueChanged += new System.EventHandler(this.xScale_ValueChanged);
			// 
			// yScaleLabel
			// 
			this.yScaleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.yScaleLabel.Location = new System.Drawing.Point(12, 59);
			this.yScaleLabel.Name = "yScaleLabel";
			this.yScaleLabel.Size = new System.Drawing.Size(47, 13);
			this.yScaleLabel.TabIndex = 3;
			this.yScaleLabel.Text = "Y Scale:";
			// 
			// yScale
			// 
			this.yScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.yScale.Location = new System.Drawing.Point(65, 57);
			this.yScale.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
			this.yScale.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.yScale.Name = "yScale";
			this.yScale.Size = new System.Drawing.Size(48, 20);
			this.yScale.TabIndex = 4;
			this.yScale.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.yScale.ValueChanged += new System.EventHandler(this.yScale_ValueChanged);
			// 
			// lockScale
			// 
			this.lockScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lockScale.Checked = true;
			this.lockScale.CheckState = System.Windows.Forms.CheckState.Checked;
			this.lockScale.Location = new System.Drawing.Point(120, 46);
			this.lockScale.Name = "lockScale";
			this.lockScale.Size = new System.Drawing.Size(50, 17);
			this.lockScale.TabIndex = 5;
			this.lockScale.Text = "Lock";
			this.lockScale.UseVisualStyleBackColor = true;
			this.lockScale.CheckedChanged += new System.EventHandler(this.lockScale_CheckedChanged);
			// 
			// xFlip
			// 
			this.xFlip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.xFlip.AutoSize = true;
			this.xFlip.Location = new System.Drawing.Point(176, 32);
			this.xFlip.Name = "xFlip";
			this.xFlip.Size = new System.Drawing.Size(52, 17);
			this.xFlip.TabIndex = 6;
			this.xFlip.Text = "Flip X";
			this.xFlip.UseVisualStyleBackColor = true;
			this.xFlip.CheckedChanged += new System.EventHandler(this.xFlip_CheckedChanged);
			// 
			// yFlip
			// 
			this.yFlip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.yFlip.AutoSize = true;
			this.yFlip.Location = new System.Drawing.Point(176, 58);
			this.yFlip.Name = "yFlip";
			this.yFlip.Size = new System.Drawing.Size(52, 17);
			this.yFlip.TabIndex = 7;
			this.yFlip.Text = "Flip Y";
			this.yFlip.UseVisualStyleBackColor = true;
			this.yFlip.CheckedChanged += new System.EventHandler(this.yFlip_CheckedChanged);
			// 
			// rotateLabel
			// 
			this.rotateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.rotateLabel.Location = new System.Drawing.Point(234, 47);
			this.rotateLabel.Name = "rotateLabel";
			this.rotateLabel.Size = new System.Drawing.Size(48, 13);
			this.rotateLabel.TabIndex = 8;
			this.rotateLabel.Text = "Rotate:";
			// 
			// rotate
			// 
			this.rotate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.rotate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.rotate.FormattingEnabled = true;
			this.rotate.Items.AddRange(new object[] {
            "0°",
            "90°",
            "180°",
            "270°"});
			this.rotate.Location = new System.Drawing.Point(288, 44);
			this.rotate.Name = "rotate";
			this.rotate.Size = new System.Drawing.Size(64, 21);
			this.rotate.TabIndex = 9;
			this.rotate.SelectedIndexChanged += new System.EventHandler(this.rotate_SelectedIndexChanged);
			// 
			// groupBox_Options
			// 
			this.groupBox_Options.Controls.Add(this.xScaleLabel);
			this.groupBox_Options.Controls.Add(this.rotate);
			this.groupBox_Options.Controls.Add(this.xScale);
			this.groupBox_Options.Controls.Add(this.rotateLabel);
			this.groupBox_Options.Controls.Add(this.yScaleLabel);
			this.groupBox_Options.Controls.Add(this.yFlip);
			this.groupBox_Options.Controls.Add(this.yScale);
			this.groupBox_Options.Controls.Add(this.xFlip);
			this.groupBox_Options.Controls.Add(this.lockScale);
			this.groupBox_Options.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupBox_Options.Location = new System.Drawing.Point(0, 346);
			this.groupBox_Options.Name = "groupBox_Options";
			this.groupBox_Options.Size = new System.Drawing.Size(624, 100);
			this.groupBox_Options.TabIndex = 10;
			this.groupBox_Options.TabStop = false;
			this.groupBox_Options.Text = "Options";
			// 
			// tileGrid
			// 
			this.tileGrid.AutoScroll = true;
			this.tileGrid.AutoScrollMinSize = new System.Drawing.Size(622, 2);
			this.tileGrid.Dock = System.Windows.Forms.DockStyle.Top;
			this.tileGrid.Elements = new Porno_Graphic.Classes.GfxElement[0];
			this.tileGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.tileGrid.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
			this.tileGrid.Location = new System.Drawing.Point(0, 0);
			this.tileGrid.Name = "tileGrid";
			this.tileGrid.Palette = null;
			this.tileGrid.Size = new System.Drawing.Size(624, 329);
			this.tileGrid.TabIndex = 0;
			this.tileGrid.Tag = "";
			// 
			// TileViewer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(624, 446);
			this.Controls.Add(this.groupBox_Options);
			this.Controls.Add(this.tileGrid);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.MinimumSize = new System.Drawing.Size(320, 240);
			this.Name = "TileViewer";
			this.Text = "[Tile Viewer]";
			this.Resize += new System.EventHandler(this.TileViewer_Resize);
			((System.ComponentModel.ISupportInitialize)(this.xScale)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.yScale)).EndInit();
			this.groupBox_Options.ResumeLayout(false);
			this.groupBox_Options.PerformLayout();
			this.ResumeLayout(false);

		}

        #endregion

        private Classes.ElementGridView tileGrid;
        private System.Windows.Forms.NumericUpDown xScale;
        private System.Windows.Forms.Label yScaleLabel;
        private System.Windows.Forms.NumericUpDown yScale;
        private System.Windows.Forms.Label xScaleLabel;
        private System.Windows.Forms.CheckBox lockScale;
        private System.Windows.Forms.CheckBox yFlip;
        private System.Windows.Forms.CheckBox xFlip;
        private System.Windows.Forms.Label rotateLabel;
		private System.Windows.Forms.ComboBox rotate;
		private System.Windows.Forms.GroupBox groupBox_Options;
    }
}