using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accord.Video.FFMPEG;

namespace StoreFileInVideo {
    class ByteReader {

        private const int ProgressInterval = 50;

        private IProgress<int> _progress;
        private int _progressCount;

        private string _filename;

        public ByteReader(string filename, IProgress<int> progress) {
            _filename = filename;
            _progress = progress;
        }

        public List<byte> GetFileBytes (long start, long end, int increment, int boxSize) {
            VideoFileReader reader = new VideoFileReader();
            reader.Open(_filename);

            List<byte> fileBytes = new List<byte>();

            _progressCount = 0;

            for (long i = start; i < end; i += increment) {
                using (Bitmap fileImage = reader.ReadVideoFrame((int)i)) {
                    GetVideoFrameBytes(fileBytes, fileImage, boxSize);
                }

                _progressCount++;

                ReportProgress(increment);
            }

            return fileBytes;
        }

        private static void GetVideoFrameBytes (List<byte> fileBytes, Bitmap fileImage, int boxSize) {
            using (Bitmap formattedImage = fileImage.Clone(new Rectangle(0, 0, fileImage.Width, fileImage.Height), System.Drawing.Imaging.PixelFormat.Format32bppArgb)) {
                using (var snoop = new BmpPixelSnoop(formattedImage)) {
                    for (int x = boxSize / 2; x < fileImage.Width; x += boxSize) {

                        List<Color> colors = new List<Color>();
                        for (int y = boxSize / 2; y < fileImage.Height; y += boxSize) {
                            Color pixelColor = snoop.GetPixel(x, y);
                            if (pixelColor.B >= 125) {
                                colors.Add(pixelColor);
                            } else {
                                break;
                            }
                        }

                        if (colors.Count > 0) {
                            byte fileByte = ColorByte.GetByteFromColors(colors);
                            fileBytes.Add(fileByte);
                        }
                    }
                }
            }
        }

        private void ReportProgress (int increment) {
            if (_progressCount % ProgressInterval == 0) {
                _progress?.Report(ProgressInterval * increment);
            }
        }
    }
}
