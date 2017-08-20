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

namespace WpfSelectie
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            weekdag();
        }

        private void btnTestBool_Click(object sender, RoutedEventArgs e)
        {
            bool benjeklaar = false;
            MessageBox.Show(benjeklaar.ToString(), "Ben je klaar?");
        }

        private void btnTestNot_Click(object sender, RoutedEventArgs e)
        {
            bool benjeklaar = false;
            benjeklaar = !benjeklaar;
            MessageBox.Show(benjeklaar.ToString(), "Ben je klaar?");
        }

        void isAvond()
        {
            int uur = 19;
            bool avond = (uur >= 18) && (uur <= 22);
            MessageBox.Show("Om " + uur + " uur: " + avond.ToString(), "Is het al avond?");
        }

        void isNacht()
        {
            int uur = 23;
            bool nacht = (uur > 22) || (uur < 6);
            MessageBox.Show("Om " + uur + " uur: " + nacht.ToString(), "Is het nacht?");
        }


        private void btnWeekDag_Click(object sender, RoutedEventArgs e)
        {
            string dagNaam;
            DateTime momenteel = DateTime.Now;
            DayOfWeek dag = momenteel.DayOfWeek;
            if (dag == DayOfWeek.Sunday)
                dagNaam = "zondag";
            else if (dag == DayOfWeek.Monday)
                dagNaam = "maandag";
            else if (dag == DayOfWeek.Tuesday)
                dagNaam = "dinsdag";
            else if (dag == DayOfWeek.Wednesday)
                dagNaam = "woensdag";
            else if (dag == DayOfWeek.Thursday)
                dagNaam = "donderdag";
            else if (dag == DayOfWeek.Friday)
                dagNaam = "vrijdag";
            else dagNaam = "zaterdag";
            MessageBox.Show("Vandaag is het " + dagNaam, "Dag van de week");
        }

        private void btnLeeftijd_Click(object sender, RoutedEventArgs e)
        {
            int leeftijd = 10;
            if (leeftijd >= 18) MessageBox.Show("Op de leeftijd van " + leeftijd + " ben je meerderjarig");
            else MessageBox.Show("Op de leeftijd van " + leeftijd + " ben je nog niet meerderjarig");
        }

        private void weekdag()
        {
string dagNaam;
DateTime momenteel = DateTime.Now;
DayOfWeek dag = momenteel.DayOfWeek;
switch(dag)
{
    case DayOfWeek.Sunday:
        dagNaam = "zondag";

    case DayOfWeek.Monday:
        dagNaam = "maandag";
        break;
    case DayOfWeek.Tuesday:
        dagNaam = "dinsdag";
        break;
    case DayOfWeek.Wednesday:
        dagNaam = "woensdag";
        break;
    case DayOfWeek.Thursday:
        dagNaam = "donderdag";
        break;
    case DayOfWeek.Friday:
        dagNaam = "vrijdag";
        break;
    default:
        dagNaam = "zaterdag";
        break;
}
MessageBox.Show("Vandaag is het " + dagNaam, "Dag van de week");
        }
    }
}
