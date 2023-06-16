
namespace Sistema__Renovo_Barber
{
    partial class FrmCadastroPaises
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
            this.tbPais = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.Label();
            this.tbSigla = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDDI = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbPais
            // 
            this.tbPais.Location = new System.Drawing.Point(187, 64);
            this.tbPais.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPais.Name = "tbPais";
            this.tbPais.Size = new System.Drawing.Size(255, 22);
            this.tbPais.TabIndex = 7;
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(187, 41);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(35, 17);
            this.Nome.TabIndex = 8;
            this.Nome.Text = "Pais";
            // 
            // tbSigla
            // 
            this.tbSigla.Location = new System.Drawing.Point(473, 64);
            this.tbSigla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSigla.Name = "tbSigla";
            this.tbSigla.Size = new System.Drawing.Size(76, 22);
            this.tbSigla.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(469, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sigla";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(580, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "DDI";
            // 
            // tbDDI
            // 
            this.tbDDI.Location = new System.Drawing.Point(583, 64);
            this.tbDDI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDDI.Name = "tbDDI";
            this.tbDDI.Size = new System.Drawing.Size(76, 22);
            this.tbDDI.TabIndex = 11;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(667, 524);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FrmCadastroPaises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(891, 581);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbDDI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbSigla);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.tbPais);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCadastroPaises";
            this.Text = "Cadastro de Paises";
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.tbCodigo, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.tbPais, 0);
            this.Controls.SetChildIndex(this.Nome, 0);
            this.Controls.SetChildIndex(this.tbSigla, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.tbDDI, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPais;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.TextBox tbSigla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDDI;
        private System.Windows.Forms.Button btnSalvar;
    }
}
