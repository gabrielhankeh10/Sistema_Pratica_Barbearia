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
    class uCtrlCondicaoPagamento :uController
    {
        private uCondicaoPagamento CondicaoPagamento = new uCondicaoPagamento();
        private uDaoCondicaoPagamento DaoCondicaoPagamento = new uDaoCondicaoPagamento();
        public uCtrlCondicaoPagamento()
        {

        }
        public DataTable PopularGrid()
        {
            DataTable vData = new DataTable();
            vData = DaoCondicaoPagamento.PopularGrid();
            return vData;
        }
        public uCondicaoPagamento Carregar(int Id)
        {
            uCondicaoPagamento CondicaoPagamento = DaoCondicaoPagamento.Selecionar(Id);
            return CondicaoPagamento;
        }
        public void Alterar(uCondicaoPagamento condicaoPagamento)
        {
            CondicaoPagamento = condicaoPagamento;
            DaoCondicaoPagamento.Alterar(CondicaoPagamento);
        }
        public void Excluir(uCondicaoPagamento condicaoPagamento)
        {
            CondicaoPagamento = condicaoPagamento;
            DaoCondicaoPagamento.Excluir(CondicaoPagamento);
        }
        public void Salvar(uCondicaoPagamento condicaoPagamento)
        {
            CondicaoPagamento = condicaoPagamento;
            DaoCondicaoPagamento.Salvar(CondicaoPagamento);
        }
    }
}
