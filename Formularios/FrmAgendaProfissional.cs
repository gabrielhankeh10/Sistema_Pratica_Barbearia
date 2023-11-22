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
    public partial class FrmAgendaProfissional : Sistema__Renovo_Barber.Formularios.FrmPai
    {
        uFuncionario Funcionario = new uFuncionario();
        public FrmAgendaProfissional()
        {
            InitializeComponent();
        }

        public void GerarAgenda()
        {
            
            try
            {
                if (DateTime.Parse($"{dateTimePicker1.Value.ToString("dd/MM/yyyy")} {tbInter1Ini.Text}") < DateTime.Now)

                    throw new Exception("Data inválida.");
                else
                {
                    string Horario_2;
                    Funcionario.id = Convert.ToInt32(tbIdFuncionario.Text);
                    TimeSpan Inter1Inicio = TimeSpan.Parse(tbInter1Ini.Text);
                    TimeSpan Inter1Fim = TimeSpan.Parse(tbInter1Fim.Text);
                    while (Inter1Inicio < Inter1Fim)
                    {
                        uCtrlAgenda CtrlAgenda = new uCtrlAgenda();
                        uAgenda Agenda = new uAgenda();
                        Agenda.Funcionario = Funcionario;
                        Agenda.Data = DateTime.Parse($"{dateTimePicker1.Value.ToString("dd/MM/yyyy")} {Inter1Inicio}");
                        Agenda.Intervalo = int.Parse(tbIntervalo.Text);
                        CtrlAgenda.Salvar(Agenda);
                        Inter1Inicio = Inter1Inicio.Add(new TimeSpan(0, Agenda.Intervalo, 0));
                    }
                    
                    if (!string.IsNullOrEmpty(tbInter2Ini.Text))
                    {
                        TimeSpan Inter2Inicio = TimeSpan.Parse(tbInter2Ini.Text);
                        TimeSpan Inter2Fim = TimeSpan.Parse(tbInter2Fim.Text);
                        while (Inter2Inicio < Inter2Fim)
                        {
                            uCtrlAgenda CtrlAgenda = new uCtrlAgenda();
                            uAgenda Agenda = new uAgenda();
                            Agenda.Funcionario = Funcionario;
                            Agenda.Data = DateTime.Parse($"{dateTimePicker1.Value.ToString("dd/MM/yyyy")} {Inter2Inicio}");
                            Agenda.Intervalo = int.Parse(tbIntervalo.Text);
                            CtrlAgenda.Salvar(Agenda);
                            Inter2Inicio = Inter2Inicio.Add(new TimeSpan(0, Agenda.Intervalo, 0));
                        }
                    }
                    MessageBox.Show("Agenda Cadastrada");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void btnGerar_Click(object sender, EventArgs e)
        {
            GerarAgenda();
            Listar_Datas();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            FrmConsultaFuncionario frmConsultaFuncionario = new FrmConsultaFuncionario();
            frmConsultaFuncionario.ShowDialog();
            uFuncionario Funcionario = new uFuncionario();
            if (!frmConsultaFuncionario.ActiveControl.ContainsFocus)
            {
                Funcionario = frmConsultaFuncionario.PegarObj();
                tbIdFuncionario.Text = Funcionario.id.ToString();
                tbFuncionario.Text = Funcionario.Nome.ToString();
                frmConsultaFuncionario.Close();
                DgConsultaAgenda.Rows.Clear();
                
                uCtrlAgenda Controller = new uCtrlAgenda();
                DataTable vData = Controller.Verificar_datas(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, Funcionario.id);
                if (vData != null)
                {
                    foreach (DataRow vLinha in vData.Rows)
                    {
                        DgConsultaAgenda.Rows.Add(
                            vLinha["data"]);
                    }
                }
            }
            tbFuncionario.Enabled = false;
            tbIdFuncionario.Enabled = false;
        }

        private void Listar_Datas()
        {
            DgConsultaAgenda.Rows.Clear();
            if (!string.IsNullOrEmpty(tbIdFuncionario.Text))
            {
                uCtrlAgenda Controller = new uCtrlAgenda();
                int IdFuncionario = int.Parse(tbIdFuncionario.Text);
                DataTable vData = Controller.Verificar_datas(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, IdFuncionario);
                if (vData != null)
                {
                    foreach (DataRow vLinha in vData.Rows)
                    {
                        DgConsultaAgenda.Rows.Add(
                            vLinha["data"]);
                    }
                }
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            Listar_Datas();
        }
    }
}
