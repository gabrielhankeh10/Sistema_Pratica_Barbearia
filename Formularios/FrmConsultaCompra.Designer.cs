
namespace Sistema__Renovo_Barber.Formularios
{
    partial class FrmConsultaCompra
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
            this.DgConsultaCompras = new System.Windows.Forms.DataGridView();
            this.tbPesquisarCompra = new System.Windows.Forms.TextBox();
            this.btnPesquisarCompra = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.num_nfc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo_nfc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serie_nfc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_frete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_seguro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_outras_despesas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_chegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_emissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_criacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgConsultaCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(761, 518);
            // 
            // DgConsultaCompras
            // 
            this.DgConsultaCompras.AllowUserToAddRows = false;
            this.DgConsultaCompras.AllowUserToDeleteRows = false;
            this.DgConsultaCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgConsultaCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num_nfc,
            this.modelo_nfc,
            this.serie_nfc,
            this.cod_fornecedor,
            this.fornecedor,
            this.condicao,
            this.valor_total,
            this.valor_frete,
            this.valor_seguro,
            this.valor_outras_despesas,
            this.data_chegada,
            this.data_emissao,
            this.data_criacao});
            this.DgConsultaCompras.Location = new System.Drawing.Point(51, 79);
            this.DgConsultaCompras.MultiSelect = false;
            this.DgConsultaCompras.Name = "DgConsultaCompras";
            this.DgConsultaCompras.ReadOnly = true;
            this.DgConsultaCompras.RowHeadersWidth = 51;
            this.DgConsultaCompras.RowTemplate.Height = 24;
            this.DgConsultaCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgConsultaCompras.Size = new System.Drawing.Size(785, 419);
            this.DgConsultaCompras.TabIndex = 10;
            // 
            // tbPesquisarCompra
            // 
            this.tbPesquisarCompra.Location = new System.Drawing.Point(51, 34);
            this.tbPesquisarCompra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPesquisarCompra.Name = "tbPesquisarCompra";
            this.tbPesquisarCompra.Size = new System.Drawing.Size(255, 22);
            this.tbPesquisarCompra.TabIndex = 14;
            // 
            // btnPesquisarCompra
            // 
            this.btnPesquisarCompra.Location = new System.Drawing.Point(339, 33);
            this.btnPesquisarCompra.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisarCompra.Name = "btnPesquisarCompra";
            this.btnPesquisarCompra.Size = new System.Drawing.Size(91, 23);
            this.btnPesquisarCompra.TabIndex = 25;
            this.btnPesquisarCompra.Text = "Pesquisar";
            this.btnPesquisarCompra.UseVisualStyleBackColor = true;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(560, 518);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(84, 23);
            this.btnIncluir.TabIndex = 26;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(661, 518);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 23);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(458, 518);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(84, 23);
            this.btnSelecionar.TabIndex = 28;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // num_nfc
            // 
            this.num_nfc.HeaderText = "Nº Nota";
            this.num_nfc.MinimumWidth = 6;
            this.num_nfc.Name = "num_nfc";
            this.num_nfc.ReadOnly = true;
            this.num_nfc.Width = 125;
            // 
            // modelo_nfc
            // 
            this.modelo_nfc.HeaderText = "Modelo";
            this.modelo_nfc.MinimumWidth = 6;
            this.modelo_nfc.Name = "modelo_nfc";
            this.modelo_nfc.ReadOnly = true;
            this.modelo_nfc.Width = 125;
            // 
            // serie_nfc
            // 
            this.serie_nfc.HeaderText = "Série";
            this.serie_nfc.MinimumWidth = 6;
            this.serie_nfc.Name = "serie_nfc";
            this.serie_nfc.ReadOnly = true;
            this.serie_nfc.Width = 125;
            // 
            // cod_fornecedor
            // 
            this.cod_fornecedor.HeaderText = "Cod Fornecedor";
            this.cod_fornecedor.MinimumWidth = 6;
            this.cod_fornecedor.Name = "cod_fornecedor";
            this.cod_fornecedor.ReadOnly = true;
            this.cod_fornecedor.Width = 125;
            // 
            // fornecedor
            // 
            this.fornecedor.HeaderText = "Fornecedor";
            this.fornecedor.MinimumWidth = 6;
            this.fornecedor.Name = "fornecedor";
            this.fornecedor.ReadOnly = true;
            this.fornecedor.Width = 125;
            // 
            // condicao
            // 
            this.condicao.HeaderText = "Condição de Pagamento";
            this.condicao.MinimumWidth = 6;
            this.condicao.Name = "condicao";
            this.condicao.ReadOnly = true;
            this.condicao.Width = 125;
            // 
            // valor_total
            // 
            this.valor_total.HeaderText = "Valor Total";
            this.valor_total.MinimumWidth = 6;
            this.valor_total.Name = "valor_total";
            this.valor_total.ReadOnly = true;
            this.valor_total.Width = 125;
            // 
            // valor_frete
            // 
            this.valor_frete.HeaderText = "Valor Frete";
            this.valor_frete.MinimumWidth = 6;
            this.valor_frete.Name = "valor_frete";
            this.valor_frete.ReadOnly = true;
            this.valor_frete.Width = 125;
            // 
            // valor_seguro
            // 
            this.valor_seguro.HeaderText = "Valor Seguro";
            this.valor_seguro.MinimumWidth = 6;
            this.valor_seguro.Name = "valor_seguro";
            this.valor_seguro.ReadOnly = true;
            this.valor_seguro.Width = 125;
            // 
            // valor_outras_despesas
            // 
            this.valor_outras_despesas.HeaderText = "Outras Despesas";
            this.valor_outras_despesas.MinimumWidth = 6;
            this.valor_outras_despesas.Name = "valor_outras_despesas";
            this.valor_outras_despesas.ReadOnly = true;
            this.valor_outras_despesas.Width = 125;
            // 
            // data_chegada
            // 
            this.data_chegada.HeaderText = "Chegada";
            this.data_chegada.MinimumWidth = 6;
            this.data_chegada.Name = "data_chegada";
            this.data_chegada.ReadOnly = true;
            this.data_chegada.Width = 125;
            // 
            // data_emissao
            // 
            this.data_emissao.HeaderText = "Emissão";
            this.data_emissao.MinimumWidth = 6;
            this.data_emissao.Name = "data_emissao";
            this.data_emissao.ReadOnly = true;
            this.data_emissao.Width = 125;
            // 
            // data_criacao
            // 
            this.data_criacao.HeaderText = "Criação";
            this.data_criacao.MinimumWidth = 6;
            this.data_criacao.Name = "data_criacao";
            this.data_criacao.ReadOnly = true;
            this.data_criacao.Width = 125;
            // 
            // FrmConsultaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(888, 593);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.btnPesquisarCompra);
            this.Controls.Add(this.tbPesquisarCompra);
            this.Controls.Add(this.DgConsultaCompras);
            this.Name = "FrmConsultaCompra";
            this.Text = "Consulta de Compras";
            this.Controls.SetChildIndex(this.DgConsultaCompras, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.tbPesquisarCompra, 0);
            this.Controls.SetChildIndex(this.btnPesquisarCompra, 0);
            this.Controls.SetChildIndex(this.btnIncluir, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.btnSelecionar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DgConsultaCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgConsultaCompras;
        private System.Windows.Forms.TextBox tbPesquisarCompra;
        private System.Windows.Forms.Button btnPesquisarCompra;
        public System.Windows.Forms.Button btnIncluir;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_nfc;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo_nfc;
        private System.Windows.Forms.DataGridViewTextBoxColumn serie_nfc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn condicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_frete;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_seguro;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_outras_despesas;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_chegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_emissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_criacao;
    }
}
