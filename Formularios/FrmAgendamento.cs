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
    public partial class FrmAgendamento : Sistema__Renovo_Barber.Formularios.FrmPai
    {
        uAgenda Agenda;
        public FrmAgendamento(uAgenda agenda)
        {
            Agenda = agenda;
            InitializeComponent();
            tbCodigoCliente.Text = agenda.Cliente != null? agenda.Cliente.id.ToString():"";
            tbCliente.Text = agenda.Cliente != null ? agenda.Cliente.Nome.ToString():"";
            tbIdFuncionario.Text = agenda.Funcionario.id.ToString();
            tbFuncionario.Text = agenda.Funcionario.Nome;
            tbIdServico.Text = agenda.Servicos != null ? agenda.Servicos.id.ToString() : "";
            tbNomeServico.Text = agenda.Servicos != null ? agenda.Servicos.Descricao.ToString() : "";
            dateTimePicker1.Text = agenda.Data.ToString();
            lbHorario.Text = agenda.Data.ToString("hh:mm");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmConsultaCliente frmConsultaCliente = new FrmConsultaCliente();
            frmConsultaCliente.ShowDialog();
            uCliente Cliente = new uCliente();
            if (!frmConsultaCliente.ActiveControl.ContainsFocus)
            {
                Cliente = frmConsultaCliente.PegarObj();
                tbCodigoCliente.Text = Cliente.id.ToString();
                Agenda.Cliente = Cliente;
                tbCliente.Text = Cliente.Nome.ToString();
            }
            frmConsultaCliente.Close();
            tbCodigoCliente.Enabled = false;
            tbCliente.Enabled = false;
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            uCtrlAgenda CtrlAgenda = new uCtrlAgenda();
            CtrlAgenda.Alterar(Agenda);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void btnPesquisaServico_Click(object sender, EventArgs e)
        {
            FrmConsultaServicos frmConsultaServicos = new FrmConsultaServicos();
            frmConsultaServicos.ShowDialog();
            uServicos Servicos = new uServicos();
            if (!frmConsultaServicos.ActiveControl.ContainsFocus)
            {
                Servicos = frmConsultaServicos.PegarObj();
                tbIdServico.Text = Servicos.id.ToString();
                tbNomeServico.Text = Servicos.Descricao.ToString();
                Agenda.Servicos = Servicos;
            }
            frmConsultaServicos.Close();
            tbIdServico.Enabled = false;
            tbNomeServico.Enabled = false;
        }

        private void FrmAgendamento_Load(object sender, EventArgs e)
        {

        }
    }
}
