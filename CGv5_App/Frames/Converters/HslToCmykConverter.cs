using ColorMine.ColorSpaces;
using System.Collections.Generic;
using System.Linq;

namespace CGv5_App.Frames.Converters
{
    public static class HslToCmykConverter
    {
        public static Cmyk Convert(Hsl hslColor)
        {
            double c, m, y, k;

            double h = hslColor.H / 360;
            double s = hslColor.S / 100;
            double l = hslColor.L / 100;

            if (s == 0 || h == 0)
            {
                c = 0;
                m = 0;
                y = 0;
                k = 1 - l;
            }
            else
            {
                double q = (l < 0.5) ? (l * (1 + s)) : (l + s - l * s);
                double p = 2 * l - q;

                var r = HueToRgb(p, q, h + 1.0 / 3);
                var g = HueToRgb(p, q, h);
                var b = HueToRgb(p, q, h - 1.0 / 3);

                k = 1 - new List<double>() { r, g, b }.Max();

                // RGB To CMYK
                c = (1 - r - k) / (1 - k);
                m = (1 - g - k) / (1 - k);
                y = (1 - b - k) / (1 - k);
            }

            return new Cmyk { C = c, M = m, Y = y, K = k };
        }

        private static double HueToRgb(double p, double q, double t)
        {
            if (t < 0) t++;
            if (t > 1) t--;
            if (t < 1.0 / 6) return p + (q - p) * 6 * t;
            if (t < 1.0 / 2) return q;
            if (t < 2.0 / 3) return p + (q - p) * (2.0 / 3 - t) * 6;
            return p;
        }
    }

}
