using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LivePerformance
{
    public class GebruikerRepository
    {
        private IGebruikerServices _gebruikerServices;

        GebruikerRepository(IGebruikerServices gebruikerServices)
        {
            _gebruikerServices = gebruikerServices;
        }

        public List<Klant> ListKlanten()
        {
            return _gebruikerServices.ListKlanten();
        }

        public void AddKlant(Klant klant)
        {
            _gebruikerServices.AddKlant(klant);
        }

        public void RemoveKlant(Klant klant)
        {
            _gebruikerServices.RemoveKlant(klant);
        }

        public void EditKlant(Klant klant)
        {
            _gebruikerServices.EditKlant(klant);
        }

        public Manager LoginManager(string naam, string wachtwoord)
        {
            return _gebruikerServices.LoginManager(naam, wachtwoord);
        }

        public Klant KlantById(int id)
        {
            return _gebruikerServices.KlantById(id);
        }
    }
}
