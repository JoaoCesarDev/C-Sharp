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
using APRESENTAÇÃO.UIWindows;


namespace APRESENTAÇÃO
{
    
    public partial class frmconfig : Form
    {

        public frmconfig()
        {
            InitializeComponent();
            
        }
        public frmconfig(String valor)
        {
            InitializeComponent();
            txtusuario2.Text = valor;
        }
        

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var appSettings = (AppSettingsSection)config.GetSection("appSettings");
            appSettings.Settings["server"].Value = cboserver.Text;
            appSettings.Settings["uid"].Value = txtusuario2.Text;
            appSettings.Settings["pwd"].Value = txtsenha.Text;
            config.Save();
            ConfigurationManager.RefreshSection("appSettings");
            this.Close();
        }

        private void frmconfig_Load(object sender, EventArgs e)
        {
            
            
            cboserver.Text = ConfigurationManager.AppSettings["server"];
            txtdatabase.Text = ConfigurationManager.AppSettings["database"];
            txtusuario2.Text = ConfigurationManager.AppSettings["uid"]; 
            txtsenha.Text = ConfigurationManager.AppSettings["pwd"];
         
        }

        private void brnfechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
