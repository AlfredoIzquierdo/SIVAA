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
using System.Collections;

namespace Pantallas_SIVAA
{

    public partial class AgregarCita : Form
    {
        readonly ClienteLog cliente = new ClienteLog();
        readonly EmpleadoLog empleado = new EmpleadoLog();
        CitaLog log = new CitaLog();
        Cita cita = new Cita();
        Empleado _pqt;
        public AgregarCita(Empleado pqt)
        {
            InitializeComponent();
            _pqt = pqt;
        }


        private void AgregarCita_Load(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            List<Cliente> clie = cliente.ListadoAll();
            foreach (Cliente x in clie)
            {
                dataGridView1.Rows.Add(x.IDCliente, x.Nombre, x.ApellidoPat, x.ApellidoMat);
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

            if (lblHora.Text != "-" && lblEmpleado.Text != "Seleccione un empleado" && lblIDCliente.Text != "Seleccione un cliente")
            {
                List<Cita> x = log.ListadoAll();
                string i = "CT" + (x.Count + 1).ToString();
                cita.IDCita = i;

                cita.Dia = Convert.ToInt32(lblDia.Text);
                cita.Mes = Convert.ToInt32(lblMes.Text);
                cita.Año = Convert.ToInt32(lblAño.Text);
                cita.Hora = lblHora.Text;
                cita.IDEmpleado = lblEmpleado.Text;
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


        private void comboBusqueda_SelectedValueChanged(object sender, EventArgs e)
        {
            if (txtbusqueda.Text != "")
            {
                txtbusqueda.ResetText();
            }
            txtbusqueda.Enabled = true;
            if (comboBusqueda.Text == "Todos")
            {
                txtbusqueda.Enabled = false;
                dataGridView1.ClearSelection();
                List<Cliente> clie = cliente.ListadoAll();
                foreach (Cliente x in clie)
                {

                    if (x.EstadoCliente.Trim() == "Activo")
                        dataGridView1.Rows.Add(x.IDCliente, x.Nombre, x.ApellidoPat, x.ApellidoMat, x.RFC, x.Correo, x.Telefono, x.NoExterior, x.Colonia, x.Ciudad, x.Estado);
                }
            }
        }
        List<Cliente> listas = new List<Cliente>();
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbusqueda.Text))
            {
                MessageBox.Show("Llene el campo busqueda");
            }
            else
            {
                List<Cliente> datos = new List<Cliente>();

                datos = cliente.ListadoEspecifico(txtbusqueda.Text, comboBusqueda.Text);
                listas.Clear();
                dataGridView1.Rows.Clear();
                foreach (Cliente x in datos)
                {
                    if (x.EstadoCliente == "Activo")
                    {
                        listas.Add(x);
                        dataGridView1.Rows.Add(x.IDCliente, x.Nombre, x.ApellidoPat, x.ApellidoMat, x.RFC, x.Correo, x.Telefono, x.NoExterior, x.Colonia, x.Ciudad, x.Estado);
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

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblEmpleado.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
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

    }
}
