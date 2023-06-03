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
    class uCtrlFornecedor: uController
    {
        private uFornecedor Fornecedor = new uFornecedor();
        private uDaoFornecedor DaoFornecedor = new uDaoFornecedor();
        public uCtrlFornecedor()
        {

        }
        public DataTable PopularGrid()
        {
            DataTable vData = new DataTable();
            vData = DaoFornecedor.PopularGrid();
            return vData;
        }
        public void Salvar(uFornecedor fornecedor)
        {
            Fornecedor = fornecedor;
            DaoFornecedor.Salvar(fornecedor);
        }
    }
}
