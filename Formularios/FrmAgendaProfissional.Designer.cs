﻿
namespace Sistema__Renovo_Barber.Formularios
{
    partial class FrmAgendaProfissional
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.tbFuncionario = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.tbIdFuncionario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGerar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.DgConsultaAgenda = new System.Windows.Forms.DataGridView();
            this.datas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbInter1Ini = new System.Windows.Forms.MaskedTextBox();
            this.tbInter1Fim = new System.Windows.Forms.MaskedTextBox();
            this.tbInter2Ini = new System.Windows.Forms.MaskedTextBox();
            this.tbInter2Fim = new System.Windows.Forms.MaskedTextBox();
            this.tbIntervalo = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgConsultaAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Funcionario";
            // 
            // tbFuncionario
            // 
            this.tbFuncionario.Location = new System.Drawing.Point(130, 62);
            this.tbFuncionario.Name = "tbFuncionario";
            this.tbFuncionario.Size = new System.Drawing.Size(175, 22);
            this.tbFuncionario.TabIndex = 9;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(324, 62);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 19;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // tbIdFuncionario
            // 
            this.tbIdFuncionario.Location = new System.Drawing.Point(39, 61);
            this.tbIdFuncionario.Name = "tbIdFuncionario";
            this.tbIdFuncionario.Size = new System.Drawing.Size(69, 22);
            this.tbIdFuncionario.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(452, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Data de Agenda";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(455, 63);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(128, 22);
            this.dateTimePicker1.TabIndex = 24;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Intervalo 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(321, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Intervalo 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Hora Inicio";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(168, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "Hora Fim";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(452, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 34;
            this.label8.Text = "Hora Fim";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(320, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 17);
            this.label9.TabIndex = 33;
            this.label9.Text = "Hora Inicio";
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(666, 524);
            this.btnGerar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(75, 23);
            this.btnGerar.TabIndex = 35;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(587, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 17);
            this.label10.TabIndex = 37;
            this.label10.Text = "Intervalo em Minutos";
            // 
            // DgConsultaAgenda
            // 
            this.DgConsultaAgenda.AllowUserToAddRows = false;
            this.DgConsultaAgenda.AllowUserToDeleteRows = false;
            this.DgConsultaAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgConsultaAgenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datas});
            this.DgConsultaAgenda.Location = new System.Drawing.Point(39, 210);
            this.DgConsultaAgenda.MultiSelect = false;
            this.DgConsultaAgenda.Name = "DgConsultaAgenda";
            this.DgConsultaAgenda.ReadOnly = true;
            this.DgConsultaAgenda.RowHeadersWidth = 51;
            this.DgConsultaAgenda.RowTemplate.Height = 24;
            this.DgConsultaAgenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgConsultaAgenda.Size = new System.Drawing.Size(796, 299);
            this.DgConsultaAgenda.TabIndex = 38;
            // 
            // datas
            // 
            this.datas.HeaderText = "Datas Com Agenda";
            this.datas.MinimumWidth = 6;
            this.datas.Name = "datas";
            this.datas.ReadOnly = true;
            this.datas.Width = 180;
            // 
            // tbInter1Ini
            // 
            this.tbInter1Ini.Location = new System.Drawing.Point(39, 156);
            this.tbInter1Ini.Mask = "##:##";
            this.tbInter1Ini.Name = "tbInter1Ini";
            this.tbInter1Ini.Size = new System.Drawing.Size(99, 22);
            this.tbInter1Ini.TabIndex = 39;
            // 
            // tbInter1Fim
            // 
            this.tbInter1Fim.Location = new System.Drawing.Point(171, 156);
            this.tbInter1Fim.Mask = "##:##";
            this.tbInter1Fim.Name = "tbInter1Fim";
            this.tbInter1Fim.Size = new System.Drawing.Size(100, 22);
            this.tbInter1Fim.TabIndex = 40;
            // 
            // tbInter2Ini
            // 
            this.tbInter2Ini.Location = new System.Drawing.Point(323, 156);
            this.tbInter2Ini.Mask = "##:##";
            this.tbInter2Ini.Name = "tbInter2Ini";
            this.tbInter2Ini.Size = new System.Drawing.Size(100, 22);
            this.tbInter2Ini.TabIndex = 41;
            // 
            // tbInter2Fim
            // 
            this.tbInter2Fim.Location = new System.Drawing.Point(455, 156);
            this.tbInter2Fim.Mask = "##:##";
            this.tbInter2Fim.Name = "tbInter2Fim";
            this.tbInter2Fim.Size = new System.Drawing.Size(100, 22);
            this.tbInter2Fim.TabIndex = 42;
            // 
            // tbIntervalo
            // 
            this.tbIntervalo.Location = new System.Drawing.Point(590, 156);
            this.tbIntervalo.Mask = "##";
            this.tbIntervalo.Name = "tbIntervalo";
            this.tbIntervalo.Size = new System.Drawing.Size(37, 22);
            this.tbIntervalo.TabIndex = 43;
            // 
            // FrmAgendaProfissional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(891, 581);
            this.Controls.Add(this.tbIntervalo);
            this.Controls.Add(this.tbInter2Fim);
            this.Controls.Add(this.tbInter2Ini);
            this.Controls.Add(this.tbInter1Fim);
            this.Controls.Add(this.tbInter1Ini);
            this.Controls.Add(this.DgConsultaAgenda);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbIdFuncionario);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbFuncionario);
            this.Name = "FrmAgendaProfissional";
            this.Text = "Agenda Profissional";
            this.Controls.SetChildIndex(this.tbFuncionario, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.btnPesquisar, 0);
            this.Controls.SetChildIndex(this.tbIdFuncionario, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.dateTimePicker1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.btnGerar, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.DgConsultaAgenda, 0);
            this.Controls.SetChildIndex(this.tbInter1Ini, 0);
            this.Controls.SetChildIndex(this.tbInter1Fim, 0);
            this.Controls.SetChildIndex(this.tbInter2Ini, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.tbInter2Fim, 0);
            this.Controls.SetChildIndex(this.tbIntervalo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DgConsultaAgenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbFuncionario;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox tbIdFuncionario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView DgConsultaAgenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn datas;
        private System.Windows.Forms.MaskedTextBox tbInter1Ini;
        private System.Windows.Forms.MaskedTextBox tbInter1Fim;
        private System.Windows.Forms.MaskedTextBox tbInter2Ini;
        private System.Windows.Forms.MaskedTextBox tbInter2Fim;
        private System.Windows.Forms.MaskedTextBox tbIntervalo;
    }
}
