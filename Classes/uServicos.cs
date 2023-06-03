using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema__Renovo_Barber.Classes
{
    public class uServicos :uPai
    {
        public uServicos()
        {
            
        }
        public uPai Pai { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }
        public TimeSpan Duracao { get; set; }
        public decimal Valor { get; set; }

    }
}
