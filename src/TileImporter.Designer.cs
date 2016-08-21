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
            this.countLabel = new System.Windows.Forms.Label();
            this.importButton = new System.Windows.Forms.Button();
            this.fileGrid = new System.Windows.Forms.DataGridView();
            this.regionLabel = new System.Windows.Forms.Label();
            this.regionBox = new System.Windows.Forms.ComboBox();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.browse = new System.Windows.Forms.DataGridViewButtonColumn();
            this.path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.fileGrid)).BeginInit();
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
            this.offsetBox.Location = new System.Drawing.Point(66, 245);
            this.offsetBox.Name = "offsetBox";
            this.offsetBox.Size = new System.Drawing.Size(100, 20);
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
            this.offsetLabel.Size = new System.Drawing.Size(48, 13);
            this.offsetLabel.TabIndex = 6;
            this.offsetLabel.Text = "Offset:";
            // 
            // countBox
            // 
            this.countBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.countBox.Location = new System.Drawing.Point(66, 271);
            this.countBox.Name = "countBox";
            this.countBox.Size = new System.Drawing.Size(100, 20);
            this.countBox.TabIndex = 7;
            this.countBox.Text = "1";
            this.countBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.countBox.TextChanged += new System.EventHandler(this.countBox_TextChanged);
            // 
            // countLabel
            // 
            this.countLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.countLabel.Location = new System.Drawing.Point(12, 274);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(48, 13);
            this.countLabel.TabIndex = 8;
            this.countLabel.Text = "Count:";
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
            // TileImporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 332);
            this.Controls.Add(this.regionLabel);
            this.Controls.Add(this.regionBox);
            this.Controls.Add(this.fileGrid);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.countBox);
            this.Controls.Add(this.offsetLabel);
            this.Controls.Add(this.offsetBox);
            this.Controls.Add(this.layoutLabel);
            this.Controls.Add(this.layoutBox);
            this.MaximizeBox = false;
            this.Name = "TileImporter";
            this.Text = "Import Tiles";
            ((System.ComponentModel.ISupportInitialize)(this.fileGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox layoutBox;
        private System.Windows.Forms.Label layoutLabel;
        private System.Windows.Forms.TextBox offsetBox;
        private System.Windows.Forms.Label offsetLabel;
        private System.Windows.Forms.TextBox countBox;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.DataGridView fileGrid;
        private System.Windows.Forms.Label regionLabel;
        private System.Windows.Forms.ComboBox regionBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewButtonColumn browse;
        private System.Windows.Forms.DataGridViewTextBoxColumn path;
    }
}