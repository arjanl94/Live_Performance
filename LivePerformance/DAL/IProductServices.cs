using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance
{
    public interface IProductServices
    {
        List<Product> ListProducten();
        List<Pizza> ListPizzas();
        List<Artikel> ListArtikelen();
        List<Ingrediënt> ListIngrediënten();
        void AddArtikel(Artikel artikel);
        void EditArtikel(Artikel artikel);
        void RemoveArtikel(Artikel artikel);
        void AddPizza(Pizza pizza);
        void EditPizza(Pizza pizza);
        void RemovePizza(Pizza pizza);
    }
}
