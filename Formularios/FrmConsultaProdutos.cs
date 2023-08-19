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
    public partial class FrmConsultaProdutos : Sistema__Renovo_Barber.FrmConsulta
    {
        public FrmConsultaProdutos()
        {
            InitializeComponent();
            Listar();
        }
        uCtrlProdutos Controller = new uCtrlProdutos();
        public void Listar()
        {
            DgConsultaProdutos.Rows.Clear();
            DataTable vData = Controller.PopularGrid();
            if (vData != null)
            {
                foreach (DataRow vLinha in vData.Rows)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(DgConsultaProdutos);
                    row.Cells[0].Value = vLinha["id_produto"].ToString();
                    row.Cells[1].Value = vLinha["descricao_produto"].ToString();
                    row.Cells[2].Value = vLinha["marca"].ToString();
                    row.Cells[3].Value = vLinha["preco_custo"].ToString();
                    row.Cells[4].Value = vLinha["preco_venda"].ToString();
                    row.Cells[5].Value = vLinha["qtd_estoque"].ToString();
                    row.Cells[6].Value = vLinha["data_criacao"].ToString();
                    row.Cells[7].Value = vLinha["data_ult_alteracao"].ToString();
                    DgConsultaProdutos.Rows.Add(row); 
                }
            }
        }
        public override void IncluirFormCadastro()
        {
            FrmCadastroProdutos frmCadastroProdutos = new FrmCadastroProdutos();
            frmCadastroProdutos.ShowDialog();
            Listar();
        }
    }
}
