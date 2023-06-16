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
    public class uDaoCidades :uDao
    {
        private MySqlConnection ConexaoBanco;
        public uDaoCidades()
        {
            this.ConexaoBanco = new Conexao().GetConnection();
        }
        public DataTable PopularGrid()
        {
            string Sql = @"select cid.id_cidade, cid.nome as CIDADE ,cid.DDD, est.uf from tb_cidades cid 
                            left join tb_estados est on est.id_estado = cid.id_estado";


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
        public void Alterar(uCidade Obj)
        {
            try
            {
                string Sql = @"update tb_cidades set nome = @nome, DDD = @DDD, id_estado = @id_estado,
                            data_ult_alteracao = @data_ult_alteracao where id_cidade = @id_cidade";
                MySqlCommand ExecutaCmd = new MySqlCommand(Sql, ConexaoBanco);
                ExecutaCmd.Parameters.AddWithValue("@id_cidade", Obj.id);
                ExecutaCmd.Parameters.AddWithValue("@nome", Obj.Cidade);
                ExecutaCmd.Parameters.AddWithValue("@DDD", Obj.DDD);
                ExecutaCmd.Parameters.AddWithValue("@id_estado", Obj.Estado.id);
                ExecutaCmd.Parameters.AddWithValue("@data_ult_alteracao", Obj.data_ult_alteracao);
                ConexaoBanco.Open();
                ExecutaCmd.ExecuteNonQuery();
                MessageBox.Show("Cidade alterado com sucesso!");
                ConexaoBanco.Close();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Aconteceu o Erro: " + Erro);
            }
        }

        public uCidade Selecionar(int Id)
        {
            try
            {
                uCtrlEstados CtrlEstados = new uCtrlEstados();
                string Sql = "select * from tb_cidades where id_cidade = @id_cidade";
                MySqlCommand ExecutaCmd = new MySqlCommand(Sql, ConexaoBanco);
                ExecutaCmd.Parameters.AddWithValue("@id_cidade", Id);
                ConexaoBanco.Open();
                using (var reader = ExecutaCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        uCidade Obj = new uCidade
                        {
                            id = Convert.ToInt32(reader["id_cidade"]),
                            Cidade = Convert.ToString(reader["nome"]),
                            DDD = Convert.ToString(reader["DDD"]),
                            Estado = CtrlEstados.Carregar(Convert.ToInt32(reader["id_estado"])),
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
        public void Salvar(uCidade Obj)
        {
            try
            {
                string Sql = @"insert into tb_cidades (nome, DDD, id_estado, data_criacao, data_ult_alteracao)
                                values (@nome, @DDD, @id_estado, @data_criacao, @data_ult_alteracao)";
                
                MySqlCommand ExecutaComando = new MySqlCommand(Sql, ConexaoBanco);
                ExecutaComando.Parameters.AddWithValue("@nome", Obj.Cidade);
                ExecutaComando.Parameters.AddWithValue("@DDD", Obj.DDD);
                ExecutaComando.Parameters.AddWithValue("@id_estado",Obj.Estado.id);
                ExecutaComando.Parameters.AddWithValue("@data_criacao", Obj.data_criacao);
                ExecutaComando.Parameters.AddWithValue("@data_ult_alteracao", Obj.data_ult_alteracao);

                ConexaoBanco.Open();
                ExecutaComando.ExecuteNonQuery();
                MessageBox.Show("Cidade cadastrada com sucesso!");
                ConexaoBanco.Close();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Aconteceu o Erro: " + Erro);
            }
        }
    }
}
