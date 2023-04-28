namespace Factura
{
    partial class ReporteFacturaProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DetalleFactura1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AccessDataSet1 = new Factura.AccessDataSet1();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.numfacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Badgenumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expr1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechacreacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturaProductoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.btnVerDetalle = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnFiltrarProducto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dateInicial = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dateFinal = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dataTable1TableAdapter1 = new Factura.AccessDataSet1TableAdapters.DataTable1TableAdapter();
            this.reporteFacturaPTableAdapter1 = new Factura.AccessDataSet1TableAdapters.ReporteFacturaPTableAdapter();
            this.facturapTableAdapter = new Factura.AccessDataSet1TableAdapters.facturapTableAdapter();
            this.facturaProductoTableAdapter = new Factura.AccessDataSet1TableAdapters.FacturaProductoTableAdapter();
            this.facturapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturaProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DetalleFactura1TableAdapter = new Factura.AccessDataSet1TableAdapters.DetalleFactura1TableAdapter();
            this.btnImprimirRecibo = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleFactura1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccessDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaProductoBindingSource1)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facturapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaProductoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DetalleFactura1BindingSource
            // 
            this.DetalleFactura1BindingSource.DataMember = "DetalleFactura1";
            this.DetalleFactura1BindingSource.DataSource = this.AccessDataSet1;
            // 
            // AccessDataSet1
            // 
            this.AccessDataSet1.DataSetName = "AccessDataSet1";
            this.AccessDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bunifuCustomDataGrid1
            // 
            this.bunifuCustomDataGrid1.AllowUserToAddRows = false;
            this.bunifuCustomDataGrid1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.AutoGenerateColumns = false;
            this.bunifuCustomDataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numfacturaDataGridViewTextBoxColumn,
            this.Badgenumber,
            this.Expr1,
            this.fechacreacionDataGridViewTextBoxColumn});
            this.bunifuCustomDataGrid1.DataSource = this.facturaProductoBindingSource1;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.OliveDrab;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(0, 201);
            this.bunifuCustomDataGrid1.MultiSelect = false;
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.ReadOnly = true;
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(1022, 130);
            this.bunifuCustomDataGrid1.TabIndex = 3;
            this.bunifuCustomDataGrid1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellDoubleClick);
            // 
            // numfacturaDataGridViewTextBoxColumn
            // 
            this.numfacturaDataGridViewTextBoxColumn.DataPropertyName = "Num_factura";
            this.numfacturaDataGridViewTextBoxColumn.HeaderText = "Num_factura";
            this.numfacturaDataGridViewTextBoxColumn.Name = "numfacturaDataGridViewTextBoxColumn";
            this.numfacturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Badgenumber
            // 
            this.Badgenumber.DataPropertyName = "Badgenumber";
            this.Badgenumber.HeaderText = "ID Cliente";
            this.Badgenumber.Name = "Badgenumber";
            this.Badgenumber.ReadOnly = true;
            // 
            // Expr1
            // 
            this.Expr1.DataPropertyName = "Expr1";
            this.Expr1.HeaderText = "Cliente";
            this.Expr1.Name = "Expr1";
            this.Expr1.ReadOnly = true;
            // 
            // fechacreacionDataGridViewTextBoxColumn
            // 
            this.fechacreacionDataGridViewTextBoxColumn.DataPropertyName = "Fecha_creacion";
            this.fechacreacionDataGridViewTextBoxColumn.HeaderText = "Fecha de Creacion";
            this.fechacreacionDataGridViewTextBoxColumn.Name = "fechacreacionDataGridViewTextBoxColumn";
            this.fechacreacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // facturaProductoBindingSource1
            // 
            this.facturaProductoBindingSource1.DataMember = "FacturaProducto";
            this.facturaProductoBindingSource1.DataSource = this.AccessDataSet1;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.YellowGreen;
            this.bunifuCards1.Controls.Add(this.btnImprimirRecibo);
            this.bunifuCards1.Controls.Add(this.btnVerDetalle);
            this.bunifuCards1.Controls.Add(this.bunifuSeparator2);
            this.bunifuCards1.Controls.Add(this.btnFiltrarProducto);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel5);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel4);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel3);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuCards1.Controls.Add(this.dateInicial);
            this.bunifuCards1.Controls.Add(this.dateFinal);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(1022, 199);
            this.bunifuCards1.TabIndex = 1;
            // 
            // btnVerDetalle
            // 
            this.btnVerDetalle.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnVerDetalle.BackColor = System.Drawing.Color.OliveDrab;
            this.btnVerDetalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVerDetalle.BorderRadius = 0;
            this.btnVerDetalle.ButtonText = "Ver Detalle";
            this.btnVerDetalle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerDetalle.DisabledColor = System.Drawing.Color.Gray;
            this.btnVerDetalle.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVerDetalle.Iconimage = global::Factura.Properties.Resources.documento;
            this.btnVerDetalle.Iconimage_right = null;
            this.btnVerDetalle.Iconimage_right_Selected = null;
            this.btnVerDetalle.Iconimage_Selected = null;
            this.btnVerDetalle.IconMarginLeft = 0;
            this.btnVerDetalle.IconMarginRight = 0;
            this.btnVerDetalle.IconRightVisible = true;
            this.btnVerDetalle.IconRightZoom = 0D;
            this.btnVerDetalle.IconVisible = true;
            this.btnVerDetalle.IconZoom = 60D;
            this.btnVerDetalle.IsTab = false;
            this.btnVerDetalle.Location = new System.Drawing.Point(879, 49);
            this.btnVerDetalle.Name = "btnVerDetalle";
            this.btnVerDetalle.Normalcolor = System.Drawing.Color.DarkOliveGreen;
            this.btnVerDetalle.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnVerDetalle.OnHoverTextColor = System.Drawing.Color.White;
            this.btnVerDetalle.selected = false;
            this.btnVerDetalle.Size = new System.Drawing.Size(131, 47);
            this.btnVerDetalle.TabIndex = 15;
            this.btnVerDetalle.Text = "Ver Detalle";
            this.btnVerDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVerDetalle.Textcolor = System.Drawing.Color.White;
            this.btnVerDetalle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDetalle.Click += new System.EventHandler(this.btnVerDetalle_Click);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(691, 32);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(22, 145);
            this.bunifuSeparator2.TabIndex = 14;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = true;
            // 
            // btnFiltrarProducto
            // 
            this.btnFiltrarProducto.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnFiltrarProducto.BackColor = System.Drawing.Color.OliveDrab;
            this.btnFiltrarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFiltrarProducto.BorderRadius = 0;
            this.btnFiltrarProducto.ButtonText = "Filtrar";
            this.btnFiltrarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrarProducto.DisabledColor = System.Drawing.Color.Gray;
            this.btnFiltrarProducto.Iconcolor = System.Drawing.Color.Transparent;
            this.btnFiltrarProducto.Iconimage = global::Factura.Properties.Resources.filtrar;
            this.btnFiltrarProducto.Iconimage_right = null;
            this.btnFiltrarProducto.Iconimage_right_Selected = null;
            this.btnFiltrarProducto.Iconimage_Selected = null;
            this.btnFiltrarProducto.IconMarginLeft = 0;
            this.btnFiltrarProducto.IconMarginRight = 0;
            this.btnFiltrarProducto.IconRightVisible = true;
            this.btnFiltrarProducto.IconRightZoom = 0D;
            this.btnFiltrarProducto.IconVisible = true;
            this.btnFiltrarProducto.IconZoom = 60D;
            this.btnFiltrarProducto.IsTab = false;
            this.btnFiltrarProducto.Location = new System.Drawing.Point(728, 49);
            this.btnFiltrarProducto.Name = "btnFiltrarProducto";
            this.btnFiltrarProducto.Normalcolor = System.Drawing.Color.OliveDrab;
            this.btnFiltrarProducto.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnFiltrarProducto.OnHoverTextColor = System.Drawing.Color.White;
            this.btnFiltrarProducto.selected = false;
            this.btnFiltrarProducto.Size = new System.Drawing.Size(131, 47);
            this.btnFiltrarProducto.TabIndex = 13;
            this.btnFiltrarProducto.Text = "Filtrar";
            this.btnFiltrarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFiltrarProducto.Textcolor = System.Drawing.Color.White;
            this.btnFiltrarProducto.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarProducto.Click += new System.EventHandler(this.btnFiltrarProducto_Click);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(386, 97);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(44, 16);
            this.bunifuCustomLabel5.TabIndex = 9;
            this.bunifuCustomLabel5.Text = "Hasta";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(72, 97);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(47, 16);
            this.bunifuCustomLabel4.TabIndex = 8;
            this.bunifuCustomLabel4.Text = "Desde";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(68, 58);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(152, 20);
            this.bunifuCustomLabel3.TabIndex = 7;
            this.bunifuCustomLabel3.Text = "Intervalo de fecha";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(23, 12);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(122, 24);
            this.bunifuCustomLabel1.TabIndex = 5;
            this.bunifuCustomLabel1.Text = "Buscar por";
            // 
            // dateInicial
            // 
            this.dateInicial.BackColor = System.Drawing.Color.Gray;
            this.dateInicial.BorderRadius = 0;
            this.dateInicial.ForeColor = System.Drawing.Color.White;
            this.dateInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateInicial.FormatCustom = null;
            this.dateInicial.Location = new System.Drawing.Point(72, 126);
            this.dateInicial.Name = "dateInicial";
            this.dateInicial.Size = new System.Drawing.Size(229, 41);
            this.dateInicial.TabIndex = 3;
            this.dateInicial.Value = new System.DateTime(2019, 10, 14, 0, 0, 0, 0);
            // 
            // dateFinal
            // 
            this.dateFinal.BackColor = System.Drawing.Color.Gray;
            this.dateFinal.BorderRadius = 0;
            this.dateFinal.ForeColor = System.Drawing.Color.White;
            this.dateFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFinal.FormatCustom = null;
            this.dateFinal.Location = new System.Drawing.Point(389, 126);
            this.dateFinal.Name = "dateFinal";
            this.dateFinal.Size = new System.Drawing.Size(229, 41);
            this.dateFinal.TabIndex = 1;
            this.dateFinal.Value = new System.DateTime(2019, 10, 29, 0, 0, 0, 0);
            // 
            // dataTable1TableAdapter1
            // 
            this.dataTable1TableAdapter1.ClearBeforeFill = true;
            // 
            // reporteFacturaPTableAdapter1
            // 
            this.reporteFacturaPTableAdapter1.ClearBeforeFill = true;
            // 
            // facturapTableAdapter
            // 
            this.facturapTableAdapter.ClearBeforeFill = true;
            // 
            // facturaProductoTableAdapter
            // 
            this.facturaProductoTableAdapter.ClearBeforeFill = true;
            // 
            // facturapBindingSource
            // 
            this.facturapBindingSource.DataMember = "facturap";
            this.facturapBindingSource.DataSource = this.AccessDataSet1;
            // 
            // facturaProductoBindingSource
            // 
            this.facturaProductoBindingSource.DataMember = "FacturaProducto";
            this.facturaProductoBindingSource.DataSource = this.AccessDataSet1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DetalleFactura1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Factura.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 337);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1022, 301);
            this.reportViewer1.TabIndex = 4;
            // 
            // DetalleFactura1TableAdapter
            // 
            this.DetalleFactura1TableAdapter.ClearBeforeFill = true;
            // 
            // btnImprimirRecibo
            // 
            this.btnImprimirRecibo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnImprimirRecibo.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnImprimirRecibo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImprimirRecibo.BorderRadius = 0;
            this.btnImprimirRecibo.ButtonText = "Imprimir Recibo";
            this.btnImprimirRecibo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimirRecibo.DisabledColor = System.Drawing.Color.Gray;
            this.btnImprimirRecibo.Iconcolor = System.Drawing.Color.Transparent;
            this.btnImprimirRecibo.Iconimage = global::Factura.Properties.Resources.documento;
            this.btnImprimirRecibo.Iconimage_right = null;
            this.btnImprimirRecibo.Iconimage_right_Selected = null;
            this.btnImprimirRecibo.Iconimage_Selected = null;
            this.btnImprimirRecibo.IconMarginLeft = 0;
            this.btnImprimirRecibo.IconMarginRight = 0;
            this.btnImprimirRecibo.IconRightVisible = true;
            this.btnImprimirRecibo.IconRightZoom = 0D;
            this.btnImprimirRecibo.IconVisible = true;
            this.btnImprimirRecibo.IconZoom = 60D;
            this.btnImprimirRecibo.IsTab = false;
            this.btnImprimirRecibo.Location = new System.Drawing.Point(728, 120);
            this.btnImprimirRecibo.Name = "btnImprimirRecibo";
            this.btnImprimirRecibo.Normalcolor = System.Drawing.Color.DarkOliveGreen;
            this.btnImprimirRecibo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnImprimirRecibo.OnHoverTextColor = System.Drawing.Color.White;
            this.btnImprimirRecibo.selected = false;
            this.btnImprimirRecibo.Size = new System.Drawing.Size(282, 47);
            this.btnImprimirRecibo.TabIndex = 16;
            this.btnImprimirRecibo.Text = "Imprimir Recibo";
            this.btnImprimirRecibo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnImprimirRecibo.Textcolor = System.Drawing.Color.White;
            this.btnImprimirRecibo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirRecibo.Click += new System.EventHandler(this.btnImprimirRecibo_Click);
            // 
            // ReporteFacturaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 638);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReporteFacturaProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Factura";
            this.Load += new System.EventHandler(this.ReporteFacturaProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DetalleFactura1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccessDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaProductoBindingSource1)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facturapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaProductoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuDatepicker dateInicial;
        private Bunifu.Framework.UI.BunifuDatepicker dateFinal;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnFiltrarProducto;
        private AccessDataSet1 AccessDataSet1;
        private System.Windows.Forms.BindingSource facturaProductoBindingSource1;
        private Bunifu.Framework.UI.BunifuFlatButton btnVerDetalle;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private AccessDataSet1TableAdapters.DataTable1TableAdapter dataTable1TableAdapter1;
        private AccessDataSet1TableAdapters.ReporteFacturaPTableAdapter reporteFacturaPTableAdapter1;
        private AccessDataSet1TableAdapters.facturapTableAdapter facturapTableAdapter;
        private AccessDataSet1TableAdapters.FacturaProductoTableAdapter facturaProductoTableAdapter;
        private System.Windows.Forms.BindingSource facturapBindingSource;
        private System.Windows.Forms.BindingSource facturaProductoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn numfacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Badgenumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expr1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechacreacionDataGridViewTextBoxColumn;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DetalleFactura1BindingSource;
        private AccessDataSet1TableAdapters.DetalleFactura1TableAdapter DetalleFactura1TableAdapter;
        private Bunifu.Framework.UI.BunifuFlatButton btnImprimirRecibo;
    }
}