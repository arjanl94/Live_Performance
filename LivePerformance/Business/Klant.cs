using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance
{
    public class Klant : Gebruiker
    {
        public string Adres { get; set; }

        public Klant(int nr, string naam, string adres) : base(nr, naam)
        {
            Gebruikernr = nr;
            Naam = naam;
            Adres = adres;
        }

        public Klant(string naam, string adres) : base(naam)
        {
            Naam = naam;
            Adres = adres;
        }

        public override string ToString()
        {
            return $"{Naam}, Adres: {Adres}";
        }
    }
}
