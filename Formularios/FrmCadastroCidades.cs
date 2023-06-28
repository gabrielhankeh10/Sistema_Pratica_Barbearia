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

        public void Alterar_Botao()
        {
            btnSalvar.Text = "Alterar";
            btnPesquisarEstado.Text = "Alterar";
            tbCodigo.Enabled = false;
            tbDatCad.Enabled = false;
            tbDatUltAlt.Enabled = false;
            tbCodEstado.Enabled = false;
            tbEstado.Enabled = false;
        }
        public void Popular(uCidade Cidade)
        {
            tbCodigo.Text = Cidade.id.ToString();
            tbCidade.Text = Cidade.Cidade.ToString();
            tbDDD.Text = Cidade.DDD.ToString();
            tbEstado.Text = Cidade.Estado.estado.ToString();
            tbCodEstado.Text = Cidade.Estado.id.ToString();
            tbDatCad.Text = Cidade.data_criacao.ToShortDateString();
            tbDatUltAlt.Text = Cidade.data_ult_alteracao.ToShortDateString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
               
            uCidade Obj = new uCidade();
            Obj.Estado = new uEstado();
            if (btnSalvar.Text == "Salvar")
            {
                Obj.Estado.id = int.Parse(tbCodEstado.Text);
                Obj.Cidade = tbCidade.Text;
                Obj.DDD = tbDDD.Text;
                Obj.data_criacao = DateTime.Now;
                Obj.data_ult_alteracao = DateTime.Now;
                ControllerCidades.Salvar(Obj);
                this.Close();
            }
            else if (btnSalvar.Text == "Alterar")
            {
                Obj.id = Convert.ToInt32(tbCodigo.Text);
                Obj.Estado.id = int.Parse(tbCodEstado.Text);
                Obj.Cidade = tbCidade.Text;
                Obj.DDD = tbDDD.Text;
                Obj.data_criacao = DateTime.Now;
                Obj.data_ult_alteracao = DateTime.Now;
                ControllerCidades.Alterar(Obj);
                this.Close();
            }
        }
    }
}
