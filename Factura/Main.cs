using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factura
{
    public partial class Main : Form
    {
        public void AbrirForm(object Formhijo)
        {
            //Main fm = new Main();
            if (this.panelCentral.Controls.Count > 0)
                this.panelCentral.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelCentral.Controls.Add(fh);
            this.panelCentral.Tag = fh;
            fh.Show();
        }

        void cargarFoto(string imagen)
        {
            string ruta = Application.StartupPath + @"\resource\"+imagen;
            if (File.Exists(ruta))
            {
                pictureBox2.Image = Image.FromFile(ruta);
            }
            else
            {
                pictureBox2.Image = Properties.Resources.COAN_DOMINICANA_BLANCO_02;
            }    
        }

        string nombreImagen()
        {
            string nombre = "";
            
            OleDbConnection Conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\ZKTeco\\ZKAccess3.5\\Access.mdb");
            Conexion.Open();
            String Consulta = "SELECT * FROM empresa;";
            OleDbCommand Comando = new OleDbCommand(Consulta, Conexion);
            OleDbDataReader LectorDatos;
            LectorDatos = Comando.ExecuteReader();
            LectorDatos.Read();
            if (LectorDatos.HasRows)
            {
                nombre = LectorDatos["ruta"].ToString();
                return nombre;
            }

            return nombre;
            
        }

        Form1 form1 = new Form1();
        
        public Main()
        {
            InitializeComponent();
            btnUsuario.Text = form1.getNombreUsuario();
            AbrirForm(new AccesosDirectos());
            cargarFoto(nombreImagen());
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        

        //public void AbrirFormExterno( object Formhijo)
        //{
        //    Main fm = new Main();
        //    if (fm.panelCentral.Controls.Count > 0)
        //        fm.panelCentral.Controls.RemoveAt(0);
        //    Form fh = Formhijo as Form;
        //    fh.TopLevel = false;
        //    fh.Dock = DockStyle.Fill;
        //    fm.panelCentral.Controls.Add(fh);
        //    fm.panelCentral.Tag = fh;
        //    fh.Show();
        //}

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            var salir = MessageBox.Show("Desea salir del sistema?", "Salir del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (salir == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnFactura_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            if (form.verificarLicencia())
            {
                AbrirForm(new tipoFactura());
            }
            else
            {
                MessageBox.Show("Comuniquese con los tecnicos para su mantenimiento periodico del sistema", "Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            var salir = MessageBox.Show("Desea salir del sistema?", "Salir del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (salir == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {


        }

        private bool mouseDown;
        private Point lastLocation;

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {

            mouseDown = true;
            lastLocation = e.Location;

        }

        private void BarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void BarraTitulo_MouseUp(object sender, MouseEventArgs e)
        {

            mouseDown = false;
        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }



        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();

            if (form.verificarLicencia())
            {
                AbrirForm(new Clientes());
            }
            else
            {
               MessageBox.Show("Comuniquese con los tecnicos para su mantenimiento periodico del sistema", "Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void PanelCentral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            if (form.verificarLicencia())
            {
                //AbrirForm(new Producto());

                if (form.isAdmin())
                {
                    AbrirForm(new Producto());
                }
                else
                {
                    MessageBox.Show("Solo el administrador puede acceder a este modulo", "Nivel de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                MessageBox.Show("Comuniquese con los tecnicos para su mantenimiento periodico del sistema", "Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            if (form.verificarLicencia())
            {
                // AbrirForm(new Reportes());
                if (form.isAdmin())
                {
                    AbrirForm(new Reportes());
                }
                else
                {
                    MessageBox.Show("Solo el administrador puede acceder a este modulo", "Nivel de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
            }
            else
            {
                MessageBox.Show("Comuniquese con los tecnicos para su mantenimiento periodico del sistema", "Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            string ID = form.getIdUsuario();
            if (form.isAdmin())
            {
                AbrirForm(new Usuarios());
            }
            else
            {
                OleDbConnection Conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\ZKTeco\\ZKAccess3.5\\Access.mdb");
                Conexion.Open();

                String Consulta = "SELECT * FROM RegistroEmpleado WHERE Id_usuario = '" + ID + "';";
                OleDbCommand Comando = new OleDbCommand(Consulta, Conexion);
                OleDbDataReader LectorDatos;
                LectorDatos = Comando.ExecuteReader();
                LectorDatos.Read();

                NuevoUsuario usuario = new NuevoUsuario();


                //Cambiar los Labels del formulario de Agregar Usuarios
                //frm.btnGuardarUsuario.Text = "Modificar";

                usuario.txtIdUsuario.Enabled = false;
                usuario.btnModificarUsuario.Visible = true;
                usuario.btnGuardarUsuario.Visible = false;
                usuario.comboRol.Enabled = false;

                //Mostrar el genero en el ComboBox del formulario Agregar Usuario
                string rol = LectorDatos["Rol"].ToString();
                if (rol.ToLower() == "usuario")
                {
                    usuario.comboRol.SelectedIndex = 0;
                }
                else
                {
                    usuario.comboRol.SelectedIndex = 1;
                }
                //Llevar los datos del usuario al formulario de Agregar Usuarios
                usuario.txtIdUsuario.Text = LectorDatos["Id_usuario"].ToString();
                usuario.txtNombreUsuario.Text = LectorDatos["Nombre"].ToString();
                usuario.txtUsuario.Text = LectorDatos["Usuario"].ToString();
                usuario.txtContraseña.Text = LectorDatos["Clave"].ToString();
                usuario.ShowDialog();
                usuario.Refresh();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

                  Form1 form = new Form1();

            if (form.verificarLicencia())
            {
                AbrirForm(new AccesosDirectos());
            }
            else
            {
               MessageBox.Show("Comuniquese con los tecnicos para su mantenimiento periodico del sistema", "Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            if (form.verificarLicencia())
            {
                //AbrirForm(new Configuraciones());
                if (form.isAdmin())
                {
                    AbrirForm(new Configuraciones());
                }
                else
                {
                    MessageBox.Show("Solo el administrador puede acceder a este modulo", "Nivel de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Comuniquese con los tecnicos para su mantenimiento periodico del sistema", "Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
