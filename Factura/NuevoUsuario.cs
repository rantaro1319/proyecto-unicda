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
    public partial class NuevoUsuario : Form
    {
        public NuevoUsuario()
        {
            InitializeComponent();
        }

        bool validar()
        {
            if ((txtIdUsuario.Text.Trim().Equals("")))
            {
                MessageBox.Show("Debe registrar un ID", "Registrar ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;

            }
            else if(comboRol.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un rol para el usuario", "Seleccionar Rol", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;

            }
            else if ((txtNombreUsuario.Text.Trim().Equals("")))
            {
                MessageBox.Show("El nombre de usuario no puede quedar vacio", "Registrar Nombre de Usuario ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;

            }
            else if ((txtUsuario.Text.Trim().Equals("")))
            {
                MessageBox.Show("El usuario no puede quedar vacio", "Registrar Usuario ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;

            }
            else if ((txtContraseña.Text.Trim().Equals("")))
            {
                MessageBox.Show("La contraseña no puede quedar vacia", "Registrar Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!(txtConfirmar.Text.Equals(txtContraseña.Text)))
            {
                MessageBox.Show("La confirmacion de la contraseña no coincide con la contraseña ingresada", "Valida Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {

            try
            {
                if (validar())
                {
                    OleDbConnection Conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\ZKTeco\\ZKAccess3.5\\Access.mdb");
                String Consulta = "INSERT INTO RegistroEmpleado (Id_usuario,Nombre,Usuario,Clave,Rol) values(" + txtIdUsuario.Text + ",'" + txtNombreUsuario.Text + "','" + txtUsuario.Text + "','" + txtContraseña.Text + "','" + comboRol.SelectedItem.ToString().ToLower() + "');";
                OleDbCommand Comando = new OleDbCommand(Consulta, Conexion);

                Conexion.Open();
      
                    Comando.ExecuteNonQuery();
                    MessageBox.Show("Datos guardados correctamente", "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //fr.bunifuCustomDataGrid1.Refresh();
                    this.Close();
                }

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                try
                {
                    OleDbConnection Conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\ZKTeco\\ZKAccess3.5\\Access.mdb");
                    String Consulta1 = "SELECT * FROM  RegistroEmpleado WHERE Id_usuario = '" + txtIdUsuario.Text + "';";
                    OleDbCommand Comando1 = new OleDbCommand(Consulta1, Conexion);

                    Conexion.Open();

                    OleDbDataReader lectorId = Comando1.ExecuteReader();

                    if ((lectorId.HasRows))
                    {

                        String Consulta2 = "UPDATE RegistroEmpleado SET Nombre = '" + txtNombreUsuario.Text + "', Usuario = '" + txtUsuario.Text + "', Clave = '" + txtContraseña.Text + "', Rol = '" + comboRol.SelectedItem.ToString() + "' WHERE Id_usuario = '" + txtIdUsuario.Text + "'";
                        OleDbCommand Comando2 = new OleDbCommand(Consulta2, Conexion);
                        Comando2.ExecuteNonQuery();

                        MessageBox.Show("Datos modificados correctamente", "Datos Modificados", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                    this.Close();
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
        }
    }
    
}
