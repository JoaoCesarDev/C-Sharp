namespace APRESENTAÇÃO
{
    partial class frmrentbike
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.btnconfig = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnfechar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnprodutos = new System.Windows.Forms.Button();
            this.btnbikes = new System.Windows.Forms.Button();
            this.btnclientes = new System.Windows.Forms.Button();
            this.panelconteudo = new System.Windows.Forms.Panel();
            this.panelCabecalho.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.BackColor = System.Drawing.Color.Goldenrod;
            this.panelCabecalho.Controls.Add(this.btnconfig);
            this.panelCabecalho.Controls.Add(this.label1);
            this.panelCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecalho.Location = new System.Drawing.Point(0, 0);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(922, 41);
            this.panelCabecalho.TabIndex = 0;
            this.panelCabecalho.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCabecalho_Paint);
            // 
            // btnconfig
            // 
            this.btnconfig.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnconfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconfig.Location = new System.Drawing.Point(816, 0);
            this.btnconfig.Name = "btnconfig";
            this.btnconfig.Size = new System.Drawing.Size(106, 41);
            this.btnconfig.TabIndex = 2;
            this.btnconfig.Text = "Configurações";
            this.btnconfig.UseVisualStyleBackColor = true;
            this.btnconfig.Click += new System.EventHandler(this.btnconfig_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, -6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loja Bike Master";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.MenuText;
            this.panelMenu.Controls.Add(this.btnfechar);
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.btnprodutos);
            this.panelMenu.Controls.Add(this.btnbikes);
            this.panelMenu.Controls.Add(this.btnclientes);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 41);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(239, 498);
            this.panelMenu.TabIndex = 1;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // btnfechar
            // 
            this.btnfechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnfechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfechar.Location = new System.Drawing.Point(12, 454);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(208, 32);
            this.btnfechar.TabIndex = 3;
            this.btnfechar.Text = "Sair";
            this.btnfechar.UseVisualStyleBackColor = true;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(20, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 60);
            this.button1.TabIndex = 2;
            this.button1.Text = "         Vendas";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnprodutos
            // 
            this.btnprodutos.BackColor = System.Drawing.Color.Black;
            this.btnprodutos.FlatAppearance.BorderSize = 0;
            this.btnprodutos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnprodutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprodutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprodutos.ForeColor = System.Drawing.Color.White;
            this.btnprodutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnprodutos.Location = new System.Drawing.Point(16, 256);
            this.btnprodutos.Name = "btnprodutos";
            this.btnprodutos.Size = new System.Drawing.Size(199, 66);
            this.btnprodutos.TabIndex = 2;
            this.btnprodutos.Text = "Produtos";
            this.btnprodutos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnprodutos.UseVisualStyleBackColor = false;
            this.btnprodutos.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnbikes
            // 
            this.btnbikes.BackColor = System.Drawing.Color.Black;
            this.btnbikes.FlatAppearance.BorderSize = 0;
            this.btnbikes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnbikes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbikes.ForeColor = System.Drawing.Color.White;
            this.btnbikes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbikes.Location = new System.Drawing.Point(12, 150);
            this.btnbikes.Name = "btnbikes";
            this.btnbikes.Size = new System.Drawing.Size(227, 70);
            this.btnbikes.TabIndex = 2;
            this.btnbikes.Text = "           Fornecedores";
            this.btnbikes.UseVisualStyleBackColor = false;
            this.btnbikes.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnclientes
            // 
            this.btnclientes.BackColor = System.Drawing.Color.Black;
            this.btnclientes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnclientes.FlatAppearance.BorderSize = 0;
            this.btnclientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnclientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnclientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclientes.ForeColor = System.Drawing.Color.White;
            this.btnclientes.Image = global::APRESENTAÇÃO.Properties.Resources.users_icon_icons1;
            this.btnclientes.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnclientes.Location = new System.Drawing.Point(20, 61);
            this.btnclientes.Name = "btnclientes";
            this.btnclientes.Size = new System.Drawing.Size(200, 49);
            this.btnclientes.TabIndex = 0;
            this.btnclientes.Text = "             Clientes";
            this.btnclientes.UseVisualStyleBackColor = false;
            this.btnclientes.Click += new System.EventHandler(this.btnclientes_Click);
            // 
            // panelconteudo
            // 
            this.panelconteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelconteudo.Location = new System.Drawing.Point(239, 41);
            this.panelconteudo.Name = "panelconteudo";
            this.panelconteudo.Size = new System.Drawing.Size(683, 498);
            this.panelconteudo.TabIndex = 2;
            this.panelconteudo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelconteudo_Paint);
            // 
            // frmrentbike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 539);
            this.Controls.Add(this.panelconteudo);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmrentbike";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rent Bike";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.panelCabecalho.ResumeLayout(false);
            this.panelCabecalho.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCabecalho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnclientes;
        private System.Windows.Forms.Button btnbikes;
        private System.Windows.Forms.Button btnprodutos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelconteudo;
        private System.Windows.Forms.Button btnfechar;
        private System.Windows.Forms.Button btnconfig;
    }
}

