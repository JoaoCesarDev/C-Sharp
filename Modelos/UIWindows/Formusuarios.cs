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
using APRESENTAÇÃO.Modelos;
using APRESENTAÇÃO.BLL;
using MySql.Data.MySqlClient;

namespace UIWindows
{
    public partial class Formusuarios : Form
    {
        private string data = DateTime.Now.ToShortDateString();
        public Formusuarios()
        {
            InitializeComponent();
        }
        private bool textBoxVazias()
        {
            foreach (Control c in this.Controls)
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                        return true;
                }
            return false;
           
        }
        private bool ComboBoxVazias()
        {
            foreach (Control co in this.Controls)
                if (co is ComboBox)
                {
                    ComboBox combobox = co as ComboBox;

                    if (string.IsNullOrWhiteSpace(combobox.Text))
                        return true;
                }
            return false;

        }

        private void Formusuarios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
       
        private void btncadastrar_Click_1(object sender, EventArgs e)
        {
            if (!textBoxVazias() && !ComboBoxVazias())
            {
                try

                {

                    Usuariosinformation usuario = new Usuariosinformation();

                    usuario.Nome = txtnome.Text;

                    usuario.ID_Perfil = Convert.ToInt32(cboperfil.SelectedValue);

                    usuario.Senha = txtsenha.Text;

                    usuario.Situacao = cbostatus.Text;

                    usuario.Data_cadastro = Convert.ToDateTime(data);

                    UsuarioBLL obj = new UsuarioBLL();

                    obj.Incluir(usuario);

                    MessageBox.Show("O Usuário foi cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)

                {

                    MessageBox.Show("Erro: " + ex.Message);

                }

            }
            else
            {
                MessageBox.Show("Preencha todos os Campos para Cadastrar um novo Cliente");
            }
            txtnome.Text = "";
            txtnome.Focus();
            txtsenha.Text = "";
            cboperfil.Text = "";
            cbostatus.Text = "";
        }

        private void carregarcomboperfil()
        {
            PerfisusuarioBLL perfisusuario = new PerfisusuarioBLL();
            cboperfil.DataSource = perfisusuario.Listagem();
            cboperfil.ValueMember = "id_perfil";
            cboperfil.DisplayMember = "perfil";
        }

        private void Formusuarios_Load(object sender, EventArgs e)
        {
            carregarcomboperfil();
        }
    }
}
