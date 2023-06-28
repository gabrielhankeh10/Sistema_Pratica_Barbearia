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
        public void Alterar_Botao()
        {
            btnSalvar.Text = "Alterar";
            tbCodigo.Enabled = false;
            tbDatCad.Enabled = false;
            tbDatUltAlt.Enabled = false;
            tbCidade.Enabled = false;
        }

        public void Popular(uFornecedor Fornecedor)
        {
            tbCodigo.Text = Fornecedor.id.ToString();
            tbApelido.Text = Fornecedor.NomeFantasia.ToString();
            tbCpfCnpj.Text = Fornecedor.CNPJ.ToString();
            tbDatNasc.Text = Fornecedor.Data_nasc.ToString();
            tbStatus.Text = Fornecedor.Status.ToString();
            tbNome.Text = Fornecedor.Nome.ToString();
            tbInscricaoMun.Text = Fornecedor.InscMunicipal.ToString();
            tbInscricaoEst.Text = Fornecedor.InscEstadual.ToString();
            tbEmail.Text = Fornecedor.Email.ToString();
            tbEndereco.Text = Fornecedor.Endereco.ToString();
            tbNumero.Text = Fornecedor.Numero.ToString();
            tbBairro.Text = Fornecedor.Bairro.ToString();
            tbComplemento.Text = Fornecedor.Complemento.ToString();
            TbTelefone.Text = Fornecedor.Telefone.ToString();
            tbCidade.Text = Fornecedor.Cidade.id.ToString();
            TbCEP.Text = Fornecedor.CEP.ToString();
            tbCelular.Text = Fornecedor.Celular.ToString();
            tbDatCad.Text = Fornecedor.data_criacao.ToShortDateString();
            tbDatUltAlt.Text = Fornecedor.data_ult_alteracao.ToShortDateString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            uFornecedor Obj = new uFornecedor();
            Obj.Cidade = new uCidade();
            Obj.Pessoa = new uPessoa();
            if (btnSalvar.Text == "Salvar")
            {
                Obj.Pessoa.Nome = tbNome.Text;
                Obj.Pessoa.Data_nasc = DateTime.Parse(tbDatNasc.Text);
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
                this.Close();
            }
            else if (btnSalvar.Text == "Alterar")
            {
                Obj.id = Convert.ToInt32(tbCodigo.Text);
                Obj.Nome = tbNome.Text;
                Obj.Status = tbStatus.Text;
                Obj.Data_nasc = DateTime.Parse(tbDatNasc.Text);
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
                Obj.data_ult_alteracao = DateTime.Now;
                ControllerFornecedor.Alterar(Obj);
                this.Close();
            }
        }
    }
}
