using MySql.Data.MySqlClient;
using Sistema__Renovo_Barber.Classes;
using Sistema__Renovo_Barber.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema__Renovo_Barber.Dao
{
    public class uDaoCondicaoPagamento : uDao
    {
        private MySqlConnection ConexaoBanco;
        private readonly uCtrlParcelas Controller = new uCtrlParcelas();

        public uDaoCondicaoPagamento()
        {
            this.ConexaoBanco = new Conexao().GetConnection();
        }
        public DataTable PopularGrid()
        {
            string Sql = @"select con.id_condicao, 
                            con.condicao, con.parcelas, con.taxa, con.multa, con.desconto, con.data_criacao, con.data_ult_alteracao
                            from tb_condicao_pagamento con";

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
        public uCondicaoPagamento Selecionar(int Id)
        {
            DataTable Dt = new DataTable();
            ConexaoBanco.Open();
            try
            {
                uCtrlFormaPagamento CtrlFormaPagamento = new uCtrlFormaPagamento();
                string Sql = $"select * from tb_condicao_pagamento pag left join tb_parcelas par on par.id_condicao = pag.id_condicao left join tb_forma_pagamento frm on frm.id_forma = par.id_forma where pag.id_condicao = {Id}";

                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(Sql, ConexaoBanco);
                sqlDataAdapter.Fill(Dt);
                if (Dt.Rows.Count > 0)
                {
                    uCondicaoPagamento Obj = new uCondicaoPagamento
                    {
                        id = Convert.ToInt32(Dt.Rows[0]["id_condicao"]),
                        Condicao = Convert.ToString(Dt.Rows[0]["condicao"]),
                        Parcelas = Convert.ToInt32(Dt.Rows[0]["parcelas"]),
                        Taxa = Convert.ToInt32(Dt.Rows[0]["taxa"]),
                        Multa = Convert.ToInt32(Dt.Rows[0]["multa"]),
                        Desconto = Convert.ToInt32(Dt.Rows[0]["desconto"]),
                        data_criacao = Convert.ToDateTime(Dt.Rows[0]["data_criacao"]),
                        data_ult_alteracao = Convert.ToDateTime(Dt.Rows[0]["data_ult_alteracao"]),
                        uParcelas = new List<uParcelas>()
                    };

                    foreach (DataRow item in Dt.Rows)
                    {
                        uParcelas parcela = new uParcelas
                        {
                            DiasTotais = Convert.ToInt32(item["dias_totais"]),
                            NumParcela = Convert.ToInt32(item["num_parcela"]),
                            Porcentagem = Convert.ToDouble(item["porcentagem"]),
                            FormaPagamento = new uFormaPagamento { 
                                id = Convert.ToInt32(item["id_forma"]),
                                Forma = Convert.ToString(item["forma"])    
                            }
                        };
                        Obj.uParcelas.Add(parcela);
                    }
                    ConexaoBanco.Close();
                    return Obj;
                }
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Aconteceu o Erro: " + Erro);
            }
            ConexaoBanco.Close();
            return null;
        }
        public void Alterar(uCondicaoPagamento Obj)
        {
            try
            {
                string Sql = @"update tb_condicao_pagamento set condicao = @condicao, parcelas = @parcelas, taxa = @taxa,
                                multa = @multa, desconto = @desconto, id_forma = @id_forma,
                                   data_ult_alteracao = @data_ult_alteracao where id_condicao = @id_condicao";
                MySqlCommand ExecutaCmd = new MySqlCommand(Sql, ConexaoBanco);
                ExecutaCmd.Parameters.AddWithValue("@id_condicao", Obj.id);
                ExecutaCmd.Parameters.AddWithValue("@condicao", Obj.Condicao);
                //ExecutaCmd.Parameters.AddWithValue("@parcelas", Obj.Parcelas);
                ExecutaCmd.Parameters.AddWithValue("@taxa", Obj.Taxa);
                ExecutaCmd.Parameters.AddWithValue("@multa", Obj.Multa);
                ExecutaCmd.Parameters.AddWithValue("@desconto", Obj.Desconto);
                //ExecutaCmd.Parameters.AddWithValue("@dias", Obj.Dias);
                //ExecutaCmd.Parameters.AddWithValue("@id_forma", Obj.Forma.id);
                ExecutaCmd.Parameters.AddWithValue("@data_ult_alteracao", Obj.data_ult_alteracao);
                ConexaoBanco.Open();
                ExecutaCmd.ExecuteNonQuery();
                MessageBox.Show("Condição de Pagamento alterado com sucesso!");
                ConexaoBanco.Close();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Aconteceu o Erro: " + Erro);
            }
        }
        public void Excluir(uCondicaoPagamento Obj)
        {
            try
            {
                string Sql = "delete from tb_condicao_pagamento where id_condicao = @id_condicao";

                MySqlCommand ExecutaCmd = new MySqlCommand(Sql, ConexaoBanco);
                ExecutaCmd.Parameters.AddWithValue("@id_condicao", Obj.id);
                ConexaoBanco.Open();
                ExecutaCmd.ExecuteNonQuery();
                MessageBox.Show("Condição de pagamento excluida com sucesso!");

                ConexaoBanco.Close();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Aconteceu o Erro: " + Erro);
            }
        }
        public bool Salvar(uCondicaoPagamento Obj)
        {
            bool status = false;
            string Sql = @"insert into tb_condicao_pagamento (condicao, parcelas, taxa, multa, desconto, data_criacao, data_ult_alteracao)
                                values(@condicao, @parcelas, @taxa, @multa, @desconto, @data_criacao, @data_ult_alteracao)";
            string UltimoID = "select max(id_condicao) from tb_condicao_pagamento";
            try
            {
                MySqlCommand ExecutaComando = new MySqlCommand(Sql, ConexaoBanco);
                MySqlCommand ExecutaComando2 = new MySqlCommand(UltimoID, ConexaoBanco);
                ExecutaComando.Parameters.AddWithValue("@condicao", Obj.Condicao);
                ExecutaComando.Parameters.AddWithValue("@taxa", Obj.Taxa);
                ExecutaComando.Parameters.AddWithValue("@multa", Obj.Multa);
                ExecutaComando.Parameters.AddWithValue("@desconto", Obj.Desconto);
                ExecutaComando.Parameters.AddWithValue("@parcelas", Obj.Parcelas);
                ExecutaComando.Parameters.AddWithValue("@data_criacao", Obj.data_criacao);
                ExecutaComando.Parameters.AddWithValue("@data_ult_alteracao", Obj.data_ult_alteracao);
                ConexaoBanco.Open();
                ExecutaComando.ExecuteNonQuery();
                int i = Convert.ToInt32(ExecutaComando2.ExecuteScalar());
                ConexaoBanco.Close();
                if (i > 0)
                {
                    foreach (uParcelas parcelas in Obj.uParcelas)
                    {
                        if (parcelas != null)
                        {
                            parcelas.id = i;
                            status = Controller.SalvarParcelas(parcelas);
                            if (!status)
                            {
                                MessageBox.Show("Aconteceu um erro");
                            }
                        }
                    }
                    if (status)
                    {
                        MessageBox.Show("Condição de pagamento cadastrada com sucesso!");
                    }
                }
            }
            catch (Exception Erro)
            {
                MessageBox.Show(": " + Erro);
                return status;
            }
            finally
            {
                ConexaoBanco.Close();
            }
            return status;
        }
    }
}
