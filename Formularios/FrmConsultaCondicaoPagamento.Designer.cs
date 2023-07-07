
namespace Sistema__Renovo_Barber.Formularios
{
    partial class FrmConsultaCondicaoPagamento
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
            this.DgConsultaCondicaoPagamento = new System.Windows.Forms.DataGridView();
            this.id_condicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.multa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_criacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_ult_alteracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgConsultaCondicaoPagamento)).BeginInit();
            this.SuspendLayout();
            // 
            // DgConsultaCondicaoPagamento
            // 
            this.DgConsultaCondicaoPagamento.AllowUserToAddRows = false;
            this.DgConsultaCondicaoPagamento.AllowUserToDeleteRows = false;
            this.DgConsultaCondicaoPagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgConsultaCondicaoPagamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_condicao,
            this.condicao,
            this.parcelas,
            this.taxa,
            this.multa,
            this.desconto,
            this.data_criacao,
            this.data_ult_alteracao});
            this.DgConsultaCondicaoPagamento.Location = new System.Drawing.Point(54, 72);
            this.DgConsultaCondicaoPagamento.MultiSelect = false;
            this.DgConsultaCondicaoPagamento.Name = "DgConsultaCondicaoPagamento";
            this.DgConsultaCondicaoPagamento.ReadOnly = true;
            this.DgConsultaCondicaoPagamento.RowHeadersWidth = 51;
            this.DgConsultaCondicaoPagamento.RowTemplate.Height = 24;
            this.DgConsultaCondicaoPagamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgConsultaCondicaoPagamento.Size = new System.Drawing.Size(782, 437);
            this.DgConsultaCondicaoPagamento.TabIndex = 11;
            // 
            // id_condicao
            // 
            this.id_condicao.HeaderText = "ID Condição";
            this.id_condicao.MinimumWidth = 6;
            this.id_condicao.Name = "id_condicao";
            this.id_condicao.ReadOnly = true;
            this.id_condicao.Width = 125;
            // 
            // condicao
            // 
            this.condicao.HeaderText = "Condição";
            this.condicao.MinimumWidth = 6;
            this.condicao.Name = "condicao";
            this.condicao.ReadOnly = true;
            this.condicao.Width = 125;
            // 
            // parcelas
            // 
            this.parcelas.HeaderText = "Parcelas";
            this.parcelas.MinimumWidth = 6;
            this.parcelas.Name = "parcelas";
            this.parcelas.ReadOnly = true;
            this.parcelas.Width = 125;
            // 
            // taxa
            // 
            this.taxa.HeaderText = "Taxa";
            this.taxa.MinimumWidth = 6;
            this.taxa.Name = "taxa";
            this.taxa.ReadOnly = true;
            this.taxa.Width = 125;
            // 
            // multa
            // 
            this.multa.HeaderText = "Multa";
            this.multa.MinimumWidth = 6;
            this.multa.Name = "multa";
            this.multa.ReadOnly = true;
            this.multa.Width = 125;
            // 
            // desconto
            // 
            this.desconto.HeaderText = "Desconto";
            this.desconto.MinimumWidth = 6;
            this.desconto.Name = "desconto";
            this.desconto.ReadOnly = true;
            this.desconto.Width = 125;
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
            // FrmConsultaCondicaoPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(891, 581);
            this.Controls.Add(this.DgConsultaCondicaoPagamento);
            this.Name = "FrmConsultaCondicaoPagamento";
            this.Text = "Consulta Condição de Pagamento";
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.btnAlterar, 0);
            this.Controls.SetChildIndex(this.btnIncluir, 0);
            this.Controls.SetChildIndex(this.tbPesquisar, 0);
            this.Controls.SetChildIndex(this.btnPesquisar, 0);
            this.Controls.SetChildIndex(this.DgConsultaCondicaoPagamento, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DgConsultaCondicaoPagamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgConsultaCondicaoPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_condicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn condicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxa;
        private System.Windows.Forms.DataGridViewTextBoxColumn multa;
        private System.Windows.Forms.DataGridViewTextBoxColumn desconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_criacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_ult_alteracao;
    }
}
