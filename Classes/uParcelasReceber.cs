using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema__Renovo_Barber.Classes
{
    public class uParcelasReceber
    {
        public uParcelasReceber()
        {

        }
        public int NumParcela { get; set; }
        public int IdReceber { get; set; }

        public DateTime DataVencimento { get; set; }
        public decimal Valor { get; set; }

    }
}
