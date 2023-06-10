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
    public class uDaoCondicaoPagamento : uDao
    {
        private MySqlConnection ConexaoBanco;
        public uDaoCondicaoPagamento()
        {
            this.ConexaoBanco = new Conexao().GetConnection();
        }
        public DataTable PopularGrid()
        {
            string Sql = @"select con.id_condicao, case when con.status_condicao = 'A' then 'Ativo' else 'I' end status_condicao,
                            con.condicao, con.parcelas, con.taxa, con.multa, con.desconto, con.data_criacao, con.data_ult_alteracao
                            from tb_condicao_pagamento con";

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
        public void Salvar(uCondicaoPagamento Obj)
        {
            try
            {
                string Sql = @"insert into tb_condicao_pagamento (status_condicao, condicao, parcelas, taxa, multa, desconto, data_criacao)
                                values(@status_condicao, @condicao, @parcelas, @taxa, @multa, @desconto, @data_criacao)";

                MySqlCommand ExecutaComando = new MySqlCommand(Sql, ConexaoBanco);

                ExecutaComando.Parameters.AddWithValue("@status_condicao", "A");
                ExecutaComando.Parameters.AddWithValue("@condicao", Obj.Condicao);
                ExecutaComando.Parameters.AddWithValue("@parcelas", Obj.Parcelas);
                ExecutaComando.Parameters.AddWithValue("@taxa", Obj.Taxa);
                ExecutaComando.Parameters.AddWithValue("@multa", Obj.Multa);
                ExecutaComando.Parameters.AddWithValue("@desconto", Obj.Desconto);
                ExecutaComando.Parameters.AddWithValue("@data_criacao", Obj.data_criacao);
                ConexaoBanco.Open();
                ExecutaComando.ExecuteNonQuery();
                MessageBox.Show("Condição cadastrada com sucesso!");
                ConexaoBanco.Close();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Aconteceu um erro: " + Erro);
            }
        }
    }
}
