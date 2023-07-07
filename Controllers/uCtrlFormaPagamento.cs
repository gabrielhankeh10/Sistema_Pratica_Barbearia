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
    class uCtrlFormaPagamento :uController
    {
        private uFormaPagamento FormaPagamento = new uFormaPagamento();
        private uDaoFormaPagamento DaoFormaPagamento = new uDaoFormaPagamento();
        public uCtrlFormaPagamento()
        {

        }
        public DataTable PopularGrid()
        {
            DataTable vData = new DataTable();
            vData = DaoFormaPagamento.PopularGrid();
            return vData;
        }
        public void Salvar(uFormaPagamento formaPagamento)
        {
            FormaPagamento = formaPagamento;
            DaoFormaPagamento.Salvar(FormaPagamento);
        }
        public uFormaPagamento Carregar(int Id)
        {
            uFormaPagamento Forma = DaoFormaPagamento.Selecionar(Id);
            return Forma;
        }
        public void Alterar(uFormaPagamento formaPagamento)
        {
            FormaPagamento = formaPagamento;
            DaoFormaPagamento.Alterar(FormaPagamento);
        }
        public void Excluir(uFormaPagamento formaPagamento)
        {
            FormaPagamento = formaPagamento;
            DaoFormaPagamento.Excluir(FormaPagamento);
        }
    }
}
