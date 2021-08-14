using APRESENTAÇÃO.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APRESENTAÇÃO.DAL;
using System.Data;

namespace APRESENTAÇÃO.BLL
{
    public class UsuarioBLL
    {
        public void Incluir(Usuariosinformation usuario)

        {

            //Se tudo está Ok, chama a rotina de inserção.

            UsuariosDAL obj = new UsuariosDAL();

            obj.Incluir(usuario);

        }

        public void Alterar(Usuariosinformation ususarios)

        {

            UsuariosDAL obj = new UsuariosDAL();

            obj.Alterar(ususarios);

        }

        public DataTable Listagem()

        {

            UsuariosDAL obj = new UsuariosDAL();

            return obj.Listagem();

        }

        public void Excluir(int codigo)

        {

            UsuariosDAL obj = new UsuariosDAL();

            obj.Excluir(codigo);

        }

        public DataTable filtragem(string nome)

        {

            UsuariosDAL obj = new UsuariosDAL();

            return obj.filtragem(nome);

        }
    }
}
