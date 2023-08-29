using MySql.Data.MySqlClient;
using Sistema__Renovo_Barber.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema__Renovo_Barber.Dao
{
    public class uDaoContasPagar
    {
        private MySqlConnection ConexaoBanco;
        public uDaoContasPagar()
        {
            this.ConexaoBanco = new Conexao().GetConnection();
        }
        public void Salvar(uContasPagar Obj)
        {
            try
            {
                string Sql = @"insert into  tb_contas_pagar (num_nfc, modelo_nfc, serie_nfc, num_parcela, id_fornecedor, 
                                id_condicao, valor, situacao, data_baixa, data_vencimento, data_criacao, data_ult_alteracao)
                                values (@num_nfc, @modelo_nfc, @serie_nfc, @num_parcela, @id_fornecedor, 
                                @id_condicao, @valor, @situacao, @data_baixa, @data_vencimento, @data_criacao, @data_ult_alteracao)";
                
                MySqlCommand ExecutaComando = new MySqlCommand(Sql, ConexaoBanco);
                ExecutaComando.Parameters.AddWithValue("@num_nfc", Obj.Compras.Num_nfc);
                ExecutaComando.Parameters.AddWithValue("@modelo_nfc", Obj.Compras.Modelo_nfc);
                ExecutaComando.Parameters.AddWithValue("@serie_nfc", Obj.Compras.Serie_nfc);
                ExecutaComando.Parameters.AddWithValue("@id_fornecedor", Obj.Fornecedor.id);
                ExecutaComando.Parameters.AddWithValue("@id_condicao", Obj.CondicaoPagamento.id);
                ExecutaComando.Parameters.AddWithValue("@valor", Obj.Compras.Valor_total);
                ExecutaComando.Parameters.AddWithValue("@situacao", "AB");
                ExecutaComando.Parameters.AddWithValue("@data_vencimento", Obj.DataVencimento);
                ExecutaComando.Parameters.AddWithValue("@data_criacao", Obj.data_criacao);
                ExecutaComando.Parameters.AddWithValue("@data_criacao", Obj.data_ult_alteracao);
                ConexaoBanco.Open();
                ExecutaComando.ExecuteNonQuery();
                MessageBox.Show("Títulos gerados com sucesso!");
                ConexaoBanco.Close();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Aconteceu o Erro: " + Erro);
            }
        }

    }
}
