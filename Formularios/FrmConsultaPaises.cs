﻿using Sistema__Renovo_Barber.Classes;
using Sistema__Renovo_Barber.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema__Renovo_Barber
{
    public partial class FrmConsultaPaises : Sistema__Renovo_Barber.FrmConsulta
    {
        private uCtrlPaises Controller = new uCtrlPaises();
        public FrmConsultaPaises()
        {
            InitializeComponent();
            Listar();
        }
        public void Listar()
        {
            DgConsultaPais.Rows.Clear();
            DataTable vData = Controller.PopularGrid();
            if (vData != null)
            {
                foreach (DataRow vLinha in vData.Rows)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(DgConsultaPais);
                    row.Cells[0].Value = vLinha["id_pais"].ToString();
                    row.Cells[1].Value = vLinha["nome"].ToString();
                    row.Cells[2].Value = vLinha["sigla"].ToString();
                    row.Cells[3].Value = vLinha["DDI"].ToString();
                    DgConsultaPais.Rows.Add(row);
                }
            }
        }
        public override void IncluirFormCadastro()
        {
            FrmCadastroPaises frmCadastroPaises = new FrmCadastroPaises();
            frmCadastroPaises.ShowDialog();
            Listar();
        }

        public void PesquisarPais()
        {
            try
            {
                DgConsultaPais.ClearSelection();
                var Obj = Controller.PesquisarNome(tbPesquisar.Text);
                if (Obj != null)
                {
                    foreach (DataGridViewRow vLinha in DgConsultaPais.Rows)
                    {
                        if (vLinha.Cells["nome"].Value.ToString() == Obj.pais)
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
        public override void AlterarFormCadastro()
        {
            try
            {
                DataGridViewRow vLinha;
                uPais Pais = new uPais();
                vLinha = DgConsultaPais.SelectedRows[0];
                if (vLinha != null)
                {
                    Pais = Controller.Carregar(Convert.ToInt32(vLinha.Cells["id_pais"].Value));
                    FrmCadastroPaises frmCadastroPaises = new FrmCadastroPaises();
                    frmCadastroPaises.Alterar_Botao();
                    frmCadastroPaises.Popular(Pais);
                    frmCadastroPaises.ShowDialog();
                    Listar();
                }
            }
            catch { }
        }
        public override void ExcluirFormCadastro()
        {
            try
            {
                DataGridViewRow vLinha;
                uPais Pais = new uPais();
                vLinha = DgConsultaPais.SelectedRows[0];
                if (vLinha != null)
                {
                    Pais = Controller.Carregar(Convert.ToInt32(vLinha.Cells["id_pais"].Value));
                    FrmCadastroPaises frmCadastroPaises = new FrmCadastroPaises();
                    frmCadastroPaises.Excluir_Botao();
                    frmCadastroPaises.Popular(Pais);
                    frmCadastroPaises.ShowDialog();
                    Listar();
                }
            }
            catch { }
        }

        private void DgConsultaPais_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisarPais();
        }
        public uPais PegarObj()
        {
            return Controller.Carregar(Convert.ToInt32(DgConsultaPais.SelectedRows[0].Cells["id_pais"].Value));
        }
        private void DgConsultaPais_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PegarObj();
            this.Hide();
        }

        private void DgConsultaPais_KeyPress(object sender, KeyPressEventArgs e)
        {
            PegarObj();
            this.Hide();
        }
    }
}
