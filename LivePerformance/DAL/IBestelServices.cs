using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance
{
    public interface IBestelServices
    {
        List<Bestelling> ListBestellingen();
        void AddBestelling(Bestelling bestelling);
    }
}
