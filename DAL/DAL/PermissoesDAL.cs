using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APRESENTAÇÃO.DAL;
using System.Data;
using MySql.Data.MySqlClient;

namespace APRESENTAÇÃO.DAL
{
    public class PermissoesDAL
    {
        Dados_Conexao con = new Dados_Conexao();
        private MySqlConnection cn;
        public Boolean permissao = false;
        public bool Permissao(string user)
        {
           
            int função;
            int função1;
            int função2;
            try
            {
                cn = new MySqlConnection();
                cn.ConnectionString = con.Conexao();

                MySqlCommand com = new MySqlCommand();
                com.Connection = cn;
                com.CommandText = "SELECT nome,perfil,cadastrar,alterar,excluir FROM rentbike.usuarios join perfis_do_usuario on rentbike.usuarios.id_perfil = rentbike.perfis_do_usuario.id_perfil where nome like @nome;";
                com.Parameters.AddWithValue("@nome", user.ToString());
                
                cn.Open();
                MySqlDataReader dados = com.ExecuteReader();

                if (dados.Read())
                {
                    função = Convert.ToInt32(dados.GetValue(2));
                    função1 = Convert.ToInt32(dados.GetValue(3));
                    função2 = Convert.ToInt32(dados.GetValue(3));

                    if (função.Equals(1))
                    {
                        permissao = true;

                    }
                    if (função1.Equals(1))
                    {
                        permissao = true;

                    }
                    if (função2.Equals(1))
                    {
                        permissao = true;

                    }
                    else
                    {
                        permissao = false;
                    }

                }

                
                cn.Close();
                return permissao;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }




    }
}
