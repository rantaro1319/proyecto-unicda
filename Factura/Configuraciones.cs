using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Factura
{
    public partial class Configuraciones : Form
    {
        public void AbrirForm(object Formhijo)
        {
            //Main fm = new Main();
            if (this.tabPage1.Controls.Count > 0)
                this.tabPage1.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.tabPage1.Controls.Add(fh);
            this.tabPage1.Tag = fh;
            fh.Show();
        }

        bool existeID(string tabla)
        {
            OleDbConnection Conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\ZKTeco\\ZKAccess3.5\\Access.mdb");
            Conexion.Open();

            String Consulta = "SELECT * FROM "+tabla+";";
            OleDbCommand Comando = new OleDbCommand(Consulta, Conexion);
            OleDbDataReader LectorDatos;
            LectorDatos = Comando.ExecuteReader();
            Boolean ExisteRegistros = LectorDatos.HasRows;
            if (!ExisteRegistros)
            {
                return false;
            }
            return true;
        }

        public Configuraciones()
        {
            
            InitializeComponent();
            AbrirForm(new plcdemo.PL());
            if (existeID("empresa"))
            {
                OleDbConnection Conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\ZKTeco\\ZKAccess3.5\\Access.mdb");
                Conexion.Open();
                String Consulta = "SELECT * FROM empresa;";
                OleDbCommand Comando = new OleDbCommand(Consulta, Conexion);
                OleDbDataReader LectorDatos;
                LectorDatos = Comando.ExecuteReader();
                LectorDatos.Read();
                txtNombreEmpresa.Text = LectorDatos["nombre"].ToString();
                txtRNC.Text = LectorDatos["rnc"].ToString();
                txtContacto.Text = LectorDatos["contacto"].ToString();
                txtTelefono.Text = LectorDatos["telefono"].ToString();
                txtEmail.Text = LectorDatos["correo"].ToString();
                txtDireccion.Text = LectorDatos["direccion"].ToString();
            }

            if (existeID("configuracion"))
            {
                OleDbConnection Conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\ZKTeco\\ZKAccess3.5\\Access.mdb");
                Conexion.Open();
                String Consulta = "SELECT * FROM configuracion;";
                OleDbCommand Comando = new OleDbCommand(Consulta, Conexion);
                OleDbDataReader LectorDatos;
                LectorDatos = Comando.ExecuteReader();
                LectorDatos.Read();
                txtIP.Text = LectorDatos["ip"].ToString();
            }

        }

        bool validarEmpresa()
        {
            if (string.IsNullOrEmpty(txtNombreEmpresa.Text)){
                MessageBox.Show("Indique el nombre de la empresa o local","Campo Vacio",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return false;
            }else if (string.IsNullOrEmpty(txtRNC.Text))
            {
                MessageBox.Show("Indique el RNC", "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            OpenFileDialog Carpeta = new OpenFileDialog(); //busca la imagen 
            Carpeta.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";

            if (Carpeta.ShowDialog() == DialogResult.OK)
            {
                txtRuta.Text = Carpeta.FileName; // guarda la ruta de la imagen seleccionada en el label
                imagenEmpresa.Image = Image.FromFile(Carpeta.FileName);
                imagenEmpresa.Tag = Carpeta.FileName;
                txtNombreImagen.Text = Path.GetFileName(imagenEmpresa.Tag.ToString().Trim());
            }

            imagenEmpresa.Image = Image.FromFile(txtRuta.Text);
            imagenEmpresa.SizeMode = PictureBoxSizeMode.Zoom;
        }
        
        private void btnRegistrarEmpresa_Click(object sender, EventArgs e)
        {
            

            if (validarEmpresa())
            {
                try
                {
                    if (!String.IsNullOrEmpty(txtNombreImagen.Text))
                    {
                        string ruta = Application.StartupPath;  //ruta de la aplicacion 
                        string ruta_destino = ruta + @"\resource"; // ruta de la carpeta creada "imgF"

                        string ruta_ver = txtRuta.Text.Replace("//", "////"); // ruta de la imagen seleccionada 
                        string pruebaDes = Application.StartupPath + @"\resource\" + txtNombreImagen.Text; // ruta de la imagen 

                        if (File.Exists(pruebaDes))
                        {
                            label1.Text = "Configuraciones";
                        }
                        // Determine whether the directory exists.
                        else if (Directory.Exists(ruta_destino)) // si existe la ruta de la carpeta "imgF"
                        {
                            File.Copy(ruta_ver, pruebaDes, true); //sustitulle la imagen con el mismo nombre
                        }
                        else // si no existe la ruta 
                        {
                            DirectoryInfo direc = Directory.CreateDirectory(ruta_destino); // crea la ruta 
                            File.Copy(ruta_ver, pruebaDes, true);//sustitulle la imagen con el mismo nombre 00
                        }
                    }
                    if (!existeID("empresa"))
                    {

                        OleDbConnection Conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\ZKTeco\\ZKAccess3.5\\Access.mdb");
                        String Consulta = "INSERT INTO empresa (nombre,rnc,contacto,telefono,correo,direccion,ruta) values('"
                            + txtNombreEmpresa.Text + "','"
                            + txtRNC.Text + "','"
                            + txtContacto.Text + "','"
                            + txtTelefono.Text + "','"
                            + txtEmail.Text + "','"
                            + txtDireccion.Text + "','"
                            + txtNombreImagen.Text + "');";
                        OleDbCommand Comando = new OleDbCommand(Consulta, Conexion);

                        Conexion.Open();

                        Comando.ExecuteNonQuery();
                        MessageBox.Show("Datos guardados correctamente", "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        OleDbConnection Conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\ZKTeco\\ZKAccess3.5\\Access.mdb");
                        String Consulta = "UPDATE empresa SET nombre = '" + txtNombreEmpresa.Text + "', rnc = '" + txtRNC.Text + "', contacto = '" + txtContacto.Text + "', telefono = '" + txtTelefono.Text + "', correo = '" + txtEmail.Text + "', direccion = '" + txtDireccion.Text + "', ruta = '" + txtNombreImagen.Text + "';";

                        OleDbCommand Comandov = new OleDbCommand(Consulta, Conexion);
                        Conexion.Open();
                        Comandov.ExecuteNonQuery();
                        
                        Conexion.Close();

                        MessageBox.Show("Datos actualizados correctamente", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Activate();
            main.pictureBox2.Image = Properties.Resources.COAN_DOMINICANA_BLANCO_02;
        }

        private void btnSeleccionarFondo_Click(object sender, EventArgs e)
        {
            OpenFileDialog Carpeta = new OpenFileDialog(); //busca la imagen 
            Carpeta.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";

            if (Carpeta.ShowDialog() == DialogResult.OK)
            {
                txtRutaFondo.Text = Carpeta.FileName; // guarda la ruta de la imagen seleccionada en el label
                fondoPantalla.Image = Image.FromFile(Carpeta.FileName);
                fondoPantalla.Tag = Carpeta.FileName;
                txtNombreFondo.Text = Path.GetFileName(fondoPantalla.Tag.ToString().Trim());
            }

            fondoPantalla.Image = Image.FromFile(txtRutaFondo.Text);
            fondoPantalla.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void bntEstablecerFondo_Click(object sender, EventArgs e)
        {
            //try {
                if (!String.IsNullOrEmpty(txtNombreFondo.Text))
                {
                    string ruta = Application.StartupPath;  //ruta de la aplicacion 
                    string ruta_destino = ruta + @"\resource"; // ruta de la carpeta creada "imgF"

                    string ruta_ver = txtRutaFondo.Text.Replace("//", "////"); // ruta de la imagen seleccionada 
                    string pruebaDes = Application.StartupPath + @"\resource\" + txtNombreFondo.Text; // ruta de la imagen 

                    // Determine whether the directory exists.
                    if (File.Exists(pruebaDes))
                    {
                        label1.Text = "Configuraciones";
                    }
                    else if (Directory.Exists(ruta_destino)) // si existe la ruta de la carpeta "imgF"
                    {
                        File.Copy(ruta_ver, pruebaDes, true); //sustitulle la imagen con el mismo nombre
                    }
                    else // si no existe la ruta 
                    {
                        DirectoryInfo direc = Directory.CreateDirectory(ruta_destino); // crea la ruta 
                        File.Copy(ruta_ver, pruebaDes, true);//sustitulle la imagen con el mismo nombre 00
                    }
                }

            if (!existeID("configuracion"))
            {

                OleDbConnection Conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\ZKTeco\\ZKAccess3.5\\Access.mdb");
                String Consulta = "INSERT INTO configuracion (fondo,ip) values('"+txtNombreFondo.Text+"','"+txtIP.Text+"');";
                OleDbCommand Comando = new OleDbCommand(Consulta, Conexion);

                Conexion.Open();

                Comando.ExecuteNonQuery();
                MessageBox.Show("Datos guardados correctamente", "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                OleDbConnection Conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\ZKTeco\\ZKAccess3.5\\Access.mdb");
                    String Consulta = "UPDATE configuracion SET fondo = '" + txtNombreFondo.Text + "' , ip = '" + txtIP.Text + "';";
                    if (String.IsNullOrEmpty(txtNombreFondo.Text))
                    {
                        Consulta = "UPDATE configuracion SET ip = '" + txtIP.Text + "';";
                    }
                
                OleDbCommand Comandov = new OleDbCommand(Consulta, Conexion);
                Conexion.Open();
                Comandov.ExecuteNonQuery();

                Conexion.Close();

                MessageBox.Show("Datos actualizados correctamente", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}
        

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
