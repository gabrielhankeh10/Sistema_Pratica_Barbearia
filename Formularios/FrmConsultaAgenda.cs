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
    public partial class FrmConsultaAgenda : Sistema__Renovo_Barber.Formularios.FrmPai
    {
        public FrmConsultaAgenda()
        {
            InitializeComponent();
            dateTimePicker1.Text = DateTime.Now.ToString();
            Listar();
        }
        public void Listar()
        {
            DgConsultaAgenda.Rows.Clear();
            int? IdFuncionario = null;
            if (!string.IsNullOrEmpty(tbIdFuncionario.Text))
                IdFuncionario = int.Parse(tbIdFuncionario.Text);
            uCtrlAgenda Controller = new uCtrlAgenda();
            DataTable vData = Controller.PopularGrid(dateTimePicker1.Value, IdFuncionario);
            if (vData != null)
            {
                foreach (DataRow vLinha in vData.Rows)
                {
                    DgConsultaAgenda.Rows.Add(
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

        public void AgendarCliente()
        {
            DateTime Data;
            int IdFuncionario;
            Data = (DateTime)DgConsultaAgenda.SelectedRows[0].Cells[0].Value;
            IdFuncionario = (int)DgConsultaAgenda.SelectedRows[0].Cells[2].Value;
            uCtrlAgenda CtrlAgenda = new uCtrlAgenda();
            uAgenda Agenda = new uAgenda();
            Agenda = CtrlAgenda.CarregarConsulta(Data, IdFuncionario);
            FrmAgendamento FrmAgendamento = new FrmAgendamento(Agenda);
            FrmAgendamento.ShowDialog();
        }

        private void DgConsultaCargos_KeyPress(object sender, KeyPressEventArgs e)
        {
            AgendarCliente();
        }

        private void DgConsultaCargos_DoubleClick(object sender, EventArgs e)
        {
            AgendarCliente();
        }
    }
}
