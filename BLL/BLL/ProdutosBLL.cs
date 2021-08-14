using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using APRESENTAÇÃO.Modelos;
using APRESENTAÇÃO.DAL;

namespace APRESENTAÇÃO.BLL
{
    
    public class ProdutosBLL
   
    {
       

        public ArrayList ProdutosBaixoEstoque()
        {

            {



                ProdutosDAL obj = new ProdutosDAL();

                return obj.ProdutosBaixoEstoque();


            }
        }

        public void Incluir(Produtosinformation produto)

        {

            // Nome do produto é obrigatório

            if (produto.Nome.Trim().Length == 0)

            {

                throw new Exception("O nome do produto é obrigatório.");

            }


            // O preço do produto não pode ser negativo

            if (produto.Precocusto < 0)

            {

                throw new Exception("Preço do produto não pode ser negativo.");

            }


            // O estoque do produto não pode ser negativo

            if (produto.Estoque < 0)

            {

                throw new Exception("Estoque do produto não pode ser negativo.");

            }


            //Se tudo estiver ok, chama a rotina de gravação

            ProdutosDAL obj = new ProdutosDAL();

            obj.Incluir(produto);


        }


        public void Alterar(Produtosinformation produto)

        {

            ProdutosDAL obj = new ProdutosDAL();

            obj.Alterar(produto);

        }


        public void Excluir(int codigo)

        {

            ProdutosDAL obj = new ProdutosDAL();

            obj.Excluir(codigo);

        }


        public DataTable Listagem()

        {

            ProdutosDAL obj = new ProdutosDAL();

            return obj.Listagem();

        }

        public DataTable Filtragem_Produtos(int codigo)

        {

            ProdutosDAL obj = new ProdutosDAL();

            return obj.Filtragem_Produtos(codigo);

        }

        public DataTable Filtragem_Produtos_codigo(int codigo)

        {

            ProdutosDAL obj = new ProdutosDAL();

            return obj.Filtragem_Produtos_codigo(codigo);

        }

        public DataTable Filtragem_Produtos_nome(string nome)

        {

            ProdutosDAL obj = new ProdutosDAL();

            return obj.Filtragem_Produtos_nome(nome);

        }

    }
}