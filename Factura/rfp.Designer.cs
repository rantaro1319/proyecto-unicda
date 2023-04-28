namespace Factura
{
    partial class rfp
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
            this.reporteFactura = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reporteFactura
            // 
            this.reporteFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reporteFactura.LocalReport.ReportEmbeddedResource = "Factura.Report1.rdlc";
            this.reporteFactura.Location = new System.Drawing.Point(0, 0);
            this.reporteFactura.Name = "reporteFactura";
            this.reporteFactura.ServerReport.BearerToken = null;
            this.reporteFactura.Size = new System.Drawing.Size(800, 450);
            this.reporteFactura.TabIndex = 0;
            // 
            // rfp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reporteFactura);
            this.Name = "rfp";
            this.Text = "rfp";
            this.Load += new System.EventHandler(this.rfp_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reporteFactura;
    }
}