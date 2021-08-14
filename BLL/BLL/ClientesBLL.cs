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
    public class ClientesBLL
    {
        public void Incluir(Clientesinformation cliente)

        {

            //O nome do cliente é obrigatório

            if (cliente.Nome.Trim().Length == 0)

            {

                throw new Exception("O nome do cliente é obrigatório");

            }


            //E-mail é sempre em letras minúsculas

            cliente.Email = cliente.Email.ToLower();



            //Se tudo está Ok, chama a rotina de inserção.

            ClientesDAL obj = new ClientesDAL();

            obj.Incluir(cliente);

        }


        public void Alterar(Clientesinformation cliente)

        {
            PermissoesDAL permissoes = new PermissoesDAL();
            
                ClientesDAL obj = new ClientesDAL();

            obj.Alterar(cliente);

        }


        public void Excluir(int codigo)

        {

            if (codigo < 1)

            {

                throw new Exception("Selecione um cliente antes de excluí-lo.");

            }

            ClientesDAL obj = new ClientesDAL();

            obj.Excluir(codigo);

        }


        public DataTable Listagem()

        {

            ClientesDAL obj = new ClientesDAL();

            return obj.Listagem();

        }

        public DataTable Filtragem(string letras)

        {

            ClientesDAL obj = new ClientesDAL();

            return obj.Filtragem(letras);

        }

    }

}
