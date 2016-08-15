using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Porno_Graphic
{
	public partial class TileEditor : Form
	{
		public bool ShowGrid;
		public TileEditor() {
			InitializeComponent();
			/* set tile editor vars */
			ShowGrid = false; // xxx: should use current setting
		}

		#region UI buttons
		private void editorToolStrip_Button_FlipH_Click(object sender, EventArgs e) {
			/* flip tile horizontally */
		}

		private void editorToolStrip_Button_FlipV_Click(object sender, EventArgs e) {
			/* flip tile vertically */
		}

		private void editorToolStrip_Button_NudgeUp_Click(object sender, EventArgs e) {
			/* nudge tile up */
		}

		private void editorToolStrip_Button_NudgeDown_Click(object sender, EventArgs e) {
			/* nudge tile down */
		}

		private void editorToolStrip_Button_NudgeLeft_Click(object sender, EventArgs e) {
			/* nudge tile left */
		}

		private void editorToolStrip_Button_NudgeRight_Click(object sender, EventArgs e) {
			/* nudge tile right */
		}

		private void editorToolStrip_Button_RotateClockwise_Click(object sender, EventArgs e) {
			/* rotate tile 90 degrees to the right */
		}

		private void editorToolStrip_Button_RotateCounterClockwise_Click(object sender, EventArgs e) {
			/* rotate tile 90 degrees to the left */
		}
		#endregion

		#region Mouse Events
		private void panel_TileEditor_MouseClick(object sender, MouseEventArgs e) {
			/* This is where the bulk of the work happens. */
			/*
			 * check curActiveTool to see what we're expected to do.
			 * also check e.Button for System.Windows.Forms.MouseButtons.Left or System.Windows.Forms.MouseButtons.Right
			 * (do we want to handle middle click?)
			 */
		}

		private void panel_TileEditor_MouseDown(object sender, MouseEventArgs e) {
			/* check if we're in a tool that needs continuous holding (e.g. line tool) */
		}

		private void panel_TileEditor_MouseUp(object sender, MouseEventArgs e) {
			/* check if we're in a tool that needs continuous holding (e.g. line tool) */
		}
		#endregion
	}
}
