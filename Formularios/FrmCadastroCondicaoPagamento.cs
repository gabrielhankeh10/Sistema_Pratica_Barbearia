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
    public partial class FrmCadastroCondicaoPagamento : Sistema__Renovo_Barber.FrmCadastro
    {
        uCtrlCondicaoPagamento ControllerCondicao = new uCtrlCondicaoPagamento();
        public FrmCadastroCondicaoPagamento()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            uCondicaoPagamento Obj = new uCondicaoPagamento();
            Obj.Condicao = tbCondicao.Text;
            Obj.Parcelas = int.Parse(tbParcelas.Text);
            Obj.Taxa = decimal.Parse(tbTaxa.Text);
            Obj.Multa = decimal.Parse(tbMulta.Text);
            Obj.Desconto = decimal.Parse(tbDesconto.Text);
            Obj.data_criacao = DateTime.Now;
            ControllerCondicao.Salvar(Obj);
        }
    }
}
