using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using APRESENTAÇÃO.Modelos;
using DAL;
using MySql.Data.MySqlClient;
using APRESENTAÇÃO.DAL;

namespace DAL
{
    public class FuncionariosDAL
    {
        Dados_Conexao con = new Dados_Conexao();
        public DataTable Listagem()

        {
            DataTable tabela = new DataTable();

            MySqlDataAdapter da = new MySqlDataAdapter("select * from rentbike.funcionario", con.Conexao());

            da.Fill(tabela);

            return tabela;
        }

    }



}

