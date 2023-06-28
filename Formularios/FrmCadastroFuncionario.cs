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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            uFuncionario Obj = new uFuncionario();
            Obj.Cidade = new uCidade();
            Obj.Cargos = new uCargos();
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
            Obj.data_criacao = DateTime.Now;
            Obj.data_ult_alteracao = DateTime.Now;
            Obj.Cargos.id = int.Parse(tbCargo.Text);
            Obj.Cidade.id = int.Parse(tbCidade.Text);
            ControllerFuncionario.Salvar(Obj);
        }
    }
}
