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
        public void Salvar(uFormaPagamento Obj)
        {
            try
            {
                string Sql = @"insert into tb_forma_pagamento (status_forma, forma, data_criacao)
			                    values(@status_forma, @forma, @data_criacao)";

                MySqlCommand ExecutaComando = new MySqlCommand(Sql, ConexaoBanco);

                ExecutaComando.Parameters.AddWithValue("@status_forma", "A");
                ExecutaComando.Parameters.AddWithValue("@forma", Obj.Forma);
                ExecutaComando.Parameters.AddWithValue("@data_criacao", Obj.data_criacao);

                ConexaoBanco.Open();
                ExecutaComando.ExecuteNonQuery();
                MessageBox.Show("Forma cadastrada com sucesso!");
                ConexaoBanco.Close();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Aconteceu um erro: " + Erro);
            }
        }
    }
}
