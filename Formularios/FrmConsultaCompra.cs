using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema__Renovo_Barber.Formularios
{
    public partial class FrmConsultaCompra : Sistema__Renovo_Barber.Formularios.FrmPai
    {
        public FrmConsultaCompra()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            FrmCadastroCompra frmCadastroCompra = new FrmCadastroCompra();
            frmCadastroCompra.ShowDialog();
        }
    }
}
