namespace Factura
{
    partial class Producto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.EliminarProducto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.EditarProducto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.NuevoProducto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BuscarProducto = new System.Windows.Forms.TextBox();
            this.bunifuCards3 = new Bunifu.Framework.UI.BunifuCards();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuCards4 = new Bunifu.Framework.UI.BunifuCards();
            this.label1 = new System.Windows.Forms.Label();
            this.tablaProducto = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.accessDataSet1 = new Factura.AccessDataSet1();
            this.productosTableAdapter = new Factura.AccessDataSet1TableAdapters.ProductosTableAdapter();
            this.bunifuCards3.SuspendLayout();
            this.bunifuCards4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // EliminarProducto
            // 
            this.EliminarProducto.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.EliminarProducto.BackColor = System.Drawing.Color.OliveDrab;
            this.EliminarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EliminarProducto.BorderRadius = 0;
            this.EliminarProducto.ButtonText = "Eliminar";
            this.EliminarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EliminarProducto.DisabledColor = System.Drawing.Color.Gray;
            this.EliminarProducto.Iconcolor = System.Drawing.Color.Transparent;
            this.EliminarProducto.Iconimage = global::Factura.Properties.Resources.Borrar;
            this.EliminarProducto.Iconimage_right = null;
            this.EliminarProducto.Iconimage_right_Selected = null;
            this.EliminarProducto.Iconimage_Selected = null;
            this.EliminarProducto.IconMarginLeft = 0;
            this.EliminarProducto.IconMarginRight = 0;
            this.EliminarProducto.IconRightVisible = true;
            this.EliminarProducto.IconRightZoom = 0D;
            this.EliminarProducto.IconVisible = true;
            this.EliminarProducto.IconZoom = 35D;
            this.EliminarProducto.IsTab = false;
            this.EliminarProducto.Location = new System.Drawing.Point(286, 83);
            this.EliminarProducto.Name = "EliminarProducto";
            this.EliminarProducto.Normalcolor = System.Drawing.Color.OliveDrab;
            this.EliminarProducto.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.EliminarProducto.OnHoverTextColor = System.Drawing.Color.White;
            this.EliminarProducto.selected = false;
            this.EliminarProducto.Size = new System.Drawing.Size(110, 33);
            this.EliminarProducto.TabIndex = 20;
            this.EliminarProducto.Text = "Eliminar";
            this.EliminarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EliminarProducto.Textcolor = System.Drawing.Color.White;
            this.EliminarProducto.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarProducto.Click += new System.EventHandler(this.BtnEliminarProducto_Click);
            // 
            // EditarProducto
            // 
            this.EditarProducto.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.EditarProducto.BackColor = System.Drawing.Color.OliveDrab;
            this.EditarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditarProducto.BorderRadius = 0;
            this.EditarProducto.ButtonText = "Modificar";
            this.EditarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditarProducto.DisabledColor = System.Drawing.Color.Gray;
            this.EditarProducto.Iconcolor = System.Drawing.Color.Transparent;
            this.EditarProducto.Iconimage = global::Factura.Properties.Resources.edit_24px;
            this.EditarProducto.Iconimage_right = null;
            this.EditarProducto.Iconimage_right_Selected = null;
            this.EditarProducto.Iconimage_Selected = null;
            this.EditarProducto.IconMarginLeft = 0;
            this.EditarProducto.IconMarginRight = 0;
            this.EditarProducto.IconRightVisible = true;
            this.EditarProducto.IconRightZoom = 0D;
            this.EditarProducto.IconVisible = true;
            this.EditarProducto.IconZoom = 35D;
            this.EditarProducto.IsTab = false;
            this.EditarProducto.Location = new System.Drawing.Point(170, 83);
            this.EditarProducto.Name = "EditarProducto";
            this.EditarProducto.Normalcolor = System.Drawing.Color.OliveDrab;
            this.EditarProducto.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.EditarProducto.OnHoverTextColor = System.Drawing.Color.White;
            this.EditarProducto.selected = false;
            this.EditarProducto.Size = new System.Drawing.Size(110, 33);
            this.EditarProducto.TabIndex = 19;
            this.EditarProducto.Text = "Modificar";
            this.EditarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EditarProducto.Textcolor = System.Drawing.Color.White;
            this.EditarProducto.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditarProducto.Click += new System.EventHandler(this.BtnEditarProducto_Click);
            // 
            // NuevoProducto
            // 
            this.NuevoProducto.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.NuevoProducto.BackColor = System.Drawing.Color.OliveDrab;
            this.NuevoProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NuevoProducto.BorderRadius = 0;
            this.NuevoProducto.ButtonText = "Nuevo Producto";
            this.NuevoProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NuevoProducto.DisabledColor = System.Drawing.Color.Gray;
            this.NuevoProducto.Iconcolor = System.Drawing.Color.Transparent;
            this.NuevoProducto.Iconimage = global::Factura.Properties.Resources.Nuevo;
            this.NuevoProducto.Iconimage_right = null;
            this.NuevoProducto.Iconimage_right_Selected = null;
            this.NuevoProducto.Iconimage_Selected = null;
            this.NuevoProducto.IconMarginLeft = 0;
            this.NuevoProducto.IconMarginRight = 0;
            this.NuevoProducto.IconRightVisible = true;
            this.NuevoProducto.IconRightZoom = 0D;
            this.NuevoProducto.IconVisible = true;
            this.NuevoProducto.IconZoom = 45D;
            this.NuevoProducto.IsTab = false;
            this.NuevoProducto.Location = new System.Drawing.Point(22, 83);
            this.NuevoProducto.Name = "NuevoProducto";
            this.NuevoProducto.Normalcolor = System.Drawing.Color.OliveDrab;
            this.NuevoProducto.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.NuevoProducto.OnHoverTextColor = System.Drawing.Color.White;
            this.NuevoProducto.selected = false;
            this.NuevoProducto.Size = new System.Drawing.Size(142, 33);
            this.NuevoProducto.TabIndex = 18;
            this.NuevoProducto.Text = "Nuevo Producto";
            this.NuevoProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NuevoProducto.Textcolor = System.Drawing.Color.White;
            this.NuevoProducto.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoProducto.Click += new System.EventHandler(this.btnNuevoProducto_Click);
            // 
            // BuscarProducto
            // 
            this.BuscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarProducto.Location = new System.Drawing.Point(19, 72);
            this.BuscarProducto.Name = "BuscarProducto";
            this.BuscarProducto.Size = new System.Drawing.Size(319, 26);
            this.BuscarProducto.TabIndex = 21;
            this.BuscarProducto.TextChanged += new System.EventHandler(this.BuscarProducto_TextChanged);
            this.BuscarProducto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BuscarProducto_KeyUp);
            // 
            // bunifuCards3
            // 
            this.bunifuCards3.BackColor = System.Drawing.Color.White;
            this.bunifuCards3.BorderRadius = 5;
            this.bunifuCards3.BottomSahddow = true;
            this.bunifuCards3.color = System.Drawing.Color.YellowGreen;
            this.bunifuCards3.Controls.Add(this.label3);
            this.bunifuCards3.Controls.Add(this.BuscarProducto);
            this.bunifuCards3.LeftSahddow = false;
            this.bunifuCards3.Location = new System.Drawing.Point(0, 100);
            this.bunifuCards3.Name = "bunifuCards3";
            this.bunifuCards3.RightSahddow = true;
            this.bunifuCards3.ShadowDepth = 20;
            this.bunifuCards3.Size = new System.Drawing.Size(434, 139);
            this.bunifuCards3.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Buscar Productos";
            // 
            // bunifuCards4
            // 
            this.bunifuCards4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards4.BackColor = System.Drawing.Color.White;
            this.bunifuCards4.BorderRadius = 5;
            this.bunifuCards4.BottomSahddow = true;
            this.bunifuCards4.color = System.Drawing.Color.YellowGreen;
            this.bunifuCards4.Controls.Add(this.label1);
            this.bunifuCards4.Controls.Add(this.EliminarProducto);
            this.bunifuCards4.Controls.Add(this.EditarProducto);
            this.bunifuCards4.Controls.Add(this.NuevoProducto);
            this.bunifuCards4.LeftSahddow = false;
            this.bunifuCards4.Location = new System.Drawing.Point(620, 100);
            this.bunifuCards4.Name = "bunifuCards4";
            this.bunifuCards4.RightSahddow = true;
            this.bunifuCards4.ShadowDepth = 20;
            this.bunifuCards4.Size = new System.Drawing.Size(411, 139);
            this.bunifuCards4.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Administrar Productos";
            // 
            // tablaProducto
            // 
            this.tablaProducto.AllowUserToAddRows = false;
            this.tablaProducto.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tablaProducto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaProducto.AutoGenerateColumns = false;
            this.tablaProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaProducto.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.tablaProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaProducto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn4});
            this.tablaProducto.DataSource = this.bindingSource1;
            this.tablaProducto.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tablaProducto.DoubleBuffered = true;
            this.tablaProducto.EnableHeadersVisualStyles = false;
            this.tablaProducto.HeaderBgColor = System.Drawing.Color.OliveDrab;
            this.tablaProducto.HeaderForeColor = System.Drawing.Color.White;
            this.tablaProducto.Location = new System.Drawing.Point(0, 245);
            this.tablaProducto.MultiSelect = false;
            this.tablaProducto.Name = "tablaProducto";
            this.tablaProducto.ReadOnly = true;
            this.tablaProducto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tablaProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaProducto.Size = new System.Drawing.Size(1055, 378);
            this.tablaProducto.TabIndex = 24;
            this.tablaProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaProducto_CellContentClick);
            this.tablaProducto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaProducto_CellDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 45);
            this.label4.TabIndex = 25;
            this.label4.Text = "Inventario";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Id_producto";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nombreProducto";
            this.dataGridViewTextBoxColumn3.HeaderText = "Producto";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "precio";
            dataGridViewCellStyle3.Format = "C2";
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn5.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "costo";
            dataGridViewCellStyle4.Format = "C2";
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn6.HeaderText = "Costo";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "cantidad";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Olive;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn4.HeaderText = "Existencia";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Productos";
            this.bindingSource1.DataSource = this.accessDataSet1;
            // 
            // accessDataSet1
            // 
            this.accessDataSet1.DataSetName = "AccessDataSet1";
            this.accessDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // Producto
            // 
            this.ClientSize = new System.Drawing.Size(1055, 623);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tablaProducto);
            this.Controls.Add(this.bunifuCards4);
            this.Controls.Add(this.bunifuCards3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Producto";
            this.Load += new System.EventHandler(this.Producto_Load_1);
            this.bunifuCards3.ResumeLayout(false);
            this.bunifuCards3.PerformLayout();
            this.bunifuCards4.ResumeLayout(false);
            this.bunifuCards4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCerrar;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private AccessDataSet1 accessDataSet;
        private Bunifu.Framework.UI.BunifuFlatButton btnNuevoProducto;
        private Bunifu.Framework.UI.BunifuFlatButton btnEliminarProducto;
        private Bunifu.Framework.UI.BunifuFlatButton btnEditarProducto;
        public Bunifu.Framework.UI.BunifuCustomDataGrid tablaProductos;
        private System.Windows.Forms.BindingSource productosBindingSource;
        //private AccessDataSetTableAdapters.ProductosTableAdapter productosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproductoDataGridViewTextBoxColumn1;
        private Bunifu.Framework.UI.BunifuFlatButton EliminarProducto;
        private Bunifu.Framework.UI.BunifuFlatButton EditarProducto;
        private Bunifu.Framework.UI.BunifuFlatButton NuevoProducto;
        private System.Windows.Forms.TextBox BuscarProducto;
        private Bunifu.Framework.UI.BunifuCards bunifuCards3;
        private Bunifu.Framework.UI.BunifuCards bunifuCards4;
        private AccessDataSet1 accessDataSet1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private AccessDataSet1TableAdapters.ProductosTableAdapter productosTableAdapter;
        public Bunifu.Framework.UI.BunifuCustomDataGrid tablaProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label4;
    }
}