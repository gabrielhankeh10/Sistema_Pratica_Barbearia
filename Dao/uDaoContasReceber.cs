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
                string Sql = @"insert into tb_contas_receber (id_receber, id_forma, situacao, data_criacao)
                                values (@id_receber, @id_forma, @situacao, @data_criacao) ";

                MySqlCommand ExecutaComando = new MySqlCommand(Sql, ConexaoBanco);
                ExecutaComando.Parameters.AddWithValue("@id_receber", Obj.Id_receber);
                ExecutaComando.Parameters.AddWithValue("@id_forma", Obj.FormaPagamento.id);
                ExecutaComando.Parameters.AddWithValue("@situacao", Obj.Situacao);
                ExecutaComando.Parameters.AddWithValue("@data_criacao", Obj.Data_criacao);

                ExecutaComando.ExecuteNonQuery();
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter("select max(id_receber) from tb_contas_receber;", ConexaoBanco);
                DataTable Dt = new DataTable();
                sqlDataAdapter.Fill(Dt);

                var Id = Convert.ToInt32(Dt.Rows[0].ItemArray.First());
                Obj.Id_receber = Id;
                
                foreach (var Agenda in Obj.Agendas)
                {
                    string SqlAgenda = @"update tb_agenda set id_receber = @id_receber
                                where id_agenda = @id_agenda or id_agenda_referencia = @id_agenda";
                    MySqlCommand ExecutaCmd = new MySqlCommand(SqlAgenda, ConexaoBanco, Transacao);
                    ExecutaCmd.Parameters.AddWithValue("@id_agenda", Agenda.id_agenda);
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
