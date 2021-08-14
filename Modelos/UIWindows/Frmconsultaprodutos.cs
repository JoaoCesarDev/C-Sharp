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
using Microsoft.ReportingServices.RdlExpressions.ExpressionHostObjectModel;

namespace UIWindows
{
    public partial class Frmconsultaprodutos : Form
    {
        public int usuarioperfil;
        public string usuario;
        public List<Produtos> _Itensprodutos = new List<Produtos>();
        public Frmconsultaprodutos(string usuariologado)
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
                com.CommandText = "select nome,id_perfil,situacao from rentbike.usuarios where nome=" + "'" + nome + "';";
                con.Open();
                MySqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    usuarioperfil = dr.GetInt32("id_perfil");

                    if (usuarioperfil.Equals(6))
                    {

                        groupBox2.Visible = false;
                        dgvconsultaprodutos.Enabled = false;
                    }

                }
                con.Close();
            }
            catch (MySqlException erro)
            {
                MessageBox.Show(erro.Message + "Erro");
            }
        }

        private void Frmconsultaprodutos_Load(object sender, EventArgs e)
        {
            carregar_grid();
            permissao(usuario);
           
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            if (txtconsultaproduto.Text != "")
            {

                ProdutosBLL produtos = new ProdutosBLL();
                dgvconsultaprodutos.DataSource = produtos.Filtragem_Produtos_nome(txtconsultaproduto.Text);
            }
            btndesfazer.Visible = true;
            btnconsultar.Visible = false;
        }

        private void carregar_grid()
        {
            try
            {
                ProdutosBLL obj = new ProdutosBLL();

                dgvconsultaprodutos.DataSource = obj.Listagem();
            }
            catch (MySqlException Ex)
            {
                MessageBox.Show("Erro na Conexão" + " " + Ex.Message);
            }
            dgvconsultaprodutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvconsultaprodutos.Columns[0].ReadOnly = true;
            dgvconsultaprodutos.Columns[10].ReadOnly = true;
            dgvconsultaprodutos.Columns[8].DefaultCellStyle.Format = "C";
            dgvconsultaprodutos.Columns[9].DefaultCellStyle.Format = "C";
            dgvconsultaprodutos.Columns[11].ReadOnly = true;
        
            
            
        }

        private void btndesfazer_Click(object sender, EventArgs e)
        {
            carregar_grid();
            btndesfazer.Visible = false;
            btnconsultar.Visible = true;
            txtconsultaproduto.Text = String.Empty;
            txtconsultaproduto.Focus();
        }

        private void Frmconsultaprodutos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void dgvconsultaprodutos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int idproduto = Convert.ToInt32(dgvconsultaprodutos["id_produtos", e.RowIndex].Value);
            string produto = Convert.ToString(dgvconsultaprodutos["nome", e.RowIndex].Value);
            int Estoque_disponível = Convert.ToInt32(dgvconsultaprodutos["estoque", e.RowIndex].Value);
            int QTD = 1;
            decimal preco_unitario = Convert.ToDecimal(dgvconsultaprodutos["preco_venda", e.RowIndex].Value);
           
                Produtos prod = new Produtos() { Codigo = idproduto, nome = produto, Estoque_disponível = Estoque_disponível, quantidade = QTD, preco_unitario = preco_unitario };


            if (!adicionarlista(prod))
            {
                MessageBox.Show("Item já adicionado na lista!");

            }
            else if (dgvconsultaprodutos["estoque", e.RowIndex].Value.Equals(0))
            {
                MessageBox.Show("Sem Estoque do Produto!");
                return;
            }
            else
              {
               _Itensprodutos.Add(prod);

              }
            Frmvendas fmvendas = new Frmvendas(_Itensprodutos);
           
            fmvendas.Show();
        }
        public bool adicionarlista(Produtos produtos)
        {
            bool existe = _Itensprodutos.Any(x => x.nome.Equals(produtos.nome));
            if (!existe)
            {

                return true;

            }
            return false;

        }

        private void dgvconsultaprodutos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.Value.Equals(0))

            {
                dgvconsultaprodutos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                
            }
        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            try
            {
                Produtosinformation produtos = new Produtosinformation();

                produtos.Idproduto = Convert.ToInt32(dgvconsultaprodutos.CurrentRow.Cells[0].Value);

                produtos.Nome = Convert.ToString(dgvconsultaprodutos.CurrentRow.Cells[1].Value);

                produtos.Descricao = Convert.ToString(dgvconsultaprodutos.CurrentRow.Cells[2].Value);

                produtos.Tipo = Convert.ToString(dgvconsultaprodutos.CurrentRow.Cells[3].Value);

                produtos.Categoria = Convert.ToString(dgvconsultaprodutos.CurrentRow.Cells[4].Value);

                produtos.Fabricante = Convert.ToString(dgvconsultaprodutos.CurrentRow.Cells[5].Value);

                produtos.Codigo = Convert.ToString(dgvconsultaprodutos.CurrentRow.Cells[6].Value);

                produtos.Estoque = Convert.ToInt32(dgvconsultaprodutos.CurrentRow.Cells[7].Value);

                produtos.Precocusto = Convert.ToDecimal(dgvconsultaprodutos.CurrentRow.Cells[8].Value);

                produtos.Precovenda = Convert.ToDecimal(dgvconsultaprodutos.CurrentRow.Cells[9].Value);

                produtos.Idfornec = Convert.ToInt32(dgvconsultaprodutos.CurrentRow.Cells[10].Value);

                PermissoesDAL permissoes = new PermissoesDAL();
                if (permissoes.Permissao(usuario))
                {

                    ProdutosBLL obj = new ProdutosBLL();
                obj.Alterar(produtos);
                MessageBox.Show("O Produto foi alterado com sucesso", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("O Usuário logado não tem permissão para executar essa função!");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error:    " + ex.Message);
            }
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Tem Certeza da Exclusão do Produto?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogresult == DialogResult.Yes)
            {
                int codigo = Convert.ToInt32(dgvconsultaprodutos.CurrentRow.Cells[0].Value);

                ProdutosBLL obj = new ProdutosBLL();

                obj.Excluir(codigo);

                MessageBox.Show("O Cliente foi excluído com Sucesso!");
            }
            carregar_grid();

        }

    }
}
