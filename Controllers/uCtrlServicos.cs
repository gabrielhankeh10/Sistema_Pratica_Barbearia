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
    class uCtrlServicos : uController
    {
        private uServicos Servicos = new uServicos();
        private uDaoServicos DaoServicos = new uDaoServicos();
        public uCtrlServicos()
        {

        }
        public DataTable PopularGrid()
        {
            DataTable vData = new DataTable();
            vData = DaoServicos.PopularGrid();
            return vData;
        }
        public void Salvar(uServicos servicos)
        {
            Servicos = servicos;
            DaoServicos.Salvar(Servicos);
        }
    }
}
