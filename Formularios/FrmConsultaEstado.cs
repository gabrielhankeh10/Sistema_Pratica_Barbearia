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
        }
    }
}
