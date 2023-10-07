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
    class uDaoAgenda : uDao
    {
        private MySqlConnection ConexaoBanco;
        public uDaoAgenda()
        {
            this.ConexaoBanco = new Conexao().GetConnection();
        }
        public DataTable PopularGrid(DateTime Data, int? IdFuncionario)
        {
            string Sql = $@"select tb.data_agenda, tb.id_funcionario, fun.nome as funcionario, tb.id_cliente, cli.nome as cliente, 
                            tb.id_servico, ser.descricao as servico from tb_agenda tb 
                            left join tb_funcionarios fun on fun.id_funcionario = tb.id_funcionario
                            left join tb_clientes cli on cli.id_cliente = tb.id_cliente
                            left join tb_servicos ser on ser.id_servico = tb.id_servico
                            where cast(tb.data_agenda as date) = cast('{Data.ToString("yyyy-MM-dd")}' as date)";

            if (IdFuncionario != null
                )
                Sql = Sql + $"and tb.id_funcionario = {IdFuncionario}";

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
        
        public void Alterar(uAgenda Obj)
        {
            try
            {
                string Sql = @"update tb_agenda set id_cliente =  @id_cliente, id_servico = @id_servico
                                where data_agenda = @data_agenda and id_funcionario = @id_funcionario";
                MySqlCommand ExecutaCmd = new MySqlCommand(Sql, ConexaoBanco);
                if (Obj.Cliente != null)
                    ExecutaCmd.Parameters.AddWithValue("@id_cliente", Obj.Cliente.id);
                else
                    ExecutaCmd.Parameters.AddWithValue("@id_cliente", null);
                if (Obj.Servicos != null)
                    ExecutaCmd.Parameters.AddWithValue("@id_servico", Obj.Servicos.id);
                else
                    ExecutaCmd.Parameters.AddWithValue("@id_servico", null);
                ExecutaCmd.Parameters.AddWithValue("@data_agenda", Obj.Data);
                ExecutaCmd.Parameters.AddWithValue("@id_funcionario", Obj.Funcionario.id);
                ConexaoBanco.Open();
                ExecutaCmd.ExecuteNonQuery();
                ConexaoBanco.Close();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Aconteceu o Erro: " + Erro);
            }
        }
        
        public uAgenda Selecionar(DateTime Data, int IdFuncionario)
        {
            try
            {
                uCtrlAgenda CtrlAgenda = new uCtrlAgenda();
                string Sql = @"select tb.id_funcionario, tb.data_agenda, tb.id_cliente, cli.nome cliente, fun.nome funcionario, tb.id_servico, ser.descricao as servico from tb_agenda tb
                                left join tb_funcionarios fun on fun.id_funcionario = tb.id_funcionario
                                left join tb_clientes cli on cli.id_cliente = tb.id_cliente
                                left join tb_servicos ser on ser.id_servico = tb.id_servico
                                where tb.id_funcionario = @id_funcionario and tb.data_agenda = @data_agenda";
                MySqlCommand ExecutaCmd = new MySqlCommand(Sql, ConexaoBanco);
                ExecutaCmd.Parameters.AddWithValue("@id_funcionario", IdFuncionario);
                ExecutaCmd.Parameters.AddWithValue("@data_agenda", Data);
                ConexaoBanco.Open();
                using (var reader = ExecutaCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        uAgenda Obj = new uAgenda
                        {
                            Data = Convert.ToDateTime(reader["data_agenda"]),
                            Funcionario = new uFuncionario
                            {
                                id = Convert.ToInt32(reader["id_funcionario"]),
                                Nome = Convert.ToString(reader["funcionario"])
                            }
                            
                        };
                        int idCliente = 0;
                        int.TryParse(reader["id_cliente"].ToString(), out idCliente);
                        if(idCliente > 0)
                        {
                            Obj.Cliente = new uCliente
                            {
                                id = Convert.ToInt32(reader["id_cliente"]),
                                Nome = Convert.ToString(reader["cliente"])
                            };
                        }
                        int idServico = 0;
                        int.TryParse(reader["id_servico"].ToString(), out idServico);
                        if (idServico > 0)
                        {
                            Obj.Servicos = new uServicos
                            {
                                id = idServico,
                                Descricao = Convert.ToString(reader["servico"])
                            };
                        }
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
        /*
        public void Excluir(uAgenda Obj)
        {
            try
            {
                string Sql = "delete from tb_cargos where id_cargo = @id_cargo";

                MySqlCommand ExecutaCmd = new MySqlCommand(Sql, ConexaoBanco);
                ExecutaCmd.Parameters.AddWithValue("@id_cargo", Obj.id);
                ConexaoBanco.Open();
                ExecutaCmd.ExecuteNonQuery();
                MessageBox.Show("Cargo excluido com sucesso!");

                ConexaoBanco.Close();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Aconteceu o Erro: " + Erro);
            }
        }
        public uAgenda SelecionarNome(string Nome)
        {
            try
            {
                string Sql = "select * from tb_cargos where cargo like @cargo";
                MySqlCommand ExecutaCmd = new MySqlCommand(Sql, ConexaoBanco);
                ExecutaCmd.Parameters.AddWithValue("@cargo", "%" + Nome + "%");
                ConexaoBanco.Open();
                using (var reader = ExecutaCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        uAgenda Obj = new uAgenda
                        {
                            Cargo = Convert.ToString(reader["cargo"])
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
        }*/
        public void Salvar(uAgenda Obj)
        {
            try
            {
                string Sql = @"insert into tb_agenda (id_funcionario, id_cliente, data_agenda)
                                values (@id_funcionario, @id_cliente, @data_agenda)";

                MySqlCommand ExecutaComando = new MySqlCommand(Sql, ConexaoBanco);

                ExecutaComando.Parameters.AddWithValue("@id_funcionario", Obj.Funcionario.id);
                if (Obj.Cliente != null)
                    ExecutaComando.Parameters.AddWithValue("@id_cliente", Obj.Cliente.id);
                else
                    ExecutaComando.Parameters.AddWithValue("@id_cliente", null);
                ExecutaComando.Parameters.AddWithValue("@data_agenda", Obj.Data);
                ConexaoBanco.Open();
                ExecutaComando.ExecuteNonQuery();
                ConexaoBanco.Close();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Aconteceu um erro: " + Erro);
            }
        }
    }
}
