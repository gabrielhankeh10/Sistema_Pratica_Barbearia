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
    public partial class FrmConsultaCondicaoPagamento : Sistema__Renovo_Barber.FrmConsulta
    {
        uCtrlCondicaoPagamento Controller = new uCtrlCondicaoPagamento();
        public FrmConsultaCondicaoPagamento()
        {
            InitializeComponent();
            Listar();
        }
        public void Listar()
        {
            DgConsultaCondicaoPagamento.Rows.Clear();
            DataTable vData = Controller.PopularGrid();
            if (vData != null)
            {
                foreach (DataRow vLinha in vData.Rows)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(DgConsultaCondicaoPagamento);
                    row.Cells[0].Value = vLinha["id_condicao"].ToString();
                    row.Cells[1].Value = vLinha["status_condicao"].ToString();
                    row.Cells[2].Value = vLinha["condicao"].ToString();
                    row.Cells[3].Value = vLinha["parcelas"].ToString();
                    row.Cells[4].Value = vLinha["taxa"].ToString();
                    row.Cells[5].Value = vLinha["multa"].ToString();
                    row.Cells[6].Value = vLinha["desconto"].ToString();
                    row.Cells[7].Value = vLinha["data_criacao"].ToString();
                    row.Cells[8].Value = vLinha["data_ult_alteracao"].ToString();
                    DgConsultaCondicaoPagamento.Rows.Add(row);
                }
            }
        }
        public override void IncluirFormCadastro()
        {
            FrmCadastroCondicaoPagamento frmCadastroCondicaoPagamento = new FrmCadastroCondicaoPagamento();
            frmCadastroCondicaoPagamento.ShowDialog();
        }
    }
}
