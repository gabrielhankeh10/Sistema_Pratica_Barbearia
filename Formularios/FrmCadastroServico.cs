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
    public partial class FrmCadastroServico : Sistema__Renovo_Barber.FrmCadastro
    {
        public FrmCadastroServico()
        {
            InitializeComponent();
        }
        private uCtrlServicos ControllerServicos = new uCtrlServicos();
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            uServicos Obj = new uServicos();
            Obj.Descricao = tbDescricao.Text;
            Obj.Duracao = TimeSpan.Parse(tbDuracao.Text);
            Obj.Valor = decimal.Parse(tbValor.Text);
            Obj.data_criacao = DateTime.Now;
            ControllerServicos.Salvar(Obj);
        }
    }
}
