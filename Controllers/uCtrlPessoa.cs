using Sistema__Renovo_Barber.Classes;
using Sistema__Renovo_Barber.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema__Renovo_Barber.Controllers
{
    class uCtrlPessoa : uController
    {
        private uCliente Cliente = new uCliente();
        private readonly uDaoCliente DaoCliente = new uDaoCliente();
        public uCtrlPessoa()
        {

        }
        public uPessoa Carregar(int Id)
        {
            uCliente Cliente = DaoCliente.Selecionar(Id);
            return Cliente;
        }
    }
}
