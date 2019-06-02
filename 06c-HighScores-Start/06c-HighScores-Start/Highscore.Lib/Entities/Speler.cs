using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Highscore.Lib.Entities
{
    public class Speler
    {

        public string Naam { get; set; }
        public int Highscore { get; set; }

        public Speler(string naam, int highscore)
        {
            Naam = naam;
            Highscore = highscore;
        }


        public override string ToString()
        {
            string info;
            info = $"{Naam} - {Highscore}";
            return info;
        }

    }
}
