
namespace Sistema__Renovo_Barber.Formularios
{
    partial class FrmConsultaFuncionario
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
            this.DgConsultaFuncionario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgConsultaFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // DgConsultaFuncionario
            // 
            this.DgConsultaFuncionario.AllowUserToAddRows = false;
            this.DgConsultaFuncionario.AllowUserToDeleteRows = false;
            this.DgConsultaFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgConsultaFuncionario.Location = new System.Drawing.Point(54, 72);
            this.DgConsultaFuncionario.Name = "DgConsultaFuncionario";
            this.DgConsultaFuncionario.ReadOnly = true;
            this.DgConsultaFuncionario.RowHeadersWidth = 51;
            this.DgConsultaFuncionario.RowTemplate.Height = 24;
            this.DgConsultaFuncionario.Size = new System.Drawing.Size(782, 437);
            this.DgConsultaFuncionario.TabIndex = 10;
            // 
            // FrmConsultaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(891, 581);
            this.Controls.Add(this.DgConsultaFuncionario);
            this.Name = "FrmConsultaFuncionario";
            this.Text = "Consulta de Funcionarios";
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.btnAlterar, 0);
            this.Controls.SetChildIndex(this.btnIncluir, 0);
            this.Controls.SetChildIndex(this.tbPesquisar, 0);
            this.Controls.SetChildIndex(this.btnPesquisar, 0);
            this.Controls.SetChildIndex(this.DgConsultaFuncionario, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DgConsultaFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgConsultaFuncionario;
    }
}
