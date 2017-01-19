using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance
{
    public class Ingrediënt:IProduct
    {
        public string Naam { get; set; }
        public decimal Inkoopprijs { get; set; }
        public decimal Verkoopprijs { get; set; }

        public Ingrediënt(string naam, decimal inkoopprijs, decimal verkoopprijs)
        {
            Naam = naam;
            Inkoopprijs = inkoopprijs;
            Verkoopprijs = verkoopprijs;
        }

        public override string ToString()
        {
            return $"Naam: {Naam}, Inkoopprijs: {Inkoopprijs}, Verkoopprijs: {Verkoopprijs}";
        }
    }
}
