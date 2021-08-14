using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APRESENTAÇÃO.DAL;
using System.Data;
using APRESENTAÇÃO.Modelos;

namespace APRESENTAÇÃO.BLL
{
    public class PerfisusuarioBLL
    {
        public DataTable Listagem()

        {

            PerfisusuariosDAL obj = new PerfisusuariosDAL();

            return obj.Listagem();

        }
        public void Incluir(Perfisusuarioinformation Perfil)

        {

            //Se tudo está Ok, chama a rotina de inserção.

            PerfisusuariosDAL obj = new PerfisusuariosDAL();

            obj.Incluir(Perfil);

        }

        public void Alterar(Perfisusuarioinformation Perfil)

        {

            //Se tudo está Ok, chama a rotina de inserção.

            PerfisusuariosDAL obj = new PerfisusuariosDAL();

            obj.Alterar(Perfil);

        }

        public void Excluir(int codigo)

        {

            //Se tudo está Ok, chama a rotina de inserção.

            PerfisusuariosDAL obj = new PerfisusuariosDAL();

            obj.Excluir(codigo);

        }


    }
}
