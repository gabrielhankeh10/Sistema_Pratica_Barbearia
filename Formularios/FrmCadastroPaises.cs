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

        public void Alterar_Botao()
        {
            btnSalvar.Text = "Alterar";
            tbCodigo.Enabled = false;
            tbDatCad.Enabled = false;
            tbDatUltAlt.Enabled = false;
        }
        public void Excluir_Botao()
        {
            btnSalvar.Text = "Excluir";
            tbCodigo.Enabled = false;
            tbDatCad.Enabled = false;
            tbDatUltAlt.Enabled = false;
            tbPais.Enabled = false;
            tbSigla.Enabled = false;
            tbDDI.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            uPais Obj = new uPais();
            if (btnSalvar.Text == "Salvar")
            {
                Obj.pais = tbPais.Text;
                Obj.ddi = tbDDI.Text;
                Obj.sigla = tbSigla.Text;
                Obj.data_criacao = DateTime.Now;
                Obj.data_ult_alteracao = DateTime.Now;
                ControllerPaises.Salvar(Obj);
                this.Close();

            }
            else if (btnSalvar.Text == "Alterar")
            {
                Obj.pais = tbPais.Text;
                Obj.ddi = tbDDI.Text;
                Obj.sigla = tbSigla.Text;
                Obj.data_ult_alteracao = DateTime.Now;
                Obj.id = Convert.ToInt32(tbCodigo.Text);
                ControllerPaises.Alterar(Obj);
                this.Close();
            }
            else if (btnSalvar.Text == "Excluir")
            {
                Obj.id = Convert.ToInt32(tbCodigo.Text);
                ControllerPaises.Excluir(Obj);
                this.Close();
            }
        }

        public void Popular(uPais Pais)
        {
            tbCodigo.Text = Pais.id.ToString();
            tbPais.Text = Pais.pais.ToString();
            tbSigla.Text = Pais.sigla.ToString();
            tbDDI.Text = Pais.ddi.ToString();
            tbDatCad.Text = Pais.data_criacao.ToShortDateString();
            tbDatUltAlt.Text = Pais.data_ult_alteracao.ToShortDateString();
        }
    }
}
