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

        public void Alterar_Botao()
        {
            btnSalvar.Text = "Alterar";
            tbCodigo.Enabled = false;
            tbDatCad.Enabled = false;
            tbDatUltAlt.Enabled = false;
        }

        public void Popular(uCargos Cargos)
        {
            tbCodigo.Text = Cargos.id.ToString();
            tbCargo.Text = Cargos.Cargo.ToString();
            tbStatus.Text = Cargos.Status.ToString();
            tbDatCad.Text = Cargos.data_criacao.ToShortDateString();
            tbDatUltAlt.Text = Cargos.data_ult_alteracao.ToShortDateString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            uCargos Obj = new uCargos();
            if (btnSalvar.Text == "Salvar")
            {
                Obj.Cargo = tbCargo.Text;
                Obj.data_criacao = DateTime.Now;
                Obj.data_ult_alteracao = DateTime.Now;
                ControllerCargos.Salvar(Obj);
                this.Close();
            }
            else if (btnSalvar.Text == "Alterar")
            {
                Obj.id = Convert.ToInt32(tbCodigo.Text);
                Obj.Cargo = tbCargo.Text;
                Obj.Status = tbStatus.Text;
                Obj.data_ult_alteracao = DateTime.Now;
                ControllerCargos.Alterar(Obj);
                this.Close();
            }
        }
    }
}
