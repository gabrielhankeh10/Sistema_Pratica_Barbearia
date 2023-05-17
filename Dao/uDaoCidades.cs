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
    public class uDaoCidades :uDao
    {
        private MySqlConnection ConexaoBanco;
        public uDaoCidades()
        {
            this.ConexaoBanco = new Conexao().GetConnection();
        }
        public void Salvar(uCidade Obj)
        {
            try
            {
                string Sql = @"insert into tb_cidades (nome, DDD, id_estado, data_criacao, data_ult_alteracao)
                                values (@nome, @DDD, @id_estado, @data_criacao, @data_ult_alteracao)";
                
                MySqlCommand ExecutaComando = new MySqlCommand(Sql, ConexaoBanco);
                ExecutaComando.Parameters.AddWithValue("@nome", Obj.Cidade);
                ExecutaComando.Parameters.AddWithValue("@DDD", Obj.DDD);
                ExecutaComando.Parameters.AddWithValue("@id_estado",Obj.Estado.id);
                ExecutaComando.Parameters.AddWithValue("@data_criacao", Obj.data_criacao);
                ExecutaComando.Parameters.AddWithValue("@data_ult_alteracao", Obj.data_ult_alteracao);

                ConexaoBanco.Open();
                ExecutaComando.ExecuteNonQuery();
                MessageBox.Show("Cidade cadastrada com sucesso!");
                ConexaoBanco.Close();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Aconteceu o Erro: " + Erro);
            }
        }
    }
}
