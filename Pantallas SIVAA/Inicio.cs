using Entidades;
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

namespace Pantallas_SIVAA
{
    public partial class Inicio : Form
    {
        // principal


        // barra lateral


        private Empleado _pqt;
        public Inicio(Empleado pqt)
        {
            InitializeComponent();
            _pqt = pqt;
        }


        public Inicio()
        {
            InitializeComponent();
        }

        private void btnVehículos_Click(object sender, EventArgs e)
        {
            this.Close();
            Vehiculos vehiculos1 = new Vehiculos(_pqt);
            vehiculos1.Show();
        }

        private void btnVersiones_Click(object sender, EventArgs e)
        {
            this.Close();
            Versiones versiones = new Versiones(_pqt);
            versiones.Show();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            this.Close();
            GestionarEmpleados gestionarEmpleados = new GestionarEmpleados(_pqt);
            gestionarEmpleados.Show();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            this.Close();
            ProovedoresPrin proovedoresPrin = new ProovedoresPrin(_pqt);
            proovedoresPrin.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            this.Close();
            Clientes clientes = new Clientes(_pqt);
            clientes.Show();
        }

        private void btnCotizacion_Click(object sender, EventArgs e)
        {
            this.Close();
            Cotizacion cotizacion = new Cotizacion(_pqt);
            cotizacion.Show();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            switch (_pqt.Tipo.Trim())
            {
                case "Atencion":
                    // Funciones activas: Citas e inventario
                    lblTipoEmpleado.Text = _pqt.Tipo + " a clientes";
                    lblNombre.Text = "Bienvenido: " + _pqt.Nombre + " " + _pqt.ApellidoPat;

                    //Panel central
                    btnVehículos.Enabled = false;
                    btnClientes.Enabled = false;
                    btnCotizacion.Enabled = false;
                    btnProveedor.Enabled = false;
                    btnVersiones.Enabled = false;
                    btnEmpleados.Enabled = false;
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

                    //Panel central
                    btnVehículos.Enabled = false;
                    btnProveedor.Enabled = false;
                    btnClientes.Enabled = false;
                    btnCotizacion.Enabled = true;
                    btnProveedor.Enabled = false;
                    btnVersiones.Enabled = false;
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

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio(_pqt);
            this.Close();
            inicio.Show();

        }


    }
}
