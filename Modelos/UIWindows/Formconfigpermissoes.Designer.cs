namespace UIWindows
{
    partial class Formconfigpermissoes
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
            this.cboperfil = new System.Windows.Forms.ComboBox();
            this.lblusuarios = new System.Windows.Forms.Label();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.gbpermissoes = new System.Windows.Forms.GroupBox();
            this.chkExcluir = new System.Windows.Forms.CheckBox();
            this.chkalterar = new System.Windows.Forms.CheckBox();
            this.chkcadastrar = new System.Windows.Forms.CheckBox();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.gbpermissoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboperfil
            // 
            this.cboperfil.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboperfil.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboperfil.FormattingEnabled = true;
            this.cboperfil.Location = new System.Drawing.Point(88, 32);
            this.cboperfil.Name = "cboperfil";
            this.cboperfil.Size = new System.Drawing.Size(181, 21);
            this.cboperfil.TabIndex = 1;
            this.cboperfil.SelectedIndexChanged += new System.EventHandler(this.cboperfil_SelectedIndexChanged);
            // 
            // lblusuarios
            // 
            this.lblusuarios.AutoSize = true;
            this.lblusuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuarios.Location = new System.Drawing.Point(40, 31);
            this.lblusuarios.Name = "lblusuarios";
            this.lblusuarios.Size = new System.Drawing.Size(48, 20);
            this.lblusuarios.TabIndex = 2;
            this.lblusuarios.Text = "Perfil:";
            // 
            // btnmodificar
            // 
            this.btnmodificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificar.Location = new System.Drawing.Point(66, 261);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(94, 32);
            this.btnmodificar.TabIndex = 3;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // gbpermissoes
            // 
            this.gbpermissoes.Controls.Add(this.chkExcluir);
            this.gbpermissoes.Controls.Add(this.chkalterar);
            this.gbpermissoes.Controls.Add(this.chkcadastrar);
            this.gbpermissoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbpermissoes.Location = new System.Drawing.Point(78, 81);
            this.gbpermissoes.Name = "gbpermissoes";
            this.gbpermissoes.Size = new System.Drawing.Size(191, 155);
            this.gbpermissoes.TabIndex = 9;
            this.gbpermissoes.TabStop = false;
            this.gbpermissoes.Text = "Permissões";
            // 
            // chkExcluir
            // 
            this.chkExcluir.AutoSize = true;
            this.chkExcluir.Location = new System.Drawing.Point(55, 115);
            this.chkExcluir.Name = "chkExcluir";
            this.chkExcluir.Size = new System.Drawing.Size(74, 24);
            this.chkExcluir.TabIndex = 2;
            this.chkExcluir.Text = "Excluir";
            this.chkExcluir.UseVisualStyleBackColor = true;
            // 
            // chkalterar
            // 
            this.chkalterar.AutoSize = true;
            this.chkalterar.Location = new System.Drawing.Point(55, 74);
            this.chkalterar.Name = "chkalterar";
            this.chkalterar.Size = new System.Drawing.Size(75, 24);
            this.chkalterar.TabIndex = 1;
            this.chkalterar.Text = "Alterar";
            this.chkalterar.UseVisualStyleBackColor = true;
            // 
            // chkcadastrar
            // 
            this.chkcadastrar.AutoSize = true;
            this.chkcadastrar.Location = new System.Drawing.Point(55, 35);
            this.chkcadastrar.Name = "chkcadastrar";
            this.chkcadastrar.Size = new System.Drawing.Size(98, 24);
            this.chkcadastrar.TabIndex = 0;
            this.chkcadastrar.Text = "Cadastrar";
            this.chkcadastrar.UseVisualStyleBackColor = true;
            // 
            // btnexcluir
            // 
            this.btnexcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcluir.Location = new System.Drawing.Point(177, 261);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(103, 32);
            this.btnexcluir.TabIndex = 10;
            this.btnexcluir.Text = "Excluir Perfil";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // Formconfigpermissoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 309);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.gbpermissoes);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.lblusuarios);
            this.Controls.Add(this.cboperfil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Formconfigpermissoes";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurar Permissões";
            this.Load += new System.EventHandler(this.Formconfigpermissoes_Load);
            this.gbpermissoes.ResumeLayout(false);
            this.gbpermissoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboperfil;
        private System.Windows.Forms.Label lblusuarios;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.GroupBox gbpermissoes;
        private System.Windows.Forms.CheckBox chkExcluir;
        private System.Windows.Forms.CheckBox chkalterar;
        private System.Windows.Forms.CheckBox chkcadastrar;
        private System.Windows.Forms.Button btnexcluir;
    }
}