
namespace Sistema__Renovo_Barber.Formularios
{
    partial class FrmConsultaServicos
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
            this.DgConsultaServicos = new System.Windows.Forms.DataGridView();
            this.id_servico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_servico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_criacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_ult_alteracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgConsultaServicos)).BeginInit();
            this.SuspendLayout();
            // 
            // DgConsultaServicos
            // 
            this.DgConsultaServicos.AllowUserToAddRows = false;
            this.DgConsultaServicos.AllowUserToDeleteRows = false;
            this.DgConsultaServicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgConsultaServicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_servico,
            this.descricao,
            this.status_servico,
            this.duracao,
            this.valor,
            this.data_criacao,
            this.data_ult_alteracao});
            this.DgConsultaServicos.Location = new System.Drawing.Point(53, 72);
            this.DgConsultaServicos.MultiSelect = false;
            this.DgConsultaServicos.Name = "DgConsultaServicos";
            this.DgConsultaServicos.ReadOnly = true;
            this.DgConsultaServicos.RowHeadersWidth = 51;
            this.DgConsultaServicos.RowTemplate.Height = 24;
            this.DgConsultaServicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgConsultaServicos.Size = new System.Drawing.Size(784, 437);
            this.DgConsultaServicos.TabIndex = 8;
            // 
            // id_servico
            // 
            this.id_servico.HeaderText = "ID Servico";
            this.id_servico.MinimumWidth = 6;
            this.id_servico.Name = "id_servico";
            this.id_servico.ReadOnly = true;
            this.id_servico.Width = 125;
            // 
            // descricao
            // 
            this.descricao.HeaderText = "Serviço";
            this.descricao.MinimumWidth = 6;
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            this.descricao.Width = 125;
            // 
            // status_servico
            // 
            this.status_servico.HeaderText = "Status";
            this.status_servico.MinimumWidth = 6;
            this.status_servico.Name = "status_servico";
            this.status_servico.ReadOnly = true;
            this.status_servico.Width = 125;
            // 
            // duracao
            // 
            this.duracao.HeaderText = "Duração";
            this.duracao.MinimumWidth = 6;
            this.duracao.Name = "duracao";
            this.duracao.ReadOnly = true;
            this.duracao.Width = 125;
            // 
            // valor
            // 
            this.valor.HeaderText = "Valor";
            this.valor.MinimumWidth = 6;
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            this.valor.Width = 125;
            // 
            // data_criacao
            // 
            this.data_criacao.HeaderText = "Data de Criação";
            this.data_criacao.MinimumWidth = 6;
            this.data_criacao.Name = "data_criacao";
            this.data_criacao.ReadOnly = true;
            this.data_criacao.Width = 125;
            // 
            // data_ult_alteracao
            // 
            this.data_ult_alteracao.HeaderText = "Ultima Alteração";
            this.data_ult_alteracao.MinimumWidth = 6;
            this.data_ult_alteracao.Name = "data_ult_alteracao";
            this.data_ult_alteracao.ReadOnly = true;
            this.data_ult_alteracao.Width = 125;
            // 
            // FrmConsultaServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(891, 581);
            this.Controls.Add(this.DgConsultaServicos);
            this.Name = "FrmConsultaServicos";
            this.Text = "Consulta de Serviços";
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.btnAlterar, 0);
            this.Controls.SetChildIndex(this.btnIncluir, 0);
            this.Controls.SetChildIndex(this.tbPesquisar, 0);
            this.Controls.SetChildIndex(this.btnPesquisar, 0);
            this.Controls.SetChildIndex(this.DgConsultaServicos, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DgConsultaServicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgConsultaServicos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_servico;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_servico;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracao;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_criacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_ult_alteracao;
    }
}
