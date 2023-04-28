namespace Factura
{
    partial class tipoFactura
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pbMembresia = new System.Windows.Forms.PictureBox();
            this.pbFacturaProducto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMembresia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFacturaProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Pago de Membresia";
            this.label1.Click += new System.EventHandler(this.pbMembresia_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(370, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 39);
            this.label3.TabIndex = 12;
            this.label3.Text = "Punto de Venta";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(776, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Facturar Producto";
            this.label4.Click += new System.EventHandler(this.pbFacturaProducto_Click);
            // 
            // pbMembresia
            // 
            this.pbMembresia.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pbMembresia.BackColor = System.Drawing.Color.Transparent;
            this.pbMembresia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMembresia.Image = global::Factura.Properties.Resources.checka_100px;
            this.pbMembresia.Location = new System.Drawing.Point(12, 170);
            this.pbMembresia.Name = "pbMembresia";
            this.pbMembresia.Size = new System.Drawing.Size(209, 220);
            this.pbMembresia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbMembresia.TabIndex = 10;
            this.pbMembresia.TabStop = false;
            this.pbMembresia.Click += new System.EventHandler(this.pbMembresia_Click);
            this.pbMembresia.MouseLeave += new System.EventHandler(this.pbMembresia_MouseLeave);
            this.pbMembresia.MouseHover += new System.EventHandler(this.pbMembresia_MouseHover);
            this.pbMembresia.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbMembresia_MouseMove);
            // 
            // pbFacturaProducto
            // 
            this.pbFacturaProducto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pbFacturaProducto.BackColor = System.Drawing.Color.Transparent;
            this.pbFacturaProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFacturaProducto.Image = global::Factura.Properties.Resources.check_100px;
            this.pbFacturaProducto.Location = new System.Drawing.Point(740, 170);
            this.pbFacturaProducto.Name = "pbFacturaProducto";
            this.pbFacturaProducto.Size = new System.Drawing.Size(225, 220);
            this.pbFacturaProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbFacturaProducto.TabIndex = 9;
            this.pbFacturaProducto.TabStop = false;
            this.pbFacturaProducto.Click += new System.EventHandler(this.pbFacturaProducto_Click);
            this.pbFacturaProducto.MouseLeave += new System.EventHandler(this.pbFacturaProducto_MouseLeave);
            this.pbFacturaProducto.MouseHover += new System.EventHandler(this.pbFacturaProducto_MouseHover);
            this.pbFacturaProducto.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbFacturaProducto_MouseMove);
            // 
            // tipoFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 533);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbMembresia);
            this.Controls.Add(this.pbFacturaProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tipoFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "tipoFactura";
            this.Load += new System.EventHandler(this.tipoFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMembresia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFacturaProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbFacturaProducto;
        private System.Windows.Forms.PictureBox pbMembresia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}