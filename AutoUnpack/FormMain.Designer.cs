namespace AutoUnpack
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.fbdSelectBase = new System.Windows.Forms.FolderBrowserDialog();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.gbLog = new System.Windows.Forms.GroupBox();
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.gbUnpack = new System.Windows.Forms.GroupBox();
            this.btnUnpack = new System.Windows.Forms.Button();
            this.pbUnpack = new System.Windows.Forms.ProgressBar();
            this.gbScan = new System.Windows.Forms.GroupBox();
            this.btnScan = new System.Windows.Forms.Button();
            this.pbScan = new System.Windows.Forms.ProgressBar();
            this.gbFolders = new System.Windows.Forms.GroupBox();
            this.tsFolders = new System.Windows.Forms.ToolStrip();
            this.tsAddFolder = new System.Windows.Forms.ToolStripButton();
            this.tsRemoveFolder = new System.Windows.Forms.ToolStripButton();
            this.lstFolders = new System.Windows.Forms.ListBox();
            this.gbIgnore = new System.Windows.Forms.GroupBox();
            this.tsIgnore = new System.Windows.Forms.ToolStrip();
            this.tsAddIgnore = new System.Windows.Forms.ToolStripButton();
            this.tsRemoveIgnore = new System.Windows.Forms.ToolStripButton();
            this.lbIgnore = new System.Windows.Forms.ListBox();
            this.tvFiles = new System.Windows.Forms.TreeView();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.pbArchiveProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.tssArchiveProgress = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.btnSaveDefault = new System.Windows.Forms.ToolStripButton();
            this.btnLoadDefault = new System.Windows.Forms.ToolStripButton();
            this.chkUnpackDelete = new System.Windows.Forms.CheckBox();
            this.chkScanSubdirs = new System.Windows.Forms.CheckBox();
            this.gbArchives = new System.Windows.Forms.GroupBox();
            this.gbLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.gbUnpack.SuspendLayout();
            this.gbScan.SuspendLayout();
            this.gbFolders.SuspendLayout();
            this.tsFolders.SuspendLayout();
            this.gbIgnore.SuspendLayout();
            this.tsIgnore.SuspendLayout();
            this.ssMain.SuspendLayout();
            this.tsMain.SuspendLayout();
            this.gbArchives.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbLog
            // 
            this.lbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLog.FormattingEnabled = true;
            this.lbLog.Location = new System.Drawing.Point(6, 19);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(923, 82);
            this.lbLog.TabIndex = 4;
            // 
            // gbLog
            // 
            this.gbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLog.Controls.Add(this.lbLog);
            this.gbLog.Location = new System.Drawing.Point(9, 3);
            this.gbLog.Name = "gbLog";
            this.gbLog.Size = new System.Drawing.Size(935, 128);
            this.gbLog.TabIndex = 5;
            this.gbLog.TabStop = false;
            this.gbLog.Text = "Log";
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scMain.Location = new System.Drawing.Point(0, 25);
            this.scMain.Name = "scMain";
            this.scMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.gbArchives);
            this.scMain.Panel1.Controls.Add(this.gbUnpack);
            this.scMain.Panel1.Controls.Add(this.gbScan);
            this.scMain.Panel1.Controls.Add(this.gbFolders);
            this.scMain.Panel1.Controls.Add(this.gbIgnore);
            this.scMain.Panel1MinSize = 357;
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.gbLog);
            this.scMain.Size = new System.Drawing.Size(956, 495);
            this.scMain.SplitterDistance = 357;
            this.scMain.TabIndex = 16;
            // 
            // gbUnpack
            // 
            this.gbUnpack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbUnpack.Controls.Add(this.chkUnpackDelete);
            this.gbUnpack.Controls.Add(this.btnUnpack);
            this.gbUnpack.Controls.Add(this.pbUnpack);
            this.gbUnpack.Location = new System.Drawing.Point(771, 126);
            this.gbUnpack.Name = "gbUnpack";
            this.gbUnpack.Size = new System.Drawing.Size(173, 109);
            this.gbUnpack.TabIndex = 20;
            this.gbUnpack.TabStop = false;
            this.gbUnpack.Text = "Unpack";
            // 
            // btnUnpack
            // 
            this.btnUnpack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnpack.Location = new System.Drawing.Point(6, 43);
            this.btnUnpack.Name = "btnUnpack";
            this.btnUnpack.Size = new System.Drawing.Size(161, 40);
            this.btnUnpack.TabIndex = 13;
            this.btnUnpack.Text = "Unpack archives";
            this.btnUnpack.UseVisualStyleBackColor = true;
            this.btnUnpack.Click += new System.EventHandler(this.btnUnpack_Click);
            // 
            // pbUnpack
            // 
            this.pbUnpack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbUnpack.Location = new System.Drawing.Point(6, 89);
            this.pbUnpack.Name = "pbUnpack";
            this.pbUnpack.Size = new System.Drawing.Size(161, 10);
            this.pbUnpack.TabIndex = 14;
            // 
            // gbScan
            // 
            this.gbScan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbScan.Controls.Add(this.chkScanSubdirs);
            this.gbScan.Controls.Add(this.btnScan);
            this.gbScan.Controls.Add(this.pbScan);
            this.gbScan.Location = new System.Drawing.Point(771, 12);
            this.gbScan.Name = "gbScan";
            this.gbScan.Size = new System.Drawing.Size(173, 108);
            this.gbScan.TabIndex = 19;
            this.gbScan.TabStop = false;
            this.gbScan.Text = "Scan";
            // 
            // btnScan
            // 
            this.btnScan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScan.Location = new System.Drawing.Point(6, 39);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(161, 45);
            this.btnScan.TabIndex = 2;
            this.btnScan.Text = "Scan folders for sfv-files";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // pbScan
            // 
            this.pbScan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbScan.Location = new System.Drawing.Point(6, 90);
            this.pbScan.Name = "pbScan";
            this.pbScan.Size = new System.Drawing.Size(161, 10);
            this.pbScan.TabIndex = 7;
            // 
            // gbFolders
            // 
            this.gbFolders.Controls.Add(this.tsFolders);
            this.gbFolders.Controls.Add(this.lstFolders);
            this.gbFolders.Location = new System.Drawing.Point(12, 12);
            this.gbFolders.Name = "gbFolders";
            this.gbFolders.Size = new System.Drawing.Size(173, 183);
            this.gbFolders.TabIndex = 18;
            this.gbFolders.TabStop = false;
            this.gbFolders.Text = " Folders to scan";
            // 
            // tsFolders
            // 
            this.tsFolders.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAddFolder,
            this.tsRemoveFolder});
            this.tsFolders.Location = new System.Drawing.Point(3, 16);
            this.tsFolders.Name = "tsFolders";
            this.tsFolders.Size = new System.Drawing.Size(167, 25);
            this.tsFolders.TabIndex = 1;
            this.tsFolders.Text = "toolStrip2";
            // 
            // tsAddFolder
            // 
            this.tsAddFolder.BackColor = System.Drawing.SystemColors.Control;
            this.tsAddFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsAddFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAddFolder.Name = "tsAddFolder";
            this.tsAddFolder.Size = new System.Drawing.Size(33, 22);
            this.tsAddFolder.Text = "Add";
            this.tsAddFolder.Click += new System.EventHandler(this.tsAddFolder_Click);
            // 
            // tsRemoveFolder
            // 
            this.tsRemoveFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsRemoveFolder.Enabled = false;
            this.tsRemoveFolder.Image = ((System.Drawing.Image)(resources.GetObject("tsRemoveFolder.Image")));
            this.tsRemoveFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsRemoveFolder.Name = "tsRemoveFolder";
            this.tsRemoveFolder.Size = new System.Drawing.Size(54, 22);
            this.tsRemoveFolder.Text = "Remove";
            this.tsRemoveFolder.Click += new System.EventHandler(this.tsRemoveFolder_Click);
            // 
            // lstFolders
            // 
            this.lstFolders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstFolders.FormattingEnabled = true;
            this.lstFolders.Location = new System.Drawing.Point(6, 42);
            this.lstFolders.Name = "lstFolders";
            this.lstFolders.Size = new System.Drawing.Size(161, 134);
            this.lstFolders.TabIndex = 0;
            this.lstFolders.SelectedIndexChanged += new System.EventHandler(this.lstFolders_SelectedIndexChanged);
            // 
            // gbIgnore
            // 
            this.gbIgnore.Controls.Add(this.tsIgnore);
            this.gbIgnore.Controls.Add(this.lbIgnore);
            this.gbIgnore.Location = new System.Drawing.Point(9, 194);
            this.gbIgnore.Name = "gbIgnore";
            this.gbIgnore.Size = new System.Drawing.Size(173, 160);
            this.gbIgnore.TabIndex = 17;
            this.gbIgnore.TabStop = false;
            this.gbIgnore.Text = "Ignore files that ends with";
            // 
            // tsIgnore
            // 
            this.tsIgnore.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAddIgnore,
            this.tsRemoveIgnore});
            this.tsIgnore.Location = new System.Drawing.Point(3, 16);
            this.tsIgnore.Name = "tsIgnore";
            this.tsIgnore.Size = new System.Drawing.Size(167, 25);
            this.tsIgnore.TabIndex = 10;
            this.tsIgnore.Text = "toolStrip3";
            // 
            // tsAddIgnore
            // 
            this.tsAddIgnore.BackColor = System.Drawing.SystemColors.Control;
            this.tsAddIgnore.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsAddIgnore.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAddIgnore.Name = "tsAddIgnore";
            this.tsAddIgnore.Size = new System.Drawing.Size(33, 22);
            this.tsAddIgnore.Text = "Add";
            this.tsAddIgnore.Click += new System.EventHandler(this.tsAddIgnore_Click);
            // 
            // tsRemoveIgnore
            // 
            this.tsRemoveIgnore.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsRemoveIgnore.Enabled = false;
            this.tsRemoveIgnore.Image = ((System.Drawing.Image)(resources.GetObject("tsRemoveIgnore.Image")));
            this.tsRemoveIgnore.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsRemoveIgnore.Name = "tsRemoveIgnore";
            this.tsRemoveIgnore.Size = new System.Drawing.Size(54, 22);
            this.tsRemoveIgnore.Text = "Remove";
            this.tsRemoveIgnore.Click += new System.EventHandler(this.tsRemoveIgnore_Click);
            // 
            // lbIgnore
            // 
            this.lbIgnore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbIgnore.FormattingEnabled = true;
            this.lbIgnore.Location = new System.Drawing.Point(6, 42);
            this.lbIgnore.Name = "lbIgnore";
            this.lbIgnore.Size = new System.Drawing.Size(161, 108);
            this.lbIgnore.TabIndex = 9;
            this.lbIgnore.SelectedIndexChanged += new System.EventHandler(this.lbIgnore_SelectedIndexChanged);
            // 
            // tvFiles
            // 
            this.tvFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvFiles.Location = new System.Drawing.Point(6, 19);
            this.tvFiles.Name = "tvFiles";
            this.tvFiles.Size = new System.Drawing.Size(562, 313);
            this.tvFiles.TabIndex = 16;
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pbArchiveProgress,
            this.tssArchiveProgress});
            this.ssMain.Location = new System.Drawing.Point(0, 520);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(956, 22);
            this.ssMain.TabIndex = 18;
            this.ssMain.Text = "statusStrip1";
            // 
            // pbArchiveProgress
            // 
            this.pbArchiveProgress.Name = "pbArchiveProgress";
            this.pbArchiveProgress.Size = new System.Drawing.Size(100, 16);
            // 
            // tssArchiveProgress
            // 
            this.tssArchiveProgress.Name = "tssArchiveProgress";
            this.tssArchiveProgress.Size = new System.Drawing.Size(46, 17);
            this.tssArchiveProgress.Text = "Idling...";
            // 
            // tsMain
            // 
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSaveDefault,
            this.btnLoadDefault});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(956, 25);
            this.tsMain.TabIndex = 19;
            this.tsMain.Text = "toolStrip1";
            // 
            // btnSaveDefault
            // 
            this.btnSaveDefault.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSaveDefault.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveDefault.Image")));
            this.btnSaveDefault.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveDefault.Name = "btnSaveDefault";
            this.btnSaveDefault.Size = new System.Drawing.Size(112, 22);
            this.btnSaveDefault.Text = "Save default profile";
            this.btnSaveDefault.Click += new System.EventHandler(this.btnSaveDefault_Click);
            // 
            // btnLoadDefault
            // 
            this.btnLoadDefault.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnLoadDefault.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadDefault.Image")));
            this.btnLoadDefault.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLoadDefault.Name = "btnLoadDefault";
            this.btnLoadDefault.Size = new System.Drawing.Size(114, 22);
            this.btnLoadDefault.Text = "Load default profile";
            this.btnLoadDefault.Click += new System.EventHandler(this.btnLoadDefault_Click);
            // 
            // chkUnpackDelete
            // 
            this.chkUnpackDelete.AutoSize = true;
            this.chkUnpackDelete.Checked = true;
            this.chkUnpackDelete.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUnpackDelete.Location = new System.Drawing.Point(7, 20);
            this.chkUnpackDelete.Name = "chkUnpackDelete";
            this.chkUnpackDelete.Size = new System.Drawing.Size(163, 17);
            this.chkUnpackDelete.TabIndex = 15;
            this.chkUnpackDelete.Text = "Delete archives after unpack";
            this.chkUnpackDelete.UseVisualStyleBackColor = true;
            // 
            // chkScanSubdirs
            // 
            this.chkScanSubdirs.AutoSize = true;
            this.chkScanSubdirs.Checked = true;
            this.chkScanSubdirs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkScanSubdirs.Location = new System.Drawing.Point(7, 16);
            this.chkScanSubdirs.Name = "chkScanSubdirs";
            this.chkScanSubdirs.Size = new System.Drawing.Size(87, 17);
            this.chkScanSubdirs.TabIndex = 16;
            this.chkScanSubdirs.Text = "Scan subdirs";
            this.chkScanSubdirs.UseVisualStyleBackColor = true;
            // 
            // gbArchives
            // 
            this.gbArchives.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbArchives.Controls.Add(this.tvFiles);
            this.gbArchives.Location = new System.Drawing.Point(191, 12);
            this.gbArchives.Name = "gbArchives";
            this.gbArchives.Size = new System.Drawing.Size(574, 342);
            this.gbArchives.TabIndex = 21;
            this.gbArchives.TabStop = false;
            this.gbArchives.Text = "Archives";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 542);
            this.Controls.Add(this.scMain);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.ssMain);
            this.Name = "FormMain";
            this.Text = "AutoUnpack";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbLog.ResumeLayout(false);
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.gbUnpack.ResumeLayout(false);
            this.gbUnpack.PerformLayout();
            this.gbScan.ResumeLayout(false);
            this.gbScan.PerformLayout();
            this.gbFolders.ResumeLayout(false);
            this.gbFolders.PerformLayout();
            this.tsFolders.ResumeLayout(false);
            this.tsFolders.PerformLayout();
            this.gbIgnore.ResumeLayout(false);
            this.gbIgnore.PerformLayout();
            this.tsIgnore.ResumeLayout(false);
            this.tsIgnore.PerformLayout();
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.gbArchives.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog fbdSelectBase;
        private System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.GroupBox gbLog;
        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.GroupBox gbUnpack;
        private System.Windows.Forms.Button btnUnpack;
        private System.Windows.Forms.ProgressBar pbUnpack;
        private System.Windows.Forms.GroupBox gbScan;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.ProgressBar pbScan;
        private System.Windows.Forms.GroupBox gbFolders;
        private System.Windows.Forms.ListBox lstFolders;
        private System.Windows.Forms.GroupBox gbIgnore;
        private System.Windows.Forms.ListBox lbIgnore;
        private System.Windows.Forms.TreeView tvFiles;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel tssArchiveProgress;
        private System.Windows.Forms.ToolStripProgressBar pbArchiveProgress;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStrip tsFolders;
        private System.Windows.Forms.ToolStripButton tsAddFolder;
        private System.Windows.Forms.ToolStripButton tsRemoveFolder;
        private System.Windows.Forms.ToolStrip tsIgnore;
        private System.Windows.Forms.ToolStripButton tsAddIgnore;
        private System.Windows.Forms.ToolStripButton tsRemoveIgnore;
        private System.Windows.Forms.ToolStripButton btnSaveDefault;
        private System.Windows.Forms.ToolStripButton btnLoadDefault;
        private System.Windows.Forms.CheckBox chkUnpackDelete;
        private System.Windows.Forms.CheckBox chkScanSubdirs;
        private System.Windows.Forms.GroupBox gbArchives;
    }
}

