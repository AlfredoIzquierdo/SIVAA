using Datos;
using Entidades;
using Logicas;
using Pantallas_SIVAA.Pedidos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pantallas_SIVAA
{
    public partial class Vehiculos : Form
    {
        readonly VehiculoLog vehiculo = new VehiculoLog();
        string id = null;
        Empleado _pqt;
        public Vehiculos(Empleado pqt)
        {
            InitializeComponent();
            this._pqt = pqt;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio inicio = new Inicio(_pqt);
            inicio.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Close();
            AgregarVehiculos agregarVehiculos = new AgregarVehiculos(_pqt);
            agregarVehiculos.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            string id = null;
            if (dataGridView1.SelectedRows.Count == 1)
            {
                id = dataGridView1[0, dataGridView1.SelectedRows[0].Index].Value.ToString();
                ModificarVehiculo modificarVehiculo = new ModificarVehiculo(id, _pqt);
                this.Close();
                modificarVehiculo.Show();
            }
            else
            {
                MessageBox.Show("Favor de seleccionar un vehiculo");
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            GestionarPedidos pedidos = new GestionarPedidos(_pqt);
            pedidos.Show();
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

        private void pictureBox11_Click(object sender, EventArgs e)
        {


            if (dataGridView1.SelectedRows.Count == 1 && id != null)
            {
                id = dataGridView1[0, dataGridView1.SelectedRows[0].Index].Value.ToString();
                vehiculo.Eliminar(id);
                MessageBox.Show("Vehiculo eliminado correctamente");
                List<Vehiculo> vhe = vehiculo.ListadoAll();
                dataGridView1.DataSource = vhe;
            }
            else
            {
                MessageBox.Show("Favor de seleccionar un vehiculo");
            }

        }
        List<Vehiculo> listas;
        private void Vehiculos_Load(object sender, EventArgs e)
        {

            dataGridView1.ClearSelection();
            List<Vehiculo> pro = vehiculo.ListadoAll();
            listas = pro;
            dataGridView1.DataSource = "";
            dataGridView1.DataSource = pro;

            switch (_pqt.Tipo.Trim())
            {
                case "Atencion":
                    // Funciones activas: Citas e inventario
                    lblTipoEmpleado.Text = _pqt.Tipo + " a clientes";
                    lblNombre.Text = "Bienvenido: " + _pqt.Nombre.Trim() + " " + _pqt.ApellidoPat;


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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
                id = dataGridView1[0, dataGridView1.SelectedRows[0].Index].Value.ToString();

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ReporteVehiculos rp = new ReporteVehiculos(listas);
            rp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbOpcionBusqueda.SelectedIndex != 0)
            {
                List<Vehiculo> pro;
                int opcion = cmbOpcionBusqueda.SelectedIndex;
                dataGridView1.ClearSelection();
                pro = vehiculo.ListadoEspecifico(txtValorBusqueda.Text, cmbOpcionBusqueda.Text);
                listas = pro;
                dataGridView1.DataSource = "";
                dataGridView1.DataSource = pro;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
                id = dataGridView1[0, dataGridView1.SelectedRows[0].Index].Value.ToString();
            }
        }

        private void cmbOpcionBusqueda_SelectedValueChanged(object sender, EventArgs e)
        {
            if (txtValorBusqueda.Text != "")
                txtValorBusqueda.ResetText();
            if (cmbOpcionBusqueda.SelectedIndex == 0)
            {
                dataGridView1.ClearSelection();
                List<Vehiculo> pro = vehiculo.ListadoAll();
                listas = pro;
                dataGridView1.DataSource = "";
                dataGridView1.DataSource = pro;
            }
        }
    }
}
