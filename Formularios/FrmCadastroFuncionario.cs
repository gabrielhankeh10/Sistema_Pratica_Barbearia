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
    public partial class FrmCadastroFuncionario : Sistema__Renovo_Barber.Formularios.FrmCadastroPessoa
    {
        public FrmCadastroFuncionario()
        {
            InitializeComponent();
        }
        private uCtrlFuncionario ControllerFuncionario = new uCtrlFuncionario();

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
            tbStatus.Enabled = true;
            tbCodigo.Enabled = false;
            tbNome.Enabled = false;
            tbCpfCnpj.Enabled = false;
            tbRG.Enabled = false;
            tbSexo.Enabled = false;
            tbStatus.Enabled = false;
            tbApelido.Enabled = false;
            tbDatNasc.Enabled = false;
            tbCargo.Enabled = false;
            tbEmail.Enabled = false;
            tbEndereco.Enabled = false;
            tbNumero.Enabled = false;
            tbBairro.Enabled = false;
            tbComplemento.Enabled = false;
            TbTelefone.Enabled = false;
            tbCidade.Enabled = false;
            TbCEP.Enabled = false;
            tbCelular.Enabled = false;
            tbSenha.Enabled = false;
            tbDatCad.Enabled = false;
            tbDatUltAlt.Enabled = false;
        }

        public void Popular(uFuncionario Funcionario)
        {

            tbCodigo.Text = Funcionario.id.ToString();
            tbNome.Text = Funcionario.Nome.ToString();
            tbCidadeDesc.Text = Funcionario.Cidade.Cidade.ToString();
            tbCargoDesc.Text = Funcionario.Cargos.Cargo.ToString();
            tbCpfCnpj.Text = Funcionario.CPF.ToString();
            tbRG.Text = Funcionario.RG.ToString();
            tbSexo.Text = Funcionario.Sexo.ToString();
            tbStatus.Text = Funcionario.Status.ToString();
            tbApelido.Text = Funcionario.Apelido.ToString();
            tbDatNasc.Text = Funcionario.Data_nasc.ToShortDateString();
            tbCargo.Text = Funcionario.Cargos.id.ToString();
            tbEmail.Text = Funcionario.Email.ToString();
            tbEndereco.Text = Funcionario.Endereco.ToString();
            tbNumero.Text = Funcionario.Numero.ToString();
            tbBairro.Text = Funcionario.Bairro.ToString();
            tbComplemento.Text = Funcionario.Complemento.ToString();
            TbTelefone.Text = Funcionario.Telefone.ToString();
            tbCidade.Text = Funcionario.Cidade.id.ToString();
            TbCEP.Text = Funcionario.CEP.ToString();
            tbCelular.Text = Funcionario.Celular.ToString();
            tbSenha.Text = Funcionario.Senha.ToString();
            tbDatCad.Text = Funcionario.data_criacao.ToShortDateString();
            tbDatUltAlt.Text = Funcionario.data_ult_alteracao.ToShortDateString();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            uFuncionario Obj = new uFuncionario();
            Obj.Cidade = new uCidade();
            Obj.Cargos = new uCargos();
            if (btnSalvar.Text == "Salvar")
            {
                Obj.Apelido = tbApelido.Text;
                Obj.Bairro = tbBairro.Text;
                Obj.Nome = tbNome.Text;
                Obj.Sexo = tbSexo.Text;
                Obj.RG = tbRG.Text;
                Obj.CPF = tbCpfCnpj.Text;
                Obj.Email = tbEmail.Text;
                Obj.Senha = tbSenha.Text;
                Obj.Telefone = TbTelefone.Text;
                Obj.Celular = tbCelular.Text;
                Obj.CEP = TbCEP.Text;
                Obj.Endereco = tbEndereco.Text;
                Obj.Numero = int.Parse(tbNumero.Text);
                Obj.Complemento = tbComplemento.Text;
                Obj.Data_nasc = DateTime.Parse(tbDatNasc.Text);
                Obj.data_criacao = DateTime.Now;
                Obj.data_ult_alteracao = DateTime.Now;
                Obj.Cargos.id = int.Parse(tbCargo.Text);
                Obj.Cidade.id = int.Parse(tbCidade.Text);
                ControllerFuncionario.Salvar(Obj);
                this.Close();
            }
            else if (btnSalvar.Text == "Alterar")
            {
                Obj.id = Convert.ToInt32(tbCodigo.Text);
                Obj.Status = tbStatus.Text;
                Obj.Bairro = tbBairro.Text;
                Obj.Apelido = tbApelido.Text;
                Obj.Nome = tbNome.Text;
                Obj.Sexo = tbSexo.Text;
                Obj.RG = tbRG.Text;
                Obj.CPF = tbCpfCnpj.Text;
                Obj.Email = tbEmail.Text;
                Obj.Senha = tbSenha.Text;
                Obj.Telefone = TbTelefone.Text;
                Obj.Celular = tbCelular.Text;
                Obj.CEP = TbCEP.Text;
                Obj.Endereco = tbEndereco.Text;
                Obj.Numero = int.Parse(tbNumero.Text);
                Obj.Complemento = tbComplemento.Text;
                Obj.Data_nasc = DateTime.Parse(tbDatNasc.Text);
                Obj.data_ult_alteracao = DateTime.Now;
                Obj.Cargos.id = int.Parse(tbCargo.Text);
                Obj.Cidade.id = int.Parse(tbCidade.Text);
                ControllerFuncionario.Alterar(Obj);
                this.Close();
            }
            else if (btnSalvar.Text == "Excluir")
            {
                Obj.id = Convert.ToInt32(tbCodigo.Text);
                ControllerFuncionario.Excluir(Obj);
                this.Close();
            }

        }

        private void btnPesquisarCidade_Click(object sender, EventArgs e)
        {
            FrmConsultaCidades frmConsultaCidades = new FrmConsultaCidades();
            frmConsultaCidades.ShowDialog();
            uCidade Cidade = new uCidade();
            if (!frmConsultaCidades.ActiveControl.ContainsFocus)
            {
                Cidade = frmConsultaCidades.PegarObj();
                tbCidade.Text = Cidade.id.ToString();
                tbCidadeDesc.Text = Cidade.Cidade.ToString();
            }
            frmConsultaCidades.Close();
        }

        private void btnPesquisarCargo_Click(object sender, EventArgs e)
        {
            FrmConsultaCargos frmConsultaCargos = new FrmConsultaCargos();
            frmConsultaCargos.ShowDialog();
            uCargos Cargos = new uCargos();
            if (!frmConsultaCargos.ActiveControl.ContainsFocus)
            {
                Cargos = frmConsultaCargos.PegarObj();
                tbCargo.Text = Cargos.id.ToString();
                tbCargoDesc.Text = Cargos.Cargo.ToString();
            }
            frmConsultaCargos.Close();
        }
    }
}
