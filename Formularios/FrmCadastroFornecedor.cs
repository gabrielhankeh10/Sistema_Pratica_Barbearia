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
    public partial class FrmCadastroFornecedor : Sistema__Renovo_Barber.Formularios.FrmCadastroPessoa
    {
        public FrmCadastroFornecedor()
        {
            InitializeComponent();
        }
        private uCtrlFornecedor ControllerFornecedor = new uCtrlFornecedor();

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            uFornecedor Obj = new uFornecedor();
            Obj.Cidade = new uCidade();
            Obj.Pessoa = new uPessoa();
            Obj.Pessoa.Nome = tbNome.Text;
            //Obj.Pessoa.Data_nasc = DateTime.Parse(tbDatNasc.Text);
            Obj.NomeFantasia = tbApelido.Text;
            Obj.CNPJ = tbCpfCnpj.Text;
            Obj.InscEstadual = tbInscricaoEst.Text;
            Obj.InscMunicipal = tbInscricaoMun.Text;
            Obj.Email = tbEmail.Text;
            Obj.Telefone = TbTelefone.Text;
            Obj.Celular = tbCelular.Text;
            Obj.CEP = TbCEP.Text;
            Obj.Endereco = tbEndereco.Text;
            Obj.Numero = int.Parse(tbNumero.Text);
            Obj.Complemento = tbComplemento.Text;
            Obj.Bairro = tbBairro.Text;
            Obj.Cidade.id = int.Parse(tbCidade.Text);
            Obj.data_criacao = DateTime.Now;
            Obj.data_ult_alteracao = DateTime.Now;
            ControllerFornecedor.Salvar(Obj);
        }
    }
}
