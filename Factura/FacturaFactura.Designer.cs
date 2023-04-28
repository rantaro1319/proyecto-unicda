namespace Factura
{
    partial class FacturaFactura
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
            this.DetalleFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AccessDataSet1 = new Factura.AccessDataSet1();
            this.reportFactura = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DetalleFacturaTableAdapter = new Factura.AccessDataSet1TableAdapters.DetalleFacturaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccessDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // DetalleFacturaBindingSource
            // 
            this.DetalleFacturaBindingSource.DataMember = "DetalleFactura";
            this.DetalleFacturaBindingSource.DataSource = this.AccessDataSet1;
            // 
            // AccessDataSet1
            // 
            this.AccessDataSet1.DataSetName = "AccessDataSet1";
            this.AccessDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportFactura
            // 
            this.reportFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DetalleFacturaBindingSource;
            this.reportFactura.LocalReport.DataSources.Add(reportDataSource1);
            this.reportFactura.LocalReport.ReportEmbeddedResource = "Factura.factura.rdlc";
            this.reportFactura.Location = new System.Drawing.Point(0, 0);
            this.reportFactura.Name = "reportFactura";
            this.reportFactura.ServerReport.BearerToken = null;
            this.reportFactura.Size = new System.Drawing.Size(478, 513);
            this.reportFactura.TabIndex = 0;
            // 
            // DetalleFacturaTableAdapter
            // 
            this.DetalleFacturaTableAdapter.ClearBeforeFill = true;
            // 
            // FacturaFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 513);
            this.Controls.Add(this.reportFactura);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FacturaFactura";
            this.Text = "FacturaFactura";
            this.Load += new System.EventHandler(this.FacturaFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DetalleFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccessDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource DetalleFacturaBindingSource;
        private AccessDataSet1 AccessDataSet1;
        public Microsoft.Reporting.WinForms.ReportViewer reportFactura;
        public AccessDataSet1TableAdapters.DetalleFacturaTableAdapter DetalleFacturaTableAdapter;
    }
}