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
        public uCidade PesquisarNome(string cidade)
        {
            return DaoCidades.SelecionarNome(cidade);
        }
        public void Salvar(uCidade cidade)
        {
            Cidade = cidade;
            DaoCidades.Salvar(Cidade);
        }
        public void Excluir(uCidade cidade)
        {
            Cidade = cidade;
            DaoCidades.Excluir(Cidade);
        }
        public uCidade Carregar(int Id)
        {
            uCidade Cidade = DaoCidades.Selecionar(Id);
            return Cidade;
        }
        public void Alterar(uCidade cidade)
        {
            Cidade = cidade;
            DaoCidades.Alterar(Cidade);
        }

    }
}
