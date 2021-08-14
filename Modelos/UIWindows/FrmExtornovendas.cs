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
using APRESENTAÇÃO.Modelos;
using MySql.Data.MySqlClient;
using APRESENTAÇÃO.BLL;

namespace UIWindows
{
    public partial class FrmExtornovendas : Form
    {
        public FrmExtornovendas()
        {
            InitializeComponent();
           
        }

        private void FrmExtornovendas_Load(object sender, EventArgs e)
        {
            carregar_grid_vendas();
            VendasBLL obj = new VendasBLL();

            cbocodigovenda.DataSource = obj.ListaDeClientes;
            cbocodigovenda.DisplayMember = "nome";
            cbocodigovenda.ValueMember = "id_Cliente";

            cbodatadavenda.DataSource = obj.Listagem;
            cbodatadavenda.DisplayMember = "data_da_venda";
            cbodatadavenda.ValueMember = "data_da_venda";
            Carregar_grid_Itens_da_Venda();
        }
        private void carregar_grid_vendas()
        {
            VendasBLL vendas = new VendasBLL();

            dgvvendas.DataSource = vendas.Listagem;
            


            dgvvendas.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dgvvendas.Columns[0].HeaderText = "Código da Venda";
            DataGridViewColumn column = dgvvendas.Columns[0];
            column.Width = 125;
            dgvvendas.Columns[1].HeaderText = "Data da Venda";
            DataGridViewColumn column1 = dgvvendas.Columns[1];
            column1.Width = 125;
            dgvvendas.Columns[2].HeaderText = "Data da Expedição";
            DataGridViewColumn column2 = dgvvendas.Columns[2];
            column2.Width = 125;
            dgvvendas.Columns[3].HeaderText = "Cliente";
            dgvvendas.Columns[4].HeaderText = "Vendedor";
            dgvvendas.Columns[5].HeaderText = "Forma de Pagamento";
            DataGridViewColumn column3 = dgvvendas.Columns[5];
            column3.Width = 155;
            dgvvendas.Columns[6].HeaderText = "Parcelas";
            dgvvendas.Columns[7].HeaderText = "Valor das Parcelas";
            DataGridViewColumn column7 = dgvvendas.Columns[7];
            column7.Width = 125;
            dgvvendas.Columns[7].DefaultCellStyle.Format = "C";
            dgvvendas.Columns[8].HeaderText = "Desconto";
            dgvvendas.Columns[8].DefaultCellStyle.Format = "C";
            dgvvendas.Columns[9].HeaderText = "Subtotal";
            dgvvendas.Columns[9].DefaultCellStyle.Format = "C";
            dgvvendas.Columns[10].HeaderText = "Valor Total";
            dgvvendas.Columns[10].DefaultCellStyle.Format = "C";
            dgvvendas.Columns[11].HeaderText = "Valor Pago";
            dgvvendas.Columns[11].DefaultCellStyle.Format = "C";
            dgvvendas.Columns[12].HeaderText = "Troco";
            dgvvendas.Columns[12].DefaultCellStyle.Format = "C";
        }
        private void Carregar_grid_Itens_da_Venda()
        {
            
            try
            {
                
                    ItensvendasBLL vendas = new ItensvendasBLL();

                    dgvlistadeitens.DataSource = vendas.Listagem(Convert.ToInt32(dgvvendas.Rows[0].Cells[0].Value));
                    dgvlistadeitens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dgvlistadeitens.Columns[4].DefaultCellStyle.Format = "C";
                    dgvlistadeitens.Columns[5].DefaultCellStyle.Format = "C";
                
            }
            catch (Exception ex)

            {

                MessageBox.Show(ex.Message);


            }
        }

        private void dgvvendas_Click(object sender, EventArgs e)
        {
            
                ItensvendasBLL vendas = new ItensvendasBLL();

                dgvlistadeitens.DataSource = vendas.Listagem(Convert.ToInt32(dgvvendas.SelectedCells[0].Value));
                dgvlistadeitens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvlistadeitens.Columns[4].DefaultCellStyle.Format = "C";
                dgvlistadeitens.Columns[5].DefaultCellStyle.Format = "C";
             
        }

        private void btnextornar_Click(object sender, EventArgs e)
        {
            ItensvendasDAL itensvendas = new ItensvendasDAL();
            itensvendas.Atualiza_Estoque(Convert.ToInt32(dgvlistadeitens.SelectedCells[1].Value));

            DialogResult dialogresult = MessageBox.Show("Tem Certeza da Exclusão da Venda?", "Excluir Venda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogresult == DialogResult.Yes)

            {
                try

                {

                    int codigo = Convert.ToInt32(dgvvendas.SelectedCells[0].Value);

                    VendasBLL obj = new VendasBLL();

                    obj.Excluir(codigo);

                    MessageBox.Show("A venda foi extornada com Sucesso!");



                }

                catch (Exception ex)

                {

                    MessageBox.Show(ex.Message);


                }
            }
            carregar_grid_vendas();
            
            Carregar_grid_Itens_da_Venda();
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            VendasBLL vendas = new VendasBLL();

            dgvvendas.DataSource = vendas.Filtragem_por_cliente(Convert.ToString(cbocodigovenda.Text));
            btndesfazerfiltros.Enabled = true;
        }

        private void btnconsultardata_Click(object sender, EventArgs e)
        {
            VendasBLL vendas = new VendasBLL();

            dgvvendas.DataSource = vendas.Filtragem_por_data(Convert.ToDateTime(cbodatadavenda.Text).ToString("yyyy-MM-dd"));
            btndesfazerfiltros.Enabled = true;
        }

        private void btndesfazerfiltros_Click(object sender, EventArgs e)
        {
            carregar_grid_vendas();
            btndesfazerfiltros.Enabled = false;
        }

        private void FrmExtornovendas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
