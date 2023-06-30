
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
            this.id_pais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sigla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ddi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgConsultaPais)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // DgConsultaPais
            // 
            this.DgConsultaPais.AllowUserToAddRows = false;
            this.DgConsultaPais.AllowUserToDeleteRows = false;
            this.DgConsultaPais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgConsultaPais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_pais,
            this.nome,
            this.sigla,
            this.ddi});
            this.DgConsultaPais.Location = new System.Drawing.Point(51, 72);
            this.DgConsultaPais.Name = "DgConsultaPais";
            this.DgConsultaPais.ReadOnly = true;
            this.DgConsultaPais.RowHeadersWidth = 51;
            this.DgConsultaPais.RowTemplate.Height = 24;
            this.DgConsultaPais.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgConsultaPais.Size = new System.Drawing.Size(784, 437);
            this.DgConsultaPais.TabIndex = 7;
            this.DgConsultaPais.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgConsultaPais_CellContentClick);
            this.DgConsultaPais.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgConsultaPais_CellContentDoubleClick);
            this.DgConsultaPais.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DgConsultaPais_KeyPress);
            // 
            // id_pais
            // 
            this.id_pais.HeaderText = "Codigo Pais";
            this.id_pais.MinimumWidth = 6;
            this.id_pais.Name = "id_pais";
            this.id_pais.ReadOnly = true;
            this.id_pais.Width = 125;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.MinimumWidth = 6;
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 125;
            // 
            // sigla
            // 
            this.sigla.HeaderText = "Sigla";
            this.sigla.MinimumWidth = 6;
            this.sigla.Name = "sigla";
            this.sigla.ReadOnly = true;
            this.sigla.Width = 125;
            // 
            // ddi
            // 
            this.ddi.HeaderText = "DDI";
            this.ddi.MinimumWidth = 6;
            this.ddi.Name = "ddi";
            this.ddi.ReadOnly = true;
            this.ddi.Width = 125;
            // 
            // FrmConsultaPaises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(891, 581);
            this.Controls.Add(this.DgConsultaPais);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmConsultaPaises";
            this.Text = "Consulta de Pais";
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.btnAlterar, 0);
            this.Controls.SetChildIndex(this.tbPesquisar, 0);
            this.Controls.SetChildIndex(this.btnPesquisar, 0);
            this.Controls.SetChildIndex(this.btnIncluir, 0);
            this.Controls.SetChildIndex(this.DgConsultaPais, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DgConsultaPais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgConsultaPais;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pais;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn sigla;
        private System.Windows.Forms.DataGridViewTextBoxColumn ddi;
    }
}
