﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Accord.Video.FFMPEG;

namespace StoreFileInVideo {
    class ByteReader {

        private const int ProgressInterval = 1;

        private IProgress<int> _progress;
        int progressCount;

        private string _filename;

        public ByteReader(string filename, IProgress<int> progress) {
            _filename = filename;
            _progress = progress;
        }

        public List<byte> GetFileBytes (int start, int end, int increment, int boxSize) {
            VideoFileReader reader = new VideoFileReader();
            reader.Open(_filename);

            List<byte> fileBytes = new List<byte>();

            progressCount = 0;

            for (int i = start; i < end; i++) {
                using (Bitmap fileImage = reader.ReadVideoFrame(i)) {
                    if (i % increment != 0) {
                        continue;
                    }
                    GetVideoFrameBytes (fileBytes, fileImage, boxSize);
                }

                progressCount++;

                ReportProgress(increment);
            }

            return fileBytes;
        }

        private void GetVideoFrameBytes (List<byte> fileBytes, Bitmap fileImage, int boxSize) {
            for (int x = boxSize / 2; x < fileImage.Width; x += boxSize) {

                List<Color> colors = new List<Color>();
                for (int y = boxSize / 2; y < fileImage.Height; y += boxSize) {
                    Color pixelColor = fileImage.GetPixel(x, y);
                    if (pixelColor.B >= 125) {
                        colors.Add(pixelColor);
                    } else {
                        break;
                    }
                }

                if (colors.Count > 0) {
                    byte videoFrameByte = ColorByte.GetByteFromColors(colors);
                    fileBytes.Add(videoFrameByte);
                }
            }   
        }

        private void ReportProgress (int increment) {
           if (progressCount % ProgressInterval == 0) {
                _progress?.Report(ProgressInterval * increment);
            }
        }
    }
}
