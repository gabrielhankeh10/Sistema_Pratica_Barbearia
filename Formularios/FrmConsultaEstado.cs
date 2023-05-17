using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema__Renovo_Barber.Formularios
{
    public partial class FrmConsultaEstado : Sistema__Renovo_Barber.FrmConsulta
    {
        public FrmConsultaEstado()
        {
            InitializeComponent();
        }
        public override void IncluirFormCadastro()
        {
            FrmCadastroEstado frmCadastroEstado = new FrmCadastroEstado();
            frmCadastroEstado.ShowDialog();
        }
    }
}
