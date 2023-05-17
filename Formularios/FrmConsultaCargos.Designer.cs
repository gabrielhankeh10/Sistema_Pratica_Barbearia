
namespace Sistema__Renovo_Barber.Formularios
{
    partial class FrmConsultaCargos
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
            this.DgConsultaCargos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgConsultaCargos)).BeginInit();
            this.SuspendLayout();
            // 
            // DgConsultaCargos
            // 
            this.DgConsultaCargos.AllowUserToAddRows = false;
            this.DgConsultaCargos.AllowUserToDeleteRows = false;
            this.DgConsultaCargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgConsultaCargos.Location = new System.Drawing.Point(54, 72);
            this.DgConsultaCargos.Name = "DgConsultaCargos";
            this.DgConsultaCargos.ReadOnly = true;
            this.DgConsultaCargos.RowHeadersWidth = 51;
            this.DgConsultaCargos.RowTemplate.Height = 24;
            this.DgConsultaCargos.Size = new System.Drawing.Size(782, 437);
            this.DgConsultaCargos.TabIndex = 10;
            // 
            // FrmConsultaCargos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(891, 581);
            this.Controls.Add(this.DgConsultaCargos);
            this.Name = "FrmConsultaCargos";
            this.Text = "Consulta de Cargos";
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.btnAlterar, 0);
            this.Controls.SetChildIndex(this.btnIncluir, 0);
            this.Controls.SetChildIndex(this.tbPesquisar, 0);
            this.Controls.SetChildIndex(this.btnPesquisar, 0);
            this.Controls.SetChildIndex(this.DgConsultaCargos, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DgConsultaCargos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgConsultaCargos;
    }
}
