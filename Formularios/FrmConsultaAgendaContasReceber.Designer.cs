
namespace Sistema__Renovo_Barber.Formularios
{
    partial class FrmConsultaAgendaContasReceber
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
            this.DgConsultaAgenda = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.id_agenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo_funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_forma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgConsultaAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // DgConsultaAgenda
            // 
            this.DgConsultaAgenda.AllowUserToAddRows = false;
            this.DgConsultaAgenda.AllowUserToDeleteRows = false;
            this.DgConsultaAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgConsultaAgenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_agenda,
            this.data,
            this.horario,
            this.codigo_funcionario,
            this.funcionario,
            this.codigo_cliente,
            this.cliente,
            this.id_forma,
            this.forma});
            this.DgConsultaAgenda.Location = new System.Drawing.Point(32, 89);
            this.DgConsultaAgenda.MultiSelect = false;
            this.DgConsultaAgenda.Name = "DgConsultaAgenda";
            this.DgConsultaAgenda.ReadOnly = true;
            this.DgConsultaAgenda.RowHeadersWidth = 51;
            this.DgConsultaAgenda.RowTemplate.Height = 24;
            this.DgConsultaAgenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgConsultaAgenda.Size = new System.Drawing.Size(803, 410);
            this.DgConsultaAgenda.TabIndex = 32;
            this.DgConsultaAgenda.DoubleClick += new System.EventHandler(this.DgConsultaCargos_DoubleClick);
            this.DgConsultaAgenda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgConsultaAgenda_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Data de Agenda";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(32, 46);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(128, 22);
            this.dateTimePicker1.TabIndex = 31;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
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
            // horario
            // 
            this.horario.HeaderText = "Horario";
            this.horario.MinimumWidth = 6;
            this.horario.Name = "horario";
            this.horario.ReadOnly = true;
            this.horario.Width = 125;
            // 
            // codigo_funcionario
            // 
            this.codigo_funcionario.HeaderText = "Codigo Funcionario";
            this.codigo_funcionario.MinimumWidth = 6;
            this.codigo_funcionario.Name = "codigo_funcionario";
            this.codigo_funcionario.ReadOnly = true;
            this.codigo_funcionario.Width = 125;
            // 
            // funcionario
            // 
            this.funcionario.HeaderText = "Nome Funcionario";
            this.funcionario.MinimumWidth = 6;
            this.funcionario.Name = "funcionario";
            this.funcionario.ReadOnly = true;
            this.funcionario.Width = 200;
            // 
            // codigo_cliente
            // 
            this.codigo_cliente.HeaderText = "Codigo Cliente";
            this.codigo_cliente.MinimumWidth = 6;
            this.codigo_cliente.Name = "codigo_cliente";
            this.codigo_cliente.ReadOnly = true;
            this.codigo_cliente.Width = 125;
            // 
            // cliente
            // 
            this.cliente.HeaderText = "Cliente";
            this.cliente.MinimumWidth = 6;
            this.cliente.Name = "cliente";
            this.cliente.ReadOnly = true;
            this.cliente.Width = 200;
            // 
            // id_forma
            // 
            this.id_forma.HeaderText = "Codigo Forma";
            this.id_forma.MinimumWidth = 6;
            this.id_forma.Name = "id_forma";
            this.id_forma.ReadOnly = true;
            this.id_forma.Width = 125;
            // 
            // forma
            // 
            this.forma.HeaderText = "Forma de Pagamento";
            this.forma.MinimumWidth = 6;
            this.forma.Name = "forma";
            this.forma.ReadOnly = true;
            this.forma.Width = 125;
            // 
            // FrmConsultaAgendaContasReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(891, 581);
            this.Controls.Add(this.DgConsultaAgenda);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Name = "FrmConsultaAgendaContasReceber";
            this.Text = "Consulta Agenda Receber";
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.dateTimePicker1, 0);
            this.Controls.SetChildIndex(this.DgConsultaAgenda, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DgConsultaAgenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DgConsultaAgenda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_agenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn horario;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_funcionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_forma;
        private System.Windows.Forms.DataGridViewTextBoxColumn forma;
    }
}
