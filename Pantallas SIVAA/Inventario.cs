using Datos;
using Entidades;
using Logicas;
using Pantallas_SIVAA.Pedidos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Design.AxImporter;

namespace Pantallas_SIVAA
{
    public partial class Inventario : Form
    {
        readonly UnidadLog PqteLog5 = new UnidadLog();
        string Noserie, vehiculostr, versionstr, colorstr, disponibilidadstr, model;
        Empleado _pqt;
        List<UnidadNoUsar> lista;
        public Inventario(Empleado pqt)
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
            ReporteInventario reporteInventario = new ReporteInventario(_pqt,lista);
            reporteInventario.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click_1(object sender, EventArgs e)
        {

        }

        private void btnPedidos_Click_1(object sender, EventArgs e)
        {

        }

        private void btnStock_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCitas_Click_1(object sender, EventArgs e)
        {

        }

        private void btnVentas_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCobros_Click_1(object sender, EventArgs e)
        {

        }

        private void btnReportes_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Versiones versiones = new Versiones(_pqt);
            this.Close();
            versiones.Show();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            List<UnidadNoUsar> clie = PqteLog5.Inventario();
            lista = clie;
            foreach (UnidadNoUsar x in clie)
            {
                dataGridView1.Rows.Add(x.NoSerie, x.Vehiculo, x.Version, x.Color, x.Estatus);
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

        private void button1_Click(object sender, EventArgs e)
        {
            int opcion = cmbOpcionBusqueda.SelectedIndex;
            if (opcion == 0)
            {
                txtValorBusqueda.Text = "";
                dataGridView1.Rows.Clear();
                List<UnidadNoUsar> em = PqteLog5.Inventario();
                lista = em;
                foreach (UnidadNoUsar x in em)
                {
                    dataGridView1.Rows.Add(x.NoSerie, x.Vehiculo, x.Version, x.Color, x.Estatus);
                }
                return;
            }
            if (opcion == 1 || opcion == 4)
            {
                dataGridView1.Rows.Clear();
                List<UnidadNoUsar> em = PqteLog5.InventarioFiltro(txtValorBusqueda.Text, cmbOpcionBusqueda.Text);
                lista = em;
                foreach (UnidadNoUsar x in em)
                {
                    dataGridView1.Rows.Add(x.NoSerie, x.Vehiculo, x.Version, x.Color, x.Estatus);
                }
            }
            if (opcion == 2)
            {
                dataGridView1.Rows.Clear();
                List<UnidadNoUsar> em = PqteLog5.InventarioVehiculo(txtValorBusqueda.Text);
                lista = em;
                foreach (UnidadNoUsar x in em)
                {
                    dataGridView1.Rows.Add(x.NoSerie, x.Vehiculo, x.Version, x.Color, x.Estatus);
                }
            }
            if (opcion == 3)
            {
                dataGridView1.Rows.Clear();
                List<UnidadNoUsar> em = PqteLog5.InventarioVersion(txtValorBusqueda.Text);
                lista = em;
                foreach (UnidadNoUsar x in em)
                {
                    dataGridView1.Rows.Add(x.NoSerie, x.Vehiculo, x.Version, x.Color, x.Estatus);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
                
            }

            if (dataGridView1.CurrentCell.RowIndex >= 0)
            {
                int i = dataGridView1.CurrentCell.RowIndex;
                Noserie = dataGridView1[0, i].Value.ToString();
                vehiculostr = dataGridView1[1, i].Value.ToString();
                versionstr = dataGridView1[2, i].Value.ToString();
                //model = dataGridView1[3, i].Value.ToString();
                colorstr = dataGridView1[3, i].Value.ToString();
                //disponibilidadstr = dataGridView1[5, i].Value.ToString();

                //MessageBox.Show("Serie= " + Noserie + "\r\nvehiculo = " + vehiculostr + "\r\nVersion = " + versionstr + "\r\nmodel = " + model);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                FichaTecnica ficha = new FichaTecnica(Noserie, vehiculostr, versionstr, model, colorstr, disponibilidadstr);
                ficha.Show();
            }
            else
                MessageBox.Show("Seleccione un vehiculo a consultar");

        }


    }
}
