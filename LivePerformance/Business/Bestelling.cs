using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivePerformance
{
    public class Bestelling
    {
        public int Bestelnr { get; set; }
        public Klant Klant { get; set; }
        public Product Producten { get; set; }
        public bool Bezorg { get; set; }

        public Bestelling(int bestelnr, Klant klant, Product product)
        {
            Bestelnr = bestelnr;
            Klant = klant;
            Producten = product;
        }
        public Bestelling(Klant klant, Product product)
        {
            Klant = klant;
            Producten = product;
        }
        public Bestelling(Product product)
        {
            Producten = product;
        }

        public void AddProduct(Product product)
        {
            this.Producten = product;
        }

        public void ExporteerBestelling(SaveFileDialog save)
        {
            using (StreamWriter writer = new StreamWriter(save.OpenFile()))
            {
                writer.WriteLine("Pizzeria La Crosta Insapore");
                writer.WriteLine("Klantbon voor: " + Klant.Naam);
                writer.WriteLine("");
                foreach (var item in Producten.Pizzas)
                {
                    writer.WriteLine(item.Naam + ": " + item.Verkoopprijs.ToString("#.##"));
                }
                foreach (var item in Producten.Artikelen)
                {
                    writer.WriteLine(item.Naam + ": " + item.Verkoopprijs.ToString("#.##"));
                }
                writer.WriteLine("");
                Producten.TotalPrijs();
                double totaalprijs = Convert.ToDouble(Producten.Totaalprijs.ToString("#.##"));
                double totaalminbtw = totaalprijs/1.06;
                writer.WriteLine("Prijs exclusief BTW: " + totaalminbtw.ToString("#.##"));
                writer.WriteLine("BTW bedrag: " + (totaalprijs - totaalminbtw).ToString("#.##"));
                writer.WriteLine("Te betalen bedrag: " + totaalprijs.ToString("#.##"));
                writer.WriteLine();
            }
        }
        public void Bezorging(bool bezorg)
        {
            Bezorg = bezorg;
        }
    }
}
