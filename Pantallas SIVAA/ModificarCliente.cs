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
using Entidades;
using Logicas;

namespace Pantallas_SIVAA
{
    public partial class ModificarCliente : Form
    {
        ClienteLog log = new ClienteLog();
        Cliente cliente = new Cliente();

        string id;

        Empleado _pqt;
        public ModificarCliente(string idCliente, Empleado pqt)
        {
            InitializeComponent();
            _pqt = pqt;
            id = idCliente;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            cliente.IDCliente = id;
            cliente.Nombre = txtNombre.Text;
            cliente.ApellidoPat = txtApellidoP.Text;
            cliente.ApellidoMat = txtApellidoM.Text;
            cliente.Correo = txtAgregarCorreo.Text;
            cliente.Telefono = txtTelefono.Text;
            cliente.RFC = txtRFC.Text;
            cliente.NoExterior = txtNoExterior.Text;
            cliente.Colonia = txtColonia.Text;
            cliente.Estado = txtEstado.Text;
            cliente.Ciudad = txtCiudad.Text;

            log.Modificar(cliente);

            this.Close();
            Clientes clientes = new Clientes(_pqt);
            clientes.Show();
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


        private void ModificarCliente_Load(object sender, EventArgs e)
        {
            List<Cliente> cliente = log.ListadoAll();
            foreach (Cliente x in cliente)
            {
                if (x.IDCliente == id)
                {
                    txtNombre.Text = x.Nombre;
                    txtRFC.Text = x.RFC;
                    txtApellidoP.Text = x.ApellidoPat;
                    txtApellidoM.Text = x.ApellidoMat;
                    txtNoExterior.Text = x.NoExterior;
                    txtCiudad.Text = x.Ciudad;
                    txtAgregarCorreo.Text = x.Correo;
                    txtEstado.Text = x.Estado;
                    txtColonia.Text = x.Colonia;
                    txtTelefono.Text = x.Telefono;
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Clientes clientes = new Clientes(_pqt);
            clientes.Show();
        }

        private void btnCitas_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCobros_Click_1(object sender, EventArgs e)
        {

        }

        private void btnVentas_Click_1(object sender, EventArgs e)
        {

        }

        private void btnReportes_Click_1(object sender, EventArgs e)
        {

        }

        private void btnStock_Click_1(object sender, EventArgs e)
        {

        }

        private void btnPedidos_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click_1(object sender, EventArgs e)
        {

        }

        private void ModificarCliente_Load_1(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
