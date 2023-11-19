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
        public override void ExcluirFormCadastro()
        {
            try
            {
                DataGridViewRow vLinha;
                uProdutos Produtos = new uProdutos();
                vLinha = DgConsultaProdutos.SelectedRows[0];
                if (vLinha != null)
                {
                    Produtos = Controller.Carregar(Convert.ToInt32(vLinha.Cells["id_produto"].Value));
                    FrmCadastroProdutos frmCadastroProdutos = new FrmCadastroProdutos();
                    frmCadastroProdutos.Excluir_Botao();
                    frmCadastroProdutos.Popular(Produtos);
                    frmCadastroProdutos.ShowDialog();
                    Listar();
                }
            }
            catch { }
        }
        public override void AlterarFormCadastro()
        {
            try
            {
                DataGridViewRow vLinha;
                uProdutos Produtos = new uProdutos();
                vLinha = DgConsultaProdutos.SelectedRows[0];
                if (vLinha != null)
                {
                    Produtos = Controller.Carregar(Convert.ToInt32(vLinha.Cells["id_produto"].Value));
                    FrmCadastroProdutos frmCadastroProdutos = new FrmCadastroProdutos();
                    frmCadastroProdutos.Alterar_Botao();
                    frmCadastroProdutos.Popular(Produtos);
                    frmCadastroProdutos.ShowDialog();
                    Listar();
                }
            }
            catch { }
        }
        public uProdutos PegarObj()
        {
            return Controller.Carregar(Convert.ToInt32(DgConsultaProdutos.SelectedRows[0].Cells["id_produto"].Value));
        }

        public override void IncluirFormCadastro()
        {
            FrmCadastroProdutos frmCadastroProdutos = new FrmCadastroProdutos();
            frmCadastroProdutos.ShowDialog();
            Listar();
        }

        private void DgConsultaProdutos_KeyPress(object sender, KeyPressEventArgs e)
        {
            PegarObj();
            this.Hide();
        }

        private void DgConsultaProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PegarObj();
            this.Hide();
        }

        private void DgConsultaProdutos_DoubleClick(object sender, EventArgs e)
        {
            PegarObj();
            this.Hide();
        }
    }
}
