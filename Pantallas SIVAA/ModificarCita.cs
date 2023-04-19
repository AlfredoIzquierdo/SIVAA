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
        string _idCita;
        Cita cita = new Cita();
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
            cmbVendedor.Items.AddRange(ListadoTotal().ToArray());


            CitaLog log = new CitaLog();
            List<Cita> ver = citaD.ListadoTotal();
            foreach (Cita x in ver)
            {
                if (x.IDCita == _idCita)
                {
                    lblAño.Text = x.Año.ToString();
                    lblDia.Text = x.Dia.ToString();
                    lblMes.Text = x.Mes.ToString();
                    txtHora.Text = x.Hora.ToString();
                    cmbVendedor.Text = x.IDEmpleado.ToString();
                }
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
        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            int dia = monthCalendar1.SelectionRange.Start.Day;
            int mes = monthCalendar1.SelectionRange.Start.Month;
            int año = monthCalendar1.SelectionRange.Start.Year;
            lblDia.Text = monthCalendar1.SelectionRange.Start.Day.ToString();
            lblMes.Text = monthCalendar1.SelectionRange.Start.Month.ToString();
            lblAño.Text = monthCalendar1.SelectionRange.Start.Year.ToString();
        }

        private void btnAgregarCita_Click(object sender, EventArgs e)
        {
            CitaLog log = new CitaLog();
            cita.Año = Convert.ToInt32(lblAño.Text);
            cita.Dia = Convert.ToInt32(lblDia.Text);
            cita.Mes = Convert.ToInt32(lblMes.Text);
            cita.Hora = txtHora.Text;
            cita.IDEmpleado = cmbVendedor.Text;
            cita.IDCita = lblIDCliente.Text;
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
    }
}
