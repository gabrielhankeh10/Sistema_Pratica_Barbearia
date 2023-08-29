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
        public DataTable PopularGrid()
        {
            string Sql = "select * from tb_compras";
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
