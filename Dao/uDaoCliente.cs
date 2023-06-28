using MySql.Data.MySqlClient;
using Sistema__Renovo_Barber.Controllers;
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
            cli.numero, cli.complemento, cli.bairro,cid.nome as cidade, cli.data_nasc, cli.data_criacao, 
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
        public void Alterar(uCliente Obj)
        {
            try
            {
                string Sql = @"update tb_clientes set status_cliente = @status_cliente, nome = @nome, 
                                sexo = @sexo, apelido = @apelido, rg = @rg, cpf = @cpf, email = @email, 
                                telefone = @telefone, celular = @celular, cep = @cep, endereco = @endereco, 
                                numero = @numero, complemento = @complemento, bairro = @bairro, 
                                id_cidade = @id_cidade, data_nasc = @data_nasc, data_ult_alteracao = @data_ult_alteracao 
                                where id_cliente = @id_cliente";
                MySqlCommand ExecutaCmd = new MySqlCommand(Sql, ConexaoBanco);
                ExecutaCmd.Parameters.AddWithValue("@id_cliente", Obj.id);
                ExecutaCmd.Parameters.AddWithValue("@status_cliente", Obj.Status);
                ExecutaCmd.Parameters.AddWithValue("@nome", Obj.Nome);
                ExecutaCmd.Parameters.AddWithValue("@sexo", Obj.Sexo);
                ExecutaCmd.Parameters.AddWithValue("@apelido", Obj.Apelido);
                ExecutaCmd.Parameters.AddWithValue("@rg", Obj.RG);
                ExecutaCmd.Parameters.AddWithValue("@cep", Obj.CEP);
                ExecutaCmd.Parameters.AddWithValue("@cpf", Obj.CPF);
                ExecutaCmd.Parameters.AddWithValue("@email", Obj.Email);
                ExecutaCmd.Parameters.AddWithValue("@telefone", Obj.Telefone);
                ExecutaCmd.Parameters.AddWithValue("@celular", Obj.Celular);
                ExecutaCmd.Parameters.AddWithValue("@endereco", Obj.Endereco);
                ExecutaCmd.Parameters.AddWithValue("@numero", Obj.Numero);
                ExecutaCmd.Parameters.AddWithValue("@complemento", Obj.Complemento);
                ExecutaCmd.Parameters.AddWithValue("@bairro", Obj.Bairro);
                ExecutaCmd.Parameters.AddWithValue("@id_cidade", Obj.Cidade.id);
                ExecutaCmd.Parameters.AddWithValue("@data_nasc", Obj.Data_nasc);
                ExecutaCmd.Parameters.AddWithValue("@data_ult_alteracao", Obj.data_ult_alteracao);
                ConexaoBanco.Open();
                ExecutaCmd.ExecuteNonQuery();
                MessageBox.Show("Cliente alterado com sucesso!");
                ConexaoBanco.Close();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Aconteceu o Erro: " + Erro);
            }
        }
        public uCliente Selecionar(int Id)
        {
            try
            {
                uCtrlCidades CtrlCidades = new uCtrlCidades();
                string Sql = "select * from tb_clientes where id_cliente = @id_cliente";
                MySqlCommand ExecutaCmd = new MySqlCommand(Sql, ConexaoBanco);
                ExecutaCmd.Parameters.AddWithValue("@id_cliente", Id);
                ConexaoBanco.Open();
                using (var reader = ExecutaCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        uCliente Obj = new uCliente
                        {
                            id = Convert.ToInt32(reader["id_cliente"]),
                            Nome = Convert.ToString(reader["nome"]),
                            Sexo = Convert.ToString(reader["sexo"]),
                            CPF = Convert.ToString(reader["cpf"]),
                            RG = Convert.ToString(reader["rg"]),
                            Status = Convert.ToString(reader["status_cliente"]),
                            Apelido = Convert.ToString(reader["apelido"]),
                            Data_nasc = Convert.ToDateTime(reader["data_nasc"]),
                            Email = Convert.ToString(reader["email"]),
                            Endereco = Convert.ToString(reader["endereco"]),
                            Numero = Convert.ToInt32(reader["numero"]),
                            Bairro = Convert.ToString(reader["bairro"]),
                            Complemento = Convert.ToString(reader["complemento"]),
                            Telefone = Convert.ToString(reader["telefone"]),
                            Cidade = CtrlCidades.Carregar(Convert.ToInt32(reader["id_cidade"])),
                            CEP = Convert.ToString(reader["cep"]),
                            Celular = Convert.ToString(reader["celular"]),
                            data_criacao = Convert.ToDateTime(reader["data_criacao"]),
                            data_ult_alteracao = Convert.ToDateTime(reader["data_ult_alteracao"])
                        };
                        ConexaoBanco.Close();
                        return Obj;
                    }
                }
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Aconteceu o Erro: " + Erro);
            }
            ConexaoBanco.Close();
            return null;
        }
        public void Salvar(uCliente Obj)
        {
            try
            {
                string Sql = @"insert into tb_clientes (nome, sexo, apelido, status_cliente, rg, cpf, email, telefone, celular, cep, endereco, numero, complemento, bairro, id_cidade, data_nasc,  data_criacao, data_ult_alteracao)
                             values (@nome, @sexo, @apelido, @status_cliente, @rg, @cpf, @email, @telefone, @celular, @cep, @endereco, @numero, @complemento, @bairro, @id_cidade, @data_nasc, @data_criacao, @data_ult_alteracao)";

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
                ExecutaComando.Parameters.AddWithValue("@data_nasc", Obj.Data_nasc);
                ExecutaComando.Parameters.AddWithValue("@data_criacao", Obj.data_criacao);
                ExecutaComando.Parameters.AddWithValue("@data_ult_alteracao", Obj.data_ult_alteracao);

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
