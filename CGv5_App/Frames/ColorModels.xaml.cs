using CGv5_App.Frames.Converters;
using ColorMine.ColorSpaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CGv5_App.Frames
{
    /// <summary>
    /// Interaction logic for ColorModels.xaml
    /// </summary>
    public partial class ColorModels : Page
    {
        public BitmapImage OldHslBitmap { get; set; }

        public ColorModels()
        {
            InitializeComponent();
        }

        private void GraynessScaleSlider_ValueChanged(object sender, DragCompletedEventArgs e)
        {
            if (this.HslImage.Source == null)
                return;

            this.HslImage.Source = ReplaceColorOfImage(new WriteableBitmap(OldHslBitmap),
                this.GraynessScaleSlider.Value / 100, this.ShadeAccuracyScaleSlider.Value / 100);
        }

        private WriteableBitmap ReplaceColorOfImage(WriteableBitmap writeableBitmap, double scale, double accuracy)
        {
            int stride = writeableBitmap.PixelWidth * 4;
            double calculatedAccuracy = 255 * accuracy;
            byte[] pixelData = new byte[stride * writeableBitmap.PixelHeight];
            writeableBitmap.CopyPixels(pixelData, stride, 0);

            for (int i = 0; i < pixelData.Length; i += 4)
            {
                Rgb rgbColor = new Rgb { R = (int)pixelData[i + 2], G = (int)pixelData[i + 1], B = (int)pixelData[i] };

                if (Math.Abs(rgbColor.R - rgbColor.G) <= calculatedAccuracy && Math.Abs(rgbColor.R - rgbColor.B) <= calculatedAccuracy)
                {
                    Hsl hslColor = rgbColor.To<Hsl>();

                    var newColorValue = hslColor.L * scale;

                    if (newColorValue > 100)
                        newColorValue = 100;

                    hslColor.L = newColorValue;

                    Rgb updatedRgbColor = hslColor.To<Rgb>();

                    pixelData[i + 2] = (byte)updatedRgbColor.R;
                    pixelData[i + 1] = (byte)updatedRgbColor.G;
                    pixelData[i] = (byte)updatedRgbColor.B;

                }
            }

            writeableBitmap.WritePixels(new Int32Rect(0, 0, writeableBitmap.PixelWidth, writeableBitmap.PixelHeight), pixelData, stride, 0);

            return writeableBitmap;
        }

        public WriteableBitmap ImageToHsl(WriteableBitmap writeableBitmap)
        {
            int stride = writeableBitmap.PixelWidth * 4;
            byte[] pixelData = new byte[stride * writeableBitmap.PixelHeight];
            writeableBitmap.CopyPixels(pixelData, stride, 0);

            for (int i = 0; i < pixelData.Length; i += 4)
            {
                Rgb rgbColor = new Rgb { R = (int)pixelData[i + 2], G = (int)pixelData[i + 1], B = (int)pixelData[i] };
                Hsl hslColor = rgbColor.To<Hsl>();

                hslColor.H = (int)hslColor.H;
                hslColor.S = (int)hslColor.S;
                hslColor.L = (int)hslColor.L;

                Rgb updatedRgbColor = hslColor.To<Rgb>();

                pixelData[i + 2] = (byte)(int)updatedRgbColor.R;
                pixelData[i + 1] = (byte)(int)updatedRgbColor.G;
                pixelData[i] = (byte)(int)updatedRgbColor.B;

            }

            writeableBitmap.WritePixels(new Int32Rect(0, 0, writeableBitmap.PixelWidth, writeableBitmap.PixelHeight), pixelData, stride, 0);

            return writeableBitmap;
        }

        public WriteableBitmap ImageToCmyk(WriteableBitmap writeableBitmap)
        {
            int stride = writeableBitmap.PixelWidth * 4;
            byte[] pixelData = new byte[stride * writeableBitmap.PixelHeight];
            writeableBitmap.CopyPixels(pixelData, stride, 0);

            for (int i = 0; i < pixelData.Length; i += 4)
            {
                Rgb rgbColor = new Rgb { R = pixelData[i + 2], G = pixelData[i + 1], B = pixelData[i] };
                Cmyk cmykColor = rgbColor.To<Cmyk>();
                Rgb updatedRgbColor = cmykColor.To<Rgb>();

                pixelData[i + 2] = (byte)(cmykColor.C * 255);
                pixelData[i + 1] = (byte)(cmykColor.M * 255);
                pixelData[i] = (byte)(cmykColor.K * 255);

            }

            writeableBitmap.WritePixels(new Int32Rect(0, 0, writeableBitmap.PixelWidth, writeableBitmap.PixelHeight), pixelData, stride, 0);

            return writeableBitmap;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.GraynessScaleSlider.Value = 100;
            this.ShadeAccuracyScaleSlider.Value = 0;

            if (OldHslBitmap != null)
                this.HslImage.Source = new WriteableBitmap(OldHslBitmap);
        }

        private void HslImage_MouseDown(object sender, MouseEventArgs e)
        {
            var image = sender as System.Windows.Controls.Image;

            if (image == null || image.Source == null)
                return;

            System.Windows.Point mousePosition = e.GetPosition(image);

            if (mousePosition.X >= 0 && mousePosition.Y >= 0 &&
                mousePosition.X < image.ActualWidth && mousePosition.Y < image.ActualHeight)
            {
                int x = (int)mousePosition.X;
                int y = (int)mousePosition.Y;

                DrawingVisual visual = new DrawingVisual();
                using (DrawingContext context = visual.RenderOpen())
                {
                    VisualBrush brush = new VisualBrush(image);
                    context.DrawRectangle(brush, null, new Rect(0, 0, image.ActualWidth, image.ActualHeight));
                }

                RenderTargetBitmap renderTarget =
                    new RenderTargetBitmap((int)image.ActualWidth, (int)image.ActualHeight, 96, 96, PixelFormats.Default);
                renderTarget.Render(visual);

                CroppedBitmap croppedBitmap = new CroppedBitmap(renderTarget, new Int32Rect(x, y, 1, 1));

                byte[] pixelData = new byte[4];

                croppedBitmap.CopyPixels(pixelData, 4, 0);

                byte blue = pixelData[0];
                byte green = pixelData[1];
                byte red = pixelData[2];

                var rgb = new Rgb { R = red, G = green, B = blue };
                var color = new System.Windows.Media.Color { R = (byte)rgb.R, G = (byte)rgb.G, B = (byte)rgb.B, A = 255 };

                var hsl = rgb.To<Hsl>();
                var cmyk = HslToCmykConverter.Convert(hsl);

                HueScaleSlider.Value = Math.Round(hsl.H, 2);
                SaturationScaleSlider.Value = Math.Round(hsl.S, 2);
                LightnessScaleSlider.Value = Math.Round(hsl.L, 2);

                CyanScaleSlider.Value = Math.Round(cmyk.C * 100, 2);
                MagentaScaleSlider.Value = Math.Round(cmyk.M * 100, 2);
                YellowScaleSlider.Value = Math.Round(cmyk.Y * 100, 2);
                KeyScaleSlider.Value = Math.Round(cmyk.K * 100, 2);

                HSLtb.Foreground = new SolidColorBrush(color);
                CMYKtb.Foreground = new SolidColorBrush(color);
            }
        }

        private void CmykImage_MouseDown(object sender, MouseEventArgs e)
        {
            var image = sender as System.Windows.Controls.Image;

            if (image == null || image.Source == null)
                return;

            System.Windows.Point mousePosition = e.GetPosition(image);

            if (mousePosition.X >= 0 && mousePosition.Y >= 0 &&
                mousePosition.X < image.ActualWidth && mousePosition.Y < image.ActualHeight)
            {
                int x = (int)mousePosition.X;
                int y = (int)mousePosition.Y;

                DrawingVisual visual = new DrawingVisual();
                using (DrawingContext context = visual.RenderOpen())
                {
                    VisualBrush brush = new VisualBrush(image);
                    context.DrawRectangle(brush, null, new Rect(0, 0, image.ActualWidth, image.ActualHeight));
                }

                RenderTargetBitmap renderTarget =
                    new RenderTargetBitmap((int)image.ActualWidth, (int)image.ActualHeight, 96, 96, PixelFormats.Default);
                renderTarget.Render(visual);

                CroppedBitmap croppedBitmap = new CroppedBitmap(renderTarget, new Int32Rect(x, y, 1, 1));

                byte[] pixelData = new byte[4];

                croppedBitmap.CopyPixels(pixelData, 4, 0);

                byte blue = pixelData[0];
                byte green = pixelData[1];
                byte red = pixelData[2];

                var rgb = new Rgb { R = red, G = green, B = blue };
                var color = new System.Windows.Media.Color { R = red, G = green, B = blue, A = 255 };

                var cmyk = rgb.To<Cmyk>();
                var hsl = CmykToHslConverter.Convert(cmyk);

                HueScaleSlider.Value = Math.Round(hsl.H, 2);
                SaturationScaleSlider.Value = Math.Round(hsl.S, 2);
                LightnessScaleSlider.Value = Math.Round(hsl.L, 2);

                CyanScaleSlider.Value = Math.Round(cmyk.C * 100, 2);
                MagentaScaleSlider.Value = Math.Round(cmyk.M * 100, 2);
                YellowScaleSlider.Value = Math.Round(cmyk.Y * 100, 2);
                KeyScaleSlider.Value = Math.Round(cmyk.K * 100, 2);

                HSLtb.Foreground = new SolidColorBrush(color);
                CMYKtb.Foreground = new SolidColorBrush(color);
            }
        }

        private void RgbImage_MouseDown(object sender, MouseEventArgs e)
        {
            var image = sender as System.Windows.Controls.Image;

            if (image == null || image.Source == null)
                return;

            System.Windows.Point mousePosition = e.GetPosition(image);

            if (mousePosition.X >= 0 && mousePosition.Y >= 0 &&
                mousePosition.X < image.ActualWidth && mousePosition.Y < image.ActualHeight)
            {
                int x = (int)mousePosition.X;
                int y = (int)mousePosition.Y;

                DrawingVisual visual = new DrawingVisual();
                using (DrawingContext context = visual.RenderOpen())
                {
                    VisualBrush brush = new VisualBrush(image);
                    context.DrawRectangle(brush, null, new Rect(0, 0, image.ActualWidth, image.ActualHeight));
                }

                RenderTargetBitmap renderTarget =
                    new RenderTargetBitmap((int)image.ActualWidth, (int)image.ActualHeight, 96, 96, PixelFormats.Default);
                renderTarget.Render(visual);

                CroppedBitmap croppedBitmap = new CroppedBitmap(renderTarget, new Int32Rect(x, y, 1, 1));

                byte[] pixelData = new byte[4];

                croppedBitmap.CopyPixels(pixelData, 4, 0);

                byte blue = pixelData[0];
                byte green = pixelData[1];
                byte red = pixelData[2];

                var rgb = new Rgb { R = red, G = green, B = blue };
                var color = new System.Windows.Media.Color { R = red, G = green, B = blue, A = 255 };

                var cmyk = rgb.To<Cmyk>();
                var hsl = rgb.To<Hsl>();

                HueScaleSlider.Value = Math.Round(hsl.H, 2);
                SaturationScaleSlider.Value = Math.Round(hsl.S, 2);
                LightnessScaleSlider.Value = Math.Round(hsl.L, 2);

                CyanScaleSlider.Value = Math.Round(cmyk.C * 100, 2);
                MagentaScaleSlider.Value = Math.Round(cmyk.M * 100, 2);
                YellowScaleSlider.Value = Math.Round(cmyk.Y * 100, 2);
                KeyScaleSlider.Value = Math.Round(cmyk.K * 100, 2);

                HSLtb.Foreground = new SolidColorBrush(color);
                CMYKtb.Foreground = new SolidColorBrush(color);
            }
        }
    }
}
