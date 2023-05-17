using Sistema__Renovo_Barber.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema__Renovo_Barber.Controllers
{
    class uCtrlCliente : uController
    {
        private uCliente Cliente = new uCliente();
        private uDaoCliente DaoCliente = new uDaoCliente();
        public uCtrlCliente()
        {

        }
        public void Salvar(uCliente cliente)
        {
            Cliente = cliente;
            DaoCliente.Salvar(cliente);
        }
    }
}
