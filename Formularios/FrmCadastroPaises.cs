using Sistema__Renovo_Barber.Classes;
using Sistema__Renovo_Barber.Controllers;
using Sistema__Renovo_Barber.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema__Renovo_Barber
{
    public partial class FrmCadastroPaises : Sistema__Renovo_Barber.FrmCadastro
    {
        public FrmCadastroPaises()
        {
            InitializeComponent();
        }
        private uCtrlPaises ControllerPaises = new uCtrlPaises(); 
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            uPais Obj = new uPais();
            Obj.pais = tbEstado.Text;
            Obj.ddi = tbDDI.Text;
            Obj.sigla = tbSigla.Text;
            Obj.data_criacao = DateTime.Now;
            Obj.data_ult_alteracao = DateTime.Now;
            ControllerPaises.Salvar(Obj); 
        }
    }
}
