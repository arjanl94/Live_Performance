using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance
{
    public class Pizza
    {
        public int Pizzanr { get; set; }
        public string Naam { get; set; }
        public Vorm Vorm { get; set; }
        public string Formaat { get; set; }
        public bool Standaard { get; set; }
        public List<Ingrediënt> Ingrediënten { get; set; }

        public Pizza(int pizzanr, string naam, Vorm vorm, string formaat, bool standaard, List<Ingrediënt> ingrediënten)
        {
            Pizzanr = pizzanr;
            Naam = naam;
            Vorm = vorm;
            Formaat = formaat;
            Standaard = standaard;
            Ingrediënten = ingrediënten;
        }
        public Pizza(string naam, Vorm vorm, string formaat, bool standaard, List<Ingrediënt> ingrediënten)
        {
            Naam = naam;
            Vorm = vorm;
            Formaat = formaat;
            Standaard = standaard;
            Ingrediënten = ingrediënten;
        }
    }
}
