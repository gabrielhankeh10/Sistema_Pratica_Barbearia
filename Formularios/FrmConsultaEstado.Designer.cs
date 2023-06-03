
namespace Sistema__Renovo_Barber.Formularios
{
    partial class FrmConsultaEstado
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
            this.id_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgConsultaEstado)).BeginInit();
            this.SuspendLayout();
            // 
            // DgConsultaEstado
            // 
            this.DgConsultaEstado.AllowUserToAddRows = false;
            this.DgConsultaEstado.AllowUserToDeleteRows = false;
            this.DgConsultaEstado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgConsultaEstado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_estado,
            this.nome,
            this.uf,
            this.pais});
            this.DgConsultaEstado.Location = new System.Drawing.Point(53, 72);
            this.DgConsultaEstado.Name = "DgConsultaEstado";
            this.DgConsultaEstado.ReadOnly = true;
            this.DgConsultaEstado.RowHeadersWidth = 51;
            this.DgConsultaEstado.RowTemplate.Height = 24;
            this.DgConsultaEstado.Size = new System.Drawing.Size(782, 437);
            this.DgConsultaEstado.TabIndex = 8;
            // 
            // id_estado
            // 
            this.id_estado.HeaderText = "ID Estado";
            this.id_estado.MinimumWidth = 6;
            this.id_estado.Name = "id_estado";
            this.id_estado.ReadOnly = true;
            this.id_estado.Width = 125;
            // 
            // nome
            // 
            this.nome.HeaderText = "Estado";
            this.nome.MinimumWidth = 6;
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 125;
            // 
            // uf
            // 
            this.uf.HeaderText = "UF";
            this.uf.MinimumWidth = 6;
            this.uf.Name = "uf";
            this.uf.ReadOnly = true;
            this.uf.Width = 125;
            // 
            // pais
            // 
            this.pais.HeaderText = "Pais";
            this.pais.MinimumWidth = 6;
            this.pais.Name = "pais";
            this.pais.ReadOnly = true;
            this.pais.Width = 125;
            // 
            // FrmConsultaEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(891, 581);
            this.Controls.Add(this.DgConsultaEstado);
            this.Name = "FrmConsultaEstado";
            this.Text = "Consulta de Estado";
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.btnAlterar, 0);
            this.Controls.SetChildIndex(this.tbPesquisar, 0);
            this.Controls.SetChildIndex(this.btnPesquisar, 0);
            this.Controls.SetChildIndex(this.btnIncluir, 0);
            this.Controls.SetChildIndex(this.DgConsultaEstado, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DgConsultaEstado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgConsultaEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn uf;
        private System.Windows.Forms.DataGridViewTextBoxColumn pais;
    }
}
