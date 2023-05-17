
namespace Sistema__Renovo_Barber.Formularios
{
    partial class FrmConsultaFornecedor
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
            this.DgConsultaFornecedor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgConsultaFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIncluir
            // 
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // DgConsultaFornecedor
            // 
            this.DgConsultaFornecedor.AllowUserToAddRows = false;
            this.DgConsultaFornecedor.AllowUserToDeleteRows = false;
            this.DgConsultaFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgConsultaFornecedor.Location = new System.Drawing.Point(53, 72);
            this.DgConsultaFornecedor.Name = "DgConsultaFornecedor";
            this.DgConsultaFornecedor.ReadOnly = true;
            this.DgConsultaFornecedor.RowHeadersWidth = 51;
            this.DgConsultaFornecedor.RowTemplate.Height = 24;
            this.DgConsultaFornecedor.Size = new System.Drawing.Size(782, 437);
            this.DgConsultaFornecedor.TabIndex = 10;
            this.DgConsultaFornecedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgConsultaClientes_CellContentClick);
            // 
            // FrmConsultaFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(891, 581);
            this.Controls.Add(this.DgConsultaFornecedor);
            this.Name = "FrmConsultaFornecedor";
            this.Text = "Consulta de Fornecedor";
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.btnAlterar, 0);
            this.Controls.SetChildIndex(this.btnIncluir, 0);
            this.Controls.SetChildIndex(this.tbPesquisar, 0);
            this.Controls.SetChildIndex(this.btnPesquisar, 0);
            this.Controls.SetChildIndex(this.DgConsultaFornecedor, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DgConsultaFornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgConsultaFornecedor;
    }
}
