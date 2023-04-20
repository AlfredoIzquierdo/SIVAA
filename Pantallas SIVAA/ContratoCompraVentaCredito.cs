using Entidades;
using Logicas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantallas_SIVAA
{
    public partial class ContratoCompraVentaCredito : Form
    {
        public ContratoCompraVentaCredito()
        {
            InitializeComponent();
        }
        readonly ClienteLog PqteLog = new ClienteLog();
        readonly EmpleadoLog empleadoLog = new EmpleadoLog();
        readonly VentaCreditoLog PqteLog33 = new VentaCreditoLog();
        readonly CompraventaLOG comvenLOG = new CompraventaLOG();
        private bool isFormBorderStyleNone = false;
        private bool isFormBorderStyleChanged = false;
        ModeloVersion datosModVer;
        public ContratoCompraVentaCredito(VentaCredito pqtventC, Venta pqtvent, string nombreclien, string apellidoclien)
        {
            InitializeComponent();
            Entidades.Cotizacion Cotizacion = comvenLOG.datoscotizacion(pqtventC.IDCotizacion);
            Entidades.CotizacionCredito cotizacion1 = comvenLOG.datoscotizacionCredito(pqtventC.IDCotizacion);
            Empleado empleado = empleadoLog.LeerPorClave(Cotizacion.IDEmpleado.ToString());
            Versions versiondoc = comvenLOG.datosversion(Cotizacion.IDVersion);
            datosModVer = comvenLOG.ObtenerModeloVersion(Cotizacion.IDVersion);
            Modelo modelo = comvenLOG.datosmodelo(datosModVer.IDModelo);
            Vehiculo vehiculo = comvenLOG.datosvehiculo(versiondoc.IDVehiculo);
            string Nombrecompleto = nombreclien.Trim() + " " + apellidoclien.Trim();
            lbltotalven.Text = pqtvent.Subtotal.ToString();
            lblnomclien.Text = Nombrecompleto;
            lblnomven.Text = empleado.Nombre.Trim() + " " + empleado.ApellidoPat.Trim() + " " + empleado.ApellidoMat.Trim();

            //DATOSVEHICULO
            lblanchura.Text = versiondoc.Anchura;
            lblaltura.Text = versiondoc.Altura;
            lblllanta.Text = versiondoc.Llantas;
            lblversion.Text = versiondoc.Version;
            lbltrans.Text = versiondoc.Transmision;
            lbltraccion.Text = versiondoc.TipoTraccion;
            lblrines.Text = versiondoc.Rines;
            lbldisejes.Text = versiondoc.DistanciaEjes;
            lblengra.Text = versiondoc.NumEngranajes;
            lblpuertas.Text = versiondoc.NumPuertas;
            lblcombus.Text = versiondoc.TipoCombustible;
            lblmodelo.Text = modelo.Año;
            lblnombre.Text = vehiculo.Nombre;
            //final
            lblenganche.Text = cotizacion1.Enganche.ToString();
            lblplazo.Text = cotizacion1.Plazo.ToString();

            lblclien2.Text = Nombrecompleto.ToString();
            lblnomven3.Text = empleado.Nombre.Trim() + " " + empleado.ApellidoPat.Trim() + " " + empleado.ApellidoMat.Trim();
            lbldia.Text = pqtvent.Dia.ToString();
            lblmes.Text = MesALetra(pqtvent.Mes.ToString());
            lblano.Text = pqtvent.Año.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Crear un objeto PrintDocument
            pictureBox1.Hide();
            //Guardar el estado original de la propiedad "BorderStyle"
            isFormBorderStyleNone = this.FormBorderStyle == FormBorderStyle.None;
            isFormBorderStyleChanged = true;
            if (!isFormBorderStyleNone)
            {
                this.FormBorderStyle = FormBorderStyle.None;
            }


            printDocument1.Print();

        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Crear un objeto Bitmap del tamaño del formulario
            Bitmap bm = new Bitmap(this.Width, this.Height);

            // Dibujar el contenido del formulario en el Bitmap
            this.DrawToBitmap(bm, new Rectangle(0, 0, this.Width, this.Height));

            // Dibujar el Bitmap en la página de impresión
            e.Graphics.DrawImage(bm, 0, 0);
        }
        private string MesALetra(string num)
        {
            if (num == "1")
            {
                return "Enero";
            }
            if (num == "2")
            {
                return "Febrero";
            }
            if (num == "3")
            {
                return "Marzo";
            }
            if (num == "4")
            {
                return "Abril";
            }
            if (num == "5")
            {
                return "Mayo";
            }
            if (num == "6")
            {
                return "Junio";

            }
            if (num == "7")
            {
                return "Julio";
            }
            if (num == "8")
            {
                return "Agosto";
            }
            if (num == "9")
            {
                return "Septiembre";
            }
            if (num == "10")
            {
                return "Octubre";
            }
            if (num == "11")
            {
                return "Noviembre";
            }
            if (num == "12")
            {
                return "Diciembre";
            }
            else
            {
                return num;
            }
        }

        private void printDocument1_BeginPrint(object sender, PrintEventArgs e)
        {
            printDocument1.DefaultPageSettings.Landscape = false;
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Letter", 850, 1100);
        }

        private void printDocument1_EndPrint(object sender, PrintEventArgs e)
        {
            // Restablecer el estado original de la propiedad "BorderStyle"
            if (isFormBorderStyleChanged)
            {
                this.FormBorderStyle = isFormBorderStyleNone ? FormBorderStyle.None : FormBorderStyle.FixedSingle;
            }
            pictureBox1.Show();
        }

        private void printDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bitmap, new Rectangle(0, 0, this.Width, this.Height));
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void ContratoCompraVentaCredito_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
