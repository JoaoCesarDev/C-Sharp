using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APRESENTAÇÃO.Modelos;
using MySql.Data.MySqlClient;
using System.Data;


namespace APRESENTAÇÃO.DAL
{
    public class UsuariosDAL
    {
        Dados_Conexao con = new Dados_Conexao();
        private MySqlConnection cn;
        public void Incluir(Usuariosinformation usuario)

        {

            //conexao

            cn = new MySqlConnection();

            try

            {

                cn.ConnectionString = con.Conexao();

                //command

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = cn;

                cmd.CommandText = "insert into rentbike.usuarios(id_login,nome,id_perfil,senha,situacao,data_cadastro)" +
                " values (0,@nome,@id_perfil,@senha,@situacao,@data_cadastro);";

                cmd.Parameters.AddWithValue("@nome", usuario.Nome);
                cmd.Parameters.AddWithValue("@id_perfil", usuario.ID_Perfil);
                cmd.Parameters.AddWithValue("@senha", usuario.Senha);
                cmd.Parameters.AddWithValue("@situacao", usuario.Situacao);
                cmd.Parameters.AddWithValue("@data_cadastro", usuario.Data_cadastro);
                
                cn.Open();

                usuario.IDlogin = Convert.ToInt32(cmd.ExecuteScalar());

            }

            catch (MySqlException ex)

            {

                throw new Exception("Servidor SQL Erro:" + ex.Number + ex.Message);

            }

            catch (Exception ex)

            {

                throw new Exception(ex.Message);

            }

            finally

            {

                cn.Close();

            }

        }

        public void Alterar(Usuariosinformation usuarios)

        {

            // conexao

            cn = new MySqlConnection();

            try

            {

                cn.ConnectionString = con.Conexao();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = cn;

                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "UPDATE rentbike.usuarios set id_login=@id_login, nome=@nome, id_perfil=@id_perfil, senha=@senha, situacao=@situacao, data_cadastro=@data_cadastro WHERE id_login=@id_login;";




                cmd.Parameters.AddWithValue("@id_login", usuarios.IDlogin);
                cmd.Parameters.AddWithValue("@nome", usuarios.Nome);
                cmd.Parameters.AddWithValue("@id_perfil", usuarios.ID_Perfil);
                cmd.Parameters.AddWithValue("@senha", usuarios.Senha);
                cmd.Parameters.AddWithValue("@situacao", usuarios.Situacao);
                cmd.Parameters.AddWithValue("@data_cadastro", usuarios.Data_cadastro);
               


                cn.Open();

                cmd.ExecuteNonQuery();


            }
            catch (MySqlException ex)

            {

                throw new Exception(ex.Message);

            }

            finally

            {

                cn.Close();

            }


        }

        public void Excluir(int codigo)

        {

            //conexao

            cn = new MySqlConnection();

            try

            {

                cn.ConnectionString = con.Conexao();

                //command

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = cn;

                cmd.CommandText = "delete from rentbike.usuarios where id_login =" + codigo;


                cn.Open();

                int resultado = cmd.ExecuteNonQuery();

                if (resultado != 1)

                {

                    throw new Exception("Não foi possível excluir o Usuário " + codigo);

                }

            }

            catch (MySqlException ex)

            {

                throw new Exception("Servidor SQL Erro:" + ex.Number);

            }

            catch (Exception ex)

            {

                throw new Exception(ex.Message);

            }

            finally

            {

                cn.Close();

            }

        }
        public DataTable Listagem()

        {
            DataTable tabela = new DataTable();

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT id_login,nome,perfis_do_usuario.perfil,senha,situacao,data_cadastro FROM rentbike.usuarios join perfis_do_usuario on usuarios.id_perfil = perfis_do_usuario.id_perfil", con.Conexao());
            
            da.Fill(tabela);
            
            return tabela;
        }

        public DataTable filtragem(string nome)

        {
            DataTable tabela = new DataTable();

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT id_login,nome,perfis_do_usuario.perfil,senha,situacao,data_cadastro FROM rentbike.usuarios join perfis_do_usuario on usuarios.id_perfil = perfis_do_usuario.id_perfil where nome like'%" + nome + "%';", con.Conexao());

            da.Fill(tabela);

            return tabela;
        }
        



    }
}
