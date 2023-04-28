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
    public partial class tipoFactura : Form
    {
        public tipoFactura()
        {
            InitializeComponent();
        }

        private void pbFacturaProducto_Click(object sender, EventArgs e)
        {
            ProductoFactura productoFactura = new ProductoFactura();
            productoFactura.ShowDialog();

        }

        private void pbMembresia_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            
        }

        private void pbFacturaProducto_MouseHover(object sender, EventArgs e)
        {
            pbFacturaProducto.BackColor = Color.YellowGreen;
            label4.BackColor = Color.YellowGreen;
        }

        private void pbMembresia_MouseHover(object sender, EventArgs e)
        {
            pbMembresia.BackColor = Color.YellowGreen;
            label1.BackColor = Color.YellowGreen;
        }

        private void pbFacturaProducto_MouseLeave(object sender, EventArgs e)
        {
            pbFacturaProducto.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
        }

        private void pbMembresia_MouseLeave(object sender, EventArgs e)
        {
            pbMembresia.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
        }

        private void pbMembresia_MouseMove(object sender, MouseEventArgs e)
        {
            pbMembresia.BackColor = Color.YellowGreen;
            label1.BackColor = Color.YellowGreen;
        }

        private void pbFacturaProducto_MouseMove(object sender, MouseEventArgs e)
        {
            pbFacturaProducto.BackColor = Color.YellowGreen;
            label4.BackColor = Color.YellowGreen;
        }

        private void tipoFactura_Load(object sender, EventArgs e)
        {

        }
    }
}
