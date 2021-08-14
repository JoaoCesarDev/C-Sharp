using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Loja_Bike_Master.DAL;
namespace APRESENTAÇÃO
{
    
    public partial class frmconfig : Form
    {
        Dados_Conexao con = new Dados_Conexao();

        public frmconfig()
        {
            InitializeComponent();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            Config_app.Atualizarappsettings(lblservidor.Text, cboserver.Text);
        }

        private void frmconfig_Load(object sender, EventArgs e)
        {
            cboserver.Text = ConfigurationManager.AppSettings["server"]; 
            txtdatabase.Text = ConfigurationManager.AppSettings["database"];
            txtusuario.Text = ConfigurationManager.AppSettings["uid"];
            txtsenha.Text = ConfigurationManager.AppSettings["pwd"];
         
        }

        private void brnfechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
