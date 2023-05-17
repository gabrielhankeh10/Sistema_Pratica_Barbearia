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
    public partial class FrmCadastroCidades : Sistema__Renovo_Barber.FrmCadastro
    {
        public FrmCadastroCidades()
        {
            InitializeComponent();
        }
        private uCtrlCidades ControllerCidades = new uCtrlCidades();
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            uCidade Obj = new uCidade();
            Obj.Estado = new uEstado();
            Obj.Estado.id = int.Parse(tbCodEstado.Text);
            Obj.Cidade = tbCidade.Text;
            Obj.DDD = tbDDD.Text;
            Obj.data_criacao = DateTime.Now;
            Obj.data_ult_alteracao = DateTime.Now;
            ControllerCidades.Salvar(Obj);
        }
    }
}
