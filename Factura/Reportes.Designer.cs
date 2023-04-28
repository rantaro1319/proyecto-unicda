namespace Factura
{
    partial class Reportes
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.imgFacturas = new System.Windows.Forms.PictureBox();
            this.imgCuentas = new System.Windows.Forms.PictureBox();
            this.imgIngreso = new System.Windows.Forms.PictureBox();
            this.imgMembresia = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCuentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgIngreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMembresia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 22);
            this.label1.TabIndex = 19;
            this.label1.Text = "Reportes de Membresia";
            this.label1.Click += new System.EventHandler(this.imgMembresia_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(684, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "Reportes de Facturas";
            this.label2.Click += new System.EventHandler(this.imgFacturas_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 497);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 22);
            this.label3.TabIndex = 21;
            this.label3.Text = "Cuentas por cobrar";
            this.label3.Click += new System.EventHandler(this.imgCuentas_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(701, 497);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 22);
            this.label4.TabIndex = 22;
            this.label4.Text = "Cuadre de ingreso";
            this.label4.Click += new System.EventHandler(this.imgIngreso_Click);
            // 
            // imgFacturas
            // 
            this.imgFacturas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgFacturas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgFacturas.Image = global::Factura.Properties.Resources.check_80px;
            this.imgFacturas.Location = new System.Drawing.Point(667, 61);
            this.imgFacturas.Name = "imgFacturas";
            this.imgFacturas.Size = new System.Drawing.Size(225, 166);
            this.imgFacturas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgFacturas.TabIndex = 18;
            this.imgFacturas.TabStop = false;
            this.imgFacturas.Click += new System.EventHandler(this.imgFacturas_Click);
            this.imgFacturas.MouseLeave += new System.EventHandler(this.imgFacturas_MouseLeave);
            this.imgFacturas.MouseHover += new System.EventHandler(this.imgFacturas_MouseHover);
            this.imgFacturas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imgFacturas_MouseMove);
            // 
            // imgCuentas
            // 
            this.imgCuentas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.imgCuentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgCuentas.Image = global::Factura.Properties.Resources.money_bag_100px;
            this.imgCuentas.Location = new System.Drawing.Point(21, 363);
            this.imgCuentas.Name = "imgCuentas";
            this.imgCuentas.Size = new System.Drawing.Size(225, 166);
            this.imgCuentas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgCuentas.TabIndex = 17;
            this.imgCuentas.TabStop = false;
            this.imgCuentas.Click += new System.EventHandler(this.imgCuentas_Click);
            this.imgCuentas.MouseLeave += new System.EventHandler(this.imgCuentas_MouseLeave);
            this.imgCuentas.MouseHover += new System.EventHandler(this.imgCuentas_MouseHover);
            this.imgCuentas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imgCuentas_MouseMove);
            // 
            // imgIngreso
            // 
            this.imgIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.imgIngreso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgIngreso.Image = global::Factura.Properties.Resources.investment_portfolio_filled_100px;
            this.imgIngreso.Location = new System.Drawing.Point(667, 363);
            this.imgIngreso.Name = "imgIngreso";
            this.imgIngreso.Padding = new System.Windows.Forms.Padding(20);
            this.imgIngreso.Size = new System.Drawing.Size(225, 166);
            this.imgIngreso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgIngreso.TabIndex = 16;
            this.imgIngreso.TabStop = false;
            this.imgIngreso.Click += new System.EventHandler(this.imgIngreso_Click);
            this.imgIngreso.MouseLeave += new System.EventHandler(this.imgIngreso_MouseLeave);
            this.imgIngreso.MouseHover += new System.EventHandler(this.imgIngreso_MouseHover);
            this.imgIngreso.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imgIngreso_MouseMove);
            // 
            // imgMembresia
            // 
            this.imgMembresia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgMembresia.Image = global::Factura.Properties.Resources.check_64px;
            this.imgMembresia.Location = new System.Drawing.Point(21, 61);
            this.imgMembresia.Name = "imgMembresia";
            this.imgMembresia.Size = new System.Drawing.Size(225, 166);
            this.imgMembresia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgMembresia.TabIndex = 15;
            this.imgMembresia.TabStop = false;
            this.imgMembresia.Click += new System.EventHandler(this.imgMembresia_Click);
            this.imgMembresia.MouseLeave += new System.EventHandler(this.imgMembresia_MouseLeave);
            this.imgMembresia.MouseHover += new System.EventHandler(this.imgMembresia_MouseHover);
            this.imgMembresia.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imgMembresia_MouseMove);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 45);
            this.label5.TabIndex = 23;
            this.label5.Text = "Reportes";
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(904, 541);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgFacturas);
            this.Controls.Add(this.imgCuentas);
            this.Controls.Add(this.imgIngreso);
            this.Controls.Add(this.imgMembresia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Reportes_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.imgFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCuentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgIngreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMembresia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox imgMembresia;
        private System.Windows.Forms.PictureBox imgIngreso;
        private System.Windows.Forms.PictureBox imgCuentas;
        private System.Windows.Forms.PictureBox imgFacturas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}