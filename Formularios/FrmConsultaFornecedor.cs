using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema__Renovo_Barber.Formularios
{
    public partial class FrmConsultaFornecedor : Sistema__Renovo_Barber.FrmConsulta
    {
        public FrmConsultaFornecedor()
        {
            InitializeComponent();
        }

        private void DgConsultaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public override void IncluirFormCadastro()
        {
            FrmCadastroFornecedor frmCadastroFornecedor = new FrmCadastroFornecedor();
            frmCadastroFornecedor.ShowDialog();
        }
        private void btnIncluir_Click(object sender, EventArgs e)
        {

        }
    }
}
