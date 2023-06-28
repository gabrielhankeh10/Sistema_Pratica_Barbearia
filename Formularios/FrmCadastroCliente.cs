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
    public partial class FrmCadastroCliente : Sistema__Renovo_Barber.Formularios.FrmCadastroPessoa
    {
        public FrmCadastroCliente()
        {
            InitializeComponent();
        }
        private uCtrlCliente ControllerCliente = new uCtrlCliente();
        public void Alterar_Botao()
        {
            btnSalvar.Text = "Alterar";
            tbCodigo.Enabled = false;
            tbDatCad.Enabled = false;
            tbDatUltAlt.Enabled = false;
            tbCidade.Enabled = false;
        }
        public void Popular(uCliente Cliente)
        {
            tbCodigo.Text = Cliente.id.ToString();
            tbNome.Text = Cliente.Nome.ToString();
            tbSexo.Text = Cliente.Sexo.ToString();
            tbCpfCnpj.Text = Cliente.CPF.ToString();
            tbRG.Text = Cliente.RG.ToString();
            tbStatus.Text = Cliente.Status.ToString();
            tbApelido.Text = Cliente.Apelido.ToString();
            tbDatNasc.Text = Cliente.Data_nasc.ToShortDateString();
            tbEmail.Text = Cliente.Email.ToString();
            tbEndereco.Text = Cliente.Endereco.ToString();
            tbNumero.Text = Cliente.Numero.ToString();
            tbBairro.Text = Cliente.Bairro.ToString();
            tbComplemento.Text = Cliente.Complemento.ToString();
            TbTelefone.Text = Cliente.Telefone.ToString();
            tbCidade.Text = Cliente.Cidade.id.ToString();
            TbCEP.Text = Cliente.CEP.ToString();
            tbCelular.Text = Cliente.Celular.ToString();
            tbDatCad.Text = Cliente.data_criacao.ToShortDateString();
            tbDatUltAlt.Text = Cliente.data_ult_alteracao.ToShortDateString();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            uCliente Obj = new uCliente();
            Obj.Pessoa = new uPessoa();
            Obj.Cidade = new uCidade();
            if (btnSalvar.Text == "Salvar")
            {
                Obj.Pessoa.Nome = tbNome.Text;
                Obj.Sexo = tbSexo.Text;
                Obj.Apelido = tbApelido.Text;
                Obj.Data_nasc = DateTime.Parse(tbDatNasc.Text);
                Obj.RG = tbRG.Text;
                Obj.CPF = tbCpfCnpj.Text;
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
                ControllerCliente.Salvar(Obj);
                this.Close();
            }
            else if (btnSalvar.Text == "Alterar")
            {
                Obj.id = Convert.ToInt32(tbCodigo.Text);
                Obj.Nome = tbNome.Text;
                Obj.Sexo = tbSexo.Text;
                Obj.CPF = tbCpfCnpj.Text;
                Obj.RG = tbRG.Text;
                Obj.Status = tbStatus.Text;
                Obj.Apelido = tbApelido.Text;
                Obj.Data_nasc = DateTime.Parse(tbDatNasc.Text);
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
                ControllerCliente.Alterar(Obj);
                this.Close();
            }
        }
    }
}
