using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using APRESENTAÇÃO.Modelos;
using APRESENTAÇÃO.DAL;




namespace APRESENTAÇÃO.UIWindows
{
    public class Validação_login
    {
        Dados_Conexao con = new Dados_Conexao();
        private MySqlConnection cn;
        public Boolean login = false;
        public int tipo { get; set; }
        public string status { get; set; }
        public void Login(string user, string senha)
        {
            try
            {
                cn = new MySqlConnection();
                cn.ConnectionString = con.Conexao();

                MySqlCommand com = new MySqlCommand();
                com.Connection = cn;
                com.CommandText = "select nome, senha, id_perfil, situacao from rentbike.usuarios where nome like @nome and senha like @senha";
                com.Parameters.AddWithValue("@nome", user.ToString());
                com.Parameters.AddWithValue("@senha", senha.ToString());
                cn.Open();
                MySqlDataReader dados = com.ExecuteReader();

                if (dados.Read())
                {
                    tipo  = dados.GetInt32("id_perfil");
                    user = dados.GetString("nome");
                    status = dados.GetString("situacao");
                    if (tipo.Equals(4) && status.Equals("Ativo"))
                    {
                        login = true;
                        
                    }
                    else if (tipo.Equals(6) && status.Equals("Ativo"))
                    {
                        login = true;
                       
                    }
                    else if (tipo.Equals(8) && status.Equals("Ativo"))
                    {
                        login = true;

                    }
                    else if (tipo.Equals(5) && status.Equals("Ativo"))
                    {
                        login = true;

                    }
                    else if (tipo.Equals(7) && status.Equals("Ativo"))
                    {
                        login = true;

                    }
                    else
                    {
                        login = false;
                    }
                    
                }
                
                
                cn.Close();
            }
            catch(MySqlException erro)
            {
                MessageBox.Show(erro + "Conexão ao Banco de Dados");
            }
        }

       
    }
}
