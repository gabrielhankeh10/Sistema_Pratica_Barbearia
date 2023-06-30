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
        public uServicos PesquisarNome(string servico)
        {
            return DaoServicos.SelecionarNome(servico);
        }
        public void Excluir(uServicos servicos)
        {
            Servicos = servicos;
            DaoServicos.Excluir(Servicos);
        }
        public void Alterar(uServicos servicos)
        {
            Servicos = servicos;
            DaoServicos.Alterar(Servicos);
        }
        public uServicos Carregar(int Id)
        {
            uServicos Servicos = DaoServicos.Selecionar(Id);
            return Servicos;
        }

        public void Salvar(uServicos servicos)
        {
            Servicos = servicos;
            DaoServicos.Salvar(Servicos);
        }
    }
}
