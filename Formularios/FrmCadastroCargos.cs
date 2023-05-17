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
    public partial class FrmCadastroCargos : Sistema__Renovo_Barber.FrmCadastro
    {
        public FrmCadastroCargos()
        {
            InitializeComponent();
        }
        private uCtrlCargos ControllerCargos = new uCtrlCargos();
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            uCargos Obj = new uCargos();
            Obj.Cargo = tbCargo.Text;
            Obj.data_criacao = DateTime.Now;
            ControllerCargos.Salvar(Obj);
        }
    }
}
