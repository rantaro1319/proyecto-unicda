using Microsoft.Reporting.WinForms;
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
using ZKSoftwareAPI;

namespace Factura
{
    public partial class Form2 : Form
    {
        IntPtr h = IntPtr.Zero;
        Form1 fo = new Form1();
        DateTime fechaFinalPagar;
        [DllImport("C:\\WINDOWS\\system32\\plcommpro.dll", EntryPoint = "Connect")]
        public static extern IntPtr Connect(string Parameters);
        
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
        void generarID()
        {
            int contadorID = 0;
            int totalDias = 0;
            OleDbConnection Conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\ZKTeco\\ZKAccess3.5\\Access.mdb");

            //Sentencia sql para consultar a los clientes o usuarios
            String Consulta = "SELECT Num_factura FROM factura ;";
            OleDbCommand Comando = new OleDbCommand(Consulta, Conexion);
            Conexion.Open();
            OleDbDataReader LectorDatos = Comando.ExecuteReader();
            if(!(LectorDatos.HasRows))
            {
                lbID.Text = "1";
            }
            else
            {
                for(int i = 0 ;LectorDatos.Read() ;i++)
                {
                    contadorID += 1;
                }
                totalDias = contadorID + 1;
                lbID.Text = totalDias.ToString();
                lbFechaActual.Text = DateTime.Now.ToString();
            }
        }

        public Form2()
        {
            InitializeComponent();
            generarID();
            lbResponsable.Text = fo.getNombreUsuario();   
        }

        bool validar_factura()
        { 
            if (string.IsNullOrEmpty(comboID.SelectedValue.ToString()))
            {
                MessageBox.Show("No puede realizar una factura sin asignar un cliente", "Cliente no asignado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
            {
                MessageBox.Show("Seleccione un plan de pago", "Plan no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if ((radioButton1.Checked && comboMeses.SelectedIndex < 0) || (radioButton2.Checked && comboDias.SelectedIndex < 0) || (radioButton3.Checked && string.IsNullOrWhiteSpace(txtDiasManual.Text)))
            {
                MessageBox.Show("Seleccione el numero de Meses/Dias ", "Tiempo no Establecido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        //Funcion para buscar a los clientes
        void buscar()
        {
            try
            {
                if (!(string.IsNullOrEmpty(comboID.SelectedText)))
            {
                //Conexion a la base de datos
                OleDbConnection Conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\ZKTeco\\ZKAccess3.5\\Access.mdb");

                //Sentencia sql para consultar a los clientes o usuarios
                String Consulta = "SELECT * FROM  USERINFO WHERE (Badgenumber = '" + comboID.SelectedValue.ToString() + "');";
                OleDbCommand Comando = new OleDbCommand(Consulta, Conexion);

                Conexion.Open();
                OleDbDataReader LectorDatos = Comando.ExecuteReader();
                if (LectorDatos.Read() == true)
                {

                        checkRenovado.Enabled = true;

                    //Fechas de acceso desde la base de datos
                    string fechaFinal = LectorDatos["acc_enddate"].ToString();
                    string fechaInicial = LectorDatos["acc_startdate"].ToString();

                    //Datos generales desde la base de datos
                    string genero = LectorDatos["gender"].ToString();
                    showNombre.Text = LectorDatos["name"].ToString();
                    showApellido.Text = LectorDatos["lastname"].ToString();

                    //String.Format da formato de salida
                    //showTelefono.Text = String.Format("{0:(###) ###-####}", Double.Parse(LectorDatos["pager"].ToString()));
                    showTelefono.Text = LectorDatos["pager"].ToString();
                    showUltimoAcceso.Text = String.Format("{0:f}",DateTime.Parse(fechaFinal));

                        DateTime d = new DateTime();
                        DateTime a = new DateTime();

                        TimeSpan ts = dateFechaInicial.Value - dateFechaFinal.Value;
                        int cantidad = ts.Days;

                        label17.Text = cantidad.ToString();
                        fechaFinalPagar = DateTime.Parse(fechaFinal);
                         dateFechaInicial.Value = fechaFinalPagar;

                        //Establecer genero del usuario
                        switch (genero.ToLower())
                    {
                        case "m":
                            showGenero.Text = "Masculino";
                            break;
                        case "f":
                            showGenero.Text = "Femenino";
                            break;
                    }

                        bunifuCards2.Enabled = true;               
                }
                else
                {
                    MessageBox.Show("No se ha encontrado Registro","Sin Registro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    dateFechaInicial.CustomFormat = "";
                    dateFechaFinal.CustomFormat = "";
                        bunifuCards2.Enabled = false;

                }
                Conexion.Close();
            }
            else
            {
                MessageBox.Show("Debe indicar un ID","Sin ID",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        DateTime fechaAcceso = DateTime.Now;

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'accessDataSet.USERINFO1' Puede moverla o quitarla según sea necesario.
            this.uSERINFO1TableAdapter.Fill(this.accessDataSet.USERINFO1);

            // TODO: esta línea de código carga datos en la tabla 'accessDataSet.USERINFO' Puede moverla o quitarla según sea necesario.
            //this.uSERINFOTableAdapter.Fill(this.accessDataSet.USERINFO);

            lbFechaActual.Text = DateTime.Now.ToString();
        }

        [DllImport("plcommpro.dll", EntryPoint = "SetDeviceData")]
        public static extern int SetDeviceData(IntPtr h, string tablename, string data, string options);

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
                    String Consulta = "SELECT * FROM  USERINFO WHERE (Badgenumber = '" + comboID.SelectedValue.ToString() + "');";
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

                    StartTime = dateFechaInicial.Value.ToString("yyyyMMdd");
                    EndTime = dateFechaFinal.Value.ToString("yyyyMMdd");

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
                            MessageBox.Show("Fallo de conexion en el torniquete");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Fallo de Conexion!");
                        return;
                    }
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {   
                if (validar_factura())
            {
                try
                {    
                TimeSpan ts = dateFechaFinal.Value - dateFechaInicial.Value;
                int cantidad = ts.Days;

                int total = 0;
                int monto = 0;
                int dias = 0;
                int meses = 0;
                int cantidadMD = 0;
                string plan = "";
                string tipofecha = "";

                    if (checkRenovado.Checked)
                    {
                        dateFechaFinal.Value = DateTime.Today;
                    }

                if (radioButton1.Checked && !string.IsNullOrEmpty(txtMensual.Text) && comboMeses.SelectedIndex > 0)
                {
                       DateTime alo = DateTime.Today;
                        meses = int.Parse(comboMeses.SelectedItem.ToString());
                    plan = "Mensual";
                    dias = 30;
                    total = int.Parse(txtMonto.Text);
                    monto = int.Parse(txtMensual.Text);
                    tipofecha = "Meses";
                    cantidadMD = meses;
                        if (checkRenovado.Checked)
                        {
                            dateFechaFinal.Value = alo.AddMonths(meses);

                        }
                        // dateFechaFinal.Value = alo.AddMonths(meses);

                        txtMonto.Text = " " + (monto * meses) + "";
                }
                else if(radioButton2.Checked)
                {
                        //DateTime alo = dateFechaInicial.Value;
                        DateTime alo = dateFechaFinal.Value;

                    plan = "Dias";
                    dias = int.Parse(comboDias.SelectedItem.ToString());
                    total = int.Parse(txtMonto.Text);
                    monto = int.Parse(txtPago.Text);
                    tipofecha = "Dias";
                    cantidadMD = dias;
                    dateFechaFinal.Value = alo.AddDays(dias);
                }
                else if(radioButton3.Checked)
                {
                        DateTime alo = dateFechaFinal.Value;
                        plan = "Dias";
                        dias = int.Parse(txtDiasManual.Text);
                        total = int.Parse(txtMonto.Text);
                        monto = int.Parse(txtMontoManual.Text);
                        tipofecha = "Dias";
                        cantidadMD = dias;
                        dateFechaFinal.Value = alo.AddDays(dias);

                    }
                    else
                    {
                        MessageBox.Show("Dias/Meses o Monto vacios", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    DateTime hoy = DateTime.Now;

                    /*
                     *"UPDATE USERINFO SET "acc_startdate = '" + dateFechaInicial.Value + "',
                    "acc_enddate= '" + dateFechaFinal.Value + "' WHERE Badgenumber = '" + comboID.SelectedValue.ToString() + "'";
                    */

                    OleDbConnection Conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\ZKTeco\\ZKAccess3.5\\Access.mdb");
                    String Consulta = "UPDATE USERINFO SET acc_enddate= '" + dateFechaFinal.Value + "' WHERE Badgenumber = '" + comboID.SelectedValue.ToString() + "'";
                    OleDbCommand Comando = new OleDbCommand(Consulta, Conexion);
                    Conexion.Open();
                    Comando.ExecuteNonQuery();

                    String Consulta2 = "INSERT INTO factura (Fecha_factura,Plan,Dias,Monto,Total_factura,Id_empleado,Id_cliente)values('" + hoy + "','" + plan + "'," + cantidad + "," + monto + "," + total + "," + fo.getIdUsuario() + "," + comboID.SelectedValue.ToString() + ")";
                    OleDbCommand Comando2 = new OleDbCommand(Consulta2, Conexion);
                    Comando2.ExecuteNonQuery();

                    String Consulta3 = "SELECT * FROM empresa ";
                    OleDbCommand Comando3 = new OleDbCommand(Consulta3, Conexion);
                    OleDbDataReader LectorDatos = Comando3.ExecuteReader();
                    
                    //Mandar datos al torniquete
                    sincronizar();

                    MessageBox.Show("Datos guardados correctamente", "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Generar factura de Membresia

                    ReciboMembresia factura = new ReciboMembresia();
                    string cliente, id_factura, fecha_hy, responsable, rPlan, rCantidadMD, rMonto, rTotal, rFechaFinal,rTipo_fecha, rempresa, rtelefono, rRnc;

                    id_factura = lbID.Text;
                    cliente = showNombre.Text + " " + showApellido.Text;
                    fecha_hy = lbFechaActual.Text;
                    responsable = lbResponsable.Text;
                    rPlan = plan;
                    rCantidadMD = cantidadMD.ToString();
                    rMonto = monto.ToString();
                    rTotal = total.ToString();
                    rFechaFinal = dateFechaFinal.Value.ToString();
                    rTipo_fecha = tipofecha;
                    if (LectorDatos.Read())
                    {
                        rempresa = LectorDatos["nombre"].ToString();
                        rtelefono = LectorDatos["telefono"].ToString();
                        rRnc = LectorDatos["rnc"].ToString();
                    }
                    else
                    {
                        rempresa = "";
                        rtelefono = "";
                        rRnc = "";
                    }
                    ReportParameter[] parameters = new ReportParameter[13];
                    //Establecemos el valor de los parámetros
                    parameters[0] = new ReportParameter("Nombre_cliente", Convert.ToString(cliente));
                    parameters[1] = new ReportParameter("Fecha_factura", Convert.ToString(fecha_hy));
                    parameters[2] = new ReportParameter("Id_factura", Convert.ToString(id_factura));
                    parameters[3] = new ReportParameter("Empleado", Convert.ToString(responsable));
                    parameters[4] = new ReportParameter("Plan", Convert.ToString(rPlan));
                    parameters[5] = new ReportParameter("cantidadMD", Convert.ToString(rCantidadMD));
                    parameters[6] = new ReportParameter("Monto", Convert.ToString(rMonto));
                    parameters[7] = new ReportParameter("Total", Convert.ToString(rTotal));
                    parameters[8] = new ReportParameter("FechaFinal", Convert.ToString(rFechaFinal));
                    parameters[9] = new ReportParameter("Tipo_fecha", Convert.ToString(rTipo_fecha));
                    parameters[10] = new ReportParameter("Empresa", Convert.ToString(rempresa));
                    parameters[11] = new ReportParameter("Telefono", Convert.ToString(rtelefono));
                    parameters[12] = new ReportParameter("rnc", Convert.ToString(rRnc));


                    factura.reportMembresia.LocalReport.SetParameters(parameters);
                    factura.reportMembresia.RefreshReport();
                    factura.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                this.Close();
            }
                
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                comboMeses.Enabled = true;
                txtMensual.Enabled = true;

                comboDias.SelectedIndex = 0;
                comboDias.Enabled = false;
                txtPago.Enabled = false;
                txtDiasManual.Enabled = false;
                txtMontoManual.Enabled = false;

                txtMonto.Text = " ";
                txtPago.Text = " ";
                txtMontoManual.Text = " ";
                txtDiasManual.Text = " ";
            }
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {

                comboDias.Enabled = true;
                txtPago.Enabled = true;

                txtMensual.Enabled = false;
                comboMeses.SelectedItem = "0";
                comboMeses.Enabled = false;
                txtDiasManual.Enabled = false;
                txtMontoManual.Enabled = false;

                txtMonto.Text = "";
                txtPago.Text = "";
                txtMontoManual.Text = "";
                txtDiasManual.Text = "";
            }
        }

        private void comboDias_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime fechaDeAcceso = dateFechaFinal.Value;
            int dias = 1;
            dias = int.Parse(comboDias.SelectedItem.ToString());
            //dateFechaFinal.Value = fechaDeAcceso.AddDays(dias);
            if (!string.IsNullOrEmpty(txtPago.Text) && comboDias.SelectedIndex > 0)
            {
                int monto = int.Parse(txtPago.Text);
                int numeroDias = int.Parse(comboDias.SelectedItem.ToString());

                txtMonto.Text = " " + (monto * numeroDias) + "";
            }
            else
            {
                txtPago.Text = "";
                txtMonto.Text = "";
            }
            
        }

        private void txtPago_KeyUp(object sender, KeyEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPago.Text, "[0-9]"))
            {
                if (comboDias.SelectedIndex > 0)
                {
                    int monto = int.Parse(txtPago.Text);
                    int dias = int.Parse(comboDias.SelectedItem.ToString());

                    txtMonto.Text = " " + (monto * dias) + "";
                }
            }
            else
            {
                txtPago.Text = "";
                txtMonto.Text = "";
            }
        }

        private void comboMeses_SelectedIndexChanged(object sender, EventArgs e)
        {
            int meses = 1;
            meses = int.Parse(comboMeses.SelectedItem.ToString());

            if (checkRenovado.Checked)
            {
                dateFechaFinal.Value = DateTime.Today;
                dateFechaFinal.Value = dateFechaInicial.Value.AddMonths(meses);
            }
            else
            {
                dateFechaFinal.Value = dateFechaInicial.Value.AddMonths(meses);
            }
            
            
            if (!string.IsNullOrEmpty(txtMensual.Text) && comboMeses.SelectedIndex > 0)
            {
                int monto = int.Parse(txtMensual.Text);
                int numeroMeses = int.Parse(comboMeses.SelectedItem.ToString());

                txtMonto.Text = " " + (monto * numeroMeses) + "";
            }
            else
            {
                txtMensual.Text = "";
                txtMonto.Text = "";
            }
        }

        private void txtMensual_KeyUp(object sender, KeyEventArgs e)
        {

            try
            {

                if (System.Text.RegularExpressions.Regex.IsMatch(txtMensual.Text, "[0-9]"))
                {
                    if (comboMeses.SelectedIndex > 0)
                    {
                        int monto = int.Parse(txtMensual.Text);
                        int meses = int.Parse(comboMeses.SelectedItem.ToString());

                        txtMonto.Text = " " + (monto * meses) + "";
                    }
                }
                else
                {
                    txtMensual.Text = "";
                    txtMonto.Text = "";
                }

            }

            catch (System.Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);

            }
        }

        private void lbFechaActual_Click(object sender, EventArgs e)
        {

        }

        private void txtPago_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {

                txtDiasManual.Enabled = true;
                txtMontoManual.Enabled = true;

                comboDias.Enabled = false;
                txtPago.Enabled = false;

                txtMensual.Enabled = false;
                comboMeses.SelectedItem = "0";
                comboMeses.Enabled = false;

                txtMonto.Text = "";
                txtPago.Text = "";
                txtMontoManual.Text = "";
                txtDiasManual.Text = "";
            }
        }

        private void txtDiasManual_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {

                if (System.Text.RegularExpressions.Regex.IsMatch(txtDiasManual.Text, "[0-9]"))
                {

                        /*hola*/
                    
                }
                else
                {
                    txtMensual.Text = "";
                    txtMonto.Text = "";
                    txtDiasManual.Text = "";
                }

            }

            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void txtMontoManual_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {

                if (System.Text.RegularExpressions.Regex.IsMatch(txtMontoManual.Text, "[0-9]"))
                {

                    txtMonto.Text = txtMontoManual.Text;

                }
                else
                {
                    txtMontoManual.Text = "";
                    txtMonto.Text = "0";
                }

            }

            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
