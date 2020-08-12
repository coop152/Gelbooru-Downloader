namespace GelbooruDownloader
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tagsTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.downloadButton = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.leftStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.rightStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.aboutButton = new System.Windows.Forms.Button();
            this.searchHelpButton = new System.Windows.Forms.Button();
            this.settingsPictureBox = new System.Windows.Forms.PictureBox();
            this.baseUrlTextBox = new System.Windows.Forms.TextBox();
            this.baseUrlLabel = new System.Windows.Forms.Label();
            this.tagsLabel = new System.Windows.Forms.Label();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tagsTextBox
            // 
            this.tagsTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tagsTextBox.Location = new System.Drawing.Point(12, 99);
            this.tagsTextBox.Name = "tagsTextBox";
            this.tagsTextBox.Size = new System.Drawing.Size(487, 29);
            this.tagsTextBox.TabIndex = 1;
            this.tagsTextBox.Text = "overwatch animated";
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchButton.Location = new System.Drawing.Point(102, 134);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(151, 34);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.Location = new System.Drawing.Point(0, 202);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(511, 32);
            this.infoLabel.TabIndex = 100;
            this.infoLabel.Text = "This is an unofficial application. Uses the Gelbooru API.";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "Select the folder for the downloaded content";
            // 
            // downloadButton
            // 
            this.downloadButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.downloadButton.Location = new System.Drawing.Point(259, 134);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(151, 34);
            this.downloadButton.TabIndex = 3;
            this.downloadButton.Text = "Download";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.AllowMerge = false;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leftStatusLabel,
            this.progressBar,
            this.rightStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 245);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(511, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 5;
            this.statusStrip.Text = "statusStrip1";
            // 
            // leftStatusLabel
            // 
            this.leftStatusLabel.AutoSize = false;
            this.leftStatusLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.leftStatusLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.leftStatusLabel.Name = "leftStatusLabel";
            this.leftStatusLabel.Size = new System.Drawing.Size(146, 17);
            this.leftStatusLabel.Text = "Downloading content...";
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(266, 16);
            // 
            // rightStatusLabel
            // 
            this.rightStatusLabel.AutoSize = false;
            this.rightStatusLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.rightStatusLabel.Name = "rightStatusLabel";
            this.rightStatusLabel.Size = new System.Drawing.Size(95, 17);
            this.rightStatusLabel.Text = "12578 / 12542";
            // 
            // aboutButton
            // 
            this.aboutButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aboutButton.Location = new System.Drawing.Point(259, 174);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(106, 25);
            this.aboutButton.TabIndex = 5;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // searchHelpButton
            // 
            this.searchHelpButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchHelpButton.Location = new System.Drawing.Point(147, 174);
            this.searchHelpButton.Name = "searchHelpButton";
            this.searchHelpButton.Size = new System.Drawing.Size(106, 25);
            this.searchHelpButton.TabIndex = 4;
            this.searchHelpButton.Text = "Search help";
            this.searchHelpButton.UseVisualStyleBackColor = true;
            this.searchHelpButton.Click += new System.EventHandler(this.searchHelpButton_Click);
            // 
            // settingsPictureBox
            // 
            this.settingsPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsPictureBox.Image = global::GelbooruDownloader.Properties.Resources.settings;
            this.settingsPictureBox.Location = new System.Drawing.Point(467, 202);
            this.settingsPictureBox.Name = "settingsPictureBox";
            this.settingsPictureBox.Size = new System.Drawing.Size(32, 32);
            this.settingsPictureBox.TabIndex = 101;
            this.settingsPictureBox.TabStop = false;
            this.settingsPictureBox.Click += new System.EventHandler(this.settingsPictureBox_Click);
            // 
            // baseUrlTextBox
            // 
            this.baseUrlTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.baseUrlTextBox.Location = new System.Drawing.Point(12, 38);
            this.baseUrlTextBox.Name = "baseUrlTextBox";
            this.baseUrlTextBox.Size = new System.Drawing.Size(487, 29);
            this.baseUrlTextBox.TabIndex = 102;
            // 
            // baseUrlLabel
            // 
            this.baseUrlLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseUrlLabel.Location = new System.Drawing.Point(12, 9);
            this.baseUrlLabel.Name = "baseUrlLabel";
            this.baseUrlLabel.Size = new System.Drawing.Size(487, 26);
            this.baseUrlLabel.TabIndex = 103;
            this.baseUrlLabel.Text = "Base URL";
            this.baseUrlLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tagsLabel
            // 
            this.tagsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagsLabel.Location = new System.Drawing.Point(12, 70);
            this.tagsLabel.Name = "tagsLabel";
            this.tagsLabel.Size = new System.Drawing.Size(487, 26);
            this.tagsLabel.TabIndex = 104;
            this.tagsLabel.Text = "Tags";
            this.tagsLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(511, 267);
            this.Controls.Add(this.tagsLabel);
            this.Controls.Add(this.baseUrlLabel);
            this.Controls.Add(this.baseUrlTextBox);
            this.Controls.Add(this.settingsPictureBox);
            this.Controls.Add(this.searchHelpButton);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.tagsTextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gelbooru Downloader";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tagsTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button searchHelpButton;
        private System.Windows.Forms.ToolStripStatusLabel leftStatusLabel;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ToolStripStatusLabel rightStatusLabel;
        private System.Windows.Forms.PictureBox settingsPictureBox;
        private System.Windows.Forms.TextBox baseUrlTextBox;
        private System.Windows.Forms.Label baseUrlLabel;
        private System.Windows.Forms.Label tagsLabel;
    }
}
