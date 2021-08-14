using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using APRESENTAÇÃO.Modelos;
using APRESENTAÇÃO.DAL;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace APRESENTAÇÃO.DAL
{
    public class VendasDAL
    {
        Dados_Conexao con = new Dados_Conexao();

        public DataTable Listagem

        {

            get

            {

                MySqlConnection cn = new MySqlConnection();

                cn.ConnectionString = con.Conexao();

                cn.Open();


                MySqlDataAdapter da = new MySqlDataAdapter("SELECT id_venda,data_da_venda,data_expedicao,cliente.nome,funcionario.nome,venda.forma_de_pagamento,venda.parcelas,venda.valor_parcelas,venda.desconto,venda.subtotal,venda.valor_total,venda.valor_pago,venda.troco  FROM rentbike.venda join cliente on cliente.id_Cliente = venda.CLIENTE_id_Cliente join funcionario on venda.FUNCIONARIO_id_funcionarios = funcionario.id_funcionarios;", cn);


                DataTable dt = new DataTable();

                da.Fill(dt);

                cn.Close();

                return dt;

            }
        }

        public DataTable Filtragem_por_cliente(string nome)

        {

            DataTable tabela = new DataTable();

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT id_venda,data_da_venda,data_expedicao,cliente.nome,funcionario.nome,venda.forma_de_pagamento,venda.parcelas,venda.valor_parcelas,venda.desconto,venda.subtotal,venda.valor_total,venda.valor_pago,venda.troco  FROM rentbike.venda join cliente on cliente.id_Cliente = venda.CLIENTE_id_Cliente join funcionario on venda.FUNCIONARIO_id_funcionarios = funcionario.id_funcionarios where cliente.nome LIKE '%" + nome + "%';", con.Conexao());

            da.Fill(tabela);

            return tabela;

        }

        public DataTable Filtragem_por_data(string data)

        {
            MySqlConnection cn = new MySqlConnection();
            
            cn.ConnectionString = con.Conexao();

            var sql = "SELECT id_venda,data_da_venda,data_expedicao,cliente.nome,funcionario.nome,venda.forma_de_pagamento,venda.parcelas,venda.valor_parcelas,venda.desconto,venda.subtotal,venda.valor_total,venda.valor_pago,venda.troco  FROM rentbike.venda join cliente on cliente.id_Cliente = venda.CLIENTE_id_Cliente join funcionario on venda.FUNCIONARIO_id_funcionarios = funcionario.id_funcionarios where data_da_venda = @data ;";

            MySqlCommand cmd = new MySqlCommand();

            cmd.Connection = cn;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = sql;

            cmd.Parameters.Add("@data", MySqlDbType.VarChar).Value =  data ;

            MySqlDataAdapter da = new MySqlDataAdapter();

            da.SelectCommand = cmd;

            DataTable tabela = new DataTable();

            da.Fill(tabela);

            return tabela;

        }
        public DataTable ListaDeProdutos

        {

            get

            {

                MySqlConnection cn = new MySqlConnection();

                cn.ConnectionString = con.Conexao();

                cn.Open();


                MySqlDataAdapter da = new MySqlDataAdapter("select * from rentbike.produto", cn);


                DataTable dt = new DataTable();

                da.Fill(dt);

                cn.Close();

                return dt;

            }

        }

        public DataTable ListaDeFuncionarios

        {

            get

            {

                MySqlConnection cn = new MySqlConnection();

                cn.ConnectionString = con.Conexao();

                cn.Open();


                MySqlDataAdapter da = new MySqlDataAdapter("select * from rentbike.funcionario", cn);


                DataTable dt = new DataTable();

                da.Fill(dt);

                cn.Close();

                return dt;

            }

        }

        //Propriedade que retorna uma Lista de Clientes

        public DataTable ListaDeClientes

        {

            get

            {

                MySqlConnection cn = new MySqlConnection();

                cn.ConnectionString = con.Conexao();

                cn.Open();


                MySqlDataAdapter da = new MySqlDataAdapter("select * from rentbike.cliente", cn);


                DataTable dt = new DataTable();

                da.Fill(dt);

                cn.Close();

                return dt;

            }

        }
        public void Incluir(Vendasinformation venda)

        {

            //conexao

            MySqlConnection cn = new MySqlConnection();



            try

            {


                cn.ConnectionString = con.Conexao();

                //command

                MySqlCommand cmd1 = new MySqlCommand();

                cmd1.Connection = cn;

                cmd1.CommandText = "insert into venda(id_venda,data_da_venda,data_expedicao,observacao,CLIENTE_id_Cliente,FUNCIONARIO_id_funcionarios,forma_de_pagamento,parcelas,valor_parcelas,desconto,subtotal,valor_total,valor_pago,troco)" +
                                    " values (@id_venda,@data_da_venda,@data_expedicao,@observacao,@CLIENTE_id_Cliente,@FUNCIONARIO_id_funcionario,@forma_de_pagamento,@parcelas,@valor_parcelas,@desconto,@subtotal,@valor_total,@valor_pago,@troco);";

                cn.Open();

                cmd1.Parameters.AddWithValue("@id_venda", venda.Idvendas);
                cmd1.Parameters.AddWithValue("@data_da_venda", venda.Datavenda);
                cmd1.Parameters.AddWithValue("@data_expedicao", venda.Dataexpedicao);
                cmd1.Parameters.AddWithValue("@observacao", venda.Observacao);
                cmd1.Parameters.AddWithValue("@CLIENTE_id_Cliente", venda.Idcliente);
                cmd1.Parameters.AddWithValue("@FUNCIONARIO_id_funcionario", venda.Idfuncionario);
                cmd1.Parameters.AddWithValue("@forma_de_pagamento", venda.Forma_de_Pagamento);
                cmd1.Parameters.AddWithValue("@parcelas", venda.Parcelas);
                cmd1.Parameters.AddWithValue("@valor_parcelas", venda.Valor_parcelas);
                cmd1.Parameters.AddWithValue("@desconto", venda.Desconto);
                cmd1.Parameters.AddWithValue("@subtotal", venda.Subtotal);
                cmd1.Parameters.AddWithValue("@valor_total", venda.Valortotal);
                cmd1.Parameters.AddWithValue("@valor_pago", venda.Valorpago);
                cmd1.Parameters.AddWithValue("@troco", venda.Troco);

                venda.Idvendas = Convert.ToInt32(cmd1.ExecuteScalar());

            }

            catch (Exception ex)

            {

                throw new Exception("Servidor no Servidor:" + ex.Message);

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

                    cmd.CommandText = "DELETE FROM venda.*, itens_da_venda.* USING venda INNER JOIN itens_da_venda WHERE venda.id_venda = itens_da_venda.id_vendas AND venda.id_venda =" + codigo;


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

        }

    }
}

