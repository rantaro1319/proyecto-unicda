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
    public partial class Producto : Form
    {
        public Producto()
        {
            InitializeComponent();
        }

        private void Producto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'accessDataSet.Productos' Puede moverla o quitarla según sea necesario.
         //   this.productosTableAdapter.Fill(this.accessDataSet.Productos);
            // TODO: esta línea de código carga datos en la tabla 'accessDataSet.Productos' Puede moverla o quitarla según sea necesario.
         //   this.productosTableAdapter.Fill(this.accessDataSet.Productos);
            // TODO: esta línea de código carga datos en la tabla 'accessDataSet.facturap' Puede moverla o quitarla según sea necesario.
            //this.facturapTableAdapter.Fill(this.accessDataSet.facturap);
            // TODO: esta línea de código carga datos en la tabla 'accessDataSet.factura' Puede moverla o quitarla según sea necesario.
            //this.facturaTableAdapter.Fill(this.accessDataSet.factura);

        }

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnEditarProducto_Click(object sender, EventArgs e)
        {
            Productos frm = new Productos();

            if (tablaProducto.SelectedRows.Count > 0)
            {
                //Llevar los datos del productos al formulario de Agregar Productos
                frm.txtIdProducto.Text = tablaProducto.CurrentRow.Cells[0].Value.ToString();
                frm.txtProducto.Text = tablaProducto.CurrentRow.Cells[1].Value.ToString();
                frm.txtPrecio.Text = tablaProducto.CurrentRow.Cells[2].Value.ToString();
                frm.txtCosto.Text = tablaProducto.CurrentRow.Cells[3].Value.ToString();
                frm.txtExistencia.Text = tablaProducto.CurrentRow.Cells[4].Value.ToString();
                frm.txtIdProducto.Enabled = false;
                frm.btnAgregarProduto.Visible = false;
                frm.btnEditarProducto.Visible = true;
                frm.ShowDialog();
                frm.Refresh();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila", "Seleccione una Fila", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }

        private void BtnEliminarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (tablaProducto.SelectedRows.Count > 0)
            {
                string idProducto = tablaProducto.CurrentRow.Cells[0].Value.ToString();
                var confirmar = MessageBox.Show("Esta seguro que desea eliminar el registro?", "Eliminar Registro", MessageBoxButtons.YesNo);
                if (confirmar == DialogResult.Yes)
                {
                    OleDbConnection Conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\ZKTeco\\ZKAccess3.5\\Access.mdb");
                    Conexion.Open();
                    string cadena = "DELETE * FROM  Productos WHERE Id_producto = '" + int.Parse(idProducto) + "';";
                    OleDbCommand comando = new OleDbCommand(cadena, Conexion);
                    comando.ExecuteNonQuery();
                    Conexion.Close();
                    
                     }

                 }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            Productos fm = new Productos();
            fm.btnAgregarProduto.Visible = true;
            fm.btnEditarProducto.Visible = false;
            fm.txtIdProducto.Enabled = true;
            fm.ShowDialog();
        }

        private void Producto_Load_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'accessDataSet1.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.accessDataSet1.Productos);

        }

        private void tablaProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BuscarProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void BuscarProducto_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
            OleDbConnection Conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\ZKTeco\\ZKAccess3.5\\Access.mdb");
            Conexion.Open();
            OleDbCommand Comando = Conexion.CreateCommand();
            Comando.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(Comando);


            if (!(string.IsNullOrEmpty(BuscarProducto.Text)))
            {

                Comando.CommandText = "SELECT * FROM  Productos WHERE nombreProducto like  ('" + BuscarProducto.Text + "%') OR (Id_producto = '" + BuscarProducto.Text + "');";
                Comando.ExecuteNonQuery();

                da.Fill(dt);
                tablaProducto.DataSource = dt;


            }
            else
            {

                Comando.CommandText = "SELECT * FROM  Productos";
                Comando.ExecuteNonQuery();
                da.Fill(dt);
                tablaProducto.DataSource = dt;
            }

            Conexion.Close();

            }

            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tablaProducto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Productos frm = new Productos();

            if (tablaProducto.SelectedRows.Count > 0)
            {
                //Llevar los datos del productos al formulario de Agregar Productos
                frm.txtIdProducto.Text = tablaProducto.CurrentRow.Cells[0].Value.ToString();
                frm.txtProducto.Text = tablaProducto.CurrentRow.Cells[1].Value.ToString();
                frm.txtPrecio.Text = tablaProducto.CurrentRow.Cells[2].Value.ToString();
                frm.txtCosto.Text = tablaProducto.CurrentRow.Cells[3].Value.ToString();
                frm.txtExistencia.Text = tablaProducto.CurrentRow.Cells[4].Value.ToString();
                frm.ShowDialog();
                frm.Refresh();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila", "Seleccione una Fila", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
