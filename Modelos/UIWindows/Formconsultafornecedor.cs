using APRESENTAÇÃO.BLL;
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
using MySql.Data.MySqlClient;
using APRESENTAÇÃO.Modelos;

namespace UIWindows
{
    public partial class Formconsultafornecedor : Form
    {

        public string usuarioperfil;
        public string usuario;
        public Formconsultafornecedor(string usuariologado)
        {
            InitializeComponent();
            usuario = usuariologado;
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
                com.CommandText = "select nome,perfil,situacao from rentbike.usuarios where nome=" + "'" + nome + "';";
                con.Open();
                MySqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    usuarioperfil = dr.GetString("perfil");

                    if (usuarioperfil.Equals("Comum"))
                    {

                        groupBox2.Visible = false;

                    }

                }
                con.Close();
            }
            catch (MySqlException erro)
            {
                MessageBox.Show(erro.Message + "Erro");
            }
        }

        private void Carregar_grid()
        {
            try
            {
                FornecedoresBLL obj = new FornecedoresBLL();

                dgvfornecedores.DataSource = obj.Listagem();
            }
            catch (MySqlException Ex)
            {
                MessageBox.Show("Erro na Conexão" + " " + Ex.Message);
            }
            dgvfornecedores.Columns[0].ReadOnly = true;


        }

        private void Formconsultafornecedor_Load(object sender, EventArgs e)
        {
            Carregar_grid();
            permissao(usuario);
        }

        private void btndesfazer_Click(object sender, EventArgs e)
        {
            Carregar_grid();
            btnconsultar.Visible = true;
            btndesfazer.Visible = false;
            txtcamponome.Text = String.Empty;
            txtcamponome.Focus();
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            FornecedoresBLL clientes = new FornecedoresBLL();
            dgvfornecedores.DataSource = clientes.Filtragem(txtcamponome.Text);
            btnconsultar.Visible = false;
            btndesfazer.Visible = true;
        }

        private void Formconsultafornecedor_KeyDown(object sender, KeyEventArgs e)
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
                Fornecedorinformation fornecedor = new Fornecedorinformation();

                fornecedor.Idfornecedores = Convert.ToInt32(dgvfornecedores.CurrentRow.Cells[0].Value);

                fornecedor.Nome = Convert.ToString(dgvfornecedores.CurrentRow.Cells[1].Value);

                fornecedor.Endereco = Convert.ToString(dgvfornecedores.CurrentRow.Cells[2].Value);

                fornecedor.Bairro = Convert.ToString(dgvfornecedores.CurrentRow.Cells[3].Value);

                fornecedor.Cidade = Convert.ToString(dgvfornecedores.CurrentRow.Cells[4].Value);

                fornecedor.Estado = Convert.ToString(dgvfornecedores.CurrentRow.Cells[5].Value);

                fornecedor.Pais = Convert.ToString(dgvfornecedores.CurrentRow.Cells[6].Value);

                fornecedor.Telefone = Convert.ToString(dgvfornecedores.CurrentRow.Cells[7].Value);

                fornecedor.CNPJ = Convert.ToString(dgvfornecedores.CurrentRow.Cells[8].Value);


                FornecedoresBLL obj = new FornecedoresBLL();
                obj.Alterar(fornecedor);
                MessageBox.Show("O fornecedor foi alterado com sucesso", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                int codigo = Convert.ToInt32(dgvfornecedores.CurrentRow.Cells[0].Value);

                FornecedoresBLL obj = new FornecedoresBLL();

                obj.Excluir(codigo);

                MessageBox.Show("O Fornecedor foi excluído com Sucesso!");
            }
            Carregar_grid();

        }
    }

    

}
