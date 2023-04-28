using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factura
{
    public partial class Usuarios : Form
    {

        public Usuarios()
        {
            InitializeComponent();
            
        }

        private void pbUsuarios_Click(object sender, EventArgs e)
        {
            Adminusuarios admin = new Adminusuarios();
            admin.ShowDialog();
        }

        private void pbUsuarios_MouseHover(object sender, EventArgs e)
        {
            pbUsuarios.BackColor = Color.YellowGreen;
            label1.BackColor = Color.YellowGreen;
        }

        private void pbUsuarios_MouseLeave(object sender, EventArgs e)
        {
            pbUsuarios.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
        }

        private void pbUsuarios_MouseMove(object sender, MouseEventArgs e)
        {
            pbUsuarios.BackColor = Color.YellowGreen;
            label1.BackColor = Color.YellowGreen;
        }

        private void pbMiUsuario_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            string ID = frm.getIdUsuario();
            OleDbConnection Conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\ZKTeco\\ZKAccess3.5\\Access.mdb");
            Conexion.Open();

            String Consulta = "SELECT * FROM RegistroEmpleado WHERE Id_usuario = '"+ ID +"';";
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

        private void pbMiUsuario_MouseHover(object sender, EventArgs e)
        {
            pbMiUsuario.BackColor = Color.YellowGreen;
            label2.BackColor = Color.YellowGreen;
        }

        private void pbMiUsuario_MouseLeave(object sender, EventArgs e)
        {
            pbMiUsuario.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
        }

        private void pbMiUsuario_MouseMove(object sender, MouseEventArgs e)
        {
            pbMiUsuario.BackColor = Color.YellowGreen;
            label2.BackColor = Color.YellowGreen;
        }
    }
}
