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
    public partial class FrmConsultaEstado : Sistema__Renovo_Barber.FrmConsulta
    {
        private uCtrlEstados Controller = new uCtrlEstados();
        public FrmConsultaEstado()
        {
            InitializeComponent();
            Listar();
        }
        public override void AlterarFormCadastro()
        {
            try
            {
                DataGridViewRow vLinha;
                uEstado Estado = new uEstado();
                vLinha = DgConsultaEstado.SelectedRows[0];
                if (vLinha != null)
                {
                    Estado = Controller.Carregar(Convert.ToInt32(vLinha.Cells["id_estado"].Value));
                    FrmCadastroEstado frmCadastroEstado = new FrmCadastroEstado();
                    frmCadastroEstado.Alterar_Botao();
                    frmCadastroEstado.Popular(Estado);
                    frmCadastroEstado.ShowDialog();
                    Listar();
                }
            }
            catch { }
        }
        public void Listar()
        {
            DgConsultaEstado.Rows.Clear();
            DataTable vData = Controller.PopularGrid();
            if (vData != null)
            {
                foreach (DataRow vLinha in vData.Rows)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(DgConsultaEstado);
                    row.Cells[0].Value = vLinha["id_estado"].ToString();
                    row.Cells[1].Value = vLinha["nome"].ToString();
                    row.Cells[2].Value = vLinha["uf"].ToString();
                    row.Cells[3].Value = vLinha["pais"].ToString();
                    DgConsultaEstado.Rows.Add(row);
                }
            }
        }
        public override void IncluirFormCadastro()
        {
            FrmCadastroEstado frmCadastroEstado = new FrmCadastroEstado();
            frmCadastroEstado.ShowDialog();
            Listar();
        }
        public uEstado PegarObj()
        {
            return Controller.Carregar(Convert.ToInt32(DgConsultaEstado.SelectedRows[0].Cells["id_estado"].Value));
        }
        public override void ExcluirFormCadastro()
        {
            try
            {
                DataGridViewRow vLinha;
                uEstado Estado = new uEstado();
                vLinha = DgConsultaEstado.SelectedRows[0];
                if (vLinha != null)
                {
                    Estado = Controller.Carregar(Convert.ToInt32(vLinha.Cells["id_estado"].Value));
                    FrmCadastroEstado frmCadastroEstado = new FrmCadastroEstado();
                    frmCadastroEstado.Excluir_Botao();
                    frmCadastroEstado.Popular(Estado);
                    frmCadastroEstado.ShowDialog();
                    Listar();
                }
            }
            catch { }
        }
        public void PesquisarEstado()
        {
            try
            {
                DgConsultaEstado.ClearSelection();
                var Obj = Controller.PesquisarNome(tbPesquisar.Text);
                if (Obj != null)
                {
                    foreach (DataGridViewRow vLinha in DgConsultaEstado.Rows)
                    {
                        if (vLinha.Cells["nome"].Value.ToString() == Obj.estado)
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
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisarEstado();
        }

        private void DgConsultaEstado_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            PegarObj();
            this.Hide();
        }

        private void DgConsultaEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            PegarObj();
            this.Hide();
        }
    }
}
