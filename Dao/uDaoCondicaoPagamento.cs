﻿using MySql.Data.MySqlClient;
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
            try
            {
                uCtrlFormaPagamento CtrlFormaPagamento = new uCtrlFormaPagamento();
                string Sql = "select * from tb_condicao_pagamento where id_condicao = @id_condicao";
                MySqlCommand ExecutaCmd = new MySqlCommand(Sql, ConexaoBanco);
                ExecutaCmd.Parameters.AddWithValue("@id_condicao", Id);
                ConexaoBanco.Open();
                using (var reader = ExecutaCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        uCondicaoPagamento Obj = new uCondicaoPagamento
                        {
                            id = Convert.ToInt32(reader["id_condicao"]),
                            Condicao = Convert.ToString(reader["condicao"]),
                            Parcelas = Convert.ToInt32(reader["parcelas"]),
                            Taxa = Convert.ToInt32(reader["taxa"]),
                            Multa = Convert.ToInt32(reader["multa"]),
                            Desconto = Convert.ToInt32(reader["desconto"]),
                            Dias = Convert.ToInt32(reader["dias"]),
                            Forma = CtrlFormaPagamento.Carregar(Convert.ToInt32(reader["id_forma"])),
                            data_criacao = Convert.ToDateTime(reader["data_criacao"]),
                            data_ult_alteracao = Convert.ToDateTime(reader["data_ult_alteracao"])
                        };
                        ConexaoBanco.Close();
                        return Obj;
                    }
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
                                multa = @multa, desconto = @desconto, dias = @dias, id_forma = @id_forma,
                                   data_ult_alteracao = @data_ult_alteracao where id_condicao = @id_condicao";
                MySqlCommand ExecutaCmd = new MySqlCommand(Sql, ConexaoBanco);
                ExecutaCmd.Parameters.AddWithValue("@id_condicao", Obj.id);
                ExecutaCmd.Parameters.AddWithValue("@condicao", Obj.Condicao);
                ExecutaCmd.Parameters.AddWithValue("@parcelas", Obj.Parcelas);
                ExecutaCmd.Parameters.AddWithValue("@taxa", Obj.Taxa);
                ExecutaCmd.Parameters.AddWithValue("@multa", Obj.Multa);
                ExecutaCmd.Parameters.AddWithValue("@desconto", Obj.Desconto);
                ExecutaCmd.Parameters.AddWithValue("@dias", Obj.Dias);
                ExecutaCmd.Parameters.AddWithValue("@id_forma", Obj.Forma.id);
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
        public void Salvar(uCondicaoPagamento Obj)
        {
            try
            {
                string Sql = @"insert into tb_condicao_pagamento (condicao, parcelas, taxa, multa, desconto, dias, id_forma, data_criacao, data_ult_alteracao)
                                values(@condicao, @parcelas, @taxa, @multa, @desconto, @dias, @id_forma, @data_criacao, @data_ult_alteracao)";

                MySqlCommand ExecutaComando = new MySqlCommand(Sql, ConexaoBanco);

                ExecutaComando.Parameters.AddWithValue("@condicao", Obj.Condicao);
                ExecutaComando.Parameters.AddWithValue("@parcelas", Obj.Parcelas);
                ExecutaComando.Parameters.AddWithValue("@taxa", Obj.Taxa);
                ExecutaComando.Parameters.AddWithValue("@multa", Obj.Multa);
                ExecutaComando.Parameters.AddWithValue("@desconto", Obj.Desconto);
                ExecutaComando.Parameters.AddWithValue("@dias", Obj.Dias);
                ExecutaComando.Parameters.AddWithValue("@id_forma", Obj.Forma.id);
                ExecutaComando.Parameters.AddWithValue("@data_criacao", Obj.data_criacao);
                ExecutaComando.Parameters.AddWithValue("@data_ult_alteracao", Obj.data_ult_alteracao);
                ConexaoBanco.Open();
                ExecutaComando.ExecuteNonQuery();
                MessageBox.Show("Condição cadastrada com sucesso!");
                ConexaoBanco.Close();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Aconteceu um erro: " + Erro);
            }
        }
    }
}
