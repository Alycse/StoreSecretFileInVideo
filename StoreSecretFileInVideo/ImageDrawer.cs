using Accord.Video.FFMPEG;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreFileInVideo {
    class ImageDrawer {

        private const int ProgressInterval = 25;

        private IProgress<int> _progress;
        private int _progressCount;

        private VideoFileWriter _writer;

        private byte[] _fileBytes;
        private int _byteIndex;

        public ImageDrawer(VideoFileWriter writer, byte[] fileBytes, IProgress<int> progress = null) {
            _writer = writer;
            _fileBytes = fileBytes;
            _progress = progress;
        }

        public void DrawImages (int start, int end, int width, int height, int boxSize) {
            SolidBrush brush = new SolidBrush(Color.White);

            _progressCount = 0;
            _byteIndex = start;

            while (_byteIndex < end) {
                Bitmap image = ProcessImage(brush, width, height, boxSize);
                _writer.WriteVideoFrame(image);
                image.Dispose();
            }

            brush.Dispose();
        }

        private Bitmap ProcessImage (SolidBrush brush, int width, int height, int boxSize) {
            Bitmap image = new Bitmap(width, height);
            Rectangle rect = new Rectangle(0, 0, boxSize, boxSize);

            using (Graphics graphics = Graphics.FromImage(image)) {
                for (int x = 0; x + boxSize - 1 < image.Width && _byteIndex < _fileBytes.Length; x += boxSize) {

                    Color[] colorByte = ColorByte.GetColorsFromByte(_fileBytes[_byteIndex]);
                    byte i = 0;
                    for (int y = 0; y + boxSize - 1 < image.Height && i < colorByte.Length && !colorByte[i].IsEmpty; y += boxSize, i++) {
                        brush.Color = colorByte[i];
                        rect.X = x;
                        rect.Y = y;
                        graphics.FillRectangle(brush, rect);
                    }

                    _byteIndex++;
                    _progressCount++;

                    ReportProgress(1);
                }
            }

            return image;
        }

        private void ReportProgress (int increment) {
            if (_progressCount % ProgressInterval == 0) {
                _progress?.Report(ProgressInterval * increment);
            }
        }
    }
}
