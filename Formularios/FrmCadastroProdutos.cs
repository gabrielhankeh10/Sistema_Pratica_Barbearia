using Sistema__Renovo_Barber.Classes;
using Sistema__Renovo_Barber.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema__Renovo_Barber.Formularios
{
    public partial class FrmCadastroProdutos : Sistema__Renovo_Barber.FrmCadastro
    {
        public FrmCadastroProdutos()
        {
            InitializeComponent();
        }
        private uCtrlProdutos ControllerProdutos = new uCtrlProdutos();

        public void Alterar_Botao()
        {
            btnSalvar.Text = "Alterar";
            tbQtdEstoque.Enabled = false;
            tbPrecoCusto.Enabled = false;
            tbPrecoVenda.Enabled = false;
        }
        public void Excluir_Botao()
        {
            btnSalvar.Text = "Excluir";
            tbDescricaoProduto.Enabled = false;
            tbMarcaProduto.Enabled = false;
            tbQtdEstoque.Enabled = false;
            tbPrecoCusto.Enabled = false;
            tbPrecoVenda.Enabled = false;
        }
        public void Popular (uProdutos Produtos)
        {
            tbCodigo.Text = Produtos.id.ToString();
            tbDescricaoProduto.Text = Produtos.Descricao_produto.ToString();
            tbMarcaProduto.Text = Produtos.Marca.ToString();
            tbQtdEstoque.Text = Produtos.Qtd_estoque.ToString();
            tbPrecoCusto.Text = Produtos.Preco_custo.ToString();
            tbPrecoVenda.Text = Produtos.Preco_venda.ToString();
            tbDatCad.Text = Produtos.data_criacao.ToShortDateString();
            tbDatUltAlt.Text = Produtos.data_ult_alteracao.ToShortDateString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            uProdutos Obj = new uProdutos();
            if (btnSalvar.Text == "Salvar")
            {
                Obj.Descricao_produto = tbDescricaoProduto.Text;
                Obj.Marca = tbMarcaProduto.Text;
                Obj.Preco_custo = decimal.Parse(tbPrecoCusto.Text);
                Obj.Preco_venda = decimal.Parse(tbPrecoVenda.Text);
                Obj.Qtd_estoque = 0;
                Obj.data_criacao = DateTime.Now;
                Obj.data_ult_alteracao = DateTime.Now;
                ControllerProdutos.Salvar(Obj);
                this.Close();
            }
            else if (btnSalvar.Text == "Alterar")
            {
                Obj.id = Convert.ToInt32(tbCodigo.Text);
                Obj.Descricao_produto = tbDescricaoProduto.Text;
                Obj.Marca = tbMarcaProduto.Text;
                Obj.Qtd_estoque = Convert.ToInt32(tbQtdEstoque.Text);
                Obj.Preco_custo = Convert.ToDecimal(tbPrecoCusto.Text);
                Obj.Preco_venda = Convert.ToDecimal(tbPrecoVenda.Text);
                Obj.data_criacao = DateTime.Now;
                Obj.data_ult_alteracao = DateTime.Now;
                ControllerProdutos.Alterar(Obj);
                this.Close();
            }
            else if (btnSalvar.Text == "Excluir")
            {
                Obj.id = Convert.ToInt32(tbCodigo.Text);
                ControllerProdutos.Excluir(Obj);
                this.Close();
            }

        }
        /*public uCidade PegarObj()
        {
            return ControllerProdutos.Carregar(Convert.ToInt32(DgConsultaCidades.SelectedRows[0].Cells["id_cidade"].Value));
        }*/
    }
}
