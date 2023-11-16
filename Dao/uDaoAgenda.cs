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
    class uDaoAgenda : uDao
    {
        private MySqlConnection ConexaoBanco;
        public uDaoAgenda()
        {
            this.ConexaoBanco = new Conexao().GetConnection();
        }
        public DataTable PopularGrid(DateTime Data, int? IdFuncionario)
        {
            string Sql = $@"select tb.id_agenda, tb.data_agenda,case when tb.id_cliente > 0 and tb.id_receber is null then 'Agendado'
                            when tb.id_cliente > 0 and tb.id_receber > 0 then 'Finalizado'
                            else 'Disponível' end status, tb.id_funcionario, fun.nome as funcionario, tb.id_cliente, cli.nome as cliente, 
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

        public DataTable PopularGridReceber(DateTime Data)  
        {
            string Sql = $@"select tb.id_agenda, tb.data_agenda, tb.id_funcionario, fun.nome as funcionario, tb.id_cliente, cli.nome as cliente, 
                            tb.id_servico, ser.descricao as servico, cli.id_forma, fr.forma from tb_agenda tb 
                            left join tb_funcionarios fun on fun.id_funcionario = tb.id_funcionario
                            left join tb_clientes cli on cli.id_cliente = tb.id_cliente
                            left join tb_servicos ser on ser.id_servico = tb.id_servico
                            left join tb_forma_pagamento fr on fr.id_forma = cli.id_forma
                            where cast(tb.data_agenda as date) = cast('{Data.ToString("yyyy-MM-dd")}' as date) and tb.id_receber is null and tb.id_cliente is not null";


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
            ConexaoBanco.Open();
            var Transacao = ConexaoBanco.BeginTransaction();
            try
            {
                var Tempo = Obj.Servicos.Duracao;
                var Data = Obj.Data;
                var IdAgenda = 0;
                while (Tempo > TimeSpan.Parse("0"))
                {
                    var Agenda = Selecionar(Data, Obj.Funcionario.id, Transacao);
                    if (Agenda.Cliente != null)
                    {
                        throw new Exception("Horario Reservado");
                    }
                    if (Data < DateTime.Now)
                    {
                        throw new Exception("Horario Nao Permitido");
                    }
                    {
                        var TempSql = string.Empty;
                        var TempSql2 = string.Empty;
                        if(IdAgenda > 0)
                        {
                            TempSql = ", id_agenda_referencia = @id_agenda_referencia";
                        }
                        string Sql = $@"update tb_agenda set id_cliente =  @id_cliente, id_servico = @id_servico {TempSql}
                                where id_agenda = @id_agenda";
                        MySqlCommand ExecutaCmd = new MySqlCommand(Sql, ConexaoBanco,Transacao);
                        if (Obj.Cliente != null)
                            ExecutaCmd.Parameters.AddWithValue("@id_cliente", Obj.Cliente.id);
                        else
                            ExecutaCmd.Parameters.AddWithValue("@id_cliente", null);
                        if (Obj.Servicos != null)
                            ExecutaCmd.Parameters.AddWithValue("@id_servico", Obj.Servicos.id);
                        else
                            ExecutaCmd.Parameters.AddWithValue("@id_servico", null);
                        if (IdAgenda > 0)
                        {
                            ExecutaCmd.Parameters.AddWithValue("@id_agenda_referencia", IdAgenda);
                        }
                        ExecutaCmd.Parameters.AddWithValue("@id_agenda", Agenda.id_agenda);

                        ExecutaCmd.ExecuteNonQuery();
                        if (IdAgenda == 0)
                            IdAgenda = Agenda.id_agenda;
                        
                    }
                    Data = Data.AddMinutes(Obj.Intervalo);
                    Tempo -=(TimeSpan.FromMinutes(Obj.Intervalo));
                }
                Transacao.Commit();
                MessageBox.Show("Agendado");
            }
            catch (Exception Erro)
            {
                Transacao.Rollback();
                MessageBox.Show("Aconteceu o Erro: " + Erro.Message);
            }
            finally { ConexaoBanco.Close(); }
        }

        public DataTable Verificar_datas(int Ano, int Mes, int IdFuncionario)
        {
            DataTable Dt = new DataTable();
            ConexaoBanco.Open();
            try
            {
                string Sql = $@"select distinct cast(tb.data_agenda as date) as data from tb_agenda tb where 
                            year(tb.data_agenda) = {Ano} and month(tb.data_agenda) = {Mes} and tb.id_funcionario = {IdFuncionario}";
                uCtrlAgenda CtrlAgenda = new uCtrlAgenda();
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

        public uAgenda Selecionar(int IdAgenda)
        {
            try
            {
                uCtrlAgenda CtrlAgenda = new uCtrlAgenda();
                string Sql = @"select tb.id_agenda, tb.id_funcionario, tb.data_agenda, tb.id_cliente, cli.nome cliente, fun.nome funcionario, tb.id_servico, ser.descricao as servico, tb.intervalo, ser.valor, tb.id_agenda_referencia, cli.id_forma, fr.forma from tb_agenda tb
                                left join tb_funcionarios fun on fun.id_funcionario = tb.id_funcionario
                                left join tb_clientes cli on cli.id_cliente = tb.id_cliente
                                left join tb_servicos ser on ser.id_servico = tb.id_servico
                                left join tb_forma_pagamento fr on fr.id_forma = cli.id_forma
                                where tb.id_agenda = @id_agenda";
                MySqlCommand ExecutaCmd = new MySqlCommand(Sql, ConexaoBanco);
                ExecutaCmd.Parameters.AddWithValue("@id_agenda", IdAgenda);
                ConexaoBanco.Open();
                using (var reader = ExecutaCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int id_agenda_referencia = 0;
                        int.TryParse(reader["id_agenda_referencia"].ToString(), out id_agenda_referencia);
                        uAgenda Obj = new uAgenda
                        {
                            id_agenda = Convert.ToInt32(reader["id_agenda"]),
                            Data = Convert.ToDateTime(reader["data_agenda"]),
                            id_agenda_referencia = id_agenda_referencia,
                            Funcionario = new uFuncionario
                            {
                                id = Convert.ToInt32(reader["id_funcionario"]),
                                Nome = Convert.ToString(reader["funcionario"])
                            }
                            
                        };
                        int Intervalo = 0;
                        int.TryParse(reader["intervalo"].ToString(), out Intervalo);
                        Obj.Intervalo = Intervalo;
                        int idCliente = 0;
                        int.TryParse(reader["id_cliente"].ToString(), out idCliente);
                        
                        if (idCliente > 0)
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
                                Descricao = Convert.ToString(reader["servico"]),
                                Valor = Convert.ToDecimal(reader["valor"])
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

        public uAgenda Selecionar(DateTime Data, int IdFuncionario, MySqlTransaction transaction)
        {
            try
            {
                uCtrlAgenda CtrlAgenda = new uCtrlAgenda();
                string Sql = @"select tb.id_agenda, tb.id_funcionario, tb.data_agenda, tb.id_cliente, cli.nome cliente, fun.nome funcionario, tb.id_servico, ser.descricao as servico, tb.intervalo from tb_agenda tb
                                left join tb_funcionarios fun on fun.id_funcionario = tb.id_funcionario
                                left join tb_clientes cli on cli.id_cliente = tb.id_cliente
                                left join tb_servicos ser on ser.id_servico = tb.id_servico
                                where tb.id_funcionario = @id_funcionario and tb.data_agenda = @data_agenda";
                MySqlCommand ExecutaCmd = new MySqlCommand(Sql, ConexaoBanco, transaction);
                ExecutaCmd.Parameters.AddWithValue("@id_funcionario", IdFuncionario);
                ExecutaCmd.Parameters.AddWithValue("@data_agenda", Data);
                using (var reader = ExecutaCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        uAgenda Obj = new uAgenda
                        {
                            id_agenda = Convert.ToInt32(reader["id_agenda"]),
                            Data = Convert.ToDateTime(reader["data_agenda"]),
                            Funcionario = new uFuncionario
                            {
                                id = Convert.ToInt32(reader["id_funcionario"]),
                                Nome = Convert.ToString(reader["funcionario"])
                            }

                        };
                        int Intervalo = 0;
                        int.TryParse(reader["intervalo"].ToString(), out Intervalo);
                        Obj.Intervalo = Intervalo;
                        int idCliente = 0;
                        int.TryParse(reader["id_cliente"].ToString(), out idCliente);
                        if (idCliente > 0)
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
            {
                if (Obj.Data < DateTime.Now)
                    throw new Exception("Data inválida.");

                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(
                    $"select id_agenda from tb_agenda WHERE id_funcionario = {Obj.Funcionario.id} AND data_agenda =  '{Obj.Data.ToString("yyyy-MM-dd hh:mm")}'", ConexaoBanco);
                DataTable Dt = new DataTable();
                sqlDataAdapter.Fill(Dt);
                if (Dt.Rows.Count > 0)
                    throw new Exception("Agenda já reservada.");
                string Sql = @"insert into tb_agenda (id_funcionario, id_cliente, data_agenda, intervalo)
                                values (@id_funcionario, @id_cliente, @data_agenda, @intervalo)";

                MySqlCommand ExecutaComando = new MySqlCommand(Sql, ConexaoBanco);

                ExecutaComando.Parameters.AddWithValue("@id_funcionario", Obj.Funcionario.id);
                if (Obj.Cliente != null)
                    ExecutaComando.Parameters.AddWithValue("@id_cliente", Obj.Cliente.id);
                else
                    ExecutaComando.Parameters.AddWithValue("@id_cliente", null);
                ExecutaComando.Parameters.AddWithValue("@data_agenda", Obj.Data);
                ExecutaComando.Parameters.AddWithValue("@intervalo", Obj.Intervalo);
                ConexaoBanco.Open();
                ExecutaComando.ExecuteNonQuery();
                ConexaoBanco.Close();
            }
        }
    }
}
