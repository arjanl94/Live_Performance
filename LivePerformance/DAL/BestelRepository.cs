using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance
{
    public class BestelRepository
    {
        private IBestelServices _bestelServices;

        public BestelRepository(IBestelServices bestelServices)
        {
            _bestelServices = bestelServices;
        }

        public List<Bestelling> ListBestellingen()
        {
            return _bestelServices.ListBestellingen();
        }

        public void AddBestelling(Bestelling bestelling)
        {
            _bestelServices.AddBestelling(bestelling);
        }
    }
}
