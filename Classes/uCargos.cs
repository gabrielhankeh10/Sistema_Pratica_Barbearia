using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema__Renovo_Barber.Classes
{
    public class uCargos : uPai
    {
        public uCargos()
        {
            uPai Pai = new uPai();
        }
        public uPai Pai { get; set; }
        public string Cargo { get; set; }
        public string Status { get; set; }
    }
}
