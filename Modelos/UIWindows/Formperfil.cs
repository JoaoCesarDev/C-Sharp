using APRESENTAÇÃO.BLL;
using APRESENTAÇÃO.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIWindows
{
    public partial class Formperfil : Form
    {
        public Formperfil()
        {
            InitializeComponent();
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            if (!txtnome.Text.Equals(String.Empty))
            {
                try

                {

                    Perfisusuarioinformation perfil = new Perfisusuarioinformation();

                    perfil.Perfil = Convert.ToString(txtnome.Text);
                    perfil.Cadastrar = Convert.ToBoolean(chkcadastrar.Checked);
                    perfil.Alterar = Convert.ToBoolean(chkalterar.Checked);
                    perfil.Excluir = Convert.ToBoolean(chkExcluir.Checked);

                    PerfisusuarioBLL obj = new PerfisusuarioBLL();

                    obj.Incluir(perfil);

                    MessageBox.Show("O Perfil foi cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)

                {

                    MessageBox.Show("Erro: " + ex.Message);

                }

            }
            else
            {
                MessageBox.Show("Preencha o nome para o novo Perfil!");
            }
            txtnome.Text = string.Empty;
            chkcadastrar.Checked = false;
            chkalterar.Checked = false;
            chkExcluir.Checked = false;
        }
        
    }
}
