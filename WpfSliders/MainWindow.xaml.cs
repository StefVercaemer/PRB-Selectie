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

using System.Drawing;

namespace WpfSliders
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

        private void btnTestSliders_Click(object sender, RoutedEventArgs e)
        {
            int getal1 = (int)sldGetal1.Value;
            int getal2 = (int)sldGetal2.Value;
            string boodschap = "";
            if (getal1 == getal2) {
                boodschap = "eerste = tweede";
                lblBoodschap.Foreground = new SolidColorBrush(Colors.Green);
            }
            else if (getal1 < getal2) {
                boodschap = "eerste < tweede";
                lblBoodschap.Foreground = new SolidColorBrush(Colors.Red);
            }
            else {
                boodschap = "eerste > tweede";
                lblBoodschap.Foreground = new SolidColorBrush(Colors.DeepPink);
            }
            lblBoodschap.Content = boodschap;
                
        }
    }
}
