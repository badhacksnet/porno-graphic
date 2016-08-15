using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Porno_Graphic
{
	public partial class MainForm : Form
	{
		/* -- types and shit -- */
		public enum ToolTypes {
			Tool_Pointer = 0,
			Tool_Selection,
			Tool_ColorPicker,
			Tool_FloodFill,
			Tool_Line,
			Tool_RectLine,
			Tool_RectFill,
			Tool_RectStrokeFill,
			Tool_CircleLine,
			Tool_CircleFill,
			Tool_CircleStrokeFill,
			NUM_ToolTypes
		};

		/* -- main form variables -- */
		public int NewFileCount = 0;
		public int NumOpenDocuments = 0;
		public ToolTypes curActiveTool;

		/* -- other important things -- */
		TileArranger arrangerForm; // the tile arranger/scratchboard
		TileEditor editorForm; // the tile editor

		// todo: currently active palette set number

		/* -- preferences/options/whatever -- */
		public bool ShowEditorGrid;
		public bool ShowArrangerGrid;
		public bool ShowViewerGrid;

		public Color EditorGridColor;
		public Color ArrangerGridColor;
		public Color ViewerGridColor;

		/* -- save/load filters-- */
		public String defaultLoadFilter = "All Supported Files|*.bin,*.nes,*.gb,*.gbc,*.gba,*.sfc,*.smc,*.smd,*.gen,*.chr,*.pce|All Files|*.*";
		public String defaultSaveFilter = "All Files|*.*";
		//public String paletteLoadFilter = "All Supported Palette Files|*.pgpal,*.act,*.pal,*.ngpal|Porno-Graphic Palette|*.pgpal|Adobe ACT|*.act|Jasc PAL|*.pal|NGFX Palette|*.ngpal|All Files|*.*";
		//public String paletteSaveFilter = "Porno-Graphic Palette|*.pgpal|Adobe ACT|*.act|Jasc PAL|*.pal|NGFX Palette|*.ngpal|All Files|*.*";

		/* == begin form code == */
		public MainForm() {
			InitializeComponent();

			/* set any status strip items to open upwards and to the right (subject to change) */
			mainStatusStrip.DefaultDropDownDirection = ToolStripDropDownDirection.AboveRight;

			/* tool related */
			curActiveTool = ToolTypes.Tool_Pointer;

			/* palette related */
			cBox_ActivePaletteSet.SelectedIndex = 0;

			/* add tile editor to main window */
			editorForm = new TileEditor();
			editorForm.MdiParent = this;
			editorForm.Show();

			/* add tile arranger to main window */
			arrangerForm = new TileArranger();
			arrangerForm.MdiParent = this;
			arrangerForm.Show();

			/* set variables from settings/config */
			ShowEditorGrid = Porno_Graphic.Properties.Settings.Default.EditorGrid;
			ShowArrangerGrid = Porno_Graphic.Properties.Settings.Default.ArrangerGrid;
			ShowViewerGrid = Porno_Graphic.Properties.Settings.Default.ViewerGrid;
			EditorGridColor = Porno_Graphic.Properties.Settings.Default.EditorGridColor;
			ArrangerGridColor = Porno_Graphic.Properties.Settings.Default.ArrangerGridColor;
			ViewerGridColor = Porno_Graphic.Properties.Settings.Default.ViewerGridColor;

			/* initialize grid item checkmarks */
			menuItem_View_GridEdit.Checked = ShowEditorGrid;
			menuItem_View_GridArranger.Checked = ShowArrangerGrid;
			menuItem_View_GridView.Checked = ShowViewerGrid;
		}

		private void menuItem_File_Exit_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
			AboutDialog about = new AboutDialog();
			about.ShowDialog();
		}

		#region Active Tool status routines
		private void SetTool_Pointer() {
			/* set current tool to mouse pointer */
			curActiveTool = ToolTypes.Tool_Pointer;

			/* check mouse pointer button */
			this.toolToolStrip_Button_Pointer.Checked = true;
			/* uncheck other tool buttons */
			this.toolToolStrip_Button_Colorpicker.Checked = false;
			this.toolToolStrip_Button_Selection.Checked = false;
			this.toolToolStrip_Button_Fill.Checked = false;
			this.toolToolStrip_Button_Line.Checked = false;
			this.toolToolStrip_Button_RectLine.Checked = false;
			this.toolToolStrip_Button_RectFill.Checked = false;
			this.toolToolStrip_Button_RectStrokeFill.Checked = false;
			this.toolToolStrip_Button_CircleLine.Checked = false;
			this.toolToolStrip_Button_CircleFill.Checked = false;
			this.toolToolStrip_Button_CircleStrokeFill.Checked = false;
		}

		private void SetTool_Selection() {
			/* set current tool to selection */
			curActiveTool = ToolTypes.Tool_Selection;
			/* check selection button */
			this.toolToolStrip_Button_Selection.Checked = true;
			/* uncheck other tool buttons */
			this.toolToolStrip_Button_Pointer.Checked = false;
			this.toolToolStrip_Button_Colorpicker.Checked = false;
			this.toolToolStrip_Button_Fill.Checked = false;
			this.toolToolStrip_Button_Line.Checked = false;
			this.toolToolStrip_Button_RectLine.Checked = false;
			this.toolToolStrip_Button_RectFill.Checked = false;
			this.toolToolStrip_Button_RectStrokeFill.Checked = false;
			this.toolToolStrip_Button_CircleLine.Checked = false;
			this.toolToolStrip_Button_CircleFill.Checked = false;
			this.toolToolStrip_Button_CircleStrokeFill.Checked = false;
		}

		private void SetTool_ColorPicker() {
			/* set current tool to color picker */
			curActiveTool = ToolTypes.Tool_ColorPicker;

			/* check color picker button */
			this.toolToolStrip_Button_Colorpicker.Checked = true;
			/* uncheck other tool buttons */
			this.toolToolStrip_Button_Pointer.Checked = false;
			this.toolToolStrip_Button_Selection.Checked = false;
			this.toolToolStrip_Button_Fill.Checked = false;
			this.toolToolStrip_Button_Line.Checked = false;
			this.toolToolStrip_Button_RectLine.Checked = false;
			this.toolToolStrip_Button_RectFill.Checked = false;
			this.toolToolStrip_Button_RectStrokeFill.Checked = false;
			this.toolToolStrip_Button_CircleLine.Checked = false;
			this.toolToolStrip_Button_CircleFill.Checked = false;
			this.toolToolStrip_Button_CircleStrokeFill.Checked = false;
		}

		private void SetTool_Fill() {
			/* set current tool to flood fill */
			curActiveTool = ToolTypes.Tool_FloodFill;

			/* check flood fill button */
			this.toolToolStrip_Button_Fill.Checked = true;
			/* uncheck other tool buttons */
			this.toolToolStrip_Button_Pointer.Checked = false;
			this.toolToolStrip_Button_Selection.Checked = false;
			this.toolToolStrip_Button_Colorpicker.Checked = false;
			this.toolToolStrip_Button_Line.Checked = false;
			this.toolToolStrip_Button_RectLine.Checked = false;
			this.toolToolStrip_Button_RectFill.Checked = false;
			this.toolToolStrip_Button_RectStrokeFill.Checked = false;
			this.toolToolStrip_Button_CircleLine.Checked = false;
			this.toolToolStrip_Button_CircleFill.Checked = false;
			this.toolToolStrip_Button_CircleStrokeFill.Checked = false;
		}

		private void SetTool_Line() {
			/* set current tool to line */
			curActiveTool = ToolTypes.Tool_Line;

			/* check line button */
			this.toolToolStrip_Button_Line.Checked = true;
			/* uncheck other tool buttons */
			this.toolToolStrip_Button_Pointer.Checked = false;
			this.toolToolStrip_Button_Selection.Checked = false;
			this.toolToolStrip_Button_Colorpicker.Checked = false;
			this.toolToolStrip_Button_Fill.Checked = false;
			this.toolToolStrip_Button_RectLine.Checked = false;
			this.toolToolStrip_Button_RectFill.Checked = false;
			this.toolToolStrip_Button_RectStrokeFill.Checked = false;
			this.toolToolStrip_Button_CircleLine.Checked = false;
			this.toolToolStrip_Button_CircleFill.Checked = false;
			this.toolToolStrip_Button_CircleStrokeFill.Checked = false;
		}

		private void SetTool_RectLine() {
			/* set current tool to hollow rectangle */
			curActiveTool = ToolTypes.Tool_RectLine;

			/* check hollow rectangle button */
			this.toolToolStrip_Button_RectLine.Checked = true;
			/* uncheck other tool buttons */
			this.toolToolStrip_Button_Pointer.Checked = false;
			this.toolToolStrip_Button_Selection.Checked = false;
			this.toolToolStrip_Button_Colorpicker.Checked = false;
			this.toolToolStrip_Button_Fill.Checked = false;
			this.toolToolStrip_Button_Line.Checked = false;
			this.toolToolStrip_Button_RectFill.Checked = false;
			this.toolToolStrip_Button_RectStrokeFill.Checked = false;
			this.toolToolStrip_Button_CircleLine.Checked = false;
			this.toolToolStrip_Button_CircleFill.Checked = false;
			this.toolToolStrip_Button_CircleStrokeFill.Checked = false;
		}

		private void SetTool_RectFill() {
			/* set current tool to filled rectangle */
			curActiveTool = ToolTypes.Tool_RectFill;

			/* check filled rectangle button */
			this.toolToolStrip_Button_RectFill.Checked = true;
			/* uncheck other tool buttons */
			this.toolToolStrip_Button_Pointer.Checked = false;
			this.toolToolStrip_Button_Selection.Checked = false;
			this.toolToolStrip_Button_Colorpicker.Checked = false;
			this.toolToolStrip_Button_Fill.Checked = false;
			this.toolToolStrip_Button_Line.Checked = false;
			this.toolToolStrip_Button_RectLine.Checked = false;
			this.toolToolStrip_Button_RectStrokeFill.Checked = false;
			this.toolToolStrip_Button_CircleLine.Checked = false;
			this.toolToolStrip_Button_CircleFill.Checked = false;
			this.toolToolStrip_Button_CircleStrokeFill.Checked = false;
		}

		private void SetTool_RectStrokeFill() {
			/* set current tool to stroke filled rectangle */
			curActiveTool = ToolTypes.Tool_RectStrokeFill;

			/* check stroke filled rectangle button */
			this.toolToolStrip_Button_RectStrokeFill.Checked = true;
			/* uncheck other tool buttons */
			this.toolToolStrip_Button_Pointer.Checked = false;
			this.toolToolStrip_Button_Selection.Checked = false;
			this.toolToolStrip_Button_Colorpicker.Checked = false;
			this.toolToolStrip_Button_Fill.Checked = false;
			this.toolToolStrip_Button_Line.Checked = false;
			this.toolToolStrip_Button_RectLine.Checked = false;
			this.toolToolStrip_Button_RectFill.Checked = false;
			this.toolToolStrip_Button_CircleLine.Checked = false;
			this.toolToolStrip_Button_CircleFill.Checked = false;
			this.toolToolStrip_Button_CircleStrokeFill.Checked = false;
		}

		private void SetTool_CircleLine() {
			/* set current tool to hollow circle */
			curActiveTool = ToolTypes.Tool_CircleLine;

			/* check hollow circle button */
			this.toolToolStrip_Button_CircleLine.Checked = true;
			/* uncheck other tool buttons */
			this.toolToolStrip_Button_Pointer.Checked = false;
			this.toolToolStrip_Button_Selection.Checked = false;
			this.toolToolStrip_Button_Colorpicker.Checked = false;
			this.toolToolStrip_Button_Fill.Checked = false;
			this.toolToolStrip_Button_Line.Checked = false;
			this.toolToolStrip_Button_RectLine.Checked = false;
			this.toolToolStrip_Button_RectFill.Checked = false;
			this.toolToolStrip_Button_RectStrokeFill.Checked = false;
			this.toolToolStrip_Button_CircleFill.Checked = false;
			this.toolToolStrip_Button_CircleStrokeFill.Checked = false;
		}

		private void SetTool_CircleFill() {
			/* set current tool to filled circle */
			curActiveTool = ToolTypes.Tool_CircleFill;
			/* check filled circle button */
			this.toolToolStrip_Button_CircleFill.Checked = true;
			/* uncheck other tool buttons */
			this.toolToolStrip_Button_Pointer.Checked = false;
			this.toolToolStrip_Button_Selection.Checked = false;
			this.toolToolStrip_Button_Colorpicker.Checked = false;
			this.toolToolStrip_Button_Fill.Checked = false;
			this.toolToolStrip_Button_Line.Checked = false;
			this.toolToolStrip_Button_RectLine.Checked = false;
			this.toolToolStrip_Button_RectFill.Checked = false;
			this.toolToolStrip_Button_RectStrokeFill.Checked = false;
			this.toolToolStrip_Button_CircleLine.Checked = false;
			this.toolToolStrip_Button_CircleStrokeFill.Checked = false;
		}

		private void SetTool_CircleStrokeFill() {
			/* set current tool to stroked filled circle */
			curActiveTool = ToolTypes.Tool_CircleStrokeFill;
			/* check stroked filled circle button */
			this.toolToolStrip_Button_CircleStrokeFill.Checked = true;
			/* uncheck other tool buttons */
			this.toolToolStrip_Button_Pointer.Checked = false;
			this.toolToolStrip_Button_Selection.Checked = false;
			this.toolToolStrip_Button_Colorpicker.Checked = false;
			this.toolToolStrip_Button_Fill.Checked = false;
			this.toolToolStrip_Button_Line.Checked = false;
			this.toolToolStrip_Button_RectLine.Checked = false;
			this.toolToolStrip_Button_RectFill.Checked = false;
			this.toolToolStrip_Button_RectStrokeFill.Checked = false;
			this.toolToolStrip_Button_CircleLine.Checked = false;
			this.toolToolStrip_Button_CircleFill.Checked = false;
		}
		#endregion

		#region Tool toolstrip buttons
		private void toolToolStrip_Button_Pointer_Click(object sender, EventArgs e) {
			SetTool_Pointer();
		}

		private void toolToolStrip_Button_Selection_Click(object sender, EventArgs e) {
			SetTool_Selection();
		}

		private void toolToolStrip_Button_Colorpicker_Click(object sender, EventArgs e) {
			SetTool_ColorPicker();
		}

		private void toolToolStrip_Button_Fill_Click(object sender, EventArgs e) {
			SetTool_Fill();
		}

		private void toolToolStrip_Button_Line_Click(object sender, EventArgs e) {
			SetTool_Line();
		}

		private void toolToolStrip_Button_RectLine_Click(object sender, EventArgs e) {
			SetTool_RectLine();
		}

		private void toolToolStrip_Button_RectFill_Click(object sender, EventArgs e) {
			SetTool_RectFill();
		}

		private void toolToolStrip_Button_RectStrokeFill_Click(object sender, EventArgs e) {
			SetTool_RectStrokeFill();
		}

		private void toolToolStrip_Button_CircleLine_Click(object sender, EventArgs e) {
			SetTool_CircleLine();
		}

		private void toolToolStrip_Button_CircleFill_Click(object sender, EventArgs e) {
			SetTool_CircleFill();
		}

		private void toolToolStrip_Button_CircleStrokeFill_Click(object sender, EventArgs e) {
			SetTool_CircleStrokeFill();
		}
		#endregion

		/*
		 * CreateNewDocument()
		 * Creates a new document window after a NewFileDialog is shown.
		 */
		protected void CreateNewDocument() {
			/* bring up the new file dialog */
			NewFileDialog nfd = new NewFileDialog();
			nfd.ShowDialog();

			/* if the dialog was OK, then make a new file */
			if (nfd.DialogResult == System.Windows.Forms.DialogResult.OK) {
				/* xxx: somewhat temporary code to create a new form. */
				TileViewer a = new TileViewer();
				a.MdiParent = this;
				/* icon, caption */
				a.Icon = Porno_Graphic.Properties.Resources.Document;
				a.Text = String.Format("NewFile{0:d02}", NewFileCount);
				/* todo: background color should probably match palette entry 0 */
				a.BackColor = Color.Black;
				a.Show();

				/* increment counters */
				NewFileCount++;
				NumOpenDocuments++;
			}
		}

		/*
		 * ShowOpenFileDialog()
		 * Shows the open file dialog.
		 */
		protected void ShowOpenFileDialog() {
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = defaultLoadFilter;
			if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
				/* load file data */

				/* create new TileViewer */
				//use ofd.FileName.EndsWith(".xxx") to determine input format/bpp setting

				//NumOpenDocuments++;
			}
		}

		/*
		 * ShowSaveFileDialog()
		 * Shows the save file dialog.
		 */
		protected void ShowSaveFileDialog() {
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = defaultSaveFilter;
			if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
				/* save file data */
			}
		}

		/*
		 * ShowOptionDialog()
		 * Shows the options dialog.
		 */
		protected void ShowOptionsDialog() {
			OptionsDialog opt = new OptionsDialog();
			if (opt.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
				/* save yer options, buddy */
			}
		}

		#region CreateNewDocument callers
		/* Routines that call CreateNewDocument */
		private void mainToolStrip_Button_New_Click(object sender, EventArgs e) {
			CreateNewDocument();
		}

		private void menuItem_File_New_Click(object sender, EventArgs e) {
			CreateNewDocument();
		}
		#endregion

		#region ShowOpenFileDialog callers
		/* Routines that call ShowOpenFileDialog */
		private void mainToolStrip_Button_Open_Click(object sender, EventArgs e) {
			ShowOpenFileDialog();
		}

		private void menuItem_File_Open_Click(object sender, EventArgs e) {
			ShowOpenFileDialog();
		}
		#endregion

		#region ShowSaveFileDialog callers
		/* Routines that call ShowSaveFileDialog */
		private void menuItem_File_SaveAs_Click(object sender, EventArgs e) {
			ShowSaveFileDialog();
		}
		#endregion

		#region ShowOptionsDialog callers
		private void mainToolStrip_Button_Options_Click(object sender, EventArgs e) {
			ShowOptionsDialog();
		}

		private void menuItem_Tools_Options_Click(object sender, EventArgs e) {
			ShowOptionsDialog();
		}
		#endregion

		#region Regular saving routines
		/* Routines that only call ShowSaveFileDialog if this is a new file */
		private void menuItem_File_Save_Click(object sender, EventArgs e) {

		}

		private void mainToolStrip_Button_Save_Click(object sender, EventArgs e) {

		}
		#endregion

		private void mainToolStrip_Button_Reload_Click(object sender, EventArgs e) {
			/* reload currently active document from disk */
		}

		#region Window management routines
		private void menuItem_Window_Editor_Click(object sender, EventArgs e) {
			/* bring tile editor to the front */
			editorForm.BringToFront();
		}

		private void menuItem_Window_Arranger_Click(object sender, EventArgs e) {
			/* bring tile arranger to the front */
			arrangerForm.BringToFront();
		}

		private void closeAllToolStripMenuItem_Click(object sender, EventArgs e) {
			foreach(Form f in this.MdiChildren){
				/* somewhat hacky way of not closing the tile arranger and editor */
				if(f.Name != arrangerForm.Name && f.Name != editorForm.Name){
					/* todo: check if a window is "dirty"/needs to be saved */
					f.Close();
					NumOpenDocuments--;
				}
			}
		}
		#endregion

		#region Palette load/save routines
		private void loadPaletteToolStripMenuItem_Click(object sender, EventArgs e) {
			/* load palette data from file */
		}

		private void savePaletteToolStripMenuItem_Click(object sender, EventArgs e) {
			/* save palette data to file */
		}

		private void menu_PaletteItem_Import_Click(object sender, EventArgs e) {
			/* import palette from currently opened and active file */
		}
		#endregion

		#region Grid toggle
		private void viewerGridToolStripMenuItem_Click(object sender, EventArgs e) {
			ShowViewerGrid = !ShowViewerGrid;
			Porno_Graphic.Properties.Settings.Default.ViewerGrid = ShowViewerGrid;
			Porno_Graphic.Properties.Settings.Default.Save();
			/* toggle TileViewer grid */
			// xxx: is this per-document or for all documents?
		}

		private void editorGridToolStripMenuItem_Click(object sender, EventArgs e) {
			ShowEditorGrid = !ShowEditorGrid;
			Porno_Graphic.Properties.Settings.Default.EditorGrid = ShowEditorGrid;
			Porno_Graphic.Properties.Settings.Default.Save();
			/* toggle TileEditor grid */
			editorForm.ShowGrid = ShowEditorGrid;
		}

		private void menuItem_View_GridArranger_Click(object sender, EventArgs e) {
			ShowArrangerGrid = !ShowArrangerGrid;
			Porno_Graphic.Properties.Settings.Default.ArrangerGrid = ShowArrangerGrid;
			Porno_Graphic.Properties.Settings.Default.Save();
			/* toggle TileArranger grid */
			arrangerForm.ShowGrid = ShowArrangerGrid;
		}
		#endregion

		private void cBox_ActivePaletteSet_SelectedIndexChanged(object sender, EventArgs e) {
			// update active palette set
		}

		protected void ShowPaletteSetDialog() {
			PaletteSets palSets = new PaletteSets();
			palSets.ShowDialog();
		}

		#region access palette set dialog
		private void menuItem_Palette_PalSets_Click(object sender, EventArgs e) {
			ShowPaletteSetDialog();
		}

		private void button_EditPalSets_Click(object sender, EventArgs e) {
			ShowPaletteSetDialog();
		}
		#endregion

		#region Drag/Drop handling
		private void MainForm_DragEnter(object sender, DragEventArgs e) {
			/* check if this is a file */
			if(e.Data.GetDataPresent(DataFormats.FileDrop,false)){
				// ok cool, it's a file, at least.
			}
		}

		private void MainForm_DragDrop(object sender, DragEventArgs e) {
			/* dragging and dropping an item (e.g. a file) onto the main window */
		}
		#endregion

	}
}
