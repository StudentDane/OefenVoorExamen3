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

namespace LussenOnderbreken.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] spelersNamen = { "Ann", "Piet", "Axelle", "Marian" };
        int[] highScores = { 1100,505,2580,1080};
        string huidigeSpeler;
        int index;

        public MainWindow()
        {
            InitializeComponent();
        }

        void GeefOverzicht()
        {
            string scoreInfo;
            string rankingInfo;
            string[] namenGesorteerd;


        }

        void ToonNamen(string[] spelersLijst)
        {
            lstNamen.ItemsSource = spelersLijst;
        }

        string ToonScore(string[] spelersLijst)
        {
            string scoreOverzicht = "";
            foreach (string spelerNaam in spelersLijst)
            {
                int spelerIndex;
                string scoreInfo;
                spelerIndex = ZoekSpeler(spelerNaam);
                scoreInfo = spelersNamen[spelerIndex] + " - " + highScores[spelerIndex];
                scoreOverzicht += scoreInfo + "\n";
            }
            return scoreOverzicht;
        }

        string[] ToonSpelersMetScore(int score)
        {
            List<string> spelersMetScore = new List<string>();
            string[] spelers;
            for (int index = 0; index < spelersNamen.Length; index++)
            {
                if (highScores[index] == score)
                {
                    spelersMetScore.Add(spelersNamen[index]);
                }
            }
            spelers = spelersMetScore.ToArray();
            return spelers;
        }

        string ToonRanking()
        {
            string rankingInfo = "";
            int[] ranking;
            int vorigeScore = -1;
            List<string> rankingLijst = new List<string>();

            ranking = (int[])highScores.Clone();
            Array.Sort(ranking);
            Array.Reverse(ranking);

            foreach (int score in ranking)
            {
                if (vorigeScore != score)
                {
                    string[] spelersMetScore;
                    spelersMetScore = ToonSpelersMetScore(score);
                    foreach (string speler in spelersMetScore)
                    {
                        rankingLijst.Add(speler);
                    }
                }
                vorigeScore = score;
            }
            rankingInfo = ToonScore(rankingLijst.ToArray());
            return rankingInfo;
        }

        int ZoekSpeler(string spelerNaam)
        {
            int indexSpeler = 0;

            foreach (string naam in spelersNamen)
            {
                if (naam == spelerNaam)
                {
                    break;
                }
                indexSpeler++;
            }

            return indexSpeler;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string scoreInfo;

            ToonNamen(spelersNamen);
            scoreInfo = ToonScore(spelersNamen);

            tbkScoreBord.Text = scoreInfo;
        }

        private void btnSorteer_Click(object sender, RoutedEventArgs e)
        {
            GeefOverzicht();
        }

        private void lstNamen_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lstNamen.SelectedIndex >= 0)
            {
                int highScore;

                huidigeSpeler = lstNamen.SelectedItem.ToString();
                index = ZoekSpeler(huidigeSpeler);
                highScore = highScores[index];

                txtNaam.Text = huidigeSpeler;
                txtHighScore.Text = highScore.ToString();

                txtHighScore.Focus();
                txtHighScore.SelectAll();
            }
            else
            {
                txtNaam.Text = "";
                txtHighScore.Text = "";
            }
        }

        private void btnOpslaan_Click(object sender, RoutedEventArgs e)
        {
            int highScore;

            highScore = int.Parse(txtHighScore.Text);
            huidigeSpeler = txtNaam.Text;

            highScores[index] = highScore;
            spelersNamen[index] = huidigeSpeler;

            GeefOverzicht();

            lstNamen.SelectedIndex = -1;
        }
    }
}
