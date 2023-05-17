using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema__Renovo_Barber.Classes
{
    public class uPessoa : uPai
    {
        public uPessoa()
        {
            uPai pai = new uPai();
        }
        public uPai pai { get; set; }
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public DateTime Data_nasc { get; set; }
    }
}
