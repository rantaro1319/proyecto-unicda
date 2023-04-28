namespace Factura
{
    partial class CuentasPorCobrar
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.AccessDataSet1 = new Factura.AccessDataSet1();
            this.CuentasPorCobrarTablaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CuentasPorCobrarTablaTableAdapter = new Factura.AccessDataSet1TableAdapters.CuentasPorCobrarTablaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.AccessDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CuentasPorCobrarTablaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CuentasPorCobrarTablaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Factura.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // AccessDataSet1
            // 
            this.AccessDataSet1.DataSetName = "AccessDataSet1";
            this.AccessDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CuentasPorCobrarTablaBindingSource
            // 
            this.CuentasPorCobrarTablaBindingSource.DataMember = "CuentasPorCobrarTabla";
            this.CuentasPorCobrarTablaBindingSource.DataSource = this.AccessDataSet1;
            // 
            // CuentasPorCobrarTablaTableAdapter
            // 
            this.CuentasPorCobrarTablaTableAdapter.ClearBeforeFill = true;
            // 
            // CuentasPorCobrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "CuentasPorCobrar";
            this.Text = "CuentasPorCobrar";
            this.Load += new System.EventHandler(this.CuentasPorCobrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AccessDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CuentasPorCobrarTablaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CuentasPorCobrarTablaBindingSource;
        private AccessDataSet1 AccessDataSet1;
        private AccessDataSet1TableAdapters.CuentasPorCobrarTablaTableAdapter CuentasPorCobrarTablaTableAdapter;
    }
}