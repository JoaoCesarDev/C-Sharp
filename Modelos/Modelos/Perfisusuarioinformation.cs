using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APRESENTAÇÃO.Modelos
{
    public class Perfisusuarioinformation
    {
        private int _IDperfil;
        public int IDperfil
        {
            get
            {
                return _IDperfil;
            }
            set
            {
                _IDperfil = value;
            }
        }

        private string _perfil;
        public string Perfil
        {
            get
            {
                return _perfil;
            }
            set
            {
                _perfil = value;
            }
        }

        private bool _cadastrar;
        public bool Cadastrar
        {
            get
            {
                return _cadastrar;
            }
            set
            {
                _cadastrar = value;
            }
        }

        private bool _alterar;
        public bool Alterar
        {
            get
            {
                return _alterar;
            }
            set
            {
                _alterar = value;
            }
        }

        private bool _excluir;
        public bool Excluir
        {
            get
            {
                return _excluir;
            }
            set
            {
                _excluir = value;
            }
        }

        
    }
}
