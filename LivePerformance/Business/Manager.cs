using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LivePerformance
{
    public class Manager : Gebruiker
    {
        public string Wachtwoord { get; set; }

        public Manager(int nr, string naam, string wachtwoord) : base(nr, naam)
        {
            Gebruikernr = nr;
            Naam = naam;
            Wachtwoord = wachtwoord;
        }

        public Manager(string naam, string wachtwoord) : base(naam)
        {
            Naam = naam;
            Wachtwoord = wachtwoord;
        }
    }
}
