namespace Factura
{
    partial class NuevoCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoCliente));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comboAcceso = new System.Windows.Forms.ComboBox();
            this.forceFPMake = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCaptarHuella = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label10 = new System.Windows.Forms.Label();
            this.comboGenero = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGuardarCliente = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEditar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clienteFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.clienteFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.facturaProductoTableAdapter1 = new Factura.AccessDataSet1TableAdapters.FacturaProductoTableAdapter();
            this.axAFXOnlineMain1 = new Axzkonline.AxAFXOnlineMain();
            this.txtTemplate = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAFXOnlineMain1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Correo Electronico";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Genero";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Telefono";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(193, 289);
            this.txtCorreo.MaxLength = 100;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(295, 22);
            this.txtCorreo.TabIndex = 12;
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoCliente.Location = new System.Drawing.Point(193, 139);
            this.txtApellidoCliente.MaxLength = 100;
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.Size = new System.Drawing.Size(295, 22);
            this.txtApellidoCliente.TabIndex = 9;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(193, 89);
            this.txtNombreCliente.MaxLength = 100;
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(295, 22);
            this.txtNombreCliente.TabIndex = 8;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCliente.Location = new System.Drawing.Point(193, 39);
            this.txtIdCliente.MaxLength = 9;
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(295, 24);
            this.txtIdCliente.TabIndex = 7;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(193, 239);
            this.txtTelefono.MaxLength = 15;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(295, 22);
            this.txtTelefono.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.comboAcceso);
            this.groupBox1.Controls.Add(this.forceFPMake);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnCaptarHuella);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.comboGenero);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIdCliente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNombreCliente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtApellidoCliente);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 447);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Cliente";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(519, 139);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 18);
            this.label14.TabIndex = 25;
            this.label14.Text = "ID";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(22, 399);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 18);
            this.label13.TabIndex = 24;
            this.label13.Text = "Nivel de Acceso";
            // 
            // comboAcceso
            // 
            this.comboAcceso.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.comboAcceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAcceso.FormattingEnabled = true;
            this.comboAcceso.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboAcceso.Location = new System.Drawing.Point(193, 398);
            this.comboAcceso.Name = "comboAcceso";
            this.comboAcceso.Size = new System.Drawing.Size(188, 23);
            this.comboAcceso.TabIndex = 23;
            this.comboAcceso.SelectedIndexChanged += new System.EventHandler(this.comboAcceso_SelectedIndexChanged);
            // 
            // forceFPMake
            // 
            this.forceFPMake.AutoSize = true;
            this.forceFPMake.Location = new System.Drawing.Point(366, 346);
            this.forceFPMake.Name = "forceFPMake";
            this.forceFPMake.Size = new System.Drawing.Size(15, 14);
            this.forceFPMake.TabIndex = 18;
            this.forceFPMake.UseVisualStyleBackColor = true;
            this.forceFPMake.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(378, 342);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 18);
            this.label11.TabIndex = 17;
            this.label11.Text = "Huella de advertencia";
            this.label11.Visible = false;
            // 
            // btnCaptarHuella
            // 
            this.btnCaptarHuella.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCaptarHuella.BackColor = System.Drawing.Color.YellowGreen;
            this.btnCaptarHuella.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCaptarHuella.BorderRadius = 0;
            this.btnCaptarHuella.ButtonText = "Captar Huella";
            this.btnCaptarHuella.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCaptarHuella.DisabledColor = System.Drawing.Color.Gray;
            this.btnCaptarHuella.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCaptarHuella.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCaptarHuella.Iconimage")));
            this.btnCaptarHuella.Iconimage_right = null;
            this.btnCaptarHuella.Iconimage_right_Selected = null;
            this.btnCaptarHuella.Iconimage_Selected = null;
            this.btnCaptarHuella.IconMarginLeft = 0;
            this.btnCaptarHuella.IconMarginRight = 0;
            this.btnCaptarHuella.IconRightVisible = false;
            this.btnCaptarHuella.IconRightZoom = 0D;
            this.btnCaptarHuella.IconVisible = false;
            this.btnCaptarHuella.IconZoom = 60D;
            this.btnCaptarHuella.IsTab = false;
            this.btnCaptarHuella.Location = new System.Drawing.Point(193, 332);
            this.btnCaptarHuella.Name = "btnCaptarHuella";
            this.btnCaptarHuella.Normalcolor = System.Drawing.Color.YellowGreen;
            this.btnCaptarHuella.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnCaptarHuella.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCaptarHuella.selected = false;
            this.btnCaptarHuella.Size = new System.Drawing.Size(149, 41);
            this.btnCaptarHuella.TabIndex = 16;
            this.btnCaptarHuella.Text = "Captar Huella";
            this.btnCaptarHuella.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaptarHuella.Textcolor = System.Drawing.Color.White;
            this.btnCaptarHuella.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaptarHuella.Click += new System.EventHandler(this.btnCaptarHuella_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 342);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 18);
            this.label10.TabIndex = 15;
            this.label10.Text = "Registrar Huella";
            // 
            // comboGenero
            // 
            this.comboGenero.DisplayMember = "m";
            this.comboGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboGenero.FormattingEnabled = true;
            this.comboGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.comboGenero.Location = new System.Drawing.Point(193, 190);
            this.comboGenero.Name = "comboGenero";
            this.comboGenero.Size = new System.Drawing.Size(295, 24);
            this.comboGenero.TabIndex = 14;
            this.comboGenero.SelectedIndexChanged += new System.EventHandler(this.comboGenero_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(494, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 24);
            this.label8.TabIndex = 13;
            this.label8.Text = "*";
            // 
            // btnGuardarCliente
            // 
            this.btnGuardarCliente.Activecolor = System.Drawing.Color.DarkOliveGreen;
            this.btnGuardarCliente.BackColor = System.Drawing.Color.OliveDrab;
            this.btnGuardarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardarCliente.BorderRadius = 0;
            this.btnGuardarCliente.ButtonText = "Guardar";
            this.btnGuardarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarCliente.DisabledColor = System.Drawing.Color.Gray;
            this.btnGuardarCliente.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGuardarCliente.Iconimage = global::Factura.Properties.Resources.save_24px;
            this.btnGuardarCliente.Iconimage_right = null;
            this.btnGuardarCliente.Iconimage_right_Selected = null;
            this.btnGuardarCliente.Iconimage_Selected = null;
            this.btnGuardarCliente.IconMarginLeft = 0;
            this.btnGuardarCliente.IconMarginRight = 0;
            this.btnGuardarCliente.IconRightVisible = false;
            this.btnGuardarCliente.IconRightZoom = 0D;
            this.btnGuardarCliente.IconVisible = false;
            this.btnGuardarCliente.IconZoom = 50D;
            this.btnGuardarCliente.IsTab = false;
            this.btnGuardarCliente.Location = new System.Drawing.Point(2, 0);
            this.btnGuardarCliente.Name = "btnGuardarCliente";
            this.btnGuardarCliente.Normalcolor = System.Drawing.Color.OliveDrab;
            this.btnGuardarCliente.OnHovercolor = System.Drawing.Color.YellowGreen;
            this.btnGuardarCliente.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGuardarCliente.selected = false;
            this.btnGuardarCliente.Size = new System.Drawing.Size(181, 49);
            this.btnGuardarCliente.TabIndex = 14;
            this.btnGuardarCliente.Text = "Guardar";
            this.btnGuardarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardarCliente.Textcolor = System.Drawing.Color.White;
            this.btnGuardarCliente.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCliente.Click += new System.EventHandler(this.BtnGuardarCliente_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Activecolor = System.Drawing.Color.DarkOliveGreen;
            this.btnEditar.BackColor = System.Drawing.Color.OliveDrab;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.BorderRadius = 0;
            this.btnEditar.ButtonText = "Modificar";
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.DisabledColor = System.Drawing.Color.Gray;
            this.btnEditar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditar.Iconimage = global::Factura.Properties.Resources.save_24px;
            this.btnEditar.Iconimage_right = null;
            this.btnEditar.Iconimage_right_Selected = null;
            this.btnEditar.Iconimage_Selected = null;
            this.btnEditar.IconMarginLeft = 0;
            this.btnEditar.IconMarginRight = 0;
            this.btnEditar.IconRightVisible = false;
            this.btnEditar.IconRightZoom = 0D;
            this.btnEditar.IconVisible = false;
            this.btnEditar.IconZoom = 50D;
            this.btnEditar.IsTab = false;
            this.btnEditar.Location = new System.Drawing.Point(409, 618);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Normalcolor = System.Drawing.Color.OliveDrab;
            this.btnEditar.OnHovercolor = System.Drawing.Color.YellowGreen;
            this.btnEditar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditar.selected = false;
            this.btnEditar.Size = new System.Drawing.Size(181, 49);
            this.btnEditar.TabIndex = 15;
            this.btnEditar.Text = "Modificar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditar.Textcolor = System.Drawing.Color.White;
            this.btnEditar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnGuardarCliente);
            this.panel2.Location = new System.Drawing.Point(408, 618);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(183, 49);
            this.panel2.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.clienteFechaFinal);
            this.groupBox2.Controls.Add(this.clienteFechaInicial);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(32, 489);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(562, 123);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fechas de Acceso";
            // 
            // clienteFechaFinal
            // 
            this.clienteFechaFinal.Enabled = false;
            this.clienteFechaFinal.Location = new System.Drawing.Point(200, 60);
            this.clienteFechaFinal.Name = "clienteFechaFinal";
            this.clienteFechaFinal.Size = new System.Drawing.Size(288, 20);
            this.clienteFechaFinal.TabIndex = 6;
            // 
            // clienteFechaInicial
            // 
            this.clienteFechaInicial.Enabled = false;
            this.clienteFechaInicial.Location = new System.Drawing.Point(200, 25);
            this.clienteFechaInicial.Name = "clienteFechaInicial";
            this.clienteFechaInicial.Size = new System.Drawing.Size(288, 20);
            this.clienteFechaInicial.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 18);
            this.label9.TabIndex = 4;
            this.label9.Text = "Fecha final de Acceso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Fecha inicial de Acceso";
            // 
            // facturaProductoTableAdapter1
            // 
            this.facturaProductoTableAdapter1.ClearBeforeFill = true;
            // 
            // axAFXOnlineMain1
            // 
            this.axAFXOnlineMain1.Location = new System.Drawing.Point(0, 0);
            this.axAFXOnlineMain1.Name = "axAFXOnlineMain1";
            this.axAFXOnlineMain1.TabIndex = 23;
            this.axAFXOnlineMain1.Visible = false;
            // 
            // txtTemplate
            // 
            this.txtTemplate.Location = new System.Drawing.Point(84, 633);
            this.txtTemplate.Name = "txtTemplate";
            this.txtTemplate.Size = new System.Drawing.Size(100, 20);
            this.txtTemplate.TabIndex = 18;
            this.txtTemplate.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 562);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 20;
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 673);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(603, 22);
            this.statusBar1.TabIndex = 22;
            this.statusBar1.Text = "statusBar1";
            // 
            // NuevoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(603, 695);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.axAFXOnlineMain1);
            this.Controls.Add(this.txtTemplate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NuevoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nuevo Cliente";
            this.Load += new System.EventHandler(this.NuevoCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAFXOnlineMain1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtCorreo;
        public System.Windows.Forms.TextBox txtApellidoCliente;
        public System.Windows.Forms.TextBox txtNombreCliente;
        public System.Windows.Forms.TextBox txtIdCliente;
        public System.Windows.Forms.TextBox txtTelefono;
        public Bunifu.Framework.UI.BunifuFlatButton btnGuardarCliente;
        public System.Windows.Forms.ComboBox comboGenero;
        public Bunifu.Framework.UI.BunifuFlatButton btnEditar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.DateTimePicker clienteFechaFinal;
        public System.Windows.Forms.DateTimePicker clienteFechaInicial;
        public System.Windows.Forms.GroupBox groupBox2;
        private AccessDataSet1TableAdapters.FacturaProductoTableAdapter facturaProductoTableAdapter1;
        private Bunifu.Framework.UI.BunifuFlatButton btnCaptarHuella;
        private System.Windows.Forms.Label label10;
        private Axzkonline.AxAFXOnlineMain axAFXOnlineMain1;
        private System.Windows.Forms.TextBox txtTemplate;
        private System.Windows.Forms.CheckBox forceFPMake;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.ComboBox comboAcceso;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}