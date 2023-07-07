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
    public class uDaoFormaPagamento : uDao
    {
        private MySqlConnection ConexaoBanco;
        public uDaoFormaPagamento()
        {
            this.ConexaoBanco = new Conexao().GetConnection();
        }
        public DataTable PopularGrid()
        {
            string Sql = @"select pag.id_forma, case when pag.status_forma = 'A' then 'Ativo' else 'Inativo' end status_forma, 
                        pag.forma, pag.data_criacao, pag.data_ult_alteracao from tb_forma_pagamento pag;";

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
        public void Alterar(uFormaPagamento Obj)
        {
            try
            {
                string Sql = @"update tb_forma_pagamento set status_forma = @status_forma, forma = @forma, 
                                data_ult_alteracao = @data_ult_alteracao where id_forma = @id_forma";
                MySqlCommand ExecutaCmd = new MySqlCommand(Sql, ConexaoBanco);
                ExecutaCmd.Parameters.AddWithValue("@id_forma", Obj.id);
                ExecutaCmd.Parameters.AddWithValue("@status_forma", Obj.Status);
                ExecutaCmd.Parameters.AddWithValue("@forma", Obj.Forma);
                ExecutaCmd.Parameters.AddWithValue("@data_ult_alteracao", Obj.data_ult_alteracao);
                ConexaoBanco.Open();
                ExecutaCmd.ExecuteNonQuery();
                MessageBox.Show("Forma de Pagamento alterado com sucesso!");
                ConexaoBanco.Close();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Aconteceu o Erro: " + Erro);
            }
        }
        public void Excluir(uFormaPagamento Obj)
        {
            try
            {
                string Sql = "delete from tb_forma_pagamento where id_forma = @id_forma";

                MySqlCommand ExecutaCmd = new MySqlCommand(Sql, ConexaoBanco);
                ExecutaCmd.Parameters.AddWithValue("@id_forma", Obj.id);
                ConexaoBanco.Open();
                ExecutaCmd.ExecuteNonQuery();
                MessageBox.Show("Forma de Pagamento excluido com sucesso!");

                ConexaoBanco.Close();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Aconteceu o Erro: " + Erro);
            }
        }
        public uFormaPagamento Selecionar(int Id)
        {
            try
            {
                uCtrlFormaPagamento CtrlFormaPagamento = new uCtrlFormaPagamento();
                string Sql = "select * from tb_forma_pagamento where id_forma = @id_forma";
                MySqlCommand ExecutaCmd = new MySqlCommand(Sql, ConexaoBanco);
                ExecutaCmd.Parameters.AddWithValue("@id_forma", Id);
                ConexaoBanco.Open();
                using (var reader = ExecutaCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        uFormaPagamento Obj = new uFormaPagamento
                        {
                            id = Convert.ToInt32(reader["id_forma"]),
                            Status = Convert.ToString(reader["status_forma"]),
                            Forma = Convert.ToString(reader["forma"]),
                            data_criacao = Convert.ToDateTime(reader["data_criacao"]),
                            data_ult_alteracao = Convert.ToDateTime(reader["data_ult_alteracao"])
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
        public void Salvar(uFormaPagamento Obj)
        {
            try
            {
                string Sql = @"insert into tb_forma_pagamento (status_forma, forma, data_criacao, data_ult_alteracao)
			                    values(@status_forma, @forma, @data_criacao, @data_ult_alteracao)";

                MySqlCommand ExecutaComando = new MySqlCommand(Sql, ConexaoBanco);

                ExecutaComando.Parameters.AddWithValue("@status_forma", "A");
                ExecutaComando.Parameters.AddWithValue("@forma", Obj.Forma);
                ExecutaComando.Parameters.AddWithValue("@data_criacao", Obj.data_criacao);
                ExecutaComando.Parameters.AddWithValue("@data_ult_alteracao", Obj.data_ult_alteracao);
                ConexaoBanco.Open();
                ExecutaComando.ExecuteNonQuery();
                MessageBox.Show("Forma de Pagamento cadastrada com sucesso!");
                ConexaoBanco.Close();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Aconteceu um erro: " + Erro);
            }
        }
    }
}
