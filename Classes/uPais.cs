using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema__Renovo_Barber.Classes
{
    public class uPais : uPai
    {
        public uPais()
        {
            uPai pai = new uPai();    
        }
        public uPai pai { get; set; }
        public string pais { get; set; }
        public string ddi { get; set; }
        public string sigla { get; set; }
    }
}
