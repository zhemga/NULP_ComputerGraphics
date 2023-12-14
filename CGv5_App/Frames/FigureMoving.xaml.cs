using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using Matrix = System.Windows.Media.Matrix;

namespace CGv5_App.Frames
{
    /// <summary>
    /// Interaction logic for FigureMoving.xaml
    /// </summary>
    public partial class FigureMoving : Page
    {
        public bool IsRunning { get { return isRunning; } }
        public Canvas DrawingCanvas { get { return drawingCanvas; } }

        private const int ARROW_SIZE = 5;
        private const double CELL_THICKNESS = 0.5;
        private const double CELL_SIZE = 20;

        private bool isRunning;
        private double X0 = 0;
        private double Y0 = 0;
        private double cellSize = CELL_SIZE;
        private double cellThickness = CELL_THICKNESS;
        private Rectangle motionRectangle = null;

        private TextBlock labelTopLeft;
        private TextBlock labelTopRight;
        private TextBlock labelBottomLeft;
        private TextBlock labelBottomRight;

        private int numRows = 1;
        private int numCols = 1;

        public FigureMoving()
        {
            InitializeComponent();
        }

        private void DockPanel_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (motionRectangle != null)
            {
                var oldLeftPositionMR =
                     (Canvas.GetLeft(motionRectangle) - numCols / 2 * cellSize) / cellSize;
                var oldTopPositionMR =
                    (numRows / 2 * cellSize - Canvas.GetTop(motionRectangle)) / cellSize;

                PaintCanvas(cellSize, cellThickness);

                Canvas.SetLeft(motionRectangle, (oldLeftPositionMR + numCols / 2) * cellSize);
                Canvas.SetTop(motionRectangle, (numRows / 2 - oldTopPositionMR) * cellSize);
                drawingCanvas.Children.Add(motionRectangle);
                DrawRectangleLabels(motionRectangle, drawingCanvas);
            }
            else
            {
                PaintCanvas(cellSize, cellThickness);
            }
        }

        private async void Run(object sender, RoutedEventArgs e)
        {
            double x1, y1, x2, y2;

            if (!double.TryParse(X1TextBox.Text, out x1) ||
                !double.TryParse(Y1TextBox.Text, out y1) ||
                !double.TryParse(X2TextBox.Text, out x2) ||
                !double.TryParse(Y2TextBox.Text, out y2))
            {
                MessageBox.Show("Invalid input. Please enter valid numeric values.");
                return;
            }

            double rotationAngle, verticalMovingStep, timeInSecondsStep;
            if (!double.TryParse(this.RotateStepTextBox.Text, out rotationAngle) ||
                !double.TryParse(this.VerticalMovingStepTextBox.Text, out verticalMovingStep) ||
                !double.TryParse(this.TimeStepTextBox.Text, out timeInSecondsStep))
            {
                MessageBox.Show("Invalid input. Please enter valid numeric values.");
                return;
            }

            if (rotationAngle <= -180 || rotationAngle >= 0)
            {
                MessageBox.Show("Write rotation angles between (-180; 00)");
                return;
            }

            isRunning = true;

            cellSize = CELL_SIZE;
            cellThickness = CELL_THICKNESS;

            PaintCanvas(cellSize, cellThickness);
            PaintRectangle(x1, y1, x2, y2, cellSize);
            DrawRectangleLabels(motionRectangle, drawingCanvas);

            while (isRunning)
            {
                if (!IsRectangleInsideCanvas(motionRectangle, drawingCanvas))
                {
                    var oldLeftPositionMR =
                        (Canvas.GetLeft(motionRectangle) - numCols / 2 * cellSize) / cellSize;
                    var oldTopPositionMR =
                        (numRows / 2 * cellSize - Canvas.GetTop(motionRectangle)) / cellSize;

                    cellSize /= 2;
                    cellThickness /= 2;
                    PaintCanvas(cellSize, cellThickness);
                    drawingCanvas.Children.Add(motionRectangle);

                    var tmpMotionRectangleMatrix = (motionRectangle.RenderTransform as MatrixTransform).Matrix;

                    motionRectangle.RenderTransform = new MatrixTransform(tmpMotionRectangleMatrix * CreateScalingMatrix(0.5, 0.5));

                    Canvas.SetLeft(motionRectangle, (oldLeftPositionMR + numCols / 2) * cellSize);
                    Canvas.SetTop(motionRectangle, (numRows / 2 - oldTopPositionMR) * cellSize);
                }

                await Task.Delay((int)(timeInSecondsStep * 1000));

                var rectangleCenter = GetRectangleCenter(motionRectangle);

                if (motionRectangle == null)
                    return;

                var motionRectangleMatrix =
                    (motionRectangle.RenderTransform as MatrixTransform).Matrix;
                var matrixOperations = motionRectangleMatrix
                    * CreateRotationMatrixAroundPoint(rotationAngle, rectangleCenter.X, rectangleCenter.Y)
                    //* CreateTranslationMatrixByUpwardDirection(motionRectangle, cellSize * verticalMovingStep);
                    * CreateTranslationMatrix(0, -cellSize * verticalMovingStep);
                motionRectangle.RenderTransform = new MatrixTransform(matrixOperations);

                DrawRectangleLabels(motionRectangle, drawingCanvas);
            }
        }

        private void Stop(object sender, RoutedEventArgs e)
        {
            isRunning = false;
        }

        private async void Clear(object sender, RoutedEventArgs e)
        {
            isRunning = false;

            motionRectangle = null;

            cellSize = CELL_SIZE;
            cellThickness = CELL_THICKNESS;

            PaintCanvas(cellSize, cellThickness);

        }

        private void PaintCanvas(double cellSize, double cellThickness)
        {
            void AddArrow(Line line, bool isDirectionX)
            {
                Polygon arrow = new Polygon
                {
                    Stroke = Brushes.Black,
                    Fill = Brushes.Black
                };

                double arrowSize = ARROW_SIZE;

                if (isDirectionX) // Arrow pointing right for X-axis
                {
                    arrow.Points.Add(new Point(line.X2 - arrowSize, line.Y2 - arrowSize));
                    arrow.Points.Add(new Point(line.X2, line.Y2));
                    arrow.Points.Add(new Point(line.X2 - arrowSize, line.Y2 + arrowSize));

                    // Add label near the arrow
                    TextBlock label = new TextBlock
                    {
                        Text = "X",
                        Foreground = Brushes.Black
                    };

                    Canvas.SetLeft(label, line.X2 - arrowSize * 4);
                    Canvas.SetTop(label, line.Y2 - arrowSize * 4);
                    drawingCanvas.Children.Add(label);
                }
                else // Arrow pointing up for Y-axis
                {
                    arrow.Points.Add(new Point(line.X1 - arrowSize, line.Y1 + arrowSize));
                    arrow.Points.Add(new Point(line.X1, line.Y1));
                    arrow.Points.Add(new Point(line.X1 + arrowSize, line.Y1 + arrowSize));

                    // Add label near the arrow
                    TextBlock label = new TextBlock
                    {
                        Text = "Y",
                        Foreground = Brushes.Black
                    };

                    Canvas.SetLeft(label, line.X1 - arrowSize * 3);
                    Canvas.SetTop(label, line.Y1 + arrowSize);
                    drawingCanvas.Children.Add(label);
                }

                drawingCanvas.Children.Add(arrow);
            }

            if (labelTopLeft != null && labelTopRight != null
                && labelBottomLeft != null && labelBottomRight != null)
            {
                drawingCanvas.Children.Remove(labelTopLeft);
                drawingCanvas.Children.Remove(labelTopRight);
                drawingCanvas.Children.Remove(labelBottomLeft);
                drawingCanvas.Children.Remove(labelBottomRight);
            }

            drawingCanvas.Children.Clear();
            drawingCanvasBorder.UpdateLayout();
            drawingCanvas.UpdateLayout();

            numRows = (int)(drawingCanvas.ActualHeight / cellSize);
            numCols = (int)(drawingCanvas.ActualWidth / cellSize);

            X0 = numCols / 2 * cellSize;
            Y0 = numRows / 2 * cellSize;

            // Draw vertical lines
            for (int i = 0; i <= numCols; i++)
            {
                Line verticalLine = new Line
                {
                    X1 = i * cellSize,
                    Y1 = 0,
                    X2 = i * cellSize,
                    Y2 = drawingCanvas.ActualHeight,
                    Stroke = Brushes.CornflowerBlue,
                    StrokeThickness = cellThickness
                };

                drawingCanvas.Children.Add(verticalLine);

                if (i != numCols)
                {
                    // Add O point
                    TextBlock label = new TextBlock
                    {
                        Text = (i - numCols / 2).ToString(),
                        Foreground = Brushes.Black,
                        FontSize = cellSize / 2
                    };

                    Canvas.SetLeft(label, i * cellSize + ARROW_SIZE / 2);
                    Canvas.SetTop(label, Y0);
                    drawingCanvas.Children.Add(label);
                }
            }

            // Draw horizontal lines
            for (int i = 0; i <= numRows; i++)
            {
                Line horizontalLine = new Line
                {
                    X1 = 0,
                    Y1 = i * cellSize,
                    X2 = drawingCanvas.ActualWidth,
                    Y2 = i * cellSize,
                    Stroke = Brushes.CornflowerBlue,
                    StrokeThickness = cellThickness
                };

                drawingCanvas.Children.Add(horizontalLine);

                if (i != numRows / 2 && i != numRows)
                {
                    // Add O point
                    TextBlock label = new TextBlock
                    {
                        Text = (numRows / 2 - i).ToString(),
                        Foreground = Brushes.Black,
                        FontSize = cellSize / 2
                    };

                    Canvas.SetLeft(label, X0 + ARROW_SIZE / 2);
                    Canvas.SetTop(label, i * cellSize + ARROW_SIZE / 2);
                    drawingCanvas.Children.Add(label);
                }
            }

            // Draw XY coordinate system
            Line xAxis = new Line
            {
                X1 = 0,
                Y1 = Y0,
                X2 = drawingCanvas.ActualWidth,
                Y2 = Y0,
                Stroke = Brushes.Black,
                StrokeThickness = 2
            };

            Line yAxis = new Line
            {
                X1 = X0,
                Y1 = 0,
                X2 = X0,
                Y2 = drawingCanvas.ActualHeight,
                Stroke = Brushes.Black,
                StrokeThickness = 2
            };

            drawingCanvas.Children.Add(xAxis);
            drawingCanvas.Children.Add(yAxis);

            AddArrow(xAxis, true);
            AddArrow(yAxis, false);
        }

        private void PaintRectangle(double x1, double y1, double x2, double y2, double cellSize)
        {
            double canvasX1 = X0 + x1 * cellSize;
            double canvasY1 = Y0 - y1 * cellSize;
            double canvasX2 = X0 + x2 * cellSize;
            double canvasY2 = Y0 - y2 * cellSize;

            motionRectangle = new Rectangle
            {
                Stroke = Brushes.Red,
                StrokeThickness = CELL_THICKNESS * 4,
                Width = Math.Abs(canvasX2 - canvasX1),
                Height = Math.Abs(canvasY2 - canvasY1)
            };

            Canvas.SetLeft(motionRectangle, Math.Min(canvasX1, canvasX2));
            Canvas.SetTop(motionRectangle, Math.Min(canvasY1, canvasY2));

            drawingCanvas.Children.Add(motionRectangle);
        }

        private Matrix CreateRotationMatrixAroundPoint(double angleInDegrees, double centerX, double centerY)
        {
            angleInDegrees %= 360.0;

            // Translate the rectangle to the origin
            var translateToOrigin = CreateTranslationMatrix(-centerX, -centerY);

            //// Rotate the rectangle
            var rotateMatrix = CreateRotationMatrix(angleInDegrees);

            // Translate the rectangle back to its original position
            var translateBack = CreateTranslationMatrix(centerX, centerY);

            // Concatenate the matrices
            return translateToOrigin * rotateMatrix * translateBack;
        }

        private Matrix CreateTranslationMatrixByUpwardDirection(Rectangle rectangle, double offsetY)
        {
            var matrix = (rectangle.RenderTransform as MatrixTransform).Matrix;
            double angleRadians = Math.Atan2(matrix.M21, matrix.M11);
            double angleDegrees = angleRadians * (180.0 / Math.PI);

            var rectangleCenter = GetRectangleCenter(motionRectangle);

            var defaultDirectionUpVector = new Vector(0, 1);
            defaultDirectionUpVector = RotateVector(defaultDirectionUpVector, angleDegrees);


            return CreateRotationMatrixAroundPoint(angleDegrees, rectangleCenter.X, rectangleCenter.Y)
                * CreateTranslationMatrix(-offsetY * defaultDirectionUpVector.X, -offsetY * defaultDirectionUpVector.Y)
            * CreateRotationMatrixAroundPoint(-angleDegrees, rectangleCenter.X, rectangleCenter.Y);
        }

        private Matrix CreateTranslationMatrix(double offsetX, double offsetY)
        {
            return new Matrix { M11 = 1.0, M12 = 0.0, M21 = 0.0, M22 = 1.0, OffsetX = offsetX, OffsetY = offsetY };
        }

        private Matrix CreateRotationMatrix(double angleInDegrees)
        {
            double sin = Math.Sin(angleInDegrees * (Math.PI / 180.0));
            double cos = Math.Cos(angleInDegrees * (Math.PI / 180.0));
            return new Matrix { M11 = cos, M12 = sin, M21 = -sin, M22 = cos, OffsetX = 0, OffsetY = 0 };
        }

        private Matrix CreateScalingMatrix(double scaleX, double scaleY)
        {
            return new Matrix { M11 = scaleX, M12 = 0.0, M21 = 0.0, M22 = scaleY, OffsetX = 0.0, OffsetY = 0.0 };
        }

        private Vector RotateVector(Vector vector, double angleDegrees)
        {
            // Convert angle from degrees to radians
            double angleRadians = angleDegrees * (Math.PI / 180.0);

            // Perform the rotation using a 2D rotation matrix
            double newX = vector.X * Math.Cos(angleRadians) - vector.Y * Math.Sin(angleRadians);
            double newY = vector.X * Math.Sin(angleRadians) + vector.Y * Math.Cos(angleRadians);

            return new Vector(newX, newY);
        }

        private Point GetRectangleCenter(Rectangle rectangle)
        {
            if (rectangle == null)
                return new Point(0, 0);

            var transofrmedRectangleBounds = rectangle.RenderTransform.TransformBounds(new Rect(rectangle.RenderSize));

            Point center = new Point(transofrmedRectangleBounds.Left + transofrmedRectangleBounds.Width / 2,
                transofrmedRectangleBounds.Top + transofrmedRectangleBounds.Height / 2);

            return center;
        }

        private bool IsRectangleInsideCanvas(Rectangle rectangle, Canvas canvas)
        {

            Rect rectangleBounds = new Rect(0, 0, rectangle.ActualWidth, rectangle.ActualHeight);
            Rect transofrmedRectangleBounds = rectangle.RenderTransform.TransformBounds(rectangleBounds);

            double rectangleLeft = Canvas.GetLeft(rectangle) + transofrmedRectangleBounds.Left;
            double rectangleTop = Canvas.GetTop(rectangle) + transofrmedRectangleBounds.Top;
            double rectangleRight = rectangleLeft + rectangle.ActualWidth;
            double rectangleBottom = rectangleTop + rectangle.ActualHeight;

            return rectangleLeft >= 0
                && rectangleTop >= 0
                && rectangleRight <= canvas.ActualWidth
                && rectangleBottom <= canvas.ActualHeight;
        }

        private void DrawRectangleLabels(Rectangle rectangle, Canvas canvas)
        {
            try
            {
                TextBlock CreateLabelBlock(Point position)
                {
                    // Create a TextBlock for a vertex label
                    TextBlock label = new TextBlock
                    {
                        Text = "("
                        + (((position.X - numCols / 2 * cellSize) / cellSize)).ToString("F1")
                        + ", "
                        + ((numRows / 2 * cellSize - position.Y) / cellSize).ToString("F1")
                        + ")",
                        Foreground = Brushes.Black,
                        FontWeight = FontWeights.Bold
                    };

                    // Set the position of the label
                    Canvas.SetLeft(label, position.X);
                    Canvas.SetTop(label, position.Y);

                    return label;
                }

                if (labelTopLeft != null && labelTopRight != null
                    && labelBottomLeft != null && labelBottomRight != null)
                {
                    canvas.Children.Remove(labelTopLeft);
                    canvas.Children.Remove(labelTopRight);
                    canvas.Children.Remove(labelBottomLeft);
                    canvas.Children.Remove(labelBottomRight);
                }

                rectangle.UpdateLayout();

                Rect originalBounds = new Rect(0, 0, rectangle.RenderSize.Width, rectangle.RenderSize.Height);

                var transform = rectangle.TransformToAncestor(canvas);

                Point topLeft = transform.Transform(originalBounds.TopLeft);
                Point topRight = transform.Transform(originalBounds.TopRight);
                Point bottomLeft = transform.Transform(originalBounds.BottomLeft);
                Point bottomRight = transform.Transform(originalBounds.BottomRight);

                labelTopLeft = CreateLabelBlock(topLeft);
                labelTopRight = CreateLabelBlock(topRight);
                labelBottomLeft = CreateLabelBlock(bottomLeft);
                labelBottomRight = CreateLabelBlock(bottomRight);

                labelBottomLeft.Foreground = Brushes.DarkGoldenrod;
                labelTopRight.Foreground = Brushes.DarkMagenta;
                labelBottomLeft.Foreground = Brushes.DarkGreen;
                labelBottomRight.Foreground = Brushes.DarkKhaki;

                canvas.Children.Add(labelTopLeft);
                canvas.Children.Add(labelTopRight);
                canvas.Children.Add(labelBottomLeft);
                canvas.Children.Add(labelBottomRight);
            }
            catch (Exception ex)
            {

            }
        }

    }
}
