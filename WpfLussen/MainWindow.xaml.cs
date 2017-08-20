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

namespace WpfLussen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        List<string[]> highScores = new List<string[]>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void lstSpelers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string speler = lstSpelers.SelectedItem.ToString();
            foreach (string[] highScore in highScores)
            {
                Console.WriteLine(highScore[0]);
                if (highScore[0]==speler)
                {
                    lblHighScore.Content = "De highscore van speler " + speler + " is " + highScore[1];
                    break;
                }
            }
        }

private void Window_Loaded(object sender, RoutedEventArgs e)
{
    string rootFolder;
    string[] score;
    rootFolder = System.AppDomain.CurrentDomain.BaseDirectory;
    string filename = rootFolder + "highscores.txt";
    StreamReader reader = new StreamReader(filename);
    string huidigeLijn = reader.ReadLine();
    while (huidigeLijn != null)
    {
        score = huidigeLijn.Split(';');
        if (score[1] == "0")
        {
            huidigeLijn = reader.ReadLine();
            continue;
        }
        lstSpelers.Items.Add(score[0]);
        highScores.Add(score);
        huidigeLijn = reader.ReadLine();
    }
}
    }
}
