using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Factura
{
    public partial class NuevoCliente : Form
    {
        IntPtr h = IntPtr.Zero;
        
        [DllImport("C:\\WINDOWS\\system32\\plcommpro.dll", EntryPoint = "Connect")]
        public static extern IntPtr Connect(string Parameters);
        [DllImport("plcommpro.dll", EntryPoint = "PullLastError")]
        public static extern int PullLastError();
        public NuevoCliente()
        {
            // Create Instance of Global Settings Class for CommandBars
            // XtremeCommandBars.CommandBarsGlobalSettingsClass settings = new XtremeCommandBars.CommandBarsGlobalSettingsClass();
            // Now enter the first three lines of your license file
            // (Note carriage return line feed '\r\n' at the end of each line)
            /*settings.License = "CommandBars Control Copyright (c) 2003-2004 Codejock Software\r\n" +
              "PRODUCT-ID: XCB-ESD-ACTX-9500\r\n" +
              "VALIDATE-CODE: XXX-XXX-XXX-XXX";*/
            InitializeComponent();
        }


        void DarAcceso()
        {
            int nivelAcceso = int.Parse(comboAcceso.SelectedItem.ToString());
            int Id_usuario = 0;
            OleDbConnection Conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\ZKTeco\\ZKAccess3.5\\Access.mdb");
            Conexion.Open();

            String Consulta = "SELECT * FROM USERINFO where Badgenumber = '"+txtIdCliente.Text+"';";
            OleDbCommand Comando = new OleDbCommand(Consulta, Conexion);

            OleDbDataReader LectorDatos;
            LectorDatos = Comando.ExecuteReader();
            Boolean ExisteRegistros = LectorDatos.HasRows;
            LectorDatos.Read();



            if (ExisteRegistros)
            {
                Id_usuario = int.Parse(LectorDatos["USERID"].ToString());
            }

            String Consulta2 = "INSERT INTO acc_levelset_emp(acclevelset_id,employee_id) values("+nivelAcceso+"," + int.Parse(txtIdCliente.Text) + ");";
            OleDbCommand Comando2 = new OleDbCommand(Consulta2, Conexion);

            Comando2.ExecuteNonQuery();



        }

        void cargarAcceso()
        {
            int idEmpleado = 1;
            if (!string.IsNullOrEmpty(txtIdCliente.Text.ToString()))
            {
                idEmpleado = int.Parse(txtIdCliente.Text);
                


                OleDbConnection Conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\ZKTeco\\ZKAccess3.5\\Access.mdb");
                Conexion.Open();

                String Consulta3 = "SELECT * FROM acc_levelset_emp where employee_id = " + idEmpleado + ";";
                OleDbCommand Comando3 = new OleDbCommand(Consulta3, Conexion);

                OleDbDataReader LectorDatos2;
                LectorDatos2 = Comando3.ExecuteReader();
                Boolean ExisteRegistros2 = LectorDatos2.HasRows;
                LectorDatos2.Read();

                if (ExisteRegistros2)
                {
                    comboAcceso.SelectedItem = LectorDatos2["acclevelset_id"].ToString();
                }
            }
        }

        void DarAccesoEditado()
        {
            int nivelAcceso = int.Parse(comboAcceso.SelectedItem.ToString());
            int Id_usuario = 0;
            OleDbConnection Conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\ZKTeco\\ZKAccess3.5\\Access.mdb");
            Conexion.Open();

            String Consulta = "SELECT * FROM USERINFO where Badgenumber = '" + txtIdCliente.Text + "';";
            OleDbCommand Comando = new OleDbCommand(Consulta, Conexion);

            OleDbDataReader LectorDatos;
            LectorDatos = Comando.ExecuteReader();
            Boolean ExisteRegistros = LectorDatos.HasRows;
            LectorDatos.Read();

            if (ExisteRegistros)
            {
                Id_usuario = int.Parse(LectorDatos["Badgenumber"].ToString());
            }

            String Consulta2 = "UPDATE acc_levelset_emp SET acclevelset_id = " + nivelAcceso + " WHERE employee_id = " +Id_usuario + "";
            OleDbCommand Comando2 = new OleDbCommand(Consulta2, Conexion);

            Comando2.ExecuteNonQuery();

        }

        void subirHuella()
        {
            //int BufferSize = 16 * 1024 * 1024;
            int ret = 0;
            //string FileName = "transaction.dat";
            string tableName = "templatev10";
            string datas = "";
            string options = "";
            string fingerID = "1";
            Byte valid = 1;
            if (true == forceFPMake.Checked)
            {
                valid = 3;
            }

            datas = "Pin=" + txtIdCliente.Text + "\tFingerID=" + fingerID +
                "\tValid=" + valid.ToString() + "\tTemplate=" + txtTemplate.Text;
            if (IntPtr.Zero != h)
            {
                ret = SetDeviceData(h, tableName, datas, options);

                if (0 == ret)
                {
                    MessageBox.Show("Huella Guardada satisfactoriamente");
                }
                else
                {
                    MessageBox.Show("La huella no pudo ser registrada, el error es：　" + ret.ToString());
                }
            }
            else
            {
                MessageBox.Show("Debe conectar el dispositivo");
            }
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
                        //MessageBox.Show("Dispositivo Conectado");
                        return true;
                    }
                    else
                    {
                        //MessageBox.Show("Fallo de conexion al dispositivo");
                        return false;
                    }
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error: " + ex.Message);
            }
            return false;
        }


        bool validar()
            {
                if ((txtNombreCliente.Text.Trim().Equals("")))
                {
                    return false;
                }
                else if ((txtApellidoCliente.Text.Trim().Equals("")))
                {
                    return false;
                }
                else if ((txtIdCliente.Text.Trim().Equals("")))
                {
                    return false;
                }
                else if (comboAcceso.SelectedIndex < 0)
            {
                return false;
            }
                return true;
            }

        [DllImport("plcommpro.dll", EntryPoint = "SetDeviceData")]
        public static extern int SetDeviceData(IntPtr h, string tablename, string data, string options);

        void sincronizarNuevo()
        {

            String CardNo = "";
            String Pin = "";
            String Password = "";
            String Group = "";
            String StartTime = "";
            String EndTime = "";

            if (conectarIP())
            {
                try
                {
                        CardNo = "0";
                        Pin = txtIdCliente.Text;
                        Password = " " ;
                        Group = "0";
                    
                    StartTime = clienteFechaInicial.Value.ToString("yyyyMMdd");
                    EndTime = clienteFechaFinal.Value.ToString("yyyyMMdd");

                    int ret = 0;
                    string data = "CardNo=" + CardNo + "\tPin=" + Pin + "\tPassword=" + Password + "\tGroup=" + Group + "\tStartTime=" + StartTime + "\tEndTime=" + EndTime + "";
                    string options = "";
                    string devtablename = "";

                    if (IntPtr.Zero != h)
                    {

                        devtablename = "user";
                        ret = SetDeviceData(h, devtablename, data, options);

                        if (ret >= 0)
                        {
                            
                            return;
                        }
                        else
                        {
                            //NADA
                        }
                    }
                    else
                    {
                        //MessageBox.Show("Conexion Fallida!");
                        return;
                    }
                }
                catch (System.Exception ex)
                {
                    //System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
        }

        void sincronizar()
        {

            String CardNo = "";
            String Pin = "";
            String Password = "";
            String Group = "";
            String StartTime = "";
            String EndTime = "";

            if (conectarIP())
            {
                try
                {

                    //Conexion a la base de datos
                    OleDbConnection Conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\ZKTeco\\ZKAccess3.5\\Access.mdb");

                    //Sentencia sql para consultar a los clientes o usuarios
                    String Consulta = "SELECT * FROM  USERINFO WHERE (Badgenumber = '" + txtIdCliente.Text + "');";
                    OleDbCommand Comando = new OleDbCommand(Consulta, Conexion);

                    Conexion.Open();
                    OleDbDataReader LectorDatos = Comando.ExecuteReader();
                    if (LectorDatos.Read() == true)
                    {
                        CardNo = LectorDatos["CardNo"].ToString();
                        Pin = LectorDatos["Badgenumber"].ToString();
                        Password = LectorDatos["PASSWORD"].ToString();
                        Group = LectorDatos["AccGroup"].ToString();
                    }

                    Conexion.Close();

                    StartTime = clienteFechaInicial.Value.ToString("yyyyMMdd");
                    EndTime = clienteFechaFinal.Value.ToString("yyyyMMdd");

                    int ret = 0;
                    string data = "CardNo=" + CardNo + "\tPin=" + Pin + "\tPassword=" + Password + "\tGroup=" + Group + "\tStartTime=" + StartTime + "\tEndTime=" + EndTime + "";
                    string options = "";
                    string devtablename = "";

                    if (IntPtr.Zero != h)
                    {

                        devtablename = "user";
                        ret = SetDeviceData(h, devtablename, data, options);

                        if (ret >= 0)
                        {
                            
                            return;
                        }
                        else
                        {
                            //NADA
                        }
                    }
                    else
                    {
                        //MessageBox.Show("Conexion Fallida");
                        return;
                    }
                }
                catch (System.Exception ex)
                {
                    //System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnGuardarCliente_Click(object sender, EventArgs e)
        {
            
            try
            {         
                DateTime tiempo = DateTime.Today;
                String genero = "";
                string id = "";
                if (comboGenero.Text == "Masculino")
                {
                    genero = "M";
                }
                else
                {
                    genero = "F";
                }

                OleDbConnection Conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\ZKTeco\\ZKAccess3.5\\Access.mdb");
                String Consulta = "INSERT INTO USERINFO (Badgenumber,name,lastname,Gender,pager,acc_startdate,acc_enddate,email) values(" + txtIdCliente.Text + ",'" + txtNombreCliente.Text + "','" + txtApellidoCliente.Text + "','" + genero + "','" + txtTelefono.Text + "','" + tiempo + "','" + tiempo + "','" + txtCorreo.Text + "');";
                OleDbCommand Comando = new OleDbCommand(Consulta, Conexion);

                Conexion.Open();
                
                if (validar())
                {
                    Clientes fr = new Clientes();

                    Comando.ExecuteNonQuery();

                    sincronizarNuevo();
                    
                    MessageBox.Show("Datos guardados correctamente", "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Funcion para crear nuevo usuario

                    if (!String.IsNullOrEmpty(txtTemplate.Text))
                    {
                        subirHuella();
                    }

                    DarAcceso();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("No se aceptan campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
                
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }


    private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                String genero = "";

            if (comboGenero.Text == "Masculino")
            {
                genero = "M";
            }
            else
            {
                genero = "F";
            }

            OleDbConnection Conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\ZKTeco\\ZKAccess3.5\\Access.mdb");
            String Consulta1 = "SELECT * FROM  USERINFO WHERE Badgenumber = '" + txtIdCliente.Text + "';";
            OleDbCommand Comando1 = new OleDbCommand(Consulta1, Conexion);

            Conexion.Open();

            OleDbDataReader lectorId = Comando1.ExecuteReader();

            if ((lectorId.HasRows))
            {
                String Consulta2 = "UPDATE USERINFO SET name = '" + txtNombreCliente.Text + "', lastname = '" + txtApellidoCliente.Text + "', Gender = '" + genero + "', FPHONE = '" + txtTelefono.Text + "', email = '" + txtCorreo.Text + "', acc_startdate = '"+clienteFechaInicial.Value+ "',acc_enddate = '"+clienteFechaFinal.Value+"' WHERE Badgenumber = '" + txtIdCliente.Text + "'";
                OleDbCommand Comando2 = new OleDbCommand(Consulta2, Conexion);
                   
                Comando2.ExecuteNonQuery();
                sincronizar();
                    if (!String.IsNullOrEmpty(txtTemplate.Text))
                    {
                        subirHuella();
                    }

                    DarAccesoEditado();
                    this.Close();

                    MessageBox.Show("Datos modificados correctamente", "Datos Modificados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void NuevoCliente_Load(object sender, EventArgs e)
        {
            cargarAcceso();
        }

        private void btnCaptarHuella_Click(object sender, EventArgs e)
        {
            string template = "";
            string template1 = "";
            txtTemplate.Text = "";
            bool ret = false;
            int i = 0;
            axAFXOnlineMain1.DefaultWindowClose = 3600;
            axAFXOnlineMain1.EnrollCount = 3;

            axAFXOnlineMain1.SetLanguageFile("zkonline.en");
            axAFXOnlineMain1.SetVerHint = "Register fingerprint";
            axAFXOnlineMain1.FPEngineVersion = "10";
            axAFXOnlineMain1.IsSupportDuress = true;
            ret = axAFXOnlineMain1.Register();
            if (ret)
            {
                for (i = 0; i < 10; i++)
                {
                    template = axAFXOnlineMain1.GetRegFingerTemplate(i);
                    if (template != null)
                        template1 = template;
                }
                txtTemplate.Text = template1;
              
                }
            
            else
            {
                MessageBox.Show("Register fingerprint failed.");
                return;
            }
            return;

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void comboAcceso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
