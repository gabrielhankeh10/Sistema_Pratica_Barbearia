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
    public partial class FrmConsultaFuncionario : Sistema__Renovo_Barber.FrmConsulta
    {
        private uCtrlFuncionario Controller = new uCtrlFuncionario();
        public FrmConsultaFuncionario()
        {
            InitializeComponent();
            Listar();
        }
        public void Listar()
        {
            DgConsultaFuncionario.Rows.Clear();
            DataTable vData = Controller.PopularGrid();
            if (vData != null)
            {
                foreach (DataRow vLinha in vData.Rows)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(DgConsultaFuncionario);
                    row.Cells[0].Value = vLinha["id_funcionario"].ToString();
                    row.Cells[1].Value = vLinha["status_funcionario"].ToString();
                    row.Cells[2].Value = vLinha["nome"].ToString();
                    row.Cells[3].Value = vLinha["cargo"].ToString();
                    row.Cells[4].Value = vLinha["cidade"].ToString();
                    row.Cells[5].Value = vLinha["sexo"].ToString();
                    row.Cells[6].Value = vLinha["rg"].ToString();
                    row.Cells[7].Value = vLinha["cpf"].ToString();
                    row.Cells[8].Value = vLinha["email"].ToString();
                    row.Cells[9].Value = vLinha["telefone"].ToString();
                    row.Cells[10].Value = vLinha["celular"].ToString();
                    row.Cells[11].Value = vLinha["cep"].ToString();
                    row.Cells[12].Value = vLinha["endereco"].ToString();
                    row.Cells[13].Value = vLinha["numero"].ToString();
                    row.Cells[14].Value = vLinha["complemento"].ToString();
                    row.Cells[15].Value = vLinha["data_nasc"].ToString();
                    row.Cells[16].Value = vLinha["data_criacao"].ToString();
                    row.Cells[17].Value = vLinha["data_ult_alteracao"].ToString();
                    DgConsultaFuncionario.Rows.Add(row);
                }
            }
        }
        public override void IncluirFormCadastro()
        {
            FrmCadastroFuncionario frmCadastroFuncionario = new FrmCadastroFuncionario();
            frmCadastroFuncionario.ShowDialog();
        }

    }
}
