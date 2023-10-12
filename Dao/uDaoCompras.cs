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
    public class uDaoCompras
    {
        private MySqlConnection ConexaoBanco;
        public uDaoCompras()
        {
            this.ConexaoBanco = new Conexao().GetConnection();
        }
        public void Salvar(uCompras Obj)
        {
            try
            {
                string Sql = @"insert into tb_compras (num_nfc, modelo_nfc, serie_nfc, id_fornecedor, id_condicao, valor_total, valor_frete, 
                                valor_seguro, valor_outras_despesas, data_chegada, data_emissao, data_criacao)
                                    values (@num_nfc, @modelo_nfc, @serie_nfc, @id_fornecedor, @id_condicao, @valor_total, @valor_frete, 
                                        @valor_seguro, @valor_outras_despesas, @data_chegada, @data_emissao, @data_criacao)";

                MySqlCommand ExecutaComando = new MySqlCommand(Sql, ConexaoBanco);
                ExecutaComando.Parameters.AddWithValue("@num_nfc", Obj.Num_nfc);
                ExecutaComando.Parameters.AddWithValue("@modelo_nfc", Obj.Modelo_nfc);
                ExecutaComando.Parameters.AddWithValue("@serie_nfc", Obj.Serie_nfc);
                ExecutaComando.Parameters.AddWithValue("@id_fornecedor", Obj.Fornecedor.id);
                ExecutaComando.Parameters.AddWithValue("@id_condicao", Obj.CondicaoPagamento.id);
                ExecutaComando.Parameters.AddWithValue("@valor_total", Obj.Valor_total);
                ExecutaComando.Parameters.AddWithValue("@valor_frete", Obj.Valor_frete);
                ExecutaComando.Parameters.AddWithValue("@valor_seguro", Obj.Valor_seguro);
                ExecutaComando.Parameters.AddWithValue("@valor_outras_despesas", Obj.Valor_outras_despesas);
                ExecutaComando.Parameters.AddWithValue("@data_chegada", Obj.Data_chegada);
                ExecutaComando.Parameters.AddWithValue("@data_emissao", Obj.Data_emissao);
                ExecutaComando.Parameters.AddWithValue("@data_criacao", Obj.data_criacao);
                ConexaoBanco.Open();
                ExecutaComando.ExecuteNonQuery();
                MessageBox.Show("Nota de compras cadastrada com sucesso!");
                ConexaoBanco.Close();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Aconteceu o Erro: " + Erro);
            }
        }

        public uCompras Buscar(int num_nota, int modelo, int serie, int codForneceodr)
        {
            try
            {
                string Sql = @"select tb.num_nfc, tb.modelo_nfc, tb.serie_nfc, tb.id_fornecedor from tb_compras tb 
                                where tb.num_nfc = @num_nfc and tb.modelo_nfc = @modelo_nfc and tb.serie_nfc = serie_nfc and tb.id_fornecedor = @id_fornecedor";

                MySqlCommand ExecutaCmd = new MySqlCommand(Sql, ConexaoBanco);
                ExecutaCmd.Parameters.AddWithValue("@num_nfc",num_nota);
                ExecutaCmd.Parameters.AddWithValue("@modelo_nfc", modelo);
                ExecutaCmd.Parameters.AddWithValue("@serie_nfc", serie);
                ExecutaCmd.Parameters.AddWithValue("@id_fornecedor", codForneceodr);
                ConexaoBanco.Open();
                using (var reader = ExecutaCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        uCtrlFornecedor Controller = new uCtrlFornecedor();
                        uCompras Obj = new uCompras
                        {
                            Num_nfc = Convert.ToInt32(reader["num_nfc"]),
                            Modelo_nfc = Convert.ToInt32(reader["modelo_nfc"]),
                            Serie_nfc = Convert.ToInt32(reader["serie_nfc"]),
                            Fornecedor = Controller.Carregar(Convert.ToInt32(reader["id_fornecedor"]))
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

        public DataTable PopularGrid()
        {
            string Sql = @"select tb.num_nfc, tb.modelo_nfc, tb.serie_nfc, forn.razao_social as fornecedor, 
                            pag.condicao, tb.valor_total, tb.valor_frete, tb.valor_seguro, tb.valor_outras_despesas,
                            tb.data_chegada, tb.data_emissao, tb.data_criacao from tb_compras tb
                            left join tb_fornecedores forn on forn.id_fornecedor = tb.id_fornecedor
                            left join tb_condicao_pagamento pag on pag.id_condicao = tb.id_condicao";

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
    }
}
