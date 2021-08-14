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
using APRESENTAÇÃO.Modelos;
using APRESENTAÇÃO.DAL;

namespace UIWindows
{
    public partial class Frmfornecedores : Form
    {
        public Frmfornecedores()
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

        private void Frmfornecedores_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!textBoxVazias())
            {
                try
                {
                    Fornecedorinformation fornecedor = new Fornecedorinformation();

                    fornecedor.Nome = txtnome.Text;

                    fornecedor.Endereco = txtendereco.Text;

                    fornecedor.Bairro = txtbairro.Text;

                    fornecedor.Cidade = txtcidade.Text;

                    fornecedor.Estado = cboestado.Text;

                    fornecedor.Pais = txtpais.Text;

                    fornecedor.Telefone = mkttelefone.Text;

                    fornecedor.CNPJ = mktcnpj.Text;

                    FornecedoresBLL fornecedoresBLL = new FornecedoresBLL();

                    fornecedoresBLL.Incluir(fornecedor);

                    MessageBox.Show("O Fornecedor foi incluído com sucesso!", "Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            txtbairro.Text = "";
            txtcidade.Text = "";
            cboestado.Text = "";
            txtpais.Text = "";
            mkttelefone.Text = "";
            mktcnpj.Text = "";
        }
    }

}
