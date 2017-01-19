using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance
{
    public class PizzaRondBerekening : IPizzaBerekening
    {
        public decimal OppervlakteBerekening(string formaat)
        {
            double PI = Math.PI;
            double formaatgetal = Convert.ToDouble(formaat);
            double Formaat = Math.Pow(formaatgetal, 2);
            double getal = 0.25 * PI * Formaat;
            return Convert.ToDecimal(getal);
        }
    }
}
