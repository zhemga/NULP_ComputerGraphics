using System;
using System.Collections.Generic;
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

namespace CGv5_App.Frames
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void NavigateToFractals_Button_Click(object sender, RoutedEventArgs e)
        {
            (App.Current.MainWindow as MainWindow).SetPage(new Fractals());
        }

        private void NavigateToColorModels_Button_Click(object sender, RoutedEventArgs e)
        {
            (App.Current.MainWindow as MainWindow).SetPage(new ColorModels());
        }

        private void NavigateToFigureMoving_Button_Click(object sender, RoutedEventArgs e)
        {
            (App.Current.MainWindow as MainWindow).SetPage(new FigureMoving());
        }

        private void NavigateToLabMaterials_Button_Click(object sender, RoutedEventArgs e)
        {
            (App.Current.MainWindow as MainWindow).SetPage(new LabMaterials());
        }
    }
}
