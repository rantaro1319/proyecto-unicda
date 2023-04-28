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
    public partial class barra : Form
    {
        public barra()
        {
            InitializeComponent();
        }

        public void barrera()
        {
            progressBar1.Increment(1);
            label2.Text = progressBar1.Value.ToString() + "%";
            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                MessageBox.Show("Analisis finalizado \n\nEl programa se ha actualizado correctamente.", "Estado del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            barrera();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void barra_Load(object sender, EventArgs e)
        {

        }
    }
}
