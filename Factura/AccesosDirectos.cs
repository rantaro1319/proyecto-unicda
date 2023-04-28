using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factura
{
    public partial class AccesosDirectos : Form
    {
        void cargarFoto(string imagen)
        {
            string ruta = Application.StartupPath + @"\resource\" + imagen;
            if (File.Exists(ruta))
            {
                this.BackgroundImage = Image.FromFile(ruta);
            }
            else
            {
                this.BackgroundImage = Properties.Resources.gimnasio;
            }
        }

        string nombreImagen()
        {
            string nombre = "";
            OleDbConnection Conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\ZKTeco\\ZKAccess3.5\\Access.mdb");
            Conexion.Open();
            String Consulta = "SELECT * FROM configuracion;";
            OleDbCommand Comando = new OleDbCommand(Consulta, Conexion);
            OleDbDataReader LectorDatos;
            LectorDatos = Comando.ExecuteReader();
            LectorDatos.Read();
            if (LectorDatos.HasRows)
            {
                nombre = LectorDatos["fondo"].ToString();
                return nombre;
            }

            return nombre;

        }
        public AccesosDirectos()
        {
            InitializeComponent();
            cargarFoto(nombreImagen());
        }

        private void panelCliente_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            NuevoCliente nuevoCliente = new NuevoCliente();
            if (form.verificarLicencia())
            {
                nuevoCliente.btnGuardarCliente.Text = "Guardar";
                nuevoCliente.btnEditar.Visible = false;
                nuevoCliente.btnGuardarCliente.Visible = true;
                nuevoCliente.groupBox2.Enabled = false;
                nuevoCliente.ShowDialog();
            }
            else
            {
                MessageBox.Show("Comuniquese con los tecnicos para su mantenimiento periodico del sistema", "Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void panelFactura_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            Form1 form = new Form1();

            if (form.verificarLicencia())
            { 
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Comuniquese con los tecnicos para su mantenimiento periodico del sistema", "Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void panelCuadre_Click(object sender, EventArgs e)
        {

            Form1 form = new Form1();

            if (form.verificarLicencia())
            {

                ReporteDiario cuadre = new ReporteDiario();
                DateTime fecha1;
                DateTime fecha2;

                fecha1 = DateTime.Today;
                fecha2 = DateTime.Today;

                ReportParameter[] parameters = new ReportParameter[2];
                //Establecemos el valor de los parámetros
                parameters[0] = new ReportParameter("fechaInicialCuadre", Convert.ToString(fecha1));
                parameters[1] = new ReportParameter("fechaFinalCuadre", Convert.ToString(fecha2.AddDays(1)));
                cuadre.FacturaMembresiaTableAdapter.Fill(cuadre.AccessDataSet1.FacturaMembresia);
                //Pasamos el array de/ los parámetros al ReportViewer
                cuadre.reportViewer1.LocalReport.SetParameters(parameters);
                cuadre.reportViewer1.RefreshReport();
                cuadre.ShowDialog();

            }
            else
            {

                MessageBox.Show("Comuniquese con los tecnicos para su mantenimiento periodico del sistema", "Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void panelCliente_MouseEnter(object sender, EventArgs e)
        {
            panelCliente.BackColor = Color.FromArgb(250, 105, 144, 22);
        }

        private void panelCliente_MouseLeave(object sender, EventArgs e)
        {
            panelCliente.BackColor = Color.FromArgb(200, 105, 144, 22);
        }

        private void panelFactura_MouseEnter(object sender, EventArgs e)
        {
            panelFactura.BackColor = Color.FromArgb(250, 105, 144, 22);
        }

        private void panelFactura_MouseLeave(object sender, EventArgs e)
        {
            panelFactura.BackColor = Color.FromArgb(200, 105, 144, 22);
        }

        private void panelCuadre_MouseEnter(object sender, EventArgs e)
        {
            panelCuadre.BackColor = Color.FromArgb(250, 105, 144, 22);
        }

        private void panelCuadre_MouseLeave(object sender, EventArgs e)
        {
            panelCuadre.BackColor = Color.FromArgb(200, 105, 144, 22);
        }

        private void panelCliente_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
