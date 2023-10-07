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
        private uCtrlProdutos ControllerProdutos = new uCtrlProdutos();
        private uCtrlComprasItens ControllerComprasItens = new uCtrlComprasItens();
   
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

        public void PercentualItem()
        {
            int Total = 0;
            foreach (DataGridViewRow vLinha in DgItensCompra.Rows)
            {
                Total += Convert.ToInt32(vLinha.Cells["qtd_entrada"].Value);
            }
            foreach (DataGridViewRow vLinha in DgItensCompra.Rows)
            {
                vLinha.Cells["percentual_compra"].Value = Math.Round(((Convert.ToDecimal(vLinha.Cells["qtd_entrada"].Value) / Total) * 100), 8);
            }
        }

        private void NovoPrecoItens()
        {
            decimal Frete = Convert.ToDecimal(tbCustoFrete.Text);
            decimal Seguro = Convert.ToDecimal(tbCustoSeguro.Text);
            decimal OutrosCustos = Convert.ToDecimal(tbOutrosCustos.Text);

            foreach (DataGridViewRow vLinha in DgItensCompra.Rows)
            {
                if (vLinha != null)
                {
                    var CustoProdutoAtual = Convert.ToDecimal(vLinha.Cells["custo_atual"].Value);
                    var QtdEstoqueAtual = Convert.ToInt32(vLinha.Cells["qtd_estoque"].Value);
                    var PercentualCompra = Convert.ToDecimal(vLinha.Cells["percentual_compra"].Value);
                    var CustoEntrada = Convert.ToDecimal(tbCusto.Text);
                    var QtdEntradaEstoque = Convert.ToInt32(vLinha.Cells["qtd_entrada"].Value);
                    var Desconto = Convert.ToDecimal(vLinha.Cells["desconto"].Value);
                    var RatFrete = (PercentualCompra / 100) * Frete;
                    var RatSeguro = (PercentualCompra / 100) * Seguro;
                    var RatOutrosCustos = (PercentualCompra / 100) * OutrosCustos;
                    var NovoCustoProduto = (RatFrete + RatSeguro + RatOutrosCustos + CustoEntrada) - Desconto;
                    var MediaPond = ((QtdEstoqueAtual * CustoProdutoAtual) + (QtdEntradaEstoque * NovoCustoProduto)) / (QtdEstoqueAtual + QtdEntradaEstoque);
                    vLinha.Cells["media_ponderada"].Value = Math.Round(MediaPond, 8);
                    vLinha.Cells["custo_sugerido"].Value = NovoCustoProduto;
                }
            }
        }

        public List<uItensCompra> ItensListView(int Num_nfc, int Modelo_nfc, int Serie_nfc, int Id_fornecedor)
        {
            var vLista = new List<uItensCompra>();
            foreach(DataGridViewRow vLinha in DgItensCompra.Rows)
            {
                uItensCompra ItensCompra = new uItensCompra();
                ItensCompra.Num_nfc = Num_nfc;
                ItensCompra.Modelo_nfc = Modelo_nfc;
                ItensCompra.Serie_nfc = Serie_nfc;
                ItensCompra.Id_fornecedor = Id_fornecedor;
                ItensCompra.Produtos = ControllerProdutos.Carregar(Convert.ToInt32(vLinha.Cells["id_produto"].Value));
                ItensCompra.Qtd = Convert.ToInt32(vLinha.Cells["qtd_entrada"].Value);
                ItensCompra.Preco_custo = Convert.ToDecimal(vLinha.Cells["custo_sugerido"].Value);
                ItensCompra.Desconto = Convert.ToDecimal(vLinha.Cells["desconto"].Value);
                ItensCompra.Percentual_compra = Convert.ToDecimal(vLinha.Cells["percentual_compra"].Value);
                ItensCompra.Media_ponderada = Convert.ToDecimal(vLinha.Cells["media_ponderada"].Value);
                ItensCompra.data_criacao = DateTime.Now;
                vLista.Add(ItensCompra);
            }
            return vLista;
        }
        public void AdicionarItens()
        {
            uProdutos Produtos = ControllerProdutos.Carregar(Convert.ToInt32(tbCodigoProduto.Text));
            var NomeProduto = tbDescProduto.Text;
            var IdProduto = tbCodigoProduto.Text;
            var CustoSugerido = tbCusto.Text;
            var Desconto = tbDesconto.Text;
            var QtdEntrada = tbQtd.Text;
            var QtdEstoque = Produtos.Qtd_estoque;
            var CustoAtual = Produtos.Preco_custo;
            var MediaPonderada = 0;
            var Percentual = 0;
            
            DgItensCompra.Rows.Add(
                IdProduto,
                NomeProduto,
                QtdEstoque,
                QtdEntrada,
                CustoAtual,
                CustoSugerido,
                Desconto,
                Percentual,
                MediaPonderada
                );
            PercentualItem();
            NovoPrecoItens();
        }

        private decimal CustoTotal()
        {
            decimal Total = 0;
            foreach(DataGridViewRow vLinha in DgItensCompra.Rows)
            {
                Total += Convert.ToDecimal(vLinha.Cells["qtd_entrada"].Value) * Convert.ToDecimal(vLinha.Cells["custo_sugerido"].Value);
            }
            return Total;
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
            Obj.Valor_total = CustoTotal();
            Obj.Valor_frete = decimal.Parse(tbCustoFrete.Text);
            Obj.Valor_seguro = decimal.Parse(tbCustoSeguro.Text);
            Obj.Valor_outras_despesas = decimal.Parse(tbOutrosCustos.Text);
            Obj.Data_chegada = DateTime.Parse(tbDataChegada.Text);
            Obj.Data_emissao = DateTime.Parse(tbDataEmissao.Text);
            Obj.data_criacao = DateTime.Now;
            Obj.ItensCompra = ItensListView(Obj.Num_nfc, Obj.Modelo_nfc, Obj.Serie_nfc, Obj.Fornecedor.id);
            ControllerCompras.Salvar(Obj);
            foreach (uItensCompra ItensCompra in Obj.ItensCompra)
            {
                ControllerProdutos.AtualizarEstoque(ItensCompra.Produtos.id, ItensCompra.Media_ponderada, ItensCompra.Qtd + ItensCompra.Produtos.Qtd_estoque);
                ControllerComprasItens.SalvarItens(ItensCompra);
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdicionarItens();
            tbTotalNota.Text = Convert.ToString(CustoTotal());
        }

        private void tbNumNota_Leave(object sender, EventArgs e)
        {
            
        }

        
    }
}
