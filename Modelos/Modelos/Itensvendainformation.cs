using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APRESENTAÇÃO.Modelos
{
    public class Itensvendainformation
    {
        private int _iditensvendas;
        public int Iditensvendas

        {

            get { return _iditensvendas; }

            set { _iditensvendas = value; }

        }
        private int _idvendas;
        public int Idvendas

        {

            get { return _idvendas; }

            set { _idvendas = value; }

        }
        
        private int _id_produto;
        public int Id_produto

        {

            get { return _id_produto; }

            set { _id_produto = value; }

        }
        
        

        private int _quantidade;
        public int Quantidade

        {

            get { return _quantidade; }

            set { _quantidade = value; }

        }
        private decimal _valor;
        public decimal Valor

        {

            get { return _valor; }

            set { _valor = value; }

        }

        private decimal _total;
        public decimal Total

        {

            get { return _total; }

            set { _total = value; }

        }








    }
}
