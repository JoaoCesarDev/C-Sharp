using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APRESENTAÇÃO.Modelos
{
    public class Usuariosinformation
    {
        private int _IDlogin;
        public int IDlogin
        {
            get
            {
                return _IDlogin;
            }
            set
            {
                _IDlogin = value;
            }
        }
        private string _nome;
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }
        private int _id_perfil;
        public int ID_Perfil
        {
            get
            {
                return _id_perfil;
            }
            set
            {
                _id_perfil = value;
            }
        }
        private string _senha;
        public string Senha
        {
            get
            {
                return _senha;
            }
            set
            {
                _senha = value;
            }
        }
                
        private string _situacao;
        public string Situacao
        {
            get
            {
                return _situacao;
            }
            set
            {
                _situacao = value;
            }
        }
        private DateTime _data_cadastro;
        public DateTime Data_cadastro
        {
            get
            {
                return _data_cadastro;
            }
            set
            {
                _data_cadastro = value;
            }
        }
    }
}
