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
            this.pathLabel = new System.Windows.Forms.Label();
            this.layoutLabel = new System.Windows.Forms.Label();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.pathButton = new System.Windows.Forms.Button();
            this.offsetBox = new System.Windows.Forms.TextBox();
            this.offsetLabel = new System.Windows.Forms.Label();
            this.countBox = new System.Windows.Forms.TextBox();
            this.countLabel = new System.Windows.Forms.Label();
            this.importButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // layoutBox
            // 
            this.layoutBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.layoutBox.FormattingEnabled = true;
            this.layoutBox.Location = new System.Drawing.Point(66, 40);
            this.layoutBox.Name = "layoutBox";
            this.layoutBox.Size = new System.Drawing.Size(386, 21);
            this.layoutBox.TabIndex = 0;
            this.layoutBox.SelectedIndexChanged += new System.EventHandler(this.layoutBox_SelectedIndexChanged);
            // 
            // pathLabel
            // 
            this.pathLabel.Location = new System.Drawing.Point(12, 17);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(48, 13);
            this.pathLabel.TabIndex = 1;
            this.pathLabel.Text = "File:";
            // 
            // layoutLabel
            // 
            this.layoutLabel.Location = new System.Drawing.Point(12, 44);
            this.layoutLabel.Name = "layoutLabel";
            this.layoutLabel.Size = new System.Drawing.Size(48, 13);
            this.layoutLabel.TabIndex = 2;
            this.layoutLabel.Text = "Layout:";
            // 
            // pathBox
            // 
            this.pathBox.Location = new System.Drawing.Point(66, 14);
            this.pathBox.Name = "pathBox";
            this.pathBox.ReadOnly = true;
            this.pathBox.Size = new System.Drawing.Size(305, 20);
            this.pathBox.TabIndex = 3;
            // 
            // pathButton
            // 
            this.pathButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pathButton.Location = new System.Drawing.Point(377, 12);
            this.pathButton.Name = "pathButton";
            this.pathButton.Size = new System.Drawing.Size(75, 23);
            this.pathButton.TabIndex = 4;
            this.pathButton.Text = "Browse...";
            this.pathButton.UseVisualStyleBackColor = true;
            this.pathButton.Click += new System.EventHandler(this.pathButton_Click);
            // 
            // offsetBox
            // 
            this.offsetBox.Location = new System.Drawing.Point(66, 67);
            this.offsetBox.Name = "offsetBox";
            this.offsetBox.Size = new System.Drawing.Size(100, 20);
            this.offsetBox.TabIndex = 5;
            this.offsetBox.Text = "0x0";
            this.offsetBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.offsetBox.TextChanged += new System.EventHandler(this.offsetBox_TextChanged);
            // 
            // offsetLabel
            // 
            this.offsetLabel.Location = new System.Drawing.Point(12, 70);
            this.offsetLabel.Name = "offsetLabel";
            this.offsetLabel.Size = new System.Drawing.Size(48, 13);
            this.offsetLabel.TabIndex = 6;
            this.offsetLabel.Text = "Offset:";
            // 
            // countBox
            // 
            this.countBox.Location = new System.Drawing.Point(66, 93);
            this.countBox.Name = "countBox";
            this.countBox.Size = new System.Drawing.Size(100, 20);
            this.countBox.TabIndex = 7;
            this.countBox.Text = "1";
            this.countBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.countBox.TextChanged += new System.EventHandler(this.countBox_TextChanged);
            // 
            // countLabel
            // 
            this.countLabel.Location = new System.Drawing.Point(12, 96);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(48, 13);
            this.countLabel.TabIndex = 8;
            this.countLabel.Text = "Count:";
            // 
            // importButton
            // 
            this.importButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.importButton.Enabled = false;
            this.importButton.Location = new System.Drawing.Point(377, 226);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(75, 23);
            this.importButton.TabIndex = 9;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // TileImporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 261);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.countBox);
            this.Controls.Add(this.offsetLabel);
            this.Controls.Add(this.offsetBox);
            this.Controls.Add(this.pathButton);
            this.Controls.Add(this.pathBox);
            this.Controls.Add(this.layoutLabel);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.layoutBox);
            this.MaximizeBox = false;
            this.Name = "TileImporter";
            this.Text = "Import Tiles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox layoutBox;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Label layoutLabel;
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.Button pathButton;
        private System.Windows.Forms.TextBox offsetBox;
        private System.Windows.Forms.Label offsetLabel;
        private System.Windows.Forms.TextBox countBox;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Button importButton;
    }
}