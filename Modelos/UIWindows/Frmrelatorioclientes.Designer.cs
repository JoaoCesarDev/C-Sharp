namespace UIWindows
{
    partial class Frmrelatorioclientes
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rpvclientes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cbonome = new System.Windows.Forms.ComboBox();
            this.btnfiltrar = new System.Windows.Forms.Button();
            this.btndesfazerfiltro = new System.Windows.Forms.Button();
            this.fillBy1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.param1ToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.param1ToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillBy1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentbikeDataSet = new UIWindows.rentbikeDataSet();
            this.clienteTableAdapter = new UIWindows.rentbikeDataSetTableAdapters.clienteTableAdapter();
            this.fillBy1ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentbikeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvclientes
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.clienteBindingSource;
            this.rpvclientes.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvclientes.LocalReport.ReportEmbeddedResource = "UIWindows.Relatórios.Report1.rdlc";
            this.rpvclientes.Location = new System.Drawing.Point(-1, 32);
            this.rpvclientes.Name = "rpvclientes";
            this.rpvclientes.ServerReport.BearerToken = null;
            this.rpvclientes.Size = new System.Drawing.Size(996, 513);
            this.rpvclientes.TabIndex = 0;
            // 
            // cbonome
            // 
            this.cbonome.FormattingEnabled = true;
            this.cbonome.Location = new System.Drawing.Point(12, 5);
            this.cbonome.Name = "cbonome";
            this.cbonome.Size = new System.Drawing.Size(121, 21);
            this.cbonome.TabIndex = 1;
            // 
            // btnfiltrar
            // 
            this.btnfiltrar.Location = new System.Drawing.Point(139, 3);
            this.btnfiltrar.Name = "btnfiltrar";
            this.btnfiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnfiltrar.TabIndex = 2;
            this.btnfiltrar.Text = "Filtro";
            this.btnfiltrar.UseVisualStyleBackColor = true;
            this.btnfiltrar.Click += new System.EventHandler(this.btnfiltrar_Click);
            // 
            // btndesfazerfiltro
            // 
            this.btndesfazerfiltro.Location = new System.Drawing.Point(220, 3);
            this.btndesfazerfiltro.Name = "btndesfazerfiltro";
            this.btndesfazerfiltro.Size = new System.Drawing.Size(86, 23);
            this.btndesfazerfiltro.TabIndex = 3;
            this.btndesfazerfiltro.Text = "Desfazer Filtro";
            this.btndesfazerfiltro.UseVisualStyleBackColor = true;
            this.btndesfazerfiltro.Click += new System.EventHandler(this.btndesfazerfiltro_Click);
            // 
            // fillBy1ToolStrip
            // 
            this.fillBy1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.param1ToolStripLabel,
            this.param1ToolStripTextBox,
            this.fillBy1ToolStripButton});
            this.fillBy1ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBy1ToolStrip.Name = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Size = new System.Drawing.Size(1015, 25);
            this.fillBy1ToolStrip.TabIndex = 4;
            this.fillBy1ToolStrip.Text = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Visible = false;
            // 
            // param1ToolStripLabel
            // 
            this.param1ToolStripLabel.Name = "param1ToolStripLabel";
            this.param1ToolStripLabel.Size = new System.Drawing.Size(50, 22);
            this.param1ToolStripLabel.Text = "Param1:";
            this.param1ToolStripLabel.Click += new System.EventHandler(this.param1ToolStripLabel_Click);
            // 
            // param1ToolStripTextBox
            // 
            this.param1ToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.param1ToolStripTextBox.Name = "param1ToolStripTextBox";
            this.param1ToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillBy1ToolStripButton
            // 
            this.fillBy1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy1ToolStripButton.Name = "fillBy1ToolStripButton";
            this.fillBy1ToolStripButton.Size = new System.Drawing.Size(45, 22);
            this.fillBy1ToolStripButton.Text = "FillBy1";
            this.fillBy1ToolStripButton.Click += new System.EventHandler(this.fillBy1ToolStripButton_Click);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.rentbikeDataSet;
            // 
            // rentbikeDataSet
            // 
            this.rentbikeDataSet.DataSetName = "rentbikeDataSet";
            this.rentbikeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // Frmrelatorioclientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 565);
            this.Controls.Add(this.fillBy1ToolStrip);
            this.Controls.Add(this.btndesfazerfiltro);
            this.Controls.Add(this.btnfiltrar);
            this.Controls.Add(this.cbonome);
            this.Controls.Add(this.rpvclientes);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frmrelatorioclientes";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Relatório dos Clientes";
            this.Load += new System.EventHandler(this.Frmrelatorioclientes_Load);
            this.fillBy1ToolStrip.ResumeLayout(false);
            this.fillBy1ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentbikeDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvclientes;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private rentbikeDataSet rentbikeDataSet;
        private rentbikeDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.ComboBox cbonome;
        private System.Windows.Forms.Button btnfiltrar;
        private System.Windows.Forms.Button btndesfazerfiltro;
        private System.Windows.Forms.ToolStrip fillBy1ToolStrip;
        private System.Windows.Forms.ToolStripLabel param1ToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox param1ToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillBy1ToolStripButton;
    }
}