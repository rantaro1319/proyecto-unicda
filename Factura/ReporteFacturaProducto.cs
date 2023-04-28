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
    public partial class ReporteFacturaProducto : Form
    {
        public ReporteFacturaProducto()
        {
            InitializeComponent();
        }

        private void ReporteFacturaProducto_Load(object sender, EventArgs e)
        {
            DateTime fechaActual = DateTime.Today;

            // TODO: esta línea de código carga datos en la tabla 'AccessDataSet1.DetalleFactura1' Puede moverla o quitarla según sea necesario.
            this.DetalleFactura1TableAdapter.Fill(this.AccessDataSet1.DetalleFactura1);
            // TODO: esta línea de código carga datos en la tabla 'accessDataSet1.FacturaProducto' Puede moverla o quitarla según sea necesario.
            this.facturaProductoTableAdapter.Fill(this.AccessDataSet1.FacturaProducto);
            // TODO: esta línea de código carga datos en la tabla 'accessDataSet1.facturap' Puede moverla o quitarla según sea necesario.
            this.facturapTableAdapter.Fill(this.AccessDataSet1.facturap);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();

            dateInicial.Value = fechaActual;
            dateFinal.Value = fechaActual.AddDays(1);
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            try
            {
                string cliente;
                string id_factura;
                string fecha_hy;

                if (bunifuCustomDataGrid1.SelectedRows.Count > 0)
                {
                    id_factura = bunifuCustomDataGrid1.CurrentRow.Cells[0].Value.ToString();
                    cliente = bunifuCustomDataGrid1.CurrentRow.Cells[2].Value.ToString();
                    fecha_hy = bunifuCustomDataGrid1.CurrentRow.Cells[3].Value.ToString();

                    ReportParameter[] parameters = new ReportParameter[3];
                    //Establecemos el valor de los parámetros
                    parameters[0] = new ReportParameter("cliente", Convert.ToString(cliente));
                    parameters[1] = new ReportParameter("fechaFactura", Convert.ToString(fecha_hy));
                    parameters[2] = new ReportParameter("id_factura", Convert.ToString(id_factura));
                    //this.reporteFacturaPTableAdapter1.Fill(this.accessDataSet1.ReporteFacturaP);
                    this.facturaProductoTableAdapter.Fill(this.AccessDataSet1.FacturaProducto);
                    this.DetalleFactura1TableAdapter.Fill(this.AccessDataSet1.DetalleFactura1);
                    //Pasamos el array de/ los parámetros al ReportViewer
                    this.reportViewer1.LocalReport.SetParameters(parameters);
                    this.reportViewer1.RefreshReport();

                }
                else
                {
                    MessageBox.Show("Debe seleccionar una fila", "Seleccione una Fila", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
        }

        private void btnFiltrarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection Conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\ZKTeco\\ZKAccess3.5\\Access.mdb");
                Conexion.Open();
                String data = "SELECT facturap.Num_factura,USERINFO.Badgenumber, USERINFO.name + ' ' + USERINFO.lastname As Expr1, facturap.Fecha_creacion FROM(facturap INNER JOIN USERINFO ON facturap.id_cliente = USERINFO.Badgenumber)WHERE facturap.Fecha_creacion BETWEEN  @Fecha_inicial AND @Fecha_final;";

                //OleDbCommand Comando = new OleDbCommand(data);
                OleDbDataAdapter da = new OleDbDataAdapter(data, Conexion);
                da.SelectCommand.CommandType = CommandType.Text;
                da.SelectCommand.Parameters.Add("@Fecha_inicial", OleDbType.Date).Value = dateInicial.Value.ToString();
                da.SelectCommand.Parameters.Add("@Fecha_final", OleDbType.Date).Value = dateFinal.Value.ToString();

                DataTable dt = new DataTable();
                da.Fill(dt);
                this.bunifuCustomDataGrid1.DataSource = dt;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void bunifuCustomDataGrid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                FacturaFactura factura = new FacturaFactura();
                string cliente;
                string id_factura;
                string fecha_hy;

                if (bunifuCustomDataGrid1.SelectedRows.Count > 0)
                {

                    id_factura = bunifuCustomDataGrid1.CurrentRow.Cells[0].Value.ToString();
                    cliente = bunifuCustomDataGrid1.CurrentRow.Cells[2].Value.ToString();
                    fecha_hy = bunifuCustomDataGrid1.CurrentRow.Cells[3].Value.ToString();

                    ReportParameter[] parameters = new ReportParameter[3];
                    //Establecemos el valor de los parámetros
                    parameters[0] = new ReportParameter("cliente", Convert.ToString(cliente));
                    parameters[1] = new ReportParameter("fechaFactura", Convert.ToString(fecha_hy));
                    parameters[2] = new ReportParameter("id_factura", Convert.ToString(id_factura));
                    //this.reporteFacturaPTableAdapter1.Fill(this.accessDataSet1.ReporteFacturaP);
                    this.facturaProductoTableAdapter.Fill(this.AccessDataSet1.FacturaProducto);
                    this.DetalleFactura1TableAdapter.Fill(this.AccessDataSet1.DetalleFactura1);
                    //Pasamos el array de/ los parámetros al ReportViewer
                    this.reportViewer1.LocalReport.SetParameters(parameters);
                    this.reportViewer1.RefreshReport();

                }
                else
                {
                    MessageBox.Show("Debe seleccionar una fila", "Seleccione una Fila", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnImprimirRecibo_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            try
            {
                FacturaFactura factura = new FacturaFactura();
                string cliente;
                string id_factura;
                string fecha_hy;
                string responsable = form1.getNombreUsuario();

                if (bunifuCustomDataGrid1.SelectedRows.Count > 0)
                {

                    id_factura = bunifuCustomDataGrid1.CurrentRow.Cells[0].Value.ToString();
                    cliente = bunifuCustomDataGrid1.CurrentRow.Cells[2].Value.ToString();
                    fecha_hy = bunifuCustomDataGrid1.CurrentRow.Cells[3].Value.ToString();

                    ReportParameter[] parameters = new ReportParameter[4];
                    //Establecemos el valor de los parámetros
                    parameters[0] = new ReportParameter("Nombre_cliente", Convert.ToString(cliente));
                    parameters[1] = new ReportParameter("Fecha_factura", Convert.ToString(fecha_hy));
                    parameters[2] = new ReportParameter("Id_factura", Convert.ToString(id_factura));
                    parameters[3] = new ReportParameter("Empleado", Convert.ToString(responsable));
                    //this.reporteFacturaPTableAdapter1.Fill(this.accessDataSet1.ReporteFacturaP);
                    //this.facturaProductoTableAdapter.Fill(this.accessDataSet1.FacturaProducto);
                    factura.DetalleFacturaTableAdapter.Fill(this.AccessDataSet1.DetalleFactura);
                    //Pasamos el array de/ los parámetros al ReportViewer
                    factura.reportFactura.LocalReport.SetParameters(parameters);
                    factura.reportFactura.RefreshReport();
                    factura.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una fila", "Seleccione una Fila", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
    }

