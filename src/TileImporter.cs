using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Porno_Graphic
{
    public partial class TileImporter : Form
    {
        private MainForm mParent;
        private Classes.GameProfile mProfile;
        private string mProfilePath;

        public Classes.GameProfile Profile
        {
            get
            {
                return mProfile;
            }
            set
            {
                mProfile = value;
                mProfilePath = null;

                if (mProfile != null)
                    Text = string.Format(Porno_Graphic.Properties.Resources.TileImporter_PopulatedTitle, mProfile.Name);
                else
                    Text = Porno_Graphic.Properties.Resources.TileImporter_UnpopulatedTitle;

                while (regionBox.Items.Count > 1)
                    regionBox.Items.RemoveAt(regionBox.Items.Count - 1);
                if ((mProfile != null) && (mProfile.LoadRegions != null))
                {
                    foreach (Classes.LoadRegion region in mProfile.LoadRegions)
                    {
                        regionBox.Items.Add(
                            string.Format(
                                Porno_Graphic.Properties.Resources.TileImporter_RegionDisplayFormat,
                                region.Name,
                                region.Length));
                    }
                }
                regionBox.SelectedIndex = 0;

                layoutBox.Items.Clear();
                if (mProfile != null)
                {
                    foreach (Classes.CharLayout layout in mProfile.CharLayouts)
                    {
                        layoutBox.Items.Add(
                            string.Format(
                                Porno_Graphic.Properties.Resources.TileImporter_LayoutDisplayFormat,
                                layout.Name,
                                layout.Width,
                                layout.Height,
                                layout.Planes));
                    }
                }
            }
        }

        public TileImporter(MainForm parent, Classes.GameProfile profile, string profilePath)
        {
            InitializeComponent();
            mParent = parent;
            MdiParent = parent;
            Profile = profile;
            mProfilePath = profilePath;
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
            EnableImportButton();
        }

        private void fracNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            fracDenUpDown.Minimum = fracNumUpDown.Value;
        }

        private void fracDenUpDown_ValueChanged(object sender, EventArgs e)
        {
            fracNumUpDown.Maximum = fracDenUpDown.Value;
        }

        private void countButton_CheckedChanged(object sender, EventArgs e)
        {
            countBox.Enabled = countButton.Checked;
            if (countButton.Checked)
                fractionButton.Checked = false;
            EnableImportButton();
        }

        private void fractionButton_CheckedChanged(object sender, EventArgs e)
        {
            fracNumUpDown.Enabled = fractionButton.Checked;
            fracDenUpDown.Enabled = fractionButton.Checked;
            if (fractionButton.Checked)
                countButton.Checked = false;
            EnableImportButton();
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            Classes.CharLayout layout = Profile.CharLayouts[layoutBox.SelectedIndex];
            byte[] data = null;
            uint offset = ParseNumber(offsetBox.Text);
            uint count;
            try
            {
                if (regionBox.SelectedIndex == 0)
                {
                    data = File.ReadAllBytes((string)fileGrid.Rows[0].Cells[3].Value);
                    count = countButton.Checked ? ParseNumber(countBox.Text) : (uint)(8U * data.Length / layout.Stride * fracNumUpDown.Value / fracDenUpDown.Value);
                    uint max = layout.MaxElements((uint)data.Length, offset);
                    if (max < count)
                    {
                        string displayCount = countButton.Checked ? countBox.Text : count.ToString();
                        MessageBox.Show(
                            String.Format(
                                Porno_Graphic.Properties.Resources.TileImporter_ErrorMessage_FileTooSmall,
                                displayCount,
                                offsetBox.Text,
                                data.Length,
                                max),
                            Porno_Graphic.Properties.Resources.TileImporter_ErrorTitle_FileTooSmall);
                        return;
                    }
                }
                else
                {
                    Classes.LoadRegion region = Profile.LoadRegions[regionBox.SelectedIndex - 1];
                    count = countButton.Checked ? ParseNumber(countBox.Text) : (uint)(8U * region.Length / layout.Stride * fracNumUpDown.Value / fracDenUpDown.Value);
                    uint max = layout.MaxElements(region.Length, offset);
                    if (max < count)
                    {
                        string displayCount = countButton.Checked ? countBox.Text : count.ToString();
                        MessageBox.Show(
                            String.Format(
                                Porno_Graphic.Properties.Resources.TileImporter_ErrorMessage_RegionTooSmall,
                                region.Name,
                                region.Length,
                                displayCount,
                                offsetBox.Text,
                                max),
                            Porno_Graphic.Properties.Resources.TileImporter_ErrorTitle_RegionTooSmall);
                        return;
                    }
                    string[] paths = new string[fileGrid.Rows.Count];
                    for (int i = 0; i < paths.Length; i++)
                        paths[i] = (string)fileGrid.Rows[i].Cells[3].Value;
                    data = region.LoadFiles(paths);
                }
            }
            catch (Classes.LoadPastEndOfFileException ex)
            {
                MessageBox.Show(
                    string.Format(
                        Porno_Graphic.Properties.Resources.TileImporter_ErrorMessage_ReadPastFileEnd,
                        ex.File.Name,
                        ex.Instruction.Offset,
                        ex.Instruction.Size,
                        ex.Read),
                    Porno_Graphic.Properties.Resources.TileImporter_ErrorTitle_ReadPastFileEnd);
                return;
            }
            catch (Classes.LoadOutsideRegionException ex)
            {
                MessageBox.Show(
                    string.Format(
                        Porno_Graphic.Properties.Resources.TileImporter_ErrorMessage_LoadBeyondRegionEnd,
                        ex.Region.Name,
                        ex.Region.Length,
                        ex.Offset,
                        ex.File.Name),
                    Porno_Graphic.Properties.Resources.TileImporter_ErrorTitle_LoadBeyondRegionEnd);
                return;
            }
            catch (Classes.FillOutsideRegionException ex)
            {
                MessageBox.Show(
                    string.Format(
                        Porno_Graphic.Properties.Resources.TileImporter_ErrorMessage_FillBeyondRegionEnd,
                        ex.Region.Name,
                        ex.Region.Length,
                        ex.Offset,
                        ex.Fill.Value),
                    Porno_Graphic.Properties.Resources.TileImporter_ErrorTitle_FillBeyondRegionEnd);
                return;
            }
            catch
            {
                MessageBox.Show(Porno_Graphic.Properties.Resources.TileImporter_ErrorReadingFile);
                return;
            }

            Classes.GfxElement[] elements = new Classes.GfxElement[count];
            Parallel.For(0, count, index => { elements[index] = new Classes.GfxElement(data, layout, offset, (uint)index); });

            Classes.TileImportMetadata metadata = new Classes.TileImportMetadata();
            if (mProfilePath != null)
                metadata.ProfileFile = Path.GetFileName(mProfilePath);
            metadata.ProfileName = mProfile.Name;
            metadata.RegionName = (string)regionBox.SelectedItem;
            metadata.LayoutName = (string)layoutBox.SelectedItem;
            metadata.Offset = offsetBox.Text;
            Classes.GfxElementSet elementSet = new Classes.GfxElementSet();
            elementSet.ElementWidth = layout.Width;
            elementSet.ElementHeight = layout.Height;
            elementSet.Elements = elements;
            elementSet.ImportMetadata = metadata;
            mParent.CreateImportProject(elementSet, (layout.Planes > 3) ? Classes.IndexedPalette.RGBI : Classes.IndexedPalette.RGB);
            Close();
        }

        private void regionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            fileGrid.Rows.Clear();
            if (regionBox.SelectedIndex == 0)
            {
                int i = fileGrid.Rows.Add();
                fileGrid.Rows[i].Cells[0].Value = Porno_Graphic.Properties.Resources.TileImporter_FlatFileDisplayName;
                fileGrid.Rows[i].Cells[1].Value = "";
                fileGrid.Rows[i].Cells[3].Value = "";
            }
            else
            {
                foreach (Classes.LoadRegion.File file in Profile.LoadRegions[regionBox.SelectedIndex - 1].Files)
                {
                    int i = fileGrid.Rows.Add();
                    fileGrid.Rows[i].Cells[0].Value = file.Name;
                    fileGrid.Rows[i].Cells[1].Value = String.Format("0x{0:x}", file.LoadedLength);
                    fileGrid.Rows[i].Cells[3].Value = "";
                }
            }
            EnableImportButton();
        }

        private void fileGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((fileGrid.Columns[e.ColumnIndex].Name == "browse") && (e.RowIndex >= 0))
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Title = string.Format(Porno_Graphic.Properties.Resources.TileImporter_OpenDataFileTitle, fileGrid.Rows[e.RowIndex].Cells[0].Value);
                dialog.Filter = Porno_Graphic.Properties.Resources.TileImporter_OpenDataFileFilter;
                dialog.FilterIndex = 1;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    fileGrid.Rows[e.RowIndex].Cells[3].Value = dialog.FileName;
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
                        fileGrid.Rows[row].Cells[3].Value = paths[0];
                        EnableImportButton();
                    }
                }
            }
        }

        private void EnableImportButton()
        {
            foreach (DataGridViewRow row in fileGrid.Rows)
            {
                if (row.Cells[3].Value.Equals(""))
                {
                    importButton.Enabled = false;
                    return;
                }
            }
            if (countButton.Checked && (!IsValidNumber(countBox.Text) || (ParseNumber(countBox.Text) < 1U)))
            {
                importButton.Enabled = false;
                return;
            }
            if (fractionButton.Checked && ((fracNumUpDown.Value < 1U) || (fracNumUpDown.Value < 1U) || (fracNumUpDown.Value > fracDenUpDown.Value)))
            {
                importButton.Enabled = false;
                return;
            }
            importButton.Enabled = (layoutBox.SelectedItem != null) && IsValidNumber(offsetBox.Text);
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
    }
}
