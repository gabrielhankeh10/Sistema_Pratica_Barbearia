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
        
        public FrmCadastroContasReceber()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            FrmConsultaAgendaContasReceber frmConsultaAgendaContasReceber = new FrmConsultaAgendaContasReceber(dateTimePicker1.Value);
            frmConsultaAgendaContasReceber.ShowDialog();
        }
        /*public void ReceberAgenda(uAgenda)
        {

        }*/
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
