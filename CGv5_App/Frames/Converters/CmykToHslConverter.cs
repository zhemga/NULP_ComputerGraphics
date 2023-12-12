using ColorMine.ColorSpaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CGv5_App.Frames.Converters
{
    public static class CmykToHslConverter
    {
        public static Hsl Convert(Cmyk cmykColor)
        {
            double h = 0, s = 0, l = 0;

            // TO RGB
            var r = 1.0 - cmykColor.C * (1.0 - cmykColor.K) + cmykColor.K;
            var g = 1.0 - cmykColor.M * (1.0 - cmykColor.K) + cmykColor.K;
            var b = 1.0 - cmykColor.Y * (1.0 - cmykColor.K) + cmykColor.K;

            var min = new List<double>() { r, g, b }.Min();
            var max = new List<double>() { r, g, b }.Max();

            var delta = max - min;
            l = (min + max) / 2;

            if (delta == 0)
            {
                h = 0;
                s = 0;
                l = 1 - cmykColor.K;
            }
            else
            {
                s = (delta / (1 - Math.Abs(2 * l - 1)));

                if (r == max)
                {
                    h = (g - b) / delta / 6 % 6;
                }
                else if (g == max)
                {
                    h = ((b - r) / delta + 2) / 6;
                }
                else
                {
                    h = ((r - g) / delta + 4) / 6;
                }

                h = (h < 0) ? ++h : h;
                h = (h > 1) ? --h : h;
            }

            return new Hsl { H = h * 360, S = s * 100, L = l * 100 };
        }
    }

}
