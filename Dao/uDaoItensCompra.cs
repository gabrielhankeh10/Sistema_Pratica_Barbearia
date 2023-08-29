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
    public class uDaoItensCompra
    {
        private MySqlConnection ConexaoBanco;
        public uDaoItensCompra()
        {
            this.ConexaoBanco = new Conexao().GetConnection();
        }
        public void Salvar(uItensCompra Obj)
        {
            try
            {
                string Sql = @"insert into tb_itens_compras (num_nfc, modelo_nfc, serie_nfc, id_fornecedor, 
                                id_produto, qtd_produto, preco_custo, total_custo, percentual_compra, media_ponderada, data_criacao)
                                values (@num_nfc, @modelo_nfc, @serie_nfc, @id_fornecedor, @id_produto, @qtd_produto ,@preco_custo, 
                                   @total_custo, @percentual_compra, @media_ponderada, @data_criacao)";

                MySqlCommand ExecutaComando = new MySqlCommand(Sql, ConexaoBanco);
                ExecutaComando.Parameters.AddWithValue("@num_nfc", Obj.Num_nfc);
                ExecutaComando.Parameters.AddWithValue("@modelo_nfc", Obj.Modelo_nfc);
                ExecutaComando.Parameters.AddWithValue("@serie_nfc", Obj.Serie_nfc);
                ExecutaComando.Parameters.AddWithValue("@id_fornecedor", Obj.Id_fornecedor);
                ExecutaComando.Parameters.AddWithValue("@id_produto", Obj.Produtos.id);
                ExecutaComando.Parameters.AddWithValue("@qtd_produto", Obj.Qtd);
                ExecutaComando.Parameters.AddWithValue("@preco_custo", Obj.Preco_custo);
                ExecutaComando.Parameters.AddWithValue("@total_custo", Obj.Total_custo);
                ExecutaComando.Parameters.AddWithValue("@percentual_compra", Obj.Percentual_compra);
                ExecutaComando.Parameters.AddWithValue("@media_ponderada", Obj.Media_ponderada);
                ExecutaComando.Parameters.AddWithValue("@data_criacao", Obj.data_criacao);
                ConexaoBanco.Open();
                ExecutaComando.ExecuteNonQuery();
                MessageBox.Show("Itens de compras cadastrado com sucesso!");
                ConexaoBanco.Close();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Aconteceu o Erro: " + Erro);
            }
        }
    }
}
