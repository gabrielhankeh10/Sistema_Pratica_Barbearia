using MySql.Data.MySqlClient;
using Sistema__Renovo_Barber.Classes;
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
    public class uDaoFuncionarios : uDao
    {
        private MySqlConnection ConexaoBanco;
        public uDaoFuncionarios()
        {
            this.ConexaoBanco = new Conexao().GetConnection();
        }
        public DataTable PopularGrid()
        {
            string Sql = @"select fun.id_funcionario, case when fun.status_funcionario = 'A' then 'Ativo' else 'Inativo' end status_funcionario,
                    fun.nome, car.cargo, cid.nome as cidade, fun.sexo, fun.rg, fun.cpf, fun.email, fun.telefone, fun.celular, fun.cep, 
                    fun.endereco, fun.numero,fun.complemento, fun.data_nasc, fun.data_criacao, fun.data_ult_alteracao from 
                    tb_funcionarios fun left join tb_cargos car on car.id_cargo = fun.id_cargo 
                    left join tb_cidades cid on cid.id_cidade = fun.id_cidade";

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
        public void Excluir(uFuncionario Obj)
        {
            try
            {
                string Sql = "delete from tb_funcionarios where id_funcionario = @id_funcionario";

                MySqlCommand ExecutaCmd = new MySqlCommand(Sql, ConexaoBanco);
                ExecutaCmd.Parameters.AddWithValue("@id_funcionario", Obj.id);
                ConexaoBanco.Open();
                ExecutaCmd.ExecuteNonQuery();
                MessageBox.Show("Funcionario excluido com sucesso!");

                ConexaoBanco.Close();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Aconteceu o Erro: " + Erro);
            }
        }
        public uFuncionario SelecionarNome(string Nome)
        {
            try
            {
                string Sql = "select * from tb_funcionarios where nome like @nome";
                MySqlCommand ExecutaCmd = new MySqlCommand(Sql, ConexaoBanco);
                ExecutaCmd.Parameters.AddWithValue("@nome", "%" + Nome + "%");
                ConexaoBanco.Open();
                using (var reader = ExecutaCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        uFuncionario Obj = new uFuncionario
                        {
                            Nome = Convert.ToString(reader["nome"])
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
        public void Alterar(uFuncionario Obj)
        {
            try
            {
                string Sql = @"update tb_funcionarios set status_funcionario = @status_funcionario, nome = @nome, sexo = @sexo,
                                rg = @rg, cpf = @cpf, email = @email, senha = @senha, telefone = @telefone, celular = @celular,
                                cep = @cep, endereco = @endereco, numero = @numero, complemento = @complemento, data_nasc = @data_nasc,
                                data_ult_alteracao = @data_ult_alteracao , id_cargo = @id_cargo, id_cidade = @id_cidade, apelido = @apelido,
                                bairro = @bairro where id_funcionario = @id_funcionario";
                MySqlCommand ExecutaCmd = new MySqlCommand(Sql, ConexaoBanco);
                ExecutaCmd.Parameters.AddWithValue("@id_funcionario", Obj.id);
                ExecutaCmd.Parameters.AddWithValue("@status_funcionario", Obj.Status);
                ExecutaCmd.Parameters.AddWithValue("@nome", Obj.Nome);
                ExecutaCmd.Parameters.AddWithValue("@sexo", Obj.Sexo);
                ExecutaCmd.Parameters.AddWithValue("@rg", Obj.RG);
                ExecutaCmd.Parameters.AddWithValue("@cpf", Obj.CPF);
                ExecutaCmd.Parameters.AddWithValue("@email", Obj.Email);
                ExecutaCmd.Parameters.AddWithValue("@senha", Obj.Senha);
                ExecutaCmd.Parameters.AddWithValue("@telefone", Obj.Telefone);
                ExecutaCmd.Parameters.AddWithValue("@celular", Obj.Celular);
                ExecutaCmd.Parameters.AddWithValue("@cep", Obj.CEP);
                ExecutaCmd.Parameters.AddWithValue("@endereco", Obj.Endereco);
                ExecutaCmd.Parameters.AddWithValue("@numero", Obj.Numero);
                ExecutaCmd.Parameters.AddWithValue("@complemento", Obj.Complemento);
                ExecutaCmd.Parameters.AddWithValue("@id_cargo", Obj.Cargos.id);
                ExecutaCmd.Parameters.AddWithValue("@id_cidade", Obj.Cidade.id);
                ExecutaCmd.Parameters.AddWithValue("@data_ult_alteracao", Obj.data_ult_alteracao);
                ExecutaCmd.Parameters.AddWithValue("@data_nasc", Obj.Data_nasc);
                ExecutaCmd.Parameters.AddWithValue("@apelido", Obj.Apelido);
                ExecutaCmd.Parameters.AddWithValue("@bairro", Obj.Bairro);
                ConexaoBanco.Open();
                ExecutaCmd.ExecuteNonQuery();
                MessageBox.Show("Funcionario alterado com sucesso!");
                ConexaoBanco.Close();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Aconteceu o Erro: " + Erro);
            }
        }

        public uFuncionario Selecionar(int Id)
        {
            try
            {
                uCtrlCidades CtrlCidades = new uCtrlCidades();
                uCtrlCargos CtrlCargos = new uCtrlCargos();
                string Sql = "select * from tb_funcionarios where id_funcionario = @id_funcionario";
                MySqlCommand ExecutaCmd = new MySqlCommand(Sql, ConexaoBanco);
                ExecutaCmd.Parameters.AddWithValue("@id_funcionario", Id);
                ConexaoBanco.Open();
                using (var reader = ExecutaCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        uFuncionario Obj = new uFuncionario
                        {
                            id = Convert.ToInt32(reader["id_funcionario"]),
                            Status = Convert.ToString(reader["status_funcionario"]),
                            Nome = Convert.ToString(reader["nome"]),
                            Sexo = Convert.ToString(reader["sexo"]),
                            RG = Convert.ToString(reader["rg"]),
                            CPF = Convert.ToString(reader["cpf"]),
                            Email = Convert.ToString(reader["email"]),
                            Senha = Convert.ToString(reader["senha"]),
                            Telefone = Convert.ToString(reader["telefone"]),
                            Celular = Convert.ToString(reader["celular"]),
                            CEP = Convert.ToString(reader["cep"]),
                            Endereco = Convert.ToString(reader["endereco"]),
                            Numero = Convert.ToInt32(reader["numero"]),
                            Complemento = Convert.ToString(reader["complemento"]),
                            Data_nasc = Convert.ToDateTime(reader["data_nasc"]),
                            data_criacao = Convert.ToDateTime(reader["data_criacao"]),
                            data_ult_alteracao = Convert.ToDateTime(reader["data_ult_alteracao"]),
                            Cidade = CtrlCidades.Carregar(Convert.ToInt32(reader["id_cidade"])),
                            Cargos = CtrlCargos.Carregar(Convert.ToInt32(reader["id_cargo"])),
                            Apelido = Convert.ToString(reader["apelido"]),
                            Bairro = Convert.ToString(reader["bairro"])
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


        public void Salvar (uFuncionario Obj)
        {
            try
            {
                string Sql = @"insert into tb_funcionarios (status_funcionario, nome, sexo, rg, cpf, email, senha, telefone, celular, cep, endereco, numero, complemento, data_criacao, id_cargo, id_cidade, data_ult_alteracao, data_nasc, apelido, bairro) 
                                values (@status_funcionario, @nome, @sexo, @rg, @cpf, @email, @senha, @telefone, @celular, @cep, @endereco, @numero, @complemento, @data_criacao, @id_cargo, @id_cidade, @data_ult_alteracao, @data_nasc, @apelido, @bairro)";

                MySqlCommand ExecutaComando = new MySqlCommand(Sql, ConexaoBanco);
                ExecutaComando.Parameters.AddWithValue("@status_funcionario", "A");
                ExecutaComando.Parameters.AddWithValue("@nome", Obj.Nome);
                ExecutaComando.Parameters.AddWithValue("@sexo", Obj.Sexo);
                ExecutaComando.Parameters.AddWithValue("@rg", Obj.RG);
                ExecutaComando.Parameters.AddWithValue("@cpf", Obj.CPF);
                ExecutaComando.Parameters.AddWithValue("@email", Obj.Email);
                ExecutaComando.Parameters.AddWithValue("@senha", Obj.Senha);
                ExecutaComando.Parameters.AddWithValue("@telefone", Obj.Telefone);
                ExecutaComando.Parameters.AddWithValue("@celular", Obj.Celular);
                ExecutaComando.Parameters.AddWithValue("@cep", Obj.CEP);
                ExecutaComando.Parameters.AddWithValue("@endereco", Obj.Endereco);
                ExecutaComando.Parameters.AddWithValue("@numero", Obj.Numero);
                ExecutaComando.Parameters.AddWithValue("@complemento", Obj.Complemento);
                ExecutaComando.Parameters.AddWithValue("@data_criacao", Obj.data_criacao);
                ExecutaComando.Parameters.AddWithValue("@id_cargo", Obj.Cargos.id);
                ExecutaComando.Parameters.AddWithValue("@id_cidade", Obj.Cidade.id);
                ExecutaComando.Parameters.AddWithValue("@data_ult_alteracao", Obj.data_ult_alteracao);
                ExecutaComando.Parameters.AddWithValue("@data_nasc", Obj.Data_nasc);
                ExecutaComando.Parameters.AddWithValue("@apelido", Obj.Apelido);
                ExecutaComando.Parameters.AddWithValue("@bairro", Obj.Bairro);
                ConexaoBanco.Open();
                ExecutaComando.ExecuteNonQuery();
                MessageBox.Show("Funcionario Cadastrado com Sucesso! ");
                ConexaoBanco.Close();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Aconteceu o erro: " + Erro);
            }
        }
    }
}
