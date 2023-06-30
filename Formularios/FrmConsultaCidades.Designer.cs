
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
            this.DgConsultaCidades = new System.Windows.Forms.DataGridView();
            this.id_cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ddd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgConsultaCidades)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAlterar
            // 
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // DgConsultaCidades
            // 
            this.DgConsultaCidades.AllowUserToAddRows = false;
            this.DgConsultaCidades.AllowUserToDeleteRows = false;
            this.DgConsultaCidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgConsultaCidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_cidade,
            this.cidade,
            this.ddd,
            this.uf});
            this.DgConsultaCidades.Location = new System.Drawing.Point(54, 72);
            this.DgConsultaCidades.MultiSelect = false;
            this.DgConsultaCidades.Name = "DgConsultaCidades";
            this.DgConsultaCidades.ReadOnly = true;
            this.DgConsultaCidades.RowHeadersWidth = 51;
            this.DgConsultaCidades.RowTemplate.Height = 24;
            this.DgConsultaCidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgConsultaCidades.Size = new System.Drawing.Size(782, 437);
            this.DgConsultaCidades.TabIndex = 9;
            this.DgConsultaCidades.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgConsultaCidades_CellMouseDoubleClick);
            this.DgConsultaCidades.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DgConsultaCidades_KeyPress);
            // 
            // id_cidade
            // 
            this.id_cidade.HeaderText = "ID Cidade";
            this.id_cidade.MinimumWidth = 6;
            this.id_cidade.Name = "id_cidade";
            this.id_cidade.ReadOnly = true;
            this.id_cidade.Width = 125;
            // 
            // cidade
            // 
            this.cidade.HeaderText = "Cidade";
            this.cidade.MinimumWidth = 6;
            this.cidade.Name = "cidade";
            this.cidade.ReadOnly = true;
            this.cidade.Width = 125;
            // 
            // ddd
            // 
            this.ddd.HeaderText = "DDD";
            this.ddd.MinimumWidth = 6;
            this.ddd.Name = "ddd";
            this.ddd.ReadOnly = true;
            this.ddd.Width = 125;
            // 
            // uf
            // 
            this.uf.HeaderText = "UF";
            this.uf.MinimumWidth = 6;
            this.uf.Name = "uf";
            this.uf.ReadOnly = true;
            this.uf.Width = 125;
            // 
            // FrmConsultaCidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(891, 581);
            this.Controls.Add(this.DgConsultaCidades);
            this.Name = "FrmConsultaCidades";
            this.Text = "Consulta de Cidades";
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.btnAlterar, 0);
            this.Controls.SetChildIndex(this.tbPesquisar, 0);
            this.Controls.SetChildIndex(this.btnPesquisar, 0);
            this.Controls.SetChildIndex(this.btnIncluir, 0);
            this.Controls.SetChildIndex(this.DgConsultaCidades, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DgConsultaCidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgConsultaCidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ddd;
        private System.Windows.Forms.DataGridViewTextBoxColumn uf;
    }
}
