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
    public partial class rfp : Form
    {
        public rfp()
        {
            InitializeComponent();
        }

        private void rfp_Load(object sender, EventArgs e)
        {

           /* string nombre;
            nombre = txtBuscarCliente.Text;
            ReportParameter[] parameters = new ReportParameter[1];
            parameters[0] = new ReportParameter("nombre", Convert.ToString(nombre));
            this.FacturaMembresiaTableAdapter.Fill(this.AccessDataSet1.FacturaMembresia);
            this.reportViewer1.LocalReport.SetParameters(parameters);          
            this.reportViewer1.RefreshReport();*/            
        }
    }
}
