using Sistema__Renovo_Barber.Classes;
using Sistema__Renovo_Barber.Dao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema__Renovo_Barber.Controllers
{
    class uCtrlContasReceber : uController
    {
        private uContasReceber ContasReceber = new uContasReceber();
        private uDaoContasReceber DaoContasReceber = new uDaoContasReceber();
        public uCtrlContasReceber()
        {

        }
        public void Salvar(uContasReceber contasReceber)
        {
            ContasReceber = contasReceber;
            DaoContasReceber.Salvar(contasReceber);
        }
    }
}
