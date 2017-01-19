using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance
{
    public interface IGebruikerServices
    {
        List<Klant> ListKlanten();
        void AddKlant(Klant klant);
        void RemoveKlant(Klant klant);
        void EditKlant(Klant klant);
        Manager LoginManager(string naam, string wachtwoord);
        Klant KlantByNaam(string naam);
    }
}
