using MySql.Data.MySqlClient;
using Sistema__Renovo_Barber.Classes;
using Sistema__Renovo_Barber.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema__Renovo_Barber.Dao
{
    public class uDaoParcelas :uDao
    {
        private MySqlConnection ConexaoBanco;
        private readonly uCtrlFormaPagamento Controller = new uCtrlFormaPagamento();
        public uDaoParcelas()
        {
            this.ConexaoBanco = new Conexao().GetConnection();
        }
        public bool Salvar(uParcelas Obj)
        {
            bool status = false;
            try
            {
                string Sql = @"insert into tb_parcelas (id_condicao, num_parcela, id_forma, dias_totais, porcentagem,
                            data_criacao, data_ult_alteracao) values (@id_condicao, @num_parcela, @id_forma, @dias_totais,
                                @porcentagem, @data_criacao, @data_ult_alteracao)";
                MySqlCommand ExecutaCmd = new MySqlCommand(Sql, ConexaoBanco);

                ExecutaCmd.Parameters.AddWithValue("@id_condicao", Obj.id);
                ExecutaCmd.Parameters.AddWithValue("@num_parcela", Obj.NumParcela);
                ExecutaCmd.Parameters.AddWithValue("@id_forma", Obj.FormaPagamento.id);
                ExecutaCmd.Parameters.AddWithValue("@dias_totais", Obj.DiasTotais);
                ExecutaCmd.Parameters.AddWithValue("@porcentagem", Obj.Porcentagem);
                ExecutaCmd.Parameters.AddWithValue("@data_criacao", Obj.data_criacao);
                ExecutaCmd.Parameters.AddWithValue("@data_ult_alteracao", Obj.data_ult_alteracao);
                ConexaoBanco.Open();
                int i = ExecutaCmd.ExecuteNonQuery();
                if (i > 0)
                {
                    status = true;
                }
                ConexaoBanco.Close();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Aconteceu o Erro: " + Erro);
            }
            finally
            {
                ConexaoBanco.Close();
            }
            return status;
        }
    }
}
