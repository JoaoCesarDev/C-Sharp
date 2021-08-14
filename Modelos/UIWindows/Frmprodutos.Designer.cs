namespace UIWindows
{
    partial class Frmprodutos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lbldescricao = new System.Windows.Forms.Label();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.lbltipo = new System.Windows.Forms.Label();
            this.txttipo = new System.Windows.Forms.TextBox();
            this.lblcategoria = new System.Windows.Forms.Label();
            this.txtcategoria = new System.Windows.Forms.TextBox();
            this.lblfabricante = new System.Windows.Forms.Label();
            this.txtfabricante = new System.Windows.Forms.TextBox();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.lblestoque = new System.Windows.Forms.Label();
            this.txtestoque = new System.Windows.Forms.TextBox();
            this.lblprecocusto = new System.Windows.Forms.Label();
            this.lblprecovenda = new System.Windows.Forms.Label();
            this.mktprecovenda = new System.Windows.Forms.MaskedTextBox();
            this.lblfornecedor = new System.Windows.Forms.Label();
            this.cbofornecedor = new System.Windows.Forms.ComboBox();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.txtprecocusto = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 259);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produtos";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(221, 26);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(55, 20);
            this.lblnome.TabIndex = 3;
            this.lblnome.Text = "Nome:";
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(224, 45);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(235, 26);
            this.txtnome.TabIndex = 1;
            // 
            // lbldescricao
            // 
            this.lbldescricao.AutoSize = true;
            this.lbldescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescricao.Location = new System.Drawing.Point(462, 25);
            this.lbldescricao.Name = "lbldescricao";
            this.lbldescricao.Size = new System.Drawing.Size(84, 20);
            this.lbldescricao.TabIndex = 5;
            this.lbldescricao.Text = "Descrição:";
            // 
            // txtdescricao
            // 
            this.txtdescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescricao.Location = new System.Drawing.Point(465, 45);
            this.txtdescricao.Multiline = true;
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(438, 26);
            this.txtdescricao.TabIndex = 2;
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipo.Location = new System.Drawing.Point(221, 74);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(43, 20);
            this.lbltipo.TabIndex = 7;
            this.lbltipo.Text = "Tipo:";
            // 
            // txttipo
            // 
            this.txttipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttipo.Location = new System.Drawing.Point(224, 94);
            this.txttipo.Name = "txttipo";
            this.txttipo.Size = new System.Drawing.Size(138, 26);
            this.txttipo.TabIndex = 3;
            // 
            // lblcategoria
            // 
            this.lblcategoria.AutoSize = true;
            this.lblcategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcategoria.Location = new System.Drawing.Point(368, 73);
            this.lblcategoria.Name = "lblcategoria";
            this.lblcategoria.Size = new System.Drawing.Size(82, 20);
            this.lblcategoria.TabIndex = 9;
            this.lblcategoria.Text = "Categoria:";
            // 
            // txtcategoria
            // 
            this.txtcategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcategoria.Location = new System.Drawing.Point(368, 94);
            this.txtcategoria.Name = "txtcategoria";
            this.txtcategoria.Size = new System.Drawing.Size(161, 26);
            this.txtcategoria.TabIndex = 4;
            // 
            // lblfabricante
            // 
            this.lblfabricante.AutoSize = true;
            this.lblfabricante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfabricante.Location = new System.Drawing.Point(646, 74);
            this.lblfabricante.Name = "lblfabricante";
            this.lblfabricante.Size = new System.Drawing.Size(89, 20);
            this.lblfabricante.TabIndex = 11;
            this.lblfabricante.Text = "Fabricante:";
            // 
            // txtfabricante
            // 
            this.txtfabricante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfabricante.Location = new System.Drawing.Point(647, 94);
            this.txtfabricante.Name = "txtfabricante";
            this.txtfabricante.Size = new System.Drawing.Size(197, 26);
            this.txtfabricante.TabIndex = 6;
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigo.Location = new System.Drawing.Point(534, 72);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(63, 20);
            this.lblcodigo.TabIndex = 12;
            this.lblcodigo.Text = "Código:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(535, 94);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(106, 26);
            this.txtcodigo.TabIndex = 5;
            // 
            // lblestoque
            // 
            this.lblestoque.AutoSize = true;
            this.lblestoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestoque.Location = new System.Drawing.Point(842, 74);
            this.lblestoque.Name = "lblestoque";
            this.lblestoque.Size = new System.Drawing.Size(73, 20);
            this.lblestoque.TabIndex = 14;
            this.lblestoque.Text = "Estoque:";
            // 
            // txtestoque
            // 
            this.txtestoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtestoque.Location = new System.Drawing.Point(850, 93);
            this.txtestoque.Name = "txtestoque";
            this.txtestoque.Size = new System.Drawing.Size(53, 29);
            this.txtestoque.TabIndex = 7;
            this.txtestoque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblprecocusto
            // 
            this.lblprecocusto.AutoSize = true;
            this.lblprecocusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprecocusto.Location = new System.Drawing.Point(426, 146);
            this.lblprecocusto.Name = "lblprecocusto";
            this.lblprecocusto.Size = new System.Drawing.Size(151, 20);
            this.lblprecocusto.TabIndex = 16;
            this.lblprecocusto.Text = "Preço de Custo:  R$";
            // 
            // lblprecovenda
            // 
            this.lblprecovenda.AutoSize = true;
            this.lblprecovenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprecovenda.Location = new System.Drawing.Point(640, 145);
            this.lblprecovenda.Name = "lblprecovenda";
            this.lblprecovenda.Size = new System.Drawing.Size(152, 20);
            this.lblprecovenda.TabIndex = 18;
            this.lblprecovenda.Text = "Preço de Venda: R$";
            // 
            // mktprecovenda
            // 
            this.mktprecovenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mktprecovenda.Location = new System.Drawing.Point(764, 143);
            this.mktprecovenda.Name = "mktprecovenda";
            this.mktprecovenda.Size = new System.Drawing.Size(89, 26);
            this.mktprecovenda.TabIndex = 10;
            this.mktprecovenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mktprecovenda.Click += new System.EventHandler(this.mktprecovenda_Click);
            // 
            // lblfornecedor
            // 
            this.lblfornecedor.AutoSize = true;
            this.lblfornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfornecedor.Location = new System.Drawing.Point(221, 124);
            this.lblfornecedor.Name = "lblfornecedor";
            this.lblfornecedor.Size = new System.Drawing.Size(95, 20);
            this.lblfornecedor.TabIndex = 19;
            this.lblfornecedor.Text = "Fornecedor:";
            // 
            // cbofornecedor
            // 
            this.cbofornecedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbofornecedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbofornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbofornecedor.FormattingEnabled = true;
            this.cbofornecedor.Location = new System.Drawing.Point(224, 143);
            this.cbofornecedor.Name = "cbofornecedor";
            this.cbofornecedor.Size = new System.Drawing.Size(196, 28);
            this.cbofornecedor.TabIndex = 8;
            // 
            // btncadastrar
            // 
            this.btncadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadastrar.Location = new System.Drawing.Point(225, 197);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(145, 38);
            this.btncadastrar.TabIndex = 11;
            this.btncadastrar.Text = "Cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = true;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // txtprecocusto
            // 
            this.txtprecocusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprecocusto.Location = new System.Drawing.Point(547, 143);
            this.txtprecocusto.Name = "txtprecocusto";
            this.txtprecocusto.Size = new System.Drawing.Size(87, 26);
            this.txtprecocusto.TabIndex = 9;
            this.txtprecocusto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtprecocusto.Click += new System.EventHandler(this.txtprecocusto_Click);
            // 
            // Frmprodutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 259);
            this.Controls.Add(this.txtprecocusto);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.cbofornecedor);
            this.Controls.Add(this.lblfornecedor);
            this.Controls.Add(this.mktprecovenda);
            this.Controls.Add(this.lblprecovenda);
            this.Controls.Add(this.lblprecocusto);
            this.Controls.Add(this.txtestoque);
            this.Controls.Add(this.lblestoque);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.lblcodigo);
            this.Controls.Add(this.txtfabricante);
            this.Controls.Add(this.lblfabricante);
            this.Controls.Add(this.txtcategoria);
            this.Controls.Add(this.lblcategoria);
            this.Controls.Add(this.txttipo);
            this.Controls.Add(this.lbltipo);
            this.Controls.Add(this.txtdescricao);
            this.Controls.Add(this.lbldescricao);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "Frmprodutos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.Frmprodutos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frmprodutos_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label lbldescricao;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.TextBox txttipo;
        private System.Windows.Forms.Label lblcategoria;
        private System.Windows.Forms.TextBox txtcategoria;
        private System.Windows.Forms.Label lblfabricante;
        private System.Windows.Forms.TextBox txtfabricante;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label lblestoque;
        private System.Windows.Forms.TextBox txtestoque;
        private System.Windows.Forms.Label lblprecocusto;
        private System.Windows.Forms.Label lblprecovenda;
        private System.Windows.Forms.MaskedTextBox mktprecovenda;
        private System.Windows.Forms.Label lblfornecedor;
        private System.Windows.Forms.ComboBox cbofornecedor;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.TextBox txtprecocusto;
    }
}