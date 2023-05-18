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
    public class uDaoFuncionarios : uDao
    {
        private MySqlConnection ConexaoBanco;
        public uDaoFuncionarios()
        {
            this.ConexaoBanco = new Conexao().GetConnection();
        }
        public void Salvar (uFuncionario Obj)
        {
            try
            {
                string Sql = @"insert into tb_funcionarios (status_funcionario, nome, sexo, rg, cpf, email, senha, telefone, celular, cep, endereco, numero, complemento, data_criacao, id_cargo, id_cidade) 
                                values (@status_funcionario, @nome, @sexo, @rg, @cpf, @email, @senha, @telefone, @celular, @cep, @endereco, @numero, @complemento, @data_criacao, @id_cargo, @id_cidade)";

                MySqlCommand ExecutaComando = new MySqlCommand(Sql, ConexaoBanco);
                ExecutaComando.Parameters.AddWithValue("@status_funcionario", "A");
                ExecutaComando.Parameters.AddWithValue("@nome", Obj.Nome);
                ExecutaComando.Parameters.AddWithValue("@sexo", Obj.Sexo);
                ExecutaComando.Parameters.AddWithValue("@rg", Obj.RG);
                ExecutaComando.Parameters.AddWithValue("@cpf", Obj.CPF);
                ExecutaComando.Parameters.AddWithValue("@email", Obj.Email);
                ExecutaComando.Parameters.AddWithValue("@senha", Obj.Senha);
                ExecutaComando.Parameters.AddWithValue("@telefone", Obj.Telefone);
                ExecutaComando.Parameters.AddWithValue("@celular", Obj.Celular);
                ExecutaComando.Parameters.AddWithValue("@cep", Obj.CEP);
                ExecutaComando.Parameters.AddWithValue("@endereco", Obj.Endereco);
                ExecutaComando.Parameters.AddWithValue("@numero", Obj.Numero);
                ExecutaComando.Parameters.AddWithValue("@complemento", Obj.Complemento);
                ExecutaComando.Parameters.AddWithValue("@data_criacao", Obj.data_criacao);
                ExecutaComando.Parameters.AddWithValue("@id_cargo", Obj.Cargos.id);
                ExecutaComando.Parameters.AddWithValue("@id_cidade", Obj.Cidade.id);

                ConexaoBanco.Open();
                ExecutaComando.ExecuteNonQuery();
                MessageBox.Show("Funcionario Cadastrado com Sucesso! ");
                ConexaoBanco.Close();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Aconteceu o erro: " + Erro);
            }
        }
    }
}
