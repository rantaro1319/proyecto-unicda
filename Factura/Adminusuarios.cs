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
    public partial class Adminusuarios : Form
    {
        public Adminusuarios()
        {
            InitializeComponent();
        }

        private void Adminusuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'accessDataSet1.RegistroEmpleado' Puede moverla o quitarla según sea necesario.
            this.registroEmpleadoTableAdapter.FillBy3(this.accessDataSet1.RegistroEmpleado);

        }

        private void txtBuscarUsuario_KeyUp(object sender, KeyEventArgs e)
        {

            OleDbConnection Conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\ZKTeco\\ZKAccess3.5\\Access.mdb");
            Conexion.Open();
            OleDbCommand Comando = Conexion.CreateCommand();
            Comando.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(Comando);


            if (!(string.IsNullOrEmpty(txtBuscarUsuario.Text)))
            {

                Comando.CommandText = "SELECT * FROM  RegistroEmpleado WHERE (Id_usuario = '" + txtBuscarUsuario.Text + "') OR Nombre like  ('" + txtBuscarUsuario.Text + "%');";
                Comando.ExecuteNonQuery();

                da.Fill(dt);
                bunifuCustomDataGrid1.DataSource = dt;

            }

            else
            {

                Comando.CommandText = "SELECT * FROM  RegistroEmpleado WHERE Rol = 'Usuario' OR Rol = 'usuario';";
                Comando.ExecuteNonQuery();
                da.Fill(dt);
                bunifuCustomDataGrid1.DataSource = dt;
            }

            Conexion.Close();
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {

            NuevoUsuario formm = new NuevoUsuario();
            formm.ShowDialog();
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {

            NuevoUsuario frm = new NuevoUsuario();

            if (bunifuCustomDataGrid1.SelectedRows.Count > 0)
            {
                //Cambiar los Labels del formulario de Agregar Usuarios
                //frm.btnGuardarUsuario.Text = "Modificar";

                frm.txtIdUsuario.Enabled = false;
                frm.btnModificarUsuario.Visible = true;
                frm.btnGuardarUsuario.Visible = false;

                //Mostrar el genero en el ComboBox del formulario Agregar Usuario
                string rol = bunifuCustomDataGrid1.CurrentRow.Cells[4].Value.ToString();
                if (rol.ToLower() == "usuario")
                {
                    frm.comboRol.SelectedIndex = 0;
                }
                else
                {
                    frm.comboRol.SelectedIndex = 1;
                }

                //Llevar los datos del usuario al formulario de Agregar Usuarios
                frm.txtIdUsuario.Text = bunifuCustomDataGrid1.CurrentRow.Cells[0].Value.ToString();
                frm.txtNombreUsuario.Text = bunifuCustomDataGrid1.CurrentRow.Cells[1].Value.ToString();
                frm.txtUsuario.Text = bunifuCustomDataGrid1.CurrentRow.Cells[2].Value.ToString();
                frm.txtContraseña.Text = bunifuCustomDataGrid1.CurrentRow.Cells[3].Value.ToString();  
                frm.ShowDialog();
                frm.Refresh();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila", "Seleccione una Fila", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {

            if (bunifuCustomDataGrid1.SelectedRows.Count > 0)
            {
                string idCliente = bunifuCustomDataGrid1.CurrentRow.Cells[0].Value.ToString();
                var confirmar = MessageBox.Show("Esta seguro que desea eliminar el registro?", "Eliminar Registro", MessageBoxButtons.YesNo);
                if (confirmar == DialogResult.Yes)
                {
                    OleDbConnection Conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\ZKTeco\\ZKAccess3.5\\Access.mdb");
                    Conexion.Open();
                    string cadena = "DELETE * FROM  RegistroEmpleado WHERE Id_usuario = '" + idCliente + "';";
                    OleDbCommand comando = new OleDbCommand(cadena, Conexion);
                    comando.ExecuteNonQuery();
                    Conexion.Close();
                }

            }

        }

        private void fillBy3ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.registroEmpleadoTableAdapter.FillBy3(this.accessDataSet1.RegistroEmpleado);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void txtBuscarUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
