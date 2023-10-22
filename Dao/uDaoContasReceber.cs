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
    public class uDaoContasReceber
    {
        private MySqlConnection ConexaoBanco;
        public uDaoContasReceber()
        {
            this.ConexaoBanco = new Conexao().GetConnection();
        }
        public void Salvar(uContasReceber Obj)
        {
            ConexaoBanco.Open();
            var Transacao = ConexaoBanco.BeginTransaction();
            try
            {
                string Sql = @"insert into tb_contas_receber (id_receber, id_condicao, situacao, data_criacao)
                                values (@id_receber, @id_condicao, @situacao, @data_criacao)";

                MySqlCommand ExecutaComando = new MySqlCommand(Sql, ConexaoBanco);
                ExecutaComando.Parameters.AddWithValue("@id_receber", Obj.Id_receber);
                ExecutaComando.Parameters.AddWithValue("@id_condicao", Obj.CondicaoPagamento.id);
                ExecutaComando.Parameters.AddWithValue("@situacao", Obj.Situacao);
                ExecutaComando.Parameters.AddWithValue("@data_criacao", Obj.Data_criacao);
                var Id = Convert.ToInt32(ExecutaComando.ExecuteScalar());
                Obj.Id_receber = Id;
                ExecutaComando.ExecuteNonQuery();
                
                foreach (var Agenda in Obj.Agendas)
                {
                    string SqlAgenda = @"update tb_agenda set id_receber = @id_receber
                                where data_agenda = @data_agenda and id_funcionario = @id_funcionario";
                    MySqlCommand ExecutaCmd = new MySqlCommand(Sql, ConexaoBanco, Transacao);
                    ExecutaCmd.Parameters.AddWithValue("@data_agenda", Agenda.Data);
                    ExecutaCmd.Parameters.AddWithValue("@id_funcionario", Agenda.Funcionario.id);
                    ExecutaCmd.Parameters.AddWithValue("@id_receber", Obj.Id_receber);
                    ExecutaCmd.ExecuteNonQuery();
                }
                Transacao.Commit();
                MessageBox.Show("Títulos gerados com sucesso!");
                
            }
            catch (Exception Erro)
            {
                Transacao.Rollback();
                MessageBox.Show("Aconteceu o Erro: " + Erro);
            }
            finally { ConexaoBanco.Close(); }
        }

        
    }
}
