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
        public decimal VerkoopprijsIngrediënten { get; set; }
        public decimal Verkoopprijs { get; set; }
        public string Bestelling { get; set; }
        public decimal Oppervlakte { get; set; }

        public Pizza(int pizzanr, string naam, Vorm vorm, string formaat, bool standaard, List<Ingrediënt> ingrediënten)
        {
            Pizzanr = pizzanr;
            Naam = naam;
            Vorm = vorm;
            Formaat = formaat;
            Standaard = standaard;
            Ingrediënten = ingrediënten;
            foreach (var item in ingrediënten)
            {
                VerkoopprijsIngrediënten += (item.Verkoopprijs / 100);
            }
            if (vorm == Vorm.Rond)
            {
                PizzaRondBerekening rondberekening = new PizzaRondBerekening();
                Oppervlakte = rondberekening.OppervlakteBerekening(formaat);             
            }
            else if (vorm == Vorm.Driehoek)
            {
                PizzaDriehoekBerekening driehoekberekening = new PizzaDriehoekBerekening();
                Oppervlakte = driehoekberekening.OppervlakteBerekening(formaat);
            }
            else if (vorm == Vorm.Rechthoek)
            {
                PizzaRechthoekBerekening rechthoekberekening = new PizzaRechthoekBerekening();
                Oppervlakte = rechthoekberekening.OppervlakteBerekening(formaat);
            }
            if (standaard == true)
            {
                Verkoopprijs = (Oppervlakte * VerkoopprijsIngrediënten) / 4 * 3;
            }
            else
            {
                Verkoopprijs = Oppervlakte * VerkoopprijsIngrediënten;
            }

            Bestelling = Naam + " - " + Verkoopprijs.ToString("#.##");
        }
        public Pizza(string naam, Vorm vorm, string formaat, bool standaard, List<Ingrediënt> ingrediënten)
        {
            Naam = naam;
            Vorm = vorm;
            Formaat = formaat;
            Standaard = standaard;
            Ingrediënten = ingrediënten;
            foreach (var item in ingrediënten)
            {
                VerkoopprijsIngrediënten += item.Verkoopprijs;
            }
        }

        public void AddBodem(string bodem)
        {
            if (bodem == "Deeg voor dunne bodem")
            {
                decimal bodemkosten = ((Oppervlakte / 100)/5*4);
                Verkoopprijs += bodemkosten;
            }
        }

        public override string ToString()
        {
            return $"Naam: {Naam}, Vorm: {Vorm}, Formaat: {Formaat}";
        }
    }
}
