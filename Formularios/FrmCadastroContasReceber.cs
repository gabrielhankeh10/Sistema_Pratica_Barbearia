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
    public partial class FrmCadastroContasReceber : Sistema__Renovo_Barber.Formularios.FrmPai
    {
        uAgenda Agenda;
        uFormaPagamento FormaPagamento;
        uCondicaoPagamento CondicaoPagamento;
        List<uAgenda> ListaAgenda;
        List<uParcelasReceber> ListaParcelaReceber;
        public FrmCadastroContasReceber()
        {
            InitializeComponent();
            ListaAgenda = new List<uAgenda>();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            FrmConsultaAgendaContasReceber frmConsultaAgendaContasReceber = new FrmConsultaAgendaContasReceber(dateTimePicker1.Value, this);
            frmConsultaAgendaContasReceber.ShowDialog();
            tbIdServico.Enabled = false;
            tbNomeServico.Enabled = false;
            tbIdFuncionario.Enabled = false;
            tbFuncionario.Enabled = false;
            tbCliente.Enabled = false;
            tbCodigoCliente.Enabled = false;
            tbCodigoCondicao.Enabled = false;
            tbDescricaoCondicao.Enabled = false;
        }
        public void ReceberAgenda(uAgenda Obj)
        {
            tbCodigoCliente.Text = Obj.Cliente.id.ToString();
            tbCliente.Text = Obj.Cliente.Nome;
            tbIdFuncionario.Text = Obj.Funcionario.id.ToString();
            tbFuncionario.Text = Obj.Funcionario.Nome;
            tbIdServico.Text = Obj.Servicos.id.ToString();
            tbNomeServico.Text = Obj.Servicos.Descricao;
            CondicaoPagamento = Obj.Cliente.CondicaoPagamento;
            tbCodigoCondicao.Text = CondicaoPagamento.id.ToString();
            tbDescricaoCondicao.Text = CondicaoPagamento.Condicao.ToString();
            dgParcelasReceber.Rows.Clear();            
            Agenda = Obj;
        }

        public void ReceberCondicao(uFormaPagamento Obj)
        {
            tbCodigoCondicao.Text = Obj.id.ToString();
            tbDescricaoCondicao.Text = Obj.Forma;
            FormaPagamento = Obj;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (
            ListaAgenda.FindAll(a => a.id_agenda == Agenda.id_agenda).Count > 0)
            {
                MessageBox.Show("Servico ja adicionado! ");
            }
            else
            {
                DgConsultaReceber.Rows.Add(
                    Agenda.id_agenda,
                    Agenda.Cliente.id,
                    Agenda.Cliente.Nome,
                    Agenda.Funcionario.id,
                    Agenda.Funcionario.Nome,
                    Agenda.Servicos.id,
                    Agenda.Servicos.Descricao,
                    Agenda.Servicos.Valor
                    );
                decimal ValorTotal = decimal.Parse("0" + tbTotal.Text);
                ValorTotal += Agenda.Servicos.Valor;
                tbTotal.Text = ValorTotal.ToString();
                ListaAgenda.Add(Agenda);
                ListaParcelaReceber = new List<uParcelasReceber>();
                foreach (var Parc in CondicaoPagamento.uParcelas)
                {
                    ListaParcelaReceber.Add(new uParcelasReceber
                    {
                        DataVencimento = DateTime.Now.AddDays(Parc.DiasTotais),
                        NumParcela = Parc.NumParcela,
                        Valor = (Parc.Porcentagem / 100) * (double)ValorTotal
                    });
                    dgParcelasReceber.Rows.Add(Parc.NumParcela, (Parc.Porcentagem / 100) * (double)ValorTotal, DateTime.Now.AddDays(Parc.DiasTotais));
                }
            }
            btnPagamento.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmConsultaCondicaoPagamento frmConsultaCondicaoPagamento = new FrmConsultaCondicaoPagamento();
            frmConsultaCondicaoPagamento.ShowDialog();

            if (!frmConsultaCondicaoPagamento.ActiveControl.ContainsFocus)
            {
                CondicaoPagamento = frmConsultaCondicaoPagamento.PegarObj();
                tbCodigoCondicao.Text = CondicaoPagamento.id.ToString();
                tbDescricaoCondicao.Text = CondicaoPagamento.Condicao.ToString();
                dgParcelasReceber.Rows.Clear();
                var Total = Double.Parse("0"+tbTotal.Text);
                ListaParcelaReceber = new List<uParcelasReceber>();
                foreach (var Parc in CondicaoPagamento.uParcelas)
                {
                    ListaParcelaReceber.Add(new uParcelasReceber
                    {
                        DataVencimento = DateTime.Now.AddDays(Parc.DiasTotais),
                        NumParcela = Parc.NumParcela,
                        Valor = (Parc.Porcentagem / 100) * Total
                    });
                    dgParcelasReceber.Rows.Add(Parc.NumParcela,(Parc.Porcentagem / 100) * Total,DateTime.Now.AddDays(Parc.DiasTotais));
                }
            }
            frmConsultaCondicaoPagamento.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            uContasReceber ContasReceber = new uContasReceber();
            ContasReceber.Agendas = ListaAgenda;
            ContasReceber.Data_criacao = DateTime.Now;
            ContasReceber.FormaPagamento = new uFormaPagamento();
            ContasReceber.FormaPagamento.id = int.Parse(tbCodigoCondicao.Text);
            ContasReceber.Situacao = "Pago";
            ContasReceber.CondicaoPagamento = CondicaoPagamento;
            ContasReceber.ListaParcelaReceber = ListaParcelaReceber;
            uCtrlContasReceber CtrlReceber = new uCtrlContasReceber();
            CtrlReceber.Salvar(ContasReceber);
        }
    }
}
