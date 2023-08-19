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
    public class uDaoProdutos: uDao
    {
        private MySqlConnection ConexaoBanco;
        public uDaoProdutos()
        {
            this.ConexaoBanco = new Conexao().GetConnection();
        }

        public DataTable PopularGrid()
        {
            string Sql = "select * from tb_produtos";
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

        public void Salvar(uProdutos Obj)
        {
            try
            {
                string Sql = @"insert into tb_produtos (descricao_produto, marca, preco_custo, preco_venda, qtd_estoque, data_criacao, data_ult_alteracao)
                               values (@descricao_produto, @marca, @preco_custo, @preco_venda, @qtd_estoque, @data_criacao, @data_ult_alteracao)";

                MySqlCommand ExecutaComando = new MySqlCommand(Sql, ConexaoBanco);
                ExecutaComando.Parameters.AddWithValue("@descricao_produto", Obj.Descricao_produto);
                ExecutaComando.Parameters.AddWithValue("@marca", Obj.Marca);
                ExecutaComando.Parameters.AddWithValue("@preco_custo", Obj.Preco_custo);
                ExecutaComando.Parameters.AddWithValue("@preco_venda", Obj.Preco_venda);
                ExecutaComando.Parameters.AddWithValue("@qtd_estoque", Obj.Qtd_estoque);
                ExecutaComando.Parameters.AddWithValue("@data_criacao", Obj.data_criacao);
                ExecutaComando.Parameters.AddWithValue("@data_ult_alteracao", Obj.data_ult_alteracao);
                ConexaoBanco.Open();
                ExecutaComando.ExecuteNonQuery();
                MessageBox.Show("Produto cadastrado com sucesso!");
                ConexaoBanco.Close();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Aconteceu o Erro: " + Erro);
            }
        }

    }

 


}
