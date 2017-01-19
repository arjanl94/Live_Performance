using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance
{
    public class PizzaRechthoekBerekening : IPizzaBerekening
    {
        public decimal OppervlakteBerekening(string formaat)
        {
            string[] maten = formaat.Split('x');
            double maat1 = Convert.ToDouble(maten[0]);
            double maat2 = Convert.ToDouble(maten[1]);
            double oppervlakte = maat1 *maat2;

            return Convert.ToDecimal(oppervlakte);
        }
    }
}
