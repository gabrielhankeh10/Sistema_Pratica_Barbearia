
namespace Sistema__Renovo_Barber.Formularios
{
    partial class FrmConsultaCliente
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
            this.DgConsultaClientes = new System.Windows.Forms.DataGridView();
            this.id_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apelido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_nasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_criacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_ult_alteracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgConsultaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // DgConsultaClientes
            // 
            this.DgConsultaClientes.AllowUserToAddRows = false;
            this.DgConsultaClientes.AllowUserToDeleteRows = false;
            this.DgConsultaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgConsultaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_cliente,
            this.status_cliente,
            this.nome,
            this.apelido,
            this.sexo,
            this.rg,
            this.cpf,
            this.email,
            this.telefone,
            this.celular,
            this.cep,
            this.endereco,
            this.numero,
            this.complemento,
            this.bairro,
            this.cidade,
            this.data_nasc,
            this.data_criacao,
            this.data_ult_alteracao});
            this.DgConsultaClientes.Location = new System.Drawing.Point(54, 72);
            this.DgConsultaClientes.MultiSelect = false;
            this.DgConsultaClientes.Name = "DgConsultaClientes";
            this.DgConsultaClientes.ReadOnly = true;
            this.DgConsultaClientes.RowHeadersWidth = 51;
            this.DgConsultaClientes.RowTemplate.Height = 24;
            this.DgConsultaClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgConsultaClientes.Size = new System.Drawing.Size(782, 437);
            this.DgConsultaClientes.TabIndex = 9;
            this.DgConsultaClientes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgConsultaClientes_CellContentDoubleClick);
            this.DgConsultaClientes.DoubleClick += new System.EventHandler(this.DgConsultaClientes_DoubleClick);
            this.DgConsultaClientes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DgConsultaClientes_KeyPress);
            // 
            // id_cliente
            // 
            this.id_cliente.HeaderText = "ID Cliente";
            this.id_cliente.MinimumWidth = 6;
            this.id_cliente.Name = "id_cliente";
            this.id_cliente.ReadOnly = true;
            this.id_cliente.Width = 125;
            // 
            // status_cliente
            // 
            this.status_cliente.HeaderText = "Status Cliente";
            this.status_cliente.MinimumWidth = 6;
            this.status_cliente.Name = "status_cliente";
            this.status_cliente.ReadOnly = true;
            this.status_cliente.Width = 125;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.MinimumWidth = 6;
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 125;
            // 
            // apelido
            // 
            this.apelido.HeaderText = "Apelido";
            this.apelido.MinimumWidth = 6;
            this.apelido.Name = "apelido";
            this.apelido.ReadOnly = true;
            this.apelido.Width = 125;
            // 
            // sexo
            // 
            this.sexo.HeaderText = "Sexo";
            this.sexo.MinimumWidth = 6;
            this.sexo.Name = "sexo";
            this.sexo.ReadOnly = true;
            this.sexo.Width = 125;
            // 
            // rg
            // 
            this.rg.HeaderText = "RG";
            this.rg.MinimumWidth = 6;
            this.rg.Name = "rg";
            this.rg.ReadOnly = true;
            this.rg.Width = 125;
            // 
            // cpf
            // 
            this.cpf.HeaderText = "CPF";
            this.cpf.MinimumWidth = 6;
            this.cpf.Name = "cpf";
            this.cpf.ReadOnly = true;
            this.cpf.Width = 125;
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
            this.endereco.HeaderText = "Endereco";
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
            // cidade
            // 
            this.cidade.HeaderText = "Cidade";
            this.cidade.MinimumWidth = 6;
            this.cidade.Name = "cidade";
            this.cidade.ReadOnly = true;
            this.cidade.Width = 125;
            // 
            // data_nasc
            // 
            this.data_nasc.HeaderText = "Data de Nascimento";
            this.data_nasc.MinimumWidth = 6;
            this.data_nasc.Name = "data_nasc";
            this.data_nasc.ReadOnly = true;
            this.data_nasc.Width = 125;
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
            this.data_ult_alteracao.HeaderText = "Data Ultima Alteração";
            this.data_ult_alteracao.MinimumWidth = 6;
            this.data_ult_alteracao.Name = "data_ult_alteracao";
            this.data_ult_alteracao.ReadOnly = true;
            this.data_ult_alteracao.Width = 125;
            // 
            // FrmConsultaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(891, 581);
            this.Controls.Add(this.DgConsultaClientes);
            this.Name = "FrmConsultaCliente";
            this.Text = "Consulta de Clientes";
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.btnAlterar, 0);
            this.Controls.SetChildIndex(this.btnIncluir, 0);
            this.Controls.SetChildIndex(this.tbPesquisar, 0);
            this.Controls.SetChildIndex(this.btnPesquisar, 0);
            this.Controls.SetChildIndex(this.DgConsultaClientes, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DgConsultaClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgConsultaClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn apelido;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn rg;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn complemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_nasc;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_criacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_ult_alteracao;
    }
}
