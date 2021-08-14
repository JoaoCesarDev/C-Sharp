using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APRESENTAÇÃO.BLL;
using APRESENTAÇÃO.Modelos;
using MySql.Data.MySqlClient;
using APRESENTAÇÃO.DAL;


namespace APRESENTAÇÃO
{
    public partial class Formclientes : Form
    {
        private string data = DateTime.Now.ToShortDateString();
        public string usuario;
        public Formclientes(string usuariologado)
        {
            InitializeComponent();
            usuario = usuariologado;
        }


        private void Formclientes_Load(object sender, EventArgs e)
        {

            txtdata.Text = data;


        }



        private void btncadastrar_Click(object sender, EventArgs e)
        {
            if (!textBoxVazias())
            {
                try

                {

                    Clientesinformation cliente = new Clientesinformation();

                    cliente.Nome = txtnome.Text;

                    cliente.Endereco = txtendereco.Text;

                    cliente.Datacadastro = Convert.ToDateTime(txtdata.Text);

                    cliente.Endereco = txtendereco.Text;

                    cliente.Bairro = txtbairro.Text;

                    cliente.Estado = cboestado.Text;

                    cliente.Cidade = txtcidade.Text;

                    cliente.Telefone = txttelefone.Text;

                    cliente.Cep = txtcep.Text;

                    cliente.Celular = txtcelular.Text;

                    cliente.Email = txtemail.Text;

                    cliente.CPF = txtcpf.Text;

                    PermissoesDAL permissoes = new PermissoesDAL();
                    if (permissoes.Permissao(usuario))
                    {
                        ClientesBLL obj = new ClientesBLL();

                        obj.Incluir(cliente);

                        MessageBox.Show("O cliente foi incluído com sucesso!", "Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("O Usuário logado não tem permissão para executar essa função!");
                    }
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
            txtendereco.Text = "";
            txtdata.Text = data.ToString();
            txtbairro.Text = "";
            txtcidade.Text = "";
            txtcep.Text = "";
            cboestado.Text = "";
            txttelefone.Text = "";
            txtcelular.Text = "";

            txtcpf.Text = "";
            txtemail.Text = "";


        }


   


    private void Formclientes_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Escape)
        {
            this.Close();
        }
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

}
}


