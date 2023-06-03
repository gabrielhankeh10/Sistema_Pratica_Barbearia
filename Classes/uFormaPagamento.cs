using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema__Renovo_Barber.Classes
{
    public class uFormaPagamento : uPai
    {
        public uFormaPagamento()
        {

        }
        public uPai Pai { get; set; }
        public string Forma { get; set; }
    }
}
