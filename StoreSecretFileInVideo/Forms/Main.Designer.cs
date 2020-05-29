namespace StoreFileInVideo {
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
            this.extractFpsMultiplierRecommendedLabel = new System.Windows.Forms.Label();
            this.extractBoxSizeTextBox = new System.Windows.Forms.TextBox();
            this.extractBoxSizeLabel = new System.Windows.Forms.Label();
            this.extractFpsMultiplierLabel = new System.Windows.Forms.Label();
            this.extractFpsMultiplierTextBox = new System.Windows.Forms.TextBox();
            this.setExtractOutputPathButton = new System.Windows.Forms.Button();
            this.extractOutputPathTextBox = new System.Windows.Forms.TextBox();
            this.storeInfoTextBox = new System.Windows.Forms.RichTextBox();
            this.extractInfoTextBox = new System.Windows.Forms.RichTextBox();
            this.extractFpsMultiplierRecommendedBLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // browseStoreFilePathButton
            // 
            this.browseStoreFilePathButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.browseStoreFilePathButton.Location = new System.Drawing.Point(22, 53);
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
            this.storeOutputPathSaveDialog.Filter = "MPEG-4 Video Files (*.mp4)|*.mp4";
            // 
            // extractButton
            // 
            this.extractButton.Location = new System.Drawing.Point(567, 321);
            this.extractButton.Name = "extractButton";
            this.extractButton.Size = new System.Drawing.Size(94, 47);
            this.extractButton.TabIndex = 5;
            this.extractButton.Text = "Extract";
            this.extractButton.UseVisualStyleBackColor = true;
            this.extractButton.Click += new System.EventHandler(this.extractButton_Click);
            // 
            // extractVideoPathTextBox
            // 
            this.extractVideoPathTextBox.Location = new System.Drawing.Point(170, 321);
            this.extractVideoPathTextBox.Name = "extractVideoPathTextBox";
            this.extractVideoPathTextBox.ReadOnly = true;
            this.extractVideoPathTextBox.Size = new System.Drawing.Size(373, 20);
            this.extractVideoPathTextBox.TabIndex = 4;
            this.extractVideoPathTextBox.TextChanged += new System.EventHandler(this.extractVideoPathTextBox_TextChanged);
            // 
            // browseExtractVideoPathButton
            // 
            this.browseExtractVideoPathButton.Location = new System.Drawing.Point(22, 319);
            this.browseExtractVideoPathButton.Name = "browseExtractVideoPathButton";
            this.browseExtractVideoPathButton.Size = new System.Drawing.Size(129, 23);
            this.browseExtractVideoPathButton.TabIndex = 3;
            this.browseExtractVideoPathButton.Text = "Browse Video";
            this.browseExtractVideoPathButton.UseVisualStyleBackColor = true;
            this.browseExtractVideoPathButton.Click += new System.EventHandler(this.browseExtractVideoPathButton_Click);
            // 
            // storeProgressBar
            // 
            this.storeProgressBar.Location = new System.Drawing.Point(22, 178);
            this.storeProgressBar.Name = "storeProgressBar";
            this.storeProgressBar.Size = new System.Drawing.Size(639, 23);
            this.storeProgressBar.TabIndex = 6;
            // 
            // storeButton
            // 
            this.storeButton.Location = new System.Drawing.Point(567, 55);
            this.storeButton.Name = "storeButton";
            this.storeButton.Size = new System.Drawing.Size(94, 46);
            this.storeButton.TabIndex = 2;
            this.storeButton.Text = "Store";
            this.storeButton.UseVisualStyleBackColor = true;
            this.storeButton.Click += new System.EventHandler(this.storeButton_Click);
            // 
            // storeFilePathTextBox
            // 
            this.storeFilePathTextBox.Location = new System.Drawing.Point(170, 55);
            this.storeFilePathTextBox.Name = "storeFilePathTextBox";
            this.storeFilePathTextBox.ReadOnly = true;
            this.storeFilePathTextBox.Size = new System.Drawing.Size(373, 20);
            this.storeFilePathTextBox.TabIndex = 1;
            this.storeFilePathTextBox.TextChanged += new System.EventHandler(this.storeFilePathTextBox_TextChanged);
            // 
            // storeLabel
            // 
            this.storeLabel.AutoSize = true;
            this.storeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.storeLabel.Location = new System.Drawing.Point(19, 17);
            this.storeLabel.Name = "storeLabel";
            this.storeLabel.Size = new System.Drawing.Size(142, 16);
            this.storeLabel.TabIndex = 7;
            this.storeLabel.Text = "Store file in a video";
            // 
            // storeOutputPathTextBox
            // 
            this.storeOutputPathTextBox.Location = new System.Drawing.Point(170, 82);
            this.storeOutputPathTextBox.Name = "storeOutputPathTextBox";
            this.storeOutputPathTextBox.ReadOnly = true;
            this.storeOutputPathTextBox.Size = new System.Drawing.Size(373, 20);
            this.storeOutputPathTextBox.TabIndex = 8;
            this.storeOutputPathTextBox.TextChanged += new System.EventHandler(this.storeOutputPathTextBox_TextChanged);
            // 
            // setStoreOutputPathButton
            // 
            this.setStoreOutputPathButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.setStoreOutputPathButton.Location = new System.Drawing.Point(22, 80);
            this.setStoreOutputPathButton.Name = "setStoreOutputPathButton";
            this.setStoreOutputPathButton.Size = new System.Drawing.Size(129, 23);
            this.setStoreOutputPathButton.TabIndex = 9;
            this.setStoreOutputPathButton.Text = "Set Output";
            this.setStoreOutputPathButton.UseVisualStyleBackColor = true;
            this.setStoreOutputPathButton.Click += new System.EventHandler(this.setStoreOutputPathButton_Click);
            // 
            // storeFpsTextBox
            // 
            this.storeFpsTextBox.Location = new System.Drawing.Point(105, 113);
            this.storeFpsTextBox.Name = "storeFpsTextBox";
            this.storeFpsTextBox.Size = new System.Drawing.Size(73, 20);
            this.storeFpsTextBox.TabIndex = 10;
            this.storeFpsTextBox.Text = "3";
            this.storeFpsTextBox.TextChanged += new System.EventHandler(this.storeFpsTextBox_TextChanged);
            // 
            // storeFpsLabel
            // 
            this.storeFpsLabel.AutoSize = true;
            this.storeFpsLabel.Location = new System.Drawing.Point(19, 116);
            this.storeFpsLabel.Name = "storeFpsLabel";
            this.storeFpsLabel.Size = new System.Drawing.Size(27, 13);
            this.storeFpsLabel.TabIndex = 11;
            this.storeFpsLabel.Text = "FPS";
            // 
            // storeBoxSizeLabel
            // 
            this.storeBoxSizeLabel.AutoSize = true;
            this.storeBoxSizeLabel.Location = new System.Drawing.Point(19, 143);
            this.storeBoxSizeLabel.Name = "storeBoxSizeLabel";
            this.storeBoxSizeLabel.Size = new System.Drawing.Size(48, 13);
            this.storeBoxSizeLabel.TabIndex = 12;
            this.storeBoxSizeLabel.Text = "Box Size";
            // 
            // storeBoxSizeTextBox
            // 
            this.storeBoxSizeTextBox.Location = new System.Drawing.Point(105, 140);
            this.storeBoxSizeTextBox.Name = "storeBoxSizeTextBox";
            this.storeBoxSizeTextBox.Size = new System.Drawing.Size(73, 20);
            this.storeBoxSizeTextBox.TabIndex = 13;
            this.storeBoxSizeTextBox.Text = "10";
            this.storeBoxSizeTextBox.TextChanged += new System.EventHandler(this.storeBoxSizeTextBox_TextChanged);
            // 
            // storeFpsRecommendedLabel
            // 
            this.storeFpsRecommendedLabel.AutoSize = true;
            this.storeFpsRecommendedLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.storeFpsRecommendedLabel.Location = new System.Drawing.Point(194, 116);
            this.storeFpsRecommendedLabel.Name = "storeFpsRecommendedLabel";
            this.storeFpsRecommendedLabel.Size = new System.Drawing.Size(114, 13);
            this.storeFpsRecommendedLabel.TabIndex = 14;
            this.storeFpsRecommendedLabel.Text = "Recommended FPS: 3";
            // 
            // storeBoxSizeRecommendedLabel
            // 
            this.storeBoxSizeRecommendedLabel.AutoSize = true;
            this.storeBoxSizeRecommendedLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.storeBoxSizeRecommendedLabel.Location = new System.Drawing.Point(194, 143);
            this.storeBoxSizeRecommendedLabel.Name = "storeBoxSizeRecommendedLabel";
            this.storeBoxSizeRecommendedLabel.Size = new System.Drawing.Size(135, 13);
            this.storeBoxSizeRecommendedLabel.TabIndex = 15;
            this.storeBoxSizeRecommendedLabel.Text = "Recommended Box Size: 5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(19, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Extract file from a video";
            // 
            // extractProgressBar
            // 
            this.extractProgressBar.Location = new System.Drawing.Point(22, 518);
            this.extractProgressBar.Name = "extractProgressBar";
            this.extractProgressBar.Size = new System.Drawing.Size(639, 23);
            this.extractProgressBar.TabIndex = 17;
            // 
            // extractBoxSizeRecommendedLabel
            // 
            this.extractBoxSizeRecommendedLabel.AutoSize = true;
            this.extractBoxSizeRecommendedLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.extractBoxSizeRecommendedLabel.Location = new System.Drawing.Point(194, 483);
            this.extractBoxSizeRecommendedLabel.Name = "extractBoxSizeRecommendedLabel";
            this.extractBoxSizeRecommendedLabel.Size = new System.Drawing.Size(264, 13);
            this.extractBoxSizeRecommendedLabel.TabIndex = 23;
            this.extractBoxSizeRecommendedLabel.Text = "This must be the same as the original video\'s Box Size.";
            // 
            // extractFpsMultiplierRecommendedLabel
            // 
            this.extractFpsMultiplierRecommendedLabel.AutoSize = true;
            this.extractFpsMultiplierRecommendedLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.extractFpsMultiplierRecommendedLabel.Location = new System.Drawing.Point(19, 436);
            this.extractFpsMultiplierRecommendedLabel.Name = "extractFpsMultiplierRecommendedLabel";
            this.extractFpsMultiplierRecommendedLabel.Size = new System.Drawing.Size(143, 13);
            this.extractFpsMultiplierRecommendedLabel.TabIndex = 22;
            this.extractFpsMultiplierRecommendedLabel.Text = "If the video is from YouTube:";
            // 
            // extractBoxSizeTextBox
            // 
            this.extractBoxSizeTextBox.Location = new System.Drawing.Point(105, 480);
            this.extractBoxSizeTextBox.Name = "extractBoxSizeTextBox";
            this.extractBoxSizeTextBox.Size = new System.Drawing.Size(73, 20);
            this.extractBoxSizeTextBox.TabIndex = 21;
            this.extractBoxSizeTextBox.Text = "10";
            this.extractBoxSizeTextBox.TextChanged += new System.EventHandler(this.extractBoxSizeTextBox_TextChanged);
            // 
            // extractBoxSizeLabel
            // 
            this.extractBoxSizeLabel.AutoSize = true;
            this.extractBoxSizeLabel.Location = new System.Drawing.Point(19, 483);
            this.extractBoxSizeLabel.Name = "extractBoxSizeLabel";
            this.extractBoxSizeLabel.Size = new System.Drawing.Size(48, 13);
            this.extractBoxSizeLabel.TabIndex = 20;
            this.extractBoxSizeLabel.Text = "Box Size";
            // 
            // extractFpsMultiplierLabel
            // 
            this.extractFpsMultiplierLabel.AutoSize = true;
            this.extractFpsMultiplierLabel.Location = new System.Drawing.Point(19, 389);
            this.extractFpsMultiplierLabel.Name = "extractFpsMultiplierLabel";
            this.extractFpsMultiplierLabel.Size = new System.Drawing.Size(71, 13);
            this.extractFpsMultiplierLabel.TabIndex = 19;
            this.extractFpsMultiplierLabel.Text = "FPS Multiplier";
            // 
            // extractFpsMultiplierTextBox
            // 
            this.extractFpsMultiplierTextBox.Location = new System.Drawing.Point(105, 386);
            this.extractFpsMultiplierTextBox.Name = "extractFpsMultiplierTextBox";
            this.extractFpsMultiplierTextBox.Size = new System.Drawing.Size(73, 20);
            this.extractFpsMultiplierTextBox.TabIndex = 18;
            this.extractFpsMultiplierTextBox.Text = "2";
            this.extractFpsMultiplierTextBox.TextChanged += new System.EventHandler(this.extractFpsMultiplierTextBox_TextChanged);
            // 
            // setExtractOutputPathButton
            // 
            this.setExtractOutputPathButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.setExtractOutputPathButton.Location = new System.Drawing.Point(22, 346);
            this.setExtractOutputPathButton.Name = "setExtractOutputPathButton";
            this.setExtractOutputPathButton.Size = new System.Drawing.Size(129, 23);
            this.setExtractOutputPathButton.TabIndex = 25;
            this.setExtractOutputPathButton.Text = "Set Output";
            this.setExtractOutputPathButton.UseVisualStyleBackColor = true;
            this.setExtractOutputPathButton.Click += new System.EventHandler(this.setExtractOutputPathButton_Click);
            // 
            // extractOutputPathTextBox
            // 
            this.extractOutputPathTextBox.Location = new System.Drawing.Point(170, 348);
            this.extractOutputPathTextBox.Name = "extractOutputPathTextBox";
            this.extractOutputPathTextBox.ReadOnly = true;
            this.extractOutputPathTextBox.Size = new System.Drawing.Size(373, 20);
            this.extractOutputPathTextBox.TabIndex = 24;
            this.extractOutputPathTextBox.TextChanged += new System.EventHandler(this.extractOutputPathTextBox_TextChanged);
            // 
            // storeInfoTextBox
            // 
            this.storeInfoTextBox.Location = new System.Drawing.Point(22, 217);
            this.storeInfoTextBox.Name = "storeInfoTextBox";
            this.storeInfoTextBox.ReadOnly = true;
            this.storeInfoTextBox.Size = new System.Drawing.Size(639, 39);
            this.storeInfoTextBox.TabIndex = 26;
            this.storeInfoTextBox.Text = "";
            // 
            // extractInfoTextBox
            // 
            this.extractInfoTextBox.Location = new System.Drawing.Point(22, 561);
            this.extractInfoTextBox.Name = "extractInfoTextBox";
            this.extractInfoTextBox.ReadOnly = true;
            this.extractInfoTextBox.Size = new System.Drawing.Size(639, 38);
            this.extractInfoTextBox.TabIndex = 27;
            this.extractInfoTextBox.Text = "";
            // 
            // extractFpsMultiplierRecommendedBLabel
            // 
            this.extractFpsMultiplierRecommendedBLabel.AutoSize = true;
            this.extractFpsMultiplierRecommendedBLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.extractFpsMultiplierRecommendedBLabel.Location = new System.Drawing.Point(19, 451);
            this.extractFpsMultiplierRecommendedBLabel.Name = "extractFpsMultiplierRecommendedBLabel";
            this.extractFpsMultiplierRecommendedBLabel.Size = new System.Drawing.Size(434, 13);
            this.extractFpsMultiplierRecommendedBLabel.TabIndex = 28;
            this.extractFpsMultiplierRecommendedBLabel.Text = "Set this to 2 if the original video\'s FPS is 3 (Default), and to 6 if the origina" +
    "l video\'s FPS is 1.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(19, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Set this to 1 if it\'s still the original video file.";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.versionLabel.Location = new System.Drawing.Point(626, 9);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(46, 13);
            this.versionLabel.TabIndex = 30;
            this.versionLabel.Text = "v1.0.0.1";
            this.versionLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 624);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.extractFpsMultiplierRecommendedBLabel);
            this.Controls.Add(this.extractInfoTextBox);
            this.Controls.Add(this.storeInfoTextBox);
            this.Controls.Add(this.setExtractOutputPathButton);
            this.Controls.Add(this.extractOutputPathTextBox);
            this.Controls.Add(this.extractBoxSizeRecommendedLabel);
            this.Controls.Add(this.extractFpsMultiplierRecommendedLabel);
            this.Controls.Add(this.extractBoxSizeTextBox);
            this.Controls.Add(this.extractBoxSizeLabel);
            this.Controls.Add(this.extractFpsMultiplierLabel);
            this.Controls.Add(this.extractFpsMultiplierTextBox);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.Text = "Store Secret File In Video";
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
        private System.Windows.Forms.Label extractFpsMultiplierRecommendedLabel;
        private System.Windows.Forms.TextBox extractBoxSizeTextBox;
        private System.Windows.Forms.Label extractBoxSizeLabel;
        private System.Windows.Forms.Label extractFpsMultiplierLabel;
        private System.Windows.Forms.TextBox extractFpsMultiplierTextBox;
        private System.Windows.Forms.Button setExtractOutputPathButton;
        private System.Windows.Forms.TextBox extractOutputPathTextBox;
        public System.Windows.Forms.RichTextBox storeInfoTextBox;
        public System.Windows.Forms.RichTextBox extractInfoTextBox;
        private System.Windows.Forms.Label extractFpsMultiplierRecommendedBLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label versionLabel;
    }
}

