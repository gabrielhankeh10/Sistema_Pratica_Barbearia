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
    public partial class FrmCadastroEstado : Sistema__Renovo_Barber.FrmCadastro
    {
        public FrmCadastroEstado()
        {
            InitializeComponent();
        }
        private uCtrlEstados ControllerEstados = new uCtrlEstados();
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            uEstado Obj = new uEstado();
            Obj.pais = new uPais();
            Obj.pais.id = int.Parse(tbCodigoPais.Text);
            Obj.estado = tbEstado.Text;
            Obj.uf = tbUf.Text;
            Obj.data_criacao = DateTime.Now;
            Obj.data_ult_alteracao = DateTime.Now;
            ControllerEstados.Salvar(Obj);
        }
    }
}
