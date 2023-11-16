
namespace Sistema__Renovo_Barber.Formularios
{
    partial class FrmConsultaAgenda
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbIdFuncionario = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbFuncionario = new System.Windows.Forms.TextBox();
            this.DgConsultaAgenda = new System.Windows.Forms.DataGridView();
            this.id_agenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo_funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgConsultaAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(884, 528);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(448, 45);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(128, 22);
            this.dateTimePicker1.TabIndex = 31;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(445, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Data de Agenda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Codigo";
            // 
            // tbIdFuncionario
            // 
            this.tbIdFuncionario.Location = new System.Drawing.Point(32, 43);
            this.tbIdFuncionario.Name = "tbIdFuncionario";
            this.tbIdFuncionario.Size = new System.Drawing.Size(69, 22);
            this.tbIdFuncionario.TabIndex = 28;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(317, 44);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 27;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Funcionario";
            // 
            // tbFuncionario
            // 
            this.tbFuncionario.Location = new System.Drawing.Point(123, 44);
            this.tbFuncionario.Name = "tbFuncionario";
            this.tbFuncionario.Size = new System.Drawing.Size(175, 22);
            this.tbFuncionario.TabIndex = 25;
            // 
            // DgConsultaAgenda
            // 
            this.DgConsultaAgenda.AllowUserToAddRows = false;
            this.DgConsultaAgenda.AllowUserToDeleteRows = false;
            this.DgConsultaAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgConsultaAgenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_agenda,
            this.data,
            this.status,
            this.horario,
            this.codigo_funcionario,
            this.funcionario,
            this.codigo_cliente,
            this.cliente});
            this.DgConsultaAgenda.Location = new System.Drawing.Point(32, 89);
            this.DgConsultaAgenda.MultiSelect = false;
            this.DgConsultaAgenda.Name = "DgConsultaAgenda";
            this.DgConsultaAgenda.ReadOnly = true;
            this.DgConsultaAgenda.RowHeadersWidth = 51;
            this.DgConsultaAgenda.RowTemplate.Height = 24;
            this.DgConsultaAgenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgConsultaAgenda.Size = new System.Drawing.Size(927, 410);
            this.DgConsultaAgenda.TabIndex = 32;
            this.DgConsultaAgenda.DoubleClick += new System.EventHandler(this.DgConsultaCargos_DoubleClick);
            this.DgConsultaAgenda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgConsultaAgenda_KeyDown);
            // 
            // id_agenda
            // 
            this.id_agenda.HeaderText = "ID Agenda";
            this.id_agenda.MinimumWidth = 6;
            this.id_agenda.Name = "id_agenda";
            this.id_agenda.ReadOnly = true;
            this.id_agenda.Visible = false;
            this.id_agenda.Width = 125;
            // 
            // data
            // 
            this.data.HeaderText = "data";
            this.data.MinimumWidth = 6;
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Visible = false;
            this.data.Width = 125;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 65;
            // 
            // horario
            // 
            this.horario.HeaderText = "Horario";
            this.horario.MinimumWidth = 6;
            this.horario.Name = "horario";
            this.horario.ReadOnly = true;
            this.horario.Width = 55;
            // 
            // codigo_funcionario
            // 
            this.codigo_funcionario.HeaderText = "Código Funcionario";
            this.codigo_funcionario.MinimumWidth = 6;
            this.codigo_funcionario.Name = "codigo_funcionario";
            this.codigo_funcionario.ReadOnly = true;
            this.codigo_funcionario.Width = 70;
            // 
            // funcionario
            // 
            this.funcionario.HeaderText = "Funcionario";
            this.funcionario.MinimumWidth = 6;
            this.funcionario.Name = "funcionario";
            this.funcionario.ReadOnly = true;
            this.funcionario.Width = 180;
            // 
            // codigo_cliente
            // 
            this.codigo_cliente.HeaderText = "Codigo Cliente";
            this.codigo_cliente.MinimumWidth = 6;
            this.codigo_cliente.Name = "codigo_cliente";
            this.codigo_cliente.ReadOnly = true;
            this.codigo_cliente.Width = 45;
            // 
            // cliente
            // 
            this.cliente.HeaderText = "Cliente";
            this.cliente.MinimumWidth = 6;
            this.cliente.Name = "cliente";
            this.cliente.ReadOnly = true;
            this.cliente.Width = 200;
            // 
            // FrmConsultaAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1002, 581);
            this.Controls.Add(this.DgConsultaAgenda);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbIdFuncionario);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbFuncionario);
            this.Name = "FrmConsultaAgenda";
            this.Text = "Consulta Agenda";
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.tbFuncionario, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.btnPesquisar, 0);
            this.Controls.SetChildIndex(this.tbIdFuncionario, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.dateTimePicker1, 0);
            this.Controls.SetChildIndex(this.DgConsultaAgenda, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DgConsultaAgenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbIdFuncionario;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbFuncionario;
        private System.Windows.Forms.DataGridView DgConsultaAgenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_agenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn horario;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_funcionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
    }
}
