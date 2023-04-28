namespace Factura
{
    partial class ReporteMembresia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteMembresia));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.FacturaMembresiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AccessDataSet1 = new Factura.AccessDataSet1();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.lbPorUsuario = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnFiltroMembresia = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dateInicial = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.dateFinal = new Bunifu.Framework.UI.BunifuDatepicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.FacturaMembresiaTableAdapter = new Factura.AccessDataSet1TableAdapters.FacturaMembresiaTableAdapter();
            this.comboPorUsuario = new System.Windows.Forms.ComboBox();
            this.registroEmpleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registroEmpleadoTableAdapter = new Factura.AccessDataSet1TableAdapters.RegistroEmpleadoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaMembresiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccessDataSet1)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registroEmpleadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // FacturaMembresiaBindingSource
            // 
            this.FacturaMembresiaBindingSource.DataMember = "FacturaMembresia";
            this.FacturaMembresiaBindingSource.DataSource = this.AccessDataSet1;
            // 
            // AccessDataSet1
            // 
            this.AccessDataSet1.DataSetName = "AccessDataSet1";
            this.AccessDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.YellowGreen;
            this.bunifuCards1.Controls.Add(this.comboPorUsuario);
            this.bunifuCards1.Controls.Add(this.lbPorUsuario);
            this.bunifuCards1.Controls.Add(this.btnFiltroMembresia);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel5);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel4);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel3);
            this.bunifuCards1.Controls.Add(this.dateInicial);
            this.bunifuCards1.Controls.Add(this.bunifuSeparator1);
            this.bunifuCards1.Controls.Add(this.dateFinal);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(966, 178);
            this.bunifuCards1.TabIndex = 17;
            // 
            // lbPorUsuario
            // 
            this.lbPorUsuario.AutoSize = true;
            this.lbPorUsuario.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPorUsuario.Location = new System.Drawing.Point(535, 40);
            this.lbPorUsuario.Name = "lbPorUsuario";
            this.lbPorUsuario.Size = new System.Drawing.Size(100, 20);
            this.lbPorUsuario.TabIndex = 14;
            this.lbPorUsuario.Text = "Por Usuario";
            this.lbPorUsuario.Visible = false;
            // 
            // btnFiltroMembresia
            // 
            this.btnFiltroMembresia.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnFiltroMembresia.BackColor = System.Drawing.Color.OliveDrab;
            this.btnFiltroMembresia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFiltroMembresia.BorderRadius = 0;
            this.btnFiltroMembresia.ButtonText = "Buscar";
            this.btnFiltroMembresia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltroMembresia.DisabledColor = System.Drawing.Color.Gray;
            this.btnFiltroMembresia.Iconcolor = System.Drawing.Color.Transparent;
            this.btnFiltroMembresia.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnFiltroMembresia.Iconimage")));
            this.btnFiltroMembresia.Iconimage_right = null;
            this.btnFiltroMembresia.Iconimage_right_Selected = null;
            this.btnFiltroMembresia.Iconimage_Selected = null;
            this.btnFiltroMembresia.IconMarginLeft = 0;
            this.btnFiltroMembresia.IconMarginRight = 0;
            this.btnFiltroMembresia.IconRightVisible = true;
            this.btnFiltroMembresia.IconRightZoom = 0D;
            this.btnFiltroMembresia.IconVisible = true;
            this.btnFiltroMembresia.IconZoom = 90D;
            this.btnFiltroMembresia.IsTab = false;
            this.btnFiltroMembresia.Location = new System.Drawing.Point(820, 108);
            this.btnFiltroMembresia.Name = "btnFiltroMembresia";
            this.btnFiltroMembresia.Normalcolor = System.Drawing.Color.OliveDrab;
            this.btnFiltroMembresia.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnFiltroMembresia.OnHoverTextColor = System.Drawing.Color.White;
            this.btnFiltroMembresia.selected = false;
            this.btnFiltroMembresia.Size = new System.Drawing.Size(122, 47);
            this.btnFiltroMembresia.TabIndex = 13;
            this.btnFiltroMembresia.Text = "Buscar";
            this.btnFiltroMembresia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltroMembresia.Textcolor = System.Drawing.Color.White;
            this.btnFiltroMembresia.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltroMembresia.Click += new System.EventHandler(this.btnFiltroMembresia_Click);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(252, 79);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(44, 16);
            this.bunifuCustomLabel5.TabIndex = 9;
            this.bunifuCustomLabel5.Text = "Hasta";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(64, 79);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(47, 16);
            this.bunifuCustomLabel4.TabIndex = 8;
            this.bunifuCustomLabel4.Text = "Desde";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(60, 40);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(215, 20);
            this.bunifuCustomLabel3.TabIndex = 7;
            this.bunifuCustomLabel3.Text = "Intervalo de fecha Factura";
            // 
            // dateInicial
            // 
            this.dateInicial.BackColor = System.Drawing.Color.Gray;
            this.dateInicial.BorderRadius = 0;
            this.dateInicial.ForeColor = System.Drawing.Color.White;
            this.dateInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateInicial.FormatCustom = null;
            this.dateInicial.Location = new System.Drawing.Point(64, 108);
            this.dateInicial.Name = "dateInicial";
            this.dateInicial.Size = new System.Drawing.Size(169, 28);
            this.dateInicial.TabIndex = 3;
            this.dateInicial.Value = new System.DateTime(2019, 10, 22, 0, 0, 0, 0);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(498, 12);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(22, 153);
            this.bunifuSeparator1.TabIndex = 2;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // dateFinal
            // 
            this.dateFinal.BackColor = System.Drawing.Color.Gray;
            this.dateFinal.BorderRadius = 0;
            this.dateFinal.ForeColor = System.Drawing.Color.White;
            this.dateFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFinal.FormatCustom = null;
            this.dateFinal.Location = new System.Drawing.Point(255, 108);
            this.dateFinal.Name = "dateFinal";
            this.dateFinal.Size = new System.Drawing.Size(157, 28);
            this.dateFinal.TabIndex = 1;
            this.dateFinal.Value = new System.DateTime(2019, 10, 22, 0, 0, 0, 0);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource5.Name = "DataSet1";
            reportDataSource5.Value = this.FacturaMembresiaBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Factura.MembresiaReporting.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 184);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(966, 411);
            this.reportViewer2.TabIndex = 18;
            this.reportViewer2.Load += new System.EventHandler(this.reportViewer2_Load);
            // 
            // FacturaMembresiaTableAdapter
            // 
            this.FacturaMembresiaTableAdapter.ClearBeforeFill = true;
            // 
            // comboPorUsuario
            // 
            this.comboPorUsuario.DataSource = this.registroEmpleadoBindingSource;
            this.comboPorUsuario.DisplayMember = "Nombre";
            this.comboPorUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPorUsuario.FormattingEnabled = true;
            this.comboPorUsuario.Location = new System.Drawing.Point(539, 79);
            this.comboPorUsuario.Name = "comboPorUsuario";
            this.comboPorUsuario.Size = new System.Drawing.Size(208, 21);
            this.comboPorUsuario.TabIndex = 15;
            this.comboPorUsuario.ValueMember = "Usuario";
            // 
            // registroEmpleadoBindingSource
            // 
            this.registroEmpleadoBindingSource.DataMember = "RegistroEmpleado";
            this.registroEmpleadoBindingSource.DataSource = this.AccessDataSet1;
            // 
            // registroEmpleadoTableAdapter
            // 
            this.registroEmpleadoTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteMembresia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 595);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.bunifuCards1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReporteMembresia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteMembresia";
            this.Load += new System.EventHandler(this.ReporteMembresia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FacturaMembresiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccessDataSet1)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registroEmpleadoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuFlatButton btnFiltroMembresia;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuDatepicker dateInicial;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuDatepicker dateFinal;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource FacturaMembresiaBindingSource;
        private AccessDataSet1 AccessDataSet1;
        private AccessDataSet1TableAdapters.FacturaMembresiaTableAdapter FacturaMembresiaTableAdapter;
        private Bunifu.Framework.UI.BunifuCustomLabel lbPorUsuario;
        private System.Windows.Forms.ComboBox comboPorUsuario;
        private System.Windows.Forms.BindingSource registroEmpleadoBindingSource;
        private AccessDataSet1TableAdapters.RegistroEmpleadoTableAdapter registroEmpleadoTableAdapter;
    }
}