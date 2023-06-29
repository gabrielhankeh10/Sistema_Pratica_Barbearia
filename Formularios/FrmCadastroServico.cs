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

        public void Alterar_Botao()
        {
            btnSalvar.Text = "Alterar";
            tbCodigo.Enabled = false;
            tbDatCad.Enabled = false;
            tbDatUltAlt.Enabled = false;
        }
        public void Popular(uServicos Servicos)
        {
            tbCodigo.Text = Servicos.id.ToString();
            tbDescricao.Text = Servicos.Descricao.ToString();
            tbStatus.Text = Servicos.Status.ToString();
            tbDuracao.Text = Servicos.Duracao.ToString();
            tbValor.Text = Servicos.Valor.ToString();
            tbDatCad.Text = Servicos.data_criacao.ToShortDateString();
            tbDatUltAlt.Text = Servicos.data_ult_alteracao.ToShortDateString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            uServicos Obj = new uServicos();
            if (btnSalvar.Text == "Salvar")
            {
                Obj.Descricao = tbDescricao.Text;
                Obj.Duracao = TimeSpan.Parse(tbDuracao.Text);
                Obj.Valor = decimal.Parse(tbValor.Text);
                Obj.data_criacao = DateTime.Now;
                Obj.data_ult_alteracao = DateTime.Now;
                ControllerServicos.Salvar(Obj);
                this.Close();
            }
            else if (btnSalvar.Text == "Alterar")
            {
                Obj.id = Convert.ToInt32(tbCodigo.Text);
                Obj.Descricao = tbDescricao.Text;
                Obj.Duracao = TimeSpan.Parse(tbDuracao.Text);
                Obj.Valor = decimal.Parse(tbValor.Text);
                Obj.Status = tbStatus.Text;
                Obj.data_ult_alteracao = DateTime.Now;
                ControllerServicos.Alterar(Obj);
                this.Close();
            }
            
        }
    }
}
