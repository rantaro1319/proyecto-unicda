namespace Factura
{
    partial class ReciboMembresia
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
            this.reportMembresia = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportMembresia
            // 
            this.reportMembresia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportMembresia.LocalReport.ReportEmbeddedResource = "Factura.ReMembresia.rdlc";
            this.reportMembresia.Location = new System.Drawing.Point(0, 0);
            this.reportMembresia.Name = "reportMembresia";
            this.reportMembresia.ServerReport.BearerToken = null;
            this.reportMembresia.Size = new System.Drawing.Size(470, 486);
            this.reportMembresia.TabIndex = 0;
            // 
            // ReciboMembresia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 486);
            this.Controls.Add(this.reportMembresia);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReciboMembresia";
            this.Text = "ReciboMembresia";
            this.Load += new System.EventHandler(this.ReciboMembresia_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer reportMembresia;
    }
}