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
    public class uDaoFornecedor
    {
        private MySqlConnection ConexaoBanco;
        public uDaoFornecedor()
        {
            this.ConexaoBanco = new Conexao().GetConnection();
        }
        public DataTable PopularGrid()
        {
            string Sql = @"select forn.id_fornecedor, case when forn.status_fornecedor = 'A' then 'Ativo' else 'Inativo' end status_fornecedor,
            forn.nome_fantasia, forn.razao_social, forn.data_fundacao, forn.insc_municipal, forn.insc_estadual,forn.cnpj, forn.email,
            forn.telefone, forn.celular, forn.cep, forn.endereco, forn.numero, forn.numero, forn.complemento, forn.bairro, forn.data_criacao,
            forn.data_ult_alteracao, cid.nome as cidade from tb_fornecedores forn left join tb_cidades cid on cid.id_cidade = forn.id_cidade";

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
        public void Salvar(uFornecedor Obj)
        {
            try
            {
                string Sql = @"insert into tb_fornecedores(status_fornecedor, razao_social, nome_fantasia, data_fundacao, insc_municipal, insc_estadual, cnpj, email, telefone, celular, cep, endereco, numero, complemento, bairro, data_criacao, id_cidade )
                            values (@status_fornecedor, @razao_social, @nome_fantasia, @data_fundacao, @insc_municipal, @insc_estadual, @cnpj, @email, @telefone, @celular, @cep, @endereco, @numero, @complemento, @bairro, @data_criacao, @id_cidade)";

                MySqlCommand ExecutaComando = new MySqlCommand(Sql, ConexaoBanco);
                ExecutaComando.Parameters.AddWithValue("@status_fornecedor", "A");
                ExecutaComando.Parameters.AddWithValue("@razao_social", Obj.Pessoa.Nome);
                ExecutaComando.Parameters.AddWithValue("@nome_fantasia", Obj.NomeFantasia);
                ExecutaComando.Parameters.AddWithValue("@data_fundacao", Obj.Pessoa.Data_nasc);
                ExecutaComando.Parameters.AddWithValue("@insc_municipal", Obj.InscMunicipal);
                ExecutaComando.Parameters.AddWithValue("@insc_estadual", Obj.InscEstadual);
                ExecutaComando.Parameters.AddWithValue("@cnpj", Obj.CNPJ);
                ExecutaComando.Parameters.AddWithValue("@email", Obj.Email);
                ExecutaComando.Parameters.AddWithValue("@telefone", Obj.Telefone);
                ExecutaComando.Parameters.AddWithValue("@celular", Obj.Celular);
                ExecutaComando.Parameters.AddWithValue("@cep", Obj.CEP);
                ExecutaComando.Parameters.AddWithValue("@endereco", Obj.Endereco);
                ExecutaComando.Parameters.AddWithValue("@numero", Obj.Numero);
                ExecutaComando.Parameters.AddWithValue("@complemento", Obj.Complemento);
                ExecutaComando.Parameters.AddWithValue("@bairro", Obj.Bairro);
                ExecutaComando.Parameters.AddWithValue("@id_cidade", Obj.Cidade.id);
                ExecutaComando.Parameters.AddWithValue("@data_criacao", Obj.data_criacao);

                ConexaoBanco.Open();
                ExecutaComando.ExecuteNonQuery();
                MessageBox.Show("Fornecedor cadastrado com sucesso!");
                ConexaoBanco.Close();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Aconteceu o Erro: " + Erro);
            }
        }
    }
}
