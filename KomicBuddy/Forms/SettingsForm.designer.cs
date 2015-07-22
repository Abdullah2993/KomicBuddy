namespace KomicBuddy
{
    partial class SettingsForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteCheck = new System.Windows.Forms.CheckBox();
            this.pdfCheck = new System.Windows.Forms.CheckBox();
            this.trayCheck = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.resumeCheck = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.retriesNumber = new System.Windows.Forms.NumericUpDown();
            this.timeoutNumber = new System.Windows.Forms.NumericUpDown();
            this.browseButton = new System.Windows.Forms.Button();
            this.locationText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.notifyOption = new System.Windows.Forms.RadioButton();
            this.nothingOption = new System.Windows.Forms.RadioButton();
            this.openPdfCheck = new System.Windows.Forms.CheckBox();
            this.settingsTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.errorLogCheck = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.retriesNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeoutNumber)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.settingsTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.errorLogCheck);
            this.groupBox1.Controls.Add(this.deleteCheck);
            this.groupBox1.Controls.Add(this.pdfCheck);
            this.groupBox1.Controls.Add(this.trayCheck);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 115);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Application Settings";
            // 
            // deleteCheck
            // 
            this.deleteCheck.AutoSize = true;
            this.deleteCheck.Location = new System.Drawing.Point(6, 65);
            this.deleteCheck.Name = "deleteCheck";
            this.deleteCheck.Size = new System.Drawing.Size(213, 17);
            this.deleteCheck.TabIndex = 2;
            this.deleteCheck.Text = "Delete all images after creating the PDF";
            this.deleteCheck.UseVisualStyleBackColor = true;
            // 
            // pdfCheck
            // 
            this.pdfCheck.AutoSize = true;
            this.pdfCheck.Location = new System.Drawing.Point(6, 42);
            this.pdfCheck.Name = "pdfCheck";
            this.pdfCheck.Size = new System.Drawing.Size(106, 17);
            this.pdfCheck.TabIndex = 1;
            this.pdfCheck.Text = "Create a PDF file";
            this.pdfCheck.UseVisualStyleBackColor = true;
            // 
            // trayCheck
            // 
            this.trayCheck.AutoSize = true;
            this.trayCheck.Location = new System.Drawing.Point(6, 19);
            this.trayCheck.Name = "trayCheck";
            this.trayCheck.Size = new System.Drawing.Size(98, 17);
            this.trayCheck.TabIndex = 0;
            this.trayCheck.Text = "Minimize to tray";
            this.trayCheck.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.resumeCheck);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.retriesNumber);
            this.groupBox2.Controls.Add(this.timeoutNumber);
            this.groupBox2.Controls.Add(this.browseButton);
            this.groupBox2.Controls.Add(this.locationText);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(7, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(505, 124);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Download Settings";
            // 
            // resumeCheck
            // 
            this.resumeCheck.AutoSize = true;
            this.resumeCheck.Location = new System.Drawing.Point(6, 19);
            this.resumeCheck.Name = "resumeCheck";
            this.resumeCheck.Size = new System.Drawing.Size(227, 17);
            this.resumeCheck.TabIndex = 7;
            this.resumeCheck.Text = "Don\'t download if exists (resume capability)";
            this.resumeCheck.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "No. of retries per Image:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Timeout per image(seconds):";
            // 
            // retriesNumber
            // 
            this.retriesNumber.Location = new System.Drawing.Point(129, 68);
            this.retriesNumber.Name = "retriesNumber";
            this.retriesNumber.Size = new System.Drawing.Size(57, 20);
            this.retriesNumber.TabIndex = 4;
            this.retriesNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timeoutNumber
            // 
            this.timeoutNumber.Location = new System.Drawing.Point(155, 42);
            this.timeoutNumber.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.timeoutNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.timeoutNumber.Name = "timeoutNumber";
            this.timeoutNumber.Size = new System.Drawing.Size(57, 20);
            this.timeoutNumber.TabIndex = 3;
            this.timeoutNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timeoutNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(454, 92);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(42, 23);
            this.browseButton.TabIndex = 2;
            this.browseButton.Text = "...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // locationText
            // 
            this.locationText.Location = new System.Drawing.Point(110, 94);
            this.locationText.Name = "locationText";
            this.locationText.Size = new System.Drawing.Size(338, 20);
            this.locationText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Download Location:";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(382, 180);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(463, 180);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.notifyOption);
            this.groupBox3.Controls.Add(this.nothingOption);
            this.groupBox3.Controls.Add(this.openPdfCheck);
            this.groupBox3.Location = new System.Drawing.Point(3, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(505, 88);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Complete Settings";
            // 
            // notifyOption
            // 
            this.notifyOption.AutoSize = true;
            this.notifyOption.Location = new System.Drawing.Point(6, 65);
            this.notifyOption.Name = "notifyOption";
            this.notifyOption.Size = new System.Drawing.Size(121, 17);
            this.notifyOption.TabIndex = 2;
            this.notifyOption.TabStop = true;
            this.notifyOption.Text = "Notify on completion";
            this.notifyOption.UseVisualStyleBackColor = true;
            // 
            // nothingOption
            // 
            this.nothingOption.AutoSize = true;
            this.nothingOption.Location = new System.Drawing.Point(6, 42);
            this.nothingOption.Name = "nothingOption";
            this.nothingOption.Size = new System.Drawing.Size(146, 17);
            this.nothingOption.TabIndex = 1;
            this.nothingOption.TabStop = true;
            this.nothingOption.Text = "Do nothing on completion";
            this.nothingOption.UseVisualStyleBackColor = true;
            // 
            // openPdfCheck
            // 
            this.openPdfCheck.AutoSize = true;
            this.openPdfCheck.Location = new System.Drawing.Point(6, 19);
            this.openPdfCheck.Name = "openPdfCheck";
            this.openPdfCheck.Size = new System.Drawing.Size(329, 17);
            this.openPdfCheck.TabIndex = 0;
            this.openPdfCheck.Text = "Open the PDF on completion (opened in the default PDF reader)";
            this.openPdfCheck.UseVisualStyleBackColor = true;
            // 
            // settingsTab
            // 
            this.settingsTab.Controls.Add(this.tabPage1);
            this.settingsTab.Controls.Add(this.tabPage2);
            this.settingsTab.Controls.Add(this.tabPage3);
            this.settingsTab.Location = new System.Drawing.Point(17, 12);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.SelectedIndex = 0;
            this.settingsTab.Size = new System.Drawing.Size(526, 162);
            this.settingsTab.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(518, 136);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Application";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(518, 136);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Download";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(518, 136);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Complete";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // errorLogCheck
            // 
            this.errorLogCheck.AutoSize = true;
            this.errorLogCheck.Location = new System.Drawing.Point(6, 88);
            this.errorLogCheck.Name = "errorLogCheck";
            this.errorLogCheck.Size = new System.Drawing.Size(86, 17);
            this.errorLogCheck.TabIndex = 3;
            this.errorLogCheck.Text = "Log all errors";
            this.errorLogCheck.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(555, 216);
            this.Controls.Add(this.settingsTab);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(561, 248);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(561, 248);
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.retriesNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeoutNumber)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.settingsTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox deleteCheck;
        private System.Windows.Forms.CheckBox pdfCheck;
        private System.Windows.Forms.CheckBox trayCheck;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox locationText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown retriesNumber;
        private System.Windows.Forms.NumericUpDown timeoutNumber;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton notifyOption;
        private System.Windows.Forms.RadioButton nothingOption;
        private System.Windows.Forms.CheckBox openPdfCheck;
        private System.Windows.Forms.CheckBox resumeCheck;
        private System.Windows.Forms.TabControl settingsTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox errorLogCheck;
    }
}