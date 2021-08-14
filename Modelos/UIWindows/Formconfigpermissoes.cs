using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APRESENTAÇÃO.DAL;
using APRESENTAÇÃO.UIWindows;
using MySql.Data.MySqlClient;
using APRESENTAÇÃO.BLL;
using APRESENTAÇÃO.Modelos;

namespace UIWindows
{
    public partial class Formconfigpermissoes : Form
    {
        public Formconfigpermissoes()
        {
            InitializeComponent();
        }

       

        private void Formconfigpermissoes_Load(object sender, EventArgs e)
        {
           
                PerfisusuariosDAL perfil = new PerfisusuariosDAL();
                cboperfil.DataSource = perfil.Listagem();
                cboperfil.ValueMember = "id_perfil";
                cboperfil.DisplayMember = "perfil";
            
           
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
        try
        {
            Perfisusuarioinformation perfil = new Perfisusuarioinformation();
             
            perfil.IDperfil = Convert.ToInt32(cboperfil.SelectedValue);
            perfil.Cadastrar = Convert.ToBoolean(chkcadastrar.Checked);
            perfil.Alterar = Convert.ToBoolean(chkalterar.Checked);
            perfil.Excluir = Convert.ToBoolean(chkExcluir.Checked);

            PerfisusuarioBLL perfisusuarioBLL = new PerfisusuarioBLL();
            perfisusuarioBLL.Alterar(perfil);
            MessageBox.Show("Permissões Modificadas com Sucesso!", "Modificação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void carregar_checkbox(string perfil)
        {
            Dados_Conexao con = new Dados_Conexao();

            MySqlConnection cn = new MySqlConnection();

            cn.ConnectionString = con.Conexao();

            MySqlCommand com = new MySqlCommand("Select cadastrar, alterar, excluir from rentbike.perfis_do_usuario where perfil ='" + perfil + "';");

            com.Connection = cn;
            cn.Open();

            MySqlDataReader DR;

            DR = com.ExecuteReader();
            
            while (DR.Read())
            {
                chkcadastrar.Checked = Convert.ToBoolean(DR.GetValue(0));
                chkalterar.Checked = Convert.ToBoolean(DR.GetValue(1));
                chkExcluir.Checked = Convert.ToBoolean(DR.GetValue(2));
            }

            
            DR.Close();
            cn.Close();

        }

        private void cboperfil_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregar_checkbox(cboperfil.Text);
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(cboperfil.SelectedValue);

            PerfisusuarioBLL perfil = new PerfisusuarioBLL();
            perfil.Excluir(codigo);

            MessageBox.Show("O Perfil foi Excluído com Sucesso!");
            cboperfil.Text = String.Empty;
            chkcadastrar.Checked = false;
            chkalterar.Checked = false;
            chkExcluir.Checked = false;

        }
    }
}
