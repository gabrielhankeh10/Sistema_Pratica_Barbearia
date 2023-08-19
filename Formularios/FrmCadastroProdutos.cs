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
        }
    }
}
