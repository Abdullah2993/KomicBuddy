namespace KomicBuddy
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.topControl = new System.Windows.Forms.Panel();
            this.settingsButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.comicPrefixCombo = new System.Windows.Forms.ComboBox();
            this.comicSearchButton = new System.Windows.Forms.Button();
            this.comicInformationBox = new System.Windows.Forms.TextBox();
            this.comicChapterList = new System.Windows.Forms.ListView();
            this.chapterHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.scanlatedHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addedOnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.linkHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bottomStrip = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.comicList = new System.Windows.Forms.ListBox();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.downloadListMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.topControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.bottomStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // topControl
            // 
            this.topControl.BackColor = System.Drawing.SystemColors.ControlText;
            this.topControl.Controls.Add(this.settingsButton);
            this.topControl.Controls.Add(this.aboutButton);
            this.topControl.Controls.Add(this.logoBox);
            this.topControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.topControl.Location = new System.Drawing.Point(0, 0);
            this.topControl.Name = "topControl";
            this.topControl.Size = new System.Drawing.Size(874, 120);
            this.topControl.TabIndex = 0;
            // 
            // settingsButton
            // 
            this.settingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("settingsButton.BackgroundImage")));
            this.settingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.settingsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.settingsButton.FlatAppearance.BorderSize = 3;
            this.settingsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.settingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Location = new System.Drawing.Point(714, 3);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(75, 114);
            this.settingsButton.TabIndex = 1;
            this.settingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aboutButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aboutButton.BackgroundImage")));
            this.aboutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.aboutButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.aboutButton.FlatAppearance.BorderSize = 3;
            this.aboutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.aboutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutButton.Location = new System.Drawing.Point(795, 3);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(75, 114);
            this.aboutButton.TabIndex = 2;
            this.aboutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.aboutButton.UseVisualStyleBackColor = false;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // logoBox
            // 
            this.logoBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.logoBox.Image = ((System.Drawing.Image)(resources.GetObject("logoBox.Image")));
            this.logoBox.Location = new System.Drawing.Point(0, 0);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(362, 120);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoBox.TabIndex = 0;
            this.logoBox.TabStop = false;
            // 
            // comicPrefixCombo
            // 
            this.comicPrefixCombo.FormattingEnabled = true;
            this.comicPrefixCombo.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.comicPrefixCombo.Location = new System.Drawing.Point(12, 126);
            this.comicPrefixCombo.MaxDropDownItems = 24;
            this.comicPrefixCombo.MaxLength = 1;
            this.comicPrefixCombo.Name = "comicPrefixCombo";
            this.comicPrefixCombo.Size = new System.Drawing.Size(155, 21);
            this.comicPrefixCombo.TabIndex = 1;
            this.comicPrefixCombo.Text = "Select a prefix...";
            this.comicPrefixCombo.TextChanged += new System.EventHandler(this.comicPrefixCombo_TextChanged);
            this.comicPrefixCombo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comicPrefixCombo_KeyDown);
            // 
            // comicSearchButton
            // 
            this.comicSearchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("comicSearchButton.BackgroundImage")));
            this.comicSearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.comicSearchButton.Location = new System.Drawing.Point(173, 126);
            this.comicSearchButton.Name = "comicSearchButton";
            this.comicSearchButton.Size = new System.Drawing.Size(30, 21);
            this.comicSearchButton.TabIndex = 2;
            this.comicSearchButton.UseVisualStyleBackColor = true;
            this.comicSearchButton.Click += new System.EventHandler(this.comicSearchButton_Click);
            // 
            // comicInformationBox
            // 
            this.comicInformationBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comicInformationBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.comicInformationBox.Location = new System.Drawing.Point(12, 384);
            this.comicInformationBox.Multiline = true;
            this.comicInformationBox.Name = "comicInformationBox";
            this.comicInformationBox.ReadOnly = true;
            this.comicInformationBox.Size = new System.Drawing.Size(191, 81);
            this.comicInformationBox.TabIndex = 3;
            // 
            // comicChapterList
            // 
            this.comicChapterList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comicChapterList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chapterHeader,
            this.scanlatedHeader,
            this.addedOnHeader,
            this.linkHeader});
            this.comicChapterList.FullRowSelect = true;
            this.comicChapterList.GridLines = true;
            this.comicChapterList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.comicChapterList.Location = new System.Drawing.Point(209, 126);
            this.comicChapterList.MultiSelect = false;
            this.comicChapterList.Name = "comicChapterList";
            this.comicChapterList.Size = new System.Drawing.Size(661, 339);
            this.comicChapterList.TabIndex = 4;
            this.comicChapterList.UseCompatibleStateImageBehavior = false;
            this.comicChapterList.View = System.Windows.Forms.View.Details;
            this.comicChapterList.Click += new System.EventHandler(this.comicChapterList_Click);
            // 
            // chapterHeader
            // 
            this.chapterHeader.Text = "Chapter No.";
            this.chapterHeader.Width = 196;
            // 
            // scanlatedHeader
            // 
            this.scanlatedHeader.Text = "Scanlated by";
            this.scanlatedHeader.Width = 111;
            // 
            // addedOnHeader
            // 
            this.addedOnHeader.Text = "Added On";
            this.addedOnHeader.Width = 113;
            // 
            // linkHeader
            // 
            this.linkHeader.Text = "Link";
            this.linkHeader.Width = 202;
            // 
            // bottomStrip
            // 
            this.bottomStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.bottomStrip.Location = new System.Drawing.Point(0, 468);
            this.bottomStrip.Name = "bottomStrip";
            this.bottomStrip.Size = new System.Drawing.Size(874, 22);
            this.bottomStrip.TabIndex = 5;
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(79, 17);
            this.status.Text = "Select a prefix";
            // 
            // comicList
            // 
            this.comicList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.comicList.FormattingEnabled = true;
            this.comicList.IntegralHeight = false;
            this.comicList.Location = new System.Drawing.Point(12, 153);
            this.comicList.Name = "comicList";
            this.comicList.Size = new System.Drawing.Size(191, 225);
            this.comicList.TabIndex = 6;
            this.comicList.SelectedIndexChanged += new System.EventHandler(this.comicList_SelectedIndexChanged);
            this.comicList.DoubleClick += new System.EventHandler(this.comicList_DoubleClick);
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.downloadListMenu;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "Komic Buddy";
            this.trayIcon.Visible = true;
            this.trayIcon.DoubleClick += new System.EventHandler(this.trayIcon_DoubleClick);
            // 
            // downloadListMenu
            // 
            this.downloadListMenu.Name = "downloadListMenu";
            this.downloadListMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.downloadListMenu.Size = new System.Drawing.Size(61, 4);
            this.downloadListMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.downloadListMenu_ItemClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 490);
            this.Controls.Add(this.comicList);
            this.Controls.Add(this.bottomStrip);
            this.Controls.Add(this.comicChapterList);
            this.Controls.Add(this.comicInformationBox);
            this.Controls.Add(this.comicSearchButton);
            this.Controls.Add(this.comicPrefixCombo);
            this.Controls.Add(this.topControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Komic Buddy";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.topControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.bottomStrip.ResumeLayout(false);
            this.bottomStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topControl;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.ComboBox comicPrefixCombo;
        private System.Windows.Forms.Button comicSearchButton;
        private System.Windows.Forms.TextBox comicInformationBox;
        private System.Windows.Forms.ListView comicChapterList;
        private System.Windows.Forms.StatusStrip bottomStrip;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.ListBox comicList;
        private System.Windows.Forms.ColumnHeader chapterHeader;
        private System.Windows.Forms.ColumnHeader scanlatedHeader;
        private System.Windows.Forms.ColumnHeader addedOnHeader;
        private System.Windows.Forms.ColumnHeader linkHeader;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip downloadListMenu;
    }
}

