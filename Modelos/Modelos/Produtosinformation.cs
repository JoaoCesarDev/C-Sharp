using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace APRESENTAÇÃO.Modelos
{
    public class Produtosinformation
    {
        
        private int _idproduto;

        public int Idproduto

        {

            get { return _idproduto; }

            set { _idproduto = value; }

        }


        private string _nome;
        public string Nome

        {

            get { return _nome; }

            set { _nome = value; }

        }


        private string _descricao;

        public string Descricao

        {

            get { return _descricao; }

            set { _descricao = value; }

        }


        private string _tipo;

        public string Tipo

        {

            get { return _tipo; }

            set { _tipo = value; }

        }
        private string _categoria;

        public string Categoria

        {

            get { return _categoria; }

            set { _categoria = value; }

        }
        private string _fabricante;

        public string Fabricante

        {

            get { return _fabricante; }

            set { _fabricante = value; }

        }
        private string _codigo;

        public string Codigo

        {

            get { return _codigo; }

            set { _codigo = value; }

        }
        private int _estoque;

        public int Estoque

        {

            get { return _estoque; }

            set { _estoque = value; }

        }
        private decimal _precocusto;

        public decimal Precocusto

        {

            get { return _precocusto; }

            set { _precocusto = value; }

        }
        private decimal _precovenda;

        public decimal Precovenda

        {

            get { return _precovenda; }

            set { _precovenda = value; }

        }
        private int _idfornec;

        public int Idfornec

        {

            get { return _idfornec; }

            set { _idfornec = value; }

        }
    }
}
