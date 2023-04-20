using Datos;
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
using static System.Net.Mime.MediaTypeNames;

namespace Pantallas_SIVAA
{
    public partial class NuevoCliente : Form
    {
        ClienteLog clienteLog = new ClienteLog();
        Cliente cliente = new Cliente();
        Empleado _pqt;
        public NuevoCliente(Empleado pqt)
        {
            InitializeComponent();
            _pqt = pqt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtApellidoPat.Text) | String.IsNullOrEmpty(txtNombreCliente.Text) | String.IsNullOrEmpty(txtApellidoMat.Text) | String.IsNullOrEmpty(txtCiudad.Text) | String.IsNullOrEmpty(txtRfc.Text) || String.IsNullOrEmpty(mtxtTelefono.Text)
              | String.IsNullOrEmpty(txtEstado.Text) | String.IsNullOrEmpty(txtColonia.Text) | String.IsNullOrEmpty(txtAgregarCorreo.Text) | String.IsNullOrEmpty(txtNoExterior.Text))
            {
                MessageBox.Show("Favor de llenar todos los campos");
            }
            else
            {

                List<Cliente> x = clienteLog.ListadoAll();
                string i = "C" + (x.Count + 3).ToString();
                cliente.IDCliente = i;
                cliente.Nombre = txtNombreCliente.Text;
                cliente.ApellidoPat = txtApellidoPat.Text;
                cliente.ApellidoMat = txtApellidoMat.Text;
                cliente.Correo = txtAgregarCorreo.Text;
                cliente.Telefono = mtxtTelefono.Text;
                cliente.RFC = txtRfc.Text;
                cliente.NoExterior = txtNoExterior.Text;
                cliente.Colonia = txtColonia.Text;
                cliente.Estado = txtEstado.Text;
                cliente.Ciudad = txtCiudad.Text;
                cliente.EstadoCliente = "Activo";

                clienteLog.Registrar(cliente);

                this.Hide();
                Clientes clientes = new Clientes(_pqt);
                clientes.Show();


            }
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

        private void NuevoCliente_Load(object sender, EventArgs e)
        {
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Clientes clientes = new Clientes(_pqt);
            clientes.Show();
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
