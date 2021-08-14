using System;
using System.Collections;
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
    public class ProdutosDAL

    {
        public int codigo  { get; set; }
    Dados_Conexao con = new Dados_Conexao();
        public ArrayList ProdutosBaixoEstoque()

        {


            MySqlConnection cn = new MySqlConnection(con.Conexao());

            MySqlCommand cmd = new MySqlCommand("Select * from Produto Where Estoque < 5", cn);


            cn.Open();


            MySqlDataReader dr = cmd.ExecuteReader();

            ArrayList lista = new ArrayList();

            while (dr.Read())

            {

                Produtosinformation produto = new Produtosinformation();

                produto.Idproduto = Convert.ToInt32(dr["id_produtos"]);
                produto.Nome = dr["nome"].ToString();
                produto.Descricao = dr["descricao"].ToString();
                produto.Tipo = dr["tipo"].ToString();
                produto.Categoria = dr["categoria"].ToString();
                produto.Fabricante = dr["fabricante"].ToString();
                produto.Codigo = dr["codigo"].ToString();
                produto.Estoque = Convert.ToInt32(dr["estoque"]);
                produto.Precocusto = Convert.ToDecimal(dr["preco_custo"]);
                produto.Precovenda = Convert.ToDecimal(dr["preco_venda"]);
                produto.Idfornec = Convert.ToInt32(dr["id_fornec"]);

                lista.Add(produto);


            }


            dr.Close();

            cn.Close();


            return lista;

        }

        public void Incluir(Produtosinformation produto)

        {

            //conexao

            MySqlConnection cn = new MySqlConnection();

            try

            {

                cn.ConnectionString = con.Conexao();

                //command

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = cn;

                cmd.CommandText = "insert into Produto(id_produtos,nome,descricao,tipo,categoria,fabricante,codigo,estoque,preco_custo,preco_venda,id_fornec)" +
                    "values (0,@nome,@descricao,@tipo,@categoria,@fabricante,@codigo,@estoque,@preco_custo,@preco_venda,@id_fornec);";


                cmd.Parameters.AddWithValue("@nome", produto.Nome);
                cmd.Parameters.AddWithValue("@descricao", produto.Descricao);
                cmd.Parameters.AddWithValue("@tipo", produto.Tipo);
                cmd.Parameters.AddWithValue("@categoria", produto.Categoria);
                cmd.Parameters.AddWithValue("@fabricante", produto.Fabricante);
                cmd.Parameters.AddWithValue("@codigo", produto.Codigo);
                cmd.Parameters.AddWithValue("@estoque", produto.Estoque);
                cmd.Parameters.AddWithValue("@preco_custo", produto.Precocusto);
                cmd.Parameters.AddWithValue("@preco_venda", produto.Precovenda);
                cmd.Parameters.AddWithValue("@id_fornec", produto.Idfornec);

                cn.Open();

                produto.Idproduto = Convert.ToInt32(cmd.ExecuteScalar());


            }

            catch (MySqlException ex)

            {

                throw new Exception("Servidor SQL Erro: " + ex.Number);

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
        public void Alterar(Produtosinformation produto)

        {

            //conexao

            MySqlConnection cn = new MySqlConnection();

            try

            {

                cn.ConnectionString = con.Conexao();

                //command

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = cn;

                cmd.CommandText = "AlterarProduto";

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_produto", produto.Idproduto);
                cmd.Parameters.AddWithValue("@nome", produto.Nome);
                cmd.Parameters.AddWithValue("@descricao", produto.Descricao);
                cmd.Parameters.AddWithValue("@tipo", produto.Tipo);
                cmd.Parameters.AddWithValue("@categoria", produto.Categoria);
                cmd.Parameters.AddWithValue("@fabricante", produto.Fabricante);
                cmd.Parameters.AddWithValue("@codigo", produto.Codigo);
                cmd.Parameters.AddWithValue("@estoque", produto.Estoque);
                cmd.Parameters.AddWithValue("@preco_custo", produto.Precocusto);

                cmd.Parameters.AddWithValue("@preco_venda", produto.Precovenda);

                cmd.Parameters.AddWithValue("@id_fornec", produto.Idfornec);

                cn.Open();

                cmd.ExecuteNonQuery();




            }

            catch (MySqlException ex)

            {

                throw new Exception("Servidor SQL Erro: " + ex.Number);

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
            {

                //conexao

                MySqlConnection cn = new MySqlConnection(con.Conexao());

                try

                {

                    cn.ConnectionString = con.Conexao();

                    //command

                    MySqlCommand cmd = new MySqlCommand();

                    cmd.Connection = cn;

                    cmd.CommandText = "delete from rentbike.produto where id_produtos=" + codigo;


                    cn.Open();

                    int resultado = cmd.ExecuteNonQuery();

                    if (resultado != 1)

                    {

                        throw new Exception("Não foi possível excluir o produto " + codigo);

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


        public DataTable Listagem()

        {

            DataTable tabela = new DataTable();

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT p.id_produtos,p.nome,p.descricao,p.tipo,p.categoria,p.fabricante,p.codigo,p.estoque,p.preco_custo,p.preco_venda,f.id_fornecedores,f.nome FROM " +
                "rentbike.produto as p join fornecedor as f on p.id_fornec = f.id_fornecedores;", con.Conexao());

            da.Fill(tabela);

            return tabela;

        }
        public DataTable Filtragem_Produtos(int codigo)

        {

            DataTable tabela = new DataTable();

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT produto.id_produtos as Cod_Produto,produto.nome as Produto,produto.estoque as Estoque_Disponível,produto.preco_venda as Preço_Unitário FROM rentbike.produto WHERE produto.id_produtos =" + codigo + ";", con.Conexao());

            da.Fill(tabela);

            return tabela;

        }

        public DataTable Filtragem_Produtos_codigo(int codigo)

        {

            DataTable tabela = new DataTable();

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT p.id_produtos,p.nome,p.descricao,p.tipo,p.categoria,p.fabricante,p.codigo,p.estoque,p.preco_custo,p.preco_venda,f.id_fornecedores,f.nome FROM " +
                "rentbike.produto as p join fornecedor as f on p.id_fornec = f.id_fornecedores WHERE p.id_produtos =" + codigo + ";", con.Conexao());

            da.Fill(tabela);

            return tabela;

        }

        public DataTable Filtragem_Produtos_nome(string nome)

        {
            DataTable tabela = new DataTable();

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT p.id_produtos,p.nome,p.descricao,p.tipo,p.categoria,p.fabricante,p.codigo,p.estoque,p.preco_custo,p.preco_venda,f.id_fornecedores,f.nome FROM " +
                "rentbike.produto as p join fornecedor as f on p.id_fornec = f.id_fornecedores WHERE p.nome LIKE '%" + nome + "%';", con.Conexao());

            da.Fill(tabela);

            return tabela;

        }
    }
}


