using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance
{
    public class ProductRepository
    {
        private IProductServices _productServices;

        public ProductRepository(IProductServices productServices)
        {
            _productServices = productServices;
        }

        public List<Product> ListProducten()
        {
            return _productServices.ListProducten();
        }

        public List<Pizza> ListPizzas()
        {
            return _productServices.ListPizzas();
        }

        public List<Artikel> ListArtikelen()
        {
            return _productServices.ListArtikelen();
        }

        public List<Ingrediënt> ListIngrediënten()
        {
            return _productServices.ListIngrediënten();
        }

        public void AddArtikel(Artikel artikel)
        {
            _productServices.AddArtikel(artikel);
        }

        public void EditArtikel(Artikel artikel)
        {
            _productServices.EditArtikel(artikel);
        }

        public void RemoveArtikel(Artikel artikel)
        {
            _productServices.RemoveArtikel(artikel);
        }

        public void AddPizza(Pizza pizza)
        {
            _productServices.AddPizza(pizza);
        }

        public void EditPizza(Pizza pizza)
        {
            _productServices.EditPizza(pizza);
        }

        public void RemovePizza(Pizza pizza)
        {
            _productServices.RemovePizza(pizza);
        }
    }
}
