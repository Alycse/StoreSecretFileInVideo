using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Accord.Video.FFMPEG;
using System.Drawing;

namespace StoreFileInVideo {
    public static class FileReader {
        public static byte[] ReadFile(string path) {
            return File.ReadAllBytes(path);
        }
    }
}
