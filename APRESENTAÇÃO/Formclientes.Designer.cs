namespace APRESENTAÇÃO
{
    partial class Formclientes
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
            this.lbltitulocliente = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblnome = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lblend = new System.Windows.Forms.Label();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.btnfechar = new System.Windows.Forms.Button();
            this.lblbairro = new System.Windows.Forms.Label();
            this.txtbairro = new System.Windows.Forms.TextBox();
            this.lblcidade = new System.Windows.Forms.Label();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.txttelefone = new System.Windows.Forms.TextBox();
            this.lbltelefone = new System.Windows.Forms.Label();
            this.lblcelular = new System.Windows.Forms.Label();
            this.txtcelular = new System.Windows.Forms.TextBox();
            this.lblcpf = new System.Windows.Forms.Label();
            this.txtcpf = new System.Windows.Forms.TextBox();
            this.lblrg = new System.Windows.Forms.Label();
            this.txtrg = new System.Windows.Forms.TextBox();
            this.lblcep = new System.Windows.Forms.Label();
            this.txtcep = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lbldata = new System.Windows.Forms.Label();
            this.txtdata = new System.Windows.Forms.TextBox();
            this.gbclientes = new System.Windows.Forms.GroupBox();
            this.btnler = new System.Windows.Forms.Button();
            this.dgvclientes = new System.Windows.Forms.DataGridView();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.btnalterar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.lblestado = new System.Windows.Forms.Label();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.gbclientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvclientes)).BeginInit();
            this.SuspendLayout();
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
            this.lbltitulocliente.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.lbltitulocliente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 637);
            this.panel1.TabIndex = 1;
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(329, 31);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(38, 13);
            this.lblnome.TabIndex = 2;
            this.lblnome.Text = "Nome:";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(373, 28);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(214, 20);
            this.txtnome.TabIndex = 3;
            // 
            // lblend
            // 
            this.lblend.AutoSize = true;
            this.lblend.Location = new System.Drawing.Point(207, 65);
            this.lblend.Name = "lblend";
            this.lblend.Size = new System.Drawing.Size(56, 13);
            this.lblend.TabIndex = 4;
            this.lblend.Text = "Endereço:";
            // 
            // txtendereco
            // 
            this.txtendereco.Location = new System.Drawing.Point(271, 62);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(193, 20);
            this.txtendereco.TabIndex = 5;
            // 
            // btnfechar
            // 
            this.btnfechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnfechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfechar.Location = new System.Drawing.Point(849, 604);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(183, 30);
            this.btnfechar.TabIndex = 6;
            this.btnfechar.Text = "Fechar";
            this.btnfechar.UseVisualStyleBackColor = true;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // lblbairro
            // 
            this.lblbairro.AutoSize = true;
            this.lblbairro.Location = new System.Drawing.Point(470, 65);
            this.lblbairro.Name = "lblbairro";
            this.lblbairro.Size = new System.Drawing.Size(37, 13);
            this.lblbairro.TabIndex = 7;
            this.lblbairro.Text = "Bairro:";
            // 
            // txtbairro
            // 
            this.txtbairro.Location = new System.Drawing.Point(513, 62);
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(102, 20);
            this.txtbairro.TabIndex = 8;
            // 
            // lblcidade
            // 
            this.lblcidade.AutoSize = true;
            this.lblcidade.Location = new System.Drawing.Point(624, 67);
            this.lblcidade.Name = "lblcidade";
            this.lblcidade.Size = new System.Drawing.Size(43, 13);
            this.lblcidade.TabIndex = 9;
            this.lblcidade.Text = "Cidade:";
            // 
            // txtcidade
            // 
            this.txtcidade.Location = new System.Drawing.Point(673, 62);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(100, 20);
            this.txtcidade.TabIndex = 10;
            // 
            // txttelefone
            // 
            this.txttelefone.Location = new System.Drawing.Point(289, 95);
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.Size = new System.Drawing.Size(91, 20);
            this.txttelefone.TabIndex = 11;
            // 
            // lbltelefone
            // 
            this.lbltelefone.AutoSize = true;
            this.lbltelefone.Location = new System.Drawing.Point(207, 97);
            this.lbltelefone.Name = "lbltelefone";
            this.lbltelefone.Size = new System.Drawing.Size(74, 13);
            this.lbltelefone.TabIndex = 12;
            this.lbltelefone.Text = "Telefone Fixo:";
            // 
            // lblcelular
            // 
            this.lblcelular.AutoSize = true;
            this.lblcelular.Location = new System.Drawing.Point(554, 101);
            this.lblcelular.Name = "lblcelular";
            this.lblcelular.Size = new System.Drawing.Size(42, 13);
            this.lblcelular.TabIndex = 13;
            this.lblcelular.Text = "Celular:";
            this.lblcelular.Click += new System.EventHandler(this.lblcelular_Click);
            // 
            // txtcelular
            // 
            this.txtcelular.Location = new System.Drawing.Point(601, 98);
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.Size = new System.Drawing.Size(99, 20);
            this.txtcelular.TabIndex = 14;
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Location = new System.Drawing.Point(363, 137);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(30, 13);
            this.lblcpf.TabIndex = 15;
            this.lblcpf.Text = "CPF:";
            this.lblcpf.Click += new System.EventHandler(this.lblcpf_Click);
            // 
            // txtcpf
            // 
            this.txtcpf.Location = new System.Drawing.Point(399, 134);
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(133, 20);
            this.txtcpf.TabIndex = 16;
            // 
            // lblrg
            // 
            this.lblrg.AutoSize = true;
            this.lblrg.Location = new System.Drawing.Point(211, 137);
            this.lblrg.Name = "lblrg";
            this.lblrg.Size = new System.Drawing.Size(26, 13);
            this.lblrg.TabIndex = 17;
            this.lblrg.Text = "RG:";
            this.lblrg.Click += new System.EventHandler(this.lblrg_Click);
            // 
            // txtrg
            // 
            this.txtrg.Location = new System.Drawing.Point(247, 134);
            this.txtrg.Name = "txtrg";
            this.txtrg.Size = new System.Drawing.Size(106, 20);
            this.txtrg.TabIndex = 18;
            // 
            // lblcep
            // 
            this.lblcep.AutoSize = true;
            this.lblcep.Location = new System.Drawing.Point(389, 100);
            this.lblcep.Name = "lblcep";
            this.lblcep.Size = new System.Drawing.Size(31, 13);
            this.lblcep.TabIndex = 19;
            this.lblcep.Text = "CEP:";
            // 
            // txtcep
            // 
            this.txtcep.Location = new System.Drawing.Point(426, 97);
            this.txtcep.Name = "txtcep";
            this.txtcep.Size = new System.Drawing.Size(106, 20);
            this.txtcep.TabIndex = 20;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(732, 102);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(37, 13);
            this.lblemail.TabIndex = 21;
            this.lblemail.Text = "e-mail:";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(779, 98);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(103, 20);
            this.txtemail.TabIndex = 22;
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.Location = new System.Drawing.Point(696, 34);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(93, 13);
            this.lbldata.TabIndex = 23;
            this.lbldata.Text = "Data do Cadastro:";
            this.lbldata.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtdata
            // 
            this.txtdata.Location = new System.Drawing.Point(793, 31);
            this.txtdata.Name = "txtdata";
            this.txtdata.Size = new System.Drawing.Size(89, 20);
            this.txtdata.TabIndex = 24;
            this.txtdata.TextChanged += new System.EventHandler(this.txtdata_TextChanged);
            // 
            // gbclientes
            // 
            this.gbclientes.Controls.Add(this.btnler);
            this.gbclientes.Controls.Add(this.dgvclientes);
            this.gbclientes.Location = new System.Drawing.Point(214, 221);
            this.gbclientes.Name = "gbclientes";
            this.gbclientes.Size = new System.Drawing.Size(818, 377);
            this.gbclientes.TabIndex = 25;
            this.gbclientes.TabStop = false;
            this.gbclientes.Text = "Clientes Cadastrados";
            this.gbclientes.Enter += new System.EventHandler(this.gbclientes_Enter);
            // 
            // btnler
            // 
            this.btnler.Location = new System.Drawing.Point(6, 348);
            this.btnler.Name = "btnler";
            this.btnler.Size = new System.Drawing.Size(112, 23);
            this.btnler.TabIndex = 1;
            this.btnler.Text = "Ler";
            this.btnler.UseVisualStyleBackColor = true;
            // 
            // dgvclientes
            // 
            this.dgvclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvclientes.Location = new System.Drawing.Point(6, 19);
            this.dgvclientes.Name = "dgvclientes";
            this.dgvclientes.Size = new System.Drawing.Size(806, 322);
            this.dgvclientes.TabIndex = 0;
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(289, 177);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(145, 30);
            this.btnlimpar.TabIndex = 26;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btncadastrar
            // 
            this.btncadastrar.Location = new System.Drawing.Point(470, 177);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(145, 31);
            this.btncadastrar.TabIndex = 27;
            this.btncadastrar.Text = "Cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = true;
            // 
            // btnalterar
            // 
            this.btnalterar.Location = new System.Drawing.Point(645, 178);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(145, 30);
            this.btnalterar.TabIndex = 28;
            this.btnalterar.Text = "Alterar";
            this.btnalterar.UseVisualStyleBackColor = true;
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(828, 178);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(145, 31);
            this.btnexcluir.TabIndex = 30;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(207, 32);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(43, 13);
            this.lblcodigo.TabIndex = 31;
            this.lblcodigo.Text = "Código:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(256, 29);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(67, 20);
            this.txtcodigo.TabIndex = 32;
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Location = new System.Drawing.Point(779, 65);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(43, 13);
            this.lblestado.TabIndex = 33;
            this.lblestado.Text = "Estado:";
            // 
            // txtestado
            // 
            this.txtestado.Location = new System.Drawing.Point(828, 62);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(54, 20);
            this.txtestado.TabIndex = 34;
            // 
            // Formclientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1044, 637);
            this.Controls.Add(this.txtestado);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.lblcodigo);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btnalterar);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.gbclientes);
            this.Controls.Add(this.btnfechar);
            this.Controls.Add(this.txtdata);
            this.Controls.Add(this.lbldata);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.txtcep);
            this.Controls.Add(this.lblcep);
            this.Controls.Add(this.txtrg);
            this.Controls.Add(this.lblrg);
            this.Controls.Add(this.txtcpf);
            this.Controls.Add(this.lblcpf);
            this.Controls.Add(this.txtcelular);
            this.Controls.Add(this.lblcelular);
            this.Controls.Add(this.lbltelefone);
            this.Controls.Add(this.txttelefone);
            this.Controls.Add(this.txtcidade);
            this.Controls.Add(this.lblcidade);
            this.Controls.Add(this.txtbairro);
            this.Controls.Add(this.lblbairro);
            this.Controls.Add(this.txtendereco);
            this.Controls.Add(this.lblend);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.panel1);
            this.Name = "Formclientes";
            this.Text = "Formclientes";
            this.Load += new System.EventHandler(this.Formclientes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbclientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvclientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulocliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label lblend;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.Button btnfechar;
        private System.Windows.Forms.Label lblbairro;
        private System.Windows.Forms.TextBox txtbairro;
        private System.Windows.Forms.Label lblcidade;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.TextBox txttelefone;
        private System.Windows.Forms.Label lbltelefone;
        private System.Windows.Forms.Label lblcelular;
        private System.Windows.Forms.TextBox txtcelular;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.TextBox txtcpf;
        private System.Windows.Forms.Label lblrg;
        private System.Windows.Forms.TextBox txtrg;
        private System.Windows.Forms.Label lblcep;
        private System.Windows.Forms.TextBox txtcep;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lbldata;
        private System.Windows.Forms.TextBox txtdata;
        private System.Windows.Forms.GroupBox gbclientes;
        private System.Windows.Forms.DataGridView dgvclientes;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.Button btnalterar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnler;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.TextBox txtestado;
    }
}