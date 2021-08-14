using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APRESENTAÇÃO.Modelos
{
    public class Permissoesinformation
    {
        public int id_permissoes {get; set;}
        public string Entidade { get; set; }
        public bool cadastrar { get; set; }
        public bool alterar { get; set; }
        public bool excluir { get; set; }
        public int id_perfil { get; set; }
    }
}
