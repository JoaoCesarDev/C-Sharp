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
using APRESENTAÇÃO.DAL;
using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;

namespace UIWindows
{
    public partial class Frmrelatorioclientes : Form
    {

        
        public Frmrelatorioclientes()
        {
            InitializeComponent();
        }

        private void Frmrelatorioclientes_Load(object sender, EventArgs e)
        {

            // TODO: esta linha de código carrega dados na tabela 'rentbikeDataSet.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.rentbikeDataSet.cliente);
            this.rpvclientes.RefreshReport();



            VendasBLL obj = new VendasBLL();

            cbonome.DataSource = obj.ListaDeClientes;
            cbonome.DisplayMember = "nome";
            cbonome.ValueMember = "id_Cliente";
        }

        private void btnfiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                this.clienteTableAdapter.FillBy1FiltroIDCiente(this.rentbikeDataSet.cliente, ((string)(System.Convert.ChangeType(cbonome.Text, typeof(string)))));
                this.rpvclientes.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.clienteTableAdapter.FillBy(this.rentbikeDataSet.cliente);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1FiltroIDCienteToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

        private void fillBy1FiltroIDCienteToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.clienteTableAdapter.FillBy1FiltroIDCiente(this.rentbikeDataSet.cliente, ((string)(System.Convert.ChangeType(cbonome.Text, typeof(string)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.clienteTableAdapter.FillBy1(this.rentbikeDataSet.cliente, param1ToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void param1ToolStripLabel_Click(object sender, EventArgs e)
        {

        }

        private void btndesfazerfiltro_Click(object sender, EventArgs e)
        {
            this.clienteTableAdapter.Fill(this.rentbikeDataSet.cliente);
            this.rpvclientes.RefreshReport();
        }
    }
}
