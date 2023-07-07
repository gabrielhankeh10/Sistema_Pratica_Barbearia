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
    public partial class FrmCadastroCondicaoPagamento : Sistema__Renovo_Barber.FrmCadastro
    {
        uCtrlCondicaoPagamento ControllerCondicao = new uCtrlCondicaoPagamento();
        public FrmCadastroCondicaoPagamento()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            uCondicaoPagamento Obj = new uCondicaoPagamento();
            Obj.Forma = new uFormaPagamento();
            if (btnSalvar.Text == "Salvar")
            {
                Obj.Condicao = tbCondicao.Text;
                Obj.Parcelas = int.Parse(tbParcelas.Text);
                Obj.Dias = int.Parse(tbDias.Text);
                Obj.Taxa = decimal.Parse(tbTaxa.Text);
                Obj.Multa = decimal.Parse(tbMulta.Text);
                Obj.Desconto = decimal.Parse(tbDesconto.Text);
                Obj.Forma.id = int.Parse(tbIdForma.Text);
                Obj.data_criacao = DateTime.Now;
                Obj.data_ult_alteracao = DateTime.Now;
                ControllerCondicao.Salvar(Obj);
                this.Close();
            }
            else if (btnSalvar.Text == "Alterar")
            {
                Obj.id = Convert.ToInt32(tbCodigo.Text);
                Obj.Condicao = tbCondicao.Text;
                Obj.Parcelas = int.Parse(tbParcelas.Text);
                Obj.Dias = int.Parse(tbDias.Text);
                Obj.Taxa = decimal.Parse(tbTaxa.Text);
                Obj.Multa = decimal.Parse(tbMulta.Text);
                Obj.Desconto = decimal.Parse(tbDesconto.Text);
                Obj.Forma.id = int.Parse(tbIdForma.Text);
                Obj.data_ult_alteracao = DateTime.Now;
                ControllerCondicao.Alterar(Obj);
                this.Close();
            }
            else if (btnSalvar.Text == "Excluir")
            {
                Obj.id = Convert.ToInt32(tbCodigo.Text);
                ControllerCondicao.Excluir(Obj);
                this.Close();
            }
        }
        public void Alterar_Botao()
        {
            btnSalvar.Text = "Alterar";
            tbCodigo.Enabled = false;
            tbIdForma.Enabled = false;
            tbDescForma.Enabled = false;
            tbDatCad.Enabled = false;
            tbDatUltAlt.Enabled = false;
        }

        public void Excluir_Botao()
        {
            btnSalvar.Text = "Excluir";
            tbCodigo.Enabled = false;
            tbCondicao.Enabled = false;
            tbParcelas.Enabled = false;
            tbDias.Enabled = false;
            tbTaxa.Enabled = false;
            tbMulta.Enabled = false;
            tbIdForma.Enabled = false;
            tbDescForma.Enabled = false;
            tbDatCad.Enabled = false;
            tbDatUltAlt.Enabled = false;
            tbDesconto.Enabled = false;
        }

        public void Popular(uCondicaoPagamento CondicaoPagamento)
        {
            tbCodigo.Text = CondicaoPagamento.id.ToString();
            tbCondicao.Text = CondicaoPagamento.Condicao.ToString();
            tbParcelas.Text = CondicaoPagamento.Parcelas.ToString();
            tbDias.Text = CondicaoPagamento.Dias.ToString();
            tbTaxa.Text = CondicaoPagamento.Taxa.ToString();
            tbMulta.Text = CondicaoPagamento.Multa.ToString();
            tbDesconto.Text = CondicaoPagamento.Desconto.ToString();
            tbIdForma.Text = CondicaoPagamento.Forma.id.ToString();
            tbDescForma.Text = CondicaoPagamento.Forma.Forma.ToString();
            tbDatCad.Text = CondicaoPagamento.data_criacao.ToShortDateString();
            tbDatUltAlt.Text = CondicaoPagamento.data_ult_alteracao.ToShortDateString();
        }

        private void tbParcelas_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            {
                FrmConsultaFormaPagamento frmConsultaFormaPagamento = new FrmConsultaFormaPagamento();
                frmConsultaFormaPagamento.ShowDialog();
                uFormaPagamento FormaPagamento = new uFormaPagamento();
                if (!frmConsultaFormaPagamento.ActiveControl.ContainsFocus)
                {
                    FormaPagamento = frmConsultaFormaPagamento.PegarObj();
                    tbIdForma.Text = FormaPagamento.id.ToString();
                    tbDescForma.Text = FormaPagamento.Forma.ToString();
                }
                frmConsultaFormaPagamento.Close();
                tbIdForma.Enabled = false;
                tbDescForma.Enabled = false;
            }
        }
    }
}
