using Sistema__Renovo_Barber.Classes;
using Sistema__Renovo_Barber.Controllers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            tbPercentualTotal.Text = Convert.ToString(100);
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            uCondicaoPagamento Obj = new uCondicaoPagamento();
            if (btnSalvar.Text == "Salvar")
            {
                Obj.Condicao = tbCondicao.Text;
                Obj.Taxa = decimal.Parse(tbTaxa.Text);
                Obj.Multa = decimal.Parse(tbMulta.Text);
                Obj.Desconto = decimal.Parse(tbDesconto.Text);
                Obj.data_criacao = DateTime.Now;
                Obj.data_ult_alteracao = DateTime.Now;
                this.ControllerCondicao.Salvar(this.AdicionarGrid());
                // ControllerCondicao.Salvar(Obj);
                this.Close();
            }
            else if (btnSalvar.Text == "Alterar")
            {
                Obj.id = Convert.ToInt32(tbCodigo.Text);
                Obj.Condicao = tbCondicao.Text;
                Obj.Taxa = decimal.Parse(tbTaxa.Text);
                Obj.Multa = decimal.Parse(tbMulta.Text);
                Obj.Desconto = decimal.Parse(tbDesconto.Text);
                //Obj.Forma.id = int.Parse(tbIdForma.Text);
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
        public void Add()
        {
            int i = DgCondicao.Rows.Count + 1;
            AddDg(i);
            tbParcelas.Text = Convert.ToString(i + 1);
        }
        public void AddDg(int vLinha)
        {
            DgCondicao.Rows.Add(
                vLinha,
                tbDias.Text,
                tbIdForma.Text,
                tbDescForma.Text,
                tbPercentual.Text.ToString());
        }
        public void ListarParcelas()
        {
            DgCondicao.Rows.Clear();
            uCtrlParcelas Controller = new uCtrlParcelas();
            DataTable vData = Controller.PopularGrid();
            if (vData != null)
            {
                foreach (DataRow vLinha in vData.Rows)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(DgConsultaCondicaoPagamento);
                    row.Cells[0].Value = vLinha["id_condicao"].ToString();
                    row.Cells[1].Value = vLinha["condicao"].ToString();
                    row.Cells[2].Value = vLinha["parcelas"].ToString();
                    row.Cells[3].Value = vLinha["taxa"].ToString();
                    row.Cells[4].Value = vLinha["multa"].ToString();
                    row.Cells[5].Value = vLinha["desconto"].ToString();
                    row.Cells[6].Value = vLinha["data_criacao"].ToString();
                    row.Cells[7].Value = vLinha["data_ult_alteracao"].ToString();
                    DgConsultaCondicaoPagamento.Rows.Add(row);
                }
            }
        }
        public uCondicaoPagamento AdicionarGrid()
        {
            uCtrlFormaPagamento ControllerForma = new uCtrlFormaPagamento();
            var Obj = new uCondicaoPagamento();
            List<uParcelas> Lista = new List<uParcelas>();
            uParcelas Parcelas = null;
            Obj.Condicao = Convert.ToString(tbCondicao.Text);
            Obj.Multa = Convert.ToDecimal(tbMulta.Text);
            Obj.Taxa = Convert.ToDecimal(tbTaxa.Text);
            Obj.Desconto = Convert.ToDecimal(tbDesconto.Text);
            Obj.data_criacao = DateTime.Now;
            Obj.data_ult_alteracao = DateTime.Now;
            foreach (DataGridViewRow vLinha in DgCondicao.Rows)
            {
                Parcelas = new uParcelas();
                Parcelas.id = Obj.id;
                Parcelas.NumParcela = Convert.ToInt32(vLinha.Cells["num_parcela"].Value);
                Parcelas.DiasTotais = Convert.ToInt32(vLinha.Cells["dias_totais"].Value);
                Parcelas.Porcentagem = Convert.ToDouble(vLinha.Cells["percentual"].Value);
                Parcelas.FormaPagamento = new uFormaPagamento();
                Parcelas.FormaPagamento.id = Convert.ToInt32(vLinha.Cells["idForma"].Value);
                Parcelas.data_criacao = DateTime.Now;
                Parcelas.data_ult_alteracao = DateTime.Now;
                Lista.Add(Parcelas);
            }
            Obj.uParcelas = Lista;
            Obj.Parcelas = Obj.uParcelas.Count();
            return Obj;
        }
        public void Popular(uCondicaoPagamento CondicaoPagamento)
        {
            tbCodigo.Text = CondicaoPagamento.id.ToString();
            tbCondicao.Text = CondicaoPagamento.Condicao.ToString();
            //tbParcelas.Text = CondicaoPagamento.Parcelas.ToString();
            //tbDias.Text = CondicaoPagamento.Dias.ToString();
            tbTaxa.Text = CondicaoPagamento.Taxa.ToString();
            tbMulta.Text = CondicaoPagamento.Multa.ToString();
            tbDesconto.Text = CondicaoPagamento.Desconto.ToString();
            //tbIdForma.Text = CondicaoPagamento.Forma.id.ToString();
            //tbDescForma.Text = CondicaoPagamento.Forma.Forma.ToString();
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void tbPercentual_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Add();
        }
    }
}
