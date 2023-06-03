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
    class uCtrlCargos : uController
    {
        private uCargos Cargos = new uCargos();
        private uDaoCargos DaoCargos = new uDaoCargos();
        public DataTable PopularGrid()
        {
            DataTable vData = new DataTable();
            vData = DaoCargos.PopularGrid();
            return vData;
        }
        public uCtrlCargos()
        {

        }
        public void Salvar(uCargos cargos)
        {
            Cargos = cargos;
            DaoCargos.Salvar(cargos);
        }
    }
}
