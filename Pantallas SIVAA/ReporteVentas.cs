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
    public partial class ReporteVentas : Form
    {
        readonly ReportesLOG reportesLOG = new ReportesLOG();
        readonly VentaContadoLog ventaContadoLog = new VentaContadoLog();
        readonly VentaCreditoLog ventaCreditoLog = new VentaCreditoLog();
        readonly EmpleadoLog empleadoLog = new EmpleadoLog();
        private bool isFormBorderStyleNone = false;
        private bool isFormBorderStyleChanged = false;
        public ReporteVentas(Empleado pqt, int diaI, int mesI, int AnoI, int diaF, int mesF, int AnoF, string opcion)
        {
            InitializeComponent();
            DateTime today = DateTime.Today;
            string diaAct = today.Day.ToString();
            string mesAct = today.Month.ToString();
            string anoAct = today.Year.ToString();
            Random rnd = new Random();
            int numeroAleatorio = rnd.Next(210000, 219001);

            lbldia.Text = diaAct;
            lblmes.Text = mesAct;
            lblano.Text = anoAct;
            lblnombrec.Text = pqt.Nombre.Trim() + " " + pqt.ApellidoPat.Trim() + " " + pqt.ApellidoMat.Trim();
            lblidempleado.Text = pqt.IDEmpleado.Trim();
            lblperiodo.Text = diaI.ToString() + "/" + mesI.ToString() + "/" + AnoI.ToString() + " --- " + diaF.ToString() + "/" + mesF.ToString() + "/" + AnoF.ToString();
            lblidcot.Text = numeroAleatorio.ToString();
            List<Venta> ventas = new List<Venta>();
            ventas = reportesLOG.ListadoVentas(diaI, mesI, AnoI, diaF, mesF, AnoF, opcion);
            //Parte de abajo
            foreach (Venta x in ventas)
            {
                Empleado empleadoact = new Empleado();
                empleadoact = empleadoLog.LeerPorClave(x.IDEmpleado);
                string nombrecompleto = empleadoact.Nombre.Trim() + " " + empleadoact.ApellidoPat.Trim() + " " + empleadoact.ApellidoMat.Trim();
                string fecha = x.Dia.ToString() + "/" + x.Mes.ToString() + "/" + x.Año.ToString();
                if (x.NoSerie == null)
                {

                }
                else
                {
                    dgvVentas.Rows.Add(x.IDVenta, nombrecompleto, x.NoSerie, fecha, x.Hora, x.TipoVenta, x.Subtotal);
                }

            }

        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {
            //ReporteVentaContado reporteVentaContado = new ReporteVentaContado();
            //reporteVentaContado.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            //ReporteVentaContado reporteVentaContado = new ReporteVentaContado();
            //reporteVentaContado.Show();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            //ReporteVentaCredito reporteVentaCredito = new ReporteVentaCredito();
            //reporteVentaCredito.Show();
        }

        private void ReporteVentas_Load_1(object sender, EventArgs e)
        {
            //paneles superiores al data

        }

        private void ReporteVentas_SizeChanged_1(object sender, EventArgs e)
        {
            ReporteVentas_Load_1(sender, e);
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            printDocument1.DefaultPageSettings.Landscape = false;
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Letter", 850, 1100);
        }

        private void printDocument1_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            // Restablecer el estado original de la propiedad "BorderStyle"
            if (isFormBorderStyleChanged)
            {
                this.FormBorderStyle = isFormBorderStyleNone ? FormBorderStyle.None : FormBorderStyle.FixedSingle;
            }
            pictureBox1.Show();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bitmap, new Rectangle(0, 0, this.Width, this.Height));
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
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
    }
}
