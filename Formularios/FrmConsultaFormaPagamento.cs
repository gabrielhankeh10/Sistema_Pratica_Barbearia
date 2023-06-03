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
                    row.Cells[1].Value = vLinha["status_forma"].ToString();
                    row.Cells[2].Value = vLinha["forma"].ToString();
                    row.Cells[3].Value = vLinha["data_criacao"].ToString();
                    row.Cells[4].Value = vLinha["data_ult_alteracao"].ToString();
                    DgConsultaFormaPagamento.Rows.Add(row);
                }
            }
        }
        public override void IncluirFormCadastro()
        {
            FrmCadastroFormaPagamento frmCadastroFormaPagamento = new FrmCadastroFormaPagamento();
            frmCadastroFormaPagamento.ShowDialog();
        }
    }
}
