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
    public partial class CuentasPorCobrar : Form
    {
        public CuentasPorCobrar()
        {
            InitializeComponent();
        }

        private void CuentasPorCobrar_Load(object sender, EventArgs e)
        {
            try
            {
                DateTime tiempo = DateTime.Today;
            // TODO: esta línea de código carga datos en la tabla 'AccessDataSet1.CuentasPorCobrarTabla' Puede moverla o quitarla según sea necesario.
            ReportParameter[] parameters = new ReportParameter[1];
            //Establecemos el valor de los parámetros
            parameters[0] = new ReportParameter("FechaHoy", Convert.ToString(tiempo));
            
            //Pasamos el array de/ los parámetros al ReportViewer
            this.reportViewer1.LocalReport.SetParameters(parameters);
            
            this.CuentasPorCobrarTablaTableAdapter.Fill(this.AccessDataSet1.CuentasPorCobrarTabla);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No existen registros para mostrar", "No hay Registros", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }
    }
}
