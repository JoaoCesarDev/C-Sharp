using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using APRESENTAÇÃO.Modelos;
using MySql.Data.MySqlClient;
using APRESENTAÇÃO.DAL;

namespace APRESENTAÇÃO.DAL
{
    public class PerfisusuariosDAL
    {
        Dados_Conexao con = new Dados_Conexao();
        private MySqlConnection cn;
        
        public DataTable Listagem()

        {
            DataTable tabela = new DataTable();

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * from perfis_do_usuario;", con.Conexao());

            da.Fill(tabela);


            return tabela;
        }


        public void Incluir(Perfisusuarioinformation Perfil)

        {

            //conexao

            cn = new MySqlConnection();

            try

            {

                cn.ConnectionString = con.Conexao();

                //command

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = cn;

                cmd.CommandText = "insert into rentbike.perfis_do_usuario(id_perfil,perfil,cadastrar,alterar,excluir) values (0,@perfil,@cadastrar,@alterar,@excluir);";

                cmd.Parameters.AddWithValue("@perfil", Perfil.Perfil);
                cmd.Parameters.AddWithValue("@cadastrar", Perfil.Cadastrar);
                cmd.Parameters.AddWithValue("@alterar", Perfil.Alterar);
                cmd.Parameters.AddWithValue("@excluir", Perfil.Excluir);


                cn.Open();

                Perfil.IDperfil = Convert.ToInt32(cmd.ExecuteScalar());

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

        public void Alterar(Perfisusuarioinformation perfil)

        {

            // conexao

            cn = new MySqlConnection();

            try

            {

                cn.ConnectionString = con.Conexao();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = cn;

                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "UPDATE rentbike.perfis_do_usuario set id_perfil=@id_perfil, cadastrar=@cadastrar, alterar=@alterar, excluir=@excluir WHERE id_perfil=@id_perfil;"; 
                

                cmd.Parameters.AddWithValue("@id_perfil", perfil.IDperfil);
                cmd.Parameters.AddWithValue("@cadastrar", perfil.Cadastrar);
                cmd.Parameters.AddWithValue("@alterar", perfil.Alterar);
                cmd.Parameters.AddWithValue("@excluir", perfil.Excluir);
                
                cn.Open();

                cmd.ExecuteNonQuery();


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

                cmd.CommandText = "delete from rentbike.perfis_do_usuario where id_perfil =" + codigo;


                cn.Open();

                int resultado = cmd.ExecuteNonQuery();

                if (resultado != 1)

                {

                    throw new Exception("Não foi possível excluir o perfil " + codigo);

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
       
        
    }
}
