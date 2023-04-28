namespace Factura
{
    partial class ReporteDiario
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.FacturaProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AccessDataSet1 = new Factura.AccessDataSet1();
            this.FacturaMembresiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.dateHoraFinal = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dateHoraInicial = new Bunifu.Framework.UI.BunifuDatepicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.registroEmpleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCuadrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label3 = new System.Windows.Forms.Label();
            this.btnfiltrarReporte = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dateDiarioFinal = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dateDiarioInicial = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.FacturaProductoTableAdapter = new Factura.AccessDataSet1TableAdapters.FacturaProductoTableAdapter();
            this.FacturaMembresiaTableAdapter = new Factura.AccessDataSet1TableAdapters.FacturaMembresiaTableAdapter();
            this.registroEmpleadoTableAdapter = new Factura.AccessDataSet1TableAdapters.RegistroEmpleadoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccessDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaMembresiaBindingSource)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registroEmpleadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // FacturaProductoBindingSource
            // 
            this.FacturaProductoBindingSource.DataMember = "FacturaProducto";
            this.FacturaProductoBindingSource.DataSource = this.AccessDataSet1;
            // 
            // AccessDataSet1
            // 
            this.AccessDataSet1.DataSetName = "AccessDataSet1";
            this.AccessDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FacturaMembresiaBindingSource
            // 
            this.FacturaMembresiaBindingSource.DataMember = "FacturaMembresia";
            this.FacturaMembresiaBindingSource.DataSource = this.AccessDataSet1;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.YellowGreen;
            this.bunifuCards1.Controls.Add(this.dateHoraFinal);
            this.bunifuCards1.Controls.Add(this.dateHoraInicial);
            this.bunifuCards1.Controls.Add(this.comboBox1);
            this.bunifuCards1.Controls.Add(this.btnCuadrar);
            this.bunifuCards1.Controls.Add(this.label4);
            this.bunifuCards1.Controls.Add(this.bunifuSeparator1);
            this.bunifuCards1.Controls.Add(this.label3);
            this.bunifuCards1.Controls.Add(this.btnfiltrarReporte);
            this.bunifuCards1.Controls.Add(this.label2);
            this.bunifuCards1.Controls.Add(this.dateDiarioFinal);
            this.bunifuCards1.Controls.Add(this.dateDiarioInicial);
            this.bunifuCards1.Controls.Add(this.label1);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(946, 152);
            this.bunifuCards1.TabIndex = 0;
            // 
            // dateHoraFinal
            // 
            this.dateHoraFinal.BackColor = System.Drawing.Color.SeaGreen;
            this.dateHoraFinal.BorderRadius = 0;
            this.dateHoraFinal.ForeColor = System.Drawing.Color.White;
            this.dateHoraFinal.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateHoraFinal.FormatCustom = null;
            this.dateHoraFinal.Location = new System.Drawing.Point(303, 109);
            this.dateHoraFinal.Name = "dateHoraFinal";
            this.dateHoraFinal.Size = new System.Drawing.Size(198, 36);
            this.dateHoraFinal.TabIndex = 14;
            this.dateHoraFinal.Value = new System.DateTime(2020, 11, 20, 21, 28, 31, 830);
            this.dateHoraFinal.Visible = false;
            this.dateHoraFinal.onValueChanged += new System.EventHandler(this.dateHoraFinal_onValueChanged);
            // 
            // dateHoraInicial
            // 
            this.dateHoraInicial.BackColor = System.Drawing.Color.SeaGreen;
            this.dateHoraInicial.BorderRadius = 0;
            this.dateHoraInicial.ForeColor = System.Drawing.Color.White;
            this.dateHoraInicial.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateHoraInicial.FormatCustom = null;
            this.dateHoraInicial.Location = new System.Drawing.Point(23, 109);
            this.dateHoraInicial.Name = "dateHoraInicial";
            this.dateHoraInicial.Size = new System.Drawing.Size(198, 36);
            this.dateHoraInicial.TabIndex = 13;
            this.dateHoraInicial.Value = new System.DateTime(2020, 11, 20, 21, 28, 31, 830);
            this.dateHoraInicial.Visible = false;
            this.dateHoraInicial.onValueChanged += new System.EventHandler(this.dateHoraInicial_onValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.registroEmpleadoBindingSource;
            this.comboBox1.DisplayMember = "Nombre";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(730, 125);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.ValueMember = "Id";
            this.comboBox1.Visible = false;
            // 
            // registroEmpleadoBindingSource
            // 
            this.registroEmpleadoBindingSource.DataMember = "RegistroEmpleado";
            this.registroEmpleadoBindingSource.DataSource = this.AccessDataSet1;
            // 
            // btnCuadrar
            // 
            this.btnCuadrar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCuadrar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnCuadrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCuadrar.BorderRadius = 0;
            this.btnCuadrar.ButtonText = "Cuadrar";
            this.btnCuadrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCuadrar.DisabledColor = System.Drawing.Color.Gray;
            this.btnCuadrar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCuadrar.Iconimage = null;
            this.btnCuadrar.Iconimage_right = null;
            this.btnCuadrar.Iconimage_right_Selected = null;
            this.btnCuadrar.Iconimage_Selected = null;
            this.btnCuadrar.IconMarginLeft = 0;
            this.btnCuadrar.IconMarginRight = 0;
            this.btnCuadrar.IconRightVisible = true;
            this.btnCuadrar.IconRightZoom = 0D;
            this.btnCuadrar.IconVisible = true;
            this.btnCuadrar.IconZoom = 90D;
            this.btnCuadrar.IsTab = false;
            this.btnCuadrar.Location = new System.Drawing.Point(730, 61);
            this.btnCuadrar.Name = "btnCuadrar";
            this.btnCuadrar.Normalcolor = System.Drawing.Color.DarkOliveGreen;
            this.btnCuadrar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnCuadrar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCuadrar.selected = false;
            this.btnCuadrar.Size = new System.Drawing.Size(173, 48);
            this.btnCuadrar.TabIndex = 11;
            this.btnCuadrar.Text = "Cuadrar";
            this.btnCuadrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCuadrar.Textcolor = System.Drawing.Color.White;
            this.btnCuadrar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuadrar.Click += new System.EventHandler(this.btnCuadrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(742, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cuadre del Dia";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(680, 20);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(10, 109);
            this.bunifuSeparator1.TabIndex = 7;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hasta";
            // 
            // btnfiltrarReporte
            // 
            this.btnfiltrarReporte.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnfiltrarReporte.BackColor = System.Drawing.Color.OliveDrab;
            this.btnfiltrarReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnfiltrarReporte.BorderRadius = 0;
            this.btnfiltrarReporte.ButtonText = "Filtrar";
            this.btnfiltrarReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnfiltrarReporte.DisabledColor = System.Drawing.Color.Gray;
            this.btnfiltrarReporte.Iconcolor = System.Drawing.Color.Transparent;
            this.btnfiltrarReporte.Iconimage = global::Factura.Properties.Resources.filtrar;
            this.btnfiltrarReporte.Iconimage_right = null;
            this.btnfiltrarReporte.Iconimage_right_Selected = null;
            this.btnfiltrarReporte.Iconimage_Selected = null;
            this.btnfiltrarReporte.IconMarginLeft = 0;
            this.btnfiltrarReporte.IconMarginRight = 0;
            this.btnfiltrarReporte.IconRightVisible = true;
            this.btnfiltrarReporte.IconRightZoom = 0D;
            this.btnfiltrarReporte.IconVisible = true;
            this.btnfiltrarReporte.IconZoom = 55D;
            this.btnfiltrarReporte.IsTab = false;
            this.btnfiltrarReporte.Location = new System.Drawing.Point(545, 85);
            this.btnfiltrarReporte.Name = "btnfiltrarReporte";
            this.btnfiltrarReporte.Normalcolor = System.Drawing.Color.OliveDrab;
            this.btnfiltrarReporte.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnfiltrarReporte.OnHoverTextColor = System.Drawing.Color.White;
            this.btnfiltrarReporte.selected = false;
            this.btnfiltrarReporte.Size = new System.Drawing.Size(103, 44);
            this.btnfiltrarReporte.TabIndex = 5;
            this.btnfiltrarReporte.Text = "Filtrar";
            this.btnfiltrarReporte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnfiltrarReporte.Textcolor = System.Drawing.Color.White;
            this.btnfiltrarReporte.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfiltrarReporte.Click += new System.EventHandler(this.btnfiltrarReporte_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Desde";
            // 
            // dateDiarioFinal
            // 
            this.dateDiarioFinal.BackColor = System.Drawing.Color.LightGray;
            this.dateDiarioFinal.BorderRadius = 0;
            this.dateDiarioFinal.ForeColor = System.Drawing.Color.White;
            this.dateDiarioFinal.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateDiarioFinal.FormatCustom = null;
            this.dateDiarioFinal.Location = new System.Drawing.Point(303, 67);
            this.dateDiarioFinal.Name = "dateDiarioFinal";
            this.dateDiarioFinal.Size = new System.Drawing.Size(200, 36);
            this.dateDiarioFinal.TabIndex = 3;
            this.dateDiarioFinal.Value = new System.DateTime(2019, 10, 17, 15, 7, 11, 369);
            // 
            // dateDiarioInicial
            // 
            this.dateDiarioInicial.BackColor = System.Drawing.Color.LightGray;
            this.dateDiarioInicial.BorderRadius = 0;
            this.dateDiarioInicial.ForeColor = System.Drawing.Color.White;
            this.dateDiarioInicial.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateDiarioInicial.FormatCustom = null;
            this.dateDiarioInicial.Location = new System.Drawing.Point(23, 67);
            this.dateDiarioInicial.Name = "dateDiarioInicial";
            this.dateDiarioInicial.Size = new System.Drawing.Size(198, 36);
            this.dateDiarioInicial.TabIndex = 2;
            this.dateDiarioInicial.Value = new System.DateTime(2019, 10, 17, 15, 7, 11, 369);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filtro de Reporte";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.FacturaProductoBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.FacturaMembresiaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Factura.ReporteCuadre.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 152);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(946, 353);
            this.reportViewer1.TabIndex = 1;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // FacturaProductoTableAdapter
            // 
            this.FacturaProductoTableAdapter.ClearBeforeFill = true;
            // 
            // FacturaMembresiaTableAdapter
            // 
            this.FacturaMembresiaTableAdapter.ClearBeforeFill = true;
            // 
            // registroEmpleadoTableAdapter
            // 
            this.registroEmpleadoTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 505);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.bunifuCards1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReporteDiario";
            this.Text = "ReporteDiario";
            this.Load += new System.EventHandler(this.ReporteDiario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FacturaProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccessDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaMembresiaBindingSource)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registroEmpleadoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDatepicker dateDiarioFinal;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuFlatButton btnfiltrarReporte;
        private Bunifu.Framework.UI.BunifuFlatButton btnCuadrar;
        private Bunifu.Framework.UI.BunifuDatepicker dateDiarioInicial;
        private System.Windows.Forms.BindingSource FacturaProductoBindingSource;
        private System.Windows.Forms.BindingSource FacturaMembresiaBindingSource;
        public AccessDataSet1 AccessDataSet1;
        public AccessDataSet1TableAdapters.FacturaProductoTableAdapter FacturaProductoTableAdapter;
        public AccessDataSet1TableAdapters.FacturaMembresiaTableAdapter FacturaMembresiaTableAdapter;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource registroEmpleadoBindingSource;
        private AccessDataSet1TableAdapters.RegistroEmpleadoTableAdapter registroEmpleadoTableAdapter;
        private Bunifu.Framework.UI.BunifuDatepicker dateHoraFinal;
        private Bunifu.Framework.UI.BunifuDatepicker dateHoraInicial;
    }
}