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
    public partial class FrmCadastroCompra : Sistema__Renovo_Barber.Formularios.FrmPai
    {
        public FrmCadastroCompra()
        {
            InitializeComponent();
            tbDataCad.Text = Convert.ToString(DateTime.Now);
        }
        private uCtrlCompras ControllerCompras = new uCtrlCompras();
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnPesquisarFornecedor_Click(object sender, EventArgs e)
        {
            FrmConsultaFornecedor frmConsultaFornecedor = new FrmConsultaFornecedor();
            frmConsultaFornecedor.ShowDialog();
            uFornecedor Fornecedor = new uFornecedor();
            if (!frmConsultaFornecedor.ActiveControl.ContainsFocus)
            {
                Fornecedor = frmConsultaFornecedor.PegarObj();
                tbCodigoFornecedor.Text = Fornecedor.id.ToString();
                tbFornecedor.Text = Fornecedor.Nome.ToString();
            }
            frmConsultaFornecedor.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmConsultaCondicaoPagamento frmConsultaCondicaoPagamento = new FrmConsultaCondicaoPagamento();
            frmConsultaCondicaoPagamento.ShowDialog();
            uCondicaoPagamento CondicaoPagamento = new uCondicaoPagamento();
            if (!frmConsultaCondicaoPagamento.ActiveControl.ContainsFocus)
            {
                CondicaoPagamento = frmConsultaCondicaoPagamento.PegarObj();
                tbCodigoCondicao.Text = CondicaoPagamento.id.ToString();
                tbDescricaoCondicao.Text = CondicaoPagamento.Condicao.ToString();
            }
            frmConsultaCondicaoPagamento.Close();
        }

        private void btPesquisarProduto_Click(object sender, EventArgs e)
        {
            FrmConsultaProdutos frmConsultaProdutos = new FrmConsultaProdutos();
            frmConsultaProdutos.ShowDialog();
            uProdutos Produtos = new uProdutos();
            if (!frmConsultaProdutos.ActiveControl.ContainsFocus)
            {
                Produtos = frmConsultaProdutos.PegarObj();
                tbCodigoProduto.Text = Produtos.id.ToString();
                tbDescProduto.Text = Produtos.Descricao_produto.ToString();
            }
            frmConsultaProdutos.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            uCompras Obj = new uCompras();
            Obj.Fornecedor = new uFornecedor();
            Obj.CondicaoPagamento = new uCondicaoPagamento();
            Obj.Fornecedor.id = int.Parse(tbCodigoFornecedor.Text);
            Obj.CondicaoPagamento.id = int.Parse(tbCodigoCondicao.Text);
            Obj.Num_nfc = int.Parse(tbNumNota.Text);
            Obj.Modelo_nfc = int.Parse(tbModeloNota.Text);
            Obj.Serie_nfc = int.Parse(tbSerieNota.Text);
            Obj.Valor_frete = decimal.Parse(tbCustoFrete.Text);
            Obj.Valor_seguro = decimal.Parse(tbCustoSeguro.Text);
            Obj.Valor_outras_despesas = decimal.Parse(tbOutrosCustos.Text);
            Obj.Data_chegada = DateTime.Parse(tbDataChegada.Text);
            Obj.Data_emissao = DateTime.Parse(tbDataEmissao.Text);
            Obj.data_criacao = DateTime.Now;
            ControllerCompras.Salvar(Obj);
            this.Close();
        }
    }
}
