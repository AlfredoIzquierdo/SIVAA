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
    public partial class Inventario : Form
    {
        readonly UnidadLog PqteLog5 = new UnidadLog();
        string Noserie, vehiculostr, versionstr, colorstr, disponibilidadstr, model;
        Empleado _pqt;
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
            ReporteInventario reporteInventario = new ReporteInventario();
            reporteInventario.Show();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Versiones versiones = new Versiones(_pqt);
            this.Close();
            versiones.Show();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            MostrarInventario();
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

        }

        public void MostrarInventario()
        {
            List<UnidadNoUsar> listado = PqteLog5.Inventario();
            dataGridView1.DataSource = listado;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.RowIndex >= 0)
            {
                int i = dataGridView1.CurrentCell.RowIndex;
                Noserie = dataGridView1[0, i].Value.ToString();
                vehiculostr = dataGridView1[1, i].Value.ToString();
                versionstr = dataGridView1[2, i].Value.ToString();
                colorstr = dataGridView1[4, i].Value.ToString();
                disponibilidadstr = dataGridView1[5, i].Value.ToString();
                model = dataGridView1[3, i].Value.ToString();
                //MessageBox.Show("Serie= " + Noserie + "\r\nvehiculo = " + vehiculostr + "\r\nVersion = " + versionstr + "\r\nmodel = " + model);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            FichaTecnica ficha = new FichaTecnica(Noserie, vehiculostr, versionstr, model, colorstr, disponibilidadstr);
            ficha.Show();
        }

        
    }
}
