using Sistema__Renovo_Barber.Classes;
using Sistema__Renovo_Barber.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema__Renovo_Barber.Controllers
{
    class uCtrlEstados : uController
    {
        private uEstado Estado = new uEstado();
        private uDaoEstados DaoEstados = new uDaoEstados();
        public uCtrlEstados()
        {

        }
        public void Salvar(uEstado estado)
        {
            Estado = estado;
            DaoEstados.Salvar(Estado);
        }
    }
}
