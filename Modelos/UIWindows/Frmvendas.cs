using System;
using System.Collections.Generic;
using System.Windows.Forms;
using APRESENTAÇÃO.DAL;
using APRESENTAÇÃO.Modelos;
using APRESENTAÇÃO.BLL;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System.Linq;
using System.Data;
using System.ComponentModel;
using System.Drawing;

namespace UIWindows
{
    public partial class Frmvendas : Form
    {
        List<Produtos> _listaprodutos = new List<Produtos>();
       
        public Frmvendas(List<Produtos> _Itensprodutos)
        {
            _listaprodutos = _Itensprodutos;
            
            InitializeComponent();
           
        }


        private void Frmvendas_Load(object sender, EventArgs e)
        {

            VendasBLL obj = new VendasBLL();

            cbocliente.DataSource = obj.ListaDeClientes;
            cbocliente.DisplayMember = "nome";
            cbocliente.ValueMember = "id_Cliente";

            contador();
            


            cbofuncionario.DataSource = obj.ListaDeFuncionarios;
            cbofuncionario.DisplayMember = "nome";
            cbofuncionario.ValueMember = "id_funcionarios";


            lbldatadavenda.Text = DateTime.Now.ToShortDateString();
           
            dtpexpedicao.Value = DateTime.Now;
            
            dgvitensvenda.DataSource = new BindingList<Produtos>(_listaprodutos);
            Verificar_duplicado();
            for (int linha = 1; linha <= dgvitensvenda.Rows.Count - 1; linha++)
            {
                this.dgvitensvenda.CurrentCell = this.dgvitensvenda[0, linha];
            }
            formatar_datagridviewlista();
            total_linha_do_Grid();
        }



        private void contador()
        {
            Dados_Conexao dados_Conexao = new Dados_Conexao();

            MySqlConnection connection = new MySqlConnection();

            connection.ConnectionString = dados_Conexao.Conexao();

            MySqlCommand com = new MySqlCommand();

            com.Connection = connection;

            com.CommandText = "select * from rentbike.contadorvendas;";

            connection.Open();

            MySqlDataReader dados = com.ExecuteReader();

            while (dados.Read())
            {
                txtcodigovenda.Text = dados["idcontador"].ToString();
            }
            connection.Close();
        }
        
        private void formatar_datagridviewlista()
        {
            DataGridViewColumn column0 = dgvitensvenda.Columns[0];
            column0.Width = 125;
            dgvitensvenda.Columns[0].HeaderText = "Código do Produto";
            dgvitensvenda.Columns[1].HeaderText = "Produto";
            dgvitensvenda.Columns[2].HeaderText = "Estoque Disponível";
            dgvitensvenda.Columns[3].HeaderText = "Quantidade";
            dgvitensvenda.Columns[4].HeaderText = "Preco Unitário";
            dgvitensvenda.Columns[5].HeaderText = "Valor Total";
            DataGridViewColumn column2 = dgvitensvenda.Columns[2];
            column2.Width = 125;
            dgvitensvenda.Columns[0].ReadOnly = true;

            dgvitensvenda.Columns[1].ReadOnly = true;

            dgvitensvenda.Columns[2].ReadOnly = true;

            dgvitensvenda.Columns[4].ReadOnly = true;

            dgvitensvenda.Columns[5].ReadOnly = true;
        }
        private void total_linha_do_Grid()
        {
            decimal total = 0;
            foreach (DataGridViewRow dgvitensvenda1 in dgvitensvenda.Rows)
            {
                
                decimal valor1 = Convert.ToDecimal(dgvitensvenda1.Cells[3].Value);
                decimal valor2 = Convert.ToDecimal(dgvitensvenda1.Cells[4].Value);
                decimal subtotal = valor1 * valor2;
                dgvitensvenda1.Cells[5].Value = subtotal;
                dgvitensvenda.Columns[4].DefaultCellStyle.Format = "C";
                dgvitensvenda.Columns[5].DefaultCellStyle.Format = "C";
                total += subtotal;

            }

            txtsubtotal.Text = total.ToString("C");
        }

        private void Verificar_duplicado()
        {
            bool isDuplicate;

            for (int nbRow = 0; nbRow < dgvitensvenda.Rows.Count; nbRow++)
            {
                for (int nbRowCompare = nbRow; nbRowCompare < dgvitensvenda.Rows.Count; nbRowCompare++)
                {
                    isDuplicate = true;

                    for (int nbCol = 0; nbCol < dgvitensvenda.Rows[nbRow].Cells.Count; nbCol++)
                    {
                        if (dgvitensvenda[nbCol, nbRow].Value != dgvitensvenda[nbCol, nbRowCompare])
                        {
                            isDuplicate = false;
                            break;     //Exit for each column if they are not duplicate
                        }
                    }

                    if (isDuplicate)
                    {
                        //Do something
                        MessageBox.Show("Item duplicado");
                    }
                }
            }
        }

        private void Adicionar_Somando()
        {
            bool existe = false;
            int cont = 0;


            for (int i = 1; i <= dgvitensvenda.Rows.Count - 1; ++i)
            {
                if (dgvitensvenda.Rows[i].Cells[2].Value.Equals(dgvitensvenda.Rows[cont].Cells[2].Value))
                {
                    existe = true;
                    dgvitensvenda.Rows[cont].Cells[3].Value = +Convert.ToInt32(dgvitensvenda.Rows[cont].Cells[3].Value);
                    dgvitensvenda.Rows.RemoveAt(dgvitensvenda.CurrentRow.Index);
                    break;
                }
                if (existe != true)
                {

                    dgvitensvenda.Rows.RemoveAt(dgvitensvenda.CurrentRow.Index);
                }
                ++cont;

            }
        }


        private void Incluir_Vendas()
        {
            DialogResult dialogresult = MessageBox.Show("Tem Certeza da Conclusão da Venda?", "Finalizar Venda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (dialogresult == DialogResult.Yes)
                {
                    Vendasinformation vendas = new Vendasinformation();

                    vendas.Idvendas = Convert.ToInt32(txtcodigovenda.Text);
                    vendas.Datavenda = Convert.ToDateTime(lbldatadavenda.Text);
                    vendas.Dataexpedicao = Convert.ToDateTime(dtpexpedicao.Value);
                    vendas.Observacao = txtobservacao.Text;
                    vendas.Idcliente = Convert.ToInt32(cbocliente.SelectedValue);
                    vendas.Idfuncionario = Convert.ToInt32(cbofuncionario.SelectedValue);
                    vendas.Forma_de_Pagamento = cboformadepagamento.Text;
                    vendas.Parcelas = Convert.ToInt32(txtparcelas.Text);
                    vendas.Valor_parcelas = Convert.ToDecimal(txtvalorparcela.Text.Replace("R$ ", ""));
                    vendas.Desconto = Convert.ToDecimal(txtdesconto.Text);
                    vendas.Subtotal = Convert.ToDecimal(txtsubtotal.Text.Replace("R$ ", ""));
                    vendas.Valortotal = Convert.ToDecimal(txttotal.Text.Replace("R$ ", ""));
                    vendas.Valorpago = Convert.ToDecimal(txtvalor_pago.Text);
                    vendas.Troco = Convert.ToDecimal(txttroco.Text.Replace("R$ ", ""));

                    VendasBLL vendasBLL = new VendasBLL();

                    vendasBLL.Incluir(vendas);
                }
                else
                {
                   
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro:  " + ex.Message);
            }
        }

        private void txtsubtotal_TextChanged(object sender, EventArgs e)
        {
            if (txtsubtotal.Text != "")
            {
                btnfecharvenda.Enabled = true;
                btncomprovante.Enabled = true;
            }
            if (!String.IsNullOrEmpty(txtdesconto.Text) && !String.IsNullOrEmpty(txtsubtotal.Text))
            {
                calcula_total();

            }
        }

        private void Inserir_Lista_Pedidos()
        {
            DialogResult dialogresult = MessageBox.Show("Tem Certeza do Fechamento da Lista?", "Fechar Lista", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (dialogresult == DialogResult.Yes)
                {
                    for (int i = 0; i <= dgvitensvenda.Rows.Count - 1; i++)
                    {

                        Itensvendainformation itensvendas = new Itensvendainformation();

                        itensvendas.Idvendas = Convert.ToInt32(txtcodigovenda.Text);

                        itensvendas.Id_produto = Convert.ToInt32(dgvitensvenda.Rows[i].Cells[0].Value);

                        itensvendas.Quantidade = Convert.ToInt32(dgvitensvenda.Rows[i].Cells[3].Value);

                        itensvendas.Valor = Convert.ToDecimal(dgvitensvenda.Rows[i].Cells[4].Value);

                        itensvendas.Total = Convert.ToDecimal(dgvitensvenda.Rows[i].Cells[5].Value);

                        ItensvendasDAL itensvendasDAL = new ItensvendasDAL();

                        itensvendasDAL.Incluir(itensvendas);

                    }
                }
               else
                {
                    btnfecharlista.Enabled = true;
                    btnfecharvenda.Enabled = false; 
                    dgvitensvenda.Enabled = true;

                    btnremoveritem.Enabled = true;
                    txtcodigovenda.Enabled = true;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Erro: " + Ex.Message);

            }
            txtdesconto.Text = "0";
        }
        private void btnfecharvenda_Click(object sender, EventArgs e)
        {
           

        }

        private void btncomprovante_Click(object sender, EventArgs e)
        {

        }

        private void btnremoveritem_Click_1(object sender, EventArgs e)
        {
            dgvitensvenda.Rows.Remove(dgvitensvenda.CurrentRow);
            if (dgvitensvenda.Rows.Count == 0)
            {
                btnfecharlista.Enabled = false;
            }


        }

        private void dgvitensvenda_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            btnfecharlista.Enabled = true;
            btnremoveritem.Visible = true;
        }
        private void Inserir_Contagem_de_Vendas()
        {
            try
            {
                Dados_Conexao conexao = new Dados_Conexao();
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = conexao.Conexao();
                MySqlCommand com = new MySqlCommand();

                com.CommandText = "Insert into rentbike.contadorvendas (idcontador) values (0);";
                com.Connection = con;
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Erro: " + erro.Message, "Erro");
            }

        }

        private void txtdesconto_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtdesconto.Text) && !String.IsNullOrEmpty(txtsubtotal.Text))
            {
                Moeda(ref txtdesconto);
                calcula_total();
            }
           
        }

        private void txtdesconto_Click(object sender, EventArgs e)
        {
            txtdesconto.SelectAll();
        }

        private void calcula_total()
        {

            decimal valor1 = decimal.Parse(txtsubtotal.Text.Replace("R$ ", "").Trim());
            decimal valor2 = decimal.Parse(txtdesconto.Text.Replace("R$ ", "").Trim());
            decimal total;


            total = valor1 - valor2;
            txttotal.Text = Convert.ToString(total.ToString("C"));

        }

        private void dgvitensvenda_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dgvitensvenda.Rows.Count.Equals(0))
            {
                btnremoveritem.Visible = false;
               
            }
        }
        private void btnfecharlista_Click(object sender, EventArgs e)

        {

            Inserir_Lista_Pedidos();
            
            btnfecharvenda.Visible = true;
            dgvitensvenda.Enabled = false;
            txtdesconto.Focus();
            
            txtcodigovenda.Enabled = false;

         }

        private void cboformadepagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboformadepagamento.SelectedItem.ToString() == "Cartão de Crédito - Parcelado")
            {
                lblparcelas.Visible = true;
                label3.Visible = true;
                txtparcelas.Visible = true;
                txtvalorparcela.Visible = true;
            }
            else
            {
                lblparcelas.Visible = false;
                label3.Visible = false;
                txtparcelas.Visible = false;
                txtvalorparcela.Visible = false;
            }

        }

        private void Frmvendas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void total_parcelas()
        {
            decimal valor1 = Decimal.Parse(txttotal.Text.Replace("R$ ", "").Trim());
            decimal valor2 = Int32.Parse(txtparcelas.Text);

            decimal valorparcela = valor1 / valor2;

            txtvalorparcela.Text = Convert.ToString(valorparcela.ToString("C"));
        }

        private void troco()
        {
            decimal total = Decimal.Parse(txttotal.Text.Replace("R$ ", "").Trim());
            decimal valor_pago = Decimal.Parse(txtvalor_pago.Text.Replace("R$ ", "").Trim());

            decimal troco = valor_pago - total;

            txttroco.Text = Convert.ToString(troco.ToString("C"));

        }

        private void dgvitensvenda_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           
            foreach (DataGridViewRow dgvitensvenda1 in dgvitensvenda.Rows)
            {
                int valor1 = Convert.ToInt32(dgvitensvenda1.Cells[3].Value);
                int valor2 = Convert.ToInt32(dgvitensvenda1.Cells[2].Value);
                if (valor1 > valor2)
                {
                    MessageBox.Show("Quantidade Inválida");
                    
                  
                }
              
                total_linha_do_Grid();
            }
            

        }
        private void dgvitensvenda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvitensvenda.EditMode = DataGridViewEditMode.EditOnEnter;
        }
       
        private void txtparcelas_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txttotal.Text) && !String.IsNullOrEmpty(txtparcelas.Text))
            {
                total_parcelas();
            }
        }

        private void txtparcelas_Click(object sender, EventArgs e)
        {
            txtparcelas.SelectAll();
        }

        private void txtvalor_pago_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtvalor_pago.Text) && !String.IsNullOrEmpty(txttotal.Text))
            {
                Moeda(ref txtvalor_pago);
                troco();
            }
        }

        private void txttroco_Click(object sender, EventArgs e)
        {
            txttroco.SelectAll();
        }

        private void txtvalor_pago_Click(object sender, EventArgs e)
        {
            txtvalor_pago.SelectAll();
        }

        private void txtsubtotal_Leave(object sender, EventArgs e)
        {

        }

        private void txtdesconto_Leave(object sender, EventArgs e)
        {

        }

        private void txtdesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowNumber(sender, e, ',');
        }

        private void txtdesconto_Enter(object sender, EventArgs e)
        {



        }

        private void txtvalor_pago_Leave(object sender, EventArgs e)
        {

        }

        private void txtvalor_pago_Enter(object sender, EventArgs e)
        {

            String x = "";
            for (int i = 0; i <= txtvalor_pago.Text.Length - 1; ++i)
            {
                if ((txtvalor_pago.Text[i] >= '0' && txtvalor_pago.Text[i] <= 9) || txtvalor_pago.Text[i] == ',')
                {
                    x += txtvalor_pago.Text[i];

                }
            }
            txtvalor_pago.Text = x;
            txtvalor_pago.SelectAll();
        }

        private void txtvalor_pago_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowNumber(sender, e, ',');
        }

        public static void Moeda(ref TextBox txt)
        {
            string valor = string.Empty;
            decimal v = 0;
            try
            {
                valor = txt.Text.Replace(",", "").Replace(".", "");
                if (valor.Equals(""))
                {
                    valor = "";
                    valor = valor.PadLeft(3, '0');
                    if (valor.Length > 3 & valor.Substring(0, 1) == "0")
                    {
                        valor = valor.Substring(1, valor.Length - 1);
                        v = Convert.ToDecimal(valor) / 100;
                        txt.Text = string.Format("{0:c}", v);
                        txt.SelectionStart = txt.Text.Length;
                    }
                }
            }
            catch (Exception)
            {

            }

        }
        public static void AllowNumber(object sender, KeyPressEventArgs e, char cSymbol)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != cSymbol)
            {
                e.Handled = true;
            }

            if (e.KeyChar == cSymbol && (sender as TextBox).Text.IndexOf(cSymbol) > -1)
            {
                e.Handled = true;
            }
        }
        public void Atualiza_Estoque_SP(int id_itensvendas)
        {
            Dados_Conexao dados_Conexao = new Dados_Conexao();

            MySqlConnection connection = new MySqlConnection();

            connection.ConnectionString = dados_Conexao.Conexao();

            connection = new MySqlConnection();

            try

            {
                //command

                MySqlCommand cmd1 = new MySqlCommand("Atualizar_Estoque1", connection);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("id_itens", id_itensvendas);
                connection.Open();
                cmd1.ExecuteNonQuery();

            }
            catch (Exception Ex)
            {
                throw new Exception(Ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnfecharvenda_Click_1(object sender, EventArgs e)
        {
            
            Incluir_Vendas();

            Inserir_Contagem_de_Vendas();
            _listaprodutos.Clear();
            dgvitensvenda.DataSource = new BindingList<Produtos>(_listaprodutos);
            this.Close();
        }
        private void Frmvendas_FormClosed(object sender, FormClosedEventArgs e)
        {
            _listaprodutos.Clear();
           
        }
    }
}
        
  


    


    





