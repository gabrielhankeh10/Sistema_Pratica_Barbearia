
namespace Sistema__Renovo_Barber.Formularios
{
    partial class FrmCadastroCidades
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
            this.label5 = new System.Windows.Forms.Label();
            this.tbCodEstado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDDD = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.Label();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tbEstado = new System.Windows.Forms.TextBox();
            this.btnPesquisarEstado = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.Text = "Codigo Cidade";
            // 
            // btnSair
            // 
            this.btnSair.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Codigo Estado";
            // 
            // tbCodEstado
            // 
            this.tbCodEstado.Enabled = false;
            this.tbCodEstado.Location = new System.Drawing.Point(49, 125);
            this.tbCodEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCodEstado.Name = "tbCodEstado";
            this.tbCodEstado.Size = new System.Drawing.Size(76, 22);
            this.tbCodEstado.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(468, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "DDD";
            // 
            // tbDDD
            // 
            this.tbDDD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbDDD.Location = new System.Drawing.Point(472, 64);
            this.tbDDD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDDD.Name = "tbDDD";
            this.tbDDD.Size = new System.Drawing.Size(76, 22);
            this.tbDDD.TabIndex = 1;
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(186, 41);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(52, 17);
            this.Nome.TabIndex = 14;
            this.Nome.Text = "Cidade";
            // 
            // tbCidade
            // 
            this.tbCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbCidade.Location = new System.Drawing.Point(186, 64);
            this.tbCidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(255, 22);
            this.tbCidade.TabIndex = 0;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(671, 524);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // tbEstado
            // 
            this.tbEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbEstado.Enabled = false;
            this.tbEstado.Location = new System.Drawing.Point(578, 64);
            this.tbEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEstado.Name = "tbEstado";
            this.tbEstado.Size = new System.Drawing.Size(142, 22);
            this.tbEstado.TabIndex = 20;
            // 
            // btnPesquisarEstado
            // 
            this.btnPesquisarEstado.Location = new System.Drawing.Point(744, 63);
            this.btnPesquisarEstado.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisarEstado.Name = "btnPesquisarEstado";
            this.btnPesquisarEstado.Size = new System.Drawing.Size(91, 23);
            this.btnPesquisarEstado.TabIndex = 2;
            this.btnPesquisarEstado.Text = "Pesquisar";
            this.btnPesquisarEstado.UseVisualStyleBackColor = true;
            this.btnPesquisarEstado.Click += new System.EventHandler(this.btnPesquisarEstado_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(575, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Estado";
            // 
            // FrmCadastroCidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(891, 581);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnPesquisarEstado);
            this.Controls.Add(this.tbEstado);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbCodEstado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbDDD);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.tbCidade);
            this.Name = "FrmCadastroCidades";
            this.Text = "Cadastro de Cidades";
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.tbCodigo, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.tbDatCad, 0);
            this.Controls.SetChildIndex(this.tbDatUltAlt, 0);
            this.Controls.SetChildIndex(this.tbCidade, 0);
            this.Controls.SetChildIndex(this.Nome, 0);
            this.Controls.SetChildIndex(this.tbDDD, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.tbCodEstado, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.tbEstado, 0);
            this.Controls.SetChildIndex(this.btnPesquisarEstado, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCodEstado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDDD;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox tbEstado;
        private System.Windows.Forms.Button btnPesquisarEstado;
        private System.Windows.Forms.Label label6;
    }
}
