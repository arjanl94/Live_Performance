using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance
{
    public class PizzaDriehoekBerekening : IPizzaBerekening
    {
        public decimal OppervlakteBerekening(string formaat)
        {
            string[] maten = formaat.Split('x');
            double maat1 = Convert.ToDouble(maten[0]);
            double maat2 = Convert.ToDouble(maten[1]);
            double maat3 = Convert.ToDouble(maten[2]);
            double oppervlakte = (maat1 + maat2 + maat3)/2;
            double getal = Math.Sqrt(oppervlakte*(oppervlakte - maat1)*(oppervlakte - maat2)*(oppervlakte - maat3));

            return Convert.ToDecimal(getal);
        }
    }
}
