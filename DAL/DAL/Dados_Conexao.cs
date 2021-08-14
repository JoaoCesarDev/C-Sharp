using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;



namespace APRESENTAÇÃO.DAL
{
    
   public class Dados_Conexao
    {
       public string Conexao()
        {
            var server = ConfigurationManager.AppSettings["server"];
            var database = ConfigurationManager.AppSettings["database"];
            var uid = ConfigurationManager.AppSettings["uid"];
            var pwd = ConfigurationManager.AppSettings["pwd"];
            var connection = "server=" + server + ";" + "database=" + database + ";" + "uid=" + uid + ";" + "pwd=" + pwd + ";";
            return connection;
        }

    }
}
