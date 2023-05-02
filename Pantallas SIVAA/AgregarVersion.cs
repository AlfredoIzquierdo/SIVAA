using Datos;
using Entidades;
using Logicas;
using Pantallas_SIVAA.Pedidos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantallas_SIVAA
{
    public partial class AgregarVersion : Form
    {
        VersionEntidad version = new VersionEntidad();
        Modelo modelo = new Modelo();
        ModeloVersion modeloVer = new ModeloVersion();
        ModeloVersionD modverl = new ModeloVersionD();
        VersionLog log = new VersionLog();
        ModeloD mods = new ModeloD();
        VehiculoLog veh = new VehiculoLog();
        Empleado _pqt;
        public AgregarVersion(Empleado pqt)
        {
            InitializeComponent();
            _pqt = pqt;
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

        private void btnAgregarVersion_Click(object sender, EventArgs e)
        {
            if (ComprobarEspacioVacio() == false)
            {
                List<VersionEntidad> x = log.ListadoTotal();
                string i = "VR" + (x.Count + 1).ToString();
                //  MessageBox.Show("I:" + i);
                version.IDVersion = i;
                version.Costo = Convert.ToDouble(txtCosto.Text);
                version.DistanciaEjes = txtDistancia.Text;
                version.Altura = txtAltura.Text;
                version.Anchura = txtAnchura.Text;
                version.Llantas = cbLlantas.Text;
                version.Version = txtVersion.Text;
                version.IDVehiculo = idVehiculo(cbVehiculo.Text);

                //version.IDVehiculo = "VH1";

                version.Transmision = cbTransmision.Text;
                version.Cilindraje = cbCilindros.Text;
                version.TipoAsientos = cbAsientos.Text;
                version.TipoCombustible = cbCombustible.Text;
                version.Rines = cbRines.Text;
                version.CapacidadCajuela = txtCapacidad.Text;
                version.TipoTraccion = cbTipo.Text;
                version.NumPuertas = cbPuertas.Text;
                version.NumEngranajes = cbEngranajes.Text;
                version.RendimientoCombustible = txtRendimiento.Text;
                version.FrenosDelanteros = cbFrenosD.Text;
                version.FrenosTraseros = cbFrenosT.Text;
                version.SuspensionDelantera = cbSuspensionD.Text;
                version.SuspensionTrasera = cbSuspensionT.Text;
                version.ACAutom = verificacion(rbAcAutSi, rbAcAutNo);
                version.Pantalla = verificacion(rbPantallaSi, rbPantallaNo);
                version.FarosHal = verificacion(rbFarosHalSi, rbFarosHalNo);
                version.FarosLED = verificacion(rbLEDSi, rbLEDNo);
                version.AudioVelC = verificacion(rbAudioSi, rbAudioNo);
                version.TomaCorriente = verificacion(rbTomaSi, rbTomaNo);
                version.EspejosLatDirC = verificacion(rbEspejosDirSi, rbEspejosDirNo);
                version.EspejosLatAE = verificacion(rbEspejosASi, rbEspejosANo);
                version.CamaraTrasera = verificacion(rbCamaraSi, rbCamaraNo);
                version.EstadoVersion = "Activo";
                version.Año = txtAnio.Text;
                log.Registrar(version);

                //contar modelos
                List<Modelo> y = mods.ListadoTotal();
               foreach (Modelo m in y )
                {
                    if (m.Año.Trim() == txtAnio.Text)
                    {
                        modeloVer.IDVersion = i;
                        modeloVer.IDModelo = m.IDModelo;
                        modverl.Insertar(modeloVer);
                        break;
                    }
                }

                


                this.Close();
                Versiones versiones = new Versiones(_pqt);
                versiones.Show();
            }
            else
            {
                MessageBox.Show("Favor de rellanar todos los campos");
            }

        }

        private void AgregarVersion_Load(object sender, EventArgs e)
        {
            DateTime fechaActual = DateTime.Now;
            txtAnio.Items.Add(fechaActual.Year.ToString());
            List<Vehiculo> vh = veh.ListadoAll();
            foreach (Vehiculo x in vh)
            {
                cbVehiculo.Items.Add(x.Nombre);
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

        private string verificacion(RadioButton x, RadioButton y)
        {
            if (x.Checked == true)
            {
                return "si";
            }
            if (y.Checked == true)
            {
                return "No";
            }
            return "";
        }

        private bool ComprobarEspacioVacio()
        {
            bool vacio = false;
            if (string.IsNullOrEmpty(cbVehiculo.Text) | string.IsNullOrEmpty(txtVersion.Text) | string.IsNullOrEmpty(cbRines.Text) | string.IsNullOrEmpty(cbCilindros.Text) |
                string.IsNullOrEmpty(cbLlantas.Text) | string.IsNullOrEmpty(cbAsientos.Text) | string.IsNullOrEmpty(cbCombustible.Text) | string.IsNullOrEmpty(cbEngranajes.Text) |
                string.IsNullOrEmpty(txtCapacidad.Text) | string.IsNullOrEmpty(txtDistancia.Text) | string.IsNullOrEmpty(txtAltura.Text) | string.IsNullOrEmpty(txtAnchura.Text) |
                string.IsNullOrEmpty(cbTransmision.Text) | string.IsNullOrEmpty(cbTipo.Text) | string.IsNullOrEmpty(cbFrenosD.Text) | string.IsNullOrEmpty(cbFrenosT.Text) |
                string.IsNullOrEmpty(cbSuspensionD.Text) | string.IsNullOrEmpty(cbSuspensionT.Text) | string.IsNullOrEmpty(txtRendimiento.Text) | string.IsNullOrEmpty(txtAnio.Text))
            {
                vacio = true;
                return vacio;
            }
            else
            {
                return vacio;
            }

        }

        private string idVehiculo(string nombre)
        {
            List<Vehiculo> em = veh.ListadoAll();
            string id = null;
            foreach (Vehiculo x in em)
            {
                if (x.Nombre == nombre)
                {
                    id = x.IDVehiculo;
                    break;
                }
            }
            return id;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Versiones versiones = new Versiones(_pqt);
            versiones.Show();
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

        private void AgregarVersion_Load_1(object sender, EventArgs e)
        {

        }

        private void txtAnchura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDistancia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDistancia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtRendimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCapacidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
