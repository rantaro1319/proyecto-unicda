namespace Factura
{
    partial class ProductoFactura
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
            this.tablaDetalle = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboProducto = new System.Windows.Forms.ComboBox();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accessDataSet1 = new Factura.AccessDataSet1();
            this.productosTableAdapter = new Factura.AccessDataSet1TableAdapters.ProductosTableAdapter();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.btnEliminarDetalle = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtCantidad = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.lbResponsable = new System.Windows.Forms.Label();
            this.txtIdFactura = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboCliente = new System.Windows.Forms.ComboBox();
            this.uSERINFO1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.uSERINFOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbFechaActual = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.uSERINFOTableAdapter = new Factura.AccessDataSet1TableAdapters.USERINFOTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.uSERINFO1TableAdapter = new Factura.AccessDataSet1TableAdapters.USERINFO1TableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.btnVender = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessDataSet1)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uSERINFO1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERINFOBindingSource)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablaDetalle
            // 
            this.tablaDetalle.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tablaDetalle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaDetalle.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.tablaDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaDetalle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_producto,
            this.Producto,
            this.precio,
            this.Cantidad,
            this.subtotal});
            this.tablaDetalle.DoubleBuffered = true;
            this.tablaDetalle.EnableHeadersVisualStyles = false;
            this.tablaDetalle.HeaderBgColor = System.Drawing.Color.OliveDrab;
            this.tablaDetalle.HeaderForeColor = System.Drawing.Color.White;
            this.tablaDetalle.Location = new System.Drawing.Point(39, 266);
            this.tablaDetalle.MultiSelect = false;
            this.tablaDetalle.Name = "tablaDetalle";
            this.tablaDetalle.ReadOnly = true;
            this.tablaDetalle.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tablaDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaDetalle.Size = new System.Drawing.Size(671, 252);
            this.tablaDetalle.TabIndex = 10;
            // 
            // Id_producto
            // 
            this.Id_producto.HeaderText = "ID Producto";
            this.Id_producto.Name = "Id_producto";
            this.Id_producto.ReadOnly = true;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // comboProducto
            // 
            this.comboProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboProducto.DataSource = this.productosBindingSource;
            this.comboProducto.DisplayMember = "nombreProducto";
            this.comboProducto.FormattingEnabled = true;
            this.comboProducto.Location = new System.Drawing.Point(131, 75);
            this.comboProducto.Name = "comboProducto";
            this.comboProducto.Size = new System.Drawing.Size(169, 21);
            this.comboProducto.TabIndex = 11;
            this.comboProducto.ValueMember = "Id_producto";
            this.comboProducto.SelectedIndexChanged += new System.EventHandler(this.comboProducto_SelectedIndexChanged);
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.accessDataSet1;
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
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.YellowGreen;
            this.bunifuCards1.Controls.Add(this.btnEliminarDetalle);
            this.bunifuCards1.Controls.Add(this.txtCantidad);
            this.bunifuCards1.Controls.Add(this.label4);
            this.bunifuCards1.Controls.Add(this.label3);
            this.bunifuCards1.Controls.Add(this.label1);
            this.bunifuCards1.Controls.Add(this.btnAgregar);
            this.bunifuCards1.Controls.Add(this.comboProducto);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(459, 60);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(451, 181);
            this.bunifuCards1.TabIndex = 12;
            // 
            // btnEliminarDetalle
            // 
            this.btnEliminarDetalle.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEliminarDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminarDetalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarDetalle.BorderRadius = 0;
            this.btnEliminarDetalle.ButtonText = "Eliminar";
            this.btnEliminarDetalle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarDetalle.DisabledColor = System.Drawing.Color.Gray;
            this.btnEliminarDetalle.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEliminarDetalle.Iconimage = global::Factura.Properties.Resources.Borrar;
            this.btnEliminarDetalle.Iconimage_right = null;
            this.btnEliminarDetalle.Iconimage_right_Selected = null;
            this.btnEliminarDetalle.Iconimage_Selected = null;
            this.btnEliminarDetalle.IconMarginLeft = 0;
            this.btnEliminarDetalle.IconMarginRight = 0;
            this.btnEliminarDetalle.IconRightVisible = true;
            this.btnEliminarDetalle.IconRightZoom = 0D;
            this.btnEliminarDetalle.IconVisible = true;
            this.btnEliminarDetalle.IconZoom = 50D;
            this.btnEliminarDetalle.IsTab = false;
            this.btnEliminarDetalle.Location = new System.Drawing.Point(320, 122);
            this.btnEliminarDetalle.Name = "btnEliminarDetalle";
            this.btnEliminarDetalle.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminarDetalle.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnEliminarDetalle.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEliminarDetalle.selected = false;
            this.btnEliminarDetalle.Size = new System.Drawing.Size(111, 33);
            this.btnEliminarDetalle.TabIndex = 28;
            this.btnEliminarDetalle.Text = "Eliminar";
            this.btnEliminarDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEliminarDetalle.Textcolor = System.Drawing.Color.White;
            this.btnEliminarDetalle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDetalle.Click += new System.EventHandler(this.btnEliminarDetalle_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtCantidad.Location = new System.Drawing.Point(131, 132);
            this.txtCantidad.MaxLength = 7;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(169, 20);
            this.txtCantidad.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Agregar Articulos";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAgregar.BackColor = System.Drawing.Color.OliveDrab;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.BorderRadius = 0;
            this.btnAgregar.ButtonText = "Agregar";
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.DisabledColor = System.Drawing.Color.Gray;
            this.btnAgregar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregar.Iconimage = global::Factura.Properties.Resources.Nuevo;
            this.btnAgregar.Iconimage_right = null;
            this.btnAgregar.Iconimage_right_Selected = null;
            this.btnAgregar.Iconimage_Selected = null;
            this.btnAgregar.IconMarginLeft = 0;
            this.btnAgregar.IconMarginRight = 0;
            this.btnAgregar.IconRightVisible = true;
            this.btnAgregar.IconRightZoom = 0D;
            this.btnAgregar.IconVisible = true;
            this.btnAgregar.IconZoom = 60D;
            this.btnAgregar.IsTab = false;
            this.btnAgregar.Location = new System.Drawing.Point(320, 75);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Normalcolor = System.Drawing.Color.OliveDrab;
            this.btnAgregar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAgregar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAgregar.selected = false;
            this.btnAgregar.Size = new System.Drawing.Size(111, 34);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregar.Textcolor = System.Drawing.Color.White;
            this.btnAgregar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.OliveDrab;
            this.bunifuCards2.Controls.Add(this.lbResponsable);
            this.bunifuCards2.Controls.Add(this.txtIdFactura);
            this.bunifuCards2.Controls.Add(this.label10);
            this.bunifuCards2.Controls.Add(this.comboCliente);
            this.bunifuCards2.Controls.Add(this.label5);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(39, 60);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(382, 181);
            this.bunifuCards2.TabIndex = 13;
            // 
            // lbResponsable
            // 
            this.lbResponsable.AutoSize = true;
            this.lbResponsable.Location = new System.Drawing.Point(94, 152);
            this.lbResponsable.Name = "lbResponsable";
            this.lbResponsable.Size = new System.Drawing.Size(77, 13);
            this.lbResponsable.TabIndex = 29;
            this.lbResponsable.Text = "lbResponsable";
            this.lbResponsable.Visible = false;
            // 
            // txtIdFactura
            // 
            this.txtIdFactura.Location = new System.Drawing.Point(97, 47);
            this.txtIdFactura.Name = "txtIdFactura";
            this.txtIdFactura.Size = new System.Drawing.Size(100, 20);
            this.txtIdFactura.TabIndex = 25;
            this.txtIdFactura.Text = "0";
            this.txtIdFactura.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "Cliente";
            // 
            // comboCliente
            // 
            this.comboCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboCliente.DataSource = this.uSERINFO1BindingSource;
            this.comboCliente.DisplayMember = "Expr1";
            this.comboCliente.FormattingEnabled = true;
            this.comboCliente.Location = new System.Drawing.Point(97, 99);
            this.comboCliente.Name = "comboCliente";
            this.comboCliente.Size = new System.Drawing.Size(198, 21);
            this.comboCliente.TabIndex = 23;
            this.comboCliente.ValueMember = "Badgenumber";
            // 
            // uSERINFO1BindingSource
            // 
            this.uSERINFO1BindingSource.DataMember = "USERINFO1";
            this.uSERINFO1BindingSource.DataSource = this.accessDataSet1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "Datos de Factura";
            // 
            // uSERINFOBindingSource
            // 
            this.uSERINFOBindingSource.DataMember = "USERINFO";
            this.uSERINFOBindingSource.DataSource = this.accessDataSet1;
            // 
            // lbFechaActual
            // 
            this.lbFechaActual.AutoSize = true;
            this.lbFechaActual.Location = new System.Drawing.Point(738, 302);
            this.lbFechaActual.Name = "lbFechaActual";
            this.lbFechaActual.Size = new System.Drawing.Size(22, 13);
            this.lbFechaActual.TabIndex = 20;
            this.lbFechaActual.Text = "-----";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(737, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Fecha";
            // 
            // uSERINFOTableAdapter
            // 
            this.uSERINFOTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1010, 25);
            this.fillByToolStrip.TabIndex = 22;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // uSERINFO1TableAdapter
            // 
            this.uSERINFO1TableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkGray;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(737, 331);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label7.Size = new System.Drawing.Size(78, 33);
            this.label7.TabIndex = 23;
            this.label7.Text = "Total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(735, 376);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "RD$";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(779, 376);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(34, 20);
            this.lbTotal.TabIndex = 25;
            this.lbTotal.Text = "0.0";
            // 
            // btnVender
            // 
            this.btnVender.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnVender.BackColor = System.Drawing.Color.OliveDrab;
            this.btnVender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVender.BorderRadius = 0;
            this.btnVender.ButtonText = "Vender";
            this.btnVender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVender.DisabledColor = System.Drawing.Color.Gray;
            this.btnVender.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVender.Iconimage = global::Factura.Properties.Resources.compra;
            this.btnVender.Iconimage_right = null;
            this.btnVender.Iconimage_right_Selected = null;
            this.btnVender.Iconimage_Selected = null;
            this.btnVender.IconMarginLeft = 0;
            this.btnVender.IconMarginRight = 0;
            this.btnVender.IconRightVisible = true;
            this.btnVender.IconRightZoom = 0D;
            this.btnVender.IconVisible = true;
            this.btnVender.IconZoom = 50D;
            this.btnVender.IsTab = false;
            this.btnVender.Location = new System.Drawing.Point(739, 444);
            this.btnVender.Name = "btnVender";
            this.btnVender.Normalcolor = System.Drawing.Color.OliveDrab;
            this.btnVender.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnVender.OnHoverTextColor = System.Drawing.Color.White;
            this.btnVender.selected = false;
            this.btnVender.Size = new System.Drawing.Size(168, 48);
            this.btnVender.TabIndex = 26;
            this.btnVender.Text = "Vender";
            this.btnVender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVender.Textcolor = System.Drawing.Color.White;
            this.btnVender.TextFont = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(739, 399);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(168, 18);
            this.bunifuSeparator1.TabIndex = 27;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // ProductoFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 548);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.bunifuCards2);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.lbFechaActual);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tablaDetalle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductoFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura de Articulos";
            this.Load += new System.EventHandler(this.ProductoFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessDataSet1)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uSERINFO1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERINFOBindingSource)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomDataGrid tablaDetalle;
        private System.Windows.Forms.ComboBox comboProducto;
        private AccessDataSet1 accessDataSet1;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private AccessDataSet1TableAdapters.ProductosTableAdapter productosTableAdapter;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnAgregar;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboCliente;
        private System.Windows.Forms.Label lbFechaActual;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource uSERINFOBindingSource;
        private AccessDataSet1TableAdapters.USERINFOTableAdapter uSERINFOTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.BindingSource uSERINFO1BindingSource;
        private AccessDataSet1TableAdapters.USERINFO1TableAdapter uSERINFO1TableAdapter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbTotal;
        private Bunifu.Framework.UI.BunifuFlatButton btnVender;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private Bunifu.Framework.UI.BunifuFlatButton btnEliminarDetalle;
        private System.Windows.Forms.TextBox txtIdFactura;
        private System.Windows.Forms.Label lbResponsable;
    }
}