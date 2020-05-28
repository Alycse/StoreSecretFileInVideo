﻿using System;
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

        private const int ProgressInterval = 50;

        public async void WriteVideo (string outputPath, int fps, byte[] fileBytes, byte[] filenameBytes, int boxSize, ProgressBar progressBar, RichTextBox storeInfoTextBox) {
            storeInfoTextBox.Text = "Storing file to a video...";

            progressBar.Value = 0;

            int totalProgressCount = 0;
            var progress = new Progress<int>(progressIncrement => {
                totalProgressCount += progressIncrement;
                progressBar.Value = Math.Min(100, (int)(((float)totalProgressCount / (float)fileBytes.Length) * 100.0f));
            });

            VideoFileWriter writer = new VideoFileWriter();
            writer.Open(outputPath, 1920, 1080, fps, VideoCodec.Default);

            Task drawImagesTask = Task.Factory.StartNew(() => {
                ImageDrawer filenameImageDrawer = new ImageDrawer(writer, filenameBytes);
                filenameImageDrawer.DrawImages(0, filenameBytes.Length, 1920, 1080, boxSize);

                ImageDrawer fileImageDrawer = new ImageDrawer(writer, fileBytes);
                fileImageDrawer.DrawImages(0, fileBytes.Length, 1920, 1080, boxSize);
            });
            await drawImagesTask;

            progressBar.Value = 100;

            storeInfoTextBox.Text = "Video was sucessfully stored!";

            writer.Close();
        }
    }
}