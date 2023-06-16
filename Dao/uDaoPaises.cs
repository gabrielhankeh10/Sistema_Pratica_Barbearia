using MySql.Data.MySqlClient;
using Sistema__Renovo_Barber.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema__Renovo_Barber.Dao
{
    public class uDaoPaises : uDao
    {
        private MySqlConnection ConexaoBanco;
        public uDaoPaises()
        {
            this.ConexaoBanco = new Conexao().GetConnection();
        }
        public DataTable PopularGrid()
        {
            string Sql = "select * from tb_pais";
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
        public void Alterar(uPais Obj)
        {
            try
            {
                string Sql = "update tb_pais set nome = @nome, sigla = @sigla, DDI = @DDI, data_ult_alteracao = @data_ult_alteracao where id_pais = @id;";
                
                MySqlCommand ExecutaCmd = new MySqlCommand(Sql, ConexaoBanco);
                ExecutaCmd.Parameters.AddWithValue("@id", Obj.id);
                ExecutaCmd.Parameters.AddWithValue("@nome", Obj.pais);
                ExecutaCmd.Parameters.AddWithValue("@sigla", Obj.sigla);
                ExecutaCmd.Parameters.AddWithValue("@DDI", Obj.ddi);
                ExecutaCmd.Parameters.AddWithValue("@data_ult_alteracao", Obj.data_ult_alteracao);
                ConexaoBanco.Open();
                ExecutaCmd.ExecuteNonQuery();
                MessageBox.Show("Pais alterado com sucesso!");

                ConexaoBanco.Close();
            }
            catch(Exception Erro)
            {
                MessageBox.Show("Aconteceu o Erro: " + Erro);
            }
        }

        public uPais Selecionar(int Id)
        {
            try
            {
                string Sql = "select * from tb_pais where id_pais = @id_pais";
                MySqlCommand ExecutaCmd = new MySqlCommand(Sql, ConexaoBanco);
                ExecutaCmd.Parameters.AddWithValue("@id_pais", Id);
                ConexaoBanco.Open();
                using (var reader = ExecutaCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        uPais Obj = new uPais
                        {
                            id = Convert.ToInt32(reader["id_pais"]),
                            pais = Convert.ToString(reader["nome"]),
                            sigla = Convert.ToString(reader["sigla"]),
                            ddi = Convert.ToString(reader["DDI"]),
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
        public void Salvar(uPais obj)
        {
            try
            {
                string Sql = @"insert into tb_pais (nome, sigla, DDI, data_criacao, data_ult_alteracao)
                                values (@nome, @sigla, @DDI, @data_criacao, @data_ult_alteracao)";
                
                MySqlCommand ExecutaCmd = new MySqlCommand(Sql, ConexaoBanco);
                ExecutaCmd.Parameters.AddWithValue("@nome", obj.pais);
                ExecutaCmd.Parameters.AddWithValue("@sigla", obj.sigla);
                ExecutaCmd.Parameters.AddWithValue("@DDI", obj.ddi);
                ExecutaCmd.Parameters.AddWithValue("@data_criacao", obj.data_criacao);
                ExecutaCmd.Parameters.AddWithValue("@data_ult_alteracao", obj.data_ult_alteracao);
                ConexaoBanco.Open();
                ExecutaCmd.ExecuteNonQuery();
                MessageBox.Show("Pais cadastrado com sucesso!");
                ConexaoBanco.Close();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Aconteceu o Erro: " + Erro);
            }

        }
    }
}
