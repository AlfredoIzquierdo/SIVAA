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
            vehiculo.IDVehiculo = id;
            vehiculo.Nombre = txtNombre.Text;

            log.Modificar(vehiculo);

            this.Hide();
            Vehiculos vehiculos = new Vehiculos(null);
            vehiculos.Show();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login.inicio.Show();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio.Pedidos.Show();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio.Stock.Show();
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio.CalendarioCitas.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio.Ventas.Show();
        }

        private void btnCobros_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio.Caja.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio.Reportes.Show();
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
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(txtNombre.Text.Length>10)
            {
                MessageBox.Show("No no no");
                txtNombre.Text = "";
            }
        }
    }
}
