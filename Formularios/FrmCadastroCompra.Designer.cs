
namespace Sistema__Renovo_Barber.Formularios
{
    partial class FrmCadastroCompra
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
            this.tbNumNota = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.Label();
            this.tbModeloNota = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSerieNota = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFornecedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPesquisarFornecedor = new System.Windows.Forms.Button();
            this.tbDescricaoCondicao = new System.Windows.Forms.TextBox();
            this.tbCodigoFornecedor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCodigoCondicao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDataChegada = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbDataEmissao = new System.Windows.Forms.MaskedTextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.DgItensCompra = new System.Windows.Forms.DataGridView();
            this.id_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtd_estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtd_entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custo_atual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custo_sugerido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentual_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.media_ponderada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbDataCad = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbCodigoProduto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbDescProduto = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btPesquisarProduto = new System.Windows.Forms.Button();
            this.tbCustoFrete = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbCustoSeguro = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbOutrosCustos = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbDataCancelamento = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbQtd = new System.Windows.Forms.TextBox();
            this.tbDesconto = new System.Windows.Forms.TextBox();
            this.tbCusto = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.dgParcelas = new System.Windows.Forms.DataGridView();
            this.num_parcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_forma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forma_pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentual_sob_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbTotalNota = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgItensCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgParcelas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(1168, 680);
            // 
            // tbNumNota
            // 
            this.tbNumNota.Location = new System.Drawing.Point(46, 40);
            this.tbNumNota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNumNota.Name = "tbNumNota";
            this.tbNumNota.Size = new System.Drawing.Size(89, 22);
            this.tbNumNota.TabIndex = 1;
            this.tbNumNota.Leave += new System.EventHandler(this.tbNumNota_Leave);
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(43, 19);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(57, 17);
            this.Nome.TabIndex = 15;
            this.Nome.Text = "Nº Nota";
            // 
            // tbModeloNota
            // 
            this.tbModeloNota.Location = new System.Drawing.Point(161, 40);
            this.tbModeloNota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbModeloNota.Name = "tbModeloNota";
            this.tbModeloNota.Size = new System.Drawing.Size(89, 22);
            this.tbModeloNota.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Modelo Nota";
            // 
            // tbSerieNota
            // 
            this.tbSerieNota.Location = new System.Drawing.Point(284, 40);
            this.tbSerieNota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSerieNota.Name = "tbSerieNota";
            this.tbSerieNota.Size = new System.Drawing.Size(85, 22);
            this.tbSerieNota.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Serie";
            // 
            // tbFornecedor
            // 
            this.tbFornecedor.Enabled = false;
            this.tbFornecedor.Location = new System.Drawing.Point(503, 40);
            this.tbFornecedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFornecedor.Name = "tbFornecedor";
            this.tbFornecedor.Size = new System.Drawing.Size(209, 22);
            this.tbFornecedor.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(500, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Fornecedor";
            // 
            // btnPesquisarFornecedor
            // 
            this.btnPesquisarFornecedor.Location = new System.Drawing.Point(744, 40);
            this.btnPesquisarFornecedor.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisarFornecedor.Name = "btnPesquisarFornecedor";
            this.btnPesquisarFornecedor.Size = new System.Drawing.Size(91, 23);
            this.btnPesquisarFornecedor.TabIndex = 25;
            this.btnPesquisarFornecedor.Text = "Pesquisar";
            this.btnPesquisarFornecedor.UseVisualStyleBackColor = true;
            this.btnPesquisarFornecedor.Click += new System.EventHandler(this.btnPesquisarFornecedor_Click);
            // 
            // tbDescricaoCondicao
            // 
            this.tbDescricaoCondicao.Enabled = false;
            this.tbDescricaoCondicao.Location = new System.Drawing.Point(148, 427);
            this.tbDescricaoCondicao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDescricaoCondicao.Name = "tbDescricaoCondicao";
            this.tbDescricaoCondicao.Size = new System.Drawing.Size(209, 22);
            this.tbDescricaoCondicao.TabIndex = 26;
            // 
            // tbCodigoFornecedor
            // 
            this.tbCodigoFornecedor.Enabled = false;
            this.tbCodigoFornecedor.Location = new System.Drawing.Point(401, 41);
            this.tbCodigoFornecedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCodigoFornecedor.Name = "tbCodigoFornecedor";
            this.tbCodigoFornecedor.Size = new System.Drawing.Size(69, 22);
            this.tbCodigoFornecedor.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Codigo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Codigo";
            // 
            // tbCodigoCondicao
            // 
            this.tbCodigoCondicao.Enabled = false;
            this.tbCodigoCondicao.Location = new System.Drawing.Point(46, 426);
            this.tbCodigoCondicao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCodigoCondicao.Name = "tbCodigoCondicao";
            this.tbCodigoCondicao.Size = new System.Drawing.Size(69, 22);
            this.tbCodigoCondicao.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(145, 405);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Condição de Pagamento";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(389, 425);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1013, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "Data Emissão";
            // 
            // tbDataChegada
            // 
            this.tbDataChegada.Location = new System.Drawing.Point(868, 41);
            this.tbDataChegada.Mask = "00/00/0000";
            this.tbDataChegada.Name = "tbDataChegada";
            this.tbDataChegada.Size = new System.Drawing.Size(89, 22);
            this.tbDataChegada.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(865, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 17);
            this.label8.TabIndex = 36;
            this.label8.Text = "Data Chegada";
            // 
            // tbDataEmissao
            // 
            this.tbDataEmissao.Location = new System.Drawing.Point(1016, 41);
            this.tbDataEmissao.Mask = "00/00/0000";
            this.tbDataEmissao.Name = "tbDataEmissao";
            this.tbDataEmissao.Size = new System.Drawing.Size(89, 22);
            this.tbDataEmissao.TabIndex = 37;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(1077, 680);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 38;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // DgItensCompra
            // 
            this.DgItensCompra.AllowUserToAddRows = false;
            this.DgItensCompra.AllowUserToDeleteRows = false;
            this.DgItensCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgItensCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_produto,
            this.produto,
            this.qtd_estoque,
            this.qtd_entrada,
            this.custo_atual,
            this.custo_sugerido,
            this.desconto,
            this.percentual_compra,
            this.media_ponderada});
            this.DgItensCompra.Location = new System.Drawing.Point(46, 130);
            this.DgItensCompra.MultiSelect = false;
            this.DgItensCompra.Name = "DgItensCompra";
            this.DgItensCompra.ReadOnly = true;
            this.DgItensCompra.RowHeadersWidth = 51;
            this.DgItensCompra.RowTemplate.Height = 24;
            this.DgItensCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgItensCompra.Size = new System.Drawing.Size(1197, 262);
            this.DgItensCompra.TabIndex = 39;
            // 
            // id_produto
            // 
            this.id_produto.HeaderText = "ID Produto";
            this.id_produto.MinimumWidth = 6;
            this.id_produto.Name = "id_produto";
            this.id_produto.ReadOnly = true;
            this.id_produto.Width = 125;
            // 
            // produto
            // 
            this.produto.HeaderText = "Produto";
            this.produto.MinimumWidth = 6;
            this.produto.Name = "produto";
            this.produto.ReadOnly = true;
            this.produto.Width = 125;
            // 
            // qtd_estoque
            // 
            this.qtd_estoque.HeaderText = "Qtd Estoque";
            this.qtd_estoque.MinimumWidth = 6;
            this.qtd_estoque.Name = "qtd_estoque";
            this.qtd_estoque.ReadOnly = true;
            this.qtd_estoque.Width = 125;
            // 
            // qtd_entrada
            // 
            this.qtd_entrada.HeaderText = "Qtd Entrada";
            this.qtd_entrada.MinimumWidth = 6;
            this.qtd_entrada.Name = "qtd_entrada";
            this.qtd_entrada.ReadOnly = true;
            this.qtd_entrada.Width = 125;
            // 
            // custo_atual
            // 
            this.custo_atual.HeaderText = "Custo Atual";
            this.custo_atual.MinimumWidth = 6;
            this.custo_atual.Name = "custo_atual";
            this.custo_atual.ReadOnly = true;
            this.custo_atual.Width = 125;
            // 
            // custo_sugerido
            // 
            this.custo_sugerido.HeaderText = "Custo Sugerido";
            this.custo_sugerido.MinimumWidth = 6;
            this.custo_sugerido.Name = "custo_sugerido";
            this.custo_sugerido.ReadOnly = true;
            this.custo_sugerido.Width = 125;
            // 
            // desconto
            // 
            this.desconto.HeaderText = "Desconto";
            this.desconto.MinimumWidth = 6;
            this.desconto.Name = "desconto";
            this.desconto.ReadOnly = true;
            this.desconto.Width = 125;
            // 
            // percentual_compra
            // 
            this.percentual_compra.HeaderText = "% Compra";
            this.percentual_compra.MinimumWidth = 6;
            this.percentual_compra.Name = "percentual_compra";
            this.percentual_compra.ReadOnly = true;
            this.percentual_compra.Width = 125;
            // 
            // media_ponderada
            // 
            this.media_ponderada.HeaderText = "Média Ponderada";
            this.media_ponderada.MinimumWidth = 6;
            this.media_ponderada.Name = "media_ponderada";
            this.media_ponderada.ReadOnly = true;
            this.media_ponderada.Width = 125;
            // 
            // tbDataCad
            // 
            this.tbDataCad.Enabled = false;
            this.tbDataCad.Location = new System.Drawing.Point(47, 680);
            this.tbDataCad.Mask = "00/00/0000";
            this.tbDataCad.Name = "tbDataCad";
            this.tbDataCad.Size = new System.Drawing.Size(89, 22);
            this.tbDataCad.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 660);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 17);
            this.label9.TabIndex = 41;
            this.label9.Text = "Data Cad.";
            // 
            // tbCodigoProduto
            // 
            this.tbCodigoProduto.Enabled = false;
            this.tbCodigoProduto.Location = new System.Drawing.Point(45, 89);
            this.tbCodigoProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCodigoProduto.Name = "tbCodigoProduto";
            this.tbCodigoProduto.Size = new System.Drawing.Size(90, 22);
            this.tbCodigoProduto.TabIndex = 42;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 17);
            this.label10.TabIndex = 43;
            this.label10.Text = "Codigo";
            // 
            // tbDescProduto
            // 
            this.tbDescProduto.Enabled = false;
            this.tbDescProduto.Location = new System.Drawing.Point(160, 89);
            this.tbDescProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDescProduto.Name = "tbDescProduto";
            this.tbDescProduto.Size = new System.Drawing.Size(193, 22);
            this.tbDescProduto.TabIndex = 44;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(157, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 17);
            this.label11.TabIndex = 45;
            this.label11.Text = "Produto";
            // 
            // btPesquisarProduto
            // 
            this.btPesquisarProduto.Location = new System.Drawing.Point(378, 88);
            this.btPesquisarProduto.Margin = new System.Windows.Forms.Padding(4);
            this.btPesquisarProduto.Name = "btPesquisarProduto";
            this.btPesquisarProduto.Size = new System.Drawing.Size(91, 23);
            this.btPesquisarProduto.TabIndex = 46;
            this.btPesquisarProduto.Text = "Pesquisar";
            this.btPesquisarProduto.UseVisualStyleBackColor = true;
            this.btPesquisarProduto.Click += new System.EventHandler(this.btPesquisarProduto_Click);
            // 
            // tbCustoFrete
            // 
            this.tbCustoFrete.Location = new System.Drawing.Point(505, 425);
            this.tbCustoFrete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCustoFrete.Name = "tbCustoFrete";
            this.tbCustoFrete.Size = new System.Drawing.Size(115, 22);
            this.tbCustoFrete.TabIndex = 49;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(502, 406);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 17);
            this.label12.TabIndex = 50;
            this.label12.Text = "Custo Frete";
            // 
            // tbCustoSeguro
            // 
            this.tbCustoSeguro.Location = new System.Drawing.Point(661, 425);
            this.tbCustoSeguro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCustoSeguro.Name = "tbCustoSeguro";
            this.tbCustoSeguro.Size = new System.Drawing.Size(115, 22);
            this.tbCustoSeguro.TabIndex = 51;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(658, 406);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 17);
            this.label13.TabIndex = 52;
            this.label13.Text = "Custo Seguro";
            // 
            // tbOutrosCustos
            // 
            this.tbOutrosCustos.Location = new System.Drawing.Point(814, 425);
            this.tbOutrosCustos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbOutrosCustos.Name = "tbOutrosCustos";
            this.tbOutrosCustos.Size = new System.Drawing.Size(115, 22);
            this.tbOutrosCustos.TabIndex = 53;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(811, 406);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 17);
            this.label14.TabIndex = 54;
            this.label14.Text = "Outras Despesas";
            // 
            // tbDataCancelamento
            // 
            this.tbDataCancelamento.Location = new System.Drawing.Point(1158, 39);
            this.tbDataCancelamento.Mask = "00/00/0000";
            this.tbDataCancelamento.Name = "tbDataCancelamento";
            this.tbDataCancelamento.Size = new System.Drawing.Size(85, 22);
            this.tbDataCancelamento.TabIndex = 55;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1134, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 17);
            this.label15.TabIndex = 56;
            this.label15.Text = "Data Cancelada";
            // 
            // tbQtd
            // 
            this.tbQtd.Location = new System.Drawing.Point(502, 89);
            this.tbQtd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbQtd.Name = "tbQtd";
            this.tbQtd.Size = new System.Drawing.Size(61, 22);
            this.tbQtd.TabIndex = 57;
            // 
            // tbDesconto
            // 
            this.tbDesconto.Location = new System.Drawing.Point(650, 89);
            this.tbDesconto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDesconto.Name = "tbDesconto";
            this.tbDesconto.Size = new System.Drawing.Size(61, 22);
            this.tbDesconto.TabIndex = 58;
            // 
            // tbCusto
            // 
            this.tbCusto.Location = new System.Drawing.Point(576, 89);
            this.tbCusto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCusto.Name = "tbCusto";
            this.tbCusto.Size = new System.Drawing.Size(61, 22);
            this.tbCusto.TabIndex = 59;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(743, 89);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 23);
            this.button2.TabIndex = 60;
            this.button2.Text = "Adicionar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(499, 69);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 17);
            this.label16.TabIndex = 61;
            this.label16.Text = "Qtd";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(573, 69);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 17);
            this.label17.TabIndex = 62;
            this.label17.Text = "Custo";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(647, 69);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 17);
            this.label18.TabIndex = 63;
            this.label18.Text = "Desconto";
            // 
            // dgParcelas
            // 
            this.dgParcelas.AllowUserToAddRows = false;
            this.dgParcelas.AllowUserToDeleteRows = false;
            this.dgParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgParcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num_parcela,
            this.dias,
            this.id_forma,
            this.forma_pagamento,
            this.percentual_sob_total});
            this.dgParcelas.Location = new System.Drawing.Point(46, 468);
            this.dgParcelas.MultiSelect = false;
            this.dgParcelas.Name = "dgParcelas";
            this.dgParcelas.ReadOnly = true;
            this.dgParcelas.RowHeadersWidth = 51;
            this.dgParcelas.RowTemplate.Height = 24;
            this.dgParcelas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgParcelas.Size = new System.Drawing.Size(1197, 179);
            this.dgParcelas.TabIndex = 64;
            // 
            // num_parcela
            // 
            this.num_parcela.HeaderText = "Nº Parcela";
            this.num_parcela.MinimumWidth = 6;
            this.num_parcela.Name = "num_parcela";
            this.num_parcela.ReadOnly = true;
            this.num_parcela.Width = 125;
            // 
            // dias
            // 
            this.dias.HeaderText = "Dias";
            this.dias.MinimumWidth = 6;
            this.dias.Name = "dias";
            this.dias.ReadOnly = true;
            this.dias.Width = 125;
            // 
            // id_forma
            // 
            this.id_forma.HeaderText = "ID Forma";
            this.id_forma.MinimumWidth = 6;
            this.id_forma.Name = "id_forma";
            this.id_forma.ReadOnly = true;
            this.id_forma.Width = 125;
            // 
            // forma_pagamento
            // 
            this.forma_pagamento.HeaderText = "Forma de Pagamento";
            this.forma_pagamento.MinimumWidth = 6;
            this.forma_pagamento.Name = "forma_pagamento";
            this.forma_pagamento.ReadOnly = true;
            this.forma_pagamento.Width = 125;
            // 
            // percentual_sob_total
            // 
            this.percentual_sob_total.HeaderText = "% Sob Total";
            this.percentual_sob_total.MinimumWidth = 6;
            this.percentual_sob_total.Name = "percentual_sob_total";
            this.percentual_sob_total.ReadOnly = true;
            this.percentual_sob_total.Width = 125;
            // 
            // tbTotalNota
            // 
            this.tbTotalNota.Location = new System.Drawing.Point(1128, 425);
            this.tbTotalNota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTotalNota.Name = "tbTotalNota";
            this.tbTotalNota.Size = new System.Drawing.Size(115, 22);
            this.tbTotalNota.TabIndex = 65;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(1125, 406);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(74, 17);
            this.label19.TabIndex = 66;
            this.label19.Text = "Total Nota";
            // 
            // FrmCadastroCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1304, 732);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.tbTotalNota);
            this.Controls.Add(this.dgParcelas);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbCusto);
            this.Controls.Add(this.tbDesconto);
            this.Controls.Add(this.tbQtd);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tbDataCancelamento);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tbOutrosCustos);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbCustoSeguro);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbCustoFrete);
            this.Controls.Add(this.btPesquisarProduto);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbDescProduto);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbCodigoProduto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbDataCad);
            this.Controls.Add(this.DgItensCompra);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.tbDataEmissao);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbDataChegada);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbCodigoCondicao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbCodigoFornecedor);
            this.Controls.Add(this.tbDescricaoCondicao);
            this.Controls.Add(this.btnPesquisarFornecedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbFornecedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSerieNota);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbModeloNota);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.tbNumNota);
            this.Name = "FrmCadastroCompra";
            this.Text = "Cadastro de Compra";
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.tbNumNota, 0);
            this.Controls.SetChildIndex(this.Nome, 0);
            this.Controls.SetChildIndex(this.tbModeloNota, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.tbSerieNota, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.tbFornecedor, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.btnPesquisarFornecedor, 0);
            this.Controls.SetChildIndex(this.tbDescricaoCondicao, 0);
            this.Controls.SetChildIndex(this.tbCodigoFornecedor, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.tbCodigoCondicao, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.tbDataChegada, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.tbDataEmissao, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.DgItensCompra, 0);
            this.Controls.SetChildIndex(this.tbDataCad, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.tbCodigoProduto, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.tbDescProduto, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.btPesquisarProduto, 0);
            this.Controls.SetChildIndex(this.tbCustoFrete, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.tbCustoSeguro, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.tbOutrosCustos, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.tbDataCancelamento, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.tbQtd, 0);
            this.Controls.SetChildIndex(this.tbDesconto, 0);
            this.Controls.SetChildIndex(this.tbCusto, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            this.Controls.SetChildIndex(this.label17, 0);
            this.Controls.SetChildIndex(this.label18, 0);
            this.Controls.SetChildIndex(this.dgParcelas, 0);
            this.Controls.SetChildIndex(this.tbTotalNota, 0);
            this.Controls.SetChildIndex(this.label19, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DgItensCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgParcelas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNumNota;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.TextBox tbModeloNota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSerieNota;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFornecedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPesquisarFornecedor;
        private System.Windows.Forms.TextBox tbDescricaoCondicao;
        private System.Windows.Forms.TextBox tbCodigoFornecedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCodigoCondicao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox tbDataChegada;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox tbDataEmissao;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView DgItensCompra;
        private System.Windows.Forms.MaskedTextBox tbDataCad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbCodigoProduto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbDescProduto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btPesquisarProduto;
        private System.Windows.Forms.TextBox tbCustoFrete;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbCustoSeguro;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbOutrosCustos;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox tbDataCancelamento;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbQtd;
        private System.Windows.Forms.TextBox tbDesconto;
        private System.Windows.Forms.TextBox tbCusto;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtd_estoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtd_entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn custo_atual;
        private System.Windows.Forms.DataGridViewTextBoxColumn custo_sugerido;
        private System.Windows.Forms.DataGridViewTextBoxColumn desconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentual_compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn media_ponderada;
        private System.Windows.Forms.DataGridView dgParcelas;
        private System.Windows.Forms.TextBox tbTotalNota;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_parcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn dias;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_forma;
        private System.Windows.Forms.DataGridViewTextBoxColumn forma_pagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentual_sob_total;
    }
}
