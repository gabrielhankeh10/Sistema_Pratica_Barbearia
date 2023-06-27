﻿using Sistema__Renovo_Barber.Classes;
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
    public partial class FrmCadastroEstado : Sistema__Renovo_Barber.FrmCadastro
    {
        public FrmCadastroEstado()
        {
            InitializeComponent();
        }
        private uCtrlEstados ControllerEstados = new uCtrlEstados();
        public void Alterar_Botao()
        {
            btnSalvar.Text = "Alterar";
            btnPesquisarPais.Text = "Alterar";
            tbCodigo.Enabled = false;
            tbDatCad.Enabled = false;
            tbDatUltAlt.Enabled = false;
            tbCodigoPais.Enabled = false;
            tbPais.Enabled = false;
        }
        public void Popular(uEstado Estado)
        {
            tbCodigo.Text = Estado.id.ToString();
            tbEstado.Text = Estado.estado.ToString();
            tbUf.Text = Estado.uf.ToString();
            tbCodigoPais.Text = Estado.pais.id.ToString();
            tbPais.Text = Estado.pais.pais.ToString();
            tbDatCad.Text = Estado.data_criacao.ToShortDateString();
            tbDatUltAlt.Text = Estado.data_ult_alteracao.ToShortDateString();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            uEstado Obj = new uEstado();
            Obj.pais = new uPais();
            if (btnSalvar.Text == "Salvar")
            {
                Obj.estado = tbEstado.Text;
                Obj.uf = tbUf.Text;
                Obj.pais.id = int.Parse(tbCodigoPais.Text);
                Obj.data_criacao = DateTime.Now;
                Obj.data_ult_alteracao = DateTime.Now;
                ControllerEstados.Salvar(Obj);
            }
            else if (btnSalvar.Text == "Alterar")
            {
                Obj.estado = tbEstado.Text;
                Obj.uf = tbUf.Text;
                Obj.pais.id = int.Parse(tbCodigoPais.Text);
                Obj.data_criacao = DateTime.Now;
                Obj.data_ult_alteracao = DateTime.Now;
                Obj.id = Convert.ToInt32(tbCodigo.Text);
                Obj.pais.pais = tbPais.Text;
                ControllerEstados.Alterar(Obj);
                this.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (btnPesquisarPais.Text == "Alterar")
            {
                FrmConsultaPaises frmConsultaPais = new FrmConsultaPaises();
                frmConsultaPais.ShowDialog();
            }
            else if (btnPesquisarPais.Text == "Incluir")
            {
                FrmConsultaPaises frmConsultaPais = new FrmConsultaPaises();
                frmConsultaPais.ShowDialog();
            }
            
        }
    }
}
