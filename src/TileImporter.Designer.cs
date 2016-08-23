namespace Porno_Graphic
{
    partial class TileImporter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutBox = new System.Windows.Forms.ComboBox();
            this.layoutLabel = new System.Windows.Forms.Label();
            this.offsetBox = new System.Windows.Forms.TextBox();
            this.offsetLabel = new System.Windows.Forms.Label();
            this.countBox = new System.Windows.Forms.TextBox();
            this.importButton = new System.Windows.Forms.Button();
            this.fileGrid = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.browse = new System.Windows.Forms.DataGridViewButtonColumn();
            this.path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regionLabel = new System.Windows.Forms.Label();
            this.regionBox = new System.Windows.Forms.ComboBox();
            this.countButton = new System.Windows.Forms.RadioButton();
            this.fractionButton = new System.Windows.Forms.RadioButton();
            this.fracNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.fracSepLabel = new System.Windows.Forms.Label();
            this.fracDenUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.fileGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fracNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fracDenUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutBox
            // 
            this.layoutBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.layoutBox.FormattingEnabled = true;
            this.layoutBox.Location = new System.Drawing.Point(66, 218);
            this.layoutBox.Name = "layoutBox";
            this.layoutBox.Size = new System.Drawing.Size(386, 21);
            this.layoutBox.TabIndex = 0;
            this.layoutBox.SelectedIndexChanged += new System.EventHandler(this.layoutBox_SelectedIndexChanged);
            // 
            // layoutLabel
            // 
            this.layoutLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.layoutLabel.Location = new System.Drawing.Point(12, 221);
            this.layoutLabel.Name = "layoutLabel";
            this.layoutLabel.Size = new System.Drawing.Size(48, 13);
            this.layoutLabel.TabIndex = 2;
            this.layoutLabel.Text = "Layout:";
            // 
            // offsetBox
            // 
            this.offsetBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.offsetBox.Location = new System.Drawing.Point(90, 245);
            this.offsetBox.Name = "offsetBox";
            this.offsetBox.Size = new System.Drawing.Size(120, 20);
            this.offsetBox.TabIndex = 5;
            this.offsetBox.Text = "0x0";
            this.offsetBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.offsetBox.TextChanged += new System.EventHandler(this.offsetBox_TextChanged);
            // 
            // offsetLabel
            // 
            this.offsetLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.offsetLabel.Location = new System.Drawing.Point(12, 248);
            this.offsetLabel.Name = "offsetLabel";
            this.offsetLabel.Size = new System.Drawing.Size(72, 13);
            this.offsetLabel.TabIndex = 6;
            this.offsetLabel.Text = "Offset:";
            // 
            // countBox
            // 
            this.countBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.countBox.Location = new System.Drawing.Point(90, 271);
            this.countBox.Name = "countBox";
            this.countBox.Size = new System.Drawing.Size(120, 20);
            this.countBox.TabIndex = 7;
            this.countBox.Text = "1";
            this.countBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.countBox.TextChanged += new System.EventHandler(this.countBox_TextChanged);
            // 
            // importButton
            // 
            this.importButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.importButton.Enabled = false;
            this.importButton.Location = new System.Drawing.Point(377, 297);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(75, 23);
            this.importButton.TabIndex = 9;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // fileGrid
            // 
            this.fileGrid.AllowDrop = true;
            this.fileGrid.AllowUserToAddRows = false;
            this.fileGrid.AllowUserToDeleteRows = false;
            this.fileGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fileGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.browse,
            this.path});
            this.fileGrid.Location = new System.Drawing.Point(12, 39);
            this.fileGrid.Name = "fileGrid";
            this.fileGrid.RowHeadersVisible = false;
            this.fileGrid.Size = new System.Drawing.Size(440, 173);
            this.fileGrid.TabIndex = 10;
            this.fileGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.fileGrid_CellContentClick);
            this.fileGrid.DragDrop += new System.Windows.Forms.DragEventHandler(this.fileGrid_DragDrop);
            this.fileGrid.DragEnter += new System.Windows.Forms.DragEventHandler(this.fileGrid_DragEnter);
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.name.Width = 41;
            // 
            // browse
            // 
            this.browse.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.browse.HeaderText = "";
            this.browse.Name = "browse";
            this.browse.ReadOnly = true;
            this.browse.Text = "Browse...";
            this.browse.UseColumnTextForButtonValue = true;
            this.browse.Width = 5;
            // 
            // path
            // 
            this.path.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.path.HeaderText = "File (path)";
            this.path.Name = "path";
            this.path.ReadOnly = true;
            this.path.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // regionLabel
            // 
            this.regionLabel.Location = new System.Drawing.Point(12, 15);
            this.regionLabel.Name = "regionLabel";
            this.regionLabel.Size = new System.Drawing.Size(48, 13);
            this.regionLabel.TabIndex = 12;
            this.regionLabel.Text = "Region:";
            // 
            // regionBox
            // 
            this.regionBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.regionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.regionBox.FormattingEnabled = true;
            this.regionBox.Items.AddRange(new object[] {
            "Flat file"});
            this.regionBox.Location = new System.Drawing.Point(66, 12);
            this.regionBox.Name = "regionBox";
            this.regionBox.Size = new System.Drawing.Size(386, 21);
            this.regionBox.TabIndex = 11;
            this.regionBox.SelectedIndexChanged += new System.EventHandler(this.regionBox_SelectedIndexChanged);
            // 
            // countButton
            // 
            this.countButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.countButton.Checked = true;
            this.countButton.Location = new System.Drawing.Point(12, 272);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(72, 17);
            this.countButton.TabIndex = 13;
            this.countButton.TabStop = true;
            this.countButton.Text = "Count:";
            this.countButton.UseVisualStyleBackColor = true;
            this.countButton.CheckedChanged += new System.EventHandler(this.countButton_CheckedChanged);
            // 
            // fractionButton
            // 
            this.fractionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fractionButton.Location = new System.Drawing.Point(12, 297);
            this.fractionButton.Name = "fractionButton";
            this.fractionButton.Size = new System.Drawing.Size(72, 17);
            this.fractionButton.TabIndex = 14;
            this.fractionButton.Text = "Fraction:";
            this.fractionButton.UseVisualStyleBackColor = true;
            this.fractionButton.CheckedChanged += new System.EventHandler(this.fractionButton_CheckedChanged);
            // 
            // fracNumUpDown
            // 
            this.fracNumUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fracNumUpDown.Enabled = false;
            this.fracNumUpDown.Location = new System.Drawing.Point(90, 297);
            this.fracNumUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fracNumUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fracNumUpDown.Name = "fracNumUpDown";
            this.fracNumUpDown.Size = new System.Drawing.Size(48, 20);
            this.fracNumUpDown.TabIndex = 15;
            this.fracNumUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.fracNumUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fracNumUpDown.ValueChanged += new System.EventHandler(this.fracNumUpDown_ValueChanged);
            // 
            // fracSepLabel
            // 
            this.fracSepLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fracSepLabel.AutoSize = true;
            this.fracSepLabel.Location = new System.Drawing.Point(144, 299);
            this.fracSepLabel.Name = "fracSepLabel";
            this.fracSepLabel.Size = new System.Drawing.Size(12, 13);
            this.fracSepLabel.TabIndex = 16;
            this.fracSepLabel.Text = "/";
            // 
            // fracDenUpDown
            // 
            this.fracDenUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fracDenUpDown.Enabled = false;
            this.fracDenUpDown.Location = new System.Drawing.Point(162, 297);
            this.fracDenUpDown.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.fracDenUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fracDenUpDown.Name = "fracDenUpDown";
            this.fracDenUpDown.Size = new System.Drawing.Size(48, 20);
            this.fracDenUpDown.TabIndex = 17;
            this.fracDenUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.fracDenUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fracDenUpDown.ValueChanged += new System.EventHandler(this.fracDenUpDown_ValueChanged);
            // 
            // TileImporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 332);
            this.Controls.Add(this.fracDenUpDown);
            this.Controls.Add(this.fracSepLabel);
            this.Controls.Add(this.fracNumUpDown);
            this.Controls.Add(this.fractionButton);
            this.Controls.Add(this.countButton);
            this.Controls.Add(this.regionLabel);
            this.Controls.Add(this.regionBox);
            this.Controls.Add(this.fileGrid);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.countBox);
            this.Controls.Add(this.offsetLabel);
            this.Controls.Add(this.offsetBox);
            this.Controls.Add(this.layoutLabel);
            this.Controls.Add(this.layoutBox);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(360, 260);
            this.Name = "TileImporter";
            this.Text = "Import Tiles";
            ((System.ComponentModel.ISupportInitialize)(this.fileGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fracNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fracDenUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox layoutBox;
        private System.Windows.Forms.Label layoutLabel;
        private System.Windows.Forms.TextBox offsetBox;
        private System.Windows.Forms.Label offsetLabel;
        private System.Windows.Forms.TextBox countBox;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.DataGridView fileGrid;
        private System.Windows.Forms.Label regionLabel;
        private System.Windows.Forms.ComboBox regionBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewButtonColumn browse;
        private System.Windows.Forms.DataGridViewTextBoxColumn path;
        private System.Windows.Forms.RadioButton countButton;
        private System.Windows.Forms.RadioButton fractionButton;
        private System.Windows.Forms.NumericUpDown fracNumUpDown;
        private System.Windows.Forms.Label fracSepLabel;
        private System.Windows.Forms.NumericUpDown fracDenUpDown;
    }
}