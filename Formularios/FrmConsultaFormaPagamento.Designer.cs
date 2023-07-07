
namespace Sistema__Renovo_Barber.Formularios
{
    partial class FrmConsultaFormaPagamento
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
            this.DgConsultaFormaPagamento = new System.Windows.Forms.DataGridView();
            this.id_forma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_criacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_ult_alteracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgConsultaFormaPagamento)).BeginInit();
            this.SuspendLayout();
            // 
            // DgConsultaFormaPagamento
            // 
            this.DgConsultaFormaPagamento.AllowUserToAddRows = false;
            this.DgConsultaFormaPagamento.AllowUserToDeleteRows = false;
            this.DgConsultaFormaPagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgConsultaFormaPagamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_forma,
            this.forma,
            this.data_criacao,
            this.data_ult_alteracao});
            this.DgConsultaFormaPagamento.Location = new System.Drawing.Point(54, 72);
            this.DgConsultaFormaPagamento.MultiSelect = false;
            this.DgConsultaFormaPagamento.Name = "DgConsultaFormaPagamento";
            this.DgConsultaFormaPagamento.ReadOnly = true;
            this.DgConsultaFormaPagamento.RowHeadersWidth = 51;
            this.DgConsultaFormaPagamento.RowTemplate.Height = 24;
            this.DgConsultaFormaPagamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgConsultaFormaPagamento.Size = new System.Drawing.Size(782, 437);
            this.DgConsultaFormaPagamento.TabIndex = 11;
            this.DgConsultaFormaPagamento.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgConsultaFormaPagamento_CellDoubleClick);
            this.DgConsultaFormaPagamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DgConsultaFormaPagamento_KeyPress);
            // 
            // id_forma
            // 
            this.id_forma.HeaderText = "ID Forma";
            this.id_forma.MinimumWidth = 6;
            this.id_forma.Name = "id_forma";
            this.id_forma.ReadOnly = true;
            this.id_forma.Width = 60;
            // 
            // forma
            // 
            this.forma.HeaderText = "Forma de Pagamento";
            this.forma.MinimumWidth = 6;
            this.forma.Name = "forma";
            this.forma.ReadOnly = true;
            this.forma.Width = 125;
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
            // FrmConsultaFormaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(891, 581);
            this.Controls.Add(this.DgConsultaFormaPagamento);
            this.Name = "FrmConsultaFormaPagamento";
            this.Text = "Consulta Forma de Pagamento";
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.btnAlterar, 0);
            this.Controls.SetChildIndex(this.btnIncluir, 0);
            this.Controls.SetChildIndex(this.tbPesquisar, 0);
            this.Controls.SetChildIndex(this.btnPesquisar, 0);
            this.Controls.SetChildIndex(this.DgConsultaFormaPagamento, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DgConsultaFormaPagamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgConsultaFormaPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_forma;
        private System.Windows.Forms.DataGridViewTextBoxColumn forma;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_criacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_ult_alteracao;
    }
}
