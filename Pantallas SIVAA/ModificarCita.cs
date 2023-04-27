using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Logicas;
using Datos;
using System.Configuration;
using System.Data.SqlClient;
using Pantallas_SIVAA.Pedidos;

namespace Pantallas_SIVAA
{
    public partial class ModificarCita : Form
    {
        readonly EmpleadoLog empleado = new EmpleadoLog();
        string _idCita;
        Cita cita = new Cita();
        CitaD citaD = new CitaD();
        Empleado _pqt;
        public ModificarCita(string idCita, Empleado pqt)
        {
            InitializeComponent();
            _idCita = idCita;
            _pqt = pqt;
        }
        public List<String> ListadoTotal()
        {
            string CdCnx = ConfigurationManager.ConnectionStrings["CnxSQL"].ToString();
            List<string> productos = new List<string>();

            //Vuelvo a crear la conexión
            using (SqlConnection Cnx = new SqlConnection(CdCnx))
            {
                Cnx.Open();
                //Creo el Query (todos los registros de la tabla cliente
                string CdSql = "Select * from Empleado WHERE Tipo = 'Vendedor'";
                using (SqlCommand Cmd = new SqlCommand(CdSql, Cnx))
                {
                    SqlDataReader Dr = Cmd.ExecuteReader();
                    //Leo registro por registro que tiene la tabla 
                    while (Dr.Read())
                    {
                        //Cada vez que lo lea se crea un nuevo objeto
                        Empleado Pqte = new Empleado
                        {
                            IDEmpleado = Convert.ToString(Dr["IDEmpleado"]),
                            Nombre = Convert.ToString(Dr["Nombre"]),
                            ApellidoPat = Convert.ToString(Dr["ApellidoPaterno"]),
                            ApellidoMat = Convert.ToString(Dr["ApellidoMaterno"]),
                            RFC = Convert.ToString(Dr["RFC"]),
                            Correo = Convert.ToString(Dr["Correo"]),
                            Telefono = Convert.ToString(Dr["Telefono"]),
                            Contraseña = Convert.ToString(Dr["Contraseña"]),
                            Tipo = Convert.ToString(Dr["Tipo"])
                        };
                        productos.Add(Pqte.IDEmpleado.ToString());
                    }
                }
                Cnx.Close();
            }
            return productos;
        }
        private void ModificarCita_Load(object sender, EventArgs e)
        {
            CitaD citaD = new CitaD();
            citaD.ObtenerPdto(_idCita);
            CitaLog log = new CitaLog();
            List<Cita> ver = citaD.ListadoTotal();
            foreach (Cita x in ver)
            {
                if (x.IDCita == _idCita)
                {
                    lblAño.Text = x.Año.ToString();
                    lblDia.Text = x.Dia.ToString();
                    lblMes.Text = x.Mes.ToString();
                    lblHora.Text = x.Hora.ToString();
                    lblCliente.Text = x.IDCliente.ToString();
                    lblVendedor.Text = x.IDEmpleado.ToString();
                }
            }

            ClienteD clienteD = new ClienteD();
            List<Cliente> cli = clienteD.ListadoTotal();
            foreach (Cliente x in cli)
            {
                if (x.IDCliente == lblCliente.Text)
                    lblNombreCliente.Text = x.Nombre.ToString().Trim() + " " + x.ApellidoPat.ToString().Trim() + " " + x.ApellidoMat.ToString().Trim();
            }
            List<Empleado> emp = empleado.ListadoAll();
            foreach (Empleado x in emp)
            {
                dataGridView2.Rows.Add(x.IDEmpleado, x.Nombre, x.ApellidoPat, x.ApellidoMat);
            }

            switch (_pqt.Tipo.Trim())
            {
                case "Atencion":
                    // Funciones activas: Citas e inventario
                    lblTipoEmpleado.Text = _pqt.Tipo + " a clientes";
                    lblNombre.Text = "Bienvenido: " + _pqt.Nombre + " " + _pqt.ApellidoPat;


                    // Menu lateral
                    btnCitas.Enabled = true;
                    btnStock.Enabled = true;
                    btnReportes.Enabled = false;
                    btnPedidos.Enabled = false;
                    btnVentas.Enabled = false;
                    btnCobros.Enabled = false;
                    break;
                case "Vendedor":
                    // Funciones activas: ventas, inventario y citas
                    lblTipoEmpleado.Text = _pqt.Tipo;
                    lblNombre.Text = "Bienvenido: " + _pqt.Nombre + " " + _pqt.ApellidoPat;


                    //Menu lateral
                    btnCitas.Enabled = true;
                    btnStock.Enabled = true;
                    btnReportes.Enabled = false;
                    btnPedidos.Enabled = false;
                    btnVentas.Enabled = true;
                    btnCobros.Enabled = false;
                    break;
                // más casos...
                case "Cajero":


                    // El cajero no pasa por aqui, se va directo al apartado de caja

                    break;
                case "Supervisor":
                    // Todo esta activado, es la vista de supervisor
                    lblTipoEmpleado.Text = _pqt.Tipo;
                    lblNombre.Text = "Bienvenido: " + _pqt.Nombre + " " + _pqt.ApellidoPat;
                    break;
            }
        }

        private void btnAgregarCita_Click(object sender, EventArgs e)
        {
            CitaLog log = new CitaLog();
            cita.Año = Convert.ToInt32(lblAño.Text);
            cita.Dia = Convert.ToInt32(lblDia.Text);
            cita.Mes = Convert.ToInt32(lblMes.Text);
            cita.IDCliente = citaD.ObtenerPdto(_idCita).IDCliente;
            cita.Hora = lblHora.Text;
            cita.IDEmpleado = lblVendedor.Text;
            cita.IDCita = _idCita;
            cita.EstadoCita = "Activo";
            log.Modificar(cita);
            CalendarioCitas citaas = new CalendarioCitas(_pqt);
            this.Close();
            citaas.Show();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio(_pqt);
            this.Close();
            inicio.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            GestionarPedidos pedidos = new GestionarPedidos(_pqt);
            pedidos.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Inventario inventario = new Inventario(_pqt);
            inventario.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            CalendarioCitas citas = new CalendarioCitas(_pqt);
            citas.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Ventas ventas = new Ventas(_pqt);
            ventas.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            AbrirCaja Caja = new AbrirCaja(_pqt);
            Caja.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Reportes reportes = new Reportes(_pqt);
            reportes.Show();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            CalendarioCitas citas = new CalendarioCitas(_pqt);
            citas.Show();
        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            List<Empleado> pro;
            int opcion = cmbEmpleado.SelectedIndex;
            if (opcion == 0)
            {
                //txtbusqueda.Enabled = false;
                dataGridView2.Rows.Clear();
                List<Empleado> em = empleado.ListadoAll();
                foreach (Empleado x in em)
                {
                    if (x.EstadoEmpleado.Trim() == "Activo")
                    {
                        dataGridView2.Rows.Add(x.IDEmpleado, x.Nombre, x.ApellidoPat, x.ApellidoMat);
                    }

                }
                return;
            }
            else
            {
                if (txtBuscarEmpleado.Text == "")
                    MessageBox.Show("Llene el campo de búsqueda");
                if (txtBuscarEmpleado.Text != "")
                    dataGridView2.ClearSelection();
                pro = empleado.ListadoEspecifico(txtBuscarEmpleado.Text, cmbEmpleado.Text);
                dataGridView2.Rows.Clear();
                foreach (Empleado x in pro)
                {
                    if (x.EstadoEmpleado.Trim() == "Activo")
                    {
                        dataGridView2.Rows.Add(x.IDEmpleado, x.Nombre, x.ApellidoPat, x.ApellidoMat);
                    }
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaHoraSeleccionada = dateTimePicker1.Value;
            lblAño.Text = fechaHoraSeleccionada.ToString("yyyy");
            lblMes.Text = fechaHoraSeleccionada.ToString("MM");
            lblDia.Text = fechaHoraSeleccionada.ToString("dd");
            lblHora.Text = fechaHoraSeleccionada.ToString("HH:mm");
        }

        private void cmbEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtBuscarEmpleado.Text != "")
            {
                txtBuscarEmpleado.ResetText();
            }
            txtBuscarEmpleado.Enabled = true;
            if (cmbEmpleado.Text == "Todos")
            {
                txtBuscarEmpleado.Enabled = false;
                dataGridView2.ClearSelection();
                List<Empleado> emp = empleado.ListadoAll();
                foreach (Empleado x in emp)
                {
                    if (x.EstadoEmpleado.Trim() == "Activo")
                        dataGridView2.Rows.Add(x.IDEmpleado, x.Nombre, x.ApellidoPat, x.ApellidoMat);
                }
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblVendedor.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}
