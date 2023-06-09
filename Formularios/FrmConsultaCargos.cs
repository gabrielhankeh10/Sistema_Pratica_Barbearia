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
    public partial class FrmConsultaCargos : Sistema__Renovo_Barber.FrmConsulta
    {
        private uCtrlCargos Controller = new uCtrlCargos();
        public FrmConsultaCargos()
        {
            InitializeComponent();
            Listar();
        }
        public override void AlterarFormCadastro()
        {
            try
            {
                DataGridViewRow vLinha;
                uCargos Cargos = new uCargos();
                vLinha = DgConsultaCargos.SelectedRows[0];
                if (vLinha != null)
                {
                    Cargos = Controller.Carregar(Convert.ToInt32(vLinha.Cells["id_cargo"].Value));
                    FrmCadastroCargos frmCadastroCargos = new FrmCadastroCargos();
                    frmCadastroCargos.Alterar_Botao();
                    frmCadastroCargos.Popular(Cargos);
                    frmCadastroCargos.ShowDialog();
                    Listar();
                }
            }
            catch { }
        }
        public void PesquisarCargo()
        {
            try
            {
                DgConsultaCargos.ClearSelection();
                var Obj = Controller.PesquisarNome(tbPesquisar.Text);
                if (Obj != null)
                {
                    foreach (DataGridViewRow vLinha in DgConsultaCargos.Rows)
                    {
                        if (vLinha.Cells["cargo"].Value.ToString() == Obj.Cargo)
                        {
                            vLinha.Selected = true;
                            break;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Listar()
        {
            DgConsultaCargos.Rows.Clear();
            DataTable vData = Controller.PopularGrid();
            if (vData != null)
            {
                foreach (DataRow vLinha in vData.Rows)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(DgConsultaCargos);
                    row.Cells[0].Value = vLinha["id_cargo"].ToString();
                    row.Cells[1].Value = vLinha["status_cargo"].ToString();
                    row.Cells[2].Value = vLinha["cargo"].ToString();
                    row.Cells[3].Value = vLinha["data_criacao"].ToString();
                    row.Cells[4].Value = vLinha["data_ult_alteracao"].ToString();
                    DgConsultaCargos.Rows.Add(row);
                }
            }
        }
        public override void ExcluirFormCadastro()
        {
            try
            {
                DataGridViewRow vLinha;
                uCargos Cargos = new uCargos();
                vLinha = DgConsultaCargos.SelectedRows[0];
                if (vLinha != null)
                {
                    Cargos = Controller.Carregar(Convert.ToInt32(vLinha.Cells["id_cargo"].Value));
                    FrmCadastroCargos frmCadastroCargos = new FrmCadastroCargos();
                    frmCadastroCargos.Excluir_Botao();
                    frmCadastroCargos.Popular(Cargos);
                    frmCadastroCargos.ShowDialog();
                    Listar();
                }
            }
            catch { }
        }
        public override void IncluirFormCadastro()
        {
            FrmCadastroCargos frmCadastroCargos = new FrmCadastroCargos();
            frmCadastroCargos.ShowDialog();
            Listar();
        }
        public uCargos PegarObj()
        {
            return Controller.Carregar(Convert.ToInt32(DgConsultaCargos.SelectedRows[0].Cells["id_cargo"].Value));
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisarCargo();
        }
        private void DgConsultaCargos_KeyPress(object sender, KeyPressEventArgs e)
        {
            PegarObj();
            this.Hide();
        }
        private void DgConsultaCargos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            PegarObj();
            this.Hide();
        }
    }
}
