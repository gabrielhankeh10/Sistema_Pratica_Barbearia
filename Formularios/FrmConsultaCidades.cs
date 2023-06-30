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
    public partial class FrmConsultaCidades : Sistema__Renovo_Barber.FrmConsulta
    {
        private uCtrlCidades Controller = new uCtrlCidades();
        public FrmConsultaCidades()
        {
            InitializeComponent();
            Listar();
        }
        public override void AlterarFormCadastro()
        {
            try
            {
                DataGridViewRow vLinha;
                uCidade Cidade = new uCidade();
                vLinha = DgConsultaCidades.SelectedRows[0];
                if (vLinha != null)
                {
                    Cidade = Controller.Carregar(Convert.ToInt32(vLinha.Cells["id_cidade"].Value));
                    FrmCadastroCidades frmCadastroCidade = new FrmCadastroCidades();
                    frmCadastroCidade.Alterar_Botao();
                    frmCadastroCidade.Popular(Cidade);
                    frmCadastroCidade.ShowDialog();
                    Listar();
                }
            }
            catch { }
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
            Listar();
        }
        public override void ExcluirFormCadastro()
        {
            try
            {
                DataGridViewRow vLinha;
                uCidade Cidade = new uCidade();
                vLinha = DgConsultaCidades.SelectedRows[0];
                if (vLinha != null)
                {
                    Cidade = Controller.Carregar(Convert.ToInt32(vLinha.Cells["id_cidade"].Value));
                    FrmCadastroCidades frmCadastroCidades = new FrmCadastroCidades();
                    frmCadastroCidades.Excluir_Botao();
                    frmCadastroCidades.Popular(Cidade);
                    frmCadastroCidades.ShowDialog();
                    Listar();
                }
            }
            catch { }
        }
        public void PesquisarCidade()
        {
            try
            {
                DgConsultaCidades.ClearSelection();
                var Obj = Controller.PesquisarNome(tbPesquisar.Text);
                if (Obj != null)
                {
                    foreach (DataGridViewRow vLinha in DgConsultaCidades.Rows)
                    {
                        if (vLinha.Cells["cidade"].Value.ToString() == Obj.Cidade)
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
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            
        }
        public uCidade PegarObj()
        {
            return Controller.Carregar(Convert.ToInt32(DgConsultaCidades.SelectedRows[0].Cells["id_cidade"].Value));
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisarCidade();
        }

        private void DgConsultaCidades_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            PegarObj();
            this.Hide();
        }

        private void DgConsultaCidades_KeyPress(object sender, KeyPressEventArgs e)
        {
            PegarObj();
            this.Hide();
        }
    }
}
