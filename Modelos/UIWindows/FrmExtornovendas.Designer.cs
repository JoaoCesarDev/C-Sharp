namespace UIWindows
{
    partial class FrmExtornovendas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblvenda = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblcodigovenda = new System.Windows.Forms.Label();
            this.cbocodigovenda = new System.Windows.Forms.ComboBox();
            this.gbdetalhes = new System.Windows.Forms.GroupBox();
            this.btndesfazerfiltros = new System.Windows.Forms.Button();
            this.gblistadeitens = new System.Windows.Forms.GroupBox();
            this.dgvlistadeitens = new System.Windows.Forms.DataGridView();
            this.dgvvendas = new System.Windows.Forms.DataGridView();
            this.btnconsultar = new System.Windows.Forms.Button();
            this.btnextornar = new System.Windows.Forms.Button();
            this.cbodatadavenda = new System.Windows.Forms.ComboBox();
            this.lbldatadavenda = new System.Windows.Forms.Label();
            this.btnconsultardata = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gbdetalhes.SuspendLayout();
            this.gblistadeitens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistadeitens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvendas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblvenda
            // 
            this.lblvenda.AutoSize = true;
            this.lblvenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvenda.ForeColor = System.Drawing.SystemColors.Window;
            this.lblvenda.Location = new System.Drawing.Point(18, 9);
            this.lblvenda.Name = "lblvenda";
            this.lblvenda.Size = new System.Drawing.Size(190, 78);
            this.lblvenda.TabIndex = 0;
            this.lblvenda.Text = "Extorno \r\nde Vendas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.lblvenda);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 636);
            this.panel1.TabIndex = 2;
            // 
            // lblcodigovenda
            // 
            this.lblcodigovenda.AutoSize = true;
            this.lblcodigovenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigovenda.Location = new System.Drawing.Point(230, 2);
            this.lblcodigovenda.Name = "lblcodigovenda";
            this.lblcodigovenda.Size = new System.Drawing.Size(62, 20);
            this.lblcodigovenda.TabIndex = 3;
            this.lblcodigovenda.Text = "Cliente:";
            // 
            // cbocodigovenda
            // 
            this.cbocodigovenda.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbocodigovenda.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbocodigovenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbocodigovenda.FormattingEnabled = true;
            this.cbocodigovenda.Location = new System.Drawing.Point(234, 25);
            this.cbocodigovenda.Name = "cbocodigovenda";
            this.cbocodigovenda.Size = new System.Drawing.Size(209, 28);
            this.cbocodigovenda.TabIndex = 4;
            // 
            // gbdetalhes
            // 
            this.gbdetalhes.Controls.Add(this.gblistadeitens);
            this.gbdetalhes.Controls.Add(this.dgvvendas);
            this.gbdetalhes.Controls.Add(this.btnextornar);
            this.gbdetalhes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbdetalhes.Location = new System.Drawing.Point(223, 54);
            this.gbdetalhes.Name = "gbdetalhes";
            this.gbdetalhes.Size = new System.Drawing.Size(1085, 570);
            this.gbdetalhes.TabIndex = 5;
            this.gbdetalhes.TabStop = false;
            this.gbdetalhes.Text = "Vendas";
            // 
            // btndesfazerfiltros
            // 
            this.btndesfazerfiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndesfazerfiltros.Location = new System.Drawing.Point(672, 14);
            this.btndesfazerfiltros.Name = "btndesfazerfiltros";
            this.btndesfazerfiltros.Size = new System.Drawing.Size(188, 42);
            this.btndesfazerfiltros.TabIndex = 11;
            this.btndesfazerfiltros.Text = "<< Desfazer Filtros  >>";
            this.btndesfazerfiltros.UseVisualStyleBackColor = true;
            this.btndesfazerfiltros.Click += new System.EventHandler(this.btndesfazerfiltros_Click);
            // 
            // gblistadeitens
            // 
            this.gblistadeitens.Controls.Add(this.dgvlistadeitens);
            this.gblistadeitens.Location = new System.Drawing.Point(0, 296);
            this.gblistadeitens.Name = "gblistadeitens";
            this.gblistadeitens.Size = new System.Drawing.Size(1085, 274);
            this.gblistadeitens.TabIndex = 2;
            this.gblistadeitens.TabStop = false;
            this.gblistadeitens.Text = "Lista de Itens";
            // 
            // dgvlistadeitens
            // 
            this.dgvlistadeitens.AllowUserToAddRows = false;
            this.dgvlistadeitens.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvlistadeitens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvlistadeitens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvlistadeitens.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvlistadeitens.Location = new System.Drawing.Point(6, 25);
            this.dgvlistadeitens.Name = "dgvlistadeitens";
            this.dgvlistadeitens.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvlistadeitens.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvlistadeitens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvlistadeitens.Size = new System.Drawing.Size(1067, 243);
            this.dgvlistadeitens.TabIndex = 0;
            // 
            // dgvvendas
            // 
            this.dgvvendas.AllowUserToAddRows = false;
            this.dgvvendas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvvendas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvvendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvvendas.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvvendas.Location = new System.Drawing.Point(6, 19);
            this.dgvvendas.Name = "dgvvendas";
            this.dgvvendas.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvvendas.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvvendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvvendas.Size = new System.Drawing.Size(1067, 222);
            this.dgvvendas.TabIndex = 0;
            this.dgvvendas.Click += new System.EventHandler(this.dgvvendas_Click);
            // 
            // btnconsultar
            // 
            this.btnconsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconsultar.Location = new System.Drawing.Point(460, 23);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(107, 31);
            this.btnconsultar.TabIndex = 6;
            this.btnconsultar.Text = "&Consultar";
            this.btnconsultar.UseVisualStyleBackColor = true;
            this.btnconsultar.Click += new System.EventHandler(this.btnconsultar_Click);
            // 
            // btnextornar
            // 
            this.btnextornar.Location = new System.Drawing.Point(448, 254);
            this.btnextornar.Name = "btnextornar";
            this.btnextornar.Size = new System.Drawing.Size(130, 39);
            this.btnextornar.TabIndex = 7;
            this.btnextornar.Text = "&Extornar Venda";
            this.btnextornar.UseVisualStyleBackColor = true;
            this.btnextornar.Click += new System.EventHandler(this.btnextornar_Click);
            // 
            // cbodatadavenda
            // 
            this.cbodatadavenda.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbodatadavenda.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbodatadavenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbodatadavenda.FormattingEnabled = true;
            this.cbodatadavenda.Location = new System.Drawing.Point(1023, 27);
            this.cbodatadavenda.Name = "cbodatadavenda";
            this.cbodatadavenda.Size = new System.Drawing.Size(126, 28);
            this.cbodatadavenda.TabIndex = 8;
            // 
            // lbldatadavenda
            // 
            this.lbldatadavenda.AutoSize = true;
            this.lbldatadavenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldatadavenda.Location = new System.Drawing.Point(1019, 4);
            this.lbldatadavenda.Name = "lbldatadavenda";
            this.lbldatadavenda.Size = new System.Drawing.Size(121, 20);
            this.lbldatadavenda.TabIndex = 9;
            this.lbldatadavenda.Text = "Data da Venda:";
            // 
            // btnconsultardata
            // 
            this.btnconsultardata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconsultardata.Location = new System.Drawing.Point(1165, 25);
            this.btnconsultardata.Name = "btnconsultardata";
            this.btnconsultardata.Size = new System.Drawing.Size(107, 31);
            this.btnconsultardata.TabIndex = 10;
            this.btnconsultardata.Text = "Con&sultar";
            this.btnconsultardata.UseVisualStyleBackColor = true;
            this.btnconsultardata.Click += new System.EventHandler(this.btnconsultardata_Click);
            // 
            // FrmExtornovendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 636);
            this.Controls.Add(this.btndesfazerfiltros);
            this.Controls.Add(this.btnconsultardata);
            this.Controls.Add(this.lbldatadavenda);
            this.Controls.Add(this.cbodatadavenda);
            this.Controls.Add(this.btnconsultar);
            this.Controls.Add(this.gbdetalhes);
            this.Controls.Add(this.cbocodigovenda);
            this.Controls.Add(this.lblcodigovenda);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "FrmExtornovendas";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmExtornovendas";
            this.Load += new System.EventHandler(this.FrmExtornovendas_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmExtornovendas_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbdetalhes.ResumeLayout(false);
            this.gblistadeitens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistadeitens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblvenda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblcodigovenda;
        private System.Windows.Forms.ComboBox cbocodigovenda;
        private System.Windows.Forms.GroupBox gbdetalhes;
        private System.Windows.Forms.DataGridView dgvvendas;
        private System.Windows.Forms.Button btnconsultar;
        private System.Windows.Forms.Button btnextornar;
        private System.Windows.Forms.ComboBox cbodatadavenda;
        private System.Windows.Forms.Label lbldatadavenda;
        private System.Windows.Forms.Button btnconsultardata;
        private System.Windows.Forms.GroupBox gblistadeitens;
        private System.Windows.Forms.DataGridView dgvlistadeitens;
        private System.Windows.Forms.Button btndesfazerfiltros;
    }
}