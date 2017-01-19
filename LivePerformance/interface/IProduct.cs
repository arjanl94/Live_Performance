using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance
{
    public interface IProduct
    {
        string Naam { get; set; }
        decimal Inkoopprijs { get; set; }
        decimal Verkoopprijs { get; set; }
    }
}
