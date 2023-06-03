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
    public partial class FrmConsultaFornecedor : Sistema__Renovo_Barber.FrmConsulta
    {
        private uCtrlFornecedor Controller = new uCtrlFornecedor();
        public FrmConsultaFornecedor()
        {
            InitializeComponent();
        }
        public void Listar()
        {
            DgConsultaFornecedor.Rows.Clear();
            DataTable vData = Controller.PopularGrid();
            if (vData != null)
            {
                foreach (DataRow vLinha in vData.Rows)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(DgConsultaFornecedor);
                    row.Cells[0].Value = vLinha["id_fornecedor"].ToString();
                    row.Cells[1].Value = vLinha["status_fornecedor"].ToString();
                    row.Cells[2].Value = vLinha["nome_fantasia"].ToString();
                    row.Cells[3].Value = vLinha["razao_social"].ToString();
                    row.Cells[4].Value = vLinha["data_fundacao"].ToString();
                    row.Cells[5].Value = vLinha["insc_municipal"].ToString();
                    row.Cells[6].Value = vLinha["razao_social"].ToString();
                    row.Cells[7].Value = vLinha["razao_social"].ToString();
                    row.Cells[8].Value = vLinha["razao_social"].ToString();
                    row.Cells[9].Value = vLinha["razao_social"].ToString();
                    row.Cells[10].Value = vLinha["razao_social"].ToString();
                    row.Cells[11].Value = vLinha["razao_social"].ToString();
                    row.Cells[12].Value = vLinha["razao_social"].ToString();
                    row.Cells[13].Value = vLinha["razao_social"].ToString();
                    row.Cells[14].Value = vLinha["razao_social"].ToString();
                    row.Cells[15].Value = vLinha["razao_social"].ToString();
                    row.Cells[16].Value = vLinha["razao_social"].ToString();
                    row.Cells[17].Value = vLinha["razao_social"].ToString();
                    row.Cells[18].Value = vLinha["razao_social"].ToString();
                    row.Cells[19].Value = vLinha["razao_social"].ToString();
                    DgConsultaFornecedor.Rows.Add(row);
                }
            }
        }
        private void DgConsultaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public override void IncluirFormCadastro()
        {
            FrmCadastroFornecedor frmCadastroFornecedor = new FrmCadastroFornecedor();
            frmCadastroFornecedor.ShowDialog();
        }
        private void btnIncluir_Click(object sender, EventArgs e)
        {

        }
    }
}
