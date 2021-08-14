namespace UIWindows
{
    partial class Frmconsultaprodutos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.txtconsultaproduto = new System.Windows.Forms.TextBox();
            this.btnconsultar = new System.Windows.Forms.Button();
            this.btndesfazer = new System.Windows.Forms.Button();
            this.dgvconsultaprodutos = new System.Windows.Forms.DataGridView();
            this.gbbuscar = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnalterar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsultaprodutos)).BeginInit();
            this.gbbuscar.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 610);
            this.panel1.TabIndex = 1;
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
            this.lblnome.Location = new System.Drawing.Point(7, 17);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(55, 20);
            this.lblnome.TabIndex = 2;
            this.lblnome.Text = "Nome:";
            // 
            // txtconsultaproduto
            // 
            this.txtconsultaproduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconsultaproduto.Location = new System.Drawing.Point(60, 16);
            this.txtconsultaproduto.Name = "txtconsultaproduto";
            this.txtconsultaproduto.Size = new System.Drawing.Size(237, 26);
            this.txtconsultaproduto.TabIndex = 3;
            // 
            // btnconsultar
            // 
            this.btnconsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconsultar.Location = new System.Drawing.Point(315, 13);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(104, 30);
            this.btnconsultar.TabIndex = 4;
            this.btnconsultar.Text = "Consultar";
            this.btnconsultar.UseVisualStyleBackColor = true;
            this.btnconsultar.Click += new System.EventHandler(this.btnconsultar_Click);
            // 
            // btndesfazer
            // 
            this.btndesfazer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndesfazer.Location = new System.Drawing.Point(315, 12);
            this.btndesfazer.Name = "btndesfazer";
            this.btndesfazer.Size = new System.Drawing.Size(104, 32);
            this.btndesfazer.TabIndex = 5;
            this.btndesfazer.Text = "Desfazer";
            this.btndesfazer.UseVisualStyleBackColor = true;
            this.btndesfazer.Visible = false;
            this.btndesfazer.Click += new System.EventHandler(this.btndesfazer_Click);
            // 
            // dgvconsultaprodutos
            // 
            this.dgvconsultaprodutos.AllowUserToAddRows = false;
            this.dgvconsultaprodutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvconsultaprodutos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvconsultaprodutos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvconsultaprodutos.Location = new System.Drawing.Point(206, 90);
            this.dgvconsultaprodutos.Name = "dgvconsultaprodutos";
            this.dgvconsultaprodutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvconsultaprodutos.Size = new System.Drawing.Size(1170, 516);
            this.dgvconsultaprodutos.TabIndex = 6;
            this.dgvconsultaprodutos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvconsultaprodutos_CellFormatting);
            this.dgvconsultaprodutos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvconsultaprodutos_CellMouseDoubleClick);
           
            // 
            // gbbuscar
            // 
            this.gbbuscar.Controls.Add(this.txtconsultaproduto);
            this.gbbuscar.Controls.Add(this.lblnome);
            this.gbbuscar.Controls.Add(this.btnconsultar);
            this.gbbuscar.Controls.Add(this.btndesfazer);
            this.gbbuscar.Location = new System.Drawing.Point(206, 22);
            this.gbbuscar.Name = "gbbuscar";
            this.gbbuscar.Size = new System.Drawing.Size(428, 51);
            this.gbbuscar.TabIndex = 36;
            this.gbbuscar.TabStop = false;
            this.gbbuscar.Text = "Localizar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnexcluir);
            this.groupBox2.Controls.Add(this.btnalterar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(853, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 67);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alterar ou Excluir Registros";
            // 
            // btnexcluir
            // 
            this.btnexcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcluir.Location = new System.Drawing.Point(206, 26);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(145, 31);
            this.btnexcluir.TabIndex = 14;
            this.btnexcluir.Text = "&Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btnalterar
            // 
            this.btnalterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnalterar.Location = new System.Drawing.Point(23, 26);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(145, 30);
            this.btnalterar.TabIndex = 13;
            this.btnalterar.Text = "&Alterar";
            this.btnalterar.UseVisualStyleBackColor = true;
            this.btnalterar.Click += new System.EventHandler(this.btnalterar_Click);
            // 
            // Frmconsultaprodutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 610);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbbuscar);
            this.Controls.Add(this.dgvconsultaprodutos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frmconsultaprodutos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frmconsultaprodutos";
            this.Load += new System.EventHandler(this.Frmconsultaprodutos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frmconsultaprodutos_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsultaprodutos)).EndInit();
            this.gbbuscar.ResumeLayout(false);
            this.gbbuscar.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.TextBox txtconsultaproduto;
        private System.Windows.Forms.Button btnconsultar;
        private System.Windows.Forms.Button btndesfazer;
        private System.Windows.Forms.DataGridView dgvconsultaprodutos;
        private System.Windows.Forms.GroupBox gbbuscar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnalterar;
    }
}