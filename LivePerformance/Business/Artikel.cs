using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance
{
    public class Artikel:IProduct, IComparable<Artikel>
    {
        public string Naam { get; set; }
        public decimal Inkoopprijs { get; set; }
        public decimal Verkoopprijs { get; set; }
        public int BtwPercentage { get; set; }
        public string Bestelling { get; set; }

        public Artikel(string naam, decimal inkoopprijs, decimal verkoopprijs, int btwpercentage)
        {
            Naam = naam;
            Inkoopprijs = inkoopprijs;
            Verkoopprijs = verkoopprijs;
            BtwPercentage = btwpercentage;
            Bestelling = Naam + " - " + "Prijs: " + Verkoopprijs;
        }

        public override string ToString()
        {
            return $"Naam: {Naam}, Inkoopprijs: {Inkoopprijs}, Verkoopprijs: {Verkoopprijs}, BTW: {BtwPercentage}";
        }

        public int CompareTo(Artikel other)
        {
            return this.Verkoopprijs.CompareTo(other.Verkoopprijs);
        }
    }
}
