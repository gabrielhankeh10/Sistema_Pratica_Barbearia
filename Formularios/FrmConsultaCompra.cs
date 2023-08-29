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
    public partial class FrmConsultaCompra : Sistema__Renovo_Barber.Formularios.FrmPai
    {
        public FrmConsultaCompra()
        {
            InitializeComponent();
            Listar();
        }
        uCtrlCompras ControllerCompras = new uCtrlCompras();
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            FrmCadastroCompra frmCadastroCompra = new FrmCadastroCompra();
            frmCadastroCompra.ShowDialog();
            Listar();
        }
        public void Listar()
        {
            DgConsultaClientes.Rows.Clear();
            DataTable vData = ControllerCompras.PopularGrid();
            if (vData != null)
            {
                foreach (DataRow vLinha in vData.Rows)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(DgConsultaClientes);
                    row.Cells[0].Value = vLinha["num_nfc"].ToString();
                    row.Cells[1].Value = vLinha["modelo_nfc"].ToString();
                    row.Cells[2].Value = vLinha["serie_nfc"].ToString();
                    row.Cells[3].Value = vLinha["fornecedor"].ToString();
                    row.Cells[4].Value = vLinha["condicao"].ToString();
                    row.Cells[5].Value = vLinha["valor_total"].ToString();
                    row.Cells[6].Value = vLinha["valor_frete"].ToString();
                    row.Cells[7].Value = vLinha["valor_seguro"].ToString();
                    row.Cells[8].Value = vLinha["valor_outras_despesas"].ToString();
                    row.Cells[9].Value = vLinha["data_chegada"].ToString();
                    row.Cells[10].Value = vLinha["data_emissao"].ToString();
                    row.Cells[11].Value = vLinha["data_criacao"].ToString();
                    DgConsultaClientes.Rows.Add(row);
                }
            }
        }
    }
}
