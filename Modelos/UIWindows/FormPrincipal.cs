using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APRESENTAÇÃO.UIWindows;
using UIWindows;
using MySql.Data.MySqlClient;
using APRESENTAÇÃO.DAL;
using APRESENTAÇÃO.Modelos;

namespace APRESENTAÇÃO.UIWindows
{
    public partial class Formprincipal : Form
    {
        public int usuario { get; set; }

        public Formprincipal(string usuariologado)
        {
            InitializeComponent();
            tssluser.Text = usuariologado;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void btnconfig_Click(object sender, EventArgs e)
        {




        }


        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Formprincipal_Load(object sender, EventArgs e)
        {

           // permissao(tssluser.Text);
        }

        private void permissao(string nome)
        {
            try
            {
                Dados_Conexao dados_Conexao = new Dados_Conexao();
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = dados_Conexao.Conexao();
                MySqlCommand com = new MySqlCommand();
                com.Connection = con;
                com.CommandText = "select nome,id_perfil,situacao from rentbike.usuarios where nome=" + "'" + nome + "';";
                con.Open();
                MySqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    usuario = dr.GetInt32("id_perfil");

                    if (usuario.Equals(4))
                    {
                        configuraçãoDeConexãoToolStripMenuItem.Visible = true;
                        
                    }
                    if (usuario.Equals(6))
                    {
                        menuconfiguracao.Visible = false;
                        menufuncionarios.Visible = false;
                        menuusuarios.Visible = false;
                        entradaNoEstoqueToolStripMenuItem.Visible = false;
                        extornoDeVendasToolStripMenuItem.Visible = false;
                        cadastrarToolStripMenuItem2.Visible = false;
                        cadastrarToolStripMenuItem.Visible = false;
                        cadastrarToolStripMenuItem1.Visible = false;
                        cadastrarToolStripMenuItem3.Visible = false;

                    }
                    if (usuario.Equals("Gerente"))
                    {
                        configuraçãoDeConexãoToolStripMenuItem.Visible = false;
                        
                    }

                }
                con.Close();
            }
            catch (MySqlException erro)
            {
                MessageBox.Show(erro.Message + "Erro");
            }
        }
        private void sairDaAplicaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void configuraçãoDeConexãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmconfig frmconfig = new frmconfig();
            frmconfig.MdiParent = this;
            frmconfig.Show();
        }

        private void extornoDeVendasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmExtornovendas obj = new FrmExtornovendas();
            obj.MdiParent = this;
            obj.Show();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frmprodutos obj = new Frmprodutos(tssluser.Text);
            obj.MdiParent = this;
            obj.Show();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formclientes obj = new Formclientes(tssluser.Text);
            obj.MdiParent = this;
            obj.Show();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Formconsultacliente obj = new Formconsultacliente(tssluser.Text);
           
                obj.MdiParent = this;
                obj.Show();
            
        }

        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Frmconsultaprodutos obj = new Frmconsultaprodutos(tssluser.Text);
            obj.MdiParent = this;
            obj.Show();
        }

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Frmfornecedores obj = new Frmfornecedores();
            obj.MdiParent = this;
            obj.Show();
        }

        private void consultarToolStripMenuItem3_Click(object sender, EventArgs e)
        {

            Formconsultafornecedor obj = new Formconsultafornecedor(tssluser.Text);
            obj.MdiParent = this;
            obj.Show();
        }

        private void cadastrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Formusuarios obj = new Formusuarios();
            obj.MdiParent = this;
            obj.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formconsultausuarios obj = new Formconsultausuarios(tssluser.Text);
            obj.MdiParent = this;
            obj.Show();
        }

        private void configuraçãoDePermissõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formconfigpermissoes obj = new Formconfigpermissoes();
            obj.MdiParent = this;
            obj.Show();
        }

        private void cadastrarPerfisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formperfil obj = new Formperfil();
            obj.MdiParent = this;
            obj.Show();
        }

        private void clientesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Frmrelatorioclientes frmrelatorioclientes = new Frmrelatorioclientes();
            frmrelatorioclientes.MdiParent = this;
            frmrelatorioclientes.Show();

        }
    }
    }

