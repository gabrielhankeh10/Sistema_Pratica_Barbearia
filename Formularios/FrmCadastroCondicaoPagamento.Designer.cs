
namespace Sistema__Renovo_Barber.Formularios
{
    partial class FrmCadastroCondicaoPagamento
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
            this.tbCondicao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbParcelas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTaxa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMulta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbDesconto = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tbDias = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbPercentual = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbIdForma = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbDescForma = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.DgCondicao = new System.Windows.Forms.DataGridView();
            this.tbPercentualTotal = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.num_parcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dias_totais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idForma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forma_pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgCondicao)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCondicao
            // 
            this.tbCondicao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbCondicao.Location = new System.Drawing.Point(169, 64);
            this.tbCondicao.Name = "tbCondicao";
            this.tbCondicao.Size = new System.Drawing.Size(255, 22);
            this.tbCondicao.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Condição";
            // 
            // tbParcelas
            // 
            this.tbParcelas.Location = new System.Drawing.Point(447, 64);
            this.tbParcelas.Name = "tbParcelas";
            this.tbParcelas.Size = new System.Drawing.Size(60, 22);
            this.tbParcelas.TabIndex = 9;
            this.tbParcelas.TextChanged += new System.EventHandler(this.tbParcelas_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(444, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Parcelas";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tbTaxa
            // 
            this.tbTaxa.Location = new System.Drawing.Point(49, 125);
            this.tbTaxa.Name = "tbTaxa";
            this.tbTaxa.Size = new System.Drawing.Size(100, 22);
            this.tbTaxa.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Taxa";
            // 
            // tbMulta
            // 
            this.tbMulta.Location = new System.Drawing.Point(169, 125);
            this.tbMulta.Name = "tbMulta";
            this.tbMulta.Size = new System.Drawing.Size(119, 22);
            this.tbMulta.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(166, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Multa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(302, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Desconto";
            // 
            // tbDesconto
            // 
            this.tbDesconto.Location = new System.Drawing.Point(305, 125);
            this.tbDesconto.Name = "tbDesconto";
            this.tbDesconto.Size = new System.Drawing.Size(119, 22);
            this.tbDesconto.TabIndex = 15;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(665, 524);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 52;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // tbDias
            // 
            this.tbDias.Location = new System.Drawing.Point(531, 65);
            this.tbDias.Name = "tbDias";
            this.tbDias.Size = new System.Drawing.Size(48, 22);
            this.tbDias.TabIndex = 53;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(528, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 17);
            this.label9.TabIndex = 54;
            this.label9.Text = "Dias";
            // 
            // tbPercentual
            // 
            this.tbPercentual.Location = new System.Drawing.Point(598, 65);
            this.tbPercentual.Name = "tbPercentual";
            this.tbPercentual.Size = new System.Drawing.Size(48, 22);
            this.tbPercentual.TabIndex = 55;
            this.tbPercentual.TextChanged += new System.EventHandler(this.tbPercentual_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(595, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 17);
            this.label10.TabIndex = 56;
            this.label10.Text = "%";
            // 
            // tbIdForma
            // 
            this.tbIdForma.Location = new System.Drawing.Point(447, 125);
            this.tbIdForma.Name = "tbIdForma";
            this.tbIdForma.Size = new System.Drawing.Size(60, 22);
            this.tbIdForma.TabIndex = 57;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(528, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 17);
            this.label11.TabIndex = 58;
            this.label11.Text = "Forma de Pagamento";
            // 
            // tbDescForma
            // 
            this.tbDescForma.Location = new System.Drawing.Point(531, 125);
            this.tbDescForma.Name = "tbDescForma";
            this.tbDescForma.Size = new System.Drawing.Size(182, 22);
            this.tbDescForma.TabIndex = 59;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(444, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 17);
            this.label12.TabIndex = 60;
            this.label12.Text = "ID Forma";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(738, 125);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 61;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DgCondicao
            // 
            this.DgCondicao.AllowUserToAddRows = false;
            this.DgCondicao.AllowUserToDeleteRows = false;
            this.DgCondicao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgCondicao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num_parcela,
            this.dias_totais,
            this.idForma,
            this.forma_pagamento,
            this.percentual});
            this.DgCondicao.Location = new System.Drawing.Point(49, 180);
            this.DgCondicao.Name = "DgCondicao";
            this.DgCondicao.ReadOnly = true;
            this.DgCondicao.RowHeadersWidth = 51;
            this.DgCondicao.RowTemplate.Height = 24;
            this.DgCondicao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgCondicao.Size = new System.Drawing.Size(786, 298);
            this.DgCondicao.TabIndex = 63;
            // 
            // tbPercentualTotal
            // 
            this.tbPercentualTotal.Location = new System.Drawing.Point(665, 65);
            this.tbPercentualTotal.Name = "tbPercentualTotal";
            this.tbPercentualTotal.Size = new System.Drawing.Size(48, 22);
            this.tbPercentualTotal.TabIndex = 64;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(738, 65);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(97, 23);
            this.btnAdicionar.TabIndex = 65;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(662, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 17);
            this.label13.TabIndex = 66;
            this.label13.Text = "% Total";
            // 
            // num_parcela
            // 
            this.num_parcela.HeaderText = "N° Parcela";
            this.num_parcela.MinimumWidth = 6;
            this.num_parcela.Name = "num_parcela";
            this.num_parcela.ReadOnly = true;
            this.num_parcela.Width = 125;
            // 
            // dias_totais
            // 
            this.dias_totais.HeaderText = "Dias";
            this.dias_totais.MinimumWidth = 6;
            this.dias_totais.Name = "dias_totais";
            this.dias_totais.ReadOnly = true;
            this.dias_totais.Width = 125;
            // 
            // idForma
            // 
            this.idForma.HeaderText = "ID Forma";
            this.idForma.MinimumWidth = 6;
            this.idForma.Name = "idForma";
            this.idForma.ReadOnly = true;
            this.idForma.Width = 125;
            // 
            // forma_pagamento
            // 
            this.forma_pagamento.HeaderText = "Forma de Pagamento";
            this.forma_pagamento.MinimumWidth = 6;
            this.forma_pagamento.Name = "forma_pagamento";
            this.forma_pagamento.ReadOnly = true;
            this.forma_pagamento.Width = 125;
            // 
            // percentual
            // 
            this.percentual.HeaderText = "% Sob Total";
            this.percentual.MinimumWidth = 6;
            this.percentual.Name = "percentual";
            this.percentual.ReadOnly = true;
            this.percentual.Width = 125;
            // 
            // FrmCadastroCondicaoPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(891, 581);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.tbPercentualTotal);
            this.Controls.Add(this.DgCondicao);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbDescForma);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbIdForma);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbPercentual);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbDias);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbDesconto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbMulta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbTaxa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbParcelas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbCondicao);
            this.Name = "FrmCadastroCondicaoPagamento";
            this.Text = "Cadastro Condição de Pagamento";
            this.Controls.SetChildIndex(this.tbCodigo, 0);
            this.Controls.SetChildIndex(this.tbDatCad, 0);
            this.Controls.SetChildIndex(this.tbDatUltAlt, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.tbCondicao, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.tbParcelas, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.tbTaxa, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.tbMulta, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.tbDesconto, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.tbDias, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.tbPercentual, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.tbIdForma, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.tbDescForma, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.DgCondicao, 0);
            this.Controls.SetChildIndex(this.tbPercentualTotal, 0);
            this.Controls.SetChildIndex(this.btnAdicionar, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DgCondicao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCondicao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbParcelas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTaxa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMulta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbDesconto;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox tbDias;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbPercentual;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbIdForma;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbDescForma;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DgCondicao;
        private System.Windows.Forms.TextBox tbPercentualTotal;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_parcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn dias_totais;
        private System.Windows.Forms.DataGridViewTextBoxColumn idForma;
        private System.Windows.Forms.DataGridViewTextBoxColumn forma_pagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentual;
    }
}
