using Sistema__Renovo_Barber.Classes;
using Sistema__Renovo_Barber.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema__Renovo_Barber.Controllers
{
    class uCtrlCidades: uController
    {
        private uCidade Cidade = new uCidade();
        private uDaoCidades DaoCidades = new uDaoCidades();
        public uCtrlCidades()
        {

        }
        public void Salvar(uCidade cidade)
        {
            Cidade = cidade;
            DaoCidades.Salvar(Cidade);
        }
    }
}
