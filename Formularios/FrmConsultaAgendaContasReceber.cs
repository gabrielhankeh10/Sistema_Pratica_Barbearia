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
    public partial class FrmConsultaAgendaContasReceber : Sistema__Renovo_Barber.Formularios.FrmPai
    {
        public FrmConsultaAgendaContasReceber(DateTime Data)
        {
            InitializeComponent();
            dateTimePicker1.Text = Data.ToString();
            Listar();
        }
        public void Listar()
        {
            DgConsultaAgenda.Rows.Clear();
            int? IdFuncionario = null;
            uCtrlAgenda Controller = new uCtrlAgenda();
            DataTable vData = Controller.PopularGridReceber(dateTimePicker1.Value);
            if (vData != null)
            {
                foreach (DataRow vLinha in vData.Rows)
                {
                    DgConsultaAgenda.Rows.Add(
                        vLinha["id_agenda"],
                        (DateTime)vLinha["data_agenda"],
                        ((DateTime)vLinha["data_agenda"]).ToString("hh:mm"),
                        vLinha["id_funcionario"],
                        vLinha["funcionario"],
                        vLinha["id_cliente"],
                        vLinha["cliente"]);
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Listar();
        }

        public void ObterServicos()
        {

        }

        public void AgendarCliente()
        {
            
            int IdAgenda = (int)DgConsultaAgenda.SelectedRows[0].Cells[0].Value;
            uCtrlAgenda CtrlAgenda = new uCtrlAgenda();
            uAgenda Agenda = new uAgenda();
            Agenda = CtrlAgenda.CarregarConsulta(IdAgenda);
            FrmAgendamento FrmAgendamento = new FrmAgendamento(Agenda);
            FrmAgendamento.ShowDialog();
            Listar();
        }

        private void DgConsultaCargos_KeyPress(object sender, KeyPressEventArgs e)
        {
            AgendarCliente();
        }

        private void DgConsultaCargos_DoubleClick(object sender, EventArgs e)
        {
            AgendarCliente();
        }

        private void DgConsultaAgenda_KeyDown(object sender, KeyEventArgs e)
        {
            AgendarCliente();
        }
    }
}
