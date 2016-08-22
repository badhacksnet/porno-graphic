using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Porno_Graphic
{
    public partial class TileImporter : Form
    {
        private Classes.GameProfile mProfile;

        public Classes.GameProfile Profile
        {
            get
            {
                return mProfile;
            }
            set
            {
                // TODO make this localisable

                mProfile = value;

                if (mProfile != null)
                    Text = string.Format("Import Tiles: {0}", mProfile.Name);
                else
                    Text = "Import Tiles";

                while (regionBox.Items.Count > 1)
                    regionBox.Items.RemoveAt(regionBox.Items.Count - 1);
                if ((mProfile != null) && (mProfile.LoadRegions != null))
                {
                    foreach (Classes.LoadRegion region in mProfile.LoadRegions)
                        regionBox.Items.Add(string.Format("{0} (0x{1:x} bytes)", region.Name, region.Length));
                }
                regionBox.SelectedIndex = 0;

                layoutBox.Items.Clear();
                if (mProfile != null)
                {
                    foreach (Classes.CharLayout layout in mProfile.CharLayouts)
                        layoutBox.Items.Add(string.Format("{0} ({1}×{2}×{3})", layout.Name, layout.Width, layout.Height, layout.Planes));
                }
            }
        }

        public TileImporter()
        {
            InitializeComponent();
        }

        private void layoutBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableImportButton();
        }

        private void offsetBox_TextChanged(object sender, EventArgs e)
        {
            if (IsValidNumber(offsetBox.Text))
                offsetBox.ForeColor = Color.Black;
            else
                offsetBox.ForeColor = Color.Red;
            EnableImportButton();
        }

        private void countBox_TextChanged(object sender, EventArgs e)
        {
            if (IsValidNumber(countBox.Text))
                countBox.ForeColor = Color.Black;
            else
                countBox.ForeColor = Color.Red;
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            // TODO make this localisable
            // TODO better error messages

            byte[] data = null;
            try
            {
                if (regionBox.SelectedIndex == 0)
                {
                    data = File.ReadAllBytes((string)fileGrid.Rows[0].Cells[2].Value);
                }
                else
                {
                    string[] paths = new string[fileGrid.Rows.Count];
                    for (int i = 0; i < paths.Length; i++)
                        paths[i] = (string)fileGrid.Rows[i].Cells[2].Value;
                    data = Profile.LoadRegions[regionBox.SelectedIndex - 1].LoadFiles(paths);
                }
            }
            catch
            {
                MessageBox.Show(Porno_Graphic.Properties.Resources.TileImporter_ErrorReadingFile);
                return;
            }

            uint offset = ParseNumber(offsetBox.Text);
            uint count = ParseNumber(countBox.Text);
            Classes.CharLayout layout = Profile.CharLayouts[layoutBox.SelectedIndex];
            if (layout.MaxElements(data, offset) < count)
            {
                MessageBox.Show(String.Format(Porno_Graphic.Properties.Resources.TileImporter_FileTooSmall, countBox.Text, offsetBox.Text));
                return;
            }

            Classes.GfxElement[] elements = new Classes.GfxElement[count];
            for (uint i = 0; i < count; i++)
                elements[i] = new Classes.GfxElement(data, layout, offset, i);

            TileViewer viewer = new TileViewer();
            viewer.MdiParent = MdiParent;
            viewer.ElementWidth = layout.Width;
            viewer.ElementHeight = layout.Height;
            viewer.Elements = elements;
            if (layout.Planes > 3)
                viewer.Palette = Classes.IndexedPalette.RGBI;
            else
                viewer.Palette = Classes.IndexedPalette.RGB;
            Close();
            viewer.Show();
        }

        private void EnableImportButton()
        {
            foreach (DataGridViewRow row in fileGrid.Rows)
            {
                if (row.Cells[2].Value.Equals(""))
                {
                    importButton.Enabled = false;
                    return;
                }
            }
            importButton.Enabled = (layoutBox.SelectedItem != null) && IsValidNumber(offsetBox.Text) && IsValidNumber(countBox.Text);
        }

        private bool IsValidNumber(string text)
        {
            uint temp;
            NumberStyles style = NumberStyles.Integer;
            if (text.StartsWith("0x", StringComparison.CurrentCultureIgnoreCase))
            {
                style = NumberStyles.HexNumber;
                text = text.Substring(2);
            }
            return uint.TryParse(text, style, CultureInfo.CurrentCulture, out temp);
        }

        private uint ParseNumber(string text)
        {
            NumberStyles style = NumberStyles.Integer;
            if (text.StartsWith("0x", StringComparison.CurrentCultureIgnoreCase))
            {
                style = NumberStyles.HexNumber;
                text = text.Substring(2);
            }
            return uint.Parse(text, style, CultureInfo.CurrentCulture);
        }

        private void regionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO make this localisable

            fileGrid.Rows.Clear();
            if (regionBox.SelectedIndex == 0)
            {
                int i = fileGrid.Rows.Add();
                fileGrid.Rows[i].Cells[0].Value = "data";
                fileGrid.Rows[i].Cells[2].Value = "";
            }
            else
            {
                foreach (Classes.LoadRegion.File file in Profile.LoadRegions[regionBox.SelectedIndex - 1].Files)
                {
                    int i = fileGrid.Rows.Add();
                    fileGrid.Rows[i].Cells[0].Value = file.Name;
                    fileGrid.Rows[i].Cells[2].Value = "";
                }
            }
            EnableImportButton();
        }

        private void fileGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // TODO make this localisable

            if ((fileGrid.Columns[e.ColumnIndex].Name == "browse") && (e.RowIndex >= 0))
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Title = string.Format("Select {0} file", fileGrid.Rows[e.RowIndex].Cells[0].Value);
                dialog.Filter = "All Files (*.*) | *.*";
                dialog.FilterIndex = 1;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    fileGrid.Rows[e.RowIndex].Cells[2].Value = dialog.FileName;
                    EnableImportButton();
                }
            }
        }

        private void fileGrid_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) && (((string[])e.Data.GetData(DataFormats.FileDrop)).Length == 1))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }

        private void fileGrid_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
            {
                string[] paths = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (paths.Length == 1)
                {
                    Point cursorPosition = fileGrid.PointToClient(Cursor.Position);
                    int row = fileGrid.HitTest(cursorPosition.X, cursorPosition.Y).RowIndex;
                    if (row >= 0)
                    {
                        fileGrid.Rows[row].Cells[2].Value = paths[0];
                        EnableImportButton();
                    }
                }
            }
        }
    }
}
