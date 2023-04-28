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
    public partial class ReporteMembresia : Form
    {
        public ReporteMembresia()
        {
            InitializeComponent();
        }

        private void btnFiltroMembresia_Click(object sender, EventArgs e)
        {

            DateTime fecha1;
            DateTime fecha2;

            fecha1 = dateInicial.Value;
            fecha2 = dateFinal.Value;


            ReportParameter[] parameters = new ReportParameter[2];
            //Establecemos el valor de los parámetros
            parameters[0] = new ReportParameter("FechaInicial", Convert.ToString(dateInicial.Value));
            parameters[1] = new ReportParameter("FechaFinal", Convert.ToString(dateFinal.Value));
            this.FacturaMembresiaTableAdapter.Fill(this.AccessDataSet1.FacturaMembresia);
            //Pasamos el array de/ los parámetros al ReportViewer
            this.reportViewer2.LocalReport.SetParameters(parameters);
            this.reportViewer2.RefreshReport();

        }

        private void ReporteMembresia_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'AccessDataSet1.RegistroEmpleado' Puede moverla o quitarla según sea necesario.
            this.registroEmpleadoTableAdapter.Fill(this.AccessDataSet1.RegistroEmpleado);
            OleDbConnection Conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\ZKTeco\\ZKAccess3.5\\Access.mdb");
            Conexion.Open();
            string Consulta = "SELECT * FROM RegistroEmpleado";
            OleDbCommand Comando = new OleDbCommand(Consulta, Conexion);
            OleDbDataReader LectorDatos;
            LectorDatos = Comando.ExecuteReader();
            Boolean ExisteRegistros = LectorDatos.HasRows;

            DateTime fechaActual = DateTime.Today;
            // TODO: esta línea de código carga datos en la tabla 'AccessDataSet1.FacturaMembresia' Puede moverla o quitarla según sea necesario.
            this.FacturaMembresiaTableAdapter.Fill(this.AccessDataSet1.FacturaMembresia);

            this.reportViewer2.RefreshReport();

            dateInicial.Value = fechaActual;
            dateFinal.Value = fechaActual.AddDays(1);

            if (Form1.admin)
            {
                lbPorUsuario.Visible = true;
                comboPorUsuario.Visible = true;
            }

            if (ExisteRegistros)
            {
                //comboPorUsuario.
            }
        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {

        }

        /*private void btnFiltrarCliente_Click(object sender, EventArgs e)

        {
            string nombre;
            nombre = txtBuscarCliente.Text;
            ReportParameter[] parameters = new ReportParameter[1];
            parameters[0] = new ReportParameter("nombre", Convert.ToString(nombre));
            this.FacturaMembresiaTableAdapter.Fill(this.AccessDataSet1.FacturaMembresia);
            this.reportViewer2.LocalReport.SetParameters(parameters);
            this.reportViewer2.RefreshReport();
        }*/
    }
}
