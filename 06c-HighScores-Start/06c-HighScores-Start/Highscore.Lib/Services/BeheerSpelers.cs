using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Highscore.Lib.Entities;

namespace Highscore.Lib.Services
{
    public class BeheerSpelers
    {
        public List<Speler> Spelers { get; set; }
        private int highestScoreEver { get; set; }

        public BeheerSpelers()
        {
            Spelers = new List<Speler>();
            MaakSpelers();
        }

        public void MaakSpelers()
        {
            Speler speler;

            speler = new Speler("Dane");
            Spelers.Add(speler);

            speler = new Speler("Kyle");
            Spelers.Add(speler);

            speler = new Speler("Tom");
            Spelers.Add(speler);

            speler = new Speler("Slava");
            Spelers.Add(speler);
        }

        public void VoegSpelerToe(string naam, int highscore) {
            Speler speler = new Speler(naam, highscore);
            Spelers.Add(speler);
        }

        public int GetHighestScore()
        {
            int highestScore = 0;
            foreach (Speler speler in Spelers)
            {
                if (speler.Highscore > highestScore) highestScore = speler.Highscore;
            }
            if (highestScore > highestScoreEver) highestScoreEver = highestScore;
            return highestScore;
        }

        public int HighestScoreEver()
        {
            return highestScoreEver;
        }
    }
}
