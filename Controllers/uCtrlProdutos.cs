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
    class uCtrlProdutos : uController
    {
        private uProdutos Produtos = new uProdutos();
        private uDaoProdutos DaoProdutos = new uDaoProdutos();
        public DataTable PopularGrid()
        {
            DataTable vData = new DataTable();
            vData = DaoProdutos.PopularGrid();
            return vData;
        }
        public void Salvar(uProdutos produtos)
        {
            Produtos = produtos;
            DaoProdutos.Salvar(Produtos);
        }
        public void Alterar(uProdutos produtos)
        {
            Produtos = produtos;
            DaoProdutos.Alterar(Produtos);
        }
        public void AtualizarEstoque(int Id, decimal Custo, int Qtd)
        {
            DaoProdutos.AtualizarEstoque(Id, Custo, Qtd);
        }
        public uProdutos Carregar(int Id)
        {
            uProdutos Produtos = DaoProdutos.Selecionar(Id);
            return Produtos;
        }
        public void Excluir(uProdutos produtos)
        {
            Produtos = produtos;
            DaoProdutos.Excluir(Produtos);
        }
    }
}
