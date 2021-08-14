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
using MySql.Data.MySqlClient;
using APRESENTAÇÃO.DAL;
using APRESENTAÇÃO.Modelos;

namespace UIWindows
{
    public partial class Formconsultausuarios : Form
    {
        public int usuarioperfil;
        public string usuario;
        public Formconsultausuarios(string usuariologado)
        {
            InitializeComponent();
            usuario = usuariologado;
        }

        private void Carregar_grid()
        {
            try
            {
                UsuarioBLL obj = new UsuarioBLL();
                
                dgvusuarios.AutoSize = true;
                dgvusuarios.DataSource = obj.Listagem();
                dgvusuarios.Columns[0].HeaderText = "Id Usuário";
                DataGridViewColumn column = dgvusuarios.Columns[0];
                column.Width = 145;
                dgvusuarios.Columns[1].HeaderText = "Nome";
                dgvusuarios.Columns[3].HeaderText = "Senha";
                

                //dgvusuarios.Columns[4].HeaderText = "Data do Cadastro";
                //dgvusuarios.Columns[4].Width = 135;
                
                dgvusuarios.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
                                
                dgvusuarios.AllowUserToAddRows = false;
                dgvusuarios.Columns["perfil"].Visible = false;
                dgvusuarios.Columns.Remove("situacao");
                AddComboBoxColumns();
                AddComboBoxColumns1();
               
            }
            catch (MySqlException Ex)
            {
                MessageBox.Show("Erro na Conexão" + " " + Ex.Message);
            }
            dgvusuarios.Columns[0].ReadOnly = true;
            dgvusuarios.Columns[6].ReadOnly = true;
            
        }
        enum ColumnName
        
        {
            Id_Login,
            Nome,
            Perfil,
            Senha,
            Situacao,
            Data_do_Cadastro
        };
        private void AddComboBoxColumns()
        {
            PerfisusuarioBLL usuario = new PerfisusuarioBLL();
            DataGridViewComboBoxColumn comboboxColumn = new DataGridViewComboBoxColumn();
            comboboxColumn.DataPropertyName = ColumnName.Perfil.ToString();
            comboboxColumn.DataSource = usuario.Listagem();
            comboboxColumn.ValueMember = "id_perfil";
            comboboxColumn.DisplayMember = "Perfil";
            comboboxColumn.CellTemplate.Value = "id_perfil";
            comboboxColumn.HeaderText = "Perfil";
            comboboxColumn.DropDownWidth = 160;
            comboboxColumn.Width = 120;
            comboboxColumn.MaxDropDownItems = 4;
            comboboxColumn.FlatStyle = FlatStyle.Flat;
            
            dgvusuarios.Columns.Insert(2, comboboxColumn);
        }

        private void AddComboBoxColumns1()
        {
            
            DataGridViewComboBoxColumn comboboxColumn1;
            
            comboboxColumn1 = CreateComboBoxColumn1();
            
            SetAlternateChoicesUsingDataSource1(comboboxColumn1);
            
            comboboxColumn1.HeaderText = "Situação";
            
            dgvusuarios.Columns.Insert(4, comboboxColumn1);
            
        }
       
        private DataGridViewComboBoxColumn CreateComboBoxColumn1()
        {
            DataGridViewComboBoxColumn column =
                new DataGridViewComboBoxColumn();
            {
                column.DataPropertyName = ColumnName.Situacao.ToString();
                
                column.DropDownWidth = 160;
                column.Width = 90;
                column.MaxDropDownItems = 2;
                column.FlatStyle = FlatStyle.Flat;
            }
            return column;
        }
        
        private void SetAlternateChoicesUsingDataSource1(DataGridViewComboBoxColumn comboboxColumn1)
        {
            {

                comboboxColumn1.DataSource = RetrieveAlternativeTitles1();
                comboboxColumn1.ValueMember = "Situacao";
                comboboxColumn1.DisplayMember = comboboxColumn1.ValueMember;
                
            }

        }
        
        private DataTable RetrieveAlternativeTitles1()
        {
            var dtsituacao = new DataTable();
            dtsituacao.Columns.Add("Situacao");
            dtsituacao.Rows.Add("Ativo");
            dtsituacao.Rows.Add("Inativo");
           
            return dtsituacao;
        }
       
        private void Formconsultausuarios_Load(object sender, EventArgs e)
        {
            Carregar_grid();
            permissao(usuario);
            exibir_id_perfil(Convert.ToString(dgvusuarios.CurrentRow.Cells[2].Value));
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

                    }

                }
                con.Close();
            }
            catch (MySqlException erro)
            {
                MessageBox.Show(erro.Message + "Erro");
            }
        }
        private void dgvusuarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvusuarios.Columns[e.ColumnIndex].Name == "senha" && e.Value != null)
            {
                dgvusuarios.Rows[e.RowIndex].Tag = e.Value;
                e.Value = new String('*', e.Value.ToString().Length);
            }
        }

       
        private void btnalterar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuariosinformation usuarios = new Usuariosinformation();

                usuarios.IDlogin = Convert.ToInt32(dgvusuarios.CurrentRow.Cells[0].Value);

                usuarios.Nome = Convert.ToString(dgvusuarios.CurrentRow.Cells[1].Value);

                usuarios.ID_Perfil = Convert.ToInt32(label3.Text);

                usuarios.Senha = Convert.ToString(dgvusuarios.CurrentRow.Cells[3].Value);

                usuarios.Situacao = Convert.ToString(dgvusuarios.CurrentRow.Cells[4].Value);

                usuarios.Data_cadastro = Convert.ToDateTime(dgvusuarios.CurrentRow.Cells[5].Value);

                UsuarioBLL obj = new UsuarioBLL();
                obj.Alterar(usuarios);
                MessageBox.Show("O Usuário foi alterado com sucesso", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error:    " + ex.Message);
            }
            
            dgvusuarios.Columns[0].HeaderText = "Id Usuário";
            dgvusuarios.Columns[1].HeaderText = "Nome";
            dgvusuarios.Columns[3].HeaderText = "Senha";
        }

        
        private void btnexcluir_Click(object sender, EventArgs e)
        {
          DialogResult dialogresult = MessageBox.Show("Tem Certeza da Exclusão do Cliente?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogresult == DialogResult.Yes)
            {
                int codigo = Convert.ToInt32(dgvusuarios.CurrentRow.Cells[0].Value);

                UsuarioBLL usuarioBLL = new UsuarioBLL();
                usuarioBLL.Excluir(codigo);

                MessageBox.Show("O Usuário foi excluído com Sucesso!");
            }
            UsuarioBLL obj = new UsuarioBLL();
            dgvusuarios.DataSource = obj.Listagem();
            dgvusuarios.Columns[0].HeaderText = "Id Usuário";
            dgvusuarios.Columns[1].HeaderText = "Nome";
            dgvusuarios.Columns[3].HeaderText = "Senha";
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            if (txtcamponome.Text.Equals(string.Empty))
            {
                MessageBox.Show("Digite as letras iniciais do nome do usuário!");
                txtcamponome.Focus();
            }
            else
            {
                UsuarioBLL usuario = new UsuarioBLL();

                dgvusuarios.DataSource = usuario.filtragem(txtcamponome.Text);
                btnconsultar.Visible = false;
                btndesfazer.Visible = true;
            }
            
        }

        private void btndesfazer_Click(object sender, EventArgs e)
        {
            UsuarioBLL obj = new UsuarioBLL();
            dgvusuarios.DataSource = obj.Listagem();
            dgvusuarios.Columns[0].HeaderText = "Id Usuário";
            dgvusuarios.Columns[1].HeaderText = "Nome";
            dgvusuarios.Columns[3].HeaderText = "Senha";
            btnconsultar.Visible = true;
            btndesfazer.Visible = false;
            txtcamponome.Text = String.Empty;
        }

        private void dgvusuarios_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if(e.Exception.Message == "DataGridViewComboBoxCell value is not valid. ")
            {
                object value = dgvusuarios.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if(!((DataGridViewComboBoxColumn)dgvusuarios.Columns[e.ColumnIndex]).Items.Contains(value))
                {
                    ((DataGridViewComboBoxColumn)dgvusuarios.Columns[e.ColumnIndex]).Items.Add(value);
                    e.ThrowException = false;
                }
            }
        }

        private void dgvusuarios_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
           
        }

        private void dgvusuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            exibir_id_perfil(Convert.ToString(dgvusuarios.CurrentRow.Cells[2].Value));

        }
        private void exibir_id_perfil(string id_perfil)
        {
            Dados_Conexao dados_Conexao = new Dados_Conexao();

            MySqlConnection connection = new MySqlConnection();

            connection.ConnectionString = dados_Conexao.Conexao();

            MySqlCommand com = new MySqlCommand();

            com.Connection = connection;

            com.CommandText = "SELECT usuarios.id_perfil FROM rentbike.perfis_do_usuario join usuarios on perfis_do_usuario.id_perfil = usuarios.id_perfil where perfis_do_usuario.perfil = '" + id_perfil + "';";

            connection.Open();

            MySqlDataReader dados = com.ExecuteReader();

            while (dados.Read())
            {
                label3.Text = dados["id_perfil"].ToString();
            }
            connection.Close();
        }
    }
}
