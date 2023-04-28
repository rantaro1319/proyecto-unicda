using Microsoft.Reporting.WinForms;
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
    public partial class ProductoFactura : Form
    {

        DateTime hoy = DateTime.Now;
        void generarID()
        {
            int contadorID = 0;
            OleDbConnection Conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\ZKTeco\\ZKAccess3.5\\Access.mdb");

            //Sentencia sql para consultar a los clientes o usuarios

            String Consulta = "SELECT Num_factura FROM facturap ;";
            OleDbCommand Comando = new OleDbCommand(Consulta, Conexion);
            Conexion.Open();
            OleDbDataReader LectorDatos = Comando.ExecuteReader();
            if (!(LectorDatos.HasRows))
            {
                txtIdFactura.Text = "1";
            }
            else
            {
                for (int i = 0; LectorDatos.Read(); i++)
                {
                    contadorID += 1;
                }
                contadorID = contadorID + 1;
                txtIdFactura.Text = contadorID.ToString();
            }
        }
        public ProductoFactura()
        {
            Form1 fm = new Form1();
            InitializeComponent();
            lbFechaActual.Text = hoy.ToString();
            lbResponsable.Text = fm.getNombreUsuario();
            generarID();
            
        }

        public void CostoT()
        {
                double Ct = 0;
                foreach (DataGridViewRow row in tablaDetalle.Rows)
                {
                    Ct += Convert.ToDouble(row.Cells["subtotal"].Value);
                }
                
                lbTotal.Text = Convert.ToString(Ct);         

        }

        private void ProductoFactura_Load(object sender, EventArgs e)
        {

            // TODO: esta línea de código carga datos en la tabla 'accessDataSet1.USERINFO1' Puede moverla o quitarla según sea necesario.
            this.uSERINFO1TableAdapter.Fill(this.accessDataSet1.USERINFO1);
            // TODO: esta línea de código carga datos en la tabla 'accessDataSet1.USERINFO' Puede moverla o quitarla según sea necesario.
            this.uSERINFOTableAdapter.Fill(this.accessDataSet1.USERINFO);
            // TODO: esta línea de código carga datos en la tabla 'accessDataSet1.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.accessDataSet1.Productos);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCantidad.Text))
                {
                    MessageBox.Show("Debe agregar una cantidad del producto", "Agregue Cantidad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    OleDbConnection Conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\ZKTeco\\ZKAccess3.5\\Access.mdb");
                    String Consulta = "Select * FROM  Productos where Id_producto = '" + int.Parse(comboProducto.SelectedValue.ToString()) + "';";
                    OleDbCommand Comando = new OleDbCommand(Consulta, Conexion);

                    Conexion.Open();

                    OleDbDataReader LectorDatos = Comando.ExecuteReader();
                    LectorDatos.Read();

                    int existencias = int.Parse(LectorDatos["cantidad"].ToString());
                    int cantidades = int.Parse(txtCantidad.Text);
                    if (cantidades > existencias)
                    {
                        MessageBox.Show("La cantidad es mayor que la existencia del producto \n\n " + LectorDatos["nombreProducto"] + " existencias: '" + LectorDatos["cantidad"] + "'", "Existencia Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {

                        if (tablaDetalle.SelectedRows.Count == 0)
                        {
                            tablaDetalle.Rows.Add();
                        }

                        if (tablaDetalle.SelectedRows.Count > 0)
                        {

                            tablaDetalle.CurrentRow.Cells[0].Value = LectorDatos["Id_producto"].ToString();
                            tablaDetalle.CurrentRow.Cells[1].Value = LectorDatos["nombreProducto"].ToString();
                            tablaDetalle.CurrentRow.Cells[2].Value = LectorDatos["precio"].ToString();
                            tablaDetalle.CurrentRow.Cells[3].Value = txtCantidad.Text;

                            int precio = int.Parse(LectorDatos["precio"].ToString());
                            int cantidad = int.Parse(txtCantidad.Text);
                            int subtotal = precio * cantidad;

                            tablaDetalle.CurrentRow.Cells[4].Value = subtotal;
                        }

                        CostoT();

                        tablaDetalle.Rows.Add();
                        tablaDetalle.ClearSelection();
                        int nRowIndex = tablaDetalle.Rows.Count - 1;
                        tablaDetalle.Rows[nRowIndex].Selected = true;
                        tablaDetalle.Rows[nRowIndex].Cells[0].Selected = true;
                    }
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.uSERINFOTableAdapter.FillBy(this.accessDataSet1.USERINFO);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            try
            {
                if (tablaDetalle.RowCount > 0)
                {

                DateTime fecha = DateTime.Now;

                OleDbConnection Conexionf = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\ZKTeco\\ZKAccess3.5\\Access.mdb");
                string consultaf = "INSERT INTO facturap (Fecha_creacion,id_cliente,total_M) values('" + fecha + "' , '" + comboCliente.SelectedValue.ToString() + "' , " + double.Parse(lbTotal.Text) + ");";
                OleDbCommand Comandof = new OleDbCommand(consultaf, Conexionf);

                Conexionf.Open();

                Comandof.ExecuteNonQuery();

                Conexionf.Close();


                OleDbConnection Conexionv = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\ZKTeco\\ZKAccess3.5\\Access.mdb");
                    string consultav = "INSERT INTO detallep (cantidad,subtotal,id_factura,id_producto) values(@param1,@param2,@param3,@param4);";
                    string actualizar = "UPDATE Productos SET cantidad = (cantidad - @cantidad) WHERE id_producto = @producto ;";
                    OleDbCommand Comandov = new OleDbCommand(consultav, Conexionv);
                    OleDbCommand ComandoActualizar = new OleDbCommand(actualizar, Conexionv);

                    Conexionv.Open();

                    String Consulta3 = "SELECT * FROM empresa ";
                    OleDbCommand Comando3 = new OleDbCommand(Consulta3, Conexionv);
                    OleDbDataReader LectorDatos = Comando3.ExecuteReader();

                    foreach (DataGridViewRow row in tablaDetalle.Rows)
                    {
                        Comandov.Parameters.Clear();
                        ComandoActualizar.Parameters.Clear();

                        //Parametros para guardar Factura
                        Comandov.Parameters.AddWithValue("@param1", Convert.ToInt32(row.Cells["cantidad"].Value));
                        Comandov.Parameters.AddWithValue("@param2", Convert.ToInt32(row.Cells["subtotal"].Value));
                        Comandov.Parameters.AddWithValue("@param3", txtIdFactura.Text);
                        Comandov.Parameters.AddWithValue("@param4", Convert.ToInt32(row.Cells["id_producto"].Value));

                        //Parametros para actualizar las existencias del Producto
                        ComandoActualizar.Parameters.AddWithValue("@cantidad", Convert.ToInt32(row.Cells["cantidad"].Value));
                        ComandoActualizar.Parameters.AddWithValue("@producto", Convert.ToInt32(row.Cells["id_producto"].Value));

                        Comandov.ExecuteNonQuery();
                        ComandoActualizar.ExecuteNonQuery();

                    }

                    MessageBox.Show("Compra registrada satisfactoriamente", "Factura Registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Generar la factura

                    FacturaFactura factura = new FacturaFactura();

                    string cliente;
                    string id_factura;
                    string fecha_hy;
                    string rempresa;
                    string rtelefono;
                    string rRnc;
                    string responsable = lbResponsable.Text;

                    id_factura = txtIdFactura.Text;
                    cliente = comboCliente.GetItemText(comboCliente.SelectedItem);
                    fecha_hy = lbFechaActual.Text;

                    if (LectorDatos.Read())
                    {
                        rempresa = LectorDatos["nombre"].ToString();
                        rtelefono = LectorDatos["telefono"].ToString();
                        rRnc = LectorDatos["rnc"].ToString();
                    }
                    else
                    {
                        rempresa = "";
                        rtelefono = "";
                        rRnc = "";
                    }

                    ReportParameter[] parameters = new ReportParameter[10];
                    //Establecemos el valor de los parámetros
                    parameters[0] = new ReportParameter("Nombre_cliente", Convert.ToString(cliente));
                    parameters[1] = new ReportParameter("Fecha_factura", Convert.ToString(fecha_hy));
                    parameters[2] = new ReportParameter("Id_factura", Convert.ToString(id_factura));
                    parameters[3] = new ReportParameter("Empleado", Convert.ToString(responsable));
                    parameters[4] = new ReportParameter("Fecha_factura", Convert.ToString(fecha_hy));
                    parameters[5] = new ReportParameter("Id_factura", Convert.ToString(id_factura));
                    parameters[6] = new ReportParameter("Empleado", Convert.ToString(responsable));
                    parameters[7] = new ReportParameter("Empresa", Convert.ToString(rempresa));
                    parameters[8] = new ReportParameter("telefono", Convert.ToString(rtelefono));
                    parameters[9] = new ReportParameter("rnc", Convert.ToString(rRnc));
                    //this.reporteFacturaPTableAdapter1.Fill(this.accessDataSet1.ReporteFacturaP);
                    //this.facturaProductoTableAdapter.Fill(this.accessDataSet1.FacturaProducto);
                    factura.DetalleFacturaTableAdapter.Fill(this.accessDataSet1.DetalleFactura);
                    //Pasamos el array de/ los parámetros al ReportViewer
                    factura.reportFactura.LocalReport.SetParameters(parameters);
                    factura.reportFactura.RefreshReport();
                    factura.ShowDialog();
                    Conexionv.Close();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Debe agregar un producto a la tabla", "Registrar Producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminarDetalle_Click(object sender, EventArgs e)
        {
            if (tablaDetalle.SelectedRows.Count > 0)
            {
                tablaDetalle.Rows.Remove(tablaDetalle.CurrentRow);
                CostoT();
            }     
            else
            {
                MessageBox.Show("Debe seleccionar una fila de tabla", "Seleccione una Fila", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void comboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

        