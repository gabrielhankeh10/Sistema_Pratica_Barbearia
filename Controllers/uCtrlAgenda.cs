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
    class uCtrlAgenda
    {
        private uDaoAgenda DaoAgenda = new uDaoAgenda();

        /*public uCtrlAgenda()
        {

        }
        public void Excluir(uCargos cargos)
        {
            Cargos = cargos;
            DaoCargos.Excluir(Cargos);
        }*/

        public uAgenda CarregarConsulta(int IdAgenda)
        {
            return DaoAgenda.Selecionar(IdAgenda);
        }
        public DataTable Verificar_datas(int Ano, int Mes, int IdFuncionario)
        {
            return DaoAgenda.Verificar_datas(Ano, Mes, IdFuncionario);
        }


        public void Alterar(uAgenda agenda)
        {
            DaoAgenda.Alterar(agenda);
        }
        public DataTable PopularGrid(DateTime Data, int? IdFuncionario)
        {
            DataTable vData = new DataTable();
            vData = DaoAgenda.PopularGrid(Data, IdFuncionario);
            return vData;
        }
        public DataTable PopularGridReceber(DateTime Data)
        {
            DataTable vData = new DataTable();
            vData = DaoAgenda.PopularGridReceber(Data);
            return vData;
        }

        public void Salvar(uAgenda agenda)
        {
            DaoAgenda.Salvar(agenda);
        }
    }
}
