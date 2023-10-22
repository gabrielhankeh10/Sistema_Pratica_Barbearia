
namespace Sistema__Renovo_Barber.Formularios
{
    partial class FrmConsultaContasReceber
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
            this.DgConsultaReceber = new System.Windows.Forms.DataGridView();
            this.id_fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_fantasia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razao_social = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_fundacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insc_municipal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insc_estadual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_criacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_ult_alteracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgConsultaReceber)).BeginInit();
            this.SuspendLayout();
            // 
            // DgConsultaReceber
            // 
            this.DgConsultaReceber.AllowUserToAddRows = false;
            this.DgConsultaReceber.AllowUserToDeleteRows = false;
            this.DgConsultaReceber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgConsultaReceber.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_fornecedor,
            this.status_fornecedor,
            this.nome_fantasia,
            this.razao_social,
            this.cidade,
            this.data_fundacao,
            this.insc_municipal,
            this.insc_estadual,
            this.cnpj,
            this.email,
            this.telefone,
            this.celular,
            this.cep,
            this.endereco,
            this.numero,
            this.complemento,
            this.bairro,
            this.data_criacao,
            this.data_ult_alteracao});
            this.DgConsultaReceber.Location = new System.Drawing.Point(54, 72);
            this.DgConsultaReceber.MultiSelect = false;
            this.DgConsultaReceber.Name = "DgConsultaReceber";
            this.DgConsultaReceber.ReadOnly = true;
            this.DgConsultaReceber.RowHeadersWidth = 51;
            this.DgConsultaReceber.RowTemplate.Height = 24;
            this.DgConsultaReceber.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgConsultaReceber.Size = new System.Drawing.Size(782, 437);
            this.DgConsultaReceber.TabIndex = 11;
            // 
            // id_fornecedor
            // 
            this.id_fornecedor.HeaderText = "ID Fornecedor";
            this.id_fornecedor.MinimumWidth = 6;
            this.id_fornecedor.Name = "id_fornecedor";
            this.id_fornecedor.ReadOnly = true;
            this.id_fornecedor.Width = 125;
            // 
            // status_fornecedor
            // 
            this.status_fornecedor.HeaderText = "Status";
            this.status_fornecedor.MinimumWidth = 6;
            this.status_fornecedor.Name = "status_fornecedor";
            this.status_fornecedor.ReadOnly = true;
            this.status_fornecedor.Width = 125;
            // 
            // nome_fantasia
            // 
            this.nome_fantasia.HeaderText = "Nome Fantasia";
            this.nome_fantasia.MinimumWidth = 6;
            this.nome_fantasia.Name = "nome_fantasia";
            this.nome_fantasia.ReadOnly = true;
            this.nome_fantasia.Width = 125;
            // 
            // razao_social
            // 
            this.razao_social.HeaderText = "Razao Social";
            this.razao_social.MinimumWidth = 6;
            this.razao_social.Name = "razao_social";
            this.razao_social.ReadOnly = true;
            this.razao_social.Width = 125;
            // 
            // cidade
            // 
            this.cidade.HeaderText = "Cidade";
            this.cidade.MinimumWidth = 6;
            this.cidade.Name = "cidade";
            this.cidade.ReadOnly = true;
            this.cidade.Width = 125;
            // 
            // data_fundacao
            // 
            this.data_fundacao.HeaderText = "Data Fundação";
            this.data_fundacao.MinimumWidth = 6;
            this.data_fundacao.Name = "data_fundacao";
            this.data_fundacao.ReadOnly = true;
            this.data_fundacao.Width = 125;
            // 
            // insc_municipal
            // 
            this.insc_municipal.HeaderText = "Inscrição Municipal";
            this.insc_municipal.MinimumWidth = 6;
            this.insc_municipal.Name = "insc_municipal";
            this.insc_municipal.ReadOnly = true;
            this.insc_municipal.Width = 125;
            // 
            // insc_estadual
            // 
            this.insc_estadual.HeaderText = "Inscrição Estatual";
            this.insc_estadual.MinimumWidth = 6;
            this.insc_estadual.Name = "insc_estadual";
            this.insc_estadual.ReadOnly = true;
            this.insc_estadual.Width = 125;
            // 
            // cnpj
            // 
            this.cnpj.HeaderText = "CNPJ";
            this.cnpj.MinimumWidth = 6;
            this.cnpj.Name = "cnpj";
            this.cnpj.ReadOnly = true;
            this.cnpj.Width = 125;
            // 
            // email
            // 
            this.email.HeaderText = "E-mail";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 125;
            // 
            // telefone
            // 
            this.telefone.HeaderText = "Telefone";
            this.telefone.MinimumWidth = 6;
            this.telefone.Name = "telefone";
            this.telefone.ReadOnly = true;
            this.telefone.Width = 125;
            // 
            // celular
            // 
            this.celular.HeaderText = "Celular";
            this.celular.MinimumWidth = 6;
            this.celular.Name = "celular";
            this.celular.ReadOnly = true;
            this.celular.Width = 125;
            // 
            // cep
            // 
            this.cep.HeaderText = "CEP";
            this.cep.MinimumWidth = 6;
            this.cep.Name = "cep";
            this.cep.ReadOnly = true;
            this.cep.Width = 125;
            // 
            // endereco
            // 
            this.endereco.HeaderText = "Endereço";
            this.endereco.MinimumWidth = 6;
            this.endereco.Name = "endereco";
            this.endereco.ReadOnly = true;
            this.endereco.Width = 125;
            // 
            // numero
            // 
            this.numero.HeaderText = "Numero";
            this.numero.MinimumWidth = 6;
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            this.numero.Width = 125;
            // 
            // complemento
            // 
            this.complemento.HeaderText = "Complemento";
            this.complemento.MinimumWidth = 6;
            this.complemento.Name = "complemento";
            this.complemento.ReadOnly = true;
            this.complemento.Width = 125;
            // 
            // bairro
            // 
            this.bairro.HeaderText = "Bairro";
            this.bairro.MinimumWidth = 6;
            this.bairro.Name = "bairro";
            this.bairro.ReadOnly = true;
            this.bairro.Width = 125;
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
            // FrmConsultaContasReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(891, 581);
            this.Controls.Add(this.DgConsultaReceber);
            this.Name = "FrmConsultaContasReceber";
            this.Text = "Consulta Contas Receber";
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.btnAlterar, 0);
            this.Controls.SetChildIndex(this.btnIncluir, 0);
            this.Controls.SetChildIndex(this.tbPesquisar, 0);
            this.Controls.SetChildIndex(this.btnPesquisar, 0);
            this.Controls.SetChildIndex(this.DgConsultaReceber, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DgConsultaReceber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgConsultaReceber;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_fantasia;
        private System.Windows.Forms.DataGridViewTextBoxColumn razao_social;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_fundacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn insc_municipal;
        private System.Windows.Forms.DataGridViewTextBoxColumn insc_estadual;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn complemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_criacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_ult_alteracao;
    }
}
