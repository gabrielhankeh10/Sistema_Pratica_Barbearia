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
        public void Salvar(uCondicaoPagamento condicaoPagamento)
        {
            CondicaoPagamento = condicaoPagamento;
            DaoCondicaoPagamento.Salvar(CondicaoPagamento);
        }
    }
}
