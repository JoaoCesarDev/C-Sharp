using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APRESENTAÇÃO.Modelos;
using APRESENTAÇÃO.DAL;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace APRESENTAÇÃO.BLL
{
   
    public class ItensvendasBLL

    {
         private ItensvendasDAL objDAL;
    public ItensvendasBLL()
        {

            objDAL = new ItensvendasDAL();


        }

        public DataTable Listagem(int codigo)

        {

            ItensvendasDAL obj = new ItensvendasDAL();

            return obj.Listagem(codigo);

        }

    }
}
