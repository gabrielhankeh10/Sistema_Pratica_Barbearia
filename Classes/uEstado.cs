using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema__Renovo_Barber.Classes
{
    public class uEstado : uPai
    {
        public uEstado()
        {
            uPais pais = new uPais();
        }
        public uPais pais { get; set; }
        public string estado { get; set; }
        public string uf { get; set; }

    }
}
