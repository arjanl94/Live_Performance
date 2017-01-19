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
        public List<Pizza> Pizzas { get; set; }
        public List<Artikel> Artikelen { get; set; }
        public decimal Totaalprijs { get; set; }

        public Product()
        {
            Pizzas = new List<Pizza>();
            Artikelen = new List<Artikel>();
        }

        public void AddArtikel(Artikel artikel)
        {
            Artikelen.Add(artikel);
        }

        public void AddPizza(Pizza pizza)
        {
            Pizzas.Add(pizza);
        }

        public void TotalPrijs()
        {
            foreach (var item in Artikelen)
            {
                Totaalprijs += item.Verkoopprijs;
            }
            foreach (var item in Pizzas)
            {
                Totaalprijs += item.Verkoopprijs;
            }
        }
    }
}
