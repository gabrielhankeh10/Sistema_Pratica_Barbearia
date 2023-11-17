using Sistema__Renovo_Barber.Classes;
using Sistema__Renovo_Barber.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Text.RegularExpressions;

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

        private void button1_Click(object sender, EventArgs e)
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

        public bool ValidarCPF(string cpf)
        {
            string cpfNumeros = new string(cpf.Where(char.IsDigit).ToArray());

            if (cpfNumeros.Length != 11)
                return false;

            int soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(cpfNumeros[i].ToString()) * (10 - i);

            int primeiroDigito = 11 - (soma % 11);
            if (primeiroDigito > 9)
                primeiroDigito = 0;

            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(cpfNumeros[i].ToString()) * (11 - i);

            int segundoDigito = 11 - (soma % 11);
            if (segundoDigito > 9)
                segundoDigito = 0;

            return cpfNumeros.EndsWith(primeiroDigito.ToString() + segundoDigito.ToString());
        }
        public bool ValidarRG(string rg)
        {
            string rgNumeros = new string(rg.Where(char.IsDigit).ToArray());

            if (rgNumeros.Length < 8)
                return false;

            return true;
        }

        static bool ValidarEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(email);
        }
        private void tbCpfCnpj_Leave(object sender, EventArgs e)
        {
            string CPF = tbCpfCnpj.Text;

            CPF = CPF.Replace(",", "").Replace("-", "").Replace(" ", "");

            ValidarCPF(CPF);
            bool Verifica = ValidarCPF(CPF);

            if (Verifica)
            {
            }
            else
            {
                MessageBox.Show("CPF inválido!");
                tbCpfCnpj.Clear();
                tbCpfCnpj.Focus();
            }
        }

        private void tbRG_Leave(object sender, EventArgs e)
        {
            string Rg = tbRG.Text;

            Rg = Rg.Replace(",", "").Replace("-", "").Replace(" ", "");

            ValidarRG(Rg);
            bool Verifica = ValidarRG(Rg);

            if (Verifica)
            {
            }
            else
            {
                MessageBox.Show("RG inválido!");
                tbRG.Clear();
                tbRG.Focus();
            }
        }

        private void tbEmail_Leave(object sender, EventArgs e)
        {
            string Email = tbEmail.Text;

            Email = Email.Replace(",", "").Replace("-", "").Replace(" ", "");

            ValidarEmail(Email);
            bool Verifica = ValidarEmail(Email);

            if (Verifica)
            {
            }
            else
            {
                MessageBox.Show("Email inválido!");
                tbEmail.Clear();
                tbEmail.Focus();
            }
        }
    }
}
