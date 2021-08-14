using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APRESENTAÇÃO.Modelos
{
    public class Fornecedorinformation
    {
        private int _idfornecedores;
        public int Idfornecedores

        {

            get { return _idfornecedores; }

            set { _idfornecedores = value; }

        }
        private string _nome;
        public string Nome

        {

            get { return _nome; }

            set { _nome = value; }

        }
        private string _endereco;
        public string Endereco

        {

            get { return _endereco; }

            set { _endereco = value; }

        }
        private string _bairro;
        public string Bairro

        {

            get { return _bairro; }

            set { _bairro = value; }

        }
        private string _cidade;
        public string Cidade

        {

            get { return _cidade; }

            set { _cidade = value; }

        }
        private string _estado;
        public string Estado

        {

            get { return _estado; }

            set { _estado = value; }
        }
        private string _pais;
        public string Pais

        {

            get { return _pais; }

            set { _pais = value; }
        }
        private string _telefone;
        public string Telefone

        {

            get { return _telefone; }

            set { _telefone = value; }
        }
        private string _cnpj;
        public string CNPJ

        {

            get { return _cnpj; }

            set { _cnpj = value; }
        }
    }

}
