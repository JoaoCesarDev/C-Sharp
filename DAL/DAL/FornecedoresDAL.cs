using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using APRESENTAÇÃO.Modelos;
using MySql.Data.MySqlClient;

namespace APRESENTAÇÃO.DAL
{
    
    public class FornecedoresDAL
      {
        Dados_Conexao con = new Dados_Conexao();
        private MySqlConnection cn;
        public void Incluir(Fornecedorinformation fornecedor)

        {

            //conexao

            MySqlConnection cn = new MySqlConnection();

            try

            {

                cn.ConnectionString = con.Conexao();

                //command

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = cn;

                cmd.CommandText = "insert into fornecedor(id_fornecedores,nome,endereco,bairro,cidade,estado,pais,telefone,cnpj)" +
                " values (0,@nome,@endereco,@bairro,@cidade,@estado,@pais,@telefone,@cnpj);";

                
                cmd.Parameters.AddWithValue("@nome", fornecedor.Nome);
                cmd.Parameters.AddWithValue("@endereco", fornecedor.Endereco);
                cmd.Parameters.AddWithValue("@bairro", fornecedor.Bairro);
                cmd.Parameters.AddWithValue("@cidade", fornecedor.Cidade);
                cmd.Parameters.AddWithValue("@estado", fornecedor.Estado);
                cmd.Parameters.AddWithValue("@pais", fornecedor.Pais);
                cmd.Parameters.AddWithValue("@telefone", fornecedor.Telefone);
                cmd.Parameters.AddWithValue("@cnpj", fornecedor.CNPJ);
                
                cn.Open();

                fornecedor.Idfornecedores = Convert.ToInt32(cmd.ExecuteScalar());

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


        public void Alterar(Fornecedorinformation fornecedor)

        {

            // conexao

            cn = new MySqlConnection();

            try

            {

                cn.ConnectionString = con.Conexao();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = cn;

                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "UPDATE rentbike.fornecedor set nome=@nome, endereco=@endereco, bairro=@bairro, cidade=@cidade, estado=@estado," +
                "pais=@pais, telefone=@telefone, cnpj=@cnpj where id_fornecedores=@id_fornecedores;";

                cmd.Parameters.AddWithValue("@id_fornecedores", fornecedor.Idfornecedores);
                cmd.Parameters.AddWithValue("@nome", fornecedor.Nome);
                cmd.Parameters.AddWithValue("@endereco", fornecedor.Endereco);
                cmd.Parameters.AddWithValue("@bairro", fornecedor.Bairro);
                cmd.Parameters.AddWithValue("@cidade", fornecedor.Cidade);
                cmd.Parameters.AddWithValue("@estado", fornecedor.Estado);
                cmd.Parameters.AddWithValue("@pais", fornecedor.Pais);
                cmd.Parameters.AddWithValue("@telefone", fornecedor.Telefone);
                cmd.Parameters.AddWithValue("@cnpj", fornecedor.CNPJ);
                
                cn.Open();

                cmd.ExecuteNonQuery();

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


        public void Excluir(int codigo)

        {

            //conexao

            MySqlConnection cn = new MySqlConnection();

            try

            {

                cn.ConnectionString = con.Conexao();

                //command

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = cn;

                cmd.CommandText = "delete from fornecedor where id_fornecedores =" + codigo;


                cn.Open();

                int resultado = cmd.ExecuteNonQuery();

                if (resultado != 1)

                {

                    throw new Exception("Não foi possível excluir o cliente " + codigo);

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

            MySqlDataAdapter da = new MySqlDataAdapter("select * from fornecedor", con.Conexao());
            da.Fill(tabela);

            return tabela;

        }

        public DataTable Filtragem(string nome)

        {

            DataTable tabela = new DataTable();

            MySqlDataAdapter da = new MySqlDataAdapter("select * from rentbike.fornecedor WHERE nome LIKE '%" + nome + "%';", con.Conexao());

            da.Fill(tabela);

            return tabela;
        }


    }
}
