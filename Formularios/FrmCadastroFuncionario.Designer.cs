
namespace Sistema__Renovo_Barber.Formularios
{
    partial class FrmCadastroFuncionario
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
            this.tbSexo = new System.Windows.Forms.TextBox();
            this.tbRG = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Sexo = new System.Windows.Forms.Label();
            this.tbCargo = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tbCargoDesc = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tbCidadeDesc = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.btnPesquisarCidade = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.TbCEP.TabIndex = 13;
            // 
            // tbCelular
            // 
            this.tbCelular.TabIndex = 14;
            // 
            // TbTelefone
            // 
            this.TbTelefone.TabIndex = 11;
            // 
            // tbNome
            // 
            this.tbNome.TabIndex = 0;
            // 
            // tbEmail
            // 
            this.tbEmail.TabIndex = 6;
            this.tbEmail.Leave += new System.EventHandler(this.tbEmail_Leave);
            // 
            // tbEndereco
            // 
            this.tbEndereco.TabIndex = 7;
            // 
            // tbNumero
            // 
            this.tbNumero.TabIndex = 8;
            // 
            // tbBairro
            // 
            this.tbBairro.TabIndex = 9;
            // 
            // tbComplemento
            // 
            this.tbComplemento.TabIndex = 10;
            // 
            // tbCidade
            // 
            this.tbCidade.Size = new System.Drawing.Size(89, 22);
            // 
            // tbCpfCnpj
            // 
            this.tbCpfCnpj.Mask = "###.###.###-##";
            this.tbCpfCnpj.Size = new System.Drawing.Size(125, 22);
            this.tbCpfCnpj.TabIndex = 2;
            this.tbCpfCnpj.Leave += new System.EventHandler(this.tbCpfCnpj_Leave);
            // 
            // tbDatNasc
            // 
            this.tbDatNasc.TabIndex = 5;
            // 
            // tbApelido
            // 
            this.tbApelido.TabIndex = 4;
            // 
            // btnSair
            // 
            this.btnSair.TabIndex = 17;
            // 
            // tbSexo
            // 
            this.tbSexo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbSexo.Location = new System.Drawing.Point(488, 64);
            this.tbSexo.Name = "tbSexo";
            this.tbSexo.Size = new System.Drawing.Size(60, 22);
            this.tbSexo.TabIndex = 1;
            // 
            // tbRG
            // 
            this.tbRG.Location = new System.Drawing.Point(735, 64);
            this.tbRG.Mask = "##.###.###-#";
            this.tbRG.Name = "tbRG";
            this.tbRG.Size = new System.Drawing.Size(100, 22);
            this.tbRG.TabIndex = 3;
            this.tbRG.Leave += new System.EventHandler(this.tbRG_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(732, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 17);
            this.label12.TabIndex = 46;
            this.label12.Text = "RG";
            // 
            // Sexo
            // 
            this.Sexo.AutoSize = true;
            this.Sexo.Location = new System.Drawing.Point(485, 42);
            this.Sexo.Name = "Sexo";
            this.Sexo.Size = new System.Drawing.Size(39, 17);
            this.Sexo.TabIndex = 48;
            this.Sexo.Text = "Sexo";
            // 
            // tbCargo
            // 
            this.tbCargo.Enabled = false;
            this.tbCargo.Location = new System.Drawing.Point(49, 362);
            this.tbCargo.Name = "tbCargo";
            this.tbCargo.Size = new System.Drawing.Size(89, 22);
            this.tbCargo.TabIndex = 49;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(154, 340);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(46, 17);
            this.label20.TabIndex = 50;
            this.label20.Text = "Cargo";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(668, 524);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 16;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // tbCargoDesc
            // 
            this.tbCargoDesc.Enabled = false;
            this.tbCargoDesc.Location = new System.Drawing.Point(157, 362);
            this.tbCargoDesc.Name = "tbCargoDesc";
            this.tbCargoDesc.Size = new System.Drawing.Size(149, 22);
            this.tbCargoDesc.TabIndex = 54;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(46, 340);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(63, 17);
            this.label21.TabIndex = 55;
            this.label21.Text = "ID Cargo";
            // 
            // tbCidadeDesc
            // 
            this.tbCidadeDesc.Enabled = false;
            this.tbCidadeDesc.Location = new System.Drawing.Point(157, 302);
            this.tbCidadeDesc.Name = "tbCidadeDesc";
            this.tbCidadeDesc.Size = new System.Drawing.Size(149, 22);
            this.tbCidadeDesc.TabIndex = 56;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(154, 282);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(52, 17);
            this.label22.TabIndex = 57;
            this.label22.Text = "Cidade";
            // 
            // btnPesquisarCidade
            // 
            this.btnPesquisarCidade.Location = new System.Drawing.Point(319, 302);
            this.btnPesquisarCidade.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisarCidade.Name = "btnPesquisarCidade";
            this.btnPesquisarCidade.Size = new System.Drawing.Size(91, 23);
            this.btnPesquisarCidade.TabIndex = 12;
            this.btnPesquisarCidade.Text = "Pesquisar";
            this.btnPesquisarCidade.UseVisualStyleBackColor = true;
            this.btnPesquisarCidade.Click += new System.EventHandler(this.btnPesquisarCidade_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(319, 361);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmCadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(887, 593);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPesquisarCidade);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.tbCidadeDesc);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.tbCargoDesc);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.tbCargo);
            this.Controls.Add(this.Sexo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbRG);
            this.Controls.Add(this.tbSexo);
            this.Name = "FrmCadastroFuncionario";
            this.Text = "Cadastro de Funcionario";
            this.Controls.SetChildIndex(this.tbSexo, 0);
            this.Controls.SetChildIndex(this.tbRG, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.Sexo, 0);
            this.Controls.SetChildIndex(this.tbCargo, 0);
            this.Controls.SetChildIndex(this.label20, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.tbCargoDesc, 0);
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
            this.Controls.SetChildIndex(this.label21, 0);
            this.Controls.SetChildIndex(this.tbCidadeDesc, 0);
            this.Controls.SetChildIndex(this.label22, 0);
            this.Controls.SetChildIndex(this.btnPesquisarCidade, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSexo;
        private System.Windows.Forms.MaskedTextBox tbRG;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label Sexo;
        private System.Windows.Forms.TextBox tbCargo;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox tbCargoDesc;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tbCidadeDesc;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnPesquisarCidade;
        private System.Windows.Forms.Button button1;
    }
}
