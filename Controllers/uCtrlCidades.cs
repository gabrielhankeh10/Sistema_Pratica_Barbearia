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
    class uCtrlCidades: uController
    {
        private uCidade Cidade = new uCidade();
        private uDaoCidades DaoCidades = new uDaoCidades();
        public uCtrlCidades()
        {

        }
        public DataTable PopularGrid()
        {
            DataTable vData = new DataTable();
            vData = DaoCidades.PopularGrid();
            return vData;
        }
        public void Salvar(uCidade cidade)
        {
            Cidade = cidade;
            DaoCidades.Salvar(Cidade);
        }
    }
}
