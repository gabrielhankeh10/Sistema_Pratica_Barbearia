using Sistema__Renovo_Barber.Classes;
using Sistema__Renovo_Barber.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema__Renovo_Barber
{
    public partial class FrmConsultaPaises : Sistema__Renovo_Barber.FrmConsulta
    {
        private uCtrlPaises Controller = new uCtrlPaises();
        public FrmConsultaPaises()
        {
            InitializeComponent();
            Listar();
        }
        
        public void Listar()
        {
            DgConsultaPais.Rows.Clear();
            DataTable vData = Controller.PopularGrid();
            if (vData != null)
            {
                foreach (DataRow vLinha in vData.Rows)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(DgConsultaPais);
                    row.Cells[0].Value = vLinha["id_pais"].ToString();
                    row.Cells[1].Value = vLinha["nome"].ToString();
                    row.Cells[2].Value = vLinha["sigla"].ToString();
                    row.Cells[3].Value = vLinha["DDI"].ToString();
                    DgConsultaPais.Rows.Add(row);
                }
            }
        }
        
        public override void IncluirFormCadastro()
        {
            FrmCadastroPaises frmCadastroPaises = new FrmCadastroPaises();
            frmCadastroPaises.ShowDialog();
        }
        public override void AlterarFormCadastro()
        {
            try
            {
                DataGridViewRow vLinha;
                uPais Pais = new uPais();
                //if (DgConsultaPais.SelectedRows[0] != null)
                //{
                vLinha = DgConsultaPais.SelectedRows[0];
                if (vLinha != null)
                {
                    Pais = Controller.Carregar(Convert.ToInt32(vLinha.Cells["id_pais"].Value));
                    FrmCadastroPaises frmCadastroPaises = new FrmCadastroPaises();
                    frmCadastroPaises.Alterar_Botao();
                    frmCadastroPaises.Popular(Pais);
                    frmCadastroPaises.ShowDialog();
                    Listar();
                }   
                //}
            }
            catch { }
        }
        public override void ExcluirFormCadastro()
        {
            FrmCadastroPaises frmCadastroPaises = new FrmCadastroPaises();
            frmCadastroPaises.ShowDialog();
        }

        private void DgConsultaPais_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

    }
}
