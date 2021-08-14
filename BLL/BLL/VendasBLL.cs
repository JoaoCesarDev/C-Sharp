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
    public class VendasBLL

    {


        //Este é um campo privado para armazenar uma instância da classe DAL.

        private VendasDAL objDAL;


        //Esse é o construtor da classe VendasBLL

        public VendasBLL()

        {

            objDAL = new VendasDAL();

        }


        public DataTable ListaDeProdutos

        {

            get

            {

                return objDAL.ListaDeProdutos;

            }

        }


        public DataTable ListaDeClientes

        {

            get

            {

                return objDAL.ListaDeClientes;

            }

        }

        public DataTable ListaDeFuncionarios

        {

            get

            {

                return objDAL.ListaDeFuncionarios;

            }

        }

        public DataTable Listagem

        {

            get

            {

                return objDAL.Listagem;

            }

        }


        public void Incluir(Vendasinformation venda)

        {

            objDAL.Incluir(venda);

        }

        public void Excluir(int codigo)

        {

            VendasDAL obj = new VendasDAL();

            obj.Excluir(codigo);

        }

        public DataTable Filtragem_por_cliente(string nome)

        {

            VendasDAL obj = new VendasDAL();

            return obj.Filtragem_por_cliente(nome);

        }

        public DataTable Filtragem_por_data(string data)

        {

            VendasDAL obj = new VendasDAL();

            return obj.Filtragem_por_data(data);

        }

    }

}
