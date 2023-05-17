using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema__Renovo_Barber
{
    public class Conexao
    {
        public MySqlConnection GetConnection()
        {
            string ConexaoBanco = ConfigurationManager.ConnectionStrings["erp_renovo_barber"].ConnectionString;

            return new MySqlConnection(ConexaoBanco);
        }
    }
}
