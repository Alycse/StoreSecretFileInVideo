﻿namespace StoreFileInVideo {
    partial class Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            this.browseStoreFilePathButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.storeOutputPathSaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.extractButton = new System.Windows.Forms.Button();
            this.extractVideoPathTextBox = new System.Windows.Forms.TextBox();
            this.browseExtractVideoPathButton = new System.Windows.Forms.Button();
            this.storeProgressBar = new System.Windows.Forms.ProgressBar();
            this.storeButton = new System.Windows.Forms.Button();
            this.storeFilePathTextBox = new System.Windows.Forms.TextBox();
            this.storeLabel = new System.Windows.Forms.Label();
            this.storeOutputPathTextBox = new System.Windows.Forms.TextBox();
            this.setStoreOutputPathButton = new System.Windows.Forms.Button();
            this.storeFpsTextBox = new System.Windows.Forms.TextBox();
            this.storeFpsLabel = new System.Windows.Forms.Label();
            this.storeBoxSizeLabel = new System.Windows.Forms.Label();
            this.storeBoxSizeTextBox = new System.Windows.Forms.TextBox();
            this.storeFpsRecommendedLabel = new System.Windows.Forms.Label();
            this.storeBoxSizeRecommendedLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.extractProgressBar = new System.Windows.Forms.ProgressBar();
            this.extractOutputPathFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.extractBoxSizeRecommendedLabel = new System.Windows.Forms.Label();
            this.extractFpsRecommendedLabel = new System.Windows.Forms.Label();
            this.extractBoxSizeTextBox = new System.Windows.Forms.TextBox();
            this.extractBoxSizeLabel = new System.Windows.Forms.Label();
            this.extractFpsLabel = new System.Windows.Forms.Label();
            this.extractFpsTextBox = new System.Windows.Forms.TextBox();
            this.setExtractOutputPathButton = new System.Windows.Forms.Button();
            this.extractOutputPathTextBox = new System.Windows.Forms.TextBox();
            this.storeInfoTextBox = new System.Windows.Forms.RichTextBox();
            this.extractInfoTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // browseStoreFilePathButton
            // 
            this.browseStoreFilePathButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.browseStoreFilePathButton.Location = new System.Drawing.Point(23, 62);
            this.browseStoreFilePathButton.Name = "browseStoreFilePathButton";
            this.browseStoreFilePathButton.Size = new System.Drawing.Size(129, 23);
            this.browseStoreFilePathButton.TabIndex = 0;
            this.browseStoreFilePathButton.Text = "Browse File";
            this.browseStoreFilePathButton.UseVisualStyleBackColor = true;
            this.browseStoreFilePathButton.Click += new System.EventHandler(this.browseStoreFilePathButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // storeOutputPathSaveDialog
            // 
            this.storeOutputPathSaveDialog.DefaultExt = "mp4";
            this.storeOutputPathSaveDialog.Filter = "MPEG-4 Video File (*.mp4)|*.mp4";
            // 
            // extractButton
            // 
            this.extractButton.Location = new System.Drawing.Point(568, 356);
            this.extractButton.Name = "extractButton";
            this.extractButton.Size = new System.Drawing.Size(94, 47);
            this.extractButton.TabIndex = 5;
            this.extractButton.Text = "Extract";
            this.extractButton.UseVisualStyleBackColor = true;
            this.extractButton.Click += new System.EventHandler(this.extractButton_Click);
            // 
            // extractVideoPathTextBox
            // 
            this.extractVideoPathTextBox.Location = new System.Drawing.Point(171, 356);
            this.extractVideoPathTextBox.Name = "extractVideoPathTextBox";
            this.extractVideoPathTextBox.ReadOnly = true;
            this.extractVideoPathTextBox.Size = new System.Drawing.Size(373, 20);
            this.extractVideoPathTextBox.TabIndex = 4;
            this.extractVideoPathTextBox.TextChanged += new System.EventHandler(this.extractVideoPathTextBox_TextChanged);
            // 
            // browseExtractVideoPathButton
            // 
            this.browseExtractVideoPathButton.Location = new System.Drawing.Point(23, 353);
            this.browseExtractVideoPathButton.Name = "browseExtractVideoPathButton";
            this.browseExtractVideoPathButton.Size = new System.Drawing.Size(129, 23);
            this.browseExtractVideoPathButton.TabIndex = 3;
            this.browseExtractVideoPathButton.Text = "Browse Video";
            this.browseExtractVideoPathButton.UseVisualStyleBackColor = true;
            this.browseExtractVideoPathButton.Click += new System.EventHandler(this.browseExtractVideoPathButton_Click);
            // 
            // storeProgressBar
            // 
            this.storeProgressBar.Location = new System.Drawing.Point(23, 185);
            this.storeProgressBar.Name = "storeProgressBar";
            this.storeProgressBar.Size = new System.Drawing.Size(639, 23);
            this.storeProgressBar.TabIndex = 6;
            // 
            // storeButton
            // 
            this.storeButton.Location = new System.Drawing.Point(568, 64);
            this.storeButton.Name = "storeButton";
            this.storeButton.Size = new System.Drawing.Size(94, 46);
            this.storeButton.TabIndex = 2;
            this.storeButton.Text = "Store";
            this.storeButton.UseVisualStyleBackColor = true;
            this.storeButton.Click += new System.EventHandler(this.storeButton_Click);
            // 
            // storeFilePathTextBox
            // 
            this.storeFilePathTextBox.Location = new System.Drawing.Point(171, 64);
            this.storeFilePathTextBox.Name = "storeFilePathTextBox";
            this.storeFilePathTextBox.ReadOnly = true;
            this.storeFilePathTextBox.Size = new System.Drawing.Size(373, 20);
            this.storeFilePathTextBox.TabIndex = 1;
            this.storeFilePathTextBox.TextChanged += new System.EventHandler(this.storeFilePathTextBox_TextChanged);
            // 
            // storeLabel
            // 
            this.storeLabel.AutoSize = true;
            this.storeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.storeLabel.Location = new System.Drawing.Point(20, 26);
            this.storeLabel.Name = "storeLabel";
            this.storeLabel.Size = new System.Drawing.Size(121, 16);
            this.storeLabel.TabIndex = 7;
            this.storeLabel.Text = "Store file in a video";
            // 
            // storeOutputPathTextBox
            // 
            this.storeOutputPathTextBox.Location = new System.Drawing.Point(171, 90);
            this.storeOutputPathTextBox.Name = "storeOutputPathTextBox";
            this.storeOutputPathTextBox.ReadOnly = true;
            this.storeOutputPathTextBox.Size = new System.Drawing.Size(373, 20);
            this.storeOutputPathTextBox.TabIndex = 8;
            this.storeOutputPathTextBox.TextChanged += new System.EventHandler(this.storeOutputPathTextBox_TextChanged);
            // 
            // setStoreOutputPathButton
            // 
            this.setStoreOutputPathButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.setStoreOutputPathButton.Location = new System.Drawing.Point(23, 87);
            this.setStoreOutputPathButton.Name = "setStoreOutputPathButton";
            this.setStoreOutputPathButton.Size = new System.Drawing.Size(129, 23);
            this.setStoreOutputPathButton.TabIndex = 9;
            this.setStoreOutputPathButton.Text = "Set Output";
            this.setStoreOutputPathButton.UseVisualStyleBackColor = true;
            this.setStoreOutputPathButton.Click += new System.EventHandler(this.setStoreOutputPathButton_Click);
            // 
            // storeFpsTextBox
            // 
            this.storeFpsTextBox.Location = new System.Drawing.Point(92, 122);
            this.storeFpsTextBox.Name = "storeFpsTextBox";
            this.storeFpsTextBox.Size = new System.Drawing.Size(73, 20);
            this.storeFpsTextBox.TabIndex = 10;
            this.storeFpsTextBox.Text = "1";
            this.storeFpsTextBox.TextChanged += new System.EventHandler(this.storeFpsTextBox_TextChanged);
            // 
            // storeFpsLabel
            // 
            this.storeFpsLabel.AutoSize = true;
            this.storeFpsLabel.Location = new System.Drawing.Point(20, 125);
            this.storeFpsLabel.Name = "storeFpsLabel";
            this.storeFpsLabel.Size = new System.Drawing.Size(27, 13);
            this.storeFpsLabel.TabIndex = 11;
            this.storeFpsLabel.Text = "FPS";
            // 
            // storeBoxSizeLabel
            // 
            this.storeBoxSizeLabel.AutoSize = true;
            this.storeBoxSizeLabel.Location = new System.Drawing.Point(20, 152);
            this.storeBoxSizeLabel.Name = "storeBoxSizeLabel";
            this.storeBoxSizeLabel.Size = new System.Drawing.Size(48, 13);
            this.storeBoxSizeLabel.TabIndex = 12;
            this.storeBoxSizeLabel.Text = "Box Size";
            // 
            // storeBoxSizeTextBox
            // 
            this.storeBoxSizeTextBox.Location = new System.Drawing.Point(92, 149);
            this.storeBoxSizeTextBox.Name = "storeBoxSizeTextBox";
            this.storeBoxSizeTextBox.Size = new System.Drawing.Size(73, 20);
            this.storeBoxSizeTextBox.TabIndex = 13;
            this.storeBoxSizeTextBox.Text = "5";
            this.storeBoxSizeTextBox.TextChanged += new System.EventHandler(this.storeBoxSizeTextBox_TextChanged);
            // 
            // storeFpsRecommendedLabel
            // 
            this.storeFpsRecommendedLabel.AutoSize = true;
            this.storeFpsRecommendedLabel.Location = new System.Drawing.Point(181, 125);
            this.storeFpsRecommendedLabel.Name = "storeFpsRecommendedLabel";
            this.storeFpsRecommendedLabel.Size = new System.Drawing.Size(120, 13);
            this.storeFpsRecommendedLabel.TabIndex = 14;
            this.storeFpsRecommendedLabel.Text = "(Recommended FPS: 1)";
            // 
            // storeBoxSizeRecommendedLabel
            // 
            this.storeBoxSizeRecommendedLabel.AutoSize = true;
            this.storeBoxSizeRecommendedLabel.Location = new System.Drawing.Point(181, 152);
            this.storeBoxSizeRecommendedLabel.Name = "storeBoxSizeRecommendedLabel";
            this.storeBoxSizeRecommendedLabel.Size = new System.Drawing.Size(141, 13);
            this.storeBoxSizeRecommendedLabel.TabIndex = 15;
            this.storeBoxSizeRecommendedLabel.Text = "(Recommended Box Size: 5)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(20, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Extract file from a video";
            // 
            // extractProgressBar
            // 
            this.extractProgressBar.Location = new System.Drawing.Point(23, 486);
            this.extractProgressBar.Name = "extractProgressBar";
            this.extractProgressBar.Size = new System.Drawing.Size(639, 23);
            this.extractProgressBar.TabIndex = 17;
            // 
            // extractBoxSizeRecommendedLabel
            // 
            this.extractBoxSizeRecommendedLabel.AutoSize = true;
            this.extractBoxSizeRecommendedLabel.Location = new System.Drawing.Point(181, 451);
            this.extractBoxSizeRecommendedLabel.Name = "extractBoxSizeRecommendedLabel";
            this.extractBoxSizeRecommendedLabel.Size = new System.Drawing.Size(194, 13);
            this.extractBoxSizeRecommendedLabel.TabIndex = 23;
            this.extractBoxSizeRecommendedLabel.Text = "(Must be the same as the original video)";
            // 
            // extractFpsRecommendedLabel
            // 
            this.extractFpsRecommendedLabel.AutoSize = true;
            this.extractFpsRecommendedLabel.Location = new System.Drawing.Point(181, 424);
            this.extractFpsRecommendedLabel.Name = "extractFpsRecommendedLabel";
            this.extractFpsRecommendedLabel.Size = new System.Drawing.Size(362, 13);
            this.extractFpsRecommendedLabel.TabIndex = 22;
            this.extractFpsRecommendedLabel.Text = "(Set this to 6 if the video is from YouTube and the original video was 1 FPS)";
            // 
            // extractBoxSizeTextBox
            // 
            this.extractBoxSizeTextBox.Location = new System.Drawing.Point(92, 448);
            this.extractBoxSizeTextBox.Name = "extractBoxSizeTextBox";
            this.extractBoxSizeTextBox.Size = new System.Drawing.Size(73, 20);
            this.extractBoxSizeTextBox.TabIndex = 21;
            this.extractBoxSizeTextBox.Text = "5";
            this.extractBoxSizeTextBox.TextChanged += new System.EventHandler(this.extractBoxSizeTextBox_TextChanged);
            // 
            // extractBoxSizeLabel
            // 
            this.extractBoxSizeLabel.AutoSize = true;
            this.extractBoxSizeLabel.Location = new System.Drawing.Point(20, 451);
            this.extractBoxSizeLabel.Name = "extractBoxSizeLabel";
            this.extractBoxSizeLabel.Size = new System.Drawing.Size(48, 13);
            this.extractBoxSizeLabel.TabIndex = 20;
            this.extractBoxSizeLabel.Text = "Box Size";
            // 
            // extractFpsLabel
            // 
            this.extractFpsLabel.AutoSize = true;
            this.extractFpsLabel.Location = new System.Drawing.Point(20, 424);
            this.extractFpsLabel.Name = "extractFpsLabel";
            this.extractFpsLabel.Size = new System.Drawing.Size(27, 13);
            this.extractFpsLabel.TabIndex = 19;
            this.extractFpsLabel.Text = "FPS";
            // 
            // extractFpsTextBox
            // 
            this.extractFpsTextBox.Location = new System.Drawing.Point(92, 421);
            this.extractFpsTextBox.Name = "extractFpsTextBox";
            this.extractFpsTextBox.Size = new System.Drawing.Size(73, 20);
            this.extractFpsTextBox.TabIndex = 18;
            this.extractFpsTextBox.Text = "1";
            this.extractFpsTextBox.TextChanged += new System.EventHandler(this.extractFpsTextBox_TextChanged);
            // 
            // setExtractOutputPathButton
            // 
            this.setExtractOutputPathButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.setExtractOutputPathButton.Location = new System.Drawing.Point(23, 380);
            this.setExtractOutputPathButton.Name = "setExtractOutputPathButton";
            this.setExtractOutputPathButton.Size = new System.Drawing.Size(129, 23);
            this.setExtractOutputPathButton.TabIndex = 25;
            this.setExtractOutputPathButton.Text = "Set Output";
            this.setExtractOutputPathButton.UseVisualStyleBackColor = true;
            this.setExtractOutputPathButton.Click += new System.EventHandler(this.setExtractOutputPathButton_Click);
            // 
            // extractOutputPathTextBox
            // 
            this.extractOutputPathTextBox.Location = new System.Drawing.Point(171, 383);
            this.extractOutputPathTextBox.Name = "extractOutputPathTextBox";
            this.extractOutputPathTextBox.ReadOnly = true;
            this.extractOutputPathTextBox.Size = new System.Drawing.Size(373, 20);
            this.extractOutputPathTextBox.TabIndex = 24;
            this.extractOutputPathTextBox.TextChanged += new System.EventHandler(this.extractOutputPathTextBox_TextChanged);
            // 
            // storeInfoTextBox
            // 
            this.storeInfoTextBox.Location = new System.Drawing.Point(23, 226);
            this.storeInfoTextBox.Name = "storeInfoTextBox";
            this.storeInfoTextBox.Size = new System.Drawing.Size(639, 60);
            this.storeInfoTextBox.TabIndex = 26;
            this.storeInfoTextBox.Text = "";
            // 
            // extractInfoTextBox
            // 
            this.extractInfoTextBox.Location = new System.Drawing.Point(23, 531);
            this.extractInfoTextBox.Name = "extractInfoTextBox";
            this.extractInfoTextBox.Size = new System.Drawing.Size(639, 60);
            this.extractInfoTextBox.TabIndex = 27;
            this.extractInfoTextBox.Text = "";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 654);
            this.Controls.Add(this.extractInfoTextBox);
            this.Controls.Add(this.storeInfoTextBox);
            this.Controls.Add(this.setExtractOutputPathButton);
            this.Controls.Add(this.extractOutputPathTextBox);
            this.Controls.Add(this.extractBoxSizeRecommendedLabel);
            this.Controls.Add(this.extractFpsRecommendedLabel);
            this.Controls.Add(this.extractBoxSizeTextBox);
            this.Controls.Add(this.extractBoxSizeLabel);
            this.Controls.Add(this.extractFpsLabel);
            this.Controls.Add(this.extractFpsTextBox);
            this.Controls.Add(this.extractProgressBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.storeBoxSizeRecommendedLabel);
            this.Controls.Add(this.storeFpsRecommendedLabel);
            this.Controls.Add(this.storeBoxSizeTextBox);
            this.Controls.Add(this.storeBoxSizeLabel);
            this.Controls.Add(this.storeFpsLabel);
            this.Controls.Add(this.storeFpsTextBox);
            this.Controls.Add(this.setStoreOutputPathButton);
            this.Controls.Add(this.storeOutputPathTextBox);
            this.Controls.Add(this.storeLabel);
            this.Controls.Add(this.storeProgressBar);
            this.Controls.Add(this.extractButton);
            this.Controls.Add(this.extractVideoPathTextBox);
            this.Controls.Add(this.browseExtractVideoPathButton);
            this.Controls.Add(this.storeButton);
            this.Controls.Add(this.storeFilePathTextBox);
            this.Controls.Add(this.browseStoreFilePathButton);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browseStoreFilePathButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog storeOutputPathSaveDialog;
        private System.Windows.Forms.Button extractButton;
        private System.Windows.Forms.TextBox extractVideoPathTextBox;
        private System.Windows.Forms.Button browseExtractVideoPathButton;
        public System.Windows.Forms.ProgressBar storeProgressBar;
        private System.Windows.Forms.Button storeButton;
        private System.Windows.Forms.TextBox storeFilePathTextBox;
        private System.Windows.Forms.Label storeLabel;
        private System.Windows.Forms.TextBox storeOutputPathTextBox;
        private System.Windows.Forms.Button setStoreOutputPathButton;
        private System.Windows.Forms.TextBox storeFpsTextBox;
        private System.Windows.Forms.Label storeFpsLabel;
        private System.Windows.Forms.Label storeBoxSizeLabel;
        private System.Windows.Forms.TextBox storeBoxSizeTextBox;
        private System.Windows.Forms.Label storeFpsRecommendedLabel;
        private System.Windows.Forms.Label storeBoxSizeRecommendedLabel;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ProgressBar extractProgressBar;
        private System.Windows.Forms.FolderBrowserDialog extractOutputPathFolderBrowserDialog;
        private System.Windows.Forms.Label extractBoxSizeRecommendedLabel;
        private System.Windows.Forms.Label extractFpsRecommendedLabel;
        private System.Windows.Forms.TextBox extractBoxSizeTextBox;
        private System.Windows.Forms.Label extractBoxSizeLabel;
        private System.Windows.Forms.Label extractFpsLabel;
        private System.Windows.Forms.TextBox extractFpsTextBox;
        private System.Windows.Forms.Button setExtractOutputPathButton;
        private System.Windows.Forms.TextBox extractOutputPathTextBox;
        public System.Windows.Forms.RichTextBox storeInfoTextBox;
        public System.Windows.Forms.RichTextBox extractInfoTextBox;
    }
}

