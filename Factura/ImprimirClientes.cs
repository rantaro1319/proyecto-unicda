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
    public partial class ImprimirClientes : Form
    {
        public ImprimirClientes()
        {
            InitializeComponent();
        }

        private void ImprimirClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'AccessDataSet1.USERINFO' Puede moverla o quitarla según sea necesario.
            this.USERINFOTableAdapter.Fill(this.AccessDataSet1.USERINFO);

            this.reportViewer1.RefreshReport();
        }
    }
}
