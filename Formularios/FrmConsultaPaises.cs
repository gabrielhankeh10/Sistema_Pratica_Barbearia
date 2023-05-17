using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema__Renovo_Barber
{
    public partial class FrmConsultaPaises : Sistema__Renovo_Barber.FrmConsulta
    {
        public FrmConsultaPaises()
        {
            InitializeComponent();
        }

        public override void IncluirFormCadastro()
        {
            FrmCadastroPaises frmCadastroPaises = new FrmCadastroPaises();
            frmCadastroPaises.ShowDialog();
        }
        public override void AlterarFormCadastro()
        {
            FrmCadastroPaises frmCadastroPaises = new FrmCadastroPaises();
            frmCadastroPaises.ShowDialog();
        }
        public override void ExcluirFormCadastro()
        {
            FrmCadastroPaises frmCadastroPaises = new FrmCadastroPaises();
            frmCadastroPaises.ShowDialog();
        }
    }
}
