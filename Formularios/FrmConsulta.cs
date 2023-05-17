using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema__Renovo_Barber
{
    public partial class FrmConsulta : Sistema__Renovo_Barber.Formularios.FrmPai
    {
        public FrmConsulta()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            IncluirFormCadastro();
        }

        public virtual void IncluirFormCadastro()
        {
            
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AlterarFormCadastro();    
        }
        public virtual void AlterarFormCadastro()
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirFormCadastro();
        }
        public virtual void ExcluirFormCadastro()
        {

        }
    }
}
