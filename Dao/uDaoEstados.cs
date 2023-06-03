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
    public class uDaoEstados : uDao  
    {
        private MySqlConnection ConexaoBanco;
        public uDaoEstados()
        {
            this.ConexaoBanco = new Conexao().GetConnection();
        }
        public DataTable PopularGrid()
        {
            string Sql = @"select est.*,pais.nome as pais from tb_estados est 
                            left join tb_pais pais on pais.id_pais = est.id_pais";

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
        public void Salvar(uEstado Obj)
        {
            try
            {
                string Sql = @"insert into tb_estados (nome, uf, id_pais, data_criacao, data_ult_alteracao)
                                values (@nome, @uf, @id_pais, @data_criacao, @data_ult_alteracao)";

                MySqlCommand ExecutaComando = new MySqlCommand(Sql, ConexaoBanco);
                ExecutaComando.Parameters.AddWithValue("@nome", Obj.estado);
                ExecutaComando.Parameters.AddWithValue("uf", Obj.uf);
                ExecutaComando.Parameters.AddWithValue("id_pais", Obj.pais.id);
                ExecutaComando.Parameters.AddWithValue("data_criacao", Obj.data_criacao);
                ExecutaComando.Parameters.AddWithValue("data_ult_alteracao", Obj.data_ult_alteracao);

                ConexaoBanco.Open();
                ExecutaComando.ExecuteNonQuery();
                MessageBox.Show("Estado cadastrado com sucesso!");
                ConexaoBanco.Close();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Aconteceu o Erro: " + Erro); 
            }
        }

    }
}
