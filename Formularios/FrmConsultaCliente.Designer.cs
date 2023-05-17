
namespace Sistema__Renovo_Barber.Formularios
{
    partial class FrmConsultaCliente
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
            this.DgConsultaClientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgConsultaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // DgConsultaClientes
            // 
            this.DgConsultaClientes.AllowUserToAddRows = false;
            this.DgConsultaClientes.AllowUserToDeleteRows = false;
            this.DgConsultaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgConsultaClientes.Location = new System.Drawing.Point(54, 72);
            this.DgConsultaClientes.Name = "DgConsultaClientes";
            this.DgConsultaClientes.ReadOnly = true;
            this.DgConsultaClientes.RowHeadersWidth = 51;
            this.DgConsultaClientes.RowTemplate.Height = 24;
            this.DgConsultaClientes.Size = new System.Drawing.Size(782, 437);
            this.DgConsultaClientes.TabIndex = 9;
            // 
            // FrmConsultaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(891, 581);
            this.Controls.Add(this.DgConsultaClientes);
            this.Name = "FrmConsultaCliente";
            this.Text = "Consulta de Clientes";
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.btnAlterar, 0);
            this.Controls.SetChildIndex(this.btnIncluir, 0);
            this.Controls.SetChildIndex(this.tbPesquisar, 0);
            this.Controls.SetChildIndex(this.btnPesquisar, 0);
            this.Controls.SetChildIndex(this.DgConsultaClientes, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DgConsultaClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgConsultaClientes;
    }
}
