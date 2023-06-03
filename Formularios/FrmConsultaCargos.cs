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
        public override void IncluirFormCadastro()
        {
            FrmCadastroCargos frmCadastroCargos = new FrmCadastroCargos();
            frmCadastroCargos.ShowDialog();
        }
    }
}
