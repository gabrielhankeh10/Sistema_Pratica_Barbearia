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
    public partial class FrmConsultaFormaPagamento : Sistema__Renovo_Barber.FrmConsulta
    {
        uCtrlFormaPagamento Controller = new uCtrlFormaPagamento();
        public FrmConsultaFormaPagamento()
        {
            InitializeComponent();
            Listar();
        }
        public void Listar()
        {
            DgConsultaFormaPagamento.Rows.Clear();
            DataTable vData = Controller.PopularGrid();
            if (vData != null)
            {
                foreach (DataRow vLinha in vData.Rows)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(DgConsultaFormaPagamento);
                    row.Cells[0].Value = vLinha["id_forma"].ToString();
                    row.Cells[1].Value = vLinha["forma"].ToString();
                    row.Cells[2].Value = vLinha["data_criacao"].ToString();
                    row.Cells[3].Value = vLinha["data_ult_alteracao"].ToString();
                    DgConsultaFormaPagamento.Rows.Add(row);
                }
            }
        }
        public uFormaPagamento PegarObj()
        {
            return Controller.Carregar(Convert.ToInt32(DgConsultaFormaPagamento.SelectedRows[0].Cells["id_forma"].Value));
        }
        public override void AlterarFormCadastro()
        {
            try
            {
                DataGridViewRow vLinha;
                uFormaPagamento FormaPagamento = new uFormaPagamento();
                vLinha = DgConsultaFormaPagamento.SelectedRows[0];
                if (vLinha != null)
                {
                    FormaPagamento = Controller.Carregar(Convert.ToInt32(vLinha.Cells["id_forma"].Value));
                    FrmCadastroFormaPagamento frmCadastroFormaPagamento = new FrmCadastroFormaPagamento();
                    frmCadastroFormaPagamento.Alterar_Botao();
                    frmCadastroFormaPagamento.Popular(FormaPagamento);
                    frmCadastroFormaPagamento.ShowDialog();
                    Listar();
                }
            }
            catch { }
        }
        public override void ExcluirFormCadastro()
        {
            try
            {
                DataGridViewRow vLinha;
                uFormaPagamento FormaPagamento = new uFormaPagamento();
                vLinha = DgConsultaFormaPagamento.SelectedRows[0];
                if (vLinha != null)
                {
                    FormaPagamento = Controller.Carregar(Convert.ToInt32(vLinha.Cells["id_forma"].Value));
                    FrmCadastroFormaPagamento frmCadastroFormaPagamento = new FrmCadastroFormaPagamento();
                    frmCadastroFormaPagamento.Excluir_Botao();
                    frmCadastroFormaPagamento.Popular(FormaPagamento);
                    frmCadastroFormaPagamento.ShowDialog();
                    Listar();
                }
            }
            catch { }
        }
        public override void IncluirFormCadastro()
        {
            FrmCadastroFormaPagamento frmCadastroFormaPagamento = new FrmCadastroFormaPagamento();
            frmCadastroFormaPagamento.ShowDialog();
            Listar();
        }

        private void DgConsultaFormaPagamento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PegarObj();
            this.Hide();
        }

        private void DgConsultaFormaPagamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            PegarObj();
            this.Hide();
        }
    }
}
