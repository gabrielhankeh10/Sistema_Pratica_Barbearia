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
    public class uCtrlPaises : uController
    {
        private uPais Pais = new uPais();
        private uDaoPaises DaoPais = new uDaoPaises();
        public uCtrlPaises()
        {
            
        }
        public void Salvar(uPais pais)
        {
            Pais = pais;
            DaoPais.Salvar(Pais);
        }
        public DataTable PopularGrid()
        {
            DataTable vData = new DataTable();
            vData = DaoPais.PopularGrid();
            return vData;
        }
    }
}
