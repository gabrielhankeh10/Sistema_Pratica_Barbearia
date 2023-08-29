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
        public void Alterar(uProdutos Obj)
        {
            try
            {
                string Sql = @"update tb_produtos set descricao_produto = @descricao_produto, marca = @marca, 
                                data_ult_alteracao = @data_ult_alteracao where id_produto = @id_produto";

                MySqlCommand ExecutaCmd = new MySqlCommand(Sql, ConexaoBanco);
                ExecutaCmd.Parameters.AddWithValue("@id_produto", Obj.id);
                ExecutaCmd.Parameters.AddWithValue("@descricao_produto", Obj.Descricao_produto);
                ExecutaCmd.Parameters.AddWithValue("@marca", Obj.Marca);
                ExecutaCmd.Parameters.AddWithValue("@data_ult_alteracao", Obj.data_ult_alteracao);
                ConexaoBanco.Open();
                ExecutaCmd.ExecuteNonQuery();
                MessageBox.Show("Produto alterado com sucesso!");
                ConexaoBanco.Close();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Aconteceu o Erro: " + Erro);
            }
        }

        public void AtualizarEstoque(int Id, decimal Custo, int Qtd)
        {
            try
            {
                string Sql = @"update tb_produtos set preco_custo = @preco_custo, qtd_estoque = @qtd_estoque, 
                                data_ult_alteracao = @data_ult_alteracao where id_produto = @id_produto";
                
                MySqlCommand ExecutaCmd = new MySqlCommand(Sql, ConexaoBanco);
                ExecutaCmd.Parameters.AddWithValue("@id_produto", Id);
                ExecutaCmd.Parameters.AddWithValue("@preco_custo", Custo);
                ExecutaCmd.Parameters.AddWithValue("@qtd_estoque", Qtd);
                ExecutaCmd.Parameters.AddWithValue("@data_ult_alteracao", DateTime.Now);
                ConexaoBanco.Open();
                ExecutaCmd.ExecuteNonQuery();
                MessageBox.Show("Estoque atualizado com sucesso!");
                ConexaoBanco.Close();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Aconteceu o Erro: " + Erro);
            }
        }
        public void Excluir(uProdutos Obj)
        {
            try
            {
                string Sql = "delete from tb_produtos where id_produto = @id_produto";

                MySqlCommand ExecutaCmd = new MySqlCommand(Sql, ConexaoBanco);
                ExecutaCmd.Parameters.AddWithValue("@id_produto", Obj.id);
                ConexaoBanco.Open();
                ExecutaCmd.ExecuteNonQuery();
                MessageBox.Show("Produto excluido com sucesso!");

                ConexaoBanco.Close();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Aconteceu o Erro: " + Erro);
            }
        }

        public uProdutos Selecionar(int Id)
        {
            try
            {
                string Sql = "select * from tb_produtos where id_produto = @id_produto";
                MySqlCommand ExecutaCmd = new MySqlCommand(Sql, ConexaoBanco);
                ExecutaCmd.Parameters.AddWithValue("@id_produto", Id);
                ConexaoBanco.Open();
                using (var reader = ExecutaCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        uProdutos Obj = new uProdutos
                        {
                            id = Convert.ToInt32(reader["id_produto"]),
                            Descricao_produto = Convert.ToString(reader["descricao_produto"]),
                            Marca = Convert.ToString(reader["marca"]),
                            Preco_custo = Convert.ToDecimal(reader["preco_custo"]),
                            Preco_venda = Convert.ToDecimal(reader["preco_venda"]),
                            Qtd_estoque = Convert.ToInt32(reader["qtd_estoque"]),
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
