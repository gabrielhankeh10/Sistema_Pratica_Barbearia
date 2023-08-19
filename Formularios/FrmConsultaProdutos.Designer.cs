
namespace Sistema__Renovo_Barber.Formularios
{
    partial class FrmConsultaProdutos
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
            this.DgConsultaProdutos = new System.Windows.Forms.DataGridView();
            this.id_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco_custo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco_venda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtd_estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_criacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_ult_alteracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgConsultaProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // DgConsultaProdutos
            // 
            this.DgConsultaProdutos.AllowUserToAddRows = false;
            this.DgConsultaProdutos.AllowUserToDeleteRows = false;
            this.DgConsultaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgConsultaProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_produto,
            this.descricao_produto,
            this.marca,
            this.preco_custo,
            this.preco_venda,
            this.qtd_estoque,
            this.data_criacao,
            this.data_ult_alteracao});
            this.DgConsultaProdutos.Location = new System.Drawing.Point(53, 72);
            this.DgConsultaProdutos.MultiSelect = false;
            this.DgConsultaProdutos.Name = "DgConsultaProdutos";
            this.DgConsultaProdutos.ReadOnly = true;
            this.DgConsultaProdutos.RowHeadersWidth = 51;
            this.DgConsultaProdutos.RowTemplate.Height = 24;
            this.DgConsultaProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgConsultaProdutos.Size = new System.Drawing.Size(784, 437);
            this.DgConsultaProdutos.TabIndex = 9;
            // 
            // id_produto
            // 
            this.id_produto.HeaderText = "ID Produto";
            this.id_produto.MinimumWidth = 6;
            this.id_produto.Name = "id_produto";
            this.id_produto.ReadOnly = true;
            this.id_produto.Width = 125;
            // 
            // descricao_produto
            // 
            this.descricao_produto.HeaderText = "Produto";
            this.descricao_produto.MinimumWidth = 6;
            this.descricao_produto.Name = "descricao_produto";
            this.descricao_produto.ReadOnly = true;
            this.descricao_produto.Width = 125;
            // 
            // marca
            // 
            this.marca.HeaderText = "Marca";
            this.marca.MinimumWidth = 6;
            this.marca.Name = "marca";
            this.marca.ReadOnly = true;
            this.marca.Width = 125;
            // 
            // preco_custo
            // 
            this.preco_custo.HeaderText = "Preço de Custo";
            this.preco_custo.MinimumWidth = 6;
            this.preco_custo.Name = "preco_custo";
            this.preco_custo.ReadOnly = true;
            this.preco_custo.Width = 125;
            // 
            // preco_venda
            // 
            this.preco_venda.HeaderText = "Preço de Venda";
            this.preco_venda.MinimumWidth = 6;
            this.preco_venda.Name = "preco_venda";
            this.preco_venda.ReadOnly = true;
            this.preco_venda.Width = 125;
            // 
            // qtd_estoque
            // 
            this.qtd_estoque.HeaderText = "Quantidade Estoque";
            this.qtd_estoque.MinimumWidth = 6;
            this.qtd_estoque.Name = "qtd_estoque";
            this.qtd_estoque.ReadOnly = true;
            this.qtd_estoque.Width = 125;
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
            // FrmConsultaProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(891, 581);
            this.Controls.Add(this.DgConsultaProdutos);
            this.Name = "FrmConsultaProdutos";
            this.Text = "Consulta de Produtos";
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.btnAlterar, 0);
            this.Controls.SetChildIndex(this.btnIncluir, 0);
            this.Controls.SetChildIndex(this.tbPesquisar, 0);
            this.Controls.SetChildIndex(this.btnPesquisar, 0);
            this.Controls.SetChildIndex(this.DgConsultaProdutos, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DgConsultaProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgConsultaProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco_custo;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco_venda;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtd_estoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_criacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_ult_alteracao;
    }
}
