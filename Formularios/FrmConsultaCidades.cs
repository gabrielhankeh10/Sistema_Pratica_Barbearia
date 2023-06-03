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
    public partial class FrmConsultaCidades : Sistema__Renovo_Barber.FrmConsulta
    {
        private uCtrlCidades Controller = new uCtrlCidades();
        public FrmConsultaCidades()
        {
            InitializeComponent();
            Listar();
        }
        public void Listar()
        {
            DgConsultaCidades.Rows.Clear();
            DataTable vData = Controller.PopularGrid();
            if (vData != null)
            {
                foreach (DataRow vLinha in vData.Rows)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(DgConsultaCidades);
                    row.Cells[0].Value = vLinha["id_cidade"].ToString();
                    row.Cells[1].Value = vLinha["cidade"].ToString();
                    row.Cells[2].Value = vLinha["ddd"].ToString();
                    row.Cells[3].Value = vLinha["uf"].ToString();
                    DgConsultaCidades.Rows.Add(row);
                }
            }
        }

        public override void IncluirFormCadastro()
        {
            FrmCadastroCidades frmCadastroCidades = new FrmCadastroCidades();
            frmCadastroCidades.ShowDialog();
        }
    }
}
