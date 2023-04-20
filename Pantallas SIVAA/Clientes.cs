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


namespace Pantallas_SIVAA
{
    public partial class Clientes : Form
    {
        readonly ClienteLog cliente = new ClienteLog();
        Empleado _pqt;
        public Clientes(Empleado pqt)
        {
            InitializeComponent();
            _pqt = pqt;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio(_pqt);
            this.Close();
            inicio.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Close();
            NuevoCliente nuevoCliente = new NuevoCliente(_pqt);
            nuevoCliente.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            string id = null;
            if (dataGridView1.SelectedRows.Count == 1)
            {
                id = dataGridView1[0, dataGridView1.SelectedRows[0].Index].Value.ToString();
                ModificarCliente modificarCliente = new ModificarCliente(id, _pqt);
                this.Close();
                modificarCliente.Show();
            }
            else
            {
                MessageBox.Show("Favor de seleccionar un cliente");
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ReporteClientes r = new ReporteClientes(listas);
            r.Show();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            List<Cliente> clie = cliente.ListadoAll();
            foreach (Cliente x in clie)
            {
                if (x.EstadoCliente == "Activo")
                {

                    dataGridView1.Rows.Add(x.IDCliente, x.Nombre, x.ApellidoPat, x.ApellidoMat, x.RFC, x.Correo, x.Telefono, x.NoExterior, x.Colonia, x.Ciudad, x.Estado);

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }
        }
        List<Cliente> listas;
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
                listas = datos;
                dataGridView1.Rows.Clear();
                foreach (Cliente x in datos)
                {
                    dataGridView1.Rows.Add(x.IDCliente, x.Nombre, x.ApellidoPat, x.ApellidoMat, x.RFC, x.Correo, x.Telefono, x.NoExterior, x.Colonia, x.Ciudad, x.Estado);
                }

            }
        }

        private void comboversion_SelectedValueChanged(object sender, EventArgs e)
        {
            txtbusqueda.Enabled = true;
            if (comboBusqueda.Text == "Todos")
            {
                txtbusqueda.Enabled = false;
                dataGridView1.ClearSelection();
                List<Cliente> clie = cliente.ListadoAll();
                foreach (Cliente x in clie)
                {
                    dataGridView1.Rows.Add(x.IDCliente, x.Nombre, x.ApellidoPat, x.ApellidoMat, x.RFC, x.Correo, x.Telefono, x.NoExterior, x.Colonia, x.Ciudad, x.Estado);
                }
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            string id = null;
            if (dataGridView1.SelectedRows.Count == 1)
            {
                id = dataGridView1[0, dataGridView1.SelectedRows[0].Index].Value.ToString();
                cliente.EliminarPorStatus(id);
                MessageBox.Show("Cliente Eliminado");
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Favor de seleccionar un cliente");
            }
        }

        private void btnEstadosCuenta_Click(object sender, EventArgs e)
        {

        }
        private bool isFormBorderStyleNone = false;
        private bool isFormBorderStyleChanged = false;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bitmap, new Rectangle(0, 0, this.Width, this.Height));
            e.Graphics.DrawImage(bitmap, 0, 0);

        }

        private void pictureBox8_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click_1(object sender, EventArgs e)
        {

        }

        private void btnEstadosCuenta_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Clientes_Load_1(object sender, EventArgs e)
        {

        }

        private void btnReportes_Click_1(object sender, EventArgs e)
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

        private void btnStock_Click_1(object sender, EventArgs e)
        {

        }

        private void btnPedidos_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click_1(object sender, EventArgs e)
        {

        }
    }
}
