
namespace Sistema__Renovo_Barber.Formularios
{
    partial class FrmConsultaCidades
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
            this.DgConsultaEstado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgConsultaEstado)).BeginInit();
            this.SuspendLayout();
            // 
            // DgConsultaEstado
            // 
            this.DgConsultaEstado.AllowUserToAddRows = false;
            this.DgConsultaEstado.AllowUserToDeleteRows = false;
            this.DgConsultaEstado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgConsultaEstado.Location = new System.Drawing.Point(54, 72);
            this.DgConsultaEstado.Name = "DgConsultaEstado";
            this.DgConsultaEstado.ReadOnly = true;
            this.DgConsultaEstado.RowHeadersWidth = 51;
            this.DgConsultaEstado.RowTemplate.Height = 24;
            this.DgConsultaEstado.Size = new System.Drawing.Size(782, 437);
            this.DgConsultaEstado.TabIndex = 9;
            // 
            // FrmConsultaCidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(891, 581);
            this.Controls.Add(this.DgConsultaEstado);
            this.Name = "FrmConsultaCidades";
            this.Text = "Consulta de Cidades";
            this.Controls.SetChildIndex(this.btnIncluir, 0);
            this.Controls.SetChildIndex(this.DgConsultaEstado, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DgConsultaEstado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgConsultaEstado;
    }
}
