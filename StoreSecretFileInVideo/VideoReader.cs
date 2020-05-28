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

        public async void ReadVideo (string videoFilename, string outputPath, int boxSize, ProgressBar progressBar, int fps, RichTextBox extractInfoTextBox) {
            extractInfoTextBox.Text = "Extracting file from video...";

            VideoFileReader reader = new VideoFileReader();
            reader.Open(videoFilename);

            progressBar.Value = 0;

            int totalProgressCount = 0;
            var progress = new Progress<int>(progressIncrement => {
                totalProgressCount += progressIncrement;
                if (reader.IsOpen) {
                    progressBar.Value = Math.Min(100, (int)(((float)totalProgressCount / (float)reader.FrameCount) * 100.0f));
                }
            });

            ByteReader byteReader = new ByteReader(videoFilename, progress);
            long getFileByteTaskFraction = reader.FrameCount / 4;
            Task<List<byte>> getFileBytesTask = Task<List<byte>>.Factory.StartNew(() =>
                byteReader.GetFileBytes(fps, getFileByteTaskFraction, fps, boxSize)
            );;
            Task<List<byte>> getFileBytesTask2 = Task<List<byte>>.Factory.StartNew(() =>
                byteReader.GetFileBytes(getFileByteTaskFraction, getFileByteTaskFraction * 2, fps, boxSize)
            );
            Task<List<byte>> getFileBytesTask3 = Task<List<byte>>.Factory.StartNew(() =>
                byteReader.GetFileBytes((getFileByteTaskFraction * 2), getFileByteTaskFraction * 3, fps, boxSize)
            );
            Task<List<byte>> getFileBytesTask4 = Task<List<byte>>.Factory.StartNew(() =>
                byteReader.GetFileBytes((getFileByteTaskFraction * 3), reader.FrameCount, fps, boxSize)
            );

            await Task.WhenAll(getFileBytesTask, getFileBytesTask2, getFileBytesTask3, getFileBytesTask4);

            getFileBytesTask.Result.AddRange(getFileBytesTask2.Result);
            getFileBytesTask.Result.AddRange(getFileBytesTask3.Result);
            getFileBytesTask.Result.AddRange(getFileBytesTask4.Result);

            string outputFilename = Encoding.ASCII.GetString(byteReader.GetFileBytes(0, 1, fps, boxSize).ToArray());

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
