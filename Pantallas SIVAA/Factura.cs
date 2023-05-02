using Entidades;
using Logicas;
using Pantallas_SIVAA.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pantallas_SIVAA
{
    public partial class Factura : Form
    {
        readonly VentaLog PqteLog2 = new VentaLog();
        readonly ClienteLog PqteLog = new ClienteLog();
        readonly EmpleadoLog empleadoLog = new EmpleadoLog();
        readonly FacturaLOG facturaLOG = new FacturaLOG();
        private bool isFormBorderStyleNone = false;
        private bool isFormBorderStyleChanged = false;
        ModeloVersion datosModVer;
        public Factura(VentaContado pqtVC, Venta pdqV, string nombreclien, string apellidoclien, string idempleado)
        {
            InitializeComponent();

            CotizacionContado datoscotcredito = facturaLOG.ObtenerCotizacionContado(pqtVC.IDCotizacion);
            Entidades.Cotizacion datoscot = facturaLOG.ObtenerCotizacion(pqtVC.IDCotizacion);
            Cliente datoscliente = facturaLOG.ObtenerDatosCliente(datoscot.IDCliente);
            Empleado datosempleado = empleadoLog.LeerPorClave(pdqV.IDEmpleado);
            Entidades.VersionEntidad datosversion = facturaLOG.ObtenerDatosVersions(datoscot.IDVersion);
            Vehiculo datosvehiculo = facturaLOG.ObtenerDatosVehiculo(datosversion.IDVehiculo);
            datosModVer = facturaLOG.ObtenerModeloVersion(datosversion.IDVersion);
            Modelo datosmodelo = facturaLOG.ObtenerDatosModelo(datosModVer.IDModelo);
            //double subtotal = (pdqV.Subtotal * 0.84);
            //double iva = (pdqV.Subtotal * .16);
            double subtotal = Math.Round(pdqV.Subtotal / 1.16);
            double iva = Math.Round(subtotal * .16);
            label57.Text = subtotal.ToString();
            label56.Text = iva.ToString();
            label55.Text = (subtotal + iva).ToString();
            //*****
            label10.Text = pdqV.NoSerie.ToString();
            UnidadLog uni = new UnidadLog();
            Unidad un;
            un = uni.LeerPorClave(pdqV.NoSerie.ToString());
            lblcolor.Text = un.Color.ToString();
            lbldia.Text = pdqV.Dia.ToString();
            lblmes.Text = pdqV.Mes.ToString();
            lblano.Text = pdqV.Año.ToString();
            lblnombrec.Text = datoscliente.Nombre.Trim() + " " + datoscliente.ApellidoPat.Trim() + " " + datoscliente.ApellidoMat.Trim();
            lblrfc.Text = datoscliente.RFC.ToString();
            lbltelefono.Text = datoscliente.Telefono.ToString();
            lblcolonia.Text = datoscliente.Colonia.ToString();
            lblnoext.Text = datoscliente.NoExterior.ToString();
            lblciudad.Text = datoscliente.Ciudad.ToString();
            lblestado.Text = datoscliente.Estado.ToString();
            lblidclien.Text = datoscliente.IDCliente.ToString();
            lblempleado.Text = datosempleado.Nombre.Trim() + " " + datosempleado.ApellidoPat.Trim() + " " + datosempleado.ApellidoMat.Trim();
            lblsubtotal.Text = subtotal.ToString();
            lbliva.Text = iva.ToString();
            lbltotalgen.Text = (subtotal + iva).ToString();
            lblidversion.Text = datoscot.IDVersion.ToString();
            lblcostover.Text = datosversion.Costo.ToString();
            //lblcostover.Text = Math.Round(datosversion.Costo / 1.16).ToString();
            lblarticulo.Text += " " + datosvehiculo.Nombre + " " + datosversion.Version;
            lblmodelo.Text = datosmodelo.Año;
            lblnombre.Text = datosvehiculo.Nombre;
            lblversion.Text = datosversion.Version;
            lblrines.Text = datosversion.Rines;
            lblpuertas.Text = datosversion.NumPuertas;
            lblllanta.Text = datosversion.Llantas;
            lbltraccion.Text = datosversion.TipoTraccion;
            lblanchura.Text = datosversion.Anchura;
            lblaltura.Text = datosversion.Altura;
            lbldisejes.Text = datosversion.DistanciaEjes;
            lblcombus.Text = datosversion.TipoCombustible;
            lbltrans.Text = datosversion.Transmision;
            lblengra.Text = datosversion.NumEngranajes;
            lblsubtotalcant.Text = subtotal.ToString();
            lblivatotal.Text = iva.ToString();
            lbltotalcontgen.Text = (subtotal + iva).ToString();

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Size formSize = this.Size;
            float scaleX = e.MarginBounds.Width / (float)formSize.Width;
            float scaleY = e.MarginBounds.Height / (float)formSize.Height;
            float scale = Math.Min(scaleX, scaleY);
            int targetWidth = (int)(formSize.Width * scale);
            int targetHeight = (int)(formSize.Height * scale);
            Bitmap bitmap = new Bitmap(targetWidth, targetHeight, graphics);
            Graphics bitmapGraphics = Graphics.FromImage(bitmap);
            bitmapGraphics.CopyFromScreen(this.PointToScreen(Point.Empty), Point.Empty, formSize);
            e.Graphics.DrawImage(bitmap, e.MarginBounds);
            bitmap.Dispose();
            bitmapGraphics.Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Factura_Load(object sender, EventArgs e)
        {

        }

        private void Factura_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Crear un objeto PrintDocument
            pictureBox4.Hide();
            //Guardar el estado original de la propiedad "BorderStyle"
            isFormBorderStyleNone = this.FormBorderStyle == FormBorderStyle.None;
            isFormBorderStyleChanged = true;
            if (!isFormBorderStyleNone)
            {
                this.FormBorderStyle = FormBorderStyle.None;
            }


            printDocument1.Print();
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
            pictureBox4.Show();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bitmap, new Rectangle(0, 0, this.Width, this.Height));
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void c_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Factura_Load_1(object sender, EventArgs e)
        {

        }
    }

}
