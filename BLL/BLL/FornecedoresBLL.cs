using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using APRESENTAÇÃO.Modelos;
using APRESENTAÇÃO.DAL;

namespace APRESENTAÇÃO.BLL
{
    public class FornecedoresBLL
    {
        public void Incluir(Fornecedorinformation fornecedor)

        {

            //O nome do fornecedor é obrigatório

            if (fornecedor.Nome.Trim().Length == 0)

            {

                throw new Exception("O nome do Fornecedor é obrigatório");

            }


           //Se tudo está Ok, chama a rotina de inserção.

            FornecedoresDAL obj = new FornecedoresDAL();

            obj.Incluir(fornecedor);

        }

        public void Alterar(Fornecedorinformation fornecedor)

        {

            FornecedoresDAL obj = new FornecedoresDAL();

            obj.Alterar(fornecedor);

        }


        public void Excluir(int codigo)

        {

            if (codigo < 1)

            {

                throw new Exception("Selecione um Fornecedor antes de excluí-lo.");

            }

            FornecedoresDAL obj = new FornecedoresDAL();

            obj.Excluir(codigo);

        }


        public DataTable Listagem()

        {

            FornecedoresDAL obj = new FornecedoresDAL();

            return obj.Listagem();

        }

        public DataTable Filtragem(string nome)

        {

            FornecedoresDAL obj = new FornecedoresDAL();

            return obj.Filtragem(nome);

        }

    }
}

