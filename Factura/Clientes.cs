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
    public partial class Clientes : Form
    {

        IntPtr h = IntPtr.Zero;
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
                        MessageBox.Show("Fallo de conexion al dispositivo");
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

        public Clientes()
        {
            InitializeComponent();
        }
        
        private void Clientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'accessDataSet.USERINFO' Puede moverla o quitarla según sea necesario.
            this.uSERINFOTableAdapter1.Fill(this.accessDataSet.USERINFO);
            validate_access_style();
            // TODO: esta línea de código carga datos en la tabla 'accessDataSet.USERINFO' Puede moverla o quitarla según sea necesario.
            //this.uSERINFOTableAdapter1.Fill(this.accessDataSet.USERINFO);
        }

        void validate_access_style()
        {
            List<DataGridViewRow> lista = bunifuCustomDataGrid1.Rows.Cast<DataGridViewRow>().ToList();
            //lista.ForEach(x => x.DefaultCellStyle.BackColor = Color.Red);
            //bunifuCustomDataGrid1.Rows[2].DefaultCellStyle.BackColor = Color.Red;
            foreach (DataGridViewRow fila in lista)
            {
                string fecha = fila.AccessibilityObject.Value.Split(';')[6].ToString();
                
                if (fecha != "(null)")
                {
                    DateTime clienteFechaFinal = DateTime.Parse(fecha);
             
                    if (clienteFechaFinal < DateTime.Now)
                    {
                        fila.Cells[6].Style.BackColor = Color.Red;
                    }
                }
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            NuevoCliente fm = new NuevoCliente();
            fm.btnGuardarCliente.Text = "Guardar";
            fm.btnEditar.Visible = false;
            fm.btnGuardarCliente.Visible = true;
            fm.groupBox2.Enabled = false;
            fm.ShowDialog();
        }

        private void TxtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            OleDbConnection Conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\ZKTeco\\ZKAccess3.5\\Access.mdb");
            Conexion.Open();
            OleDbCommand Comando = Conexion.CreateCommand();
            Comando.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(Comando);

            if (!(string.IsNullOrEmpty(txtBuscar.Text)))
            {
                Comando.CommandText = "SELECT * FROM  USERINFO WHERE (Badgenumber = '" + txtBuscar.Text + "') OR name like  ('" + txtBuscar.Text + "%');";
                Comando.ExecuteNonQuery();

                da.Fill(dt);
                bunifuCustomDataGrid1.DataSource = dt;   
            }
            else
            {
                Comando.CommandText = "SELECT * FROM  USERINFO";
                Comando.ExecuteNonQuery();
                da.Fill(dt);
                bunifuCustomDataGrid1.DataSource = dt;
            }
            Conexion.Close();
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            NuevoCliente frm = new NuevoCliente();
            try
            {
                if (bunifuCustomDataGrid1.SelectedRows.Count > 0)
                {
                    //Cambiar los Labels del formulario de Agregar Clientes
                    frm.btnGuardarCliente.Text = "Modificar";

                    frm.txtIdCliente.Enabled = false;
                    frm.btnEditar.Visible = true;
                    frm.btnGuardarCliente.Visible = false;

                    //Mostrar el genero en el ComboBox del formulario Agregar Clientes
                    string genero = bunifuCustomDataGrid1.CurrentRow.Cells[3].Value.ToString();
                    if (genero == "M")
                    {
                        frm.comboGenero.SelectedIndex = 0;
                    }
                    else if (genero == "F")
                    {
                        frm.comboGenero.SelectedIndex = 1;
                    }

                    DateTime clienteFechaInicial = DateTime.Parse(bunifuCustomDataGrid1.CurrentRow.Cells[5].Value.ToString());
                    DateTime clienteFechaFinal = DateTime.Parse(bunifuCustomDataGrid1.CurrentRow.Cells[6].Value.ToString());
                    frm.groupBox2.Enabled = true;

                    //Llevar los datos del cliente al formulario de Agregar CLientes
                    frm.txtIdCliente.Text = bunifuCustomDataGrid1.CurrentRow.Cells[0].Value.ToString();
                    frm.txtNombreCliente.Text = bunifuCustomDataGrid1.CurrentRow.Cells[1].Value.ToString();
                    frm.txtApellidoCliente.Text = bunifuCustomDataGrid1.CurrentRow.Cells[2].Value.ToString();
                    frm.txtTelefono.Text = bunifuCustomDataGrid1.CurrentRow.Cells[4].Value.ToString();
                    frm.txtCorreo.Text = bunifuCustomDataGrid1.CurrentRow.Cells[7].Value.ToString();
                    frm.clienteFechaInicial.Value = clienteFechaInicial;
                    frm.clienteFechaFinal.Value = clienteFechaFinal;
                    frm.ShowDialog();
                    frm.Refresh();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una fila", "Seleccione una Fila", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error: ", ex.Message);
            }
        }

        [DllImport("plcommpro.dll", EntryPoint = "DeleteDeviceData")]
        public static extern int DeleteDeviceData(IntPtr h, string tablename, string data, string options);

        void sincronizarBorrar()
        {
            string idCliente = "";
           
            if (conectarIP())
            {
                try
                {
                    //Conexion a la base de datos
                    OleDbConnection Conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\ZKTeco\\ZKAccess3.5\\Access.mdb");
                 
                    if (bunifuCustomDataGrid1.SelectedRows.Count > 0)
                    {
                            idCliente = bunifuCustomDataGrid1.CurrentRow.Cells[0].Value.ToString();
                    }

                    int ret = 0;
                    string data = "Pin="+idCliente+"";
                    string options = "";
                    string devtablename = "";

                    if (IntPtr.Zero != h)
                    {                        
                        devtablename = "user";
                        ret = DeleteDeviceData(h, devtablename, data, options);

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
                        MessageBox.Show("Conexion Fallida!");
                        return;
                    }
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (bunifuCustomDataGrid1.SelectedRows.Count > 0)
                {
                    string idCliente = bunifuCustomDataGrid1.CurrentRow.Cells[0].Value.ToString();
                    var confirmar = MessageBox.Show("Esta seguro que desea eliminar el registro?", "Eliminar Registro", MessageBoxButtons.YesNo);
                    if (confirmar == DialogResult.Yes)
                    {
                        OleDbConnection Conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\ZKTeco\\ZKAccess3.5\\Access.mdb");
                        Conexion.Open();
                        string cadena = "DELETE * FROM  USERINFO WHERE Badgenumber = '" + idCliente + "';";
                        OleDbCommand comando = new OleDbCommand(cadena, Conexion);
                        comando.ExecuteNonQuery();
                        sincronizarBorrar();
                        Conexion.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        
        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NuevoCliente frm = new NuevoCliente();

            if (bunifuCustomDataGrid1.SelectedRows.Count > 0)
            {
                //Cambiar los Labels del formulario de Agregar Clientes
                frm.btnGuardarCliente.Text = "Modificar";

                frm.txtIdCliente.Enabled = false;
                frm.btnEditar.Visible = true;
                frm.btnGuardarCliente.Visible = false;

                //Mostrar el genero en el ComboBox del formulario Agregar Clientes
                string genero = bunifuCustomDataGrid1.CurrentRow.Cells[4].Value.ToString();
                if (genero.ToLower() == "m")
                {
                    frm.comboGenero.SelectedIndex = 0;
                }
                else
                {
                    frm.comboGenero.SelectedIndex = 1;
                }

                DateTime clienteFechaInicial = DateTime.Parse(bunifuCustomDataGrid1.CurrentRow.Cells[5].Value.ToString());
                DateTime clienteFechaFinal = DateTime.Parse(bunifuCustomDataGrid1.CurrentRow.Cells[6].Value.ToString());
                frm.groupBox2.Enabled = true;

                //Llevar los datos del cliente al formulario de Agregar CLientes
                frm.txtIdCliente.Text = bunifuCustomDataGrid1.CurrentRow.Cells[0].Value.ToString();
                frm.txtNombreCliente.Text = bunifuCustomDataGrid1.CurrentRow.Cells[1].Value.ToString();
                frm.txtApellidoCliente.Text = bunifuCustomDataGrid1.CurrentRow.Cells[2].Value.ToString();
                frm.txtTelefono.Text = bunifuCustomDataGrid1.CurrentRow.Cells[4].Value.ToString();
                frm.clienteFechaInicial.Value = clienteFechaInicial;
                frm.clienteFechaFinal.Value = clienteFechaFinal;
                frm.txtCorreo.Text = bunifuCustomDataGrid1.CurrentRow.Cells[7].Value.ToString();
                frm.ShowDialog();
                frm.Refresh();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila", "Seleccione una Fila", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnImprimirClientes_Click(object sender, EventArgs e)
        {
            ImprimirClientes clientes = new ImprimirClientes();
            clientes.ShowDialog();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
