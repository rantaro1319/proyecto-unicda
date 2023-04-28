namespace Factura
{
    partial class Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            this.label1 = new System.Windows.Forms.Label();
            this.pbMiUsuario = new System.Windows.Forms.PictureBox();
            this.pbUsuarios = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbMiUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Administrar Usuarios";
            // 
            // pbMiUsuario
            // 
            this.pbMiUsuario.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pbMiUsuario.BackColor = System.Drawing.Color.Transparent;
            this.pbMiUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pbMiUsuario.Image")));
            this.pbMiUsuario.Location = new System.Drawing.Point(763, 135);
            this.pbMiUsuario.Name = "pbMiUsuario";
            this.pbMiUsuario.Size = new System.Drawing.Size(209, 220);
            this.pbMiUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbMiUsuario.TabIndex = 14;
            this.pbMiUsuario.TabStop = false;
            this.pbMiUsuario.Click += new System.EventHandler(this.pbMiUsuario_Click);
            this.pbMiUsuario.MouseLeave += new System.EventHandler(this.pbMiUsuario_MouseLeave);
            this.pbMiUsuario.MouseHover += new System.EventHandler(this.pbMiUsuario_MouseHover);
            this.pbMiUsuario.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbMiUsuario_MouseMove);
            // 
            // pbUsuarios
            // 
            this.pbUsuarios.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pbUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.pbUsuarios.Image = global::Factura.Properties.Resources.usuarios100px;
            this.pbUsuarios.Location = new System.Drawing.Point(20, 135);
            this.pbUsuarios.Name = "pbUsuarios";
            this.pbUsuarios.Size = new System.Drawing.Size(209, 220);
            this.pbUsuarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbUsuarios.TabIndex = 12;
            this.pbUsuarios.TabStop = false;
            this.pbUsuarios.Click += new System.EventHandler(this.pbUsuarios_Click);
            this.pbUsuarios.MouseLeave += new System.EventHandler(this.pbUsuarios_MouseLeave);
            this.pbUsuarios.MouseHover += new System.EventHandler(this.pbUsuarios_MouseHover);
            this.pbUsuarios.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbUsuarios_MouseMove);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(820, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mis Datos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 39);
            this.label3.TabIndex = 16;
            this.label3.Text = "Cuenta";
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 508);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbMiUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.pbMiUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbUsuarios;
        private System.Windows.Forms.PictureBox pbMiUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}