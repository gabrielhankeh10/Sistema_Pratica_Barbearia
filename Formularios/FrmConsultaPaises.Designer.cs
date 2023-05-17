
namespace Sistema__Renovo_Barber
{
    partial class FrmConsultaPaises
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
            this.DgConsultaPais = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgConsultaPais)).BeginInit();
            this.SuspendLayout();
            // 
            // DgConsultaPais
            // 
            this.DgConsultaPais.AllowUserToAddRows = false;
            this.DgConsultaPais.AllowUserToDeleteRows = false;
            this.DgConsultaPais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgConsultaPais.Location = new System.Drawing.Point(51, 73);
            this.DgConsultaPais.Name = "DgConsultaPais";
            this.DgConsultaPais.ReadOnly = true;
            this.DgConsultaPais.RowHeadersWidth = 51;
            this.DgConsultaPais.RowTemplate.Height = 24;
            this.DgConsultaPais.Size = new System.Drawing.Size(784, 437);
            this.DgConsultaPais.TabIndex = 7;
            // 
            // FrmConsultaPaises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(891, 581);
            this.Controls.Add(this.DgConsultaPais);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmConsultaPaises";
            this.Text = "Consulta de Pais";
            this.Controls.SetChildIndex(this.btnIncluir, 0);
            this.Controls.SetChildIndex(this.DgConsultaPais, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DgConsultaPais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgConsultaPais;
    }
}
