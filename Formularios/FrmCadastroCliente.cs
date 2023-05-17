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
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            uCliente Obj = new uCliente();
            Obj.Pessoa = new uPessoa();
            Obj.Cidade = new uCidade();
            Obj.Cidade.Estado = new uEstado();
            Obj.Pessoa.Nome = tbNome.Text;
            Obj.Sexo = tbSexo.Text;
            Obj.Apelido = tbApelido.Text;
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
        }
    }
}
