using CGv5_App.Frames.Pyhtagoras;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace CGv5_App.Frames
{
    /// <summary>
    /// Interaction logic for Fractals.xaml
    /// </summary>
    public partial class Fractals : Page
    {
        WriteableBitmap bmp;

        GradientColorGenerator colors = new GradientColorGenerator();
        int depth = 200;
        double step = 0.002;
        double centerX = 0;
        double centerY = 0;
        private bool isDragging = false;
        private Point lastMousePosition;

        // Color Scheme
        public Color Color1 { get; set; }
        public Color Color2 { get; set; }
        public Color Color3 { get; set; }
        public Color Color4 { get; set; }
        public Color Color5 { get; set; }

        public Fractals()
        {
            InitializeComponent();
        }

        private void GenerateFractal_Button_Click(object sender, RoutedEventArgs e)
        {
            bmp = new WriteableBitmap(
               (int)ImageBorder.ActualWidth,
               (int)ImageBorder.ActualHeight,
               96,
               96,
               PixelFormats.Bgr24,
               null
               );

            image.Source = bmp;

            Render();
        }

        private void ScaleSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            step = (double)e.NewValue;

            if (!PythagorasCBI.IsSelected)
                Render();
        }

        private void image_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point currentMousePosition = e.GetPosition(this);
                double deltaX = currentMousePosition.X - lastMousePosition.X;
                double deltaY = currentMousePosition.Y - lastMousePosition.Y;

                centerX -= deltaX * step;
                centerY -= deltaY * step;

                lastMousePosition = currentMousePosition;

                if (!PythagorasCBI.IsSelected)
                    Render();
            }
        }

        private void image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.MouseDevice.LeftButton == MouseButtonState.Pressed)
            {
                isDragging = true;
                lastMousePosition = e.GetPosition(this);
            }
        }

        private void image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (e.MouseDevice.LeftButton == MouseButtonState.Released)
            {
                isDragging = false;
            }
        }

        private void image_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            if (!PythagorasCBI.IsSelected && ScaleSlider.IsEnabled)
            {
                ScaleSlider.Value *= e.Delta > 0 ? 0.9 : 1.1;

                Render();
            }
        }

        private void Render()
        {
            if (bmp != null)
            {
                if (MandelbrotCBI.IsSelected)
                {
                    RenderMandelbrot();
                }
                else if (PythagorasCBI.IsSelected)
                {
                    //GradientColorGenerator.SetColorStops(Colors.AliceBlue, Colors.Aqua, Colors.Coral, Colors.Crimson, Colors.White);
                    RenderPythahorasTree();
                }
                else
                {
                    bmp = null;
                }
            }
        }

        private void RenderMandelbrot()
        {
            UpdateMandelbrotColors();

            MandelbrotGenerator.GenerateImage(
                bmp,
                centerX - (bmp.PixelWidth / 2) * step,
                centerY - (bmp.PixelHeight / 2) * step,
                step,
                colors.GeneratePalette(depth, Color1, Color2, Color3, Color4, Color5));
        }

        private void RenderPythahorasTree()
        {
            var pt = new PythagorasTree((int)ImageBorder.ActualWidth, (int)ImageBorder.ActualHeight);
            Window ptWindow = new Window
            {
                Visibility = Visibility.Hidden,
                ShowInTaskbar = false,
                Title = "Pythagoras Tree",
                Width = ImageBorder.ActualWidth,
                Height = ImageBorder.ActualHeight,
                ResizeMode = ResizeMode.NoResize,
                Content = pt,
            };

            ptWindow.Show();

            image.Source = PythagorasTree.SaveAsWriteableBitmap(pt);

            ptWindow.Close();
        }

        private void FractalTypeCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            image.Source = null;

            if (PythagorasCBI != null)
            {
                if (PythagorasCBI.IsSelected)
                    ColorScheme.Visibility = Visibility.Collapsed;
                else
                    ColorScheme.Visibility = Visibility.Visible;
            }
        }

        private void UpdateMandelbrotColors()
        {
            Color1 = (Color)ColorPicker1.SelectedColor;
            Color2 = (Color)ColorPicker2.SelectedColor;
            Color3 = (Color)ColorPicker3.SelectedColor;
            Color4 = (Color)ColorPicker4.SelectedColor;
            Color5 = (Color)ColorPicker5.SelectedColor;
        }
    }
}

