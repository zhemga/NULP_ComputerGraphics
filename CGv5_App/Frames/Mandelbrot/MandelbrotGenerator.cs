using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;

namespace CGv5_App.Frames
{
    public static class MandelbrotGenerator
    {
        public static void GenerateImage(WriteableBitmap bmp,
    double startX, double startY, double step, int[] palette)
        {
            long buffer = 0;
            var stride = 0;
            var width = 0;
            var height = 0;

            bmp.Dispatcher.Invoke(() =>
            {
                bmp.Lock();
                buffer = (long)bmp.BackBuffer;
                stride = bmp.BackBufferStride;
                width = bmp.PixelWidth;
                height = bmp.PixelHeight;
            });

            unsafe
            {
                Parallel.For(0, height, j =>
                {
                    Parallel.For(0, width, i =>
                    {
                        var pixel = buffer + j * stride + i * 3;
                        *(int*)pixel = palette[Iterate(
                            startX + i * step,
                            startY + j * step,
                            palette.Length)];
                    });
                });
            }

            bmp.Dispatcher.Invoke(() =>
            {
                bmp.AddDirtyRect(new Int32Rect(0, 0, width, height));
                bmp.Unlock();
            });
        }

        static int Iterate(double x, double y, int limit)
        {
            var x0 = x;
            var y0 = y;

            for (var i = 0; i < limit; i++)
            {
                if (x * x + y * y >= 4)
                    return i;

                var zx = x * x * x - 3 * x * y * y + x0;
                y = 3 * x * x * y - y * y * y + y0;
                x = zx;
            }

            return 0;
        }
    }
}
