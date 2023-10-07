
namespace Sistema__Renovo_Barber.Formularios
{
    partial class FrmAgendamento
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
            this.label4 = new System.Windows.Forms.Label();
            this.tbFuncionario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCodigoCliente = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCliente = new System.Windows.Forms.TextBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.lbHorario = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbIdServico = new System.Windows.Forms.TextBox();
            this.btnPesquisaServico = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNomeServico = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(324, 50);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(128, 22);
            this.dateTimePicker1.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Data de Agenda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Codigo";
            // 
            // tbIdFuncionario
            // 
            this.tbIdFuncionario.Location = new System.Drawing.Point(28, 48);
            this.tbIdFuncionario.Name = "tbIdFuncionario";
            this.tbIdFuncionario.Size = new System.Drawing.Size(69, 22);
            this.tbIdFuncionario.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Funcionario";
            // 
            // tbFuncionario
            // 
            this.tbFuncionario.Location = new System.Drawing.Point(119, 49);
            this.tbFuncionario.Name = "tbFuncionario";
            this.tbFuncionario.Size = new System.Drawing.Size(175, 22);
            this.tbFuncionario.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 43;
            this.label3.Text = "Codigo";
            // 
            // tbCodigoCliente
            // 
            this.tbCodigoCliente.Location = new System.Drawing.Point(28, 110);
            this.tbCodigoCliente.Name = "tbCodigoCliente";
            this.tbCodigoCliente.Size = new System.Drawing.Size(69, 22);
            this.tbCodigoCliente.TabIndex = 42;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 111);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 41;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "Cliente";
            // 
            // tbCliente
            // 
            this.tbCliente.Location = new System.Drawing.Point(119, 111);
            this.tbCliente.Name = "tbCliente";
            this.tbCliente.Size = new System.Drawing.Size(175, 22);
            this.tbCliente.TabIndex = 39;
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(573, 524);
            this.btnGerar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(75, 23);
            this.btnGerar.TabIndex = 44;
            this.btnGerar.Text = "Agendar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // lbHorario
            // 
            this.lbHorario.AutoSize = true;
            this.lbHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHorario.Location = new System.Drawing.Point(458, 48);
            this.lbHorario.Name = "lbHorario";
            this.lbHorario.Size = new System.Drawing.Size(154, 25);
            this.lbHorario.TabIndex = 45;
            this.lbHorario.Text = "Data de Agenda";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(667, 524);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 46;
            this.button2.Text = "Finalizar ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 51;
            this.label6.Text = "Codigo";
            // 
            // tbIdServico
            // 
            this.tbIdServico.Location = new System.Drawing.Point(28, 170);
            this.tbIdServico.Name = "tbIdServico";
            this.tbIdServico.Size = new System.Drawing.Size(69, 22);
            this.tbIdServico.TabIndex = 50;
            // 
            // btnPesquisaServico
            // 
            this.btnPesquisaServico.Location = new System.Drawing.Point(313, 171);
            this.btnPesquisaServico.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisaServico.Name = "btnPesquisaServico";
            this.btnPesquisaServico.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisaServico.TabIndex = 49;
            this.btnPesquisaServico.Text = "Pesquisar";
            this.btnPesquisaServico.UseVisualStyleBackColor = true;
            this.btnPesquisaServico.Click += new System.EventHandler(this.btnPesquisaServico_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(116, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 48;
            this.label7.Text = "Serviço";
            // 
            // tbNomeServico
            // 
            this.tbNomeServico.Location = new System.Drawing.Point(119, 171);
            this.tbNomeServico.Name = "tbNomeServico";
            this.tbNomeServico.Size = new System.Drawing.Size(175, 22);
            this.tbNomeServico.TabIndex = 47;
            // 
            // FrmAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(891, 581);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbIdServico);
            this.Controls.Add(this.btnPesquisaServico);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbNomeServico);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbHorario);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCodigoCliente);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbCliente);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbIdFuncionario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbFuncionario);
            this.Name = "FrmAgendamento";
            this.Text = "Agendamento";
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.tbFuncionario, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.tbIdFuncionario, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.dateTimePicker1, 0);
            this.Controls.SetChildIndex(this.tbCliente, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.tbCodigoCliente, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.btnGerar, 0);
            this.Controls.SetChildIndex(this.lbHorario, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.tbNomeServico, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.btnPesquisaServico, 0);
            this.Controls.SetChildIndex(this.tbIdServico, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbIdFuncionario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbFuncionario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCodigoCliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCliente;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Label lbHorario;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbIdServico;
        private System.Windows.Forms.Button btnPesquisaServico;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNomeServico;
    }
}
