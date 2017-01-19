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

        public void AddBestelling(int klantnr, int pizzanr, string artikelnm)
        {
            _bestelServices.AddBestelling(klantnr, pizzanr, artikelnm);
        }
    }
}
