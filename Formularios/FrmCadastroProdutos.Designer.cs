
namespace Sistema__Renovo_Barber.Formularios
{
    partial class FrmCadastroProdutos
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
            this.tbDescricaoProduto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMarcaProduto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPrecoCusto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPrecoVenda = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbQtdEstoque = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tbUnidade = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbDescricaoProduto
            // 
            this.tbDescricaoProduto.Location = new System.Drawing.Point(177, 64);
            this.tbDescricaoProduto.Name = "tbDescricaoProduto";
            this.tbDescricaoProduto.Size = new System.Drawing.Size(252, 22);
            this.tbDescricaoProduto.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Descrição do Produto";
            // 
            // tbMarcaProduto
            // 
            this.tbMarcaProduto.Location = new System.Drawing.Point(466, 64);
            this.tbMarcaProduto.Name = "tbMarcaProduto";
            this.tbMarcaProduto.Size = new System.Drawing.Size(218, 22);
            this.tbMarcaProduto.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(463, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Marca do Produto";
            // 
            // tbPrecoCusto
            // 
            this.tbPrecoCusto.Location = new System.Drawing.Point(49, 131);
            this.tbPrecoCusto.Name = "tbPrecoCusto";
            this.tbPrecoCusto.Size = new System.Drawing.Size(102, 22);
            this.tbPrecoCusto.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Preço de Custo";
            // 
            // tbPrecoVenda
            // 
            this.tbPrecoVenda.Location = new System.Drawing.Point(177, 131);
            this.tbPrecoVenda.Name = "tbPrecoVenda";
            this.tbPrecoVenda.Size = new System.Drawing.Size(102, 22);
            this.tbPrecoVenda.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(174, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Preço de Venda";
            // 
            // tbQtdEstoque
            // 
            this.tbQtdEstoque.Enabled = false;
            this.tbQtdEstoque.Location = new System.Drawing.Point(724, 64);
            this.tbQtdEstoque.Name = "tbQtdEstoque";
            this.tbQtdEstoque.Size = new System.Drawing.Size(111, 22);
            this.tbQtdEstoque.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(721, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Qtd. Estoque";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(667, 524);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 18;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // tbUnidade
            // 
            this.tbUnidade.Location = new System.Drawing.Point(307, 131);
            this.tbUnidade.Name = "tbUnidade";
            this.tbUnidade.Size = new System.Drawing.Size(102, 22);
            this.tbUnidade.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(304, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "UND Medida";
            // 
            // FrmCadastroProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(891, 581);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbUnidade);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbQtdEstoque);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbPrecoVenda);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPrecoCusto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbMarcaProduto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbDescricaoProduto);
            this.Name = "FrmCadastroProdutos";
            this.Text = "Cadastro de Produtos";
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.tbCodigo, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.tbDatCad, 0);
            this.Controls.SetChildIndex(this.tbDatUltAlt, 0);
            this.Controls.SetChildIndex(this.tbDescricaoProduto, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.tbMarcaProduto, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.tbPrecoCusto, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.tbPrecoVenda, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.tbQtdEstoque, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.tbUnidade, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDescricaoProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMarcaProduto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPrecoCusto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPrecoVenda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbQtdEstoque;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox tbUnidade;
        private System.Windows.Forms.Label label9;
    }
}
