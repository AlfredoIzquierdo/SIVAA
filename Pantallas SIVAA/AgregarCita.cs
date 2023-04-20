using System;
using Entidades;
using Logicas;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using Pantallas_SIVAA.Pedidos;

namespace Pantallas_SIVAA
{

    public partial class AgregarCita : Form
    {
        readonly ClienteLog cliente = new ClienteLog();
        CitaLog log = new CitaLog();
        Cita cita = new Cita();
        Empleado _pqt;
        public AgregarCita(Empleado pqt)
        {
            InitializeComponent();
            _pqt = pqt;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            int dia = monthCalendar1.SelectionRange.Start.Day;
            int mes = monthCalendar1.SelectionRange.Start.Month;
            int año = monthCalendar1.SelectionRange.Start.Year;
        }

        private void AgregarCita_Load(object sender, EventArgs e)
        {
            lblDia.Text = monthCalendar1.SelectionRange.Start.Day.ToString();
            lblMes.Text = monthCalendar1.SelectionRange.Start.Month.ToString();
            lblAño.Text = monthCalendar1.SelectionRange.Start.Year.ToString();
            dataGridView1.ClearSelection();
            cmbVendedor.Items.AddRange(ListadoTotal().ToArray());
            List<Cliente> clie = cliente.ListadoAll();
            foreach (Cliente x in clie)
            {
                dataGridView1.Rows.Add(x.IDCliente, x.Nombre, x.ApellidoPat, x.ApellidoMat, x.RFC, x.Correo, x.Telefono, x.NoExterior, x.Colonia, x.Ciudad, x.Estado);
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

        private void btnAgregarCita_Click(object sender, EventArgs e)
        {

            if (txtHora.Text != "" && cmbVendedor.Text != "" && lblIDCliente.Text != "Seleccione un cliente")
            {
                List<Cita> x = log.ListadoAll();
                string i = "CT" + (x.Count + 1).ToString();
                cita.IDCita = i;

                cita.Dia = Convert.ToInt32(lblDia.Text);
                cita.Mes = Convert.ToInt32(lblMes.Text);
                cita.Año = Convert.ToInt32(lblAño.Text);
                cita.Hora = txtHora.Text;
                cita.IDEmpleado = cmbVendedor.Text;
                cita.IDCliente = lblIDCliente.Text;
                log.Registrar(cita);
                CalendarioCitas citas = new CalendarioCitas(_pqt);
                this.Close();
                citas.Show();
            }
            else
                MessageBox.Show("Debe terminar de llenar los campos");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblIDCliente.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

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

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio(_pqt);
            this.Close();
            inicio.Show();

        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            this.Close();
            GestionarPedidos pedidos = new GestionarPedidos(_pqt);
            pedidos.Show();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            this.Close();
            Inventario inventario = new Inventario(_pqt);
            inventario.Show();
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            this.Close();
            CalendarioCitas citas = new CalendarioCitas(_pqt);
            citas.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            this.Close();
            Ventas ventas = new Ventas(_pqt);
            ventas.Show();
        }

        private void btnCobros_Click(object sender, EventArgs e)
        {
            this.Close();
            AbrirCaja Caja = new AbrirCaja(_pqt);
            Caja.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            this.Close();
            Reportes reportes = new Reportes(_pqt);
            reportes.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio(_pqt);
            this.Close();
            inicio.Show();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            CalendarioCitas citas = new CalendarioCitas(_pqt);
            citas.Show();
        }

        private void btnStock_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCobros_Click_1(object sender, EventArgs e)
        {

        }

        private void btnVentas_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCitas_Click_1(object sender, EventArgs e)
        {

        }

        private void btnReportes_Click_1(object sender, EventArgs e)
        {

        }

        private void btnPedidos_Click_1(object sender, EventArgs e)
        {

        }
    }
}
