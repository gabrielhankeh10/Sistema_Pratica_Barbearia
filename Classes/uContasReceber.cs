using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema__Renovo_Barber.Classes
{
    public class uContasReceber
    {
        public uContasReceber()
        {
            uCondicaoPagamento CondicaoPagamento = new uCondicaoPagamento();
        }

        public int Id_receber { get; set; }
        public string Situacao { get; set; }
        public DateTime Data_criacao { get; set; }
        public uCondicaoPagamento CondicaoPagamento { get; set; }
        public List<uAgenda> Agendas { get; set; }
    }
}
