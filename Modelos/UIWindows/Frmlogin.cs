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
using APRESENTAÇÃO.Modelos;


namespace APRESENTAÇÃO.UIWindows
{
    public partial class Frmlogin : Form
    {

        public string Usuario;
        
        public Frmlogin()
        {
            InitializeComponent();

        }



        private void Frmlogin_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnlogar;
            this.CancelButton = btncancelar;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlogar_Click(object sender, EventArgs e)
        {
            Validação_login validação_Login = new Validação_login();
            validação_Login.Login(txtusuario1.Text, txtsenha.Text);

            if (validação_Login.login == true)
            {
                Usuario = txtusuario1.Text;
                this.Close();
                
            }


            if (validação_Login.login == false)
            {
                MessageBox.Show("Usuário ou Senha Incorretos!");
                txtusuario1.Text = "";
                txtsenha.Text = "";
                txtusuario1.Focus();
            }



        }

    }
}
