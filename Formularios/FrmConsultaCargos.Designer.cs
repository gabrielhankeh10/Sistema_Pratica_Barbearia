
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
            this.id_cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_criacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_ult_alteração = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgConsultaCargos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // DgConsultaCargos
            // 
            this.DgConsultaCargos.AllowUserToAddRows = false;
            this.DgConsultaCargos.AllowUserToDeleteRows = false;
            this.DgConsultaCargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgConsultaCargos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_cargo,
            this.status_cargo,
            this.cargo,
            this.data_criacao,
            this.data_ult_alteração});
            this.DgConsultaCargos.Location = new System.Drawing.Point(54, 72);
            this.DgConsultaCargos.MultiSelect = false;
            this.DgConsultaCargos.Name = "DgConsultaCargos";
            this.DgConsultaCargos.ReadOnly = true;
            this.DgConsultaCargos.RowHeadersWidth = 51;
            this.DgConsultaCargos.RowTemplate.Height = 24;
            this.DgConsultaCargos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgConsultaCargos.Size = new System.Drawing.Size(782, 437);
            this.DgConsultaCargos.TabIndex = 10;
            this.DgConsultaCargos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgConsultaCargos_CellMouseDoubleClick);
            this.DgConsultaCargos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DgConsultaCargos_KeyPress);
            // 
            // id_cargo
            // 
            this.id_cargo.HeaderText = "ID Cargo";
            this.id_cargo.MinimumWidth = 6;
            this.id_cargo.Name = "id_cargo";
            this.id_cargo.ReadOnly = true;
            this.id_cargo.Width = 125;
            // 
            // status_cargo
            // 
            this.status_cargo.HeaderText = "Status";
            this.status_cargo.MinimumWidth = 6;
            this.status_cargo.Name = "status_cargo";
            this.status_cargo.ReadOnly = true;
            this.status_cargo.Width = 125;
            // 
            // cargo
            // 
            this.cargo.HeaderText = "Cargo";
            this.cargo.MinimumWidth = 6;
            this.cargo.Name = "cargo";
            this.cargo.ReadOnly = true;
            this.cargo.Width = 125;
            // 
            // data_criacao
            // 
            this.data_criacao.HeaderText = "Data de Criação";
            this.data_criacao.MinimumWidth = 6;
            this.data_criacao.Name = "data_criacao";
            this.data_criacao.ReadOnly = true;
            this.data_criacao.Width = 125;
            // 
            // data_ult_alteração
            // 
            this.data_ult_alteração.HeaderText = "Ultima Alteração";
            this.data_ult_alteração.MinimumWidth = 6;
            this.data_ult_alteração.Name = "data_ult_alteração";
            this.data_ult_alteração.ReadOnly = true;
            this.data_ult_alteração.Width = 125;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_criacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_ult_alteração;
    }
}
