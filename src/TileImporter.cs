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
                mProfile = value;
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

        private void pathButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "All Files (*.*) | *.*";
            dialog.FilterIndex = 1;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pathBox.Text = dialog.FileName;
            }
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
                data = File.ReadAllBytes(pathBox.Text);
            }
            catch
            {
                MessageBox.Show("Error reading file");
                return;
            }

            uint offset = ParseNumber(offsetBox.Text);
            uint count = ParseNumber(countBox.Text);
            Classes.CharLayout layout = Profile.CharLayouts[layoutBox.SelectedIndex];
            if (layout.MaxElements(data, offset) < count)
            {
                MessageBox.Show(String.Format("File is too small to load {0} element(s) from offset {1}", countBox.Text, offsetBox.Text));
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
            importButton.Enabled = (pathBox.Text.Length > 0) && (layoutBox.SelectedItem != null) && IsValidNumber(offsetBox.Text) && IsValidNumber(countBox.Text);
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
