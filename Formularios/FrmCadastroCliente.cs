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
            tbStatus.Enabled = true;
            tbCodigo.Enabled = false;
            tbDatCad.Enabled = false;
            tbDatUltAlt.Enabled = false;
            tbCidade.Enabled = false;
        }
        public void Excluir_Botao()
        {
            btnSalvar.Text = "Excluir";
            tbCodigo.Enabled = false;
            tbCidadeDesc.Enabled = false;
            tbNome.Enabled = false;
            tbSexo.Enabled = false;
            tbCpfCnpj.Enabled = false;
            tbRG.Enabled = false;
            tbStatus.Enabled = false;
            tbApelido.Enabled = false;
            tbDatNasc.Enabled = false;
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
            tbIdeCondicao.Enabled = false;
            tbCondicaoPagamento.Enabled = false;
            tbDatUltAlt.Enabled = false;
            btnPesquisarEstado.Enabled = false;
        }
        public void Popular(uCliente Cliente)
        {
            tbCodigo.Text = Cliente.id.ToString();
            tbCidadeDesc.Text = Cliente.Cidade.Cidade.ToString();
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
            tbIdeCondicao.Text = Cliente.CondicaoPagamento.id.ToString();
            tbCondicaoPagamento.Text = Cliente.CondicaoPagamento.Condicao.ToString();
            tbDatCad.Text = Cliente.data_criacao.ToShortDateString();
            tbDatUltAlt.Text = Cliente.data_ult_alteracao.ToShortDateString();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            uCliente Obj = new uCliente();
            Obj.CondicaoPagamento = new uCondicaoPagamento();
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
                Obj.CondicaoPagamento.id = int.Parse(tbIdeCondicao.Text);
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
                Obj.CondicaoPagamento.id = int.Parse(tbIdeCondicao.Text);
                Obj.Cidade.id = int.Parse(tbCidade.Text);
                Obj.Cidade.Cidade = tbCidadeDesc.Text;
                Obj.data_ult_alteracao = DateTime.Now;
                ControllerCliente.Alterar(Obj);
                this.Close();
            }
            else if (btnSalvar.Text == "Excluir")
            {
                Obj.id = Convert.ToInt32(tbCodigo.Text);
                ControllerCliente.Excluir(Obj);
                this.Close();
            }
        }

        public static bool IsCpfValid(string cpf)
        {
            cpf = cpf.Replace(",", "").Replace("-", "").Replace(" ", "");

            if (cpf.Length != 11 || IsAllSameDigits(cpf))
            {
                return false;
            }

            int[] weights = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int sum1 = 0;
            for (int i = 0; i < 9; i++)
            {
                sum1 += (cpf[i] - '0') * weights[i];
            }

            int remainder1 = sum1 % 11;
            int digit1 = (remainder1 < 2) ? 0 : 11 - remainder1;

            int sum2 = 0;
            for (int i = 0; i < 9; i++)
            {
                sum2 += (cpf[i] - '0') * (weights[i] + 1);
            }

            int remainder2 = sum2 % 11;
            int digit2 = (remainder2 < 2) ? 0 : 11 - remainder2;

            return (cpf[9] - '0' == digit1) && (cpf[10] - '0' == digit2);
        }

        public static bool IsAllSameDigits(string s)
        {
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] != s[0])
                {
                    return false;
                }
            }
            return true;
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
        private void btnPesquisarEstado_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            FrmConsultaCondicaoPagamento frmConsultaCondicaoPagamento = new FrmConsultaCondicaoPagamento();
            frmConsultaCondicaoPagamento.ShowDialog();
            uCondicaoPagamento CondicaoPagamento = new uCondicaoPagamento();
            if (!frmConsultaCondicaoPagamento.ActiveControl.ContainsFocus)
            {
                CondicaoPagamento = frmConsultaCondicaoPagamento.PegarObj();
                tbIdeCondicao.Text = CondicaoPagamento.id.ToString();
                tbCondicaoPagamento.Text = CondicaoPagamento.Condicao.ToString();
            }
            frmConsultaCondicaoPagamento.Close();
        }

        private void tbCpfCnpj_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbCpfCnpj_TabIndexChanged(object sender, EventArgs e)
        {
            string CPF = tbCpfCnpj.Text;

            ValidarCPF(CPF);

            bool Valida = ValidarCPF(CPF);

            if (Valida)
            {
                MessageBox.Show("CPF Valido");
            }
            else
            {
                MessageBox.Show("CPF inválido!");
            }
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
