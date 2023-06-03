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
    public partial class FrmConsultaCliente : Sistema__Renovo_Barber.FrmConsulta
    {
        private uCtrlCliente Controller = new uCtrlCliente();
        public FrmConsultaCliente()
        {
            InitializeComponent();
            Listar();
        }
        public void Listar()
        {
            DgConsultaClientes.Rows.Clear();
            DataTable vData = Controller.PopularGrid();
            if (vData != null)
            {
                foreach (DataRow vLinha in vData.Rows)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(DgConsultaClientes);
                    row.Cells[0].Value = vLinha["id_cliente"].ToString();
                    row.Cells[1].Value = vLinha["status_cliente"].ToString();
                    row.Cells[2].Value = vLinha["nome"].ToString();
                    row.Cells[3].Value = vLinha["apelido"].ToString();
                    row.Cells[4].Value = vLinha["sexo"].ToString();
                    row.Cells[5].Value = vLinha["rg"].ToString();
                    row.Cells[6].Value = vLinha["cpf"].ToString();
                    row.Cells[7].Value = vLinha["email"].ToString();
                    row.Cells[8].Value = vLinha["telefone"].ToString();
                    row.Cells[9].Value = vLinha["celular"].ToString();
                    row.Cells[10].Value = vLinha["cep"].ToString();
                    row.Cells[11].Value = vLinha["endereco"].ToString();
                    row.Cells[12].Value = vLinha["numero"].ToString();
                    row.Cells[13].Value = vLinha["complemento"].ToString();
                    row.Cells[14].Value = vLinha["bairro"].ToString();
                    row.Cells[15].Value = vLinha["cidade"].ToString();
                    row.Cells[16].Value = vLinha["data_criacao"].ToString();
                    row.Cells[17].Value = vLinha["data_ult_alteracao"].ToString();
                    DgConsultaClientes.Rows.Add(row);
                }
            }
        }
        public override void IncluirFormCadastro()
        {
            FrmCadastroCliente frmCadastroCliente = new FrmCadastroCliente();
            frmCadastroCliente.ShowDialog();
        }

    }
}
