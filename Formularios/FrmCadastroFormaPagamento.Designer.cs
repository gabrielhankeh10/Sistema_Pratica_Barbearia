
namespace Sistema__Renovo_Barber.Formularios
{
    partial class FrmCadastroFormaPagamento
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
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbForma = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbStatus
            // 
            this.tbStatus.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbStatus.Enabled = false;
            this.tbStatus.Location = new System.Drawing.Point(387, 64);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(89, 22);
            this.tbStatus.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Status";
            // 
            // tbForma
            // 
            this.tbForma.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbForma.Location = new System.Drawing.Point(186, 64);
            this.tbForma.Name = "tbForma";
            this.tbForma.Size = new System.Drawing.Size(155, 22);
            this.tbForma.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Forma";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(663, 524);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 49;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FrmCadastroFormaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(891, 581);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbForma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbStatus);
            this.Name = "FrmCadastroFormaPagamento";
            this.Text = "Cadastro Forma de Pagamento";
            this.Controls.SetChildIndex(this.tbCodigo, 0);
            this.Controls.SetChildIndex(this.tbDatCad, 0);
            this.Controls.SetChildIndex(this.tbDatUltAlt, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.tbStatus, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.tbForma, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbForma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalvar;
    }
}
