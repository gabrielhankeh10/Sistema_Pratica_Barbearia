using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema__Renovo_Barber.Classes
{
    public class uParcelas : uPai
    {
        public uParcelas()
        {
            uFormaPagamento FormaPagamento = new uFormaPagamento();
        }
        public int NumParcela { get; set; }
        public int DiasTotais { get; set; }
        public Double Porcentagem { get; set; }
        public uFormaPagamento FormaPagamento { get; set; }
    }
}
