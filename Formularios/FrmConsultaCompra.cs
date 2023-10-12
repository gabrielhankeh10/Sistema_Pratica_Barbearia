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
            frmCadastroCompra.NovoForm();
            frmCadastroCompra.ShowDialog();
            Listar();
        }
        public void Listar()
        {
            DgConsultaCompras.Rows.Clear();
            DataTable vData = ControllerCompras.PopularGrid();
            if (vData != null)
            {
                foreach (DataRow vLinha in vData.Rows)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(DgConsultaCompras);
                    row.Cells[0].Value = vLinha["num_nfc"].ToString();
                    row.Cells[1].Value = vLinha["modelo_nfc"].ToString();
                    row.Cells[2].Value = vLinha["serie_nfc"].ToString();
                    row.Cells[3].Value = vLinha["cod_fornecedor"].ToString();
                    row.Cells[4].Value = vLinha["fornecedor"].ToString();
                    row.Cells[5].Value = vLinha["condicao"].ToString();
                    row.Cells[6].Value = vLinha["valor_total"].ToString();
                    row.Cells[7].Value = vLinha["valor_frete"].ToString();
                    row.Cells[8].Value = vLinha["valor_seguro"].ToString();
                    row.Cells[9].Value = vLinha["valor_outras_despesas"].ToString();
                    row.Cells[10].Value = vLinha["data_chegada"].ToString();
                    row.Cells[11].Value = vLinha["data_emissao"].ToString();
                    row.Cells[12].Value = vLinha["data_criacao"].ToString();
                    DgConsultaCompras.Rows.Add(row);
                }
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            PegarObj();
        }

        public void PegarObj()
        {
            if(DgConsultaCompras.SelectedRows[0] != null)
            {
                int NumNota = Convert.ToInt32(DgConsultaCompras.SelectedRows[0].Cells["num_nfc"].Value);
                int Modelo = Convert.ToInt32(DgConsultaCompras.SelectedRows[0].Cells["modelo_nfc"].Value);
                int Serie = Convert.ToInt32(DgConsultaCompras.SelectedRows[0].Cells["serie_nfc"].Value);
                int CodFornecedor = Convert.ToInt32(DgConsultaCompras.SelectedRows[0].Cells["cod_fornecedor"].Value);
                var Obj = ControllerCompras.Buscar(Modelo, NumNota, Serie, CodFornecedor);
                FrmCadastroCompra frmCadastroCompra = new FrmCadastroCompra();
                frmCadastroCompra.Popular(Obj);
                frmCadastroCompra.ShowDialog();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            PegarObj();
        }

    }
}
