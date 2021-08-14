using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace APRESENTAÇÃO
{
    public class Config_app
    {
        public static void Atualizarappsettings(string valor,string chave)
        {
           
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("AppSettings");
        }
        
        
    }
}
