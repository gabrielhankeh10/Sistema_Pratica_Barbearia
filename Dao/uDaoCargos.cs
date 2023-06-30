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

        public void Alterar(uCargos Obj)
        {
            try
            {
                string Sql = @"update tb_cargos set status_cargo = @status_cargo, cargo = @cargo, 
                            data_ult_alteracao = @data_ult_alteracao where id_cargo = @id_cargo";
                MySqlCommand ExecutaCmd = new MySqlCommand(Sql, ConexaoBanco);
                ExecutaCmd.Parameters.AddWithValue("@id_cargo", Obj.id);
                ExecutaCmd.Parameters.AddWithValue("@status_cargo", Obj.Status);
                ExecutaCmd.Parameters.AddWithValue("@cargo", Obj.Cargo);
                ExecutaCmd.Parameters.AddWithValue("@data_ult_alteracao", Obj.data_ult_alteracao);
                ConexaoBanco.Open();
                ExecutaCmd.ExecuteNonQuery();
                MessageBox.Show("Cargo alterado com sucesso!");
                ConexaoBanco.Close();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Aconteceu o Erro: " + Erro);
            }
        }

        public uCargos Selecionar(int Id)
        {
            try
            {
                uCtrlCargos CtrlCargos = new uCtrlCargos();
                string Sql = "select * from tb_cargos where id_cargo = @id_cargo";
                MySqlCommand ExecutaCmd = new MySqlCommand(Sql, ConexaoBanco);
                ExecutaCmd.Parameters.AddWithValue("@id_cargo", Id);
                ConexaoBanco.Open();
                using (var reader = ExecutaCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        uCargos Obj = new uCargos
                        {
                            id = Convert.ToInt32(reader["id_cargo"]),
                            Status = Convert.ToString(reader["status_cargo"]),
                            Cargo = Convert.ToString(reader["cargo"]),
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
        public void Excluir(uCargos Obj)
        {
            try
            {
                string Sql = "delete from tb_cargos where id_cargo = @id_cargo";

                MySqlCommand ExecutaCmd = new MySqlCommand(Sql, ConexaoBanco);
                ExecutaCmd.Parameters.AddWithValue("@id_cargo", Obj.id);
                ConexaoBanco.Open();
                ExecutaCmd.ExecuteNonQuery();
                MessageBox.Show("Cargo excluido com sucesso!");

                ConexaoBanco.Close();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Aconteceu o Erro: " + Erro);
            }
        }
        public uCargos SelecionarNome(string Nome)
        {
            try
            {
                string Sql = "select * from tb_cargos where cargo like @cargo";
                MySqlCommand ExecutaCmd = new MySqlCommand(Sql, ConexaoBanco);
                ExecutaCmd.Parameters.AddWithValue("@cargo","%" + Nome + "%");
                ConexaoBanco.Open();
                using (var reader = ExecutaCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        uCargos Obj = new uCargos
                        {
                            Cargo = Convert.ToString(reader["cargo"])
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
        public void Salvar (uCargos Obj)
        {
            try
            {
                string Sql = @"insert into tb_cargos (cargo, status_cargo, data_criacao, data_ult_alteracao)
                                values (@cargo, @status_cargo, @data_criacao, @data_ult_alteracao)";

                MySqlCommand ExecutaComando = new MySqlCommand(Sql, ConexaoBanco);

                ExecutaComando.Parameters.AddWithValue("@cargo", Obj.Cargo);
                ExecutaComando.Parameters.AddWithValue("@status_cargo", "A");
                ExecutaComando.Parameters.AddWithValue("@data_criacao", Obj.data_criacao);
                ExecutaComando.Parameters.AddWithValue("@data_ult_alteracao", Obj.data_ult_alteracao);
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
