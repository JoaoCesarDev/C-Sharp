namespace UIWindows
{
    partial class Frmvendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblvenda = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbocliente = new System.Windows.Forms.ComboBox();
            this.gbvendas = new System.Windows.Forms.GroupBox();
            this.txttroco = new System.Windows.Forms.TextBox();
            this.lbltroco = new System.Windows.Forms.Label();
            this.txtvalor_pago = new System.Windows.Forms.TextBox();
            this.lblcalorpago = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtvalorparcela = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtparcelas = new System.Windows.Forms.TextBox();
            this.lblparcelas = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.lbldatadavenda = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.cboformadepagamento = new System.Windows.Forms.ComboBox();
            this.txtdesconto = new System.Windows.Forms.TextBox();
            this.lbldesconto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.lblsubtotal = new System.Windows.Forms.Label();
            this.lblforma = new System.Windows.Forms.Label();
            this.btnfecharlista = new System.Windows.Forms.Button();
            this.btnremoveritem = new System.Windows.Forms.Button();
            this.txtobservacao = new System.Windows.Forms.TextBox();
            this.lblobservacao = new System.Windows.Forms.Label();
            this.dtpexpedicao = new System.Windows.Forms.DateTimePicker();
            this.lbldataexpedicao = new System.Windows.Forms.Label();
            this.dgvitensvenda = new System.Windows.Forms.DataGridView();
            this.txtcodigovenda = new System.Windows.Forms.TextBox();
            this.lblcodigovenda = new System.Windows.Forms.Label();
            this.btncomprovante = new System.Windows.Forms.Button();
            this.lblvendedor = new System.Windows.Forms.Label();
            this.cbofuncionario = new System.Windows.Forms.ComboBox();
            this.btnfecharvenda = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gbvendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvitensvenda)).BeginInit();
            this.SuspendLayout();
            // 
            // lblvenda
            // 
            this.lblvenda.AutoSize = true;
            this.lblvenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvenda.ForeColor = System.Drawing.SystemColors.Window;
            this.lblvenda.Location = new System.Drawing.Point(18, 9);
            this.lblvenda.Name = "lblvenda";
            this.lblvenda.Size = new System.Drawing.Size(140, 39);
            this.lblvenda.TabIndex = 0;
            this.lblvenda.Text = "Vendas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.lblvenda);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 634);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cliente";
            // 
            // cbocliente
            // 
            this.cbocliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbocliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbocliente.FormattingEnabled = true;
            this.cbocliente.Location = new System.Drawing.Point(225, 30);
            this.cbocliente.Name = "cbocliente";
            this.cbocliente.Size = new System.Drawing.Size(249, 21);
            this.cbocliente.TabIndex = 1;
            // 
            // gbvendas
            // 
            this.gbvendas.Controls.Add(this.txttroco);
            this.gbvendas.Controls.Add(this.lbltroco);
            this.gbvendas.Controls.Add(this.txtvalor_pago);
            this.gbvendas.Controls.Add(this.lblcalorpago);
            this.gbvendas.Controls.Add(this.label4);
            this.gbvendas.Controls.Add(this.txtvalorparcela);
            this.gbvendas.Controls.Add(this.label3);
            this.gbvendas.Controls.Add(this.txtparcelas);
            this.gbvendas.Controls.Add(this.lblparcelas);
            this.gbvendas.Controls.Add(this.txttotal);
            this.gbvendas.Controls.Add(this.lbldatadavenda);
            this.gbvendas.Controls.Add(this.lbltotal);
            this.gbvendas.Controls.Add(this.cboformadepagamento);
            this.gbvendas.Controls.Add(this.txtdesconto);
            this.gbvendas.Controls.Add(this.lbldesconto);
            this.gbvendas.Controls.Add(this.label2);
            this.gbvendas.Controls.Add(this.txtsubtotal);
            this.gbvendas.Controls.Add(this.lblsubtotal);
            this.gbvendas.Controls.Add(this.lblforma);
            this.gbvendas.Controls.Add(this.btnfecharlista);
            this.gbvendas.Controls.Add(this.btnremoveritem);
            this.gbvendas.Controls.Add(this.txtobservacao);
            this.gbvendas.Controls.Add(this.lblobservacao);
            this.gbvendas.Controls.Add(this.dtpexpedicao);
            this.gbvendas.Controls.Add(this.lbldataexpedicao);
            this.gbvendas.Controls.Add(this.dgvitensvenda);
            this.gbvendas.Controls.Add(this.txtcodigovenda);
            this.gbvendas.Controls.Add(this.lblcodigovenda);
            this.gbvendas.Location = new System.Drawing.Point(206, 58);
            this.gbvendas.Name = "gbvendas";
            this.gbvendas.Size = new System.Drawing.Size(700, 529);
            this.gbvendas.TabIndex = 5;
            this.gbvendas.TabStop = false;
            this.gbvendas.Text = "Vendas";
            // 
            // txttroco
            // 
            this.txttroco.Location = new System.Drawing.Point(592, 485);
            this.txttroco.Name = "txttroco";
            this.txttroco.ReadOnly = true;
            this.txttroco.Size = new System.Drawing.Size(93, 20);
            this.txttroco.TabIndex = 34;
            this.txttroco.Text = "0";
            this.txttroco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txttroco.Click += new System.EventHandler(this.txttroco_Click);
            // 
            // lbltroco
            // 
            this.lbltroco.AutoSize = true;
            this.lbltroco.Location = new System.Drawing.Point(551, 488);
            this.lbltroco.Name = "lbltroco";
            this.lbltroco.Size = new System.Drawing.Size(38, 13);
            this.lbltroco.TabIndex = 33;
            this.lbltroco.Text = "Troco:";
            // 
            // txtvalor_pago
            // 
            this.txtvalor_pago.Location = new System.Drawing.Point(592, 462);
            this.txtvalor_pago.Name = "txtvalor_pago";
            this.txtvalor_pago.Size = new System.Drawing.Size(93, 20);
            this.txtvalor_pago.TabIndex = 11;
            this.txtvalor_pago.Text = "0";
            this.txtvalor_pago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtvalor_pago.Click += new System.EventHandler(this.txtvalor_pago_Click);
            this.txtvalor_pago.TextChanged += new System.EventHandler(this.txtvalor_pago_TextChanged);
            this.txtvalor_pago.Enter += new System.EventHandler(this.txtvalor_pago_Enter);
            this.txtvalor_pago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtvalor_pago_KeyPress);
            this.txtvalor_pago.Leave += new System.EventHandler(this.txtvalor_pago_Leave);
            // 
            // lblcalorpago
            // 
            this.lblcalorpago.AutoSize = true;
            this.lblcalorpago.Location = new System.Drawing.Point(513, 466);
            this.lblcalorpago.Name = "lblcalorpago";
            this.lblcalorpago.Size = new System.Drawing.Size(79, 13);
            this.lblcalorpago.TabIndex = 31;
            this.lblcalorpago.Text = "Valor Pago: R$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Lista de Itens";
            // 
            // txtvalorparcela
            // 
            this.txtvalorparcela.Location = new System.Drawing.Point(448, 444);
            this.txtvalorparcela.Name = "txtvalorparcela";
            this.txtvalorparcela.ReadOnly = true;
            this.txtvalorparcela.Size = new System.Drawing.Size(66, 20);
            this.txtvalorparcela.TabIndex = 28;
            this.txtvalorparcela.Text = "0";
            this.txtvalorparcela.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtvalorparcela.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(429, 447);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "de";
            this.label3.Visible = false;
            // 
            // txtparcelas
            // 
            this.txtparcelas.Location = new System.Drawing.Point(384, 444);
            this.txtparcelas.Name = "txtparcelas";
            this.txtparcelas.Size = new System.Drawing.Size(45, 20);
            this.txtparcelas.TabIndex = 10;
            this.txtparcelas.Text = "1";
            this.txtparcelas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtparcelas.Visible = false;
            this.txtparcelas.Click += new System.EventHandler(this.txtparcelas_Click);
            this.txtparcelas.TextChanged += new System.EventHandler(this.txtparcelas_TextChanged);
            // 
            // lblparcelas
            // 
            this.lblparcelas.AutoSize = true;
            this.lblparcelas.Location = new System.Drawing.Point(381, 428);
            this.lblparcelas.Name = "lblparcelas";
            this.lblparcelas.Size = new System.Drawing.Size(48, 13);
            this.lblparcelas.TabIndex = 25;
            this.lblparcelas.Text = "Parcelas";
            this.lblparcelas.Visible = false;
            // 
            // txttotal
            // 
            this.txttotal.Enabled = false;
            this.txttotal.Location = new System.Drawing.Point(592, 439);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(93, 20);
            this.txttotal.TabIndex = 14;
            this.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbldatadavenda
            // 
            this.lbldatadavenda.AutoSize = true;
            this.lbldatadavenda.Location = new System.Drawing.Point(632, 11);
            this.lbldatadavenda.Name = "lbldatadavenda";
            this.lbldatadavenda.Size = new System.Drawing.Size(35, 13);
            this.lbldatadavenda.TabIndex = 17;
            this.lbldatadavenda.Text = "label3";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(558, 442);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(37, 13);
            this.lbltotal.TabIndex = 13;
            this.lbltotal.Text = "Total: ";
            // 
            // cboformadepagamento
            // 
            this.cboformadepagamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboformadepagamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboformadepagamento.FormattingEnabled = true;
            this.cboformadepagamento.ItemHeight = 13;
            this.cboformadepagamento.Items.AddRange(new object[] {
            "Á Vista - Dinheiro",
            "Cartão de Débito",
            "Cartão de Crédito - Parcelado"});
            this.cboformadepagamento.Location = new System.Drawing.Point(367, 395);
            this.cboformadepagamento.Name = "cboformadepagamento";
            this.cboformadepagamento.Size = new System.Drawing.Size(149, 21);
            this.cboformadepagamento.TabIndex = 8;
            this.cboformadepagamento.Text = "Á Vista - Dinheiro";
            this.cboformadepagamento.SelectedIndexChanged += new System.EventHandler(this.cboformadepagamento_SelectedIndexChanged);
            // 
            // txtdesconto
            // 
            this.txtdesconto.Location = new System.Drawing.Point(592, 416);
            this.txtdesconto.Name = "txtdesconto";
            this.txtdesconto.Size = new System.Drawing.Size(93, 20);
            this.txtdesconto.TabIndex = 9;
            this.txtdesconto.Text = "0";
            this.txtdesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtdesconto.Click += new System.EventHandler(this.txtdesconto_Click);
            this.txtdesconto.TextChanged += new System.EventHandler(this.txtdesconto_TextChanged);
            this.txtdesconto.Enter += new System.EventHandler(this.txtdesconto_Enter);
            this.txtdesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdesconto_KeyPress);
            this.txtdesconto.Leave += new System.EventHandler(this.txtdesconto_Leave);
            // 
            // lbldesconto
            // 
            this.lbldesconto.AutoSize = true;
            this.lbldesconto.Location = new System.Drawing.Point(519, 421);
            this.lbldesconto.Name = "lbldesconto";
            this.lbldesconto.Size = new System.Drawing.Size(73, 13);
            this.lbldesconto.TabIndex = 11;
            this.lbldesconto.Text = "Desconto: R$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(551, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Data da Venda:";
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Enabled = false;
            this.txtsubtotal.Location = new System.Drawing.Point(592, 393);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.ReadOnly = true;
            this.txtsubtotal.Size = new System.Drawing.Size(93, 20);
            this.txtsubtotal.TabIndex = 10;
            this.txtsubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtsubtotal.TextChanged += new System.EventHandler(this.txtsubtotal_TextChanged);
            this.txtsubtotal.Leave += new System.EventHandler(this.txtsubtotal_Leave);
            // 
            // lblsubtotal
            // 
            this.lblsubtotal.AutoSize = true;
            this.lblsubtotal.Location = new System.Drawing.Point(543, 396);
            this.lblsubtotal.Name = "lblsubtotal";
            this.lblsubtotal.Size = new System.Drawing.Size(49, 13);
            this.lblsubtotal.TabIndex = 9;
            this.lblsubtotal.Text = "Subtotal:";
            // 
            // lblforma
            // 
            this.lblforma.AutoSize = true;
            this.lblforma.Location = new System.Drawing.Point(390, 379);
            this.lblforma.Name = "lblforma";
            this.lblforma.Size = new System.Drawing.Size(111, 13);
            this.lblforma.TabIndex = 15;
            this.lblforma.Text = "Forma de Pagamento:";
            // 
            // btnfecharlista
            // 
            this.btnfecharlista.Enabled = false;
            this.btnfecharlista.Location = new System.Drawing.Point(566, 339);
            this.btnfecharlista.Name = "btnfecharlista";
            this.btnfecharlista.Size = new System.Drawing.Size(119, 28);
            this.btnfecharlista.TabIndex = 7;
            this.btnfecharlista.Text = "&Fechar Lista de Itens";
            this.btnfecharlista.UseVisualStyleBackColor = true;
            this.btnfecharlista.Click += new System.EventHandler(this.btnfecharlista_Click);
            // 
            // btnremoveritem
            // 
            this.btnremoveritem.Location = new System.Drawing.Point(10, 339);
            this.btnremoveritem.Name = "btnremoveritem";
            this.btnremoveritem.Size = new System.Drawing.Size(102, 29);
            this.btnremoveritem.TabIndex = 6;
            this.btnremoveritem.Text = "&Remover da Lista";
            this.btnremoveritem.UseVisualStyleBackColor = true;
            this.btnremoveritem.Visible = false;
            this.btnremoveritem.Click += new System.EventHandler(this.btnremoveritem_Click_1);
            // 
            // txtobservacao
            // 
            this.txtobservacao.Location = new System.Drawing.Point(10, 395);
            this.txtobservacao.Multiline = true;
            this.txtobservacao.Name = "txtobservacao";
            this.txtobservacao.Size = new System.Drawing.Size(330, 25);
            this.txtobservacao.TabIndex = 13;
            // 
            // lblobservacao
            // 
            this.lblobservacao.AutoSize = true;
            this.lblobservacao.Location = new System.Drawing.Point(7, 379);
            this.lblobservacao.Name = "lblobservacao";
            this.lblobservacao.Size = new System.Drawing.Size(68, 13);
            this.lblobservacao.TabIndex = 14;
            this.lblobservacao.Text = "Observação:";
            // 
            // dtpexpedicao
            // 
            this.dtpexpedicao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpexpedicao.Location = new System.Drawing.Point(384, 496);
            this.dtpexpedicao.Name = "dtpexpedicao";
            this.dtpexpedicao.Size = new System.Drawing.Size(121, 20);
            this.dtpexpedicao.TabIndex = 12;
            this.dtpexpedicao.Value = new System.DateTime(2020, 6, 14, 0, 0, 0, 0);
            // 
            // lbldataexpedicao
            // 
            this.lbldataexpedicao.AutoSize = true;
            this.lbldataexpedicao.Location = new System.Drawing.Point(395, 479);
            this.lbldataexpedicao.Name = "lbldataexpedicao";
            this.lbldataexpedicao.Size = new System.Drawing.Size(101, 13);
            this.lbldataexpedicao.TabIndex = 13;
            this.lbldataexpedicao.Text = "Data da Expedição:";
            // 
            // dgvitensvenda
            // 
            this.dgvitensvenda.AllowUserToAddRows = false;
            this.dgvitensvenda.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvitensvenda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvitensvenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvitensvenda.Location = new System.Drawing.Point(8, 72);
            this.dgvitensvenda.Name = "dgvitensvenda";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvitensvenda.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvitensvenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvitensvenda.Size = new System.Drawing.Size(686, 261);
            this.dgvitensvenda.TabIndex = 8;
            this.dgvitensvenda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvitensvenda_CellClick);
            this.dgvitensvenda.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvitensvenda_CellValueChanged);
            this.dgvitensvenda.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvitensvenda_RowsAdded);
            this.dgvitensvenda.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvitensvenda_RowsRemoved);
            // 
            // txtcodigovenda
            // 
            this.txtcodigovenda.Location = new System.Drawing.Point(85, 22);
            this.txtcodigovenda.Name = "txtcodigovenda";
            this.txtcodigovenda.ReadOnly = true;
            this.txtcodigovenda.Size = new System.Drawing.Size(77, 20);
            this.txtcodigovenda.TabIndex = 20;
            this.txtcodigovenda.TabStop = false;
            // 
            // lblcodigovenda
            // 
            this.lblcodigovenda.AutoSize = true;
            this.lblcodigovenda.Location = new System.Drawing.Point(2, 25);
            this.lblcodigovenda.Name = "lblcodigovenda";
            this.lblcodigovenda.Size = new System.Drawing.Size(81, 13);
            this.lblcodigovenda.TabIndex = 0;
            this.lblcodigovenda.Text = "Cód. da Venda:";
            // 
            // btncomprovante
            // 
            this.btncomprovante.Location = new System.Drawing.Point(579, 598);
            this.btncomprovante.Name = "btncomprovante";
            this.btncomprovante.Size = new System.Drawing.Size(141, 28);
            this.btncomprovante.TabIndex = 15;
            this.btncomprovante.Text = "&Imprimir Comprovante";
            this.btncomprovante.UseVisualStyleBackColor = true;
            this.btncomprovante.Visible = false;
            // 
            // lblvendedor
            // 
            this.lblvendedor.AutoSize = true;
            this.lblvendedor.Location = new System.Drawing.Point(507, 15);
            this.lblvendedor.Name = "lblvendedor";
            this.lblvendedor.Size = new System.Drawing.Size(56, 13);
            this.lblvendedor.TabIndex = 7;
            this.lblvendedor.Text = "Atendente";
            // 
            // cbofuncionario
            // 
            this.cbofuncionario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbofuncionario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbofuncionario.FormattingEnabled = true;
            this.cbofuncionario.Location = new System.Drawing.Point(509, 30);
            this.cbofuncionario.Name = "cbofuncionario";
            this.cbofuncionario.Size = new System.Drawing.Size(232, 21);
            this.cbofuncionario.TabIndex = 2;
            // 
            // btnfecharvenda
            // 
            this.btnfecharvenda.Enabled = false;
            this.btnfecharvenda.Location = new System.Drawing.Point(794, 597);
            this.btnfecharvenda.Name = "btnfecharvenda";
            this.btnfecharvenda.Size = new System.Drawing.Size(109, 28);
            this.btnfecharvenda.TabIndex = 15;
            this.btnfecharvenda.Text = "&Fechar Venda";
            this.btnfecharvenda.UseVisualStyleBackColor = true;
            this.btnfecharvenda.Visible = false;
            this.btnfecharvenda.Click += new System.EventHandler(this.btnfecharvenda_Click_1);
            // 
            // Frmvendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 634);
            this.Controls.Add(this.btnfecharvenda);
            this.Controls.Add(this.cbofuncionario);
            this.Controls.Add(this.lblvendedor);
            this.Controls.Add(this.gbvendas);
            this.Controls.Add(this.cbocliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btncomprovante);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "Frmvendas";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frmvendas_FormClosed);
            this.Load += new System.EventHandler(this.Frmvendas_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frmvendas_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbvendas.ResumeLayout(false);
            this.gbvendas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvitensvenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblvenda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbocliente;
        private System.Windows.Forms.GroupBox gbvendas;
        private System.Windows.Forms.TextBox txtcodigovenda;
        private System.Windows.Forms.Label lblcodigovenda;
        private System.Windows.Forms.DataGridView dgvitensvenda;
        private System.Windows.Forms.Label lblvendedor;
        private System.Windows.Forms.ComboBox cbofuncionario;
        private System.Windows.Forms.TextBox txtsubtotal;
        private System.Windows.Forms.TextBox txtdesconto;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.ComboBox cboformadepagamento;
        private System.Windows.Forms.DateTimePicker dtpexpedicao;
        private System.Windows.Forms.Label lbldataexpedicao;
        private System.Windows.Forms.TextBox txtobservacao;
        private System.Windows.Forms.Label lblobservacao;
        private System.Windows.Forms.Button btnremoveritem;
        private System.Windows.Forms.Button btnfecharlista;
        private System.Windows.Forms.Button btncomprovante;
        private System.Windows.Forms.Label lbldatadavenda;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lbldesconto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblsubtotal;
        private System.Windows.Forms.Label lblforma;
        private System.Windows.Forms.TextBox txtvalorparcela;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtparcelas;
        private System.Windows.Forms.Label lblparcelas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttroco;
        private System.Windows.Forms.Label lbltroco;
        private System.Windows.Forms.TextBox txtvalor_pago;
        private System.Windows.Forms.Label lblcalorpago;
        private System.Windows.Forms.Button btnfecharvenda;
    }
}