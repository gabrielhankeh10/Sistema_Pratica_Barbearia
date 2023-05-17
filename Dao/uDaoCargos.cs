using MySql.Data.MySqlClient;
using Sistema__Renovo_Barber.Classes;
using System;
using System.Collections.Generic;
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
        public void Salvar (uCargos Obj)
        {
            try
            {
                string Sql = @"insert into tb_cargos (cargo, status_cargo, data_criacao)
                                values (@cargo, @status_cargo, @data_criacao)";

                MySqlCommand ExecutaComando = new MySqlCommand(Sql, ConexaoBanco);

                ExecutaComando.Parameters.AddWithValue("@cargo", Obj.Cargo);
                ExecutaComando.Parameters.AddWithValue("@status_cargo", "A");
                ExecutaComando.Parameters.AddWithValue("data_criacao", Obj.data_criacao);

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
