using Accord;
using System;
using System.IO;
using System.Security;
using System.Text;
using System.Windows.Forms;

namespace StoreFileInVideo {
    public partial class Main : Form {

        private const int DefaultStoreFps = 1;
        private const int DefaultStoreBoxSize = 5;

        private const int DefaultExtractFps = 1;
        private const int DefaultExtractBoxSize = 5;

        public Main () {
            InitializeComponent();
        }

        private void Main_Load (object sender, EventArgs e) {
            SetStoreFpsTextBoxDefault();
            SetStoreBoxSizeTextBoxDefault();

            UpdateSetStoreOutputPathButtonStatus();
            UpdateStoreButtonStatus();

            UpdateSetExtractOutputPathButtonStatus();
            UpdateExtractButtonStatus();

            SetExtractFpsTextBoxDefault();
            SetExtractBoxSizeTextBoxDefault();
        }

        private void browseStoreFilePathButton_Click (object sender, EventArgs e) {
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                try {
                    storeFilePathTextBox.Text = openFileDialog.FileName;
                } catch (SecurityException ex) {
                    storeInfoTextBox.Text =
                        "Security error!" +
                        "\nError message: " + ex.Message +
                        "\nDetails: " + ex.StackTrace;
                }
            }
        }

        private void Store () {
            byte[] fileBytes = FileReader.ReadFile(storeFilePathTextBox.Text);
            byte[] fileNameBytes = Encoding.ASCII.GetBytes(Path.GetFileName(storeFilePathTextBox.Text));

            VideoWriter videoWriter = new VideoWriter();
            try {
                videoWriter.WriteVideo(storeOutputPathTextBox.Text, int.Parse(storeFpsTextBox.Text), fileBytes, fileNameBytes, int.Parse(storeBoxSizeTextBox.Text), storeProgressBar, storeInfoTextBox);
            }catch(Exception e) {
                storeInfoTextBox.Text = "Error storing file!\n" + e.Message;
            }
        }

        private void extractButton_Click (object sender, EventArgs e) {
            Extract();
        }

        private void Extract () {
            VideoReader videoReader = new VideoReader();
            try {
                videoReader.ReadVideo(extractVideoPathTextBox.Text, extractOutputPathTextBox.Text, int.Parse(extractBoxSizeTextBox.Text), extractProgressBar, int.Parse(extractFpsTextBox.Text), extractInfoTextBox);
            } catch(Exception e) {
                extractInfoTextBox.Text = "Error extracting file!\n" + e.Message;
            }
        }

        private void storeFilePathTextBox_TextChanged (object sender, EventArgs e) {
            UpdateSetStoreOutputPathButtonStatus();
            UpdateStoreButtonStatus();
        }

        private void storeButton_Click (object sender, EventArgs e) {
            Store();
        }

        private void setStoreOutputPathButton_Click (object sender, EventArgs e) {
            if (storeOutputPathSaveDialog.ShowDialog() == DialogResult.OK) {
                storeOutputPathTextBox.Text = storeOutputPathSaveDialog.FileName;
            }
        }

        private void storeOutputPathTextBox_TextChanged (object sender, EventArgs e) {
            UpdateStoreButtonStatus();
        }

        private void UpdateStoreButtonStatus () {
            storeButton.Enabled = storeFilePathTextBox.Text.Length > 0 && storeOutputPathTextBox.Text.Length > 0;
        }

        private void UpdateExtractButtonStatus () {
            extractButton.Enabled = extractVideoPathTextBox.Text.Length > 0 && extractOutputPathTextBox.Text.Length > 0;
        }

        private void UpdateSetStoreOutputPathButtonStatus () {
            setStoreOutputPathButton.Enabled = storeFilePathTextBox.Text.Length > 0;
        }

        private void UpdateSetExtractOutputPathButtonStatus () {
            setExtractOutputPathButton.Enabled = extractVideoPathTextBox.Text.Length > 0;
        }

        private void storeFpsTextBox_TextChanged (object sender, EventArgs e) {
            if(storeFpsTextBox.Text.Length == 0 || int.Parse(storeFpsTextBox.Text) <= 0) {
                SetStoreFpsTextBoxDefault();
            }
        }

        private void SetStoreFpsTextBoxDefault () {
            storeFpsTextBox.Text = DefaultStoreFps.ToString();
        }

        private void storeBoxSizeTextBox_TextChanged (object sender, EventArgs e) {
            if (storeBoxSizeTextBox.Text.Length == 0 || int.Parse(storeBoxSizeTextBox.Text) <= 0) {
                SetStoreBoxSizeTextBoxDefault();
            }
        }

        private void SetStoreBoxSizeTextBoxDefault () {
            storeBoxSizeTextBox.Text = DefaultStoreBoxSize.ToString();
        }

        private void SetExtractFpsTextBoxDefault () {
            extractFpsTextBox.Text = DefaultExtractFps.ToString();
        }

        private void SetExtractBoxSizeTextBoxDefault () {
            extractBoxSizeTextBox.Text = DefaultExtractBoxSize.ToString();
        }

        private void browseExtractVideoPathButton_Click (object sender, EventArgs e) {
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                try {
                    extractVideoPathTextBox.Text = openFileDialog.FileName;
                } catch (SecurityException ex) {
                    extractInfoTextBox.Text =
                        "Security error!" +
                        "\nError message: " + ex.Message +
                        "\nDetails: " + ex.StackTrace;
                }
            }
        }

        private void extractVideoPathTextBox_TextChanged (object sender, EventArgs e) {
            UpdateSetExtractOutputPathButtonStatus();
        }

        private void setExtractOutputPathButton_Click (object sender, EventArgs e) {
            if (extractOutputPathFolderBrowserDialog.ShowDialog() == DialogResult.OK) {
                extractOutputPathTextBox.Text = extractOutputPathFolderBrowserDialog.SelectedPath;
            }
        }

        private void extractOutputPathTextBox_TextChanged (object sender, EventArgs e) {
            UpdateExtractButtonStatus();
        }

        private void extractFpsTextBox_TextChanged (object sender, EventArgs e) {
            if (extractFpsTextBox.Text.Length == 0 || int.Parse(extractFpsTextBox.Text) <= 0) {
                SetExtractFpsTextBoxDefault();
            }
        }

        private void extractBoxSizeTextBox_TextChanged (object sender, EventArgs e) {
            if (extractBoxSizeTextBox.Text.Length == 0 || int.Parse(extractBoxSizeTextBox.Text) <= 0) {
                SetExtractBoxSizeTextBoxDefault();
            }
        }
    }
}
