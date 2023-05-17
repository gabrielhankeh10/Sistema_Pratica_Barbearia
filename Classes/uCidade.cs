using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema__Renovo_Barber.Classes
{
    public class uCidade : uPai
    {
        public uCidade()
        {
            uEstado Estado = new uEstado();
        }
        public uEstado Estado { get; set; }
        public string Cidade { get; set; }
        public string DDD { get; set; }
    }
}
