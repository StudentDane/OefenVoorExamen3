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
    /// Test
    /// Test2
    
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

        void ToonNamen(string[] spelersLijst)
        {
            lstNamen.ItemsSource = spelersLijst;
        }

        int ZoekSpeler(string spelerNaam)
        {
            int indexSpeler = 0;

            /*
             De array met de spelers wordt overlopen tot de doorgegeven naam is gevonden.
             De index van de gevonden speler wordt geretourneerd.
             */

            return indexSpeler;
        }

        string ToonScore(string[] spelersLijst)
        {
            string scoreOverzicht = "";

            /*
             *  De als parameter doorgegeven array met de spelers wordt overlopen. 
                Bij elke spelersnaam wordt de bijhorende index gezocht.
                De naam en de score van de speler worden aan de lijst (variabele scoreOverzicht) toegevoegd.
                ScoreOverzicht wordt geretourneerd.

             */

            return scoreOverzicht;
        }

        /*
        string[] ToonSpelersMetScore(int score)
        {
            List<string> spelersMetScore = new List<string>();
            string[] spelers;

            
            //*** OPGAVE
                Maakt een list met de namen van de spelers met de als parameter doorgegeven highscore.
                De namen van de spelers worden doorlopen op basis van hun index.
                Bij elke naam wordt nagegaan of de score overeenkomt met de parameter. In dit geval wordt de naam toegevoegd aan de list.
                De list wordt omgezet naar een array en geretourneerd.
            //***
             

            return spelers;
        }*/

        string ToonRanking()
        {
            string rankingInfo = "";
            int[] ranking;
            List<string> rankingLijst = new List<string>();

            /*
             * Van de array met de highscores wordt een kopie gemaakt met de naam ranking.
                Ranking wordt gesorteerd en daarna wordt deze sortering omgekeerd.Op die manier staan de highscores van hoog naar laag gerangschikt.
                Bij elke score worden de spelers met die score opgeslagen in een array spelersMetScore via ToonSpelersMetScore.
                spelersMetScore wordt overlopen.Elke naam wordt toegevoegd aan een list rankingLijst.
                rankingLijst wordt, omgezet naar een array doorgegeven aan ToonScore om een overzicht van de scores te krijgen in een string variabele.
                De stringvariabele met het scoreoverzicht wordt geretourneerd.
             */

            return rankingInfo;
        }

        void GeefOverzicht()
        {
            string scoreInfo;
            string rankingInfo;
            string[] namenGesorteerd;

            //maak een kopie van spelersNamen (namenGesorteerd) en sorteer


            /*
            ToonNamen(namenGesorteerd);

            scoreInfo = ToonScore(namenGesorteerd);
            rankingInfo = ToonRanking();

            tbkScoreBord.Text = scoreInfo;
            tbkRanking.Text = rankingInfo;
            */
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
            /*
                De index van de geslecteerde speler wordt opgezocht in de array spelersNamen. 
                De gevonden index wordt opgeslagen in een variabele.
                Op basis van de index wordt de highscore van de speler opgehaald.
                De naam en de highscore worden in de textboxen getoond.
                De cursor wordt in txtHighScore geplaatst en de volledige inhoud van de textbox wordt geselecteerd.
                Als er geen item geselecteerd is, worden de textboxen leeggemaakt.
             */
        }

        private void btnOpslaan_Click(object sender, RoutedEventArgs e)
        {
            int highScore;

            /*
                De input van de textboxen wordt opgeslagen in een variabele.
                De waarden in de arrays worden aangepast.
                De overzichten in de textblocken worden opnieuw opgebouwd.
                De selectie in lstNamen wordt ongedaan gemaakt.

             */
        }
    }
}
