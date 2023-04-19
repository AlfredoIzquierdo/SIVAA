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
            AbrirCaja Caja = new AbrirCaja(_pqt);
            this.Close();
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
            this.Close();
            Inicio inicio = new Inicio(_pqt);
            inicio.Show();
        }

        private void btnAgregarVersion_Click(object sender, EventArgs e)
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
            MessageBox.Show(version.IDVehiculo);
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

            log.Registrar(version);


            this.Close();
            Versiones versiones = new Versiones(_pqt);
            versiones.Show();
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
