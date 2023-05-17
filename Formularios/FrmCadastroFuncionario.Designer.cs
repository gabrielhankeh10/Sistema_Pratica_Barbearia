
namespace Sistema__Renovo_Barber.Formularios
{
    partial class FrmCadastroFuncionario
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
            this.tbSexo = new System.Windows.Forms.TextBox();
            this.tbRG = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Sexo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.Text = "CPF";
            // 
            // tbCpfCnpj
            // 
            this.tbCpfCnpj.Mask = "###.###.###-##";
            this.tbCpfCnpj.Size = new System.Drawing.Size(125, 22);
            // 
            // tbSexo
            // 
            this.tbSexo.Location = new System.Drawing.Point(488, 64);
            this.tbSexo.Name = "tbSexo";
            this.tbSexo.Size = new System.Drawing.Size(60, 22);
            this.tbSexo.TabIndex = 44;
            // 
            // tbRG
            // 
            this.tbRG.Location = new System.Drawing.Point(735, 64);
            this.tbRG.Mask = "##.###.###-#";
            this.tbRG.Name = "tbRG";
            this.tbRG.Size = new System.Drawing.Size(100, 22);
            this.tbRG.TabIndex = 45;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(732, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 17);
            this.label12.TabIndex = 46;
            this.label12.Text = "RG";
            // 
            // Sexo
            // 
            this.Sexo.AutoSize = true;
            this.Sexo.Location = new System.Drawing.Point(485, 42);
            this.Sexo.Name = "Sexo";
            this.Sexo.Size = new System.Drawing.Size(39, 17);
            this.Sexo.TabIndex = 48;
            this.Sexo.Text = "Sexo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(678, 123);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 22);
            this.textBox1.TabIndex = 49;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(675, 101);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(46, 17);
            this.label20.TabIndex = 50;
            this.label20.Text = "Cargo";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(668, 524);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 51;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(49, 362);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(217, 22);
            this.textBox2.TabIndex = 52;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(46, 340);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 17);
            this.label18.TabIndex = 53;
            this.label18.Text = "Senha";
            // 
            // FrmCadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(891, 581);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Sexo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbRG);
            this.Controls.Add(this.tbSexo);
            this.Name = "FrmCadastroFuncionario";
            this.Text = "Cadastro de Funcionario";
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.tbNome, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.tbEmail, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.tbEndereco, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.tbNumero, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.tbBairro, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.tbComplemento, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.tbCidade, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.tbStatus, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            this.Controls.SetChildIndex(this.label17, 0);
            this.Controls.SetChildIndex(this.TbCEP, 0);
            this.Controls.SetChildIndex(this.tbCelular, 0);
            this.Controls.SetChildIndex(this.TbTelefone, 0);
            this.Controls.SetChildIndex(this.tbCpfCnpj, 0);
            this.Controls.SetChildIndex(this.tbDatNasc, 0);
            this.Controls.SetChildIndex(this.tbApelido, 0);
            this.Controls.SetChildIndex(this.label19, 0);
            this.Controls.SetChildIndex(this.tbSexo, 0);
            this.Controls.SetChildIndex(this.tbRG, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.Sexo, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.label20, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.textBox2, 0);
            this.Controls.SetChildIndex(this.label18, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSexo;
        private System.Windows.Forms.MaskedTextBox tbRG;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label Sexo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label18;
    }
}
