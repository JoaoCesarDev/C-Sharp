using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using APRESENTAÇÃO.UIWindows;

namespace APRESENTAÇÃO.UIWindows
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Frmlogin frmlogin = new Frmlogin();
            frmlogin.ShowDialog();

            Application.Run(new Formprincipal(frmlogin.Usuario));
            

        }
    }
}
