using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema__Renovo_Barber.Formularios
{
    public partial class FrmConsultaCargos : Sistema__Renovo_Barber.FrmConsulta
    {
        public FrmConsultaCargos()
        {
            InitializeComponent();
        }
        public override void IncluirFormCadastro()
        {
            FrmCadastroCargos frmCadastroCargos = new FrmCadastroCargos();
            frmCadastroCargos.ShowDialog();
        }
    }
}
