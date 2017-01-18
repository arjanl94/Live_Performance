using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance
{
    public class Artikel
    {
        public string Naam { get; set; }
        public decimal Inkoopprijs { get; set; }
        public decimal Verkoopprijs { get; set; }
        public int BtwPercentage { get; set; }

        public Artikel(string naam, decimal inkoopprijs, decimal verkoopprijs, int btwpercentage)
        {
            Naam = naam;
            Inkoopprijs = inkoopprijs;
            Verkoopprijs = verkoopprijs;
            BtwPercentage = btwpercentage;
        }
    }
}
