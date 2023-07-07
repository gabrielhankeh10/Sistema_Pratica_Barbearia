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
            if (btnSalvar.Text == "Salvar")
            {
                Obj.Forma = tbForma.Text;
                Obj.data_criacao = DateTime.Now;
                Obj.data_ult_alteracao = DateTime.Now;
                ControllerForma.Salvar(Obj);
                this.Close();
            }
            else if (btnSalvar.Text == "Alterar")
            {
                Obj.id = Convert.ToInt32(tbCodigo.Text);
                Obj.Forma = tbForma.Text;
                Obj.Status = tbStatus.Text;
                Obj.data_ult_alteracao = DateTime.Now;
                ControllerForma.Alterar(Obj);
                this.Close();
            }
            else if (btnSalvar.Text == "Excluir")
            {
                Obj.id = Convert.ToInt32(tbCodigo.Text);
                ControllerForma.Excluir(Obj);
                this.Close();
            }
        }
        public void Alterar_Botao()
        {
            btnSalvar.Text = "Alterar";
            tbStatus.Enabled = true;
            tbCodigo.Enabled = false;
            tbDatCad.Enabled = false;
            tbDatUltAlt.Enabled = false;
        }
        public void Excluir_Botao()
        {
            btnSalvar.Text = "Excluir";
            tbCodigo.Enabled = false;
            tbForma.Enabled = false;
            tbDatCad.Enabled = false;
            tbDatUltAlt.Enabled = false;
        }

        public void Popular(uFormaPagamento FormaPagamento)
        {
            tbCodigo.Text = FormaPagamento.id.ToString();
            tbForma.Text = FormaPagamento.Forma.ToString();
            tbStatus.Text = FormaPagamento.Status.ToString();
            tbDatCad.Text = FormaPagamento.data_criacao.ToShortDateString();
            tbDatUltAlt.Text = FormaPagamento.data_ult_alteracao.ToShortDateString();
        }
    }
}
