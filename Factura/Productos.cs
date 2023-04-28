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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        bool validar()
        {
            if ((txtIdProducto.Text.Trim().Equals("")))
            {
                MessageBox.Show("Debe agregar un ID al producto", "Registrar ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;

            }
            else if ((txtProducto.Text.Trim().Equals("")))
            {
                MessageBox.Show("Debe agregar un nombre al producto", "Registrar Nombre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;

            }
            else if ((txtExistencia.Text.Trim().Equals("")) || !System.Text.RegularExpressions.Regex.IsMatch(txtExistencia.Text, "[0-9]"))
            {
                MessageBox.Show("Agregue una cantidad de existencia al producto", "Registrar Existencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if ((txtPrecio.Text.Trim().Equals("")))
            {
                MessageBox.Show("Debe agregar un precio al producto", "Registrar Precio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if ((txtCosto.Text.Trim().Equals("")))
            {
                MessageBox.Show("Debe agregar un costo al producto", "Registrar Costo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnAgregarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar())
                {
                    OleDbConnection Conexion3 = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\ZKTeco\\ZKAccess3.5\\Access.mdb");
                    String Consulta3 = "INSERT INTO Productos(Id_producto,nombreProducto,precio,costo,cantidad) values(" + txtIdProducto.Text + ",'" + txtProducto.Text + "','" + txtPrecio.Text + "','" + txtCosto.Text + "','" + txtExistencia.Text + "');";
                    OleDbCommand Comando3 = new OleDbCommand(Consulta3, Conexion3);

                    Conexion3.Open();

                    Comando3.ExecuteNonQuery();
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
        
        

        private void Productos_Load(object sender, EventArgs e)
        {

        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {


            try
            {
                OleDbConnection Conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\ZKTeco\\ZKAccess3.5\\Access.mdb");
                String Consulta1 = "SELECT * FROM Productos WHERE Id_producto = '" + txtIdProducto.Text + "';";
                OleDbCommand Comando1 = new OleDbCommand(Consulta1, Conexion);

                Conexion.Open();

                OleDbDataReader lectorId = Comando1.ExecuteReader();

                if ((lectorId.HasRows))
                {

                    String Consulta2 = "UPDATE Productos SET nombreProducto = '" + txtProducto.Text + "', precio = '" + txtPrecio.Text + "', costo = '" + txtCosto.Text + "', cantidad = '" + txtExistencia.Text + "' WHERE Id_producto = '" + txtIdProducto.Text + "'";
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
