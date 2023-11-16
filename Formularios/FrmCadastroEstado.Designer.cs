
namespace Sistema__Renovo_Barber.Formularios
{
    partial class FrmCadastroEstado
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCodigoPais = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbUf = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.Label();
            this.tbEstado = new System.Windows.Forms.TextBox();
            this.tbPais = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPesquisarPais = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.Text = "Codigo Estado";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Margin = new System.Windows.Forms.Padding(4);
            // 
            // tbDatCad
            // 
            this.tbDatCad.Margin = new System.Windows.Forms.Padding(4);
            // 
            // tbDatUltAlt
            // 
            this.tbDatUltAlt.Margin = new System.Windows.Forms.Padding(4);
            // 
            // btnSair
            // 
            this.btnSair.TabIndex = 4;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(669, 524);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Codigo Pais";
            // 
            // tbCodigoPais
            // 
            this.tbCodigoPais.Enabled = false;
            this.tbCodigoPais.Location = new System.Drawing.Point(49, 118);
            this.tbCodigoPais.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCodigoPais.Name = "tbCodigoPais";
            this.tbCodigoPais.Size = new System.Drawing.Size(80, 22);
            this.tbCodigoPais.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(468, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "UF";
            // 
            // tbUf
            // 
            this.tbUf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbUf.Location = new System.Drawing.Point(472, 64);
            this.tbUf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbUf.Name = "tbUf";
            this.tbUf.Size = new System.Drawing.Size(76, 22);
            this.tbUf.TabIndex = 1;
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(187, 41);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(52, 17);
            this.Nome.TabIndex = 16;
            this.Nome.Text = "Estado";
            // 
            // tbEstado
            // 
            this.tbEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbEstado.Location = new System.Drawing.Point(187, 64);
            this.tbEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEstado.Name = "tbEstado";
            this.tbEstado.Size = new System.Drawing.Size(255, 22);
            this.tbEstado.TabIndex = 0;
            // 
            // tbPais
            // 
            this.tbPais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbPais.Enabled = false;
            this.tbPais.Location = new System.Drawing.Point(581, 64);
            this.tbPais.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPais.Name = "tbPais";
            this.tbPais.Size = new System.Drawing.Size(136, 22);
            this.tbPais.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(578, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Pais";
            // 
            // btnPesquisarPais
            // 
            this.btnPesquisarPais.Location = new System.Drawing.Point(744, 63);
            this.btnPesquisarPais.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisarPais.Name = "btnPesquisarPais";
            this.btnPesquisarPais.Size = new System.Drawing.Size(91, 23);
            this.btnPesquisarPais.TabIndex = 2;
            this.btnPesquisarPais.Text = "Pesquisar";
            this.btnPesquisarPais.UseVisualStyleBackColor = true;
            this.btnPesquisarPais.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmCadastroEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(891, 581);
            this.Controls.Add(this.btnPesquisarPais);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPais);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbCodigoPais);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbUf);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.tbEstado);
            this.Controls.Add(this.btnSalvar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCadastroEstado";
            this.Text = "Cadastro de Estados";
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.tbCodigo, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.tbDatCad, 0);
            this.Controls.SetChildIndex(this.tbDatUltAlt, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.tbEstado, 0);
            this.Controls.SetChildIndex(this.Nome, 0);
            this.Controls.SetChildIndex(this.tbUf, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.tbCodigoPais, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.tbPais, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.btnPesquisarPais, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCodigoPais;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbUf;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.TextBox tbEstado;
        private System.Windows.Forms.TextBox tbPais;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPesquisarPais;
    }
}
