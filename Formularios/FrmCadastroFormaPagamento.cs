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
    public partial class FrmCadastroFormaPagamento : Sistema__Renovo_Barber.FrmCadastro
    {
        uCtrlFormaPagamento ControllerForma = new uCtrlFormaPagamento();
        public FrmCadastroFormaPagamento()
        {
            InitializeComponent();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            uFormaPagamento Obj = new uFormaPagamento();
            Obj.Forma = tbForma.Text;
            Obj.data_criacao = DateTime.Now;
            ControllerForma.Salvar(Obj);
        }    
    }
}
