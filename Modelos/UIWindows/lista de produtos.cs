using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIWindows
{
    public class Produtos
    {
        
        public int Codigo { get; set; }
        public string nome { get; set; }
        public int Estoque_disponível { get; set; }
        public int quantidade { get; set; }
        public decimal preco_unitario { get; set; }
        public decimal valor_Total { get; set; }

    }
}
