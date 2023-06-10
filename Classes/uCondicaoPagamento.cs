using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema__Renovo_Barber.Classes
{
    public class uCondicaoPagamento : uPai
    {
        public uCondicaoPagamento()
        {

        }
        public uPai Pai { get; set; }
        public string Condicao { get; set; }
        public int Parcelas { get; set; }
        public decimal Taxa { get; set; }
        public decimal Multa { get; set; }
        public decimal Desconto { get; set; }
    }
}
