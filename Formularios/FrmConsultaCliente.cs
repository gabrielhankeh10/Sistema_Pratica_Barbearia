using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema__Renovo_Barber.Formularios
{
    public partial class FrmConsultaCliente : Sistema__Renovo_Barber.FrmConsulta
    {
        public FrmConsultaCliente()
        {
            InitializeComponent();
        }
        public override void IncluirFormCadastro()
        {
            FrmCadastroCliente frmCadastroCliente = new FrmCadastroCliente();
            frmCadastroCliente.ShowDialog();
        }

    }
}
