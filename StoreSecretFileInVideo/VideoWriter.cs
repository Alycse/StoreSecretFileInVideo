using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accord.Video.FFMPEG;

namespace StoreFileInVideo {
    class VideoWriter {

        public async void WriteVideo (string outputPath, int fps, byte[] fileBytes, byte[] filenameBytes, int boxSize, ProgressBar progressBar, RichTextBox storeInfoTextBox) {
            storeInfoTextBox.Text = "Storing file to a video...";
            progressBar.Value = 1;

            int totalProgressCount = 0;
            var progress = new Progress<int>(progressIncrement => {
                totalProgressCount += progressIncrement;
                storeInfoTextBox.Text = totalProgressCount + "/" + fileBytes.Length + " bytes stored.";
                progressBar.Value = Math.Min(100, (int)(((float)totalProgressCount / (float)fileBytes.Length) * 100.0f));
            });

            VideoFileWriter writer = new VideoFileWriter();
            writer.Open(outputPath, 1280, 720, fps, VideoCodec.Default);
            Task drawImagesTask = Task.Factory.StartNew(() => {
                ImageDrawer filenameImageDrawer = new ImageDrawer(writer, filenameBytes);
                filenameImageDrawer.DrawImages(0, filenameBytes.Length, 1280, 720, boxSize);

                ImageDrawer fileImageDrawer = new ImageDrawer(writer, fileBytes, progress);
                fileImageDrawer.DrawImages(0, fileBytes.Length, 1280, 720, boxSize);
            });
            await drawImagesTask;

            progressBar.Value = 100;
            storeInfoTextBox.Text = "Video was sucessfully stored!";

            writer.Close();
        }
    }
}
