namespace UIWindows
{
    partial class Formperfil
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
            this.lblnome = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbltitulocliente = new System.Windows.Forms.Label();
            this.gbpermissoes = new System.Windows.Forms.GroupBox();
            this.chkExcluir = new System.Windows.Forms.CheckBox();
            this.chkalterar = new System.Windows.Forms.CheckBox();
            this.chkcadastrar = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.gbpermissoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(173, 25);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(48, 20);
            this.lblnome.TabIndex = 0;
            this.lblnome.Text = "Perfil:";
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(219, 23);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(160, 26);
            this.txtnome.TabIndex = 1;
            // 
            // btncadastrar
            // 
            this.btncadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadastrar.Location = new System.Drawing.Point(228, 251);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(108, 36);
            this.btncadastrar.TabIndex = 6;
            this.btncadastrar.Text = "Cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = true;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.lbltitulocliente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 299);
            this.panel1.TabIndex = 7;
            // 
            // lbltitulocliente
            // 
            this.lbltitulocliente.AutoSize = true;
            this.lbltitulocliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulocliente.ForeColor = System.Drawing.Color.White;
            this.lbltitulocliente.Location = new System.Drawing.Point(22, 10);
            this.lbltitulocliente.Name = "lbltitulocliente";
            this.lbltitulocliente.Size = new System.Drawing.Size(113, 39);
            this.lbltitulocliente.TabIndex = 0;
            this.lbltitulocliente.Text = "Perfis";
            // 
            // gbpermissoes
            // 
            this.gbpermissoes.Controls.Add(this.chkExcluir);
            this.gbpermissoes.Controls.Add(this.chkalterar);
            this.gbpermissoes.Controls.Add(this.chkcadastrar);
            this.gbpermissoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbpermissoes.Location = new System.Drawing.Point(188, 72);
            this.gbpermissoes.Name = "gbpermissoes";
            this.gbpermissoes.Size = new System.Drawing.Size(191, 164);
            this.gbpermissoes.TabIndex = 8;
            this.gbpermissoes.TabStop = false;
            this.gbpermissoes.Text = "Permissões";
            // 
            // chkExcluir
            // 
            this.chkExcluir.AutoSize = true;
            this.chkExcluir.Location = new System.Drawing.Point(31, 115);
            this.chkExcluir.Name = "chkExcluir";
            this.chkExcluir.Size = new System.Drawing.Size(74, 24);
            this.chkExcluir.TabIndex = 2;
            this.chkExcluir.Text = "Excluir";
            this.chkExcluir.UseVisualStyleBackColor = true;
            // 
            // chkalterar
            // 
            this.chkalterar.AutoSize = true;
            this.chkalterar.Location = new System.Drawing.Point(31, 74);
            this.chkalterar.Name = "chkalterar";
            this.chkalterar.Size = new System.Drawing.Size(75, 24);
            this.chkalterar.TabIndex = 1;
            this.chkalterar.Text = "Alterar";
            this.chkalterar.UseVisualStyleBackColor = true;
            // 
            // chkcadastrar
            // 
            this.chkcadastrar.AutoSize = true;
            this.chkcadastrar.Location = new System.Drawing.Point(31, 35);
            this.chkcadastrar.Name = "chkcadastrar";
            this.chkcadastrar.Size = new System.Drawing.Size(98, 24);
            this.chkcadastrar.TabIndex = 0;
            this.chkcadastrar.Text = "Cadastrar";
            this.chkcadastrar.UseVisualStyleBackColor = true;
            // 
            // Formperfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 299);
            this.Controls.Add(this.gbpermissoes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lblnome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Formperfil";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfil";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbpermissoes.ResumeLayout(false);
            this.gbpermissoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbltitulocliente;
        private System.Windows.Forms.GroupBox gbpermissoes;
        private System.Windows.Forms.CheckBox chkExcluir;
        private System.Windows.Forms.CheckBox chkalterar;
        private System.Windows.Forms.CheckBox chkcadastrar;
    }
}