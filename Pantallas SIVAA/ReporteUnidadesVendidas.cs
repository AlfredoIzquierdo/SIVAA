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
    public partial class ReporteUnidadesVendidas : Form
    {
        readonly ReportesLOG reportesLOG = new ReportesLOG();
        readonly VersionLog verlog = new VersionLog();
        readonly VehiculoLog vehiculoLog = new VehiculoLog();
        private bool isFormBorderStyleNone = false;
        private bool isFormBorderStyleChanged = false;

        public ReporteUnidadesVendidas(Empleado pqt, int diaI, int mesI, int AnoI, int diaF, int mesF, int AnoF, string opcion)
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

            //parte de abajo
            List<ReporteVehiculoMasVendido> vehiculosContado;
            List<ReporteVehiculoMasVendido> vehiculosCredito;
            List<ReporteVehiculoMasVendido> vehiculostotales;
            vehiculosContado = reportesLOG.listadoVehiculoMasVendidoContado(diaI, mesI, AnoI, diaF, mesF, AnoF, opcion);
            vehiculosCredito = reportesLOG.listadoVehiculoMasVendidoCredito(diaI, mesI, AnoI, diaF, mesF, AnoF, opcion);
            vehiculostotales = reportesLOG.listadoVehiculoMasVendidoTotal(diaI, mesI, AnoI, diaF, mesF, AnoF, opcion);
            foreach (ReporteVehiculoMasVendido x in vehiculostotales)
            {
               

                VersionEntidad datosversion = new VersionEntidad();
                Vehiculo datosvehiculo = new Vehiculo();
                ModeloVersion datosmodeloVersion = new ModeloVersion();
                Modelo datosmodelo = new Modelo();
                datosmodeloVersion = reportesLOG.ObtenerModeloVersion(x.IDVersion);
                datosversion = verlog.ObtenerPdtoPorID(x.IDVersion);
                datosvehiculo = vehiculoLog.LeerPorClave(datosversion.IDVehiculo);
                datosmodelo = reportesLOG.datosmodelo(datosmodeloVersion.IDModelo);
                dgvVehiculos.Rows.Add(x.IDVersion, datosvehiculo.Nombre, datosversion.Version, datosmodelo.Año, x.vecesVendido, reportesLOG.gananciasVersion(x.IDVersion));

            }


            //lblmejorvehiculo.Text = "Nissan " + dgvVehiculos.Rows[0].Cells[1].Value.ToString();
        }

        private void ReporteUnidadesVendidas_Load(object sender, EventArgs e)
        {
            dgvVehiculos.CurrentCell = null;
        }

        private void dgvVehiculos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

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
