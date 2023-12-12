using CGv5_App.Frames;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CGv5_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void SetPage(Page page)
        {
            this.MainFrame.Navigate(page);
        }

        private void FileSave_MenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (MainFrame.Content is Fractals)
            {
                var fractalsPage = MainFrame.Content as Fractals;

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp";
                if (saveFileDialog.ShowDialog() == true)
                {
                    string savePath = saveFileDialog.FileName;
                    var imageToSave = fractalsPage.image.Source;

                    if (imageToSave is BitmapSource bitmapSource)
                    {
                        var encoder = new PngBitmapEncoder();
                        encoder.Frames.Add(BitmapFrame.Create(bitmapSource));

                        using (var stream = new FileStream(savePath, FileMode.Create))
                        {
                            encoder.Save(stream);
                        }

                        MessageBox.Show("Image saved successfully.");
                    }
                    else
                    {
                        MessageBox.Show("No image source to save.");
                    }
                }
            }
            else if (MainFrame.Content is ColorModels)
            {
                var colorModelsPage = MainFrame.Content as ColorModels;

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp";
                if (saveFileDialog.ShowDialog() == true)
                {
                    string savePath = saveFileDialog.FileName;
                    var imageToSave = colorModelsPage.HslImage.Source as BitmapSource;

                    if (imageToSave is BitmapSource bitmapSource)
                    {
                        var encoder = new PngBitmapEncoder();
                        encoder.Frames.Add(BitmapFrame.Create(bitmapSource));

                        using (var stream = new FileStream(savePath, FileMode.Create))
                        {
                            encoder.Save(stream);
                        }

                        MessageBox.Show("Image saved successfully.");
                    }
                    else
                    {
                        MessageBox.Show("No image source to save.");
                    }
                }
            }
        }

        private void FileOpen_MenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (MainFrame.Content is ColorModels)
            {
                var colorModelsPage = MainFrame.Content as ColorModels;

                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp";

                if (openFileDialog.ShowDialog() == true)
                {
                    try
                    {
                        string openPath = openFileDialog.FileName;
                        var rgbImage = new BitmapImage(new Uri(openPath));
                        var hslImage = new BitmapImage(new Uri(openPath));
                        var cmykImage = new BitmapImage(new Uri(openPath));
                        colorModelsPage.OldHslBitmap = hslImage;
                        colorModelsPage.RgbImage.Source = rgbImage;
                        colorModelsPage.HslImage.Source = hslImage;
                        colorModelsPage.CmykImage.Source = colorModelsPage.ImageToCmyk(new WriteableBitmap(cmykImage));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Can not open image!\nError: " + ex.Message);
                    }
                }
            }
        }
    }
}
