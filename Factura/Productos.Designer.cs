namespace Factura
{
    partial class Productos
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
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.txtProducto = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtPrecio = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtCosto = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.txtExistencia = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.btnAgregarProduto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEditarProducto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCards1.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nombre de Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Existencias";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Costo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Precio";
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.YellowGreen;
            this.bunifuCards1.Controls.Add(this.txtIdProducto);
            this.bunifuCards1.Controls.Add(this.txtProducto);
            this.bunifuCards1.Controls.Add(this.txtPrecio);
            this.bunifuCards1.Controls.Add(this.txtCosto);
            this.bunifuCards1.Controls.Add(this.label5);
            this.bunifuCards1.Controls.Add(this.label4);
            this.bunifuCards1.Controls.Add(this.label2);
            this.bunifuCards1.Controls.Add(this.label1);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(38, 58);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(499, 284);
            this.bunifuCards1.TabIndex = 20;
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Enabled = false;
            this.txtIdProducto.Location = new System.Drawing.Point(207, 49);
            this.txtIdProducto.MaxLength = 100;
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(100, 20);
            this.txtIdProducto.TabIndex = 24;
            // 
            // txtProducto
            // 
            this.txtProducto.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtProducto.Location = new System.Drawing.Point(207, 102);
            this.txtProducto.MaxLength = 100;
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(216, 20);
            this.txtProducto.TabIndex = 23;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtPrecio.Location = new System.Drawing.Point(207, 208);
            this.txtPrecio.MaxLength = 20;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(216, 20);
            this.txtPrecio.TabIndex = 22;
            // 
            // txtCosto
            // 
            this.txtCosto.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtCosto.Location = new System.Drawing.Point(207, 155);
            this.txtCosto.MaxLength = 20;
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(216, 20);
            this.txtCosto.TabIndex = 21;
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.DarkOliveGreen;
            this.bunifuCards2.Controls.Add(this.txtExistencia);
            this.bunifuCards2.Controls.Add(this.label3);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(580, 89);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(243, 91);
            this.bunifuCards2.TabIndex = 21;
            // 
            // txtExistencia
            // 
            this.txtExistencia.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtExistencia.Location = new System.Drawing.Point(120, 37);
            this.txtExistencia.MaxLength = 20;
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.Size = new System.Drawing.Size(106, 20);
            this.txtExistencia.TabIndex = 24;
            // 
            // btnAgregarProduto
            // 
            this.btnAgregarProduto.Activecolor = System.Drawing.Color.YellowGreen;
            this.btnAgregarProduto.BackColor = System.Drawing.Color.OliveDrab;
            this.btnAgregarProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarProduto.BorderRadius = 0;
            this.btnAgregarProduto.ButtonText = "Registrar Producto";
            this.btnAgregarProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarProduto.DisabledColor = System.Drawing.Color.Gray;
            this.btnAgregarProduto.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregarProduto.Iconimage = global::Factura.Properties.Resources.Nuevo;
            this.btnAgregarProduto.Iconimage_right = null;
            this.btnAgregarProduto.Iconimage_right_Selected = null;
            this.btnAgregarProduto.Iconimage_Selected = null;
            this.btnAgregarProduto.IconMarginLeft = 30;
            this.btnAgregarProduto.IconMarginRight = 0;
            this.btnAgregarProduto.IconRightVisible = true;
            this.btnAgregarProduto.IconRightZoom = 0D;
            this.btnAgregarProduto.IconVisible = true;
            this.btnAgregarProduto.IconZoom = 50D;
            this.btnAgregarProduto.IsTab = false;
            this.btnAgregarProduto.Location = new System.Drawing.Point(580, 238);
            this.btnAgregarProduto.Name = "btnAgregarProduto";
            this.btnAgregarProduto.Normalcolor = System.Drawing.Color.OliveDrab;
            this.btnAgregarProduto.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAgregarProduto.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAgregarProduto.selected = false;
            this.btnAgregarProduto.Size = new System.Drawing.Size(241, 48);
            this.btnAgregarProduto.TabIndex = 22;
            this.btnAgregarProduto.Text = "Registrar Producto";
            this.btnAgregarProduto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregarProduto.Textcolor = System.Drawing.Color.White;
            this.btnAgregarProduto.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProduto.Click += new System.EventHandler(this.btnAgregarProduto_Click);
            // 
            // btnEditarProducto
            // 
            this.btnEditarProducto.Activecolor = System.Drawing.Color.YellowGreen;
            this.btnEditarProducto.BackColor = System.Drawing.Color.OliveDrab;
            this.btnEditarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditarProducto.BorderRadius = 0;
            this.btnEditarProducto.ButtonText = "Modificar Producto";
            this.btnEditarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarProducto.DisabledColor = System.Drawing.Color.Gray;
            this.btnEditarProducto.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditarProducto.Iconimage = global::Factura.Properties.Resources.edit_24px;
            this.btnEditarProducto.Iconimage_right = null;
            this.btnEditarProducto.Iconimage_right_Selected = null;
            this.btnEditarProducto.Iconimage_Selected = null;
            this.btnEditarProducto.IconMarginLeft = 30;
            this.btnEditarProducto.IconMarginRight = 0;
            this.btnEditarProducto.IconRightVisible = true;
            this.btnEditarProducto.IconRightZoom = 0D;
            this.btnEditarProducto.IconVisible = true;
            this.btnEditarProducto.IconZoom = 50D;
            this.btnEditarProducto.IsTab = false;
            this.btnEditarProducto.Location = new System.Drawing.Point(580, 238);
            this.btnEditarProducto.Name = "btnEditarProducto";
            this.btnEditarProducto.Normalcolor = System.Drawing.Color.OliveDrab;
            this.btnEditarProducto.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnEditarProducto.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditarProducto.selected = false;
            this.btnEditarProducto.Size = new System.Drawing.Size(241, 48);
            this.btnEditarProducto.TabIndex = 23;
            this.btnEditarProducto.Text = "Modificar Producto";
            this.btnEditarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditarProducto.Textcolor = System.Drawing.Color.White;
            this.btnEditarProducto.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarProducto.Visible = false;
            this.btnEditarProducto.Click += new System.EventHandler(this.btnEditarProducto_Click);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 376);
            this.Controls.Add(this.btnEditarProducto);
            this.Controls.Add(this.btnAgregarProduto);
            this.Controls.Add(this.bunifuCards2);
            this.Controls.Add(this.bunifuCards1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Productos";
            this.Text = "Nuevo Producto";
            this.Load += new System.EventHandler(this.Productos_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox txtProducto;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox txtPrecio;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox txtCosto;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox txtExistencia;
        public Bunifu.Framework.UI.BunifuFlatButton btnAgregarProduto;
        public Bunifu.Framework.UI.BunifuFlatButton btnEditarProducto;
        public System.Windows.Forms.TextBox txtIdProducto;
    }
}