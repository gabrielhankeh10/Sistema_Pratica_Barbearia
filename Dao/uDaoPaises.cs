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
