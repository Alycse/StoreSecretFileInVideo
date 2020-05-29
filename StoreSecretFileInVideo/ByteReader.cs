using System;
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

        private const int ProgressInterval = 2;

        private IProgress<int> _progress;
        private int _progressCount;

        private string _filename;

        public ByteReader(string filename, IProgress<int> progress) {
            _filename = filename;
            _progress = progress;
        }

        public List<byte> GetFileBytes (int start, int end, int increment, int boxSize) {
            VideoFileReader reader = new VideoFileReader();
            reader.Open(_filename);

            List<byte> fileBytes = new List<byte>();

            _progressCount = 0;

            for (int i = start; i < end; i++) {
                Console.WriteLine("i: " + i + " < " + end);
                using (Bitmap fileImage = reader.ReadVideoFrame(i)) {
                    if(i % increment== 0) {
                        GetVideoFrameBytes(fileBytes, fileImage, boxSize);

                        _progressCount++;

                        ReportProgress(increment);
                    }
                }
            }

            return fileBytes;
        }

        private void GetVideoFrameBytes (List<byte> fileBytes, Bitmap fileImage, int boxSize) {
            string fileByteBinary = "";
            for (int x = boxSize / 2; x <= fileImage.Width; x += boxSize) {
                for (int y = boxSize / 2; y <= fileImage.Height; y += boxSize) {
                    Color pixelColor = fileImage.GetPixel(x, y);

                    if (pixelColor.B >= 125) {
                        if (pixelColor.R >= 125 && pixelColor.G < 125) {
                            fileByteBinary += '0';
                        } else if (pixelColor.R < 125 && pixelColor.G > 125) {
                            fileByteBinary += '1';
                        }
                    } else {
                        goto End;
                    }

                    if (fileByteBinary.Length == 8) {
                        byte videoFrameByte = (byte)Convert.ToInt32(fileByteBinary, 2);

                        fileBytes.Add(videoFrameByte);
                        fileByteBinary = "";
                    }
                }
            }
            End:
            Console.WriteLine("end!");
        }

        private void ReportProgress (int increment) {
           if (_progressCount % ProgressInterval == 0) {
                _progress?.Report(ProgressInterval * increment);
            }
        }
    }
}
