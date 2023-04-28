using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factura
{
    public partial class Form1 : Form
    {
        public static IntPtr h = IntPtr.Zero;
        public static string nombreUsuario = "";
        public static string idUsuario = "";
        public static bool admin = false;

        bool existeLicencia()
        {
            OleDbConnection Conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\ZKTeco\\ZKAccess3.5\\Access.mdb");
            Conexion.Open();

            String Consulta = "SELECT * FROM USERLOGSYSTEM ;";
            OleDbCommand Comando = new OleDbCommand(Consulta, Conexion);
            OleDbDataReader LectorDatos;
            LectorDatos = Comando.ExecuteReader();
            Boolean ExisteRegistros = LectorDatos.HasRows;
            if (!ExisteRegistros)
            {

                return true;
            }

            return false;
        }

        void actualizarLicencia(DateTime _hoy,DateTime _fechaFinal)
        {
            OleDbConnection Conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\ZKTeco\\ZKAccess3.5\\Access.mdb");
            Conexion.Open();
            String Consulta = " UPDATE USERLOGSYSTEM SET startDate ='" + _hoy + "', endDate ='" + _fechaFinal + "';";
            OleDbCommand Comando = new OleDbCommand(Consulta, Conexion);
            Comando.ExecuteNonQuery();

            barra barra = new barra();
            barra.ShowDialog();
        }

        void agregarLicencia()
        {
            DateTime hoy = new DateTime();
            DateTime fechaFinal = new DateTime();
            hoy = DateTime.Now;
            fechaFinal = hoy.AddDays(10);
            if (existeLicencia())
            {
                OleDbConnection Conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\ZKTeco\\ZKAccess3.5\\Access.mdb");
                Conexion.Open();
                string consulta = "INSERT INTO USERLOGSYSTEM(startDate,endDate) VALUES('" + hoy + "','" + fechaFinal + "')";
                OleDbCommand comando = new OleDbCommand(consulta, Conexion);
                comando.ExecuteNonQuery();
            }
        }

        public bool verificarLicencia()
        {
            DateTime hoy = DateTime.Now;
            OleDbConnection Conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\ZKTeco\\ZKAccess3.5\\Access.mdb");
            Conexion.Open();

            String Consulta = "SELECT * FROM USERLOGSYSTEM;";
            OleDbCommand Comando = new OleDbCommand(Consulta, Conexion);
            OleDbDataReader LectorDatos;
            LectorDatos = Comando.ExecuteReader();
            LectorDatos.Read();
            string fechaFinal = LectorDatos["endDate"].ToString();

            if (hoy < DateTime.Parse(fechaFinal))
            {
                return true;
            }

            return false;
        }

        void conexionBD()
        {

            //Conexion a la Base de Datos de Access
            OleDbConnection Conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\ZKTeco\\ZKAccess3.5\\Access.mdb");
            Conexion.Open();

            String Consulta = "SELECT * FROM RegistroEmpleado WHERE Clave ='" + txtClave.Text + "' and Usuario = '" + txtUsuario.Text + "';";
            OleDbCommand Comando = new OleDbCommand(Consulta, Conexion);
            OleDbDataReader LectorDatos;
            LectorDatos = Comando.ExecuteReader();
            Boolean ExisteRegistros = LectorDatos.HasRows;

            if (ExisteRegistros)
            {
                LectorDatos.Read();
                nombreUsuario = LectorDatos["Nombre"].ToString();
                idUsuario = LectorDatos["Id_usuario"].ToString();
                if (LectorDatos["Rol"].ToString() == "admin")
                {
                    admin = true;
                }
                MessageBox.Show("Bienvenido al sistema  " + nombreUsuario, "Usuario Autorizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Main frmMain = new Main();
                frmMain.WindowState = FormWindowState.Maximized;
                frmMain.Show();
            }
            else
            {
                MessageBox.Show("Usuario o Clave incorrecta", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Conexion.Close();
            this.Hide();

        }

        public string getNombreUsuario()
        {
            return nombreUsuario;
        }

        public string getIdUsuario()
        {
            return idUsuario;
        }

        public bool isAdmin()
        {
            if (admin)
            {
                return true;
            }
            return false;
        }

        public bool conectarIP()
        {
            string str = "";
            string ip = "";
            try
            {
                OleDbConnection Conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\ZKTeco\\ZKAccess3.5\\Access.mdb");
                Conexion.Open();

                String Consulta = "SELECT * FROM configuracion ;";
                OleDbCommand Comando = new OleDbCommand(Consulta, Conexion);
                OleDbDataReader LectorDatos;
                LectorDatos = Comando.ExecuteReader();
                Boolean ExisteRegistros = LectorDatos.HasRows;
                LectorDatos.Read();

                if (ExisteRegistros)
                {
                    ip = LectorDatos["ip"].ToString();
                }

                str = "protocol=TCP,ipaddress=" + ip + ",port=4370,timeout=2000,passwd=";
                if (IntPtr.Zero == h)
                {
                    h = Connect(str);
                    Cursor = Cursors.Default;
                    if (h != IntPtr.Zero)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return false;
        }

        public Form1()
        {
            InitializeComponent();
            agregarLicencia();
            
        }

        [DllImport("C:\\WINDOWS\\system32\\plcommpro.dll", EntryPoint = "Connect")]
        public static extern IntPtr Connect(string Parameters);
        [DllImport("plcommpro.dll", EntryPoint = "PullLastError")]
        public static extern int PullLastError();

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        void validarEntrada()
        {
            DateTime hoy = new DateTime();
            DateTime fechaFinal = new DateTime();
            hoy = DateTime.Now;

            if (txtUsuario.Text == "XxSuperAdminxX" && txtClave.Text == "**ActualizarAnual**")
            {
                fechaFinal = hoy.AddYears(1);
                actualizarLicencia(hoy, fechaFinal);

            }
            else if (txtUsuario.Text == "XxSuperAdminxX" && txtClave.Text == "**ActualizarSemestral**")
            {
                fechaFinal = hoy.AddMonths(6);
                actualizarLicencia(hoy, fechaFinal);
            }
            else if (txtUsuario.Text == "XxSuperAdminxX" && txtClave.Text == "**ActualizarTrimestral**")
            {
                fechaFinal = hoy.AddMonths(3);
                actualizarLicencia(hoy, fechaFinal);
            }
            else if (txtUsuario.Text == "XxSuperAdminxX" && txtClave.Text == "**ActualizarMensual**")
            {
                fechaFinal = hoy.AddMonths(1);
                actualizarLicencia(hoy, fechaFinal);
            }
            else if (verificarLicencia())
            {
                conexionBD();
            }
            else
            {
                MessageBox.Show("Comuniquese con los tecnicos para su mantenimiento periodico del sistema", "Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtUsuario.Text = "";
            txtClave.Text = "";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            conectarIP();
            validarEntrada();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'accessDataSet.RegistroEmpleado' Puede moverla o quitarla según sea necesario.
            this.registroEmpleadoTableAdapter.Fill(this.accessDataSet.RegistroEmpleado);
        }

        private void TxtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                validarEntrada();
            }
        }
    }
}
