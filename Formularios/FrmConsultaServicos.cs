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
        }
    }
}
