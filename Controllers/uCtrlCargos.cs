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
        public void Excluir(uCargos cargos)
        {
            Cargos = cargos;
            DaoCargos.Excluir(Cargos);
        }
        public void Alterar(uCargos cargo)
        {
            Cargos = cargo;
            DaoCargos.Alterar(Cargos);
        }
        public uCargos Carregar(int Id)
        {
            uCargos Cargos = DaoCargos.Selecionar(Id);
            return Cargos;
        }
        public void Salvar(uCargos cargos)
        {
            Cargos = cargos;
            DaoCargos.Salvar(cargos);
        }
    }
}
