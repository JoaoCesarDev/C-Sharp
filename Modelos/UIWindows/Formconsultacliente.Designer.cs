namespace UIWindows
{
    partial class Formconsultacliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbltitulocliente = new System.Windows.Forms.Label();
            this.txtcamponome = new System.Windows.Forms.TextBox();
            this.btnconsultar = new System.Windows.Forms.Button();
            this.dgvconsultacliente = new System.Windows.Forms.DataGridView();
            this.btndesfazer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnalterar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsultacliente)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.lbltitulocliente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 546);
            this.panel1.TabIndex = 2;
            // 
            // lbltitulocliente
            // 
            this.lbltitulocliente.AutoSize = true;
            this.lbltitulocliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulocliente.ForeColor = System.Drawing.Color.White;
            this.lbltitulocliente.Location = new System.Drawing.Point(22, 9);
            this.lbltitulocliente.Name = "lbltitulocliente";
            this.lbltitulocliente.Size = new System.Drawing.Size(151, 39);
            this.lbltitulocliente.TabIndex = 0;
            this.lbltitulocliente.Text = "Clientes";
            // 
            // txtcamponome
            // 
            this.txtcamponome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcamponome.Location = new System.Drawing.Point(60, 25);
            this.txtcamponome.Name = "txtcamponome";
            this.txtcamponome.Size = new System.Drawing.Size(258, 26);
            this.txtcamponome.TabIndex = 3;
            // 
            // btnconsultar
            // 
            this.btnconsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconsultar.Location = new System.Drawing.Point(335, 23);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(89, 30);
            this.btnconsultar.TabIndex = 4;
            this.btnconsultar.Text = "Consultar";
            this.btnconsultar.UseVisualStyleBackColor = true;
            this.btnconsultar.Click += new System.EventHandler(this.btnconsultar_Click);
            // 
            // dgvconsultacliente
            // 
            this.dgvconsultacliente.AllowUserToAddRows = false;
            this.dgvconsultacliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvconsultacliente.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvconsultacliente.Location = new System.Drawing.Point(206, 97);
            this.dgvconsultacliente.Name = "dgvconsultacliente";
            this.dgvconsultacliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvconsultacliente.Size = new System.Drawing.Size(1106, 445);
            this.dgvconsultacliente.TabIndex = 5;
            // 
            // btndesfazer
            // 
            this.btndesfazer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndesfazer.Location = new System.Drawing.Point(335, 23);
            this.btndesfazer.Name = "btndesfazer";
            this.btndesfazer.Size = new System.Drawing.Size(89, 30);
            this.btndesfazer.TabIndex = 6;
            this.btndesfazer.Text = "Desfazer";
            this.btndesfazer.UseVisualStyleBackColor = true;
            this.btndesfazer.Visible = false;
            this.btndesfazer.Click += new System.EventHandler(this.btndesfazer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtcamponome);
            this.groupBox1.Controls.Add(this.btndesfazer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnconsultar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(206, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 67);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Localizar";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnexcluir);
            this.groupBox2.Controls.Add(this.btnalterar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(820, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 67);
            this.groupBox2.TabIndex = 14;
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
            // Formconsultacliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 546);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvconsultacliente);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Formconsultacliente";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Clientes";
            this.Load += new System.EventHandler(this.Formconsultacliente_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Formconsultacliente_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsultacliente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbltitulocliente;
        private System.Windows.Forms.TextBox txtcamponome;
        private System.Windows.Forms.Button btnconsultar;
        private System.Windows.Forms.DataGridView dgvconsultacliente;
        private System.Windows.Forms.Button btndesfazer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnexcluir;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Button btnalterar;
    }
}