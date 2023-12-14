using System;
using System.Collections.Generic;
using Color = System.Windows.Media.Color;

namespace CGv5_App.Frames
{
    class GradientColorGenerator
    {
        public IList<dynamic> _stops;

        public int[] GeneratePalette(int depth, Color color1, Color color2, Color color3, Color color4, Color color5)
        {
            _stops = new List<dynamic>
            {
                new { v=0.000f, r = color1.R /255f, g = color1.G /255f , b = (float)color1.B/255f },
                new { v=0.160f, r = color2.R /255f, g = color2.G /255f , b = (float)color2.B/255f },
                new { v=0.420f, r = color3.R /255f, g = color3.G /255f , b = (float)color3.B/255f },
                new { v=0.642f, r = color4.R /255f, g = color4.G /255f , b = (float)color4.B/255f },
                new { v=1.000f, r = color5.R /255f, g = color5.G /255f , b = (float)color5.B/255f },
            };

            var x = new int[depth];
            for (int i = 0; i < depth; i++)
            {
                x[i] = GetColor(i / (float)depth);
            }
            return x;
        }

        private int GetColor(float p)
        {
            if (p > 1)
                p = 1;

            for (int i = 0; i < _stops.Count; i++)
            {
                if (_stops[i].v <= p && _stops[i + 1].v >= p)
                {
                    var s0 = _stops[i];
                    var s1 = _stops[i + 1];
                    var pos = (p - s0.v) / (s1.v - s0.v);
                    var rpos = 1 - pos;
                    var r = rpos * s0.r + pos * s1.r;
                    var g = rpos * s0.g + pos * s1.g;
                    var b = rpos * s0.b + pos * s1.b;
                    return
                        Convert.ToByte(r * 255) << 16 |
                        Convert.ToByte(g * 255) << 8 |
                        Convert.ToByte(b * 255);
                }
            }

            return 0;
        }
    }
}
