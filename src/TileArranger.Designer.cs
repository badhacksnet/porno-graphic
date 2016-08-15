namespace Porno_Graphic
{
	partial class TileArranger
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
			this.tileArrangerPanel = new System.Windows.Forms.Panel();
			this.arranger_HScrollbar = new System.Windows.Forms.HScrollBar();
			this.arranger_VScrollbar = new System.Windows.Forms.VScrollBar();
			this.tileArrangerPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// tileArrangerPanel
			// 
			this.tileArrangerPanel.AutoScroll = true;
			this.tileArrangerPanel.BackColor = System.Drawing.Color.Black;
			this.tileArrangerPanel.Controls.Add(this.arranger_HScrollbar);
			this.tileArrangerPanel.Controls.Add(this.arranger_VScrollbar);
			this.tileArrangerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tileArrangerPanel.ForeColor = System.Drawing.Color.White;
			this.tileArrangerPanel.Location = new System.Drawing.Point(0, 0);
			this.tileArrangerPanel.Name = "tileArrangerPanel";
			this.tileArrangerPanel.Size = new System.Drawing.Size(272, 288);
			this.tileArrangerPanel.TabIndex = 0;
			// 
			// arranger_HScrollbar
			// 
			this.arranger_HScrollbar.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.arranger_HScrollbar.Location = new System.Drawing.Point(0, 272);
			this.arranger_HScrollbar.Name = "arranger_HScrollbar";
			this.arranger_HScrollbar.Size = new System.Drawing.Size(256, 16);
			this.arranger_HScrollbar.TabIndex = 1;
			// 
			// arranger_VScrollbar
			// 
			this.arranger_VScrollbar.Dock = System.Windows.Forms.DockStyle.Right;
			this.arranger_VScrollbar.Location = new System.Drawing.Point(256, 0);
			this.arranger_VScrollbar.Name = "arranger_VScrollbar";
			this.arranger_VScrollbar.Size = new System.Drawing.Size(16, 288);
			this.arranger_VScrollbar.TabIndex = 0;
			// 
			// TileArranger
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(272, 288);
			this.ControlBox = false;
			this.Controls.Add(this.tileArrangerPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(280, 296);
			this.Name = "TileArranger";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "Tile Arranger";
			this.Resize += new System.EventHandler(this.TileArranger_Resize);
			this.tileArrangerPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel tileArrangerPanel;
		private System.Windows.Forms.VScrollBar arranger_VScrollbar;
		private System.Windows.Forms.HScrollBar arranger_HScrollbar;
	}
}