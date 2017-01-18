using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance
{
    public class Product
    {
        public int Productnr { get; set; }
        public Pizza Pizza { get; set; }
        public Artikel Artikel { get; set; }

        public Product(int nr, Pizza pizza)
        {
            Productnr = nr;
            Pizza = pizza;
        }

        public Product(int nr,Artikel artikel)
        {
            Productnr = nr;
            Artikel = artikel;
        }

        public Product(Pizza pizza)
        {
            Pizza = pizza;
        }

        public Product(Artikel artikel)
        {
            Artikel = artikel;
        }
    }
}
