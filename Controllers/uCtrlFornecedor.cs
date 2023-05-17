using Sistema__Renovo_Barber.Classes;
using Sistema__Renovo_Barber.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema__Renovo_Barber.Controllers
{
    class uCtrlFornecedor: uController
    {
        private uFornecedor Fornecedor = new uFornecedor();
        private uDaoFornecedor DaoFornecedor = new uDaoFornecedor();
        public uCtrlFornecedor()
        {

        }
        public void Salvar(uFornecedor fornecedor)
        {
            Fornecedor = fornecedor;
            DaoFornecedor.Salvar(fornecedor);
        }
    }
}
