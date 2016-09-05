using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Porno_Graphic
{
	public partial class MainForm : Form
	{
        private class ProjectState
        {
            public Classes.Project Project { get; private set; }
            public TileViewer TileViewer { get; set; }

            public ProjectState(Classes.Project project)
            {
                Project = project;
                TileViewer = null;
            }
        }

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
        private int mImportCount = 0;
		public int NewFileCount = 0;
		public int NumOpenDocuments = 0;
		public ToolTypes curActiveTool;
        private ProjectState mActiveProject = null;

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
		protected bool ShowSaveFileDialog(Classes.Project project)
        {
			SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = Properties.Resources.MainForm_ProjectFileFilter;
            dialog.FilterIndex = 1;
            dialog.Title = string.Format(Properties.Resources.MainForm_SaveProjectTitleFormat, mActiveProject.Project.DisplayName);
            if (dialog.ShowDialog() == DialogResult.OK)
                return SaveProject(project, dialog.FileName);
            else
                return false;
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
            if (mActiveProject != null)
			    ShowSaveFileDialog(mActiveProject.Project);
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
            if (mActiveProject != null)
            {
                if (mActiveProject.Project.FilePath != null)
                    SaveProject(mActiveProject.Project, mActiveProject.Project.FilePath);
                else
                    ShowSaveFileDialog(mActiveProject.Project);
            }
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

        private void menuItem_File_Import_Click(object sender, EventArgs e)
        {
            // TODO move this out to a different method
            // TODO make this localisable

            OpenFileDialog openProfileDialog = new OpenFileDialog();
            openProfileDialog.Title = "Select Profile";
            openProfileDialog.Filter = Properties.Resources.MainForm_GameProfileFileFilter;
            openProfileDialog.FilterIndex = 1;
            openProfileDialog.Multiselect = false;
            if (openProfileDialog.ShowDialog() != DialogResult.OK)
                return;

            StreamReader reader = null;
            Classes.GameProfile profile = null;
            try
            {
                reader = new StreamReader(openProfileDialog.FileName);
                XmlSerializer profileLoader = new XmlSerializer(typeof(Classes.GameProfile));
                profile = (Classes.GameProfile)profileLoader.Deserialize(reader);
            }
            catch
            {
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }

            if (profile == null)
            {
                // TODO more meaningful error message
                MessageBox.Show("Error loading profile");
                return;
            }

            TileImporter importer = new TileImporter(this, profile, openProfileDialog.FileName);
            importer.Show();
        }

        public void CreateImportProject(Classes.GfxElementSet elementSet, Classes.IPalette palette)
        {
            string displayName = string.Format(Porno_Graphic.Properties.Resources.MainForm_ImportProjectFormat, ++mImportCount);
            Classes.Project project = new Classes.Project(displayName, elementSet);
            TileViewer viewer = new TileViewer();
            viewer.MdiParent = this;
            viewer.ElementWidth = elementSet.ElementWidth;
            viewer.ElementHeight = elementSet.ElementHeight;
            viewer.Elements = elementSet.Elements;
            viewer.Palette = palette;

            ProjectState state = new ProjectState(project);
            state.TileViewer = viewer;

            viewer.Activated += new EventHandler(delegate (Object sender, EventArgs e)
            {
                mActiveProject = state;
            });

            viewer.FormClosing += new FormClosingEventHandler(delegate (object sender, FormClosingEventArgs e)
            {
                if (state.Project.Dirty)
                {
                    DialogResult result = MessageBox.Show(
                        string.Format(Properties.Resources.MainForm_ConfirmMessage_CloseWithoutSave, state.Project.DisplayName),
                        Properties.Resources.MainForm_ConfirmTitle_CloseWithoutSave,
                        MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.None,
                        MessageBoxDefaultButton.Button1);
                    switch (result)
                    {
                        case DialogResult.Yes:
                            if (state.Project.FilePath != null)
                                e.Cancel = !SaveProject(state.Project, state.Project.FilePath);
                            else
                                e.Cancel = !ShowSaveFileDialog(state.Project);
                            break;
                        case DialogResult.No:
                            e.Cancel = false;
                            break;
                        case DialogResult.Cancel:
                            e.Cancel = true;
                            break;
                    }
                }
            });

            viewer.FormClosed += new FormClosedEventHandler(delegate (object sender, FormClosedEventArgs e)
            {
                if (mActiveProject == state)
                    mActiveProject = null;
            });

            viewer.Show();
        }

        private void fileToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            menuItem_File_Save.Enabled = mActiveProject != null;
            menuItem_File_SaveAs.Enabled = mActiveProject != null;
            menuItem_File_Reload.Enabled = (mActiveProject != null) && (mActiveProject.Project.FilePath != null);
        }

        private bool SaveProject(Classes.Project project, string path)
        {
            try
            {
                project.Save(path);
                return true;
            }
            catch
            {
                // TODO: better error messages
                MessageBox.Show("Error saving project");
                return false;
            }
        }
    }
}
