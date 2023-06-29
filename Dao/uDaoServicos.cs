using MySql.Data.MySqlClient;
using Sistema__Renovo_Barber.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema__Renovo_Barber.Dao
{
    public class uDaoServicos : uDao
    {
        private MySqlConnection ConexaoBanco;
        public uDaoServicos()
        {
            this.ConexaoBanco = new Conexao().GetConnection();
        }
        public DataTable PopularGrid()
        {
            string Sql = @"select ser.id_servico, ser.descricao, case when ser.status_servico = 'A' then 'Ativo' 
                        else 'Inativo' end status_servico,ser.duracao, ser.valor, ser.data_criacao, 
                        ser.data_ult_alteracao from tb_servicos ser";
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

        public void Alterar(uServicos Obj)
        {
            try
            {
                string Sql = @"update tb_servicos set descricao = @descricao, status_servico = @status_servico,
                                duracao = @duracao, valor = @valor, data_ult_alteracao = @data_ult_alteracao
                                where id_servico = @id_servico";

                MySqlCommand ExecutaCmd = new MySqlCommand(Sql, ConexaoBanco);
                ExecutaCmd.Parameters.AddWithValue("@id_servico", Obj.id);
                ExecutaCmd.Parameters.AddWithValue("@descricao", Obj.Descricao);
                ExecutaCmd.Parameters.AddWithValue("@status_servico",Obj.Status);
                ExecutaCmd.Parameters.AddWithValue("@duracao", Obj.Duracao);
                ExecutaCmd.Parameters.AddWithValue("@valor", Obj.Valor);
                ExecutaCmd.Parameters.AddWithValue("@data_ult_alteracao", Obj.data_ult_alteracao);
                ConexaoBanco.Open();
                ExecutaCmd.ExecuteNonQuery();
                MessageBox.Show("Servico alterado com sucesso!");
                ConexaoBanco.Close();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Aconteceu o Erro: " + Erro);
            }
        }

        public uServicos Selecionar(int Id)
        {
            try
            {
                string Sql = "select * from tb_servicos where id_servico = @id_servico";
                MySqlCommand ExecutaCmd = new MySqlCommand(Sql, ConexaoBanco);
                ExecutaCmd.Parameters.AddWithValue("@id_servico", Id);
                ConexaoBanco.Open();
                using (var reader = ExecutaCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        uServicos Obj = new uServicos
                        {
                            id = Convert.ToInt32(reader["id_servico"]),
                            Descricao = Convert.ToString(reader["descricao"]),
                            Status = Convert.ToString(reader["status_servico"]),
                            Duracao = (TimeSpan)reader["duracao"],
                            Valor = Convert.ToDecimal(reader["valor"]),
                            data_criacao = Convert.ToDateTime(reader["data_criacao"]),
                            data_ult_alteracao = Convert.ToDateTime(reader["data_ult_alteracao"]),
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

        public void Salvar(uServicos Obj)
        {
            try
            {
                string Sql = @"insert into tb_servicos (descricao, status_servico, duracao, valor, data_criacao, data_ult_alteracao)
                                values (@descricao, @status_servico, @duracao, @valor, @data_criacao, @data_ult_alteracao)";

                MySqlCommand ExecutaComando = new MySqlCommand(Sql, ConexaoBanco);
                ExecutaComando.Parameters.AddWithValue("@descricao", Obj.Descricao);
                ExecutaComando.Parameters.AddWithValue("@status_servico", "A");
                ExecutaComando.Parameters.AddWithValue("@duracao", Obj.Duracao);
                ExecutaComando.Parameters.AddWithValue("@valor", Obj.Valor);
                ExecutaComando.Parameters.AddWithValue("@data_criacao", Obj.data_criacao);
                ExecutaComando.Parameters.AddWithValue("@data_ult_alteracao", Obj.data_ult_alteracao);
                ConexaoBanco.Open();
                ExecutaComando.ExecuteNonQuery();
                MessageBox.Show("Serviço cadastrado com sucesso!");
                ConexaoBanco.Close();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Aconteceu o Erro: " + Erro);
            }
        }
    }
}