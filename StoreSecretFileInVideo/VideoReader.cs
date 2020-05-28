using Accord.Video.FFMPEG;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreFileInVideo {
    class VideoReader {

        public async void ReadVideo (string videoFilename, string outputPath, int boxSize, ProgressBar progressBar, int fpsMultiplier, RichTextBox extractInfoTextBox) {
            extractInfoTextBox.Text = "Extracting file from video...";
            progressBar.Value = 1;

            VideoFileReader reader = new VideoFileReader();
            reader.Open(videoFilename);

            int totalProgressCount = 0;
            var progress = new Progress<int>(progressIncrement => {
                totalProgressCount += progressIncrement;
                if (reader.IsOpen) {
                    extractInfoTextBox.Text = totalProgressCount + "/" + reader.FrameCount + " Frames processed.";
                    progressBar.Value = Math.Min(100, (int)(((float)totalProgressCount / (float)reader.FrameCount) * 100.0f));
                }
            });

            ByteReader byteReader = new ByteReader(videoFilename, progress);
            Task<List<byte>> getFileBytesTask = Task<List<byte>>.Factory.StartNew(() =>
                byteReader.GetFileBytes(fpsMultiplier, (int)reader.FrameCount, fpsMultiplier, boxSize)
            );;
            await getFileBytesTask;

            string outputFilename = Encoding.ASCII.GetString(byteReader.GetFileBytes(0, 1, fpsMultiplier, boxSize).ToArray());

            try {
                File.WriteAllBytes(outputPath + "/" + outputFilename, getFileBytesTask.Result.ToArray());
                progressBar.Value = 100;
                extractInfoTextBox.Text = "File was sucessfully extracted!";
            } catch(Exception e) {
                progressBar.Value = 0;
                extractInfoTextBox.Text = "Error extracting file!\nThe settings may be invalid or the video file may be corrupted.\n" + "Error message: " + e.Message;
            }

            reader.Close();
        }

    }
}
