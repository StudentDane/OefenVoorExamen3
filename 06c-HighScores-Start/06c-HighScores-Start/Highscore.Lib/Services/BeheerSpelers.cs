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

        public BeheerSpelers()
        {
            Spelers = new List<Speler>();
        }
    }
}
