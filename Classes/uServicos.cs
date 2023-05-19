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
            uPai Pai = new uPai();
        }
        public uPai Pai { get; set; }

    }
}
