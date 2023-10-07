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
    public partial class FrmConsultaServicos : Sistema__Renovo_Barber.FrmConsulta
    {
        uCtrlServicos Controller = new uCtrlServicos();
        public FrmConsultaServicos()
        {
            InitializeComponent();
            Listar();
        }

        public override void AlterarFormCadastro()
        {
            try
            {
                DataGridViewRow vLinha;
                uServicos Servicos = new uServicos();
                vLinha = DgConsultaServicos.SelectedRows[0];
                if (vLinha != null)
                {
                    Servicos = Controller.Carregar(Convert.ToInt32(vLinha.Cells["id_servico"].Value));
                    FrmCadastroServico frmCadastroServico = new FrmCadastroServico();
                    frmCadastroServico.Alterar_Botao();
                    frmCadastroServico.Popular(Servicos);
                    frmCadastroServico.ShowDialog();
                    Listar();
                }
            }
            catch { }
        }
        public uServicos PegarObj()
        {
            return Controller.Carregar(Convert.ToInt32(DgConsultaServicos.SelectedRows[0].Cells["id_servico"].Value));
        }
        public override void ExcluirFormCadastro()
        {
            try
            {
                DataGridViewRow vLinha;
                uServicos Servicos = new uServicos();
                vLinha = DgConsultaServicos.SelectedRows[0];
                if (vLinha != null)
                {
                    Servicos = Controller.Carregar(Convert.ToInt32(vLinha.Cells["id_servico"].Value));
                    FrmCadastroServico frmCadastroServico = new FrmCadastroServico();
                    frmCadastroServico.Excluir_Botao();
                    frmCadastroServico.Popular(Servicos);
                    frmCadastroServico.ShowDialog();
                    Listar();
                }
            }
            catch { }
        }
        public void PesquisarServico()
        {
            try
            {
                DgConsultaServicos.ClearSelection();
                var Obj = Controller.PesquisarNome(tbPesquisar.Text);
                if (Obj != null)
                {
                    foreach (DataGridViewRow vLinha in DgConsultaServicos.Rows)
                    {
                        if (vLinha.Cells["descricao"].Value.ToString() == Obj.Descricao)
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
        public void Listar()
        {
            DgConsultaServicos.Rows.Clear();
            DataTable vData = Controller.PopularGrid();
            if (vData != null)
            {
                foreach (DataRow vLinha in vData.Rows)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(DgConsultaServicos);
                    row.Cells[0].Value = vLinha["id_servico"].ToString();
                    row.Cells[1].Value = vLinha["descricao"].ToString();
                    row.Cells[2].Value = vLinha["status_servico"].ToString();
                    row.Cells[3].Value = vLinha["duracao"].ToString();
                    row.Cells[4].Value = vLinha["valor"].ToString();
                    row.Cells[5].Value = vLinha["data_criacao"].ToString();
                    row.Cells[6].Value = vLinha["data_ult_alteracao"].ToString();
                    DgConsultaServicos.Rows.Add(row);
                }
            }
        }
        public override void IncluirFormCadastro()
        {
            FrmCadastroServico frmCadastroServico = new FrmCadastroServico();
            frmCadastroServico.ShowDialog();
            Listar();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisarServico();
        }

        private void DgConsultaServicos_DoubleClick(object sender, EventArgs e)
        {
            PegarObj();
            this.Hide();
        }

        private void DgConsultaServicos_KeyPress(object sender, KeyPressEventArgs e)
        {
            PegarObj();
            this.Hide();
        }
    }
}
