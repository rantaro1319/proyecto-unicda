using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factura
{
    public partial class ReporteDiario : Form
    {
        public ReporteDiario()
        {
            InitializeComponent();
        }

        private void ReporteDiario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'AccessDataSet1.RegistroEmpleado' Puede moverla o quitarla según sea necesario.
            this.registroEmpleadoTableAdapter.Fill(this.AccessDataSet1.RegistroEmpleado);
            try
            {
            // TODO: esta línea de código carga datos en la tabla 'AccessDataSet1.FacturaProducto' Puede moverla o quitarla según sea necesario.
            this.FacturaProductoTableAdapter.Fill(this.AccessDataSet1.FacturaProducto);
            // TODO: esta línea de código carga datos en la tabla 'AccessDataSet1.FacturaMembresia' Puede moverla o quitarla según sea necesario.
            this.FacturaMembresiaTableAdapter.Fill(this.AccessDataSet1.FacturaMembresia);


            this.reportViewer1.RefreshReport();
        }catch(Exception ex)
            {
                MessageBox.Show("No existen registros para mostrar", "Sin Registros", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
             }

        private void btnfiltrarReporte_Click(object sender, EventArgs e)
        {

            DateTime fecha1;
            DateTime fecha2;
            DateTime hora1;
            DateTime hora2;
            String usuario;

            fecha1 = dateDiarioInicial.Value;
            fecha2 = dateDiarioFinal.Value;
            /*hora1 = dateHoraInicial.Value.ToLongTimeString();
            hora2 = dateHoraFinal.ToLongTimeString();*/

            ReportParameter[] parameters = new ReportParameter[2];
            //Establecemos el valor de los parámetros
            parameters[0] = new ReportParameter("fechaInicialCuadre", Convert.ToString(fecha1));
            parameters[1] = new ReportParameter("fechaFinalCuadre", Convert.ToString(fecha2));
            this.FacturaMembresiaTableAdapter.Fill(this.AccessDataSet1.FacturaMembresia);
            //Pasamos el array de / los parámetros al ReportViewer
            this.reportViewer1.LocalReport.SetParameters(parameters);
            this.reportViewer1.RefreshReport();
        }

        private void btnCuadrar_Click(object sender, EventArgs e)
        {

            DateTime fecha1;
            DateTime fecha2;

            fecha1 = DateTime.Today;
            fecha2 = DateTime.Today;

            ReportParameter[] parameters = new ReportParameter[2];
            //Establecemos el valor de los parámetros
            parameters[0] = new ReportParameter("fechaInicialCuadre", Convert.ToString(fecha1));
            parameters[1] = new ReportParameter("fechaFinalCuadre", Convert.ToString(fecha2.AddDays(1)));
            this.FacturaMembresiaTableAdapter.Fill(this.AccessDataSet1.FacturaMembresia);
            //Pasamos el array de/ los parámetros al ReportViewer
            this.reportViewer1.LocalReport.SetParameters(parameters);
            this.reportViewer1.RefreshReport();

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void dateHoraInicial_onValueChanged(object sender, EventArgs e)
        {

        }

        private void dateHoraFinal_onValueChanged(object sender, EventArgs e)
        {
        
        }
    }
}
