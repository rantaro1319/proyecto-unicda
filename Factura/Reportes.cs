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
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void imgMembresia_Click(object sender, EventArgs e)
        {
            ReporteMembresia rm = new ReporteMembresia();
            rm.ShowDialog();
        }

        private void imgFacturas_Click(object sender, EventArgs e)
        {
            ReporteFacturaProducto fr = new ReporteFacturaProducto();
            fr.ShowDialog();
        }

        private void imgIngreso_Click(object sender, EventArgs e)
        {
            ReporteDiario rd = new ReporteDiario();
            rd.ShowDialog();
        }

        private void imgCuentas_Click(object sender, EventArgs e)
        {
            CuentasPorCobrar cpc = new CuentasPorCobrar();
            cpc.ShowDialog();
        }

        private void imgIngreso_MouseHover(object sender, EventArgs e)
        {
            imgIngreso.BackColor = Color.FromArgb(208, 208, 208);
            label4.BackColor = Color.FromArgb(208, 208, 208);
        }

        private void imgIngreso_MouseLeave(object sender, EventArgs e)
        {
            imgIngreso.BackColor = Color.WhiteSmoke;
            label4.BackColor = Color.WhiteSmoke;
        }

        private void imgCuentas_MouseHover(object sender, EventArgs e)
        {
            imgCuentas.BackColor = Color.FromArgb(208, 208, 208);
            label3.BackColor = Color.FromArgb(208, 208, 208);
        }

        private void imgFacturas_MouseHover(object sender, EventArgs e)
        {
            imgFacturas.BackColor = Color.FromArgb(208, 208, 208);
            label2.BackColor = Color.FromArgb(208, 208, 208);
        }

        private void imgMembresia_MouseHover(object sender, EventArgs e)
        {
            imgMembresia.BackColor = Color.FromArgb(208, 208, 208);
            label1.BackColor = Color.FromArgb(208, 208, 208);
        }

        private void imgMembresia_MouseLeave(object sender, EventArgs e)
        {
            imgMembresia.BackColor = Color.WhiteSmoke;
            label1.BackColor = Color.WhiteSmoke;
        }

        private void imgFacturas_MouseLeave(object sender, EventArgs e)
        {
            imgFacturas.BackColor = Color.WhiteSmoke;
            label2.BackColor = Color.WhiteSmoke;
        }

        private void imgCuentas_MouseLeave(object sender, EventArgs e)
        {
            imgCuentas.BackColor = Color.WhiteSmoke;
            label3.BackColor = Color.WhiteSmoke;
        }

        private void Reportes_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void imgIngreso_MouseMove(object sender, MouseEventArgs e)
        {
            imgIngreso.BackColor = Color.FromArgb(208, 208, 208);
            label4.BackColor = Color.FromArgb(208, 208, 208);
        }

        private void imgFacturas_MouseMove(object sender, MouseEventArgs e)
        {
            imgFacturas.BackColor = Color.FromArgb(208, 208, 208);
            label2.BackColor = Color.FromArgb(208, 208, 208);
        }

        private void imgMembresia_MouseMove(object sender, MouseEventArgs e)
        {
            imgMembresia.BackColor = Color.FromArgb(208, 208, 208);
            label1.BackColor = Color.FromArgb(208, 208, 208);
        }

        private void imgCuentas_MouseMove(object sender, MouseEventArgs e)
        {
            imgCuentas.BackColor = Color.FromArgb(208, 208, 208);
            label3.BackColor = Color.FromArgb(208, 208, 208);
        }
    }
}
