using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema__Renovo_Barber.Formularios
{
    public partial class FrmConsultaCidades : Sistema__Renovo_Barber.FrmConsulta
    {
        public FrmConsultaCidades()
        {
            InitializeComponent();
        }
        public override void IncluirFormCadastro()
        {
            FrmCadastroCidades frmCadastroCidades = new FrmCadastroCidades();
            frmCadastroCidades.ShowDialog();
        }
    }
}
