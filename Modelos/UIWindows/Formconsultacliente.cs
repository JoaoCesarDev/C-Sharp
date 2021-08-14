using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APRESENTAÇÃO.Modelos;
using APRESENTAÇÃO.BLL;
using MySql.Data.MySqlClient;
using APRESENTAÇÃO.DAL;

namespace UIWindows
{
    public partial class Formconsultacliente : Form
    {
        public string usuarioperfil;
        public string usuario;
        public Formconsultacliente(string usuariologado)
        {
            InitializeComponent();
             usuario = usuariologado;
        }

        private void Formconsultacliente_Load(object sender, EventArgs e)
        {
            Carregar_grid();
           
        }

        

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            ClientesBLL clientes = new ClientesBLL();
            dgvconsultacliente.DataSource = clientes.Filtragem(txtcamponome.Text);
            btnconsultar.Visible = false;
            btndesfazer.Visible = true;
        }

        private void Carregar_grid()
        {
            try
            {
                ClientesBLL obj = new ClientesBLL();

                dgvconsultacliente.DataSource = obj.Listagem();
            }
            catch (MySqlException Ex)
            {
                MessageBox.Show("Erro na Conexão" + " " + Ex.Message);
            }
            dgvconsultacliente.Columns[0].ReadOnly = true;

            dgvconsultacliente.Columns[1].ReadOnly = true;
        }

        private void btndesfazer_Click(object sender, EventArgs e)
        {
            Carregar_grid();
            btnconsultar.Visible = true;
            btndesfazer.Visible = false;
            txtcamponome.Text = String.Empty;
            txtcamponome.Focus();
        }

        private void Formconsultacliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            
            try
            {
                Clientesinformation cliente = new Clientesinformation();

                cliente.ClienteID = Convert.ToInt32(dgvconsultacliente.CurrentRow.Cells[0].Value);

                cliente.Nome = Convert.ToString(dgvconsultacliente.CurrentRow.Cells[2].Value);

                cliente.Endereco = Convert.ToString(dgvconsultacliente.CurrentRow.Cells[3].Value);

                cliente.Bairro = Convert.ToString(dgvconsultacliente.CurrentRow.Cells[4].Value);

                cliente.Cidade = Convert.ToString(dgvconsultacliente.CurrentRow.Cells[5].Value);

                cliente.Estado = Convert.ToString(dgvconsultacliente.CurrentRow.Cells[6].Value);

                cliente.Telefone = Convert.ToString(dgvconsultacliente.CurrentRow.Cells[7].Value);

                cliente.Cep = Convert.ToString(dgvconsultacliente.CurrentRow.Cells[8].Value);

                cliente.Celular = Convert.ToString(dgvconsultacliente.CurrentRow.Cells[9].Value);

                cliente.Email = Convert.ToString(dgvconsultacliente.CurrentRow.Cells[10].Value);

                cliente.CPF = Convert.ToString(dgvconsultacliente.CurrentRow.Cells[11].Value);

                PermissoesDAL permissoes = new PermissoesDAL();
                if (permissoes.Permissao(usuario))
                {

                    ClientesBLL obj = new ClientesBLL();
                    obj.Alterar(cliente);
                    MessageBox.Show("O cliente foi alterado com sucesso", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("O Usuário logado não tem permissão para executar essa função!");
                }
                Carregar_grid();



            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error:    " + ex.Message);
            }


        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Tem Certeza da Exclusão do Cliente?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogresult == DialogResult.Yes)
            {
                int codigo = Convert.ToInt32(dgvconsultacliente.CurrentRow.Cells[0].Value);
                PermissoesDAL permissoes = new PermissoesDAL();
                if (permissoes.Permissao(usuario))
                {
                    ClientesBLL obj = new ClientesBLL();

                obj.Excluir(codigo);

                MessageBox.Show("O Cliente foi excluído com Sucesso!");
                }
                else
                {
                    MessageBox.Show("O Usuário logado não tem permissão para executar essa função!");
                }
            }
            Carregar_grid();
            
        }
        public Control btnalterar1
        {
            get { return btnalterar; }
        }
    }
    }


