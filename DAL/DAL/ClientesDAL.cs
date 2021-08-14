using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APRESENTAÇÃO.Modelos;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace APRESENTAÇÃO.DAL
{

    public class ClientesDAL
    {
        public int codigo { get; set; }
        public string nome { get; set; }

        Dados_Conexao con = new Dados_Conexao();
        private MySqlConnection cn;

        public void Incluir(Clientesinformation cliente)

        {

            //conexao

            cn = new MySqlConnection();

            try

            {



                cn.ConnectionString = con.Conexao();

                //command

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = cn;

                cmd.CommandText = "insert into cliente(id_Cliente,nome,data_cadastro,endereco,bairro,cidade,estado,telefone,cep,celular,email,cpf)" +
                " values (0,@nome,@data_cadastro,@endereco,@bairro,@cidade,@estado,@telefone,@cep,@celular,@email,@cpf);";
                
                cmd.Parameters.AddWithValue("@nome", cliente.Nome);
                cmd.Parameters.AddWithValue("@data_cadastro", cliente.Datacadastro);
                cmd.Parameters.AddWithValue("@endereco", cliente.Endereco);
                cmd.Parameters.AddWithValue("@bairro", cliente.Bairro);
                cmd.Parameters.AddWithValue("@cidade", cliente.Cidade);
                cmd.Parameters.AddWithValue("@estado", cliente.Estado);
                cmd.Parameters.AddWithValue("@telefone", cliente.Telefone);
                cmd.Parameters.AddWithValue("@cep", cliente.Cep);
                cmd.Parameters.AddWithValue("@celular", cliente.Celular);
                cmd.Parameters.AddWithValue("@email", cliente.Email);
                cmd.Parameters.AddWithValue("@cpf", cliente.CPF);
              
                

                cn.Open();

                cliente.ClienteID = Convert.ToInt32(cmd.ExecuteScalar());

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


        public void Alterar(Clientesinformation cliente)

        {

            // conexao

            cn = new MySqlConnection();

            try

            {

                cn.ConnectionString = con.Conexao();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = cn;

                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "UPDATE rentbike.cliente set id_Cliente=@id_cliente, nome=@nome, endereco=@endereco, bairro=@bairro, cidade=@cidade, estado=@estado," +
                "telefone=@telefone, cep=@cep, celular=@celular, email=@email, cpf=@cpf WHERE id_Cliente=@id_cliente;";

                cmd.Parameters.AddWithValue("@id_cliente", cliente.ClienteID);
                cmd.Parameters.AddWithValue("@nome", cliente.Nome);
                cmd.Parameters.AddWithValue("@endereco", cliente.Endereco);
                cmd.Parameters.AddWithValue("@bairro", cliente.Bairro);
                cmd.Parameters.AddWithValue("@cidade", cliente.Cidade);
                cmd.Parameters.AddWithValue("@estado", cliente.Estado);
                cmd.Parameters.AddWithValue("@telefone", cliente.Telefone);
                cmd.Parameters.AddWithValue("@cep", cliente.Cep);
                cmd.Parameters.AddWithValue("@celular", cliente.Celular);
                cmd.Parameters.AddWithValue("@email", cliente.Email);
                cmd.Parameters.AddWithValue("@cpf", cliente.CPF);
              
                
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

                cmd.CommandText = "delete from rentbike.cliente where id_cliente =" + codigo;


                cn.Open();

                int resultado = cmd.ExecuteNonQuery();

               

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

            MySqlDataAdapter da = new MySqlDataAdapter("select * from rentbike.cliente", con.Conexao());

            da.Fill(tabela);

            return tabela;
        }

        public DataTable Filtragem(string letras)

        {

            DataTable tabela = new DataTable();

            MySqlDataAdapter da = new MySqlDataAdapter("select * from rentbike.cliente WHERE nome LIKE '%" + letras + "%';", con.Conexao());

            da.Fill(tabela);

            return tabela;
        }


    }
    }
 
