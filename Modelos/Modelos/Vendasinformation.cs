using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APRESENTAÇÃO.Modelos
{
    public class Vendasinformation
    {
        private int _idvendas;
        public int Idvendas

        {

            get { return _idvendas; }

            set { _idvendas = value; }

        }
        private DateTime _datavenda;
        public DateTime Datavenda

        {

            get { return _datavenda; }

            set { _datavenda = value; }

        }
      
        private DateTime _dateexpedicao;
        public DateTime Dataexpedicao

        {

            get { return _dateexpedicao; }

            set { _dateexpedicao = value; }

        }
        private string _observacao;
        public string Observacao

        {

            get { return _observacao; }

            set { _observacao = value; }

        }
        private int _idcliente;
        public int Idcliente

        {

            get { return _idcliente; }

            set { _idcliente = value; }

        }
       
        private int _idfuncionario;
        public int Idfuncionario

        {

            get { return _idfuncionario; }

            set { _idfuncionario = value; }

        }

        private string _forma_de_pagamento;
        public string Forma_de_Pagamento

        {

            get { return _forma_de_pagamento; }

            set { _forma_de_pagamento = value; }

        }

        private int _parcelas;
        public int Parcelas

        {

            get { return _parcelas; }

            set { _parcelas = value; }

        }

        private decimal _valor_parcelas;
        public decimal Valor_parcelas

        {

            get { return _valor_parcelas; }

            set { _valor_parcelas = value; }

        }

        private decimal _desconto;
        public decimal Desconto

        {

            get { return _desconto; }

            set { _desconto = value; }

        }
        private decimal _subtotal;
        public decimal Subtotal

        {

            get { return _subtotal; }

            set { _subtotal = value; }

        }

        private decimal _valortototal;
        public decimal Valortotal

        {

            get { return _valortototal; }

            set { _valortototal = value; }

        }

        private decimal _valorpago;
        public decimal Valorpago

        {

            get { return _valorpago; }

            set { _valorpago = value; }

        }

        private decimal _troco;
        public decimal Troco

        {

            get { return _troco; }

            set { _troco = value; }

        }


    }
}
