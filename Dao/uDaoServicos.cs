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
    public class uDaoServicos : uDao
    {
        private MySqlConnection ConexaoBanco;
        public uDaoServicos()
        {
            this.ConexaoBanco = new Conexao().GetConnection();
        }
        public DataTable PopularGrid()
        {
            string Sql = @"select ser.id_servico, ser.descricao, case when ser.status_servico = 'A' then 'Ativo' 
                        else 'Inativo' end status_servico,ser.duracao, ser.valor, ser.data_criacao, 
                        ser.data_ult_alteracao from tb_servicos ser";
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
        public void Salvar(uServicos Obj)
        {
            try
            {
                string Sql = @"insert into tb_servicos (descricao, status_servico, duracao, valor, data_criacao)
                                values (@descricao, @status_servico, @duracao, @valor, @data_criacao)";

                MySqlCommand ExecutaComando = new MySqlCommand(Sql, ConexaoBanco);
                ExecutaComando.Parameters.AddWithValue("@descricao", Obj.Descricao);
                ExecutaComando.Parameters.AddWithValue("@status_servico", "A");
                ExecutaComando.Parameters.AddWithValue("@duracao", Obj.Duracao);
                ExecutaComando.Parameters.AddWithValue("@valor", Obj.Valor);
                ExecutaComando.Parameters.AddWithValue("@data_criacao", Obj.data_criacao);

                ConexaoBanco.Open();
                ExecutaComando.ExecuteNonQuery();
                MessageBox.Show("Serviço cadastrado com sucesso!");
                ConexaoBanco.Close();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Aconteceu o Erro: " + Erro);
            }
        }
    }
}