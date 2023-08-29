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
    public class uCtrlCompras: uController
    {
        private uCompras Compras = new uCompras();
        private uDaoCompras DaoCompras = new uDaoCompras();
        public uCtrlCompras()
        {

        }
        public void Salvar(uCompras compras)
        {
            Compras = compras;
            DaoCompras.Salvar(Compras);
        }
        public DataTable PopularGrid()
        {
            DataTable vData = new DataTable();
            vData = DaoCompras.PopularGrid();
            return vData;
        }
    }
}
