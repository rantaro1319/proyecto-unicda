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
    public partial class FacturaFactura : Form
    {
        public FacturaFactura()
        {
            InitializeComponent();
        }

        private void FacturaFactura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'AccessDataSet1.DetalleFactura' Puede moverla o quitarla según sea necesario.
            this.DetalleFacturaTableAdapter.Fill(this.AccessDataSet1.DetalleFactura);

            this.reportFactura.RefreshReport();
        }
    }
}
