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
using APRESENTAÇÃO.BLL;
using APRESENTAÇÃO.Modelos;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Globalization;

namespace UIWindows
{
    public partial class Frmprodutos : Form
    {

        public string usuario;

        public Frmprodutos(string usuariologado)
        {
            InitializeComponent();
            usuario = usuariologado;
        }
        
 
        private void Frmprodutos_Load(object sender, EventArgs e)
        {
            
            carregar_combo_fornecedores();

        }
        private void carregar_combo_fornecedores()
        {
            try
            {
                Dados_Conexao conexao = new Dados_Conexao();
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = conexao.Conexao();
                MySqlCommand com = new MySqlCommand();
                com.Connection = con;
                com.CommandText = "SELECT id_fornecedores,nome FROM rentbike.fornecedor;";
                con.Open();
                MySqlDataReader dr = com.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                cbofornecedor.DataSource = dt;
                cbofornecedor.ValueMember = "id_fornecedores";
                cbofornecedor.DisplayMember = "nome";
                cbofornecedor.Update();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
      
        private void btnfechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            if (!textBoxVazias())
            {
                try
                {
                    Produtosinformation produtosinformation = new Produtosinformation();
                    produtosinformation.Nome = txtnome.Text;
                    produtosinformation.Descricao = txtdescricao.Text;
                    produtosinformation.Tipo = txttipo.Text;
                    produtosinformation.Categoria = txtcategoria.Text;
                    produtosinformation.Fabricante = txtfabricante.Text;
                    produtosinformation.Codigo = txtcodigo.Text;
                    produtosinformation.Estoque = Convert.ToInt32(txtestoque.Text);
                    produtosinformation.Precocusto = Convert.ToDecimal(txtprecocusto.Text);
                    produtosinformation.Precovenda = Convert.ToDecimal(mktprecovenda.Text);
                    produtosinformation.Idfornec = Convert.ToInt32(cbofornecedor.SelectedValue);

                    PermissoesDAL permissoes = new PermissoesDAL();
                    if (permissoes.Permissao(usuario))
                    {

                        ProdutosBLL produtosBLL = new ProdutosBLL();
                    produtosBLL.Incluir(produtosinformation);
                    MessageBox.Show("O produto cadastrado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("O Usuário logado não tem permissão para executar essa função!");
                    }
                    btncadastrar.Enabled = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro:  " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os Campos para Cadastrar um novo Cliente");
                txtnome.Focus();
            }
            
        }

        
       

        private void txtprecocusto_Click(object sender, EventArgs e)
        {
            txtprecocusto.SelectAll();
        }

        private void mktprecovenda_Click(object sender, EventArgs e)
        {
            mktprecovenda.SelectAll();
        }

        private void Frmprodutos_KeyDown(object sender, KeyEventArgs e)
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
 
    

