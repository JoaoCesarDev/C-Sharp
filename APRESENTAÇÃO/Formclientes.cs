using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Loja_Bike_Master.BLL;

namespace APRESENTAÇÃO
{
    public partial class Formclientes : Form
    {
        public Formclientes()
        {
            InitializeComponent();
        }
        public void AtualizaGrid()

        {

            // Comunicação com a Camada BLL

            ClientesBLL obj = new ClientesBLL();

            dgvclientes.DataSource = obj.Listagem();



            // Atualizando os objetos TextBox

            txtcodigo.Text = dgvclientes[0, dgvclientes.CurrentRow.Index].Value.ToString();
            txtnome.Text = dgvclientes[1, dgvclientes.CurrentRow.Index].Value.ToString();
            txtdata.Text = dgvclientes[2, dgvclientes.CurrentRow.Index].Value.ToString();
            txtendereco.Text = dgvclientes[3, dgvclientes.CurrentRow.Index].Value.ToString();
            txtbairro.Text = dgvclientes[4, dgvclientes.CurrentRow.Index].Value.ToString();
            txtestado.Text = dgvclientes[6, dgvclientes.CurrentRow.Index].Value.ToString();
            txtcidade.Text = dgvclientes[5, dgvclientes.CurrentRow.Index].Value.ToString();
            txtcep.Text = dgvclientes[8, dgvclientes.CurrentRow.Index].Value.ToString();
            txttelefone.Text = dgvclientes[7, dgvclientes.CurrentRow.Index].Value.ToString();
            txtcelular.Text = dgvclientes[9, dgvclientes.CurrentRow.Index].Value.ToString();
            txtrg.Text = dgvclientes[12, dgvclientes.CurrentRow.Index].Value.ToString();
            txtcpf.Text = dgvclientes[11, dgvclientes.CurrentRow.Index].Value.ToString();
            txtemail.Text = dgvclientes[10, dgvclientes.CurrentRow.Index].Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Formclientes_Load(object sender, EventArgs e)
        {
            AtualizaGrid();

            txtnome.Focus();
        }

        private void lblrg_Click(object sender, EventArgs e)
        {

        }

        private void lblcpf_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtdata_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblcelular_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void gbclientes_Enter(object sender, EventArgs e)
        {

        }
    }
}
