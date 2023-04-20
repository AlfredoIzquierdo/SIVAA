using Entidades;
using Logicas;
using Pantallas_SIVAA.Pedidos;
using System;
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

namespace Pantallas_SIVAA
{
    public partial class ModificarVehiculo : Form
    {
        VehiculoLog log = new VehiculoLog();
        Vehiculo vehiculo = new Vehiculo();
        string id;
        Empleado _pqt;
        public ModificarVehiculo(string idVehiculo, Empleado pqt)
        {
            InitializeComponent();
            this._pqt = pqt;
            id = idVehiculo;

        }

        private void btnModificarVehiculo_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                vehiculo.IDVehiculo = id;
                vehiculo.Nombre = txtNombre.Text;
                log.Modificar(vehiculo);
                log.ListadoAll();
                this.Close();
                Vehiculos vehiculos = new Vehiculos(_pqt);
                vehiculos.Show();
            }
            else
                MessageBox.Show("Seleccione un vehiculo a modificar");
            
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

        

        private void ModificarVehiculo_Load(object sender, EventArgs e)
        {
            //List<Vehiculo> vh = log.ListadoAll();
            //foreach (Vehiculo x in vh)
            //{
            //    if (x.IDVehiculo == id)
            //    {
            //        txtNombre.Text = x.Nombre;
            //    }
            //}
            
            Vehiculo vh = log.LeerPorClave(id);
            txtNombre.Text = vh.Nombre;
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

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(txtNombre.Text.Length>10)
            {
                MessageBox.Show("No no no");
                txtNombre.Text = "";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Vehiculos vehiculos = new Vehiculos(_pqt);
            this.Close();
            vehiculos.Show();
        }
    }
}
