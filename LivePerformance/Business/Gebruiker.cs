using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance
{
    public abstract class Gebruiker
    {
        public int Gebruikernr { get; set; }
        public string Naam { get; set; }

        public Gebruiker(int nr, string naam)
        {
            Gebruikernr = nr;
            Naam = naam;
        }

        public Gebruiker(string naam)
        {
            Naam = naam;
        }
    }
}
