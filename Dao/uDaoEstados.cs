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

        public void Alterar(uEstado Obj)
        {
            try
            {
                string Sql = @"update tb_estados set nome = @nome, uf = @uf, id_pais = @id_pais,
                            data_ult_alteracao = @data_ult_alteracao where id_estado = @id_estado";
                MySqlCommand ExecutaCmd = new MySqlCommand(Sql, ConexaoBanco);
                ExecutaCmd.Parameters.AddWithValue("@id_estado", Obj.id);
                ExecutaCmd.Parameters.AddWithValue("@nome", Obj.estado);
                ExecutaCmd.Parameters.AddWithValue("@uf", Obj.uf);
                ExecutaCmd.Parameters.AddWithValue("@id_pais", Obj.pais.id);
                ExecutaCmd.Parameters.AddWithValue("@data_ult_alteracao", Obj.data_ult_alteracao);
                ConexaoBanco.Open();
                ExecutaCmd.ExecuteNonQuery();
                MessageBox.Show("Estado alterado com sucesso!");
                ConexaoBanco.Close();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Aconteceu o Erro: " + Erro);
            }
        }
        public uEstado SelecionarNome(string Nome)
        {
            try
            {
                string Sql = "select * from tb_estados where nome like @nome";
                MySqlCommand ExecutaCmd = new MySqlCommand(Sql, ConexaoBanco);
                ExecutaCmd.Parameters.AddWithValue("@nome", "%" + Nome + "%");
                ConexaoBanco.Open();
                using (var reader = ExecutaCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        uEstado Obj = new uEstado
                        {
                            estado = Convert.ToString(reader["nome"]),
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
        public void Excluir(uEstado Obj)
        {
            try
            {
                string Sql = "delete from tb_estados where id_estado = @id_estado";

                MySqlCommand ExecutaCmd = new MySqlCommand(Sql, ConexaoBanco);
                ExecutaCmd.Parameters.AddWithValue("@id_estado", Obj.id);
                ConexaoBanco.Open();
                ExecutaCmd.ExecuteNonQuery();
                MessageBox.Show("Estado excluido com sucesso!");
                ConexaoBanco.Close();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Aconteceu o Erro: " + Erro);
            }
        }

        public uEstado Selecionar(int Id)
        {
            try
            {
                uCtrlPaises CtrlPaises = new uCtrlPaises();
                string Sql = "select * from tb_estados where id_estado = @id_estado";
                MySqlCommand ExecutaCmd = new MySqlCommand(Sql, ConexaoBanco);
                ExecutaCmd.Parameters.AddWithValue("@id_estado", Id);
                ConexaoBanco.Open();
                using (var reader = ExecutaCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        uEstado Obj = new uEstado
                        {
                            id = Convert.ToInt32(reader["id_estado"]),
                            estado = Convert.ToString(reader["nome"]),
                            uf = Convert.ToString(reader["uf"]),
                            pais = CtrlPaises.Carregar(Convert.ToInt32(reader["id_pais"])),
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

        public void Salvar(uEstado Obj)
        {
            try
            {
                string Sql = @"insert into tb_estados (nome, uf, id_pais, data_criacao, data_ult_alteracao)
                                values (@nome, @uf, @id_pais, @data_criacao, @data_ult_alteracao)";

                MySqlCommand ExecutaComando = new MySqlCommand(Sql, ConexaoBanco);
                ExecutaComando.Parameters.AddWithValue("@nome", Obj.estado);
                ExecutaComando.Parameters.AddWithValue("@uf", Obj.uf);
                ExecutaComando.Parameters.AddWithValue("@id_pais", Obj.pais.id);
                ExecutaComando.Parameters.AddWithValue("@data_criacao", Obj.data_criacao);
                ExecutaComando.Parameters.AddWithValue("@data_ult_alteracao", Obj.data_ult_alteracao);

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
