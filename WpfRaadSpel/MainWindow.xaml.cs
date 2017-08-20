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

namespace WpfRaadSpel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            //string kleur = "oranje";
            //string actie;
            //if (kleur == "rood")
            //    actie = "stop";
            //else if (kleur == "groen")
            //    actie = "doorrijden";
            //else
            //    actie = "stop indien mogelijk";
        }

        int teRaden;
        int pogingen;
        Random rnd = new Random();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            teRaden = rnd.Next(1, 11);
            Console.WriteLine("Te raden: " + teRaden);
            pogingen = 0;
        }

        private void btnGok_Click(object sender, RoutedEventArgs e)
        {
            int gok = int.Parse(txtGok.Text);
            if (gok == teRaden)
            {
                pogingen++;
                lblGokjes.Content = "Je hebt het getal " + teRaden + " geraden na " + pogingen + " pogingen";
            }
            else
            {
                lblGokjes.Content += gok.ToString() + Environment.NewLine;
                txtGok.Text = "";
                txtGok.Focus();
                pogingen++;
            }
           
        }


    }
}
