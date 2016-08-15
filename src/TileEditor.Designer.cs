namespace Porno_Graphic
{
	partial class TileEditor
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
			this.panel_TileEditor = new System.Windows.Forms.Panel();
			this.editorToolStrip = new System.Windows.Forms.ToolStrip();
			this.editorToolStrip_Button_FlipH = new System.Windows.Forms.ToolStripButton();
			this.editorToolStrip_Button_FlipV = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.editorToolStrip_Button_NudgeUp = new System.Windows.Forms.ToolStripButton();
			this.editorToolStrip_Button_NudgeDown = new System.Windows.Forms.ToolStripButton();
			this.editorToolStrip_Button_NudgeLeft = new System.Windows.Forms.ToolStripButton();
			this.editorToolStrip_Button_NudgeRight = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.editorToolStrip_Button_RotateClockwise = new System.Windows.Forms.ToolStripButton();
			this.editorToolStrip_Button_RotateCounterClockwise = new System.Windows.Forms.ToolStripButton();
			this.editorToolStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel_TileEditor
			// 
			this.panel_TileEditor.BackColor = System.Drawing.Color.Black;
			this.panel_TileEditor.ForeColor = System.Drawing.Color.White;
			this.panel_TileEditor.Location = new System.Drawing.Point(0, 28);
			this.panel_TileEditor.Name = "panel_TileEditor";
			this.panel_TileEditor.Size = new System.Drawing.Size(128, 128);
			this.panel_TileEditor.TabIndex = 0;
			this.panel_TileEditor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_TileEditor_MouseClick);
			this.panel_TileEditor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_TileEditor_MouseDown);
			this.panel_TileEditor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_TileEditor_MouseUp);
			// 
			// editorToolStrip
			// 
			this.editorToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.editorToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editorToolStrip_Button_FlipH,
            this.editorToolStrip_Button_FlipV,
            this.toolStripSeparator1,
            this.editorToolStrip_Button_NudgeUp,
            this.editorToolStrip_Button_NudgeDown,
            this.editorToolStrip_Button_NudgeLeft,
            this.editorToolStrip_Button_NudgeRight,
            this.toolStripSeparator2,
            this.editorToolStrip_Button_RotateClockwise,
            this.editorToolStrip_Button_RotateCounterClockwise});
			this.editorToolStrip.Location = new System.Drawing.Point(0, 0);
			this.editorToolStrip.Name = "editorToolStrip";
			this.editorToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.editorToolStrip.Size = new System.Drawing.Size(202, 25);
			this.editorToolStrip.TabIndex = 0;
			this.editorToolStrip.Text = "Tile Editor Toolstrip";
			// 
			// editorToolStrip_Button_FlipH
			// 
			this.editorToolStrip_Button_FlipH.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.editorToolStrip_Button_FlipH.Image = global::Porno_Graphic.Properties.Resources.FlipHorizontal;
			this.editorToolStrip_Button_FlipH.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.editorToolStrip_Button_FlipH.Name = "editorToolStrip_Button_FlipH";
			this.editorToolStrip_Button_FlipH.Size = new System.Drawing.Size(23, 22);
			this.editorToolStrip_Button_FlipH.Text = "Horizontal Flip";
			this.editorToolStrip_Button_FlipH.Click += new System.EventHandler(this.editorToolStrip_Button_FlipH_Click);
			// 
			// editorToolStrip_Button_FlipV
			// 
			this.editorToolStrip_Button_FlipV.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.editorToolStrip_Button_FlipV.Image = global::Porno_Graphic.Properties.Resources.FlipVertical;
			this.editorToolStrip_Button_FlipV.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.editorToolStrip_Button_FlipV.Name = "editorToolStrip_Button_FlipV";
			this.editorToolStrip_Button_FlipV.Size = new System.Drawing.Size(23, 22);
			this.editorToolStrip_Button_FlipV.Text = "Vertical Flip";
			this.editorToolStrip_Button_FlipV.Click += new System.EventHandler(this.editorToolStrip_Button_FlipV_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// editorToolStrip_Button_NudgeUp
			// 
			this.editorToolStrip_Button_NudgeUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.editorToolStrip_Button_NudgeUp.Image = global::Porno_Graphic.Properties.Resources.NudgeUp;
			this.editorToolStrip_Button_NudgeUp.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.editorToolStrip_Button_NudgeUp.Name = "editorToolStrip_Button_NudgeUp";
			this.editorToolStrip_Button_NudgeUp.Size = new System.Drawing.Size(23, 22);
			this.editorToolStrip_Button_NudgeUp.Text = "Nudge Up";
			this.editorToolStrip_Button_NudgeUp.Click += new System.EventHandler(this.editorToolStrip_Button_NudgeUp_Click);
			// 
			// editorToolStrip_Button_NudgeDown
			// 
			this.editorToolStrip_Button_NudgeDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.editorToolStrip_Button_NudgeDown.Image = global::Porno_Graphic.Properties.Resources.NudgeDown;
			this.editorToolStrip_Button_NudgeDown.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.editorToolStrip_Button_NudgeDown.Name = "editorToolStrip_Button_NudgeDown";
			this.editorToolStrip_Button_NudgeDown.Size = new System.Drawing.Size(23, 22);
			this.editorToolStrip_Button_NudgeDown.Text = "Nudge Down";
			this.editorToolStrip_Button_NudgeDown.Click += new System.EventHandler(this.editorToolStrip_Button_NudgeDown_Click);
			// 
			// editorToolStrip_Button_NudgeLeft
			// 
			this.editorToolStrip_Button_NudgeLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.editorToolStrip_Button_NudgeLeft.Image = global::Porno_Graphic.Properties.Resources.NudgeLeft;
			this.editorToolStrip_Button_NudgeLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.editorToolStrip_Button_NudgeLeft.Name = "editorToolStrip_Button_NudgeLeft";
			this.editorToolStrip_Button_NudgeLeft.Size = new System.Drawing.Size(23, 22);
			this.editorToolStrip_Button_NudgeLeft.Text = "Nudge Left";
			this.editorToolStrip_Button_NudgeLeft.Click += new System.EventHandler(this.editorToolStrip_Button_NudgeLeft_Click);
			// 
			// editorToolStrip_Button_NudgeRight
			// 
			this.editorToolStrip_Button_NudgeRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.editorToolStrip_Button_NudgeRight.Image = global::Porno_Graphic.Properties.Resources.NudgeRight;
			this.editorToolStrip_Button_NudgeRight.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.editorToolStrip_Button_NudgeRight.Name = "editorToolStrip_Button_NudgeRight";
			this.editorToolStrip_Button_NudgeRight.Size = new System.Drawing.Size(23, 22);
			this.editorToolStrip_Button_NudgeRight.Text = "Nudge Right";
			this.editorToolStrip_Button_NudgeRight.Click += new System.EventHandler(this.editorToolStrip_Button_NudgeRight_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// editorToolStrip_Button_RotateClockwise
			// 
			this.editorToolStrip_Button_RotateClockwise.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.editorToolStrip_Button_RotateClockwise.Image = global::Porno_Graphic.Properties.Resources.rotate_clockwise;
			this.editorToolStrip_Button_RotateClockwise.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.editorToolStrip_Button_RotateClockwise.Name = "editorToolStrip_Button_RotateClockwise";
			this.editorToolStrip_Button_RotateClockwise.Size = new System.Drawing.Size(23, 22);
			this.editorToolStrip_Button_RotateClockwise.Text = "Rotate 90º Clockwise";
			this.editorToolStrip_Button_RotateClockwise.Click += new System.EventHandler(this.editorToolStrip_Button_RotateClockwise_Click);
			// 
			// editorToolStrip_Button_RotateCounterClockwise
			// 
			this.editorToolStrip_Button_RotateCounterClockwise.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.editorToolStrip_Button_RotateCounterClockwise.Image = global::Porno_Graphic.Properties.Resources.rotate_counterclockwise;
			this.editorToolStrip_Button_RotateCounterClockwise.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.editorToolStrip_Button_RotateCounterClockwise.Name = "editorToolStrip_Button_RotateCounterClockwise";
			this.editorToolStrip_Button_RotateCounterClockwise.Size = new System.Drawing.Size(23, 20);
			this.editorToolStrip_Button_RotateCounterClockwise.Text = "Rotate 90º Counter-clockwise";
			this.editorToolStrip_Button_RotateCounterClockwise.Click += new System.EventHandler(this.editorToolStrip_Button_RotateCounterClockwise_Click);
			// 
			// TileEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(202, 158);
			this.ControlBox = false;
			this.Controls.Add(this.editorToolStrip);
			this.Controls.Add(this.panel_TileEditor);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "TileEditor";
			this.Text = "Tile Editor";
			this.editorToolStrip.ResumeLayout(false);
			this.editorToolStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel_TileEditor;
		private System.Windows.Forms.ToolStrip editorToolStrip;
		private System.Windows.Forms.ToolStripButton editorToolStrip_Button_FlipH;
		private System.Windows.Forms.ToolStripButton editorToolStrip_Button_FlipV;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton editorToolStrip_Button_NudgeLeft;
		private System.Windows.Forms.ToolStripButton editorToolStrip_Button_NudgeRight;
		private System.Windows.Forms.ToolStripButton editorToolStrip_Button_NudgeUp;
		private System.Windows.Forms.ToolStripButton editorToolStrip_Button_NudgeDown;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton editorToolStrip_Button_RotateClockwise;
		private System.Windows.Forms.ToolStripButton editorToolStrip_Button_RotateCounterClockwise;
	}
}