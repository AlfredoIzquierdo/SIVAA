using Entidades;
using Logicas;
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

    public partial class TablaAmortizacionCon : Form
    {

        readonly ClienteLog PqteLog = new ClienteLog();
        readonly EmpleadoLog empleadoLog = new EmpleadoLog();

        readonly AmortizacionesLOG amorlog = new AmortizacionesLOG();
        Entidades.Cotizacion datoscotizacion;
        CotizacionContado datoscotcontado;
        Cliente datoscliente;
        Versions datosversion;
        Vehiculo datosvehiculo;
        Modelo datosmodelo;
        Empleado empleado = new Empleado();
        ModeloVersion modeloVersion;
        private bool isFormBorderStyleNone = false;
        private bool isFormBorderStyleChanged = false;
        ModeloVersion datosModVer;
        public TablaAmortizacionCon(string idcotizacion)
        {
            InitializeComponent();
            datoscotizacion = amorlog.ObtenerCotizacion(idcotizacion);
            datoscotcontado = amorlog.ObtenerCotizacionContado(datoscotizacion.IDCotizacion);
            datoscliente = amorlog.ObtenerDatosCliente(datoscotizacion.IDCliente);
            datosversion = amorlog.ObtenerDatosVersions(datoscotizacion.IDVersion);
            modeloVersion = amorlog.ObtenerModeloVersion(datoscotizacion.IDVersion);
            datosvehiculo = amorlog.ObtenerDatosVehiculo(datosversion.IDVehiculo);
            datosmodelo = amorlog.ObtenerDatosModelo(modeloVersion.IDModelo);
            empleado = empleadoLog.LeerPorClave(datoscotizacion.IDEmpleado);
            //partesuperior
            lblidcot.Text = datoscotizacion.IDCotizacion;
            lbldia.Text = datoscotizacion.Dia.ToString();
            lblmes.Text = datoscotizacion.Mes.ToString();
            lblano.Text = datoscotizacion.Año.ToString();
            //vehiculo
            lblvehiculo.Text = datosvehiculo.Nombre;
            lblversion.Text = datosversion.Version;
            lblmodelo.Text = datosmodelo.Año;
            //financiamiento
            lblprecioini.Text= datoscotizacion.PrecioInicial.ToString();
            lbliva.Text = (datoscotizacion.PrecioInicial * 0.16).ToString();
            lblempleado.Text = empleado.Nombre.Trim() + " " + empleado.ApellidoPat.Trim() + " " + empleado.ApellidoMat.Trim();
            lblpreciomasiva.Text= datoscotizacion.PrecioInicial.ToString();

            //desgloce 
            lblidversion.Text = datoscotizacion.IDVersion;
            lblarticulo.Text = "NISSAN" + " " + datosvehiculo.Nombre + " " + datosversion.Version;
            lblcostover.Text = (datoscotizacion.PrecioInicial * .84).ToString();
        }

        private void TablaAmortizacionCon_Load(object sender, EventArgs e)
        {

        }
    }
}
