namespace APRESENTAÇÃO
{
    partial class frmconfig
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.lblusuario = new System.Windows.Forms.Label();
            this.txtdatabase = new System.Windows.Forms.TextBox();
            this.lbldatabase = new System.Windows.Forms.Label();
            this.lblservidor = new System.Windows.Forms.Label();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.brnfechar = new System.Windows.Forms.Button();
            this.cboserver = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboserver);
            this.groupBox1.Controls.Add(this.txtsenha);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtusuario);
            this.groupBox1.Controls.Add(this.lblusuario);
            this.groupBox1.Controls.Add(this.txtdatabase);
            this.groupBox1.Controls.Add(this.lbldatabase);
            this.groupBox1.Controls.Add(this.lblservidor);
            this.groupBox1.Location = new System.Drawing.Point(19, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 162);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configurações de Conexão com o SGBD";
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(94, 126);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(110, 20);
            this.txtsenha.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Senha:";
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(94, 94);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(110, 20);
            this.txtusuario.TabIndex = 5;
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.Location = new System.Drawing.Point(19, 96);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(58, 16);
            this.lblusuario.TabIndex = 4;
            this.lblusuario.Text = "Usuário:";
            // 
            // txtdatabase
            // 
            this.txtdatabase.Location = new System.Drawing.Point(94, 63);
            this.txtdatabase.Name = "txtdatabase";
            this.txtdatabase.Size = new System.Drawing.Size(110, 20);
            this.txtdatabase.TabIndex = 3;
            // 
            // lbldatabase
            // 
            this.lbldatabase.AutoSize = true;
            this.lbldatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldatabase.Location = new System.Drawing.Point(19, 63);
            this.lbldatabase.Name = "lbldatabase";
            this.lbldatabase.Size = new System.Drawing.Size(71, 16);
            this.lbldatabase.TabIndex = 2;
            this.lbldatabase.Text = "Database:";
            // 
            // lblservidor
            // 
            this.lblservidor.AutoSize = true;
            this.lblservidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblservidor.Location = new System.Drawing.Point(19, 32);
            this.lblservidor.Name = "lblservidor";
            this.lblservidor.Size = new System.Drawing.Size(46, 16);
            this.lblservidor.TabIndex = 0;
            this.lblservidor.Text = "server";
            // 
            // btnsalvar
            // 
            this.btnsalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalvar.Location = new System.Drawing.Point(22, 204);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(98, 31);
            this.btnsalvar.TabIndex = 8;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // brnfechar
            // 
            this.brnfechar.Location = new System.Drawing.Point(154, 204);
            this.brnfechar.Name = "brnfechar";
            this.brnfechar.Size = new System.Drawing.Size(98, 31);
            this.brnfechar.TabIndex = 9;
            this.brnfechar.Text = "Fechar";
            this.brnfechar.UseVisualStyleBackColor = true;
            this.brnfechar.Click += new System.EventHandler(this.brnfechar_Click);
            // 
            // cboserver
            // 
            this.cboserver.FormattingEnabled = true;
            this.cboserver.Location = new System.Drawing.Point(94, 34);
            this.cboserver.Name = "cboserver";
            this.cboserver.Size = new System.Drawing.Size(110, 21);
            this.cboserver.TabIndex = 8;
            // 
            // frmconfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 247);
            this.Controls.Add(this.brnfechar);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmconfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações de Conexão";
            this.Load += new System.EventHandler(this.frmconfig_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.TextBox txtdatabase;
        private System.Windows.Forms.Label lbldatabase;
        private System.Windows.Forms.Label lblservidor;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Button brnfechar;
        private System.Windows.Forms.ComboBox cboserver;
    }
}