﻿using Datos;
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
        Versions version = new Versions();
        VersionLog log = new VersionLog();
        VehiculoLog veh = new VehiculoLog();
        Versiones versiones = new Versiones();

        public AgregarVersion()
        {
            InitializeComponent();
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

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login.inicio.Show();
        }

        private void btnAgregarVersion_Click(object sender, EventArgs e)
        {
            if (ComprobarEspacioVacio() == false)
            {
                List<Versions> x = log.ListadoTotal();
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
                log.Registrar(version);

                
                this.Hide();
                versiones.Show();
            } else
            {
                MessageBox.Show("Favor de rellanar todos los campos");
            }
            
        }

        private void AgregarVersion_Load(object sender, EventArgs e)
        {
            List<Vehiculo> vh = veh.ListadoAll();
            foreach (Vehiculo x in vh)
            {
                cbVehiculo.Items.Add(x.Nombre);
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

        private bool ComprobarEspacioVacio ()
        {
            bool vacio = false;
            if (string.IsNullOrEmpty(cbVehiculo.Text)| string.IsNullOrEmpty(txtVersion.Text) | string.IsNullOrEmpty(cbRines.Text) | string.IsNullOrEmpty(cbCilindros.Text) |
                string.IsNullOrEmpty(cbLlantas.Text) | string.IsNullOrEmpty(cbAsientos.Text) | string.IsNullOrEmpty(cbCombustible.Text) | string.IsNullOrEmpty(cbEngranajes.Text) |
                string.IsNullOrEmpty(txtCapacidad.Text) | string.IsNullOrEmpty(txtDistancia.Text) | string.IsNullOrEmpty(txtAltura.Text) | string.IsNullOrEmpty(txtAnchura.Text) | 
                string.IsNullOrEmpty(cbTransmision.Text) | string.IsNullOrEmpty(cbTipo.Text) | string.IsNullOrEmpty(cbFrenosD.Text) | string.IsNullOrEmpty(cbFrenosT.Text) |
                string.IsNullOrEmpty(cbSuspensionD.Text) | string.IsNullOrEmpty(cbSuspensionT.Text) | string.IsNullOrEmpty(txtRendimiento.Text))
            {
                vacio = true;
                return vacio;
            } else
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


    }
}
