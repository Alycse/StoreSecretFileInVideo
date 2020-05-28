using System.Collections.Generic;
using System.Drawing;

namespace StoreFileInVideo {
    public static class ColorByte {

        public static Color[] GetColorsFromByte(byte fileByte) {
            Color[] colors = new Color[(fileByte / 3) + 1];
            if (fileByte == 0) {
                return new Color[] { Color.FromArgb(0, 0, 255) };
            } else {
                for (int i = 0; i < colors.Length && fileByte != 0; i++) {
                    if (fileByte >= 3) {
                        fileByte -= 3;
                        colors[i] = Color.FromArgb(255, 255, 255);
                    } else if (fileByte == 2) {
                        fileByte -= 2;
                        colors[i] = Color.FromArgb(0, 255, 255);
                    } else if (fileByte == 1) {
                        fileByte -= 1;
                        colors[i] = Color.FromArgb(255, 0, 255);
                    }
                }
            }
            return colors;
        }

        public static byte GetByteFromColors(List<Color> colors) {
            byte fileByte = 0;
            if (colors.Count > 0 && colors[0].R < 125 && colors[0].G < 125) {
                return fileByte;
            } else {
                for (int i = 0; i < colors.Count; i++) {
                    if(colors[i].R >= 125) {
                        if(colors[i].G >= 125) {
                            fileByte += 3;
                        } else {
                            fileByte += 1;
                        }
                    } else {
                        fileByte += 2;
                    }
                }
                return fileByte;
            }
        }
    }
}
