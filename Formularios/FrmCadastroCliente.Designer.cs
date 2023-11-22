
namespace Sistema__Renovo_Barber.Formularios
{
    partial class FrmCadastroCliente
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
            this.tbRG = new System.Windows.Forms.MaskedTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tbSexo = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbCidadeDesc = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.btnPesquisarEstado = new System.Windows.Forms.Button();
            this.tbCondicaoPagamento = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.tbIdeCondicao = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.Text = "Nome do Cliente";
            // 
            // label5
            // 
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.Text = "CPF";
            // 
            // label11
            // 
            this.label11.Size = new System.Drawing.Size(100, 17);
            this.label11.Text = "Codigo Cidade";
            // 
            // TbCEP
            // 
            this.TbCEP.TabIndex = 14;
            // 
            // tbCelular
            // 
            this.tbCelular.TabIndex = 15;
            // 
            // TbTelefone
            // 
            this.TbTelefone.TabIndex = 12;
            // 
            // tbNome
            // 
            this.tbNome.TabIndex = 1;
            // 
            // tbEmail
            // 
            this.tbEmail.TabIndex = 7;
            this.tbEmail.Leave += new System.EventHandler(this.tbEmail_Leave);
            // 
            // tbEndereco
            // 
            this.tbEndereco.TabIndex = 8;
            // 
            // tbNumero
            // 
            this.tbNumero.TabIndex = 9;
            // 
            // tbBairro
            // 
            this.tbBairro.TabIndex = 10;
            // 
            // tbComplemento
            // 
            this.tbComplemento.TabIndex = 11;
            // 
            // tbCidade
            // 
            this.tbCidade.Size = new System.Drawing.Size(134, 22);
            // 
            // tbCpfCnpj
            // 
            this.tbCpfCnpj.Mask = "###.###.###-##";
            this.tbCpfCnpj.Size = new System.Drawing.Size(113, 22);
            this.tbCpfCnpj.TabIndex = 3;
            this.tbCpfCnpj.TabIndexChanged += new System.EventHandler(this.tbCpfCnpj_TabIndexChanged);
            this.tbCpfCnpj.TextChanged += new System.EventHandler(this.tbCpfCnpj_TextChanged);
            this.tbCpfCnpj.Leave += new System.EventHandler(this.tbCpfCnpj_Leave);
            // 
            // tbDatNasc
            // 
            this.tbDatNasc.TabIndex = 6;
            // 
            // tbApelido
            // 
            this.tbApelido.TabIndex = 5;
            // 
            // btnSair
            // 
            this.btnSair.TabIndex = 17;
            // 
            // tbRG
            // 
            this.tbRG.Location = new System.Drawing.Point(726, 64);
            this.tbRG.Mask = "##.###.###-#";
            this.tbRG.Name = "tbRG";
            this.tbRG.Size = new System.Drawing.Size(109, 22);
            this.tbRG.TabIndex = 4;
            this.tbRG.Leave += new System.EventHandler(this.tbRG_Leave);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(726, 42);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(29, 17);
            this.label20.TabIndex = 45;
            this.label20.Text = "RG";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(669, 524);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 16;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // tbSexo
            // 
            this.tbSexo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbSexo.Location = new System.Drawing.Point(488, 64);
            this.tbSexo.Name = "tbSexo";
            this.tbSexo.Size = new System.Drawing.Size(64, 22);
            this.tbSexo.TabIndex = 2;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(485, 42);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(39, 17);
            this.label18.TabIndex = 48;
            this.label18.Text = "Sexo";
            // 
            // tbCidadeDesc
            // 
            this.tbCidadeDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbCidadeDesc.Enabled = false;
            this.tbCidadeDesc.Location = new System.Drawing.Point(220, 302);
            this.tbCidadeDesc.Name = "tbCidadeDesc";
            this.tbCidadeDesc.Size = new System.Drawing.Size(164, 22);
            this.tbCidadeDesc.TabIndex = 49;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(426, 282);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 17);
            this.label12.TabIndex = 50;
            this.label12.Text = "CEP";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(227, 282);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(52, 17);
            this.label21.TabIndex = 51;
            this.label21.Text = "Cidade";
            // 
            // btnPesquisarEstado
            // 
            this.btnPesquisarEstado.Location = new System.Drawing.Point(49, 344);
            this.btnPesquisarEstado.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisarEstado.Name = "btnPesquisarEstado";
            this.btnPesquisarEstado.Size = new System.Drawing.Size(91, 23);
            this.btnPesquisarEstado.TabIndex = 13;
            this.btnPesquisarEstado.Text = "Pesquisar";
            this.btnPesquisarEstado.UseVisualStyleBackColor = true;
            this.btnPesquisarEstado.Click += new System.EventHandler(this.btnPesquisarEstado_Click);
            // 
            // tbCondicaoPagamento
            // 
            this.tbCondicaoPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbCondicaoPagamento.Enabled = false;
            this.tbCondicaoPagamento.Location = new System.Drawing.Point(558, 368);
            this.tbCondicaoPagamento.Name = "tbCondicaoPagamento";
            this.tbCondicaoPagamento.Size = new System.Drawing.Size(164, 22);
            this.tbCondicaoPagamento.TabIndex = 52;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(744, 368);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(555, 348);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(163, 17);
            this.label22.TabIndex = 54;
            this.label22.Text = "Condição de Pagamento";
            // 
            // tbIdeCondicao
            // 
            this.tbIdeCondicao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbIdeCondicao.Enabled = false;
            this.tbIdeCondicao.Location = new System.Drawing.Point(428, 369);
            this.tbIdeCondicao.Name = "tbIdeCondicao";
            this.tbIdeCondicao.Size = new System.Drawing.Size(65, 22);
            this.tbIdeCondicao.TabIndex = 55;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(425, 349);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(115, 17);
            this.label23.TabIndex = 56;
            this.label23.Text = "Codigo Condição";
            // 
            // FrmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(891, 581);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.tbIdeCondicao);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbCondicaoPagamento);
            this.Controls.Add(this.btnPesquisarEstado);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbCidadeDesc);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.tbSexo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.tbRG);
            this.Name = "FrmCadastroCliente";
            this.Text = "Cadastro de Cliente";
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
            this.Controls.SetChildIndex(this.tbRG, 0);
            this.Controls.SetChildIndex(this.label20, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.tbSexo, 0);
            this.Controls.SetChildIndex(this.label18, 0);
            this.Controls.SetChildIndex(this.tbCidadeDesc, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.label21, 0);
            this.Controls.SetChildIndex(this.btnPesquisarEstado, 0);
            this.Controls.SetChildIndex(this.tbCondicaoPagamento, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.label22, 0);
            this.Controls.SetChildIndex(this.tbIdeCondicao, 0);
            this.Controls.SetChildIndex(this.label23, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox tbRG;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox tbSexo;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbCidadeDesc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnPesquisarEstado;
        private System.Windows.Forms.TextBox tbCondicaoPagamento;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tbIdeCondicao;
        private System.Windows.Forms.Label label23;
    }
}
