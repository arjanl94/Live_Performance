using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance
{
    public class Bestelling
    {
        public int Bestelnr { get; set; }
        public Klant Klant { get; set; }
        public List<Product> Producten { get; set; }

        public Bestelling(int bestelnr, Klant klant, List<Product> producten)
        {
            Bestelnr = bestelnr;
            Klant = klant;
            Producten = producten;
        }

        public void AddProduct(Product product)
        {
            this.Producten.Add(product);
        }
    }
}
