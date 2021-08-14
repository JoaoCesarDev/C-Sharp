using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using APRESENTAÇÃO.Modelos;
using APRESENTAÇÃO.DAL;
using System.Data;


namespace APRESENTAÇÃO.DAL
{
    public class ItensvendasDAL
    {
        Dados_Conexao con = new Dados_Conexao();

        public DataTable Listagem(int codigo)

        {

                MySqlConnection cn = new MySqlConnection();

                cn.ConnectionString = con.Conexao();

                cn.Open();


                MySqlDataAdapter da = new MySqlDataAdapter("SELECT id_itens_venda,id_vendas,produto.nome as Produto,Quantidade,Valor,total FROM rentbike.itens_da_venda join produto on produto.id_produtos = itens_da_venda.id_produto where itens_da_venda.id_vendas = " + codigo + ";", cn);


                DataTable dt = new DataTable();

                da.Fill(dt);

                cn.Close();

                return dt;

            
        }
            public void Incluir(Itensvendainformation itensvendainformation)

        {
            MySqlConnection cn = new MySqlConnection();
            //conexao

          // MySqlTransaction t = null;

            cn = new MySqlConnection();

            try

            {

                cn.ConnectionString = con.Conexao();

                //command

                MySqlCommand cmd = new MySqlCommand();
                MySqlCommand cmd2 = new MySqlCommand();
                cmd.Connection = cn;
                cmd2.Connection = cn;
                cmd.CommandText = "insert into itens_da_venda(id_itens_venda,id_vendas,id_produto,Quantidade,Valor,total)" +
                "VALUES (null,@id_vendas,@id_produto,@Quantidade,@Valor,@total);";
                
                cmd.Parameters.AddWithValue("@id_vendas", itensvendainformation.Idvendas);
                cmd.Parameters.AddWithValue("@id_produto", itensvendainformation.Id_produto);
                cmd.Parameters.AddWithValue("@Quantidade", itensvendainformation.Quantidade);
                cmd.Parameters.AddWithValue("@Valor", itensvendainformation.Valor);
                cmd.Parameters.AddWithValue("@total", itensvendainformation.Total);
                
                cn.Open();

                itensvendainformation.Iditensvendas = Convert.ToInt32(cmd.ExecuteScalar());

                


               //  t = cn.BeginTransaction();//default


                //  cmd.Transaction = t;

                // cmd2.Transaction = t;




                 // t.Commit();


            }

            catch (MySqlException ex)

            {

                //t.Rollback();

                throw new Exception("Servidor SQL Erro:" + ex.Number + ex.Message);

            }

            finally

            {

                cn.Close();

            }

        }
        public void Atualiza_Estoque(int id_venda)
        {
            MySqlConnection cn = new MySqlConnection();
            cn = new MySqlConnection();

            try

            {

                cn.ConnectionString = con.Conexao();

                //command

                MySqlCommand cmd1 = new MySqlCommand();
                cmd1.Connection = cn;
                cmd1.CommandText = "update produto join itens_da_venda on produto.id_produtos = itens_da_venda.id_produto set produto.estoque = produto.estoque + itens_da_venda.Quantidade where itens_da_venda.id_vendas = @id_vendas;";
                cmd1.Parameters.AddWithValue("@id_vendas", id_venda);
                cn.Open();
                cmd1.ExecuteNonQuery();
            }
            catch(Exception Ex)
            {
                throw new Exception(Ex.Message);
            }
            finally
            {
                cn.Close();
            }
         }

        
        }

    }



