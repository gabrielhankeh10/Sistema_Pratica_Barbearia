
namespace Sistema__Renovo_Barber.Formularios
{
    partial class FrmCadastroFornecedor
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
            this.tbInscricaoMun = new System.Windows.Forms.TextBox();
            this.tbInscricaoEst = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnPesquisarCidade = new System.Windows.Forms.Button();
            this.tbCidadeDesc = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.Text = "Razao Social";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(485, 42);
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.Text = "CNPJ";
            // 
            // label11
            // 
            this.label11.Size = new System.Drawing.Size(125, 21);
            this.label11.Text = "Codigo Cidade";
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(711, 42);
            this.label17.Size = new System.Drawing.Size(125, 17);
            this.label17.Text = "Data de Fundacao";
            // 
            // tbCidade
            // 
            this.tbCidade.Size = new System.Drawing.Size(111, 22);
            // 
            // tbCpfCnpj
            // 
            this.tbCpfCnpj.Location = new System.Drawing.Point(488, 64);
            this.tbCpfCnpj.Mask = "##.###.###/####-##";
            this.tbCpfCnpj.Size = new System.Drawing.Size(191, 22);
            // 
            // tbDatNasc
            // 
            this.tbDatNasc.Location = new System.Drawing.Point(714, 64);
            this.tbDatNasc.Size = new System.Drawing.Size(121, 22);
            // 
            // label19
            // 
            this.label19.Size = new System.Drawing.Size(103, 17);
            this.label19.Text = "Nome Fantasia";
            // 
            // tbInscricaoMun
            // 
            this.tbInscricaoMun.Location = new System.Drawing.Point(488, 123);
            this.tbInscricaoMun.Name = "tbInscricaoMun";
            this.tbInscricaoMun.Size = new System.Drawing.Size(162, 22);
            this.tbInscricaoMun.TabIndex = 44;
            // 
            // tbInscricaoEst
            // 
            this.tbInscricaoEst.Location = new System.Drawing.Point(684, 123);
            this.tbInscricaoEst.Name = "tbInscricaoEst";
            this.tbInscricaoEst.Size = new System.Drawing.Size(151, 22);
            this.tbInscricaoEst.TabIndex = 45;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(488, 103);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(127, 17);
            this.label18.TabIndex = 46;
            this.label18.Text = "Inscricao Municipal";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(681, 101);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(123, 17);
            this.label20.TabIndex = 47;
            this.label20.Text = "Inscricao Estadual";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(667, 524);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 48;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnPesquisarCidade
            // 
            this.btnPesquisarCidade.Location = new System.Drawing.Point(49, 350);
            this.btnPesquisarCidade.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisarCidade.Name = "btnPesquisarCidade";
            this.btnPesquisarCidade.Size = new System.Drawing.Size(91, 23);
            this.btnPesquisarCidade.TabIndex = 54;
            this.btnPesquisarCidade.Text = "Pesquisar";
            this.btnPesquisarCidade.UseVisualStyleBackColor = true;
            this.btnPesquisarCidade.Click += new System.EventHandler(this.btnPesquisarCidade_Click);
            // 
            // tbCidadeDesc
            // 
            this.tbCidadeDesc.Enabled = false;
            this.tbCidadeDesc.Location = new System.Drawing.Point(186, 302);
            this.tbCidadeDesc.Name = "tbCidadeDesc";
            this.tbCidadeDesc.Size = new System.Drawing.Size(180, 22);
            this.tbCidadeDesc.TabIndex = 53;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(183, 282);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 21);
            this.label12.TabIndex = 55;
            this.label12.Text = "Cidade";
            // 
            // FrmCadastroFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(891, 581);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnPesquisarCidade);
            this.Controls.Add(this.tbCidadeDesc);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.tbInscricaoEst);
            this.Controls.Add(this.tbInscricaoMun);
            this.Name = "FrmCadastroFornecedor";
            this.Text = "Cadastro de Fornecedor";
            this.Controls.SetChildIndex(this.tbCodigo, 0);
            this.Controls.SetChildIndex(this.tbDatCad, 0);
            this.Controls.SetChildIndex(this.tbDatUltAlt, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.tbNome, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.tbEmail, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.tbEndereco, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.tbNumero, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.tbBairro, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.tbComplemento, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.tbCidade, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.tbStatus, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            this.Controls.SetChildIndex(this.label17, 0);
            this.Controls.SetChildIndex(this.TbCEP, 0);
            this.Controls.SetChildIndex(this.tbCelular, 0);
            this.Controls.SetChildIndex(this.TbTelefone, 0);
            this.Controls.SetChildIndex(this.tbCpfCnpj, 0);
            this.Controls.SetChildIndex(this.tbDatNasc, 0);
            this.Controls.SetChildIndex(this.tbApelido, 0);
            this.Controls.SetChildIndex(this.label19, 0);
            this.Controls.SetChildIndex(this.tbInscricaoMun, 0);
            this.Controls.SetChildIndex(this.tbInscricaoEst, 0);
            this.Controls.SetChildIndex(this.label18, 0);
            this.Controls.SetChildIndex(this.label20, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.tbCidadeDesc, 0);
            this.Controls.SetChildIndex(this.btnPesquisarCidade, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInscricaoMun;
        private System.Windows.Forms.TextBox tbInscricaoEst;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnPesquisarCidade;
        private System.Windows.Forms.TextBox tbCidadeDesc;
        private System.Windows.Forms.Label label12;
    }
}
