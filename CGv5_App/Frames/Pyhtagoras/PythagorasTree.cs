using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace CGv5_App.Frames.Pyhtagoras
{
    public class PythagorasTree : System.Windows.Controls.Canvas
    {
        private static readonly int depthLimit = 10;
        private static readonly float hue = 0.5f;

        public PythagorasTree(int width, int height)
        {
            Width = width;
            Height = height;
            Background = Brushes.White;
        }

        private void DrawTree(DrawingContext dc, float x1, float y1, float x2, float y2, int depth)
        {
            if (depth == depthLimit)
                return;

            float dx = x2 - x1;
            float dy = y1 - y2;

            float x3 = x2 - dy;
            float y3 = y2 - dx;
            float x4 = x1 - dy;
            float y4 = y1 - dx;
            float x5 = x4 + 0.5F * (dx - dy);
            float y5 = y4 - 0.5F * (dx + dy);

            PathGeometry square = new PathGeometry();
            PathFigure squareFigure = new PathFigure();
            squareFigure.StartPoint = new Point(x1, y1);
            squareFigure.Segments.Add(new LineSegment(new Point(x2, y2), true));
            squareFigure.Segments.Add(new LineSegment(new Point(x3, y3), true));
            squareFigure.Segments.Add(new LineSegment(new Point(x4, y4), true));
            squareFigure.IsClosed = true;
            square.Figures.Add(squareFigure);

            dc.DrawGeometry(new SolidColorBrush(Color.FromRgb(0, (byte)(hue + depth * 0.05f * 255), 0)), null, square);
            dc.DrawGeometry(null, new Pen(Brushes.DarkGreen, 1), square);

            PathGeometry triangle = new PathGeometry();
            PathFigure triangleFigure = new PathFigure();
            triangleFigure.StartPoint = new Point(x3, y3);
            triangleFigure.Segments.Add(new LineSegment(new Point(x4, y4), true));
            triangleFigure.Segments.Add(new LineSegment(new Point(x5, y5), true));
            triangleFigure.IsClosed = true;
            triangle.Figures.Add(triangleFigure);

            dc.DrawGeometry(new SolidColorBrush(Color.FromRgb(0, (byte)(hue + depth * 0.1f * 255), 0)), null, triangle);
            dc.DrawGeometry(null, new Pen(Brushes.Orange, 1), triangle);

            DrawTree(dc, x4, y4, x5, y5, depth + 1);
            DrawTree(dc, x5, y5, x3, y3, depth + 1);
        }

        protected override void OnRender(DrawingContext dc)
        {
            base.OnRender(dc);
            DrawTree(dc, 275, 500, 375, 500, 0);
        }

        public static WriteableBitmap SaveAsWriteableBitmap(Canvas surface)
        {
            if (surface == null) return null;

            Transform transform = surface.LayoutTransform;
            surface.LayoutTransform = null;
            Size size = new Size(surface.ActualWidth, surface.ActualHeight);
            surface.Measure(size);
            surface.Arrange(new Rect(size));

            RenderTargetBitmap renderBitmap = new RenderTargetBitmap(
              (int)size.Width,
              (int)size.Height,
              96d,
              96d,
              PixelFormats.Pbgra32);
            renderBitmap.Render(surface);

            surface.LayoutTransform = transform;

            return new WriteableBitmap(renderBitmap);

        }
    }
}