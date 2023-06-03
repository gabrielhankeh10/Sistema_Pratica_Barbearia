using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema__Renovo_Barber.Dao
{
    public class uDaoCliente :uDao
    {
        private MySqlConnection ConexaoBanco;
        public uDaoCliente()
        {
            this.ConexaoBanco = new Conexao().GetConnection();
        }
        public DataTable PopularGrid()
        {
            string Sql = @"select cli.id_cliente, 
			case when cli.status_cliente = 'A' then 'Ativo' else 'Inativo' end status_cliente, cli.nome, cli.apelido, 
            cli.sexo, cli.rg, cli.cpf, cli.email, cli.telefone, cli.celular, cli.cep,cli.endereco,
            cli.numero, cli.complemento, cli.bairro,cid.nome as cidade, cli.data_criacao, 
            cli.data_ult_alteracao from tb_clientes cli left join tb_cidades cid on 
            cid.id_cidade = cli.id_cidade";

            MySqlCommand ExecutaCmd = new MySqlCommand(Sql, ConexaoBanco);
            ExecutaCmd.CommandType = CommandType.Text;

            DataTable Dt = new DataTable();
            try
            {
                ConexaoBanco.Open();
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(Sql, ConexaoBanco);
                sqlDataAdapter.Fill(Dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
            finally
            {
                ConexaoBanco.Close();
            }
            return Dt;
        }

        public void Salvar(uCliente Obj)
        {
            try
            {
                string Sql = @"insert into tb_clientes (nome, sexo, apelido, status_cliente, rg, cpf, email, telefone, celular, cep, endereco, numero, complemento, bairro, id_cidade, data_criacao)
                             values (@nome, @sexo, @apelido, @status_cliente, @rg, @cpf, @email, @telefone, @celular, @cep, @endereco, @numero, @complemento, @bairro, @id_cidade, @data_criacao)";

                MySqlCommand ExecutaComando = new MySqlCommand(Sql, ConexaoBanco);
                ExecutaComando.Parameters.AddWithValue("@nome", Obj.Pessoa.Nome);
                ExecutaComando.Parameters.AddWithValue("@sexo", Obj.Sexo);
                ExecutaComando.Parameters.AddWithValue("@apelido", Obj.Apelido);
                ExecutaComando.Parameters.AddWithValue("@status_cliente", "A");
                ExecutaComando.Parameters.AddWithValue("@rg", Obj.RG);
                ExecutaComando.Parameters.AddWithValue("@cpf", Obj.CPF);
                ExecutaComando.Parameters.AddWithValue("@email", Obj.Email);
                ExecutaComando.Parameters.AddWithValue("@telefone", Obj.Telefone);
                ExecutaComando.Parameters.AddWithValue("@celular", Obj.Celular);
                ExecutaComando.Parameters.AddWithValue("@cep", Obj.CEP);
                ExecutaComando.Parameters.AddWithValue("@endereco", Obj.Endereco);
                ExecutaComando.Parameters.AddWithValue("@numero", Obj.Numero);
                ExecutaComando.Parameters.AddWithValue("@complemento", Obj.Complemento);
                ExecutaComando.Parameters.AddWithValue("@bairro", Obj.Bairro);
                ExecutaComando.Parameters.AddWithValue("@id_cidade", Obj.Cidade.id);
                ExecutaComando.Parameters.AddWithValue("@data_criacao", Obj.data_criacao);

                ConexaoBanco.Open();
                ExecutaComando.ExecuteNonQuery();
                MessageBox.Show("Cliente cadastrado com sucesso!");
                ConexaoBanco.Close();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Aconteceu o Erro: " + Erro);
            }
        }
    }
}
