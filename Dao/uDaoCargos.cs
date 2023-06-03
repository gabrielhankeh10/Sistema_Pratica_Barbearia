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
    public class uDaoCargos : uDao
    {
        private MySqlConnection ConexaoBanco;
        public uDaoCargos()
        {
            this.ConexaoBanco = new Conexao().GetConnection();
        }
        public DataTable PopularGrid()
        {
            string Sql = @"select car.id_cargo, case when car.status_cargo = 'A' then 'Ativo' else 'Inativo' 
                        end status_cargo, car.cargo, car.data_criacao, car.data_ult_alteracao from tb_cargos car";


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
        public void Salvar (uCargos Obj)
        {
            try
            {
                string Sql = @"insert into tb_cargos (cargo, status_cargo, data_criacao)
                                values (@cargo, @status_cargo, @data_criacao)";

                MySqlCommand ExecutaComando = new MySqlCommand(Sql, ConexaoBanco);

                ExecutaComando.Parameters.AddWithValue("@cargo", Obj.Cargo);
                ExecutaComando.Parameters.AddWithValue("@status_cargo", "A");
                ExecutaComando.Parameters.AddWithValue("@data_criacao", Obj.data_criacao);

                ConexaoBanco.Open();
                ExecutaComando.ExecuteNonQuery();
                MessageBox.Show("Cliente cadastrado com sucesso!");
                ConexaoBanco.Close();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Aconteceu um erro: " + Erro);
            }
        }
    }
}
