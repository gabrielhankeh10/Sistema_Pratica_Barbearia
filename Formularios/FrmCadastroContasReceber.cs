using Sistema__Renovo_Barber.Classes;
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
        uCondicaoPagamento CondicaoPagamento;
        List<uAgenda> ListaAgenda;
        public FrmCadastroContasReceber()
        {
            InitializeComponent();
            ListaAgenda = new List<uAgenda>();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            FrmConsultaAgendaContasReceber frmConsultaAgendaContasReceber = new FrmConsultaAgendaContasReceber(dateTimePicker1.Value, this);
            frmConsultaAgendaContasReceber.ShowDialog();
        }
        public void ReceberAgenda(uAgenda Obj)
        {
            tbCodigoCliente.Text = Obj.Cliente.id.ToString();
            tbCliente.Text = Obj.Cliente.Nome;
            tbIdFuncionario.Text = Obj.Funcionario.id.ToString();
            tbFuncionario.Text = Obj.Funcionario.Nome;
            tbIdServico.Text = Obj.Servicos.id.ToString();
            tbNomeServico.Text = Obj.Servicos.Descricao;
            Agenda = Obj;
        }

        public void ReceberCondicao(uCondicaoPagamento Obj)
        {
            tbCodigoCondicao.Text = Obj.id.ToString();
            tbDescricaoPagamento.Text = Obj.Condicao;
            CondicaoPagamento = Obj;
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
            }
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
        }
    }
}
