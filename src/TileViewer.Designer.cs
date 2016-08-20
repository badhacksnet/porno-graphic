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
            this.tileGrid = new Porno_Graphic.Classes.ElementGridView();
            ((System.ComponentModel.ISupportInitialize)(this.xScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yScale)).BeginInit();
            this.SuspendLayout();
            // 
            // xScaleLabel
            // 
            this.xScaleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.xScaleLabel.Location = new System.Drawing.Point(12, 337);
            this.xScaleLabel.Name = "xScaleLabel";
            this.xScaleLabel.Size = new System.Drawing.Size(47, 13);
            this.xScaleLabel.TabIndex = 1;
            this.xScaleLabel.Text = "X Scale:";
            // 
            // xScale
            // 
            this.xScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.xScale.Location = new System.Drawing.Point(65, 335);
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
            this.yScaleLabel.Location = new System.Drawing.Point(12, 363);
            this.yScaleLabel.Name = "yScaleLabel";
            this.yScaleLabel.Size = new System.Drawing.Size(47, 13);
            this.yScaleLabel.TabIndex = 3;
            this.yScaleLabel.Text = "Y Scale:";
            // 
            // yScale
            // 
            this.yScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.yScale.Location = new System.Drawing.Point(65, 361);
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
            this.lockScale.Location = new System.Drawing.Point(120, 350);
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
            this.xFlip.Location = new System.Drawing.Point(176, 336);
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
            this.yFlip.Location = new System.Drawing.Point(176, 362);
            this.yFlip.Name = "yFlip";
            this.yFlip.Size = new System.Drawing.Size(52, 17);
            this.yFlip.TabIndex = 7;
            this.yFlip.Text = "Flip Y";
            this.yFlip.UseVisualStyleBackColor = true;
            this.yFlip.CheckedChanged += new System.EventHandler(this.yFlip_CheckedChanged);
            // 
            // tileGrid
            // 
            this.tileGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tileGrid.AutoScroll = true;
            this.tileGrid.AutoScrollMinSize = new System.Drawing.Size(622, 2);
            this.tileGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tileGrid.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.tileGrid.Location = new System.Drawing.Point(0, 0);
            this.tileGrid.Name = "tileGrid";
            this.tileGrid.Size = new System.Drawing.Size(624, 329);
            this.tileGrid.TabIndex = 0;
            this.tileGrid.Tag = "";
            // 
            // TileViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.yFlip);
            this.Controls.Add(this.xFlip);
            this.Controls.Add(this.lockScale);
            this.Controls.Add(this.yScale);
            this.Controls.Add(this.yScaleLabel);
            this.Controls.Add(this.xScale);
            this.Controls.Add(this.xScaleLabel);
            this.Controls.Add(this.tileGrid);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MinimumSize = new System.Drawing.Size(320, 240);
            this.Name = "TileViewer";
            this.Text = "[Tile Viewer]";
            this.Resize += new System.EventHandler(this.TileViewer_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.xScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yScale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}